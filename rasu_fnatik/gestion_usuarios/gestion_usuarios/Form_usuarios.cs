﻿using System;

namespace gestion_usuarios 
{
    public partial class Form_usuarios : Form_Base_FK.Form_FK
    {
        public Form_usuarios()
        {
            InitializeComponent();
        }

        private void Form_usuarios_Load(object sender, EventArgs e)
        {
            tabla = "Users";
            Form_FK_Load(sender, e);
        }
    }
}