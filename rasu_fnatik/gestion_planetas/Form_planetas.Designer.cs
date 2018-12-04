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
            this.sdsCodi3.CausesValidation = false;
            this.sdsCodi3.ClaseCS = "Form_cerca.dll";
            this.sdsCodi3.ControlID = "controlTextBox11";
            this.sdsCodi3.FormCS = "Form_cerca.Form_cerca";
            this.sdsCodi3.Location = new System.Drawing.Point(83, 450);
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
            this.sdsCodi2.CausesValidation = false;
            this.sdsCodi2.ClaseCS = "Form_cerca.dll";
            this.sdsCodi2.ControlID = "controlTextBox10";
            this.sdsCodi2.FormCS = "Form_cerca.Form_cerca";
            this.sdsCodi2.Location = new System.Drawing.Point(83, 418);
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
            this.sdsCodi1.CausesValidation = false;
            this.sdsCodi1.ClaseCS = "Form_cerca.dll";
            this.sdsCodi1.ControlID = "controlTextBox9";
            this.sdsCodi1.FormCS = "Form_cerca.Form_cerca";
            this.sdsCodi1.Location = new System.Drawing.Point(83, 308);
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
            this.controlTextBox8.Location = new System.Drawing.Point(169, 534);
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
            this.controlTextBox7.Location = new System.Drawing.Point(169, 508);
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
            this.controlTextBox6.Location = new System.Drawing.Point(169, 482);
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
            this.controlTextBox5.EsTipo = Control_FNATIK.ControlTextBox.Tipos.Texto;
            this.controlTextBox5.Location = new System.Drawing.Point(169, 392);
            this.controlTextBox5.Name = "controlTextBox5";
            this.controlTextBox5.NoSalirSiVacia = false;
            this.controlTextBox5.Size = new System.Drawing.Size(100, 20);
            this.controlTextBox5.TabIndex = 8;
            // 
            // controlTextBox4
            // 
            this.controlTextBox4.Campo = "lat";
            this.controlTextBox4.CausesValidation = false;
            this.controlTextBox4.ControlSds = null;
            this.controlTextBox4.EsForanea = false;
            this.controlTextBox4.EsTipo = Control_FNATIK.ControlTextBox.Tipos.Texto;
            this.controlTextBox4.Location = new System.Drawing.Point(169, 366);
            this.controlTextBox4.Name = "controlTextBox4";
            this.controlTextBox4.NoSalirSiVacia = false;
            this.controlTextBox4.Size = new System.Drawing.Size(100, 20);
            this.controlTextBox4.TabIndex = 7;
            // 
            // controlTextBox3
            // 
            this.controlTextBox3.Campo = "long";
            this.controlTextBox3.CausesValidation = false;
            this.controlTextBox3.ControlSds = null;
            this.controlTextBox3.EsForanea = false;
            this.controlTextBox3.EsTipo = Control_FNATIK.ControlTextBox.Tipos.Texto;
            this.controlTextBox3.Location = new System.Drawing.Point(169, 340);
            this.controlTextBox3.Name = "controlTextBox3";
            this.controlTextBox3.NoSalirSiVacia = false;
            this.controlTextBox3.Size = new System.Drawing.Size(100, 20);
            this.controlTextBox3.TabIndex = 6;
            // 
            // controlTextBox2
            // 
            this.controlTextBox2.Campo = "DescPlanet";
            this.controlTextBox2.CausesValidation = false;
            this.controlTextBox2.ControlSds = null;
            this.controlTextBox2.EsForanea = false;
            this.controlTextBox2.EsTipo = Control_FNATIK.ControlTextBox.Tipos.Texto;
            this.controlTextBox2.Location = new System.Drawing.Point(169, 282);
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
            this.controlTextBox1.Location = new System.Drawing.Point(169, 256);
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
            this.label5.Location = new System.Drawing.Point(99, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(204, 25);
            this.label5.TabIndex = 20;
            this.label5.Text = "Gestión de planetas";
            // 
            // Form_planetas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::gestion_planetas.Properties.Resources._1305869556_star_wars_pulp_fiction_wallpaper;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1275, 608);
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
    }
}