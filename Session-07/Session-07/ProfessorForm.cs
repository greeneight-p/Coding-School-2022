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
    public partial class ProfessorForm : Form {

        public ProfessorStorage ProfStorage { get; set; }
        public List<Professor> Professors { get; set; }


        private Professor _selectedProfessor;
        private Professor _originalProfessor;

        public ProfessorForm() {
            InitializeComponent();
        }

        private void ProfessorForm_Load(object sender, EventArgs e) {
            Professors = ProfStorage.Professors;
            UpdateProfessorsList();
 
        }


        private void listBoxProfStorage_SelectedIndexChanged(object sender, EventArgs e) {
            _selectedProfessor = Professors[listBoxProfStorage.SelectedIndex];

            PrintProfProps();
        }

        private void button1_Click(object sender, EventArgs e) {
            CreateProfessor();
        }


        private void buttonSave_Click(object sender, EventArgs e) {

            //_originalProfessor = _selectedProfessor.ShallowCopy();

            _selectedProfessor.Name = textBoxName.Text;
            _selectedProfessor.Age = Convert.ToInt32(textBoxAge.Text);
            _selectedProfessor.Rank = textBoxRank.Text.ToUpper();

            ClearFields();
            UpdateProfessorsList();
        }

        private void buttonCancel_Click(object sender, EventArgs e) {
            this.Close();
        }




        private void buttonDelete_Click(object sender, EventArgs e) {

            if(_selectedProfessor != null) {
                Professors.Remove(_selectedProfessor);
                _selectedProfessor = null;
                UpdateProfessorsList();
                ClearFields();
            }

        }

        private void buttonRevertFrontEnd_Click(object sender, EventArgs e) {
        
            PrintProfProps();
        }


        //to Revert den douleuei opws prepei. Afisa stn mesi to debugging !
        private void buttonRevert_Click(object sender, EventArgs e) {

            _selectedProfessor = _originalProfessor;

            PrintProfProps();
            UpdateProfessorsList();
            
        }

        private void CreateProfessor() {

            if (Professors.Count < 5) {
                Professor p = new Professor()
                {
                    Name = "New Professor",
                    Age = 0,
                    Rank = "B",

                };

                Professors.Add(p);
                UpdateProfessorsList();
                listBoxProfStorage.SelectedIndex = (Professors.Count - 1);
            }
            else {
                MessageBox.Show("Max Capacity Of Professors Reached.!");
            }
        }
        private void ClearFields() {
            textBoxID.Text = string.Empty;
            textBoxName.Text = string.Empty;
            textBoxAge.Text = string.Empty;
            textBoxRank.Text = string.Empty;
        }

        private void PrintProfProps() {

            textBoxID.Text = _selectedProfessor.PersonID.ToString();
            textBoxName.Text = _selectedProfessor.Name;
            textBoxAge.Text = _selectedProfessor.Age.ToString();
            textBoxRank.Text = _selectedProfessor.Rank;
        }

        private void UpdateProfessorsList() {
            listBoxProfStorage.Items.Clear();
            int i = 1;
            foreach (Professor item in Professors) {
                listBoxProfStorage.Items.Add($"[{i}] Dr. {item.Name}");
                i++;
            }

        }


        private void UpdateCourseList() {
            listBoxCourses.Items.Clear();


        }


    }
}
