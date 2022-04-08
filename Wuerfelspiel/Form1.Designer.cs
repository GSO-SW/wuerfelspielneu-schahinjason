namespace Wuerfelspiel
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.ucWuerfel1 = new Wuerfelspiel.UCWuerfel();
            this.SuspendLayout();
            // 
            // ucWuerfel1
            // 
            this.ucWuerfel1.AutoSize = true;
            this.ucWuerfel1.Location = new System.Drawing.Point(2, 1);
            this.ucWuerfel1.Name = "ucWuerfel1";
            this.ucWuerfel1.Size = new System.Drawing.Size(150, 150);
            this.ucWuerfel1.TabIndex = 0;
            this.ucWuerfel1.Load += new System.EventHandler(this.ucWuerfel1_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ucWuerfel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UCWuerfel ucWuerfel1;
    }
}

