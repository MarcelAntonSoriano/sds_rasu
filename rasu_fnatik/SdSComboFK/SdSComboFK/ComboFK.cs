using System;
using System.Windows.Forms;

namespace SdSComboFK
{
    public class ComboFK : ComboBox
    {
        public ComboFK()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            // 
            // ControlTextBox
            // 
            this.ResumeLayout(false);
        }

        private string _controlid;

        public string ControlID
        {
            get { return _controlid; }
            set { _controlid = value; }
        }
    }
}
