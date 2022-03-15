using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using University;

namespace DataBindings {
    public partial class StudentF : Form {
        public StudentF() {
            InitializeComponent();
        }

        public University.University University {get; set;}
        public Student Student { get; set;}  


        private void StudentF_Load(object sender, EventArgs e) {

            //var course = new Course() { Code = "0001", Subject="C Sharp" };
            //var student = new Student() {Name="Nick", Age=22};
            //student.Courses.Add(course);
            //University.Students.Add(student);

            //bsStudents.DataSource = University.Students;
            //gridStudents.DataSource = bsStudents;

            //bsCourses.DataSource = University.Students;
            //bsCourses.DataMember = "Courses";

            labelID.Text = "Student ID: "+ Student.ID;
            bsStudents.DataSource = Student;
            gridStudents.DataSource = bsStudents;


            bsCourses.DataSource = bsStudents; 
            bsCourses.DataMember = "Courses";
            gridControlCourses.DataSource = bsCourses;



        }

        
    }
}

