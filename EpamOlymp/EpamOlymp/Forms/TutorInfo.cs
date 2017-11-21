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
    public partial class TutorInfo : Form
    {
        BindingSource pbindingSource = new BindingSource();
        TutorList tlist = new TutorList();
        StudPartList splist = new StudPartList();
        List<Tutor> temp = new List<Tutor>();
        public TutorInfo()
        {
            InitializeComponent();
        }

        private void TutorInfo_Load(object sender, EventArgs e)
        {
            try
            {
                tlist.Read();
            }
            catch { }
            try
            {
                splist.Read();
            }
            catch { }

            if (tlist.Length == 0)
            {
                MessageBox.Show("Список тренеров пуст");
                Close();
            }
            else
            {
                bindingSource1.DataSource = tlist.Tutors;
                bindingSource2.DataSource = tlist.Tutors.GroupBy(s => s.University).Select(g => g.First());
                temp = tlist.Tutors;
                comboBox1.SelectedIndex = -1;
                tlist.Write();
                splist.Write();
                listBox1.SelectedIndex = 0;
                Ref();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sname = textBox1.Text,
                   univer = comboBox1.Text,
                   dp = textBox3.Text;

            if (sname != "" && univer == "" && dp == "")
            {
                bindingSource1.DataSource = tlist.Tutors.Where(p => p.Surname == sname).ToList();
                temp = tlist.Tutors.Where(p => p.Surname == sname).ToList();
            }
            else if (sname == "" && univer != "" && dp == "")
            {
                bindingSource1.DataSource = tlist.Tutors.Where(p => p.University == univer).ToList();
                temp = tlist.Tutors.Where(p => p.University == univer).ToList();
            }
            else if (sname == "" && univer == "" && dp != "")
            {
                bindingSource1.DataSource = tlist.Tutors.Where(p => p.Department == dp).ToList();
                temp = tlist.Tutors.Where(p => p.Department == dp).ToList();
            }
            else if (sname != "" && univer != "" && dp == "")
            {
                bindingSource1.DataSource = tlist.Tutors.Where(p => p.University == univer && p.Surname == sname).ToList();
                temp = tlist.Tutors.Where(p => p.University == univer && p.Surname == sname).ToList();
            }
            else if (sname == "" && univer != "" && dp != "")
            {
                bindingSource1.DataSource = tlist.Tutors.Where(p => p.University == univer && p.Department == dp).ToList();
                temp = tlist.Tutors.Where(p => p.University == univer && p.Department == dp).ToList();
            }
            else if (sname != "" && univer == "" && dp != "")
            {
                bindingSource1.DataSource = tlist.Tutors.Where(p => p.Surname == sname && p.Department == dp).ToList();
                temp = tlist.Tutors.Where(p => p.Surname == sname && p.Department == dp).ToList();
            }
            else if (sname != "" && univer != "" && dp != "")
            {
                bindingSource1.DataSource = tlist.Tutors.Where(p => p.University == univer && p.Surname == sname && p.Department == dp).ToList();
                temp = tlist.Tutors.Where(p => p.University == univer && p.Surname == sname && p.Department == dp).ToList();
            }
            else
            {
                bindingSource1.DataSource = tlist.Tutors;
                temp = tlist.Tutors;
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
                textBox4.Text = temp[listBox1.SelectedIndex].Department;
                pbindingSource.DataSource = splist.Participations
                    .ConvertAll(x => new {
                        Surname = x.Tutor.Surname,
                        University = x.Tutor.University,
                        Department = x.Tutor.Department,
                        Student = x.Student.Suranme,
                        Olympiad = x.Olympiad.Name,
                        OlympiadType = x.Olympiad.Type,
                        OlympiadLocation = x.Olympiad.Location,
                        OlympiadYear = x.Year,
                        Stage = x.Stage,
                        Place = x.Place                        
                    })
                    .Where(x => x.Surname == temp[listBox1.SelectedIndex].Surname && x.University == temp[listBox1.SelectedIndex].University &&
                                x.Department == temp[listBox1.SelectedIndex].Department);
                dataGridView1.DataSource = pbindingSource;
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[1].Visible = false;
                dataGridView1.Columns[2].Visible = false;
            }
            catch {
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
            ExcelApp.Cells[1, 3] = "Кафедра";
            ExcelApp.Cells[1, 4] = "Студент";
            ExcelApp.Cells[1, 5] = "Олимпиада";
            ExcelApp.Cells[1, 6] = "Тип";
            ExcelApp.Cells[1, 7] = "Уровень";
            ExcelApp.Cells[1, 8] = "Год";
            ExcelApp.Cells[1, 9] = "Этап";
            ExcelApp.Cells[1, 10] = "Место";
            

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
