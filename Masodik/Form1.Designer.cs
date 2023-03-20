namespace Masodik
{
    partial class Form1
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
            this.pctrBx = new System.Windows.Forms.PictureBox();
            this.cmbBx = new System.Windows.Forms.ComboBox();
            this.txtBx = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.prgBr = new System.Windows.Forms.ProgressBar();
            this.dtGrdVw = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pctrBx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdVw)).BeginInit();
            this.SuspendLayout();
            // 
            // pctrBx
            // 
            this.pctrBx.Location = new System.Drawing.Point(654, 41);
            this.pctrBx.Name = "pctrBx";
            this.pctrBx.Size = new System.Drawing.Size(195, 467);
            this.pctrBx.TabIndex = 0;
            this.pctrBx.TabStop = false;
            // 
            // cmbBx
            // 
            this.cmbBx.FormattingEnabled = true;
            this.cmbBx.Location = new System.Drawing.Point(50, 41);
            this.cmbBx.Name = "cmbBx";
            this.cmbBx.Size = new System.Drawing.Size(443, 24);
            this.cmbBx.TabIndex = 1;
            this.cmbBx.SelectedIndexChanged += new System.EventHandler(this.cmbBx_SelectedIndexChanged);
            // 
            // txtBx
            // 
            this.txtBx.Location = new System.Drawing.Point(50, 104);
            this.txtBx.Name = "txtBx";
            this.txtBx.Size = new System.Drawing.Size(443, 22);
            this.txtBx.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(50, 205);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(443, 86);
            this.textBox1.TabIndex = 3;
            // 
            // prgBr
            // 
            this.prgBr.Location = new System.Drawing.Point(50, 340);
            this.prgBr.Name = "prgBr";
            this.prgBr.Size = new System.Drawing.Size(443, 23);
            this.prgBr.TabIndex = 4;
            // 
            // dtGrdVw
            // 
            this.dtGrdVw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrdVw.Location = new System.Drawing.Point(50, 395);
            this.dtGrdVw.Name = "dtGrdVw";
            this.dtGrdVw.RowHeadersWidth = 51;
            this.dtGrdVw.RowTemplate.Height = 24;
            this.dtGrdVw.Size = new System.Drawing.Size(443, 150);
            this.dtGrdVw.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 558);
            this.Controls.Add(this.dtGrdVw);
            this.Controls.Add(this.prgBr);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtBx);
            this.Controls.Add(this.cmbBx);
            this.Controls.Add(this.pctrBx);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctrBx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdVw)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctrBx;
        private System.Windows.Forms.ComboBox cmbBx;
        private System.Windows.Forms.TextBox txtBx;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ProgressBar prgBr;
        private System.Windows.Forms.DataGridView dtGrdVw;
    }
}