﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoretutorials
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
