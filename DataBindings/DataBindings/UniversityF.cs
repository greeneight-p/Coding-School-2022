using System.IO;
using System.Text.Json;
using University;

namespace DataBindings {
    public partial class UniversityF : Form {
        public UniversityF() {
            InitializeComponent();
        }

        private const string FILE_SAVE = "save.json";

        private University.University _uni = new University.University();

        private void UniversityF_Load(object sender, EventArgs e) {
            saveToolStripMenuItem.Enabled = false;
            //var student = new Student() { Name="John", Age=23, RegNum=99 };
            //var professor = new Professor() { Name = "Jim", Age = 52, Rank = "S" };

            //_uni.Students.Add(student);
            //_uni.Professors.Add(professor);


        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e) {

            string json = JsonSerializer.Serialize(_uni);
            File.WriteAllText(FILE_SAVE, json);

        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e) {
            string json = File.ReadAllText(FILE_SAVE);
            _uni = (University.University)JsonSerializer.Deserialize(json, typeof(University.University));
            saveToolStripMenuItem.Enabled = true;

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e) {
            //var studentF = new StudentF();
            //studentF.University = _uni;
            //studentF.ShowDialog();
   
            var studentCountForm = new StudentCountForm();
            studentCountForm.University = _uni;
            studentCountForm.ShowDialog();
        }
    }
}