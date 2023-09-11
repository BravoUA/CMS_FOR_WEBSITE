using System.Globalization;
using System.Runtime.ConstrainedExecution;
using System.Windows.Forms;
using CMS_FOR_WEBSITE.Models;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CMS_FOR_WEBSITE
{
    public partial class Create : Form
    {
        public Create()
        {
            InitializeComponent();
        }
        string puth;


        public string Login;
        public string Paswword;
        public string Host;

        string HadImg;
        string HadImgPath;

        
        string[] ImgName;
        string[] ImgNamePaths;
        ImageList img = new ImageList();
        static string dbPath = "C:\\AnnalandBD\\ALDB.db";
        ftpConnect ftpConnect;
        private dbConnect dbConnect = new dbConnect(dbPath);
        List<NameofFirm> nameofFirms = new List<NameofFirm>();
        List<NameofFirm> IDB = new List<NameofFirm>();
        private void Form1_Load(object sender, EventArgs e)
        {
            nameofFirms = dbConnect.NameofFirm.ToList();
            ftpConnect = new ftpConnect(Login, Paswword, Host);
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            listView1.View = View.Details;
            listView1.Columns.Add("CONTENT IMGES", 150);
            listView1.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.HeaderSize);
            this.progressBar1.Maximum = 100;
        }
        //Створити позицію
        private void button1_Click(object sender, EventArgs e)
        {
            List<string> content = new List<string>();
            if (comboBox3.SelectedIndex == 0)
            {
                
                int zer = 0;
                int.TryParse(Price.Text, out zer);
           

                IDB = (from n in nameofFirms where n.Name.ToLower() == NamePos.Text.ToLower() select n).ToList();
                
                Machinery newMachinery = new Machinery()
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
                    FildType = (comboBox1.SelectedIndex + 1),
                    IDM = IDB[0].ID,
                    Sale = 0
                };





                HadImgPath hadImgPath;
                List<MachinesImg> machinesImgs = new List<MachinesImg>();

                hadImgPath = new HadImgPath() {
                    hadimgpath = "/img/HadImg/" + HadImg,
                    hadimgName = HadImg
                };

                for (int i = 0; i < ImgName.Length; i++)
                {
                    machinesImgs.Add
                        (new MachinesImg()
                        {
                            imgNAME = ImgName[i],
                            imgpath = "/img/imges/" + ImgName[i]
                        }); 
                    }

                string[] webimgpath2 = { HadImgPath, HadImg };
                dbConnect.Machinery.Add(newMachinery);
                dbConnect.HadImgPath.Add(hadImgPath);
                for (int i = 0; i < machinesImgs.Count; i++)
                {
                    dbConnect.MachinesImg.Add(machinesImgs[i]);
                }
                dbConnect.SaveChanges();
                // ftpConnect.UploadFilesIMG(webimgpath2, ImgNamePaths, ImgName);

                NamePos.Text = ""; Model.Text = ""; Year.Text = ""; Type.Text = ""; Working_hours.Text = ""; Power.Text = ""; Mass.Text = ""; TextInfo.Text = ""; comboBox1.Text = ""; comboBox2.Text = ""; Price.Text = ""; listView1.Clear();

               
                
                MessageBox.Show("upload is complete");
                this.Close();
            }
            else
            if (comboBox3.SelectedIndex == 1)
            {
                
                int zer = 0;
                int.TryParse(Price.Text, out zer);
                IDB = (from n in nameofFirms where n.Name.ToLower() == NamePos.Text.ToLower() select n).ToList();
                Technic NewTechic = new Technic()
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
                    IDT = IDB[0].ID,
                    Sale = 0
                    
                };
                HadImgPathT HadImgPathT;
                List<TechnicImg> technicImg = new List<TechnicImg>();

                HadImgPathT = new HadImgPathT()
                {
                    hadImgPathT = "/img/HadImg/" + HadImg,
                    hadImgTName = HadImg
                };
                for (int i = 0; i < ImgName.Length; i++)
                {
                    technicImg.Add
                        (new TechnicImg()
                        {
                            TechnicImgNAME = ImgName[i],
                            TechnicImgPath = "/img/imges/" + ImgName[i]
                        });
                }


                List<string> IMGSPath = new List<string>();
                string[] webimgpath = { "/img/HadImg/" + HadImg, HadImg };
                for (int i = 0; i < ImgName.Length; i++)
                {
                    IMGSPath.Add("/img/imges/" + ImgName[i]);
                }
                dbConnect.Technic.Add(NewTechic);
                dbConnect.HadImgPathT.Add(HadImgPathT);
                for (int i = 0; i < technicImg.Count; i++)
                {
                    dbConnect.TechnicImg.Add(technicImg[i]);
                }
                dbConnect.SaveChanges();

               

                string[] webimgpath2 = { HadImgPath, HadImg };
                ftpConnect.UploadFilesIMG(webimgpath2, ImgNamePaths, ImgName);

                NamePos.Text = ""; Model.Text = ""; Year.Text = ""; Type.Text = ""; Working_hours.Text = ""; Power.Text = ""; Mass.Text = ""; TextInfo.Text = ""; comboBox1.Text = ""; comboBox2.Text = ""; Price.Text = ""; listView1.Clear();
                progressBar1.Value = 100;
               
                MessageBox.Show("upload is complete");
                this.Close();
            }

        }
        //Основне Фото
        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("IMG Resolution mast be 330x270");
            OpenFileDialog choofdlog = new OpenFileDialog();
            choofdlog.Filter = "All Files (*.*)|*.*";
            choofdlog.FilterIndex = 1;

            choofdlog.Multiselect = true;

            if (choofdlog.ShowDialog() == DialogResult.OK)
            {
                HadImgPath = choofdlog.FileName;
                HadImg = choofdlog.SafeFileName;
                label2.Text = HadImg;
                pictureBox1.Image = Image.FromFile(HadImgPath);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            }


        }
        //Фотографії
        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog choofdlog = new OpenFileDialog();
            choofdlog.Filter = "All Files (*.*)|*.*";
            choofdlog.FilterIndex = 1;


            img.ImageSize = new Size(100, 80);

            choofdlog.Multiselect = true;

            if (choofdlog.ShowDialog() == DialogResult.OK)
            {
                ImgNamePaths = choofdlog.FileNames;
                ImgName = choofdlog.SafeFileNames;
                foreach (string i in ImgNamePaths)
                {
                    img.Images.Add(Image.FromFile(i));
                }
                listView1.SmallImageList = img;
                for (int a = 0; a < ImgNamePaths.Length; a++)
                {

                    listView1.Items.Add(ImgNamePaths[a], a);
                }
            }
        }
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.SelectedIndex == 0)
            {
                label5.Visible = true; label10.Visible = true;
                label6.Visible = true; label11.Visible = true;
                label7.Visible = true; label12.Visible = true;
                label8.Visible = true; label13.Visible = true;
                label9.Visible = true; label14.Visible = true;
                label15.Visible = true; 

                NamePos.Visible = true;
                Model.Visible = true;
                Year.Visible = true;
                Type.Visible = true;
                Working_hours.Visible = true;
                Power.Visible = true;
                Mass.Visible = true;
                Visible = true; TextInfo.Visible = true;
                comboBox2.Visible = true;
                Price.Visible = true; 
                comboBox1.Visible = true;
            }
            else if (comboBox3.SelectedIndex == 1)
            {
                label5.Visible = true; label10.Visible = false;
                label6.Visible = true; label11.Visible = true;
                label7.Visible = true; label12.Visible = true;
                label8.Visible = true; label13.Visible = true;
                label9.Visible = false; label14.Visible = true;
                label15.Visible = true;

                NamePos.Visible = true;
                Model.Visible = true;
                Year.Visible = true;
                Type.Visible = true;
                Working_hours.Visible = false;
                Power.Visible = false;
                Mass.Visible = true;
                Visible = true; TextInfo.Visible = true;
                comboBox2.Visible = true;
                Price.Visible = true;
                comboBox1.Visible = true;

            }
        }
    }
}