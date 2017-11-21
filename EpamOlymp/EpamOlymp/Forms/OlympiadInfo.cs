using EpamOlymp.Model;
using System;
using System.Collections;
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
    public partial class OlympiadInfo : Form
    {
        BindingSource pbindingSource = new BindingSource();
        OlympiadList olist = new OlympiadList();
        StudPartList splist = new StudPartList();
        List<Olympiad> temp = new List<Olympiad>();
        IEnumerable templ;
        public OlympiadInfo()
        {
            InitializeComponent();
        }

        private void OlympiadInfo_Load(object sender, EventArgs e)
        {
            try
            {
                olist.Read();
            }
            catch { }
            try
            {
                splist.Read();
            }
            catch { }

            if (olist.Length == 0)
            {
                MessageBox.Show("Список олимпиад пуст");
                Close();
            }
            else
            {
                bindingSource1.DataSource = olist.Olympiads;                
                temp = olist.Olympiads;
                comboBox1.SelectedIndex = -1;
                comboBox2.SelectedIndex = -1;
                olist.Write();
                splist.Write();
                listBox1.SelectedIndex = 0;
                Ref();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string oname = textBox1.Text,
                   type = comboBox1.Text,
                   loclevel = comboBox2.Text;

            if (oname != "" && type == "" && loclevel == "")
            {
                bindingSource1.DataSource = olist.Olympiads.Where(p => p.Name == oname).ToList();
                temp = olist.Olympiads.Where(p => p.Name == oname).ToList();
            }
            else if (oname == "" && type != "" && loclevel == "")
            {
                bindingSource1.DataSource = olist.Olympiads.Where(p => p.Type == type).ToList();
                temp = olist.Olympiads.Where(p => p.Type == type).ToList();
            }
            else if (oname == "" && type == "" && loclevel != "")
            {
                bindingSource1.DataSource = olist.Olympiads.Where(p => p.Location == loclevel).ToList();
                temp = olist.Olympiads.Where(p => p.Location == loclevel).ToList();
            }
            else if (oname != "" && type != "" && loclevel == "")
            {
                bindingSource1.DataSource = olist.Olympiads.Where(p => p.Type == type && p.Name == oname).ToList();
                temp = olist.Olympiads.Where(p => p.Type == type && p.Name == oname).ToList();
            }
            else if (oname == "" && type != "" && loclevel != "")
            {
                bindingSource1.DataSource = olist.Olympiads.Where(p => p.Type == type && p.Location == loclevel).ToList();
                temp = olist.Olympiads.Where(p => p.Type == type && p.Location == loclevel).ToList();
            }
            else if (oname != "" && type == "" && loclevel != "")
            {
                bindingSource1.DataSource = olist.Olympiads.Where(p => p.Name == oname && p.Location == loclevel).ToList();
                temp = olist.Olympiads.Where(p => p.Name == oname && p.Location == loclevel).ToList();
            }
            else if (oname != "" && type != "" && loclevel != "")
            {
                bindingSource1.DataSource = olist.Olympiads.Where(p => p.Type == type && p.Name == oname && p.Location == loclevel).ToList();
                temp = olist.Olympiads.Where(p => p.Type == type && p.Name == oname && p.Location == loclevel).ToList();
            }
            else
            {
                bindingSource1.DataSource = olist.Olympiads;
                temp = olist.Olympiads;
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
                templ = splist.Participations
                    .ConvertAll(x => new {
                        Olympiad = x.Olympiad.Name,
                        Surname = x.Student.Suranme,
                        University = x.Student.University,
                        Group = x.Student.Group,
                        Tutor = x.Tutor.Surname,
                        TutorUniversity = x.Tutor.University,
                        TutorDepartment = x.Tutor.Department,
                        OlympiadYear = x.Year,
                        Stage = x.Stage,
                        Place = x.Place

                    })
                    .Where(x => x.Olympiad == temp[listBox1.SelectedIndex].Name);
                textBox3.Text = temp[listBox1.SelectedIndex].Type;
                textBox2.Text = temp[listBox1.SelectedIndex].Location;
                pbindingSource.DataSource = templ;
                dataGridView1.DataSource = pbindingSource;
                dataGridView1.Columns[0].Visible = false;                
            }
            catch
            {
                textBox3.Text = "";
                textBox2.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string yr = textBox4.Text,
                   st = comboBox3.Text;

            if (yr != "" && st == "")
            {
                pbindingSource.DataSource = splist.Participations
                    .ConvertAll(x => new {
                        Olympiad = x.Olympiad.Name,
                        Surname = x.Student.Suranme,
                        University = x.Student.University,
                        Group = x.Student.Group,
                        Tutor = x.Tutor.Surname,
                        TutorUniversity = x.Tutor.University,
                        TutorDepartment = x.Tutor.Department,
                        OlympiadYear = x.Year,
                        Stage = x.Stage,
                        Place = x.Place

                    })
                    .Where(x => x.Olympiad == temp[listBox1.SelectedIndex].Name && x.OlympiadYear == Int32.Parse(yr)); 
                dataGridView1.DataSource = pbindingSource;
                dataGridView1.Columns[0].Visible = false;
            } else if (yr == "" && st != "")
            {
                pbindingSource.DataSource = splist.Participations
                    .ConvertAll(x => new {
                        Olympiad = x.Olympiad.Name,
                        Surname = x.Student.Suranme,
                        University = x.Student.University,
                        Group = x.Student.Group,
                        Tutor = x.Tutor.Surname,
                        TutorUniversity = x.Tutor.University,
                        TutorDepartment = x.Tutor.Department,
                        OlympiadYear = x.Year,
                        Stage = x.Stage,
                        Place = x.Place

                    })
                    .Where(x => x.Olympiad == temp[listBox1.SelectedIndex].Name && x.Stage == st);
                dataGridView1.DataSource = pbindingSource;
                dataGridView1.Columns[0].Visible = false;
            } else if (yr != "" && st != "")
            {
                pbindingSource.DataSource = splist.Participations
                    .ConvertAll(x => new {
                        Olympiad = x.Olympiad.Name,
                        Surname = x.Student.Suranme,
                        University = x.Student.University,
                        Group = x.Student.Group,
                        Tutor = x.Tutor.Surname,
                        TutorUniversity = x.Tutor.University,
                        TutorDepartment = x.Tutor.Department,
                        OlympiadYear = x.Year,
                        Stage = x.Stage,
                        Place = x.Place

                    })
                    .Where(x => x.Olympiad == temp[listBox1.SelectedIndex].Name && x.Stage == st && x.OlympiadYear == Int32.Parse(yr));
                dataGridView1.DataSource = pbindingSource;
                dataGridView1.Columns[0].Visible = false;
            } else 
            {
                pbindingSource.DataSource = splist.Participations
                    .ConvertAll(x => new {
                        Olympiad = x.Olympiad.Name,
                        Surname = x.Student.Suranme,
                        University = x.Student.University,
                        Group = x.Student.Group,
                        Tutor = x.Tutor.Surname,
                        TutorUniversity = x.Tutor.University,
                        TutorDepartment = x.Tutor.Department,
                        OlympiadYear = x.Year,
                        Stage = x.Stage,
                        Place = x.Place

                    })
                    .Where(x => x.Olympiad == temp[listBox1.SelectedIndex].Name);
                dataGridView1.DataSource = pbindingSource;
                dataGridView1.Columns[0].Visible = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
            ExcelApp.Application.Workbooks.Add(Type.Missing);
            ExcelApp.Columns.ColumnWidth = 15;

            ExcelApp.Cells[1, 1] = "Олимпиада";
            ExcelApp.Cells[1, 2] = "Студент";
            ExcelApp.Cells[1, 3] = "Университет студента";
            ExcelApp.Cells[1, 4] = "Группа студента";
            ExcelApp.Cells[1, 5] = "Тренер";
            ExcelApp.Cells[1, 6] = "Университет тренера";
            ExcelApp.Cells[1, 7] = "Кафедра тренера";
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
