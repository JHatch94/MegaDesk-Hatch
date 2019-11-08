namespace MegaDesk_Hatch
{
    partial class DisplayQuote
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
            this.label7 = new System.Windows.Forms.Label();
            this.numWidth = new System.Windows.Forms.NumericUpDown();
            this.numDepth = new System.Windows.Forms.NumericUpDown();
            this.numDrawers = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCustName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSubmitQuote = new System.Windows.Forms.Button();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtSurfaceMaterial = new System.Windows.Forms.TextBox();
            this.txtShippingMethod = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDepth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDrawers)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(535, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(234, 25);
            this.label7.TabIndex = 32;
            this.label7.Text = "Choose Shipping Method";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // numWidth
            // 
            this.numWidth.Location = new System.Drawing.Point(106, 231);
            this.numWidth.Maximum = new decimal(new int[] {
            96,
            0,
            0,
            0});
            this.numWidth.Minimum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.numWidth.Name = "numWidth";
            this.numWidth.ReadOnly = true;
            this.numWidth.Size = new System.Drawing.Size(120, 22);
            this.numWidth.TabIndex = 31;
            this.numWidth.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            // 
            // numDepth
            // 
            this.numDepth.Location = new System.Drawing.Point(105, 145);
            this.numDepth.Maximum = new decimal(new int[] {
            48,
            0,
            0,
            0});
            this.numDepth.Minimum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numDepth.Name = "numDepth";
            this.numDepth.ReadOnly = true;
            this.numDepth.Size = new System.Drawing.Size(120, 22);
            this.numDepth.TabIndex = 30;
            this.numDepth.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // numDrawers
            // 
            this.numDrawers.Location = new System.Drawing.Point(329, 142);
            this.numDrawers.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.numDrawers.Name = "numDrawers";
            this.numDrawers.ReadOnly = true;
            this.numDrawers.Size = new System.Drawing.Size(120, 22);
            this.numDrawers.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(324, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 25);
            this.label5.TabIndex = 28;
            this.label5.Text = "Surface Material";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(324, 103);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(179, 25);
            this.label6.TabIndex = 27;
            this.label6.Text = "Number of Drawers";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(35, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 26;
            this.label4.Text = "Width";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(33, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 25;
            this.label3.Text = "Depth";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(91, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 25);
            this.label2.TabIndex = 24;
            this.label2.Text = "Dimensions";
            // 
            // txtCustName
            // 
            this.txtCustName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.txtCustName.Location = new System.Drawing.Point(278, 27);
            this.txtCustName.Name = "txtCustName";
            this.txtCustName.ReadOnly = true;
            this.txtCustName.Size = new System.Drawing.Size(404, 41);
            this.txtCustName.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.label1.Location = new System.Drawing.Point(32, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 37);
            this.label1.TabIndex = 22;
            this.label1.Text = "Customer Name";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(100, 363);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(240, 61);
            this.btnCancel.TabIndex = 21;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSubmitQuote
            // 
            this.btnSubmitQuote.Location = new System.Drawing.Point(516, 363);
            this.btnSubmitQuote.Name = "btnSubmitQuote";
            this.btnSubmitQuote.Size = new System.Drawing.Size(240, 61);
            this.btnSubmitQuote.TabIndex = 20;
            this.btnSubmitQuote.Text = "Submit Quote";
            this.btnSubmitQuote.UseVisualStyleBackColor = true;
            this.btnSubmitQuote.Click += new System.EventHandler(this.btnSubmitQuote_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(562, 231);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(120, 22);
            this.txtPrice.TabIndex = 35;
            // 
            // txtSurfaceMaterial
            // 
            this.txtSurfaceMaterial.Location = new System.Drawing.Point(329, 231);
            this.txtSurfaceMaterial.Name = "txtSurfaceMaterial";
            this.txtSurfaceMaterial.ReadOnly = true;
            this.txtSurfaceMaterial.Size = new System.Drawing.Size(120, 22);
            this.txtSurfaceMaterial.TabIndex = 36;
            // 
            // txtShippingMethod
            // 
            this.txtShippingMethod.Location = new System.Drawing.Point(562, 147);
            this.txtShippingMethod.Name = "txtShippingMethod";
            this.txtShippingMethod.ReadOnly = true;
            this.txtShippingMethod.Size = new System.Drawing.Size(120, 22);
            this.txtShippingMethod.TabIndex = 37;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.Location = new System.Drawing.Point(557, 189);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 25);
            this.label8.TabIndex = 38;
            this.label8.Text = "Total Cost";
            // 
            // DisplayQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtShippingMethod);
            this.Controls.Add(this.txtSurfaceMaterial);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numWidth);
            this.Controls.Add(this.numDepth);
            this.Controls.Add(this.numDrawers);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCustName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmitQuote);
            this.Name = "DisplayQuote";
            this.Text = "DisplayQuote";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DisplayQuote_FormClosed);
            this.Load += new System.EventHandler(this.DisplayQuote_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.numWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDepth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDrawers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numWidth;
        private System.Windows.Forms.NumericUpDown numDepth;
        private System.Windows.Forms.NumericUpDown numDrawers;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCustName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSubmitQuote;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtSurfaceMaterial;
        private System.Windows.Forms.TextBox txtShippingMethod;
        private System.Windows.Forms.Label label8;
    }
}