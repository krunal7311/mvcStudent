using System;
namespace mvcStudent.Models
{
    public enum Grade
    {
        A, B, C, D, F
    }
    public class Enrollment
    {

        //EnrollmentID will be the primary key. EF uses classnameID to identify the primary key or just ID. 
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        public Grade? Grade { get; set; }

        public virtual Course Course { get; set; }
        public virtual Student Student { get; set; }
    }
}
