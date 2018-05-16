using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace mvcStudent.Models
{
    public class Student
    {

        //EF sets ID as the primary key


        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]

        public DateTime EnrollmentDate { get; set; }

        //Navigation property to hols related entities.
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}
