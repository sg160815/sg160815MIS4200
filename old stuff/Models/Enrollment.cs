using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sg160815MIS4200.Models
{
    public class Enrollment
    {
        public int enrollmentID { get; set; }
        public string enrollmentName { get; set; }
        public string enrollmentDescription { get; set; }
        public DateTime enrollmentTime { get; set; }
        // the next two properties link the orderDetail to the Order
        public virtual Course Course { get; set; }
        // the next two properties link the orderDetail to the Product
        public int instructorID { get; set; }

        public virtual Instructor Instructor { get; set; }
    }
}


  
