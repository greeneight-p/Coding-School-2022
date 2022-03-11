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

        public CourseForm() {
            InitializeComponent();
        }


    }
}
