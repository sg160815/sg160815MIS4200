using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace sg160815MIS4200.Models
{
    public class Instructor
    {

        public int instructorID { get; set; }
        [Display(Name = "Instructor Name")]
        [Required(ErrorMessage = "Instructor name is required")]
        [StringLength(100)]
        public string instructorName { get; set; }
        [Display(Name = "Instructor Bio")]
        [Required(ErrorMessage = "Instructor bio is required")]
        [StringLength(400)]
        public string instructorBio { get; set; }
        // add any other fields as appropriate
        //Product is on the "one" side of a one-to-many relationship with OrderDetail
        //we indicate that with an ICollection
        public ICollection<Course> Course { get; set; }
    }
}