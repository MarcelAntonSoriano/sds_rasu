using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            timer1 = new Timer();
            timer1.Tick += new EventHandler(Timer1_Tick);
            timer1.Interval = 1000;
            timer1.Start();

            Clase_BBDD cb = new Clase_BBDD();
            DataSet dts;
            string id = null;
            string query = null;

            id = ConfigurationManager.AppSettings["idUsuari"].ToString();

            query = "select U.UserName, UR.DescRank from Users U, UserRanks UR where U.idUserRank = UR.idUserRank and U.idUser = " + id;
            dts = cb.PortarPerConsulta(query);

            LabelName.Text = "Name :   " + (dts.Tables[0].Rows[0][0]).ToString();
            LabelRank.Text = "Rank :   " + (dts.Tables[0].Rows[0][1]).ToString();

            query = "SELECT UserCategories.AccessLevel, Users.idUser, Users.CodeUser FROM UserCategories, Users where UserCategories.idUserCategory = Users.idUserCategory AND idUser = " + id ;
            dts = new DataSet();
            dts = cb.PortarPerConsulta(query);

            query = "select * from MenuOptions where nivel_acces <= " + dts.Tables[0].Rows[0]["AccessLevel"];
            ds = cb.PortarPerConsulta(query);

            int n = ds.Tables[0].Rows.Count;

            UserControl1[] us = new UserControl1[n];

            for (int i = 0; i < n; i++)
            {
                us[i] = new UserControl1();
                us[i].Name = "Button" + i;
                us[i].LblText = ds.Tables[0].Rows[i][4].ToString();
                us[i].NameDLL = ds.Tables[0].Rows[i][1].ToString();
                us[i].NameForm = ds.Tables[0].Rows[i][2].ToString();
            }

            for (int i = 0; i < n; i++)
            {
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
