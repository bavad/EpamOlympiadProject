using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpamOlymp.Model
{
    [Serializable]
    class Student
    {
        public string Suranme {get; set;}
        public string University { get; set; }
        public string Group { get; set; }

        public Student(string surname, string university, string group)
        {
            Suranme = surname;
            University = university;
            Group = group;            
        }
    }
}
