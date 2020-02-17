using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sg160815MIS4200.Models
{
    public class Enrollment
    {
        public int enrollmentID { get; set; }
        [Display(Name = "Class Dates")]
        public string enrollmentName { get; set; }

        [Display(Name = "Enrollment Date")]
        public DateTime enrollmentDate { get; set; }
        // the next two properties link the orderDetail to the Order

        [Display(Name = "Course Name")]
        public string courseName { get; set; }
        public virtual Course Course { get; set; }
        // the next two properties link the orderDetail to the Product
        
        [Display(Name = "Instructor Name")]
        public int instructorID { get; set; }
        public virtual Instructor Instructor { get; set; }
    }
}


  
