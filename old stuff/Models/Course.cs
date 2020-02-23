using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace sg160815MIS4200.Models
{
    public class Course
    {
        [Key]
        public int courseID { get; set; }

        [Display(Name = "Course Name")]
        [Required(ErrorMessage ="Course Name is required")]
        [StringLength(50)]
       public string courseName { get; set; }

        [Display(Name = "Course Description")]
        [Required(ErrorMessage = "Course description is required")]
        [StringLength(400)]
        public string courseDescription { get; set; }

        [Display(Name = "Course Date and Time")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:MM/dd/yyyy}", ApplyFormatInEditMode =true)]
        public DateTime courseTime { get; set; }
        // add any other fields as appropriate
        //Order is on the "one" side of a one-to-many relationship with OrderDetail
        //and we indicate that with an ICollection
        public ICollection<Enrollment> Enrollment { get; set; }
        //Order is on the Many side of the one-to-many relation between Customer
        //and Order and we represent that relationship like this
        
        public int studentID { get; set; }
        public virtual Student Student { get; set; }
    }
}