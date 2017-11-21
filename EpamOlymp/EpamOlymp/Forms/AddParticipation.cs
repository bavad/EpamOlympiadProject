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
    public partial class AddParticipation : Form
    {
        OlympiadList olist = new OlympiadList();
        StudentList slist = new StudentList();
        TutorList tlist = new TutorList();
        StudPartList splist = new StudPartList();
        public AddParticipation()
        {
            InitializeComponent();
        }

        private void Clear()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;
            comboBox4.SelectedIndex = -1;
        }

        private void AddParticipation_Load(object sender, EventArgs e)
        {
            try
            {
                splist.Read();
            }
            catch { }
            try
            {
                olist.Read();
            } catch { }
            try
            {
                slist.Read();
            }
            catch { }
            try
            {
                tlist.Read();
            }
            catch { }

            
            bindingSource1.DataSource = olist.Olympiads;
            bindingSource2.DataSource = slist.Students;
            bindingSource3.DataSource = tlist.Tutors;
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;
            comboBox4.SelectedIndex = -1;
            olist.Write();
            slist.Write();
            tlist.Write();     
                       
        }

        private void button1_Click(object sender, EventArgs e)
        {
            splist.Add(new StudentParticipation(slist[comboBox2.SelectedIndex], tlist[comboBox3.SelectedIndex], olist[comboBox1.SelectedIndex], Int32.Parse(textBox1.Text), comboBox4.Text,Int32.Parse(textBox2.Text)));
            DialogResult = DialogResult.OK;
            splist.Write();
            Clear();
            Close();
        }
    }
}
