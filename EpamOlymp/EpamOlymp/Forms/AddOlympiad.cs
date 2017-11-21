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
    public partial class AddOlympiad : Form
    {
        OlympiadList olist = new OlympiadList();
        public AddOlympiad()
        {
            InitializeComponent();
        }

        private void Clear()
        {
            textBox1.Text = "";
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
        }

        private void AddOlympiad_Load(object sender, EventArgs e)
        {
            try
            {
                olist.Read();
            }
            catch (Exception)
            {

            }
        }

        private void addOly_Click(object sender, EventArgs e)
        {
            olist.Add(new Olympiad(textBox1.Text, comboBox2.Text, comboBox1.Text));
            DialogResult = DialogResult.OK;
            olist.Write();
            Clear();
            Close();
        }
    }
}
