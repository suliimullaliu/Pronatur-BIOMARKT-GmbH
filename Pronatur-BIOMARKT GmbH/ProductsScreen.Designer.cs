namespace Pronatur_BIOMARKT_GmbH
{
    partial class ProductsScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductsScreen));
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxProductName = new System.Windows.Forms.TextBox();
            this.textBoxProductBrand = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPreis = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxKategorie = new System.Windows.Forms.ComboBox();
            this.btnProductSave = new System.Windows.Forms.Button();
            this.btnProductDelete = new System.Windows.Forms.Button();
            this.btnProductClear = new System.Windows.Forms.Button();
            this.btnProductEdit = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(21, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
  
            // 
            // textBoxProductName
            // 
            this.textBoxProductName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.textBoxProductName.ForeColor = System.Drawing.Color.White;
            this.textBoxProductName.Location = new System.Drawing.Point(108, 27);
            this.textBoxProductName.Name = "textBoxProductName";
            this.textBoxProductName.Size = new System.Drawing.Size(272, 20);
            this.textBoxProductName.TabIndex = 1;
            // 
            // textBoxProductBrand
            // 
            this.textBoxProductBrand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.textBoxProductBrand.ForeColor = System.Drawing.Color.White;
            this.textBoxProductBrand.Location = new System.Drawing.Point(108, 51);
            this.textBoxProductBrand.Name = "textBoxProductBrand";
            this.textBoxProductBrand.Size = new System.Drawing.Size(170, 20);
            this.textBoxProductBrand.TabIndex = 3;
            this.textBoxProductBrand.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(21, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Marke";

            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(21, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Kategorie";
            // 
            // textBoxPreis
            // 
            this.textBoxPreis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.textBoxPreis.ForeColor = System.Drawing.Color.White;
            this.textBoxPreis.Location = new System.Drawing.Point(108, 105);
            this.textBoxPreis.Name = "textBoxPreis";
            this.textBoxPreis.Size = new System.Drawing.Size(75, 20);
            this.textBoxPreis.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(21, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Preis";
            // 
            // comboBoxKategorie
            // 
            this.comboBoxKategorie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.comboBoxKategorie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxKategorie.ForeColor = System.Drawing.Color.White;
            this.comboBoxKategorie.FormattingEnabled = true;
            this.comboBoxKategorie.Items.AddRange(new object[] {
            "Obst",
            "Gemüse",
            "Fleich",
            "Fisch",
            "Drogerie",
            "Getränke"});
            this.comboBoxKategorie.Location = new System.Drawing.Point(108, 77);
            this.comboBoxKategorie.Name = "comboBoxKategorie";
            this.comboBoxKategorie.Size = new System.Drawing.Size(170, 21);
            this.comboBoxKategorie.TabIndex = 8;
            this.comboBoxKategorie.Text = "Obst";
            // 
            // btnProductSave
            // 
            this.btnProductSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnProductSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnProductSave.ForeColor = System.Drawing.Color.White;
            this.btnProductSave.Location = new System.Drawing.Point(108, 143);
            this.btnProductSave.Name = "btnProductSave";
            this.btnProductSave.Size = new System.Drawing.Size(75, 23);
            this.btnProductSave.TabIndex = 9;
            this.btnProductSave.Text = "Speichern";
            this.btnProductSave.UseVisualStyleBackColor = false;
            this.btnProductSave.Click += new System.EventHandler(this.btnProductSave_Click);
            // 
            // btnProductDelete
            // 
            this.btnProductDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnProductDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnProductDelete.ForeColor = System.Drawing.Color.White;
            this.btnProductDelete.Location = new System.Drawing.Point(386, 143);
            this.btnProductDelete.Name = "btnProductDelete";
            this.btnProductDelete.Size = new System.Drawing.Size(75, 23);
            this.btnProductDelete.TabIndex = 10;
            this.btnProductDelete.Text = "Löchen";
            this.btnProductDelete.UseVisualStyleBackColor = false;
            this.btnProductDelete.Click += new System.EventHandler(this.btnProductDelete_Click);
            // 
            // btnProductClear
            // 
            this.btnProductClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnProductClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnProductClear.ForeColor = System.Drawing.Color.White;
            this.btnProductClear.Location = new System.Drawing.Point(284, 143);
            this.btnProductClear.Name = "btnProductClear";
            this.btnProductClear.Size = new System.Drawing.Size(96, 23);
            this.btnProductClear.TabIndex = 11;
            this.btnProductClear.Text = "Felder Leeren";
            this.btnProductClear.UseVisualStyleBackColor = false;
            this.btnProductClear.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnProductEdit
            // 
            this.btnProductEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnProductEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnProductEdit.ForeColor = System.Drawing.Color.White;
            this.btnProductEdit.Location = new System.Drawing.Point(189, 143);
            this.btnProductEdit.Name = "btnProductEdit";
            this.btnProductEdit.Size = new System.Drawing.Size(89, 23);
            this.btnProductEdit.TabIndex = 12;
            this.btnProductEdit.Text = "Bearbeiten";
            this.btnProductEdit.UseVisualStyleBackColor = false;
            this.btnProductEdit.Click += new System.EventHandler(this.btnProductEdit_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 195);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(763, 247);
            this.dataGridView1.TabIndex = 13;
            // 
            // ProductsScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(799, 461);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnProductEdit);
            this.Controls.Add(this.btnProductClear);
            this.Controls.Add(this.btnProductDelete);
            this.Controls.Add(this.btnProductSave);
            this.Controls.Add(this.comboBoxKategorie);
            this.Controls.Add(this.textBoxPreis);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxProductBrand);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxProductName);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "ProductsScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductsScreen";
            this.Load += new System.EventHandler(this.ProductsScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxProductName;
        private System.Windows.Forms.TextBox textBoxProductBrand;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPreis;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxKategorie;
        private System.Windows.Forms.Button btnProductSave;
        private System.Windows.Forms.Button btnProductDelete;
        private System.Windows.Forms.Button btnProductClear;
        private System.Windows.Forms.Button btnProductEdit;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}