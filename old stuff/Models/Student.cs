using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace sg160815MIS4200.Models
{
    public class Student
    {

        
        public int studentID { get; set; }

        [Display(Name = "First Name")]
        [Required(ErrorMessage = "Student first name is required")]
        [StringLength(20)]
        public string studentFirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Student last name is required")]
        [StringLength(20)]
        public string studentLastName { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "Student email is required")]
        [StringLength(30)]
        public string email { get; set; }

        [Display(Name = "Phone Number")]
        [Required(ErrorMessage = "Phone number is required")]
        [StringLength(30)]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^(\(\d{3}\) |\d{3}-)/d{3}-\d{4}$", ErrorMessage ="Phone numbers must be in the format (xxx) xxx-xxxx or xxx-xxx-xxxx")]
        public string phone { get; set; }

        [Display(Name = "Enrolled Since")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime studentSince { get; set; }
        public ICollection<Enrollment> Enrollment { get; set; }

        [Display(Name = "Student Full Name")]
        [Required(ErrorMessage = "Student full name is required")]
        [StringLength(30)]
        public string fullName { 
            get
            {
                return studentLastName + ", " + studentFirstName;
            } 
                }
    }
}