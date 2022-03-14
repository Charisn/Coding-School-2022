namespace Calc
{
        [Serializable]
        public class ProfessorInfo
        {

            public string ProfName { get; set; }

            public string ProfRank { get; set; }

            public string ProfCourses { get; set; }


            public ProfessorInfo()
            {
                ProfName = string.Empty;
                ProfRank = string.Empty;
                ProfCourses = string.Empty;
            }
            public ProfessorInfo ShallowCopy()
            {
                return (ProfessorInfo)MemberwiseClone();
            }

        }
        public class Manager
        {

        }

        public class ProfessorManager : Manager
        {

            public List<ProfessorInfo>? Professors { get; set; }

        public ProfessorManager() 
            {
                Professors = new List<ProfessorInfo>();
            }


            public ProfessorInfo AddProfessor()
            {

                return AddProfessor("{enter name}", "{enter rank}", "{enter course}");
        }

            public ProfessorInfo AddProfessor(string profName, string profRank, string profCourses)
            {

                ProfessorInfo professorInfo = new ProfessorInfo()
                {
                    ProfName = profName,
                    ProfRank = profRank,
                    ProfCourses = profCourses,
                };

                if (Professors != null)
                {
                Professors.Add(professorInfo);
                }
                return professorInfo;
            }

        }
    [Serializable]
    public class ProfessorList
    {
        public List<ProfessorInfo>? Professors { get; set; }
        public ProfessorList()
        {

        }
    }

}
