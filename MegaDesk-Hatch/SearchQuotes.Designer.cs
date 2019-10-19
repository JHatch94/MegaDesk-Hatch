namespace MegaDesk_Hatch
{
    partial class SearchQuotes
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
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.comSurfaceMaterial = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.Location = new System.Drawing.Point(569, 362);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(219, 76);
            this.btnMainMenu.TabIndex = 0;
            this.btnMainMenu.Text = "Main Menu";
            this.btnMainMenu.UseVisualStyleBackColor = true;
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // comSurfaceMaterial
            // 
            this.comSurfaceMaterial.FormattingEnabled = true;
            this.comSurfaceMaterial.Location = new System.Drawing.Point(12, 12);
            this.comSurfaceMaterial.Name = "comSurfaceMaterial";
            this.comSurfaceMaterial.Size = new System.Drawing.Size(120, 24);
            this.comSurfaceMaterial.TabIndex = 19;
            this.comSurfaceMaterial.SelectedIndexChanged += new System.EventHandler(this.comSurfaceMaterial_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(776, 313);
            this.dataGridView1.TabIndex = 20;
            // 
            // SearchQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comSurfaceMaterial);
            this.Controls.Add(this.btnMainMenu);
            this.Name = "SearchQuotes";
            this.Text = "SearchQuotes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMainMenu;
        private System.Windows.Forms.ComboBox comSurfaceMaterial;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}