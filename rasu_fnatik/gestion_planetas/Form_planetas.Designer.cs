namespace gestion_planetas
{
    partial class Form_planetas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_planetas));
            this.controlTextBox11 = new Control_FNATIK.ControlTextBox();
            this.controlTextBox10 = new Control_FNATIK.ControlTextBox();
            this.controlTextBox9 = new Control_FNATIK.ControlTextBox();
            this.sdsCodi3 = new sdsCodi.sdsCodi();
            this.sdsCodi2 = new sdsCodi.sdsCodi();
            this.sdsCodi1 = new sdsCodi.sdsCodi();
            this.controlTextBox8 = new Control_FNATIK.ControlTextBox();
            this.controlTextBox7 = new Control_FNATIK.ControlTextBox();
            this.controlTextBox6 = new Control_FNATIK.ControlTextBox();
            this.controlTextBox5 = new Control_FNATIK.ControlTextBox();
            this.controlTextBox4 = new Control_FNATIK.ControlTextBox();
            this.controlTextBox3 = new Control_FNATIK.ControlTextBox();
            this.controlTextBox2 = new Control_FNATIK.ControlTextBox();
            this.controlTextBox1 = new Control_FNATIK.ControlTextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // controlTextBox11
            // 
            this.controlTextBox11.Campo = "idFiliation";
            this.controlTextBox11.CausesValidation = false;
            this.controlTextBox11.ControlSds = null;
            this.controlTextBox11.EsForanea = true;
            this.controlTextBox11.EsTipo = Control_FNATIK.ControlTextBox.Tipos.Texto;
            this.controlTextBox11.Location = new System.Drawing.Point(393, 456);
            this.controlTextBox11.Name = "controlTextBox11";
            this.controlTextBox11.NoSalirSiVacia = false;
            this.controlTextBox11.Size = new System.Drawing.Size(23, 20);
            this.controlTextBox11.TabIndex = 17;
            // 
            // controlTextBox10
            // 
            this.controlTextBox10.Campo = "idNatives";
            this.controlTextBox10.CausesValidation = false;
            this.controlTextBox10.ControlSds = null;
            this.controlTextBox10.EsForanea = true;
            this.controlTextBox10.EsTipo = Control_FNATIK.ControlTextBox.Tipos.Texto;
            this.controlTextBox10.Location = new System.Drawing.Point(393, 424);
            this.controlTextBox10.Name = "controlTextBox10";
            this.controlTextBox10.NoSalirSiVacia = false;
            this.controlTextBox10.Size = new System.Drawing.Size(23, 20);
            this.controlTextBox10.TabIndex = 16;
            // 
            // controlTextBox9
            // 
            this.controlTextBox9.Campo = "idSector";
            this.controlTextBox9.CausesValidation = false;
            this.controlTextBox9.ControlSds = null;
            this.controlTextBox9.EsForanea = true;
            this.controlTextBox9.EsTipo = Control_FNATIK.ControlTextBox.Tipos.Texto;
            this.controlTextBox9.Location = new System.Drawing.Point(393, 314);
            this.controlTextBox9.Name = "controlTextBox9";
            this.controlTextBox9.NoSalirSiVacia = false;
            this.controlTextBox9.Size = new System.Drawing.Size(23, 20);
            this.controlTextBox9.TabIndex = 15;
            // 
            // sdsCodi3
            // 
            this.sdsCodi3.AbreCS = null;
            this.sdsCodi3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.sdsCodi3.CausesValidation = false;
            this.sdsCodi3.ClaseCS = "Form_cerca.dll";
            this.sdsCodi3.ControlID = "controlTextBox11";
            this.sdsCodi3.FormCS = "Form_cerca.Form_cerca";
            this.sdsCodi3.Location = new System.Drawing.Point(72, 365);
            this.sdsCodi3.Name = "sdsCodi3";
            this.sdsCodi3.NombreCodi = "CodeFiliation";
            this.sdsCodi3.NombreDesc = "DescFiliations";
            this.sdsCodi3.NombreID = "idFiliation";
            this.sdsCodi3.NombreTaula = "Filiations";
            this.sdsCodi3.Requerido = false;
            this.sdsCodi3.Size = new System.Drawing.Size(304, 26);
            this.sdsCodi3.TabIndex = 14;
            this.sdsCodi3.TextLabel = "Afiliaciones:     ";
            // 
            // sdsCodi2
            // 
            this.sdsCodi2.AbreCS = null;
            this.sdsCodi2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.sdsCodi2.CausesValidation = false;
            this.sdsCodi2.ClaseCS = "Form_cerca.dll";
            this.sdsCodi2.ControlID = "controlTextBox10";
            this.sdsCodi2.FormCS = "Form_cerca.Form_cerca";
            this.sdsCodi2.Location = new System.Drawing.Point(72, 331);
            this.sdsCodi2.Name = "sdsCodi2";
            this.sdsCodi2.NombreCodi = "CodeSpecie";
            this.sdsCodi2.NombreDesc = "DescSpecie";
            this.sdsCodi2.NombreID = "idSpecie";
            this.sdsCodi2.NombreTaula = "Species";
            this.sdsCodi2.Requerido = false;
            this.sdsCodi2.Size = new System.Drawing.Size(304, 26);
            this.sdsCodi2.TabIndex = 13;
            this.sdsCodi2.TextLabel = "Nativo:";
            // 
            // sdsCodi1
            // 
            this.sdsCodi1.AbreCS = null;
            this.sdsCodi1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.sdsCodi1.CausesValidation = false;
            this.sdsCodi1.ClaseCS = "Form_cerca.dll";
            this.sdsCodi1.ControlID = "controlTextBox9";
            this.sdsCodi1.FormCS = "Form_cerca.Form_cerca";
            this.sdsCodi1.Location = new System.Drawing.Point(74, 183);
            this.sdsCodi1.Name = "sdsCodi1";
            this.sdsCodi1.NombreCodi = "CodeSector";
            this.sdsCodi1.NombreDesc = "DescSector";
            this.sdsCodi1.NombreID = "idSector";
            this.sdsCodi1.NombreTaula = "Sectors";
            this.sdsCodi1.Requerido = false;
            this.sdsCodi1.Size = new System.Drawing.Size(304, 26);
            this.sdsCodi1.TabIndex = 12;
            this.sdsCodi1.TextLabel = "Sector:";
            // 
            // controlTextBox8
            // 
            this.controlTextBox8.Campo = "PortPlanet";
            this.controlTextBox8.CausesValidation = false;
            this.controlTextBox8.ControlSds = null;
            this.controlTextBox8.EsForanea = false;
            this.controlTextBox8.EsTipo = Control_FNATIK.ControlTextBox.Tipos.Texto;
            this.controlTextBox8.Location = new System.Drawing.Point(158, 473);
            this.controlTextBox8.MaxLength = 4;
            this.controlTextBox8.Name = "controlTextBox8";
            this.controlTextBox8.NoSalirSiVacia = false;
            this.controlTextBox8.Size = new System.Drawing.Size(100, 20);
            this.controlTextBox8.TabIndex = 11;
            // 
            // controlTextBox7
            // 
            this.controlTextBox7.Campo = "IPPlanet";
            this.controlTextBox7.CausesValidation = false;
            this.controlTextBox7.ControlSds = null;
            this.controlTextBox7.EsForanea = false;
            this.controlTextBox7.EsTipo = Control_FNATIK.ControlTextBox.Tipos.Texto;
            this.controlTextBox7.Location = new System.Drawing.Point(159, 438);
            this.controlTextBox7.MaxLength = 15;
            this.controlTextBox7.Name = "controlTextBox7";
            this.controlTextBox7.NoSalirSiVacia = false;
            this.controlTextBox7.Size = new System.Drawing.Size(100, 20);
            this.controlTextBox7.TabIndex = 10;
            // 
            // controlTextBox6
            // 
            this.controlTextBox6.Campo = "PlanetPicture";
            this.controlTextBox6.CausesValidation = false;
            this.controlTextBox6.ControlSds = null;
            this.controlTextBox6.EsForanea = false;
            this.controlTextBox6.EsTipo = Control_FNATIK.ControlTextBox.Tipos.Texto;
            this.controlTextBox6.Location = new System.Drawing.Point(159, 403);
            this.controlTextBox6.MaxLength = 200;
            this.controlTextBox6.Name = "controlTextBox6";
            this.controlTextBox6.NoSalirSiVacia = false;
            this.controlTextBox6.Size = new System.Drawing.Size(100, 20);
            this.controlTextBox6.TabIndex = 9;
            // 
            // controlTextBox5
            // 
            this.controlTextBox5.Campo = "parsecs";
            this.controlTextBox5.CausesValidation = false;
            this.controlTextBox5.ControlSds = null;
            this.controlTextBox5.EsForanea = false;
            this.controlTextBox5.EsTipo = Control_FNATIK.ControlTextBox.Tipos.Numero;
            this.controlTextBox5.Location = new System.Drawing.Point(160, 298);
            this.controlTextBox5.MaxLength = 12;
            this.controlTextBox5.Name = "controlTextBox5";
            this.controlTextBox5.NoSalirSiVacia = false;
            this.controlTextBox5.Size = new System.Drawing.Size(100, 20);
            this.controlTextBox5.TabIndex = 8;
            this.controlTextBox5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.controlTextBox5_KeyPress);
            // 
            // controlTextBox4
            // 
            this.controlTextBox4.Campo = "lat";
            this.controlTextBox4.CausesValidation = false;
            this.controlTextBox4.ControlSds = null;
            this.controlTextBox4.EsForanea = false;
            this.controlTextBox4.EsTipo = Control_FNATIK.ControlTextBox.Tipos.Numero;
            this.controlTextBox4.Location = new System.Drawing.Point(160, 261);
            this.controlTextBox4.MaxLength = 12;
            this.controlTextBox4.Name = "controlTextBox4";
            this.controlTextBox4.NoSalirSiVacia = false;
            this.controlTextBox4.Size = new System.Drawing.Size(100, 20);
            this.controlTextBox4.TabIndex = 7;
            this.controlTextBox4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.controlTextBox4_KeyPress);
            // 
            // controlTextBox3
            // 
            this.controlTextBox3.Campo = "long";
            this.controlTextBox3.CausesValidation = false;
            this.controlTextBox3.ControlSds = null;
            this.controlTextBox3.EsForanea = false;
            this.controlTextBox3.EsTipo = Control_FNATIK.ControlTextBox.Tipos.Numero;
            this.controlTextBox3.Location = new System.Drawing.Point(160, 224);
            this.controlTextBox3.MaxLength = 12;
            this.controlTextBox3.Name = "controlTextBox3";
            this.controlTextBox3.NoSalirSiVacia = false;
            this.controlTextBox3.Size = new System.Drawing.Size(100, 20);
            this.controlTextBox3.TabIndex = 6;
            this.controlTextBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.controlTextBox3_KeyPress);
            // 
            // controlTextBox2
            // 
            this.controlTextBox2.Campo = "DescPlanet";
            this.controlTextBox2.CausesValidation = false;
            this.controlTextBox2.ControlSds = null;
            this.controlTextBox2.EsForanea = false;
            this.controlTextBox2.EsTipo = Control_FNATIK.ControlTextBox.Tipos.Texto;
            this.controlTextBox2.Location = new System.Drawing.Point(162, 152);
            this.controlTextBox2.MaxLength = 50;
            this.controlTextBox2.Name = "controlTextBox2";
            this.controlTextBox2.NoSalirSiVacia = false;
            this.controlTextBox2.Size = new System.Drawing.Size(100, 20);
            this.controlTextBox2.TabIndex = 5;
            // 
            // controlTextBox1
            // 
            this.controlTextBox1.Campo = "CodePlanet";
            this.controlTextBox1.CausesValidation = false;
            this.controlTextBox1.ControlSds = null;
            this.controlTextBox1.EsForanea = false;
            this.controlTextBox1.EsTipo = Control_FNATIK.ControlTextBox.Tipos.Texto;
            this.controlTextBox1.Location = new System.Drawing.Point(163, 114);
            this.controlTextBox1.MaxLength = 4;
            this.controlTextBox1.Name = "controlTextBox1";
            this.controlTextBox1.NoSalirSiVacia = false;
            this.controlTextBox1.Size = new System.Drawing.Size(100, 20);
            this.controlTextBox1.TabIndex = 4;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1275, 25);
            this.toolStrip1.TabIndex = 18;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton1.AutoToolTip = false;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "X";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlText;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(135, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(204, 25);
            this.label5.TabIndex = 20;
            this.label5.Text = "Gestión de planetas";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(382, 238);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(45, 246);
            this.panel2.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(56, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Codigo Planeta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(71, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Descripción:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(85, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Longitud:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(94, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Latitud:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(89, 301);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Parsecs:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(102, 406);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Foto:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(74, 442);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = "IP Planeta:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(92, 476);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 30;
            this.label9.Text = "Puerto:";
            // 
            // Form_planetas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::gestion_planetas.Properties.Resources._1305869556_star_wars_pulp_fiction_wallpaper;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1275, 608);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.controlTextBox11);
            this.Controls.Add(this.controlTextBox10);
            this.Controls.Add(this.controlTextBox9);
            this.Controls.Add(this.sdsCodi3);
            this.Controls.Add(this.sdsCodi2);
            this.Controls.Add(this.sdsCodi1);
            this.Controls.Add(this.controlTextBox8);
            this.Controls.Add(this.controlTextBox7);
            this.Controls.Add(this.controlTextBox6);
            this.Controls.Add(this.controlTextBox5);
            this.Controls.Add(this.controlTextBox4);
            this.Controls.Add(this.controlTextBox3);
            this.Controls.Add(this.controlTextBox2);
            this.Controls.Add(this.controlTextBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_planetas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_planetas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form_planetas_Load);
            this.Controls.SetChildIndex(this.controlTextBox1, 0);
            this.Controls.SetChildIndex(this.controlTextBox2, 0);
            this.Controls.SetChildIndex(this.controlTextBox3, 0);
            this.Controls.SetChildIndex(this.controlTextBox4, 0);
            this.Controls.SetChildIndex(this.controlTextBox5, 0);
            this.Controls.SetChildIndex(this.controlTextBox6, 0);
            this.Controls.SetChildIndex(this.controlTextBox7, 0);
            this.Controls.SetChildIndex(this.controlTextBox8, 0);
            this.Controls.SetChildIndex(this.sdsCodi1, 0);
            this.Controls.SetChildIndex(this.sdsCodi2, 0);
            this.Controls.SetChildIndex(this.sdsCodi3, 0);
            this.Controls.SetChildIndex(this.controlTextBox9, 0);
            this.Controls.SetChildIndex(this.controlTextBox10, 0);
            this.Controls.SetChildIndex(this.controlTextBox11, 0);
            this.Controls.SetChildIndex(this.toolStrip1, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Control_FNATIK.ControlTextBox controlTextBox1;
        private Control_FNATIK.ControlTextBox controlTextBox2;
        private Control_FNATIK.ControlTextBox controlTextBox3;
        private Control_FNATIK.ControlTextBox controlTextBox4;
        private Control_FNATIK.ControlTextBox controlTextBox5;
        private Control_FNATIK.ControlTextBox controlTextBox6;
        private Control_FNATIK.ControlTextBox controlTextBox7;
        private Control_FNATIK.ControlTextBox controlTextBox8;
        private sdsCodi.sdsCodi sdsCodi1;
        private sdsCodi.sdsCodi sdsCodi2;
        private sdsCodi.sdsCodi sdsCodi3;
        private Control_FNATIK.ControlTextBox controlTextBox9;
        private Control_FNATIK.ControlTextBox controlTextBox10;
        private Control_FNATIK.ControlTextBox controlTextBox11;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}