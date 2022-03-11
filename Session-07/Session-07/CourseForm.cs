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
    public partial class CourseForm : Form {
  

        public CourseStorage CourseStorage { get; set; }
        public List<Course> Courses { get; set; }

        private Course _selectedCourse;

        public CourseForm() {
            InitializeComponent();
        }

        private void CourseForm_Load(object sender, EventArgs e) {
            Courses = CourseStorage.Courses;
            UpdateCourseList();
        }
        private void listBoxCourseStorage_SelectedIndexChanged(object sender, EventArgs e) {
            _selectedCourse = Courses[listBoxCourseStorage.SelectedIndex];
            PrinCourseProps();
        }
        private void buttonSave_Click(object sender, EventArgs e) {
            _selectedCourse.Code = textBoxCode.Text;
            _selectedCourse.Subject = textBoxSubject.Text;
            ClearFields();
            UpdateCourseList();

        }

        private void buttonNew_Click(object sender, EventArgs e) {
            CreateCourse();
        }

        private void CreateCourse() {
            if(Courses.Count < 20) {
                Course c = new Course()
                {
                    Code = "New Course",
                    Subject = "New Course"
                };
                Courses.Add(c);
                UpdateCourseList();
                listBoxCourseStorage.SelectedIndex = (Courses.Count - 1);
            }
            else {
                MessageBox.Show("Max Capacity Of Courses Reached.!");
            }
        }

        private void PrinCourseProps() {
            textBoxID.Text = _selectedCourse.CourseID.ToString();
            textBoxCode.Text = _selectedCourse.Code;
            textBoxSubject.Text = _selectedCourse.Subject;
        }

        private void UpdateCourseList() {
            listBoxCourseStorage.Items.Clear();
            int i = 1;
            foreach (Course item in Courses) {
                listBoxCourseStorage.Items.Add($"[{i}]Course:  {item.Code}");
                i++;
            }
        }



        private void ClearFields() {
            textBoxID.Text = string.Empty;
            textBoxCode.Text = string.Empty;
            textBoxSubject.Text = string.Empty;
        }

        private void buttonCancel_Click(object sender, EventArgs e) {
            Close();
        }

        private void buttonDelete_Click(object sender, EventArgs e) {
            if(_selectedCourse != null){
                Courses.Remove(_selectedCourse);
                _selectedCourse = null;
                UpdateCourseList();
                ClearFields();
            }
        }
    }
}
