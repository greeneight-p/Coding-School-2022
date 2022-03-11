﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using University;

namespace Session_07 {
    public partial class UniversityForm : Form {

        private const string PROF_FILE_NAME = "professors.json";
        private const string STUD_FILE_NAME = "students.json";

        public ProfessorStorage  ProfStorage{ get; set; }
        public StudentStorage StudentStorage { get; set; }

        public UniversityForm() {
            InitializeComponent();
        }

        private void UniversityForm_Load(object sender, EventArgs e) {
            //ProfStorage = new University.ProfessorStorage(2);

           
        }

        private void buttonSave_Click(object sender, EventArgs e) {

            string json = new JavaScriptSerializer().Serialize(ProfStorage);
            File.WriteAllText(PROF_FILE_NAME, json);

            json = new JavaScriptSerializer().Serialize(StudentStorage);
            File.WriteAllText(STUD_FILE_NAME, json);


        }

        

        private void editToolStripMenuItem_Click(object sender, EventArgs e) {
            var professorForm = new ProfessorForm();
            //professorForm.MdiParent = this;
            //ProfStorage = new ProfessorStorage();
            //ProfStorage.Professors = new List<Professor>();
            professorForm.ProfStorage = ProfStorage;
            professorForm.ShowDialog();

        }



        private void saveToolStripMenuItem_Click(object sender, EventArgs e) {
            string json = new JavaScriptSerializer().Serialize(ProfStorage);
            File.WriteAllText(PROF_FILE_NAME, json);



            json = new JavaScriptSerializer().Serialize(StudentStorage);
            File.WriteAllText(STUD_FILE_NAME, json);

        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e) {

            string json =  File.ReadAllText(PROF_FILE_NAME);
            ProfStorage = (ProfessorStorage)new JavaScriptSerializer().Deserialize(json, typeof(ProfessorStorage));

            json = File.ReadAllText(STUD_FILE_NAME);
            StudentStorage = (StudentStorage)new JavaScriptSerializer().Deserialize(json, typeof(StudentStorage));
 

            MessageBox.Show("File Loaded Succefully");


            saveToolStripMenuItem.Enabled = true;

            var course = new Course("C#-101");
            //ProfStorage.Professors[0].AddC(course);
        }

        private void editToolStripMenuItem1_Click(object sender, EventArgs e) {
            
            var studentsForm = new StudentForm();

            studentsForm.StudentsStorage = StudentStorage;
            studentsForm.ShowDialog();
        }
    }
}
