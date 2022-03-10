using System;
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
        public ProfessorStorage  ProfStorage{ get; set; }

        public UniversityForm() {
            InitializeComponent();
        }

        private void UniversityForm_Load(object sender, EventArgs e) {
            ProfStorage = new University.ProfessorStorage(2);

            //var prof1 = new University.Professor()
            //{
            //    Name = "Nikos",
            //    Age = 33,
            //    Rank = "S"
            //};

            //var prof2 = new University.Professor()
            //{
            //    Name = "Giwrgos",
            //    Age = 37,
            //    Rank = "A"
            //};

            //ProfStorage.Professors[0] = prof1;
            //ProfStorage.Professors[1] = prof1;
        }

        private void buttonSave_Click(object sender, EventArgs e) {

            string json = new JavaScriptSerializer().Serialize(ProfStorage);
            File.WriteAllText(PROF_FILE_NAME, json);
            //textEditScreen.EditValue = json;

        }

        private void buttonLoad_Click(object sender, EventArgs e) {
           string s = File.ReadAllText(PROF_FILE_NAME);
            ProfStorage = (University.ProfessorStorage)new JavaScriptSerializer().Deserialize(s, typeof(University.ProfessorStorage));
            textEditScreen.EditValue = ProfStorage.Professors[0].Name;

        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e) {
            var professorForm = new ProfessorForm();
            professorForm.MdiParent = this;
            professorForm.ProfStorage = ProfStorage;
            professorForm.Show();

        }

        private void buttonShowProfessors_Click(object sender, EventArgs e) {
            if (ProfStorage.Professors[0] != null) {
                foreach (Professor item in ProfStorage.Professors) {
                    textBoxShow.Text += $"Prof:{item.Name}, \n";

                }
            }
            else {
                MessageBox.Show("XD");
            }
            

        }
    }
}
