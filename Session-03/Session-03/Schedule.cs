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
            ScheduleID = Guid.NewGuid();

            //Gia Datetime smr
            //Calendar = DateTime.Now;


            //Gia Datetime parse apo string mono imerominia
            //DateTime date2 = DateTime.Parse("10-3-2012");
            //Calendar = date2;


            //Gia Datetime parse apo string me sigkekrimeni wra
            //DateTime date2 = DateTime.Parse("10-3-2012 12:30 PM");
            // Calendar = date2;


        }
    }
}
