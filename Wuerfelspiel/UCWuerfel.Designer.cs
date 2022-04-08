
namespace Wuerfelspiel
{
    partial class UCWuerfel
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

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnWuerfeln = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnWuerfeln
            // 
            this.btnWuerfeln.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnWuerfeln.Location = new System.Drawing.Point(0, 127);
            this.btnWuerfeln.Name = "btnWuerfeln";
            this.btnWuerfeln.Size = new System.Drawing.Size(150, 23);
            this.btnWuerfeln.TabIndex = 0;
            this.btnWuerfeln.Text = "Würfeln";
            this.btnWuerfeln.UseVisualStyleBackColor = true;
            this.btnWuerfeln.Click += new System.EventHandler(this.btnWuerfeln_Click);
            // 
            // UCWuerfel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnWuerfeln);
            this.Name = "UCWuerfel";
            this.Load += new System.EventHandler(this.UCWuerfel_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.UCWuerfel_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnWuerfeln;
    }
}
