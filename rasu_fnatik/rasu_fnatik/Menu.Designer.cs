namespace rasu_fnatik
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.LabelRank = new System.Windows.Forms.ToolStripLabel();
            this.LabelName = new System.Windows.Forms.ToolStripLabel();
            this.LabelTimeLeft = new System.Windows.Forms.ToolStripLabel();
            this.BtnClose = new System.Windows.Forms.ToolStripButton();
            this.BtnMinimize = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(107, 98);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 112);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(245, 98);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 112);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(383, 98);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(132, 112);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(521, 98);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(132, 112);
            this.button4.TabIndex = 3;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LabelRank,
            this.LabelName,
            this.LabelTimeLeft,
            this.BtnClose,
            this.BtnMinimize});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // LabelRank
            // 
            this.LabelRank.Name = "LabelRank";
            this.LabelRank.Size = new System.Drawing.Size(86, 22);
            this.LabelRank.Text = "toolStripLabel1";
            // 
            // LabelName
            // 
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(86, 22);
            this.LabelName.Text = "toolStripLabel2";
            // 
            // LabelTimeLeft
            // 
            this.LabelTimeLeft.Name = "LabelTimeLeft";
            this.LabelTimeLeft.Size = new System.Drawing.Size(86, 22);
            this.LabelTimeLeft.Text = "toolStripLabel3";
            // 
            // BtnClose
            // 
            this.BtnClose.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.BtnClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.BtnClose.Image = ((System.Drawing.Image)(resources.GetObject("BtnClose.Image")));
            this.BtnClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(23, 22);
            this.BtnClose.Text = "X";
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtnMinimize
            // 
            this.BtnMinimize.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.BtnMinimize.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.BtnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("BtnMinimize.Image")));
            this.BtnMinimize.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnMinimize.Name = "BtnMinimize";
            this.BtnMinimize.Size = new System.Drawing.Size(23, 22);
            this.BtnMinimize.Text = "_";
            this.BtnMinimize.Click += new System.EventHandler(this.BtnMinimize_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel LabelRank;
        private System.Windows.Forms.ToolStripLabel LabelName;
        private System.Windows.Forms.ToolStripLabel LabelTimeLeft;
        private System.Windows.Forms.ToolStripButton BtnClose;
        private System.Windows.Forms.ToolStripButton BtnMinimize;
    }
}