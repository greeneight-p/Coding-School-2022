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
        public ProfessorForm() {
            InitializeComponent();
        }

        private void ProfessorForm_Load(object sender, EventArgs e) {
            textBoxProfScreen.Text = ProfStorage.Professors[0].Name;
            ProfStorage.Professors[0].Name = "Giannis";
            var x = new UniversityForm();
            x.ProfStorage = ProfStorage;

        }
    }
}
