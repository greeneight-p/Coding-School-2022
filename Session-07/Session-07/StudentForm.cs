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

namespace Session_07 {
    public partial class StudentForm : Form {


        public StudentStorage StudentsStorage { get; set; }
        public List<Student> Students { get; set; }


        private Student _selectedStudent;
        private Student _originalStudent;


        #region
        public StudentForm() {
            InitializeComponent();
        }

        private void StudentForm_Load(object sender, EventArgs e) {

            Students = StudentsStorage.Students;
            UpdateStudentList();

        }

        private void buttonNew_Click(object sender, EventArgs e) {
            CreateStudent();
        }

        private void listBoxStudentStorage_SelectedIndexChanged(object sender, EventArgs e) {
            _selectedStudent = Students[listBoxStudentStorage.SelectedIndex];
            PrintStudentProps();
        }

        private void buttonSave_Click(object sender, EventArgs e) {
            _selectedStudent.Name = textBoxName.Text;
            _selectedStudent.Age = Convert.ToInt32(textBoxAge.Text);
            _selectedStudent.RegistrationNumber = Convert.ToInt32(textBoxRegNum.Text);
            ClearFields();
            UpdateStudentList();

        }
        #endregion



        private void UpdateStudentList() {
            listBoxStudentStorage.Items.Clear();
            int i = 1;
            foreach (Student item in Students) {
                listBoxStudentStorage.Items.Add($"[{i}] {item.Name}");
                i++;
            }

        }

        private void PrintStudentProps() {

            textBoxID.Text = _selectedStudent.PersonID.ToString();
            textBoxName.Text= _selectedStudent.Name;
            textBoxAge.Text = _selectedStudent.Age.ToString();
            textBoxRegNum.Text = _selectedStudent.RegistrationNumber.ToString();

        }

        public void CreateStudent() { 
            if(Students.Count < 30) {
                Student s = new Student()
                {
                    Name = "New Student",
                    Age = 0,
                    RegistrationNumber = 0
                };
                Students.Add(s);
                UpdateStudentList();
                listBoxStudentStorage.SelectedIndex = (Students.Count - 1); 
            }
            else {
                MessageBox.Show("Max Capacity Of Students Reached.!");
            }

        }


       
        private void ClearFields() {
            textBoxID.Text = string.Empty;
            textBoxName.Text = string.Empty;
            textBoxAge.Text = string.Empty;
            textBoxRegNum.Text = string.Empty;
        }

        private void buttonDelete_Click(object sender, EventArgs e) {
            if(_selectedStudent != null) {
                Students.Remove(_selectedStudent);
                _selectedStudent = null;
                UpdateStudentList();
                ClearFields();
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
