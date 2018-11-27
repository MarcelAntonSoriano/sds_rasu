using System;

namespace gestion_categorias
{
    public partial class Form_categorias : Form_Base.Form1
    {
        public Form_categorias()
        {
            InitializeComponent();
        }
        private void Form_categorias_Load_1(object sender, EventArgs e)
        {
            tabla = "UserCategories";
            Form1_Load(sender, e);
        }
    }
}
