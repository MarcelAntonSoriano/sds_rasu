using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using Clase_bbdd_fnatik;

namespace sdsCodi
{
    public class sdsCodi:UserControl
    {
        string query = null;
        DataSet ds = new DataSet();
        private Label Label;
        private TextBox TextCode;
        private TextBox TextDesc;
        Clase_BBDD cb = new Clase_BBDD();
        public sdsCodi()
        {
            InitializeComponent();
        }

        //PROPIEDADES
        private bool _requerido;
        private string _formCS;
        private string _claseCS;
        private string _nombreID;
        private string _nombreCodi;
        private string _nombreDesc;
        private string _nombreTaula;
        private string _controlID;
        private string _validaCodi;
        private string _abreCS;

        public bool Requerido
        {
            get { return _requerido; }
            set { _requerido = value; }
        }

        public string FormCS
        {
            get { return _formCS; }
            set { _formCS = value; }
        }

        public string ClaseCS
        {
            get { return _claseCS; }
            set { _claseCS = value; }
        }

        public string NombreID
        {
            get { return _nombreID; }
            set { _nombreID = value; }
        }

        public string NombreCodi
        {
            get { return _nombreCodi; }
            set
            {
                _nombreCodi = value;
                TextCode.Text = _nombreCodi;
            }
        }

        public string NombreDesc
        {
            get { return _nombreDesc; }
            set
            {
                _nombreDesc = value;
                TextDesc.Text = _nombreDesc;
            }
        }

        public string NombreTaula
        {
            get { return _nombreTaula; }
            set { _nombreTaula = value; }
        }

        public string ControlID
        {
            get { return _controlID; }
            set { _controlID = value; }
        }

        public string ValidaCodi
        {
            get { return _validaCodi; }
            set { _validaCodi = value; }
        }

        public string AbreCS
        {
            get { return _abreCS; }
            set { _abreCS = value; }
        }
        public void PortarDades(string query)
        {
            ds = cb.PortarPerConsulta(query);
            TextDesc.Text = ds.Tables[0].Rows[0][1].ToString();
            Form fmr = this.FindForm();

            foreach (Control ctr in this.Controls)
            {
                if (ctr.GetType() == typeof(Control_FNATIK.ControlTextBox))
                {
                    if (ctr.Name == ControlID)
                    {
                        ctr.Text = ds.Tables[0].Rows[0][0].ToString();
                    }
                }
            }
        }

        public void InsertarDades(string Texto)
        {
            query = "select * from " + NombreTaula + " where " + NombreCodi + " = '" + Texto + "'";
            PortarDades(query);
        }

        public void InsertarDades(int id)
        {
            query = "select * from " + NombreTaula + " where " + NombreCodi + " = " + id.ToString();
            PortarDades(query);
        }

        //EVENTOS
        private void TextCode_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = _requerido && TextCode.Text.Trim().Equals("");
        }

        private void TextCode_Leave(object sender, System.EventArgs e)
        {
            if (Text != null)
                InsertarDades(Text);
        }

        private void InitializeComponent()
        {
            this.Label = new System.Windows.Forms.Label();
            this.TextCode = new System.Windows.Forms.TextBox();
            this.TextDesc = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Location = new System.Drawing.Point(20, 6);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(35, 13);
            this.Label.TabIndex = 0;
            this.Label.Text = "label1";
            // 
            // TextCode
            // 
            this.TextCode.Location = new System.Drawing.Point(87, 3);
            this.TextCode.Name = "TextCode";
            this.TextCode.Size = new System.Drawing.Size(44, 20);
            this.TextCode.TabIndex = 1;
            this.TextCode.Leave += new System.EventHandler(this.TextCode_Leave);
            this.TextCode.Validating += new System.ComponentModel.CancelEventHandler(this.TextCode_Validating);
            // 
            // TextDesc
            // 
            this.TextDesc.Enabled = false;
            this.TextDesc.Location = new System.Drawing.Point(160, 3);
            this.TextDesc.Name = "TextDesc";
            this.TextDesc.Size = new System.Drawing.Size(119, 20);
            this.TextDesc.TabIndex = 2;
            // 
            // sdsCodi
            // 
            this.Controls.Add(this.TextDesc);
            this.Controls.Add(this.TextCode);
            this.Controls.Add(this.Label);
            this.Name = "sdsCodi";
            this.Size = new System.Drawing.Size(304, 26);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
