using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sg160815MIS4200.Models
{
    public class Instructor
    {
        public int instructorID { get; set; }
        public string instructorName { get; set; }
        public string instructorBio { get; set; }
        // add any other fields as appropriate
        //Product is on the "one" side of a one-to-many relationship with OrderDetail
        //we indicate that with an ICollection
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}