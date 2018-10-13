using System;
using System.Collections.Generic;
using System.Text;

namespace School
{
    enum TypeOfTransport
    {
        Bus,
        Own

    }

    class Student    {

        private static int lastStudentId = 0;

        #region Properties

        /// <summary>
        /// defining properties for the Student Class
        /// </summary>
        public int StudentId { get;  }
        public String StudentName { get; set; }
        public int StudentGrade { get; set; }
        public TypeOfTransport Transport { get; set; }
        
        //public String TeacherName { get; set; }
        public int Scores { get; set; }

        public DateTime Startdate { get; set; }

        public Teacher TeacherName { get; set; }

        #endregion

        #region Constructor
        public Student()
        {
            Startdate = DateTime.Now;
            StudentId = ++lastStudentId;
        }


    
    
        #endregion


    }
}
