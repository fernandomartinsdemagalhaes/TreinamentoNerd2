using System.Diagnostics;

namespace Treinamantonerd2.Entities
{
    public class Student
    {
        public int StudentId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime DateOfBirth { get; set; }

        public decimal Height { get; set; }

        public float Weight { get; set; }


        #region Foreing Key do BD

        public Grade Grade { get; set; }

        public int GradeId { get; set; }

        #endregion



    }
}
