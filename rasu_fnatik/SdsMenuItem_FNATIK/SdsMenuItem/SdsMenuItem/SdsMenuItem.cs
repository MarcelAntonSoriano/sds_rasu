using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace SdsMenuItem
{
    public class SdsMenuItem : ToolStripMenuItem
    {
        public SdsMenuItem()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {

        }
        private string _classe;
        private string _form;
        public string Classe
        {
            get { return _classe; }
            set { _classe = value;}
        }
        public string Form
        {
            get { return _form; }
            set { _form = value;}
        }
    }
}
