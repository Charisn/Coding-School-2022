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

            public List<ProfessorInfo> ProfName { get; set; }
            public List<ProfessorInfo> ProfRank { get; set; }
            public List<ProfessorInfo> ProfCourses { get; set; }

            public ProfessorManager()
            {
                ProfName = new List<ProfessorInfo>();
                ProfCourses = new List<ProfessorInfo>();
                ProfRank = new List<ProfessorInfo>();
            }


            public ProfessorInfo AddProfessor()
            {

                return AddProfessor("{enter name}");
        }

            public ProfessorInfo AddProfessor(string profName)
            {

            return AddProfessor(profName);
            }

            public ProfessorInfo AddProfessor(string profName, string profRank, string profCourses)
            {

                ProfessorInfo professorInfo = new ProfessorInfo()
                {
                    ProfName = profName,
                    ProfRank = profRank,
                    ProfCourses = profCourses,
                };

                ProfName.Add(professorInfo);

                return professorInfo;
            }

        }

    }
