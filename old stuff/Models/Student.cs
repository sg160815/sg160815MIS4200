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
        public string studentFirstName { get; set; }

        [Display(Name = "Last Name")]
        public string studentLastName { get; set; }

        [Display(Name = "Email")]
        public string email { get; set; }

        [Display(Name = "Phone Number")]
        public string phone { get; set; }
        public DateTime studentSince { get; set; }
        public ICollection<Enrollment> Enrollment { get; set; }
        public string fullName { 
            get
            {
                return studentLastName + ", " + studentFirstName;
            } 
                }
    }
}