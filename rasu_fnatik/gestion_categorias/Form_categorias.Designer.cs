namespace gestion_categorias
{
    partial class Form_categorias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_categorias));
            this.panel1 = new System.Windows.Forms.Panel();
            this.controlTextBox4 = new Control_FNATIK.ControlTextBox();
            this.controlTextBox3 = new Control_FNATIK.ControlTextBox();
            this.controlTextBox2 = new Control_FNATIK.ControlTextBox();
            this.controlTextBox1 = new Control_FNATIK.ControlTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(610, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(94, 38);
            this.panel1.TabIndex = 6;
            // 
            // controlTextBox4
            // 
            this.controlTextBox4.Campo = "AccessLevel";
            this.controlTextBox4.CausesValidation = false;
            this.controlTextBox4.ControlSds = null;
            this.controlTextBox4.EsForanea = false;
            this.controlTextBox4.EsTipo = Control_FNATIK.ControlTextBox.Tipos.Numero;
            this.controlTextBox4.Location = new System.Drawing.Point(306, 139);
            this.controlTextBox4.MaxLength = 3;
            this.controlTextBox4.Name = "controlTextBox4";
            this.controlTextBox4.NoSalirSiVacia = false;
            this.controlTextBox4.Size = new System.Drawing.Size(100, 20);
            this.controlTextBox4.TabIndex = 2;
            this.controlTextBox4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.controlTextBox4_KeyPress);
            // 
            // controlTextBox3
            // 
            this.controlTextBox3.Campo = "idUserCategory";
            this.controlTextBox3.CausesValidation = false;
            this.controlTextBox3.ControlSds = null;
            this.controlTextBox3.Enabled = false;
            this.controlTextBox3.EsForanea = false;
            this.controlTextBox3.EsTipo = Control_FNATIK.ControlTextBox.Tipos.Numero;
            this.controlTextBox3.Location = new System.Drawing.Point(633, 89);
            this.controlTextBox3.Name = "controlTextBox3";
            this.controlTextBox3.NoSalirSiVacia = false;
            this.controlTextBox3.Size = new System.Drawing.Size(26, 20);
            this.controlTextBox3.TabIndex = 5;
            // 
            // controlTextBox2
            // 
            this.controlTextBox2.Campo = "DescCategory";
            this.controlTextBox2.CausesValidation = false;
            this.controlTextBox2.ControlSds = null;
            this.controlTextBox2.EsForanea = false;
            this.controlTextBox2.EsTipo = Control_FNATIK.ControlTextBox.Tipos.Texto;
            this.controlTextBox2.Location = new System.Drawing.Point(306, 107);
            this.controlTextBox2.MaxLength = 30;
            this.controlTextBox2.Name = "controlTextBox2";
            this.controlTextBox2.NoSalirSiVacia = false;
            this.controlTextBox2.Size = new System.Drawing.Size(100, 20);
            this.controlTextBox2.TabIndex = 1;
            // 
            // controlTextBox1
            // 
            this.controlTextBox1.Campo = "CodeCategory";
            this.controlTextBox1.CausesValidation = false;
            this.controlTextBox1.ControlSds = null;
            this.controlTextBox1.EsForanea = false;
            this.controlTextBox1.EsTipo = Control_FNATIK.ControlTextBox.Tipos.Texto;
            this.controlTextBox1.Location = new System.Drawing.Point(306, 76);
            this.controlTextBox1.MaxLength = 4;
            this.controlTextBox1.Name = "controlTextBox1";
            this.controlTextBox1.NoSalirSiVacia = false;
            this.controlTextBox1.Size = new System.Drawing.Size(100, 20);
            this.controlTextBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(196, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Codigo Categoria:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(221, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Descripcion:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(196, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Nivel de Acceso:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(12, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(282, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "GESTIÓN DE CATEGORIAS";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 12;
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
            // Form_categorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.controlTextBox4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.controlTextBox3);
            this.Controls.Add(this.controlTextBox2);
            this.Controls.Add(this.controlTextBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "Form_categorias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestión Categorias";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form_categorias_Load_1);
            this.Controls.SetChildIndex(this.controlTextBox1, 0);
            this.Controls.SetChildIndex(this.controlTextBox2, 0);
            this.Controls.SetChildIndex(this.controlTextBox3, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.controlTextBox4, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
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
        private Control_FNATIK.ControlTextBox controlTextBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}