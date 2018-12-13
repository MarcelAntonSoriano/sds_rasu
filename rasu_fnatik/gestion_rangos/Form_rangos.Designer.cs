namespace gestion_rangos
{
    partial class Form_rangos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_rangos));
            this.controlTextBox3 = new Control_FNATIK.ControlTextBox();
            this.controlTextBox2 = new Control_FNATIK.ControlTextBox();
            this.controlTextBox1 = new Control_FNATIK.ControlTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // controlTextBox3
            // 
            this.controlTextBox3.Campo = "idUserRank";
            this.controlTextBox3.CausesValidation = false;
            this.controlTextBox3.ControlSds = null;
            this.controlTextBox3.Enabled = false;
            this.controlTextBox3.EsForanea = false;
            this.controlTextBox3.EsTipo = Control_FNATIK.ControlTextBox.Tipos.Numero;
            this.controlTextBox3.Location = new System.Drawing.Point(590, 82);
            this.controlTextBox3.Name = "controlTextBox3";
            this.controlTextBox3.NoSalirSiVacia = false;
            this.controlTextBox3.Size = new System.Drawing.Size(22, 20);
            this.controlTextBox3.TabIndex = 5;
            // 
            // controlTextBox2
            // 
            this.controlTextBox2.Campo = "DescRank";
            this.controlTextBox2.CausesValidation = false;
            this.controlTextBox2.ControlSds = null;
            this.controlTextBox2.EsForanea = false;
            this.controlTextBox2.EsTipo = Control_FNATIK.ControlTextBox.Tipos.Texto;
            this.controlTextBox2.Location = new System.Drawing.Point(390, 134);
            this.controlTextBox2.Name = "controlTextBox2";
            this.controlTextBox2.NoSalirSiVacia = false;
            this.controlTextBox2.Size = new System.Drawing.Size(100, 20);
            this.controlTextBox2.TabIndex = 4;
            // 
            // controlTextBox1
            // 
            this.controlTextBox1.Campo = "CodeRank";
            this.controlTextBox1.CausesValidation = false;
            this.controlTextBox1.ControlSds = null;
            this.controlTextBox1.EsForanea = false;
            this.controlTextBox1.EsTipo = Control_FNATIK.ControlTextBox.Tipos.Texto;
            this.controlTextBox1.Location = new System.Drawing.Point(390, 85);
            this.controlTextBox1.Name = "controlTextBox1";
            this.controlTextBox1.NoSalirSiVacia = false;
            this.controlTextBox1.Size = new System.Drawing.Size(100, 20);
            this.controlTextBox1.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(575, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(117, 64);
            this.panel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(273, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Codigo de Rango:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(300, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Descripcion:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(12, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(236, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "GESTIÓN DE RANGOS";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 10;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "X";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // Form_rangos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.controlTextBox3);
            this.Controls.Add(this.controlTextBox2);
            this.Controls.Add(this.controlTextBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_rangos";
            this.Text = "Gestión de Rangos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form_rangos_Load);
            this.Controls.SetChildIndex(this.controlTextBox1, 0);
            this.Controls.SetChildIndex(this.controlTextBox2, 0);
            this.Controls.SetChildIndex(this.controlTextBox3, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.toolStrip1, 0);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Control_FNATIK.ControlTextBox controlTextBox1;
        private Control_FNATIK.ControlTextBox controlTextBox2;
        private Control_FNATIK.ControlTextBox controlTextBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}