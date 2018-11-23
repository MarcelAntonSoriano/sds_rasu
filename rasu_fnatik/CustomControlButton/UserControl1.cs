using System;
using System.Windows.Forms;
using System.Reflection;

namespace CustomControlButton
{
    public partial class UserControl1: UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }        

            private string _lblText;
            public string LblText
            {
                get { return _lblText; }
                set
                {
                    _lblText = value;
                    button1.Text = value;
                }
            }
            
            private string _NameDLL;
            public string NameDLL
            {
                get { return _NameDLL; }
                set { _NameDLL = value; }
            }

            private string _NameForm;
            public string NameForm
            {
                get { return _NameForm; }
                set { _NameForm = value; }
            }
            
        private void ObreForm(object sender, EventArgs e)
        {
            Assembly ensamblat = Assembly.LoadFrom(NameDLL);
            
            Type tipus = ensamblat.GetType(NameForm);
            Object dllBD = Activator.CreateInstance(tipus);

            ((Form)dllBD).Show();
            button1.Text = LblText;
        }        
    }
}
