using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpamOlymp.Model
{
    [Serializable]
    class StudentParticipation
    {
        public Student Student { get; set; }
        public Tutor Tutor { get; set; }
        public Olympiad Olympiad { get; set; }
        public int Year { get; set; }
        public string Stage { get; set; }
        public int Place { get; set; }

        public StudentParticipation(Student student, Tutor tutor, Olympiad olympiad, int year, string stage, int place)
        {
            Student = student;
            Tutor = tutor;
            Olympiad = olympiad;
            Year = year;
            Stage = stage;
            Place = place;
        }
    }
}
