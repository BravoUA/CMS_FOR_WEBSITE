using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

using CMS_FOR_WEBSITE;
using CMS_FOR_WEBSITE.Models;

namespace CMS_FOR_WEBSITE
{
    public partial class Delete : Form
    {
        public Delete()
        {
            InitializeComponent();
        }



        ImageList img = new ImageList();
        dbConnect DBCON = new dbConnect(dbPath);
        List<FildType> fildTypes = new List<FildType>();
        List<Machinery> machineries = new List<Machinery>();
        List<Technic> technicModels = new List<Technic>();


        string[] ImgName;
        string[] ImgNamePaths;
        static string dbPath = "C:\\AnnalandBD\\ALDB.db";
        string HadImg;
        string HadImgPath;
        int Categories = 0;
        public DataTable AllTr;
        string Name, Model, Year, Type, Working_hours, Power, Mass, Text, State;

        int Price, FildType, IDM, Sale, id, DeleteId, DeleteIdBUT;

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            dataGridView1.DataSource = null;
            dataGridView1.Refresh();
            string selectedText = comboBox1.SelectedItem.ToString();
            List<FildType> selectedFildTypes = (from s in fildTypes where s.FildTypeName == selectedText select s).ToList();


            if (Categories == 1)
            {
                List<Machinery> sortByFildtype = (from f in machineries where f.FildType == selectedFildTypes[0].id select f).ToList();
                dataGridView1.DataSource = sortByFildtype;
            }
            else if (Categories == 2)
            {
                List<Technic> sortByFildtype = (from f in technicModels where f.FildType == selectedFildTypes[0].id select f).ToList();
                dataGridView1.DataSource = sortByFildtype;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Refresh();

            if (Categories == 1)
            {
                List<Machinery> sortByFildtype = (from f in machineries where f.Name.ToLower().Contains(textBox1.Text.ToLower()) select f).ToList();
                dataGridView1.DataSource = sortByFildtype;
            }
            else if (Categories == 2)
            {
                List<Technic> sortByFildtype = (from f in technicModels where f.Name.ToLower().Contains(textBox1.Text.ToLower()) select f).ToList();
                dataGridView1.DataSource = sortByFildtype;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {/*
            button1.Visible = false;
            button4.Visible = false;
            List<string> listChenges = new List<string>();

            if (Categories == 1)
            {
                if (dataGridView1.SelectedCells[0].RowIndex < 2)
                {
                    try
                    {
                        int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                        DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                        listChenges.Add(Convert.ToString(selectedRow.Cells["Name"].Value));
                        listChenges.Add(Convert.ToString(selectedRow.Cells["Model"].Value));
                        listChenges.Add(Convert.ToString(selectedRow.Cells["Year"].Value));
                        listChenges.Add(Convert.ToString(selectedRow.Cells["Type"].Value));
                        listChenges.Add(Convert.ToString(selectedRow.Cells["Working_hours"].Value));
                        listChenges.Add(Convert.ToString(selectedRow.Cells["Power"].Value));
                        listChenges.Add(Convert.ToString(selectedRow.Cells["Mass"].Value));
                        listChenges.Add(Convert.ToString(selectedRow.Cells["Text"].Value));
                        listChenges.Add(Convert.ToString(selectedRow.Cells["State"].Value));
                        listChenges.Add(Convert.ToString(selectedRow.Cells["Price"].Value));
                        listChenges.Add(Convert.ToString(selectedRow.Cells["FildType"].Value));
                        listChenges.Add(Convert.ToString(selectedRow.Cells["IDM"].Value));
                        listChenges.Add(Convert.ToString(selectedRow.Cells["Sale"].Value));
                        listChenges.Add(Convert.ToString(selectedRow.Cells["id"].Value));

                    }
                    catch (FormatException eror)
                    {
                        MessageBox.Show(eror.ToString());
                    }

                    dataGridView1.DataSource = null;
                    dataGridView1.Refresh();
                    dataSet.Clear();
                    try
                    {

                        DBCON.insertToDB(Categories, DeleteId, listChenges);
                        dataGridView1.ReadOnly = true;
                        dataGridView1.DataSource = null;
                        dataGridView1.Refresh();
                    }
                    catch (SQLiteException eror)
                    {
                        MessageBox.Show("Виникла Помилка\n Не використовуйте Апостроф чи подвійний Апостроф\n Якщо вони потрібні поставте перед ними символ «\\»");
                    }



                    button2.Visible = true;
                    button3.Visible = true;

                    button5.Visible = false;
                }
            }
            else if (Categories == 2)
            {
                if (dataGridView1.SelectedCells[0].RowIndex < 2)
                {
                    try
                    {
                        int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                        DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                        listChenges.Add(Convert.ToString(selectedRow.Cells["Name"].Value));
                        listChenges.Add(Convert.ToString(selectedRow.Cells["Model"].Value));
                        listChenges.Add(Convert.ToString(selectedRow.Cells["Year"].Value));
                        listChenges.Add(Convert.ToString(selectedRow.Cells["Type"].Value));
                        listChenges.Add(Convert.ToString(selectedRow.Cells["Mass"].Value));
                        listChenges.Add(Convert.ToString(selectedRow.Cells["Text"].Value));
                        listChenges.Add(Convert.ToString(selectedRow.Cells["State"].Value));
                        listChenges.Add(Convert.ToString(selectedRow.Cells["Price"].Value));
                        listChenges.Add(Convert.ToString(selectedRow.Cells["FildType"].Value));
                        listChenges.Add(Convert.ToString(selectedRow.Cells["IDT"].Value));
                        listChenges.Add(Convert.ToString(selectedRow.Cells["Sale"].Value));
                        listChenges.Add(Convert.ToString(selectedRow.Cells["id"].Value));

                    }
                    catch (FormatException eror)
                    {
                        MessageBox.Show(eror.ToString());
                    }

                    dataGridView1.DataSource = null;
                    dataGridView1.Refresh();
                    dataSet.Clear();
                    try
                    {

                        DBCON.insertToDB(Categories, DeleteId, listChenges);
                        dataGridView1.ReadOnly = true;
                        dataGridView1.DataSource = null;
                        dataGridView1.Refresh();
                    }
                    catch (SQLiteException eror)
                    {
                        MessageBox.Show("Виникла Помилка\n Не використовуйте Апостроф чи подвійний Апостроф\n Якщо вони потрібні поставте перед ними символ «\\»");
                    }



                    button2.Visible = true;
                    button3.Visible = true;

                    button5.Visible = false;
                }
            }


            */
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0 && button5.Visible == false)
            {
                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                string cellValue = Convert.ToString(selectedRow.Cells["id"].Value);
                string cellValue2 = Convert.ToString(selectedRow.Cells["FildType"].Value);

                DeleteId = int.Parse(cellValue);
                int DeleteIdFildType = int.Parse(cellValue2);

                switch (DeleteIdFildType)
                {
                    case 1:
                        Process.Start(new ProcessStartInfo { FileName = @"http://www.annaland.com.ua/SelectedMorT.php?techW=M&id='" + DeleteId + "'#Back", UseShellExecute = true });
                        break;
                    case 2:
                        Process.Start(new ProcessStartInfo { FileName = @"http://www.annaland.com.ua/SelectedMorT.php?techW=S&id='" + DeleteId + "'#Back", UseShellExecute = true });
                        break;

                    case 3:
                        Process.Start(new ProcessStartInfo { FileName = @"http://www.annaland.com.ua/SelectedMorT.php?techW=Z&id='" + DeleteId + "'#Back", UseShellExecute = true });
                        break;
                    case 4:
                        Process.Start(new ProcessStartInfo { FileName = @"http://www.annaland.com.ua/SelectedMorT.php?techW=T&typeW=P&id='" + DeleteId + "'#Back", UseShellExecute = true });
                        break;
                    case 5:
                        Process.Start(new ProcessStartInfo { FileName = @"http://www.annaland.com.ua/SelectedMorT.php?techW=T&typeW=G&id='" + DeleteId + "'#Back", UseShellExecute = true });
                        break;
                    case 6:
                        Process.Start(new ProcessStartInfo { FileName = @"http://www.annaland.com.ua/SelectedMorT.php?techW=T&typeW=PS&id='" + DeleteId + "'#Back", UseShellExecute = true });
                        break;
                    case 7:
                        Process.Start(new ProcessStartInfo { FileName = @"http://www.annaland.com.ua/SelectedMorT.php?techW=T&typeW=I&id='" + DeleteId + "'#Back", UseShellExecute = true });
                        break;
                    case 8:
                        Process.Start(new ProcessStartInfo { FileName = @"http://www.annaland.com.ua/SelectedMorT.php?techW=T&typeW=O&id='" + DeleteId + "'#Back", UseShellExecute = true });
                        break;
                }


            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Edite EditForm = new Edite();

            if (Categories == 1)
            {
                if (dataGridView1.SelectedCells.Count > 0)
                {
                    int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                    string cellValue = Convert.ToString(selectedRow.Cells["id"].Value);
                    DeleteId = int.Parse(cellValue);
                }
                Machinery machinery = new Machinery();

                for (int i = 0; i < machineries.Count; i++)
                {
                    if (machineries[i].id == DeleteId)
                    {
                        machinery = machineries[i];
                    }
                }
                EditForm.machinery = machinery;
                EditForm.Categories = Categories;
                EditForm.Show();

            }
            else if (Categories == 2)
            {
                if (dataGridView1.SelectedCells.Count > 0)
                {
                    int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                    string cellValue = Convert.ToString(selectedRow.Cells["id"].Value);
                    DeleteId = int.Parse(cellValue);
                }
                Technic technic = new Technic();

                for (int i = 0; i < machineries.Count; i++)
                {
                    if (technicModels[i].id == DeleteId)
                    {
                        technic = technicModels[i];
                    }
                }

                EditForm.technic = technic;
                EditForm.Categories = Categories;
                EditForm.Show();

            }




        }

        private void Delete_Load(object sender, EventArgs e)
        {

            dataGridView1.DataSource = null;
            dataGridView1.Refresh();

            machineries = DBCON.Machinery.ToList();
            technicModels = DBCON.Technic.ToList();
            fildTypes = DBCON.FildType.ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.Visible = true;
            button4.Visible = true;
            dataGridView1.DataSource = null;
            dataGridView1.Refresh();

            DBCON = new dbConnect(dbPath);
            technicModels.Clear();
            technicModels = DBCON.Technic.ToList();
            dataGridView1.DataSource = technicModels;
            Categories = 2;
            string[] installs = new string[] { "Картопляна техніка", "Техніка для обробка грунту", "Посівна та садильна техніка", "Техніка для внесення добрив", "Інша техніка" };
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(installs);
        }

        private void button2_Click(object sender, EventArgs e)

        {
            button1.Visible = true;
            button4.Visible = true;
            dataGridView1.DataSource = null;
            dataGridView1.Refresh();

            DBCON = new dbConnect(dbPath);
            machineries.Clear();
            machineries = DBCON.Machinery.ToList();
            dataGridView1.DataSource = machineries;
            Categories = 1;
            string[] installs = new string[] { "Трактори", "Спецтехніка", "Збиральна техніка" };
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(installs);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            button4.Visible = false;

            if (dataGridView1.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                string cellValue = Convert.ToString(selectedRow.Cells["id"].Value);
                DeleteId = int.Parse(cellValue);
            }
            if (Categories == 1)
            {
                var delM = (from a in machineries where a.id == DeleteId select a).ToList(); ;
                DBCON.Machinery.Remove(delM[0]);
                DBCON.SaveChanges();
                dataGridView1.DataSource = null;

                dataGridView1.Refresh();
                DBCON = new dbConnect(dbPath);
                machineries.Clear();
                machineries = DBCON.Machinery.ToList();
                dataGridView1.DataSource = machineries;
            }
            else if (Categories == 2)
            {
                var delT = (from a in technicModels where a.id == DeleteId select a).ToList(); ;
                DBCON.Technic.Remove(delT[0]);
                DBCON.SaveChanges();
                dataGridView1.DataSource = null;
                dataGridView1.Refresh();

                DBCON = new dbConnect(dbPath);
                technicModels.Clear();
                technicModels = DBCON.Technic.ToList();
                dataGridView1.DataSource = technicModels;
            }
        }

        private void Delete_VisibleChanged(object sender, EventArgs e)
        {

        }

        private void Delete_Activated(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Refresh();
            if (Categories == 1)
            {
                DBCON = new dbConnect(dbPath);
                machineries.Clear();
                machineries = DBCON.Machinery.ToList();
                dataGridView1.DataSource = machineries;
            }
            else if (Categories == 2)
            {
                DBCON = new dbConnect(dbPath);
                technicModels.Clear();
                technicModels = DBCON.Technic.ToList();
                dataGridView1.DataSource = technicModels;
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Create Create = new Create();
            Create.Show();

        }
    }
}
