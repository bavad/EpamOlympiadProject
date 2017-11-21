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
    class StudPartList
    {
        List<StudentParticipation> participations = new List<StudentParticipation>();

        public List<StudentParticipation> Participations
        {
            get { return participations; }
            set { participations = value; }
        }

        public StudentParticipation this[int i]
        {
            get { return participations[i]; }
            set { participations[i] = value; }
        }
        public int Length
        {
            get { return participations.Count; }
        }

        public void Write()
        {
            BinaryFormatter binFormat = new BinaryFormatter();
            using (Stream fStream = new FileStream("splist.dat", FileMode.OpenOrCreate))
            {
                binFormat.Serialize(fStream, participations);
            }

        }

        public void Read()
        {
            BinaryFormatter binFormat = new BinaryFormatter();
            using (Stream fStream = new FileStream("splist.dat", FileMode.OpenOrCreate))
            {
                participations = (List<StudentParticipation>)binFormat.Deserialize(fStream);
            }

        }

        public void Add(StudentParticipation participation)
        {
            participations.Add(participation);
        }
    }
}
