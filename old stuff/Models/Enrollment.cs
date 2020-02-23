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
        [Required(ErrorMessage = "Please list what days of the week this class is available")]
        [StringLength(500)]
        public string enrollmentName { get; set; }

        [Display(Name = "Enrollment Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime enrollmentDate { get; set; }
        // the next two properties link the Enrollment to the Student

        [Display(Name = "Course Name")]
        [Required(ErrorMessage = "Course name is required")]
        [StringLength(100)]
        public string courseName { get; set; }
        public virtual Course Course { get; set; }
        // the next two properties link the Enrollment to the Course

        [Display(Name = "Instructor Name")]
        public int instructorID { get; set; }
        public virtual Instructor Instructor { get; set; }
    }
}


  
