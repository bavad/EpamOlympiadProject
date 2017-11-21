using EpamOlymp.Forms;
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

namespace EpamOlymp
{
    [Serializable]
    public partial class Form1 : Form
    {
        StudentList slist = new StudentList();
        AddStudent addStudent = new AddStudent();
        AddTutor addTutor = new AddTutor();
        AddOlympiad addOlympiad = new AddOlympiad();
        AddParticipation addParticipation = new AddParticipation();
        StudentInfo studInfo = new StudentInfo();
        TutorInfo tutInfo = new TutorInfo();
        OlympiadInfo olyInfo = new OlympiadInfo();
        public Form1()
        {
            InitializeComponent();
            Text = "Olympiads";
        }

        private void добавитьСтудентаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (slist.Length != 0)
            {                
                slist.Write();
            }
            addStudent.ShowDialog();
            slist.Read();
        }

        private void студентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            studInfo.ShowDialog();
        }

        private void добавитьТренераToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addTutor.ShowDialog();
        }

        private void тренерыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tutInfo.ShowDialog();
        }

        private void добавитьОлимпиадуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addOlympiad.ShowDialog();
        }

        private void олимпиадыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            olyInfo.ShowDialog();
        }

        private void добавитьУчастиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addParticipation.ShowDialog();
        }
    }
}
