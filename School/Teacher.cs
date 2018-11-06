using System;
using System.Collections.Generic;
using System.Text;

namespace School
{
    class Teacher
    {
        

        ///Define Properties
        ///
        #region Properties

        public int TeacherId { get; set; }
        public String TeacherName1 { get; set; }
        public DateTime StartDate    { get; set; }
        public decimal Salary { get; set; }

        


        #endregion

        #region Constructor
        public Teacher()
        {
            StartDate = DateTime.Now;
        }
        //Constructor
        public Teacher(String name)
        {
            this.TeacherName1 = name;
        }
        #endregion

    }

}
