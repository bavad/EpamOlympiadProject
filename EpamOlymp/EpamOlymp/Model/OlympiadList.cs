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
    class OlympiadList
    {
        List<Olympiad> olympiads = new List<Olympiad>();

        public List<Olympiad> Olympiads
        {
            get { return olympiads; }
            set { olympiads = value; }
        }

        public Olympiad this[int i]
        {
            get { return olympiads[i]; }
            set { olympiads[i] = value; }
        }
        public int Length
        {
            get { return olympiads.Count; }
        }

        public void Write()
        {
            BinaryFormatter binFormat = new BinaryFormatter();
            using (Stream fStream = new FileStream("olist.dat", FileMode.OpenOrCreate))
            {
                binFormat.Serialize(fStream, olympiads);
            }

        }

        public void Read()
        {
            BinaryFormatter binFormat = new BinaryFormatter();
            using (Stream fStream = new FileStream("olist.dat", FileMode.OpenOrCreate))
            {
                olympiads = (List<Olympiad>)binFormat.Deserialize(fStream);
            }

        }

        public void Add(Olympiad olympiad) 
        {
            olympiads.Add(olympiad);
        }
    }
}
