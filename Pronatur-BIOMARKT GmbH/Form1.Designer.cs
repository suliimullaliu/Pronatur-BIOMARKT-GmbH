namespace Pronatur_BIOMARKT_GmbH
{
    partial class ProNatur
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProNatur));
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.Loading = new System.Windows.Forms.Label();
            this.prozentWert = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.progressBar1.Location = new System.Drawing.Point(12, 415);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(776, 23);
            this.progressBar1.TabIndex = 0;
            // 
            // Loading
            // 
            this.Loading.AutoSize = true;
            this.Loading.BackColor = System.Drawing.Color.Transparent;
            this.Loading.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Loading.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.Loading.ForeColor = System.Drawing.Color.White;
            this.Loading.Location = new System.Drawing.Point(301, 341);
            this.Loading.Name = "Loading";
            this.Loading.Padding = new System.Windows.Forms.Padding(20);
            this.Loading.Size = new System.Drawing.Size(150, 71);
            this.Loading.TabIndex = 1;
            this.Loading.Text = "Loading";
            // 
            // prozentWert
            // 
            this.prozentWert.AutoSize = true;
            this.prozentWert.BackColor = System.Drawing.Color.Transparent;
            this.prozentWert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prozentWert.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.prozentWert.ForeColor = System.Drawing.Color.White;
            this.prozentWert.Location = new System.Drawing.Point(423, 341);
            this.prozentWert.Name = "prozentWert";
            this.prozentWert.Padding = new System.Windows.Forms.Padding(20);
            this.prozentWert.Size = new System.Drawing.Size(93, 71);
            this.prozentWert.TabIndex = 2;
            this.prozentWert.Text = "0%";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ProNatur
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.prozentWert);
            this.Controls.Add(this.Loading);
            this.Controls.Add(this.progressBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProNatur";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProNatur Biomarkt GmbH";
            this.Load += new System.EventHandler(this.ProNatur_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label Loading;
        private System.Windows.Forms.Label prozentWert;
        private System.Windows.Forms.Timer timer1;
    }
}

