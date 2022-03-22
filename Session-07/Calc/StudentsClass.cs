using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    public class StudentInfo
    {

        public Guid RegistrationNumber { get; set; } 

        public string StudentCourses { get; set; }

        public string Name { get; set; }

        public string SureName { get; set; }



        public StudentInfo()
        {
            RegistrationNumber = Guid.Empty;
            StudentCourses = string.Empty;
        }
        public StudentInfo ShallowCopy()
        {
            return (StudentInfo)MemberwiseClone();
        }
        public class Manager
        {

        }

        public class StudentsManager : Manager
        {

            public List<StudentInfo>? Students { get; set; }

            public StudentsManager()
            {
                Students = new List<StudentInfo>();
            }


            public StudentInfo AddStudent()
            {

                return AddStudent(Guid.Empty, "{enter course}");
            }

            public StudentInfo AddStudent(Guid registrationNumber, string studentCourses)
            {

                StudentInfo studentInfo = new StudentInfo()
                {
                    RegistrationNumber = registrationNumber,
                    StudentCourses = studentCourses,
                };

                if (Students != null)
                {
                    Students.Add(studentInfo);
                }
                return studentInfo;
            }

        }
        [Serializable]
        public class StudentList
        {
            public List<StudentInfo>? Students { get; set; }
            public StudentList()
            {

            }
        }

    }


}

