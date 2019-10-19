namespace MegaDesk_Hatch
{
    partial class ViewAllQuotes
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
            this.grdDisplayQuotes = new System.Windows.Forms.DataGridView();
            this.btnMainMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdDisplayQuotes)).BeginInit();
            this.SuspendLayout();
            // 
            // grdDisplayQuotes
            // 
            this.grdDisplayQuotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDisplayQuotes.Location = new System.Drawing.Point(0, 0);
            this.grdDisplayQuotes.Name = "grdDisplayQuotes";
            this.grdDisplayQuotes.RowHeadersWidth = 51;
            this.grdDisplayQuotes.RowTemplate.Height = 24;
            this.grdDisplayQuotes.Size = new System.Drawing.Size(811, 398);
            this.grdDisplayQuotes.TabIndex = 0;
            this.grdDisplayQuotes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.Location = new System.Drawing.Point(290, 404);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(216, 56);
            this.btnMainMenu.TabIndex = 1;
            this.btnMainMenu.Text = "Main Menu";
            this.btnMainMenu.UseVisualStyleBackColor = true;
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // ViewAllQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 472);
            this.Controls.Add(this.btnMainMenu);
            this.Controls.Add(this.grdDisplayQuotes);
            this.Name = "ViewAllQuotes";
            this.Text = "ViewAllQuotes";
            ((System.ComponentModel.ISupportInitialize)(this.grdDisplayQuotes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdDisplayQuotes;
        private System.Windows.Forms.Button btnMainMenu;
    }
}