using System;
using System.Data;
using System.Windows.Forms;
using Clase_bbdd_fnatik;
using System.Configuration;
using System.Reflection;
using CustomControlButton;
using System.Media;

namespace rasu_fnatik
{
    public partial class Menu : Form
    {
        private Timer timer1;
        private int countTimer = 1800;
        DataSet ds = new DataSet();

        public Menu()
        {
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            TimerMaker();
            ToolStripNamer();
            UserControlMaker();
        }

        private void TimerMaker()
        {
            timer1 = new Timer();
            timer1.Tick += new EventHandler(Timer1_Tick);
            timer1.Interval = 1000;
            timer1.Start();
        }
        private void ToolStripNamer()
        {           
            
            Clase_BBDD cb = new Clase_BBDD();
            string id = ConfigurationManager.AppSettings["idUsuari"].ToString();
            string query = "SELECT UserCategories.AccessLevel, Users.idUser, Users.CodeUser, Users.UserName, UserRanks.DescRank FROM UserCategories, Users, UserRanks where UserCategories.idUserCategory = Users.idUserCategory AND Users.idUserRank = UserRanks.idUserRank AND idUser = " + id;
            ds = cb.PortarPerConsulta(query);           

            LabelName.Text = "    Name : " + (ds.Tables[0].Rows[0][3]).ToString();
            LabelRank.Text = "Rank : " + (ds.Tables[0].Rows[0][4]).ToString();

            query = "select * from MenuOptions where nivel_acces <= " + ds.Tables[0].Rows[0]["AccessLevel"];
            ds = cb.PortarPerConsulta(query);
        }

        private void UserControlMaker()
        {
            int n = ds.Tables[0].Rows.Count;
            UserControl1[] us = new UserControl1[n];
            for (int i = 0; i < n; i++)
            {
                us[i] = new UserControl1();
                us[i].Name = "Button" + i;
                us[i].LblText = ds.Tables[0].Rows[i]["texto"].ToString();
                us[i].NameDLL = ds.Tables[0].Rows[i]["nom_dll"].ToString();
                us[i].NameForm = ds.Tables[0].Rows[i]["nom_form"].ToString();
                flowLayoutPanel1.Controls.Add(us[i]);
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            countTimer--;
            if (countTimer == 0)
            {
                timer1.Stop();
                MessageBox.Show("Time is over!");
                this.Close();
            }
            LabelTimeLeft.Text = "      Time Left : " + countTimer / 60 + ":" + ((countTimer % 60) >= 10 ? (countTimer % 60).ToString() : "0" + countTimer % 60);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            SoundPlayer sp = new SoundPlayer
            {
                SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "\\Megalovania.wav"
            };
            sp.Play();
            sp.PlayLooping();                
        }
    }
}
