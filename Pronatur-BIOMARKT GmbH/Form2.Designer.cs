namespace Pronatur_BIOMARKT_GmbH
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.Produkte = new System.Windows.Forms.Button();
            this.Rechnung = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Produkte
            // 
            this.Produkte.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Produkte.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Produkte.BackgroundImage")));
            this.Produkte.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.Produkte.ForeColor = System.Drawing.Color.White;
            this.Produkte.Location = new System.Drawing.Point(12, 12);
            this.Produkte.Name = "Produkte";
            this.Produkte.Size = new System.Drawing.Size(275, 125);
            this.Produkte.TabIndex = 0;
            this.Produkte.Text = "Produkte Verwalten";
            this.Produkte.UseVisualStyleBackColor = false;
            this.Produkte.Click += new System.EventHandler(this.Produkte_Click);
            // 
            // Rechnung
            // 
            this.Rechnung.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Rechnung.BackgroundImage")));
            this.Rechnung.Cursor = System.Windows.Forms.Cursors.Default;
            this.Rechnung.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Rechnung.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.Rechnung.ForeColor = System.Drawing.Color.White;
            this.Rechnung.Location = new System.Drawing.Point(306, 12);
            this.Rechnung.Name = "Rechnung";
            this.Rechnung.Size = new System.Drawing.Size(275, 125);
            this.Rechnung.TabIndex = 1;
            this.Rechnung.Text = "Rechnung Erstellen";
            this.Rechnung.UseVisualStyleBackColor = true;
            this.Rechnung.Click += new System.EventHandler(this.Rechnung_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(593, 149);
            this.Controls.Add(this.Rechnung);
            this.Controls.Add(this.Produkte);
            this.MaximizeBox = false;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Produkte;
        private System.Windows.Forms.Button Rechnung;
    }
}