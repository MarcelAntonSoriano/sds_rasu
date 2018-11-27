using System.Windows.Forms;
using System.Data;
using Clase_bbdd_fnatik;

namespace Sds
{
    public partial class sdsCodi : UserControl
    {
        string query = null;
        DataSet ds = new DataSet();
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
            set { _nombreCodi = value; }
        }

        public string NombreDesc
        {
            get { return _nombreDesc; }
            set { _nombreDesc = value; }
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
            Form fmr =  this.FindForm();  

            foreach (Control ctr in this.Controls)
            {
                if (ctr.GetType() == typeof(Control_FNATIK.ControlTextBox))
                {
                   if(ctr.Name == ControlID)
                   {
                        ctr.Text = ds.Tables[0].Rows[0][0].ToString();
                   }
                }
            }
        }
       
        public void InsertarDades(string Texto)
        {
            query = "select * from " + NombreTaula + " where "+ NombreCodi + " = '" + Texto + "'";
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
            if(Text!=null)
            InsertarDades(Text);
        }

    }
}