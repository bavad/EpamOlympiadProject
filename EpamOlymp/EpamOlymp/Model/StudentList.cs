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
    class StudentList
    {
        List<Student> students = new List<Student>();

        public List<Student> Students
        {
            get { return students; }
            set { students = value; }
        }

        public Student this[int i] 
        {
            get { return students[i]; }
            set { students[i] = value; }
        }
        public int Length  
        {
            get { return students.Count; }
        }

        public void Write() 
        {
            BinaryFormatter binFormat = new BinaryFormatter();
            using (Stream fStream = new FileStream("slist.dat", FileMode.OpenOrCreate))
            {
                binFormat.Serialize(fStream, students);
            }

        }

        public void Read() 
        {
            BinaryFormatter binFormat = new BinaryFormatter();
            using (Stream fStream = new FileStream("slist.dat", FileMode.OpenOrCreate))
            {
                students = (List<Student>)binFormat.Deserialize(fStream);
            }

        }

        public void Add(Student student) 
        {
            students.Add(student);
        }
        
    }
}
