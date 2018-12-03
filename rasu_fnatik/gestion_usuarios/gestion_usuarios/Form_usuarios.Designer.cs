namespace gestion_usuarios
{
    partial class Form_usuarios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.controlTextBox1 = new Control_FNATIK.ControlTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.controlTextBox2 = new Control_FNATIK.ControlTextBox();
            this.controlTextBox3 = new Control_FNATIK.ControlTextBox();
            this.controlTextBox4 = new Control_FNATIK.ControlTextBox();
            this.controlTextBox5 = new Control_FNATIK.ControlTextBox();
            this.sdsCodi1 = new sdsCodi.sdsCodi();
            this.sdsCodi2 = new sdsCodi.sdsCodi();
            this.sdsCodi3 = new sdsCodi.sdsCodi();
            this.sdsCodi4 = new sdsCodi.sdsCodi();
            this.LabelTitulo = new System.Windows.Forms.Label();
            this.LabelUsuario = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // controlTextBox1
            // 
            this.controlTextBox1.Campo = "CodeUser";
            this.controlTextBox1.CausesValidation = false;
            this.controlTextBox1.ControlSds = null;
            this.controlTextBox1.EsForanea = false;
            this.controlTextBox1.EsTipo = Control_FNATIK.ControlTextBox.Tipos.Texto;
            this.controlTextBox1.Location = new System.Drawing.Point(189, 89);
            this.controlTextBox1.Name = "controlTextBox1";
            this.controlTextBox1.NoSalirSiVacia = false;
            this.controlTextBox1.Size = new System.Drawing.Size(100, 20);
            this.controlTextBox1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(224, 368);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(36, 34);
            this.panel1.TabIndex = 0;
            // 
            // controlTextBox2
            // 
            this.controlTextBox2.Campo = "idUserRank";
            this.controlTextBox2.CausesValidation = false;
            this.controlTextBox2.ControlSds = null;
            this.controlTextBox2.EsForanea = true;
            this.controlTextBox2.EsTipo = Control_FNATIK.ControlTextBox.Tipos.Numero;
            this.controlTextBox2.Location = new System.Drawing.Point(360, 142);
            this.controlTextBox2.Name = "controlTextBox2";
            this.controlTextBox2.NoSalirSiVacia = false;
            this.controlTextBox2.Size = new System.Drawing.Size(25, 20);
            this.controlTextBox2.TabIndex = 0;
            // 
            // controlTextBox3
            // 
            this.controlTextBox3.Campo = "idUserCategory";
            this.controlTextBox3.CausesValidation = false;
            this.controlTextBox3.ControlSds = null;
            this.controlTextBox3.EsForanea = true;
            this.controlTextBox3.EsTipo = Control_FNATIK.ControlTextBox.Tipos.Numero;
            this.controlTextBox3.Location = new System.Drawing.Point(360, 181);
            this.controlTextBox3.Name = "controlTextBox3";
            this.controlTextBox3.NoSalirSiVacia = false;
            this.controlTextBox3.Size = new System.Drawing.Size(25, 20);
            this.controlTextBox3.TabIndex = 0;
            // 
            // controlTextBox4
            // 
            this.controlTextBox4.Campo = "idPlanet";
            this.controlTextBox4.CausesValidation = false;
            this.controlTextBox4.ControlSds = null;
            this.controlTextBox4.EsForanea = true;
            this.controlTextBox4.EsTipo = Control_FNATIK.ControlTextBox.Tipos.Numero;
            this.controlTextBox4.Location = new System.Drawing.Point(360, 219);
            this.controlTextBox4.Name = "controlTextBox4";
            this.controlTextBox4.NoSalirSiVacia = false;
            this.controlTextBox4.Size = new System.Drawing.Size(25, 20);
            this.controlTextBox4.TabIndex = 0;
            // 
            // controlTextBox5
            // 
            this.controlTextBox5.Campo = "idSpecie";
            this.controlTextBox5.CausesValidation = false;
            this.controlTextBox5.ControlSds = null;
            this.controlTextBox5.EsForanea = true;
            this.controlTextBox5.EsTipo = Control_FNATIK.ControlTextBox.Tipos.Numero;
            this.controlTextBox5.Location = new System.Drawing.Point(360, 256);
            this.controlTextBox5.Name = "controlTextBox5";
            this.controlTextBox5.NoSalirSiVacia = false;
            this.controlTextBox5.Size = new System.Drawing.Size(25, 20);
            this.controlTextBox5.TabIndex = 0;
            // 
            // sdsCodi1
            // 
            this.sdsCodi1.AbreCS = null;
            this.sdsCodi1.CausesValidation = false;
            this.sdsCodi1.ClaseCS = null;
            this.sdsCodi1.ControlID = "controlTextBox2";
            this.sdsCodi1.FormCS = null;
            this.sdsCodi1.Location = new System.Drawing.Point(55, 140);
            this.sdsCodi1.Name = "sdsCodi1";
            this.sdsCodi1.NombreCodi = "CodeRank";
            this.sdsCodi1.NombreDesc = "DescRank";
            this.sdsCodi1.NombreID = "IdUserRank";
            this.sdsCodi1.NombreTaula = "UserRanks";
            this.sdsCodi1.Requerido = false;
            this.sdsCodi1.Size = new System.Drawing.Size(304, 26);
            this.sdsCodi1.TabIndex = 2;
            this.sdsCodi1.TextLabel = "Rango:";
            // 
            // sdsCodi2
            // 
            this.sdsCodi2.AbreCS = null;
            this.sdsCodi2.CausesValidation = false;
            this.sdsCodi2.ClaseCS = null;
            this.sdsCodi2.ControlID = "controlTextBox3";
            this.sdsCodi2.FormCS = null;
            this.sdsCodi2.Location = new System.Drawing.Point(55, 178);
            this.sdsCodi2.Name = "sdsCodi2";
            this.sdsCodi2.NombreCodi = "CodeCategory";
            this.sdsCodi2.NombreDesc = "DescCategory";
            this.sdsCodi2.NombreID = "IdUserCategory";
            this.sdsCodi2.NombreTaula = "UserCategories";
            this.sdsCodi2.Requerido = false;
            this.sdsCodi2.Size = new System.Drawing.Size(304, 26);
            this.sdsCodi2.TabIndex = 3;
            this.sdsCodi2.TextLabel = "Categoria:";
            // 
            // sdsCodi3
            // 
            this.sdsCodi3.AbreCS = null;
            this.sdsCodi3.CausesValidation = false;
            this.sdsCodi3.ClaseCS = null;
            this.sdsCodi3.ControlID = "controlTextBox4";
            this.sdsCodi3.FormCS = null;
            this.sdsCodi3.Location = new System.Drawing.Point(55, 216);
            this.sdsCodi3.Name = "sdsCodi3";
            this.sdsCodi3.NombreCodi = "CodePlanet";
            this.sdsCodi3.NombreDesc = "DescPlanet";
            this.sdsCodi3.NombreID = "IdPlanet";
            this.sdsCodi3.NombreTaula = "Planets";
            this.sdsCodi3.Requerido = false;
            this.sdsCodi3.Size = new System.Drawing.Size(304, 26);
            this.sdsCodi3.TabIndex = 4;
            this.sdsCodi3.TextLabel = "Planeta:";
            // 
            // sdsCodi4
            // 
            this.sdsCodi4.AbreCS = null;
            this.sdsCodi4.CausesValidation = false;
            this.sdsCodi4.ClaseCS = null;
            this.sdsCodi4.ControlID = "controlTextBox5";
            this.sdsCodi4.FormCS = null;
            this.sdsCodi4.Location = new System.Drawing.Point(55, 253);
            this.sdsCodi4.Name = "sdsCodi4";
            this.sdsCodi4.NombreCodi = "CodeSpecie";
            this.sdsCodi4.NombreDesc = "DescSpecie";
            this.sdsCodi4.NombreID = "IdSpecie";
            this.sdsCodi4.NombreTaula = "Species";
            this.sdsCodi4.Requerido = false;
            this.sdsCodi4.Size = new System.Drawing.Size(304, 26);
            this.sdsCodi4.TabIndex = 5;
            this.sdsCodi4.TextLabel = "Especie:";
            // 
            // LabelTitulo
            // 
            this.LabelTitulo.AutoSize = true;
            this.LabelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTitulo.Location = new System.Drawing.Point(35, 33);
            this.LabelTitulo.Name = "LabelTitulo";
            this.LabelTitulo.Size = new System.Drawing.Size(254, 25);
            this.LabelTitulo.TabIndex = 0;
            this.LabelTitulo.Text = "GESTIÓN DE USUARIOS";
            // 
            // LabelUsuario
            // 
            this.LabelUsuario.AutoSize = true;
            this.LabelUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelUsuario.Location = new System.Drawing.Point(89, 87);
            this.LabelUsuario.Name = "LabelUsuario";
            this.LabelUsuario.Size = new System.Drawing.Size(68, 20);
            this.LabelUsuario.TabIndex = 0;
            this.LabelUsuario.Text = "Usuario:";
            // 
            // Form_usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 410);
            this.Controls.Add(this.LabelUsuario);
            this.Controls.Add(this.LabelTitulo);
            this.Controls.Add(this.sdsCodi4);
            this.Controls.Add(this.sdsCodi3);
            this.Controls.Add(this.sdsCodi2);
            this.Controls.Add(this.sdsCodi1);
            this.Controls.Add(this.controlTextBox5);
            this.Controls.Add(this.controlTextBox4);
            this.Controls.Add(this.controlTextBox3);
            this.Controls.Add(this.controlTextBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.controlTextBox1);
            this.Name = "Form_usuarios";
            this.Text = "Form_usuarios";
            this.Load += new System.EventHandler(this.Form_usuarios_Load);
            this.Controls.SetChildIndex(this.controlTextBox1, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.controlTextBox2, 0);
            this.Controls.SetChildIndex(this.controlTextBox3, 0);
            this.Controls.SetChildIndex(this.controlTextBox4, 0);
            this.Controls.SetChildIndex(this.controlTextBox5, 0);
            this.Controls.SetChildIndex(this.sdsCodi1, 0);
            this.Controls.SetChildIndex(this.sdsCodi2, 0);
            this.Controls.SetChildIndex(this.sdsCodi3, 0);
            this.Controls.SetChildIndex(this.sdsCodi4, 0);
            this.Controls.SetChildIndex(this.LabelTitulo, 0);
            this.Controls.SetChildIndex(this.LabelUsuario, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Control_FNATIK.ControlTextBox controlTextBox1;
        private System.Windows.Forms.Panel panel1;
        private Control_FNATIK.ControlTextBox controlTextBox2;
        private Control_FNATIK.ControlTextBox controlTextBox3;
        private Control_FNATIK.ControlTextBox controlTextBox4;
        private Control_FNATIK.ControlTextBox controlTextBox5;
        private sdsCodi.sdsCodi sdsCodi1;
        private sdsCodi.sdsCodi sdsCodi2;
        private sdsCodi.sdsCodi sdsCodi3;
        private sdsCodi.sdsCodi sdsCodi4;
        private System.Windows.Forms.Label LabelTitulo;
        private System.Windows.Forms.Label LabelUsuario;
    }
}