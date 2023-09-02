using CMS_FOR_WEBSITE.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;

using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMS_FOR_WEBSITE
{
    public partial class Edite : Form
    {
        public Edite()
        {
            InitializeComponent();
        }
        static string dbPath = "C:\\AnnalandBD\\ALDB.db";
        dbConnect DB = new dbConnect(dbPath);
        public DataTable AllTr;
        public Machinery machinery = new Machinery();
        public Technic technic = new Technic();
        public int Categories;
        int ID, IDM, IDT, SALE;

        private void button1_Click(object sender, EventArgs e)
        {
            int zer = 0;
            int.TryParse(Price.Text, out zer);
            if (Categories == 1)
            {
                Machinery editM = new Machinery()
            {
                Name = NamePos.Text,
                Model = Model.Text,
                Year = Year.Text,
                Type = Type.Text,
                Working_hours = Working_hours.Text,
                Power = Power.Text,
                Mass = Mass.Text,
                Text = TextInfo.Text,
                State = comboBox2.Text,

                Price = zer,
                FildType = comboBox1.SelectedIndex,
                IDM = IDM,
                Sale = SALE,
                id = ID
            };
                DB.Machinery.Update(editM);

                DB.SaveChanges();
       
                MessageBox.Show("upload is complete");
                this.Close();
            }
            if (Categories == 2)
            {

                Technic editT = new Technic()
                {
                    Name = NamePos.Text,
                    Model = Model.Text,
                    Year = Year.Text,
                    Type = Type.Text,
                    
                    Mass = Mass.Text,
                    Text = TextInfo.Text,
                    State = comboBox2.Text,

                    Price = zer,
                    FildType = comboBox1.SelectedIndex,
                    IDT = IDT,
                    Sale = SALE,
                    id = ID
                };
                DB.Technic.Add(editT);
                DB.SaveChanges();
                MessageBox.Show("upload is complete");
                this.Close();
            }
        }

        private void Edite_Load(object sender, EventArgs e)
        {
            if (Categories == 1)
            {
                ID = machinery.id;
                IDM = machinery.IDM;
                SALE = machinery.Sale;
                NamePos.Text = machinery.Name;
                Model.Text = machinery.Model;
                Year.Text = machinery.Year;
                Type.Text = machinery.Type;
                Working_hours.Text = machinery.Working_hours;
                Power.Text = machinery.Power;
                Mass.Text = machinery.Mass;
                comboBox2.Text = machinery.State;
                int zer = 0;
                int.TryParse(machinery.Price.ToString(), out zer);
                Price.Text = zer.ToString();
                comboBox1.SelectedIndex = machinery.FildType;
                TextInfo.Text = machinery.Text;
            }
            if (Categories == 2)
            {
                label10.Visible = false;
                label9.Visible = false;
                Working_hours.Visible = false;
                Power.Visible = false;
                NamePos.Text = technic.Name;
                Model.Text = technic.Model;
                Year.Text = technic.Year;
                Type.Text = technic.Type;
                TextInfo.Text = technic.Text;
                Mass.Text = technic.Mass;
                int zer = 0;
                int.TryParse(technic.Price.ToString(), out zer);
                Price.Text = zer.ToString();

                comboBox2.Text = technic.State;
                IDT = technic.IDT;
                comboBox1.SelectedIndex = technic.FildType;
                SALE = technic.Sale;
                ID = technic.id;



            }


        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked) { Price.Enabled = false; Price.Text = ""; } else { Price.Enabled = true; }
        }
    }
}
