using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpamOlymp.Model
{
    [Serializable]
    class Olympiad
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Location { get; set; }

        public Olympiad(string name, string type, string location)
        {
            Name = name;
            Type = type;
            Location = location;
        }
    }
}
