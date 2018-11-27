namespace Sds
{
    partial class sdsCodi
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Label = new System.Windows.Forms.Label();
            this.TextCode = new System.Windows.Forms.TextBox();
            this.TextDesc = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Location = new System.Drawing.Point(16, 13);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(35, 13);
            this.Label.TabIndex = 0;
            this.Label.Text = "label1";
            // 
            // TextCode
            // 
            this.TextCode.Location = new System.Drawing.Point(57, 10);
            this.TextCode.Name = "TextCode";
            this.TextCode.Size = new System.Drawing.Size(100, 20);
            this.TextCode.TabIndex = 1;
            this.TextCode.Leave += new System.EventHandler(this.TextCode_Leave);
            this.TextCode.Validating += new System.ComponentModel.CancelEventHandler(this.TextCode_Validating);
            // 
            // TextDesc
            // 
            this.TextDesc.Location = new System.Drawing.Point(163, 10);
            this.TextDesc.Name = "TextDesc";
            this.TextDesc.Size = new System.Drawing.Size(244, 20);
            this.TextDesc.TabIndex = 2;
            // 
            // sdsCodi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TextDesc);
            this.Controls.Add(this.TextCode);
            this.Controls.Add(this.Label);
            this.Name = "sdsCodi";
            this.Size = new System.Drawing.Size(434, 41);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.TextBox TextCode;
        private System.Windows.Forms.TextBox TextDesc;
    }
}
