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
    public partial class AddTutor : Form
    {
        TutorList tlist = new TutorList();
        public AddTutor()
        {
            InitializeComponent();
        }

        private void Clear()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }     
              

        private void AddTutor_Load(object sender, EventArgs e)
        {
            try
            {
                tlist.Read();
            }
            catch (Exception)
            {

            }
        }

        private void addTut_Click(object sender, EventArgs e)
        {
            tlist.Add(new Tutor(textBox1.Text, textBox2.Text, textBox3.Text));
            DialogResult = DialogResult.OK;
            tlist.Write();
            Clear();
            Close();
        }    
    }
}
