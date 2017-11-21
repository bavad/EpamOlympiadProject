using EpamOlymp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EpamOlymp.Forms
{
    [Serializable]
    public partial class AddStudent : Form
    {
        StudentList slist = new StudentList();
        public AddStudent()
        {
            InitializeComponent();
        }

        private void Clear() 
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";            
        }

        private void AddStudent_Load(object sender, EventArgs e)
        {
            try
            {
                slist.Read();
            }
            catch (Exception)
            {

            }
        }

        private void addStud_Click(object sender, EventArgs e)
        {
            slist.Add(new Student(textBox1.Text, textBox2.Text, textBox3.Text));
            DialogResult = DialogResult.OK;
            slist.Write();
            Clear();
            Close();
        }
    }
}
