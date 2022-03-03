using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_03 {
    internal class Schedule {

        public Guid ScheduleID { get; set; }
        public Guid CourseID { get; set; }

        public Guid ProfessorID { get; set; }

        public DateTime Calendar { get; set; }



        public Schedule()
        {

        }
    }
}
