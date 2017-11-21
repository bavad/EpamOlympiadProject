using EpamOlymp.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EpamOlymp.Forms
{
    [Serializable]
    public partial class StudentInfo : Form
    {
        BindingSource pbindingSource = new BindingSource();
        StudentList slist = new StudentList();
        StudPartList splist = new StudPartList();
        List<Student> temp = new List<Student>();

        public StudentInfo()
        {
            InitializeComponent();
        }

        private void StudentInfo_Load(object sender, EventArgs e)
        {
            try
            {
                slist.Read();
            }
            catch { }
            try
            {
                splist.Read();
            }
            catch { }

            if (slist.Length == 0)
            {
                MessageBox.Show("Список студентов пуст");
                Close();
            }
            else
            {
                studentBindingSource.DataSource = slist.Students;
                bindingSource1.DataSource = slist.Students.GroupBy(s => s.University).Select(g => g.First());
                temp = slist.Students;
                comboBox1.SelectedIndex = -1;
                slist.Write();
                splist.Write();
                listBox1.SelectedIndex = 0;
                Ref();             

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sname = textBox1.Text,
                   univer = comboBox1.Text,
                   gr = textBox3.Text;

            if (sname != "" && univer == "" && gr == "")
            {
                studentBindingSource.DataSource = slist.Students.Where(p => p.Suranme == sname).ToList();
                temp = slist.Students.Where(p => p.Suranme == sname).ToList();
            }
            else if (sname == "" && univer != "" && gr == "")
            {
                studentBindingSource.DataSource = slist.Students.Where(p => p.University == univer).ToList();
                temp = slist.Students.Where(p => p.University == univer).ToList();
            }
            else if (sname == "" && univer == "" && gr != "")
            {
                studentBindingSource.DataSource = slist.Students.Where(p => p.Group == gr).ToList();
                temp = slist.Students.Where(p => p.Group == gr).ToList();
            }
            else if (sname != "" && univer != "" && gr == "")
            {
                studentBindingSource.DataSource = slist.Students.Where(p => p.University == univer && p.Suranme == sname).ToList();
                temp = slist.Students.Where(p => p.University == univer && p.Suranme == sname).ToList();
            }
            else if (sname == "" && univer != "" && gr != "")
            {
                studentBindingSource.DataSource = slist.Students.Where(p => p.University == univer && p.Group == gr).ToList();
                temp = slist.Students.Where(p => p.University == univer && p.Group == gr).ToList();
            }
            else if (sname != "" && univer == "" && gr != "")
            {
                studentBindingSource.DataSource = slist.Students.Where(p => p.Suranme == sname && p.Group == gr).ToList();
                temp = slist.Students.Where(p => p.Suranme == sname && p.Group == gr).ToList();
            }
            else if (sname != "" && univer != "" && gr != "")
            {
                studentBindingSource.DataSource = slist.Students.Where(p => p.University == univer && p.Suranme == sname && p.Group == gr).ToList();
                temp = slist.Students.Where(p => p.University == univer && p.Suranme == sname && p.Group == gr).ToList();
            }
            else
            {
                studentBindingSource.DataSource = slist.Students;
                temp = slist.Students;
            }
            Ref();               


        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Ref();            
            
        }

        private void Ref()
        {
            try
            {
                textBox2.Text = temp[listBox1.SelectedIndex].University;
                textBox4.Text = temp[listBox1.SelectedIndex].Group;
                pbindingSource.DataSource = splist.Participations
                    .ConvertAll(x => new { Surname = x.Student.Suranme, University = x.Student.University, Group = x.Student.Group,
                                           Olympiad = x.Olympiad.Name, OlympiadType = x.Olympiad.Type,
                                           OlympiadLocation = x.Olympiad.Location, OlympiadYear = x.Year,
                                           Stage = x.Stage, Place = x.Place, Tutor = x.Tutor.Surname})
                    .Where(x => x.Surname == temp[listBox1.SelectedIndex].Suranme && x.University == temp[listBox1.SelectedIndex].University &&
                                x.Group == temp[listBox1.SelectedIndex].Group);
                dataGridView1.DataSource = pbindingSource;
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[1].Visible = false;
                dataGridView1.Columns[2].Visible = false;
            }
            catch
            {
                textBox2.Text = "";
                textBox4.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {            
            Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
            ExcelApp.Application.Workbooks.Add(Type.Missing);
            ExcelApp.Columns.ColumnWidth = 15;

            ExcelApp.Cells[1, 1] = "Фамилия";
            ExcelApp.Cells[1, 2] = "Университет";
            ExcelApp.Cells[1, 3] = "Группа";
            ExcelApp.Cells[1, 4] = "Олимпиада";
            ExcelApp.Cells[1, 5] = "Тип";
            ExcelApp.Cells[1, 6] = "Уровень";
            ExcelApp.Cells[1, 7] = "Год";
            ExcelApp.Cells[1, 8] = "Этап";
            ExcelApp.Cells[1, 9] = "Место";
            ExcelApp.Cells[1, 10] = "Тренер";

            for (int i = 0; i < dataGridView1.ColumnCount; ++i)
            {
                for (int j = 0; j < dataGridView1.RowCount; ++j)
                {
                    ExcelApp.Cells[j + 2, i + 1] = (dataGridView1[i, j].Value).ToString() + ".";
                }
            }
            ExcelApp.Visible = true;
        }
    }
}
