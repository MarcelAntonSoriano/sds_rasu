using System;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using Control_FNATIK;

namespace Control_FNATIK
{
    public class ControlTextBox : TextBox
    {
        Clase_bbdd_fnatik.Clase_BBDD bd = new Clase_bbdd_fnatik.Clase_BBDD();
        public ControlTextBox()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // ControlTextBox
            // 
            this.CausesValidation = false;
            this.TextChanged += new System.EventHandler(this.ControlTextBox_TextChanged);
            this.Enter += new System.EventHandler(this.ControlTextBox_Enter);
            this.Leave += new System.EventHandler(this.ControlTextBox_Leave);
            this.ResumeLayout(false);

        }

        //PROPIEDADES
        public enum Tipos { Texto , Numero , Fecha };
        private Tipos _tipo;
        private string _campo;
        private bool _vacia = false;
        private bool _foranea = false;
        private string _controlSds;

        public string ControlSds
        {
            get { return _controlSds;}
            set { _controlSds = value; }
               
        }
        public bool EsForanea
        {
            get { return _foranea; }
            set { _foranea = value; }
        }
        public bool NoSalirSiVacia
        {
            get { return _vacia; }
            set { _vacia = value; }
        }

        public String Campo
        {
            get { return _campo; }
            set { _campo = value; }
        }

        public Tipos EsTipo
        {
            get { return _tipo; }
            set { _tipo = value; }
        }

        //EVENTOS

        //Validating
        private void ControlTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e, KeyPressEventArgs equisde)
        {
            string regex="";

            switch (_tipo)
            {
                case Tipos.Texto:  regex = "^[A-Za-z]*$"; break;
                case Tipos.Numero: regex = "^[0-9]*$"; break;
                case Tipos.Fecha:  regex = @"^([0-2][0-9]|(3)[0-1])(\/)(((0)[0-9])|((1)[0-2]))(\/)\d{4}$"; break;
            }
            e.Cancel = ValidarTextBox(regex);
        }
        public bool ValidarTextBox(string regex)
        {
            Regex rgx = new Regex(regex);
            return (_vacia && Text.Trim().Equals("")) || !rgx.IsMatch(Text.Trim());
        }

        //Enter , Leave
        private void ControlTextBox_Enter(object sender, EventArgs e)
        {
            BackColor = Color.LightGray;
        }
        private void ControlTextBox_Leave(object sender, EventArgs e)
        {
            BackColor = Color.White;
        }

        //TextChanged
        private void ControlTextBox_TextChanged(object sender, EventArgs e)
        {
            Form frm = FindForm();

            if (EsForanea)
            {
                foreach (Control ctr in frm.Controls)
                {
                    if (ctr.GetType() == typeof(sdsCodi.sdsCodi) && ((sdsCodi.sdsCodi)ctr).ControlID == Name)
                    {
                        ctr.Text = Text;
                    }
                }
            }
        }
    }
}
