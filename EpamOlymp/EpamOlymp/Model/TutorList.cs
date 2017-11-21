using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace EpamOlymp.Model
{
    [Serializable]
    class TutorList
    {
        List<Tutor> tutors = new List<Tutor>();

        public List<Tutor> Tutors
        {
            get { return tutors; }
            set { tutors = value; }
        }

        public Tutor this[int i]
        {
            get { return tutors[i]; }
            set { tutors[i] = value; }
        }
        public int Length
        {
            get { return tutors.Count; }
        }

        public void Write()
        {
            BinaryFormatter binFormat = new BinaryFormatter();
            using (Stream fStream = new FileStream("tlist.dat", FileMode.OpenOrCreate))
            {
                binFormat.Serialize(fStream, tutors);
            }

        }

        public void Read()
        {
            BinaryFormatter binFormat = new BinaryFormatter();
            using (Stream fStream = new FileStream("tlist.dat", FileMode.OpenOrCreate))
            {
                tutors = (List<Tutor>)binFormat.Deserialize(fStream);
            }

        }

        public void Add(Tutor tutor) 
        {
            tutors.Add(tutor);
        }
    }
}
