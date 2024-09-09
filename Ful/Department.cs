using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ful
{
    public class Department 
    {
        public FacultyOfEducation FacultyOfEducation { get; set; }
        public FacultyOfArtsAndSocialScience facultyOfArtsAndSocialScience { get; set; }
        public FacultyOfArts FacultyOfArts { get; set; }
        public FacultyOfEngineering FacultyOfEngineering { get; set; }  
        public FacultyOfSocialScience SocialScience { get; set; }

        public object Departments()
        {
            return FacultyOfArts.department1;

        }
        private object Dept()
        {
            return FacultyOfEducation.department2;
        }

    }
   
    //public Department()
    //{

    //}
}

//private static Guid GenerateRandomId() =>
    //Guid.NewGuid();

//private static int GenerateRandomNumber() =>
  //  IntRange()
