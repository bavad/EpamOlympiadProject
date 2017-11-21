using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpamOlymp.Model
{
    [Serializable]
    class Tutor
    {
        public string Surname { get; set; }
        public string University { get; set; }
        public string Department { get; set; }

        public Tutor(string surname, string university, string department)
        {
            Surname = surname;
            University = university;
            Department = department;
        }
    }
}
