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
            this.panel1 = new System.Windows.Forms.Panel();
            this.controlTextBox3 = new Control_FNATIK.ControlTextBox();
            this.controlTextBox2 = new Control_FNATIK.ControlTextBox();
            this.controlTextBox1 = new Control_FNATIK.ControlTextBox();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(588, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 6;
            // 
            // controlTextBox3
            // 
            this.controlTextBox3.Campo = "idUserRank";
            this.controlTextBox3.Enabled = false;
            this.controlTextBox3.EsForanea = false;
            this.controlTextBox3.EsTipo = Control_FNATIK.ControlTextBox.Tipos.Numero;
            this.controlTextBox3.Location = new System.Drawing.Point(646, 85);
            this.controlTextBox3.Name = "controlTextBox3";
            this.controlTextBox3.NoSalirSiVacia = false;
            this.controlTextBox3.Size = new System.Drawing.Size(26, 20);
            this.controlTextBox3.TabIndex = 5;
            // 
            // controlTextBox2
            // 
            this.controlTextBox2.Campo = "DescRank";
            this.controlTextBox2.EsForanea = false;
            this.controlTextBox2.EsTipo = Control_FNATIK.ControlTextBox.Tipos.Texto;
            this.controlTextBox2.Location = new System.Drawing.Point(306, 119);
            this.controlTextBox2.Name = "controlTextBox2";
            this.controlTextBox2.NoSalirSiVacia = false;
            this.controlTextBox2.Size = new System.Drawing.Size(100, 20);
            this.controlTextBox2.TabIndex = 4;
            // 
            // controlTextBox1
            // 
            this.controlTextBox1.Campo = "CodeRank";
            this.controlTextBox1.EsForanea = false;
            this.controlTextBox1.EsTipo = Control_FNATIK.ControlTextBox.Tipos.Texto;
            this.controlTextBox1.Location = new System.Drawing.Point(306, 63);
            this.controlTextBox1.Name = "controlTextBox1";
            this.controlTextBox1.NoSalirSiVacia = false;
            this.controlTextBox1.Size = new System.Drawing.Size(100, 20);
            this.controlTextBox1.TabIndex = 3;
            // 
            // Form_categorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.controlTextBox3);
            this.Controls.Add(this.controlTextBox2);
            this.Controls.Add(this.controlTextBox1);
            this.Name = "Form_categorias";
            this.Text = "Form_categorias";
            this.Load += new System.EventHandler(this.Form_categorias_Load_1);
            this.Controls.SetChildIndex(this.controlTextBox1, 0);
            this.Controls.SetChildIndex(this.controlTextBox2, 0);
            this.Controls.SetChildIndex(this.controlTextBox3, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Control_FNATIK.ControlTextBox controlTextBox1;
        private Control_FNATIK.ControlTextBox controlTextBox2;
        private Control_FNATIK.ControlTextBox controlTextBox3;
        private System.Windows.Forms.Panel panel1;
    }
}