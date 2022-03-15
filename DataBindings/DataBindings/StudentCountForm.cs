using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBindings {
    public partial class StudentCountForm : Form {
        public StudentCountForm() {
            InitializeComponent();
        }
        public University.University University { get; set; }


        private void StudentCountForm_Load(object sender, EventArgs e) {
            buttonOpen.Enabled = false;

            UpdateList();
            

            bsStudents.DataSource = University.Students;
            gridControl1.DataSource = bsStudents;

        }

        private void UpdateList() {
            listBoxStudents.Items.Clear();
            foreach (var item in University.Students) {
                listBoxStudents.Items.Add(item.Name);

            }
            listBoxStudents.SelectedIndex = 0;

        }

        private void buttonOpen_Click(object sender, EventArgs e) {
            var studentF = new StudentF();
            studentF.Student = University.Students[listBoxStudents.SelectedIndex];
            studentF.ShowDialog();
            buttonOpen.Enabled=false;

        }

        private void buttonUpdate_Click(object sender, EventArgs e) {
            UpdateList();
            buttonOpen.Enabled = true;
        }


    }
}
