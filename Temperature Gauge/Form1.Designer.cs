namespace Temperature_Gauge
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
            this.btnDisplayImage = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtTemp = new System.Windows.Forms.Label();
            this.imgTemp = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgTemp)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDisplayImage
            // 
            this.btnDisplayImage.Location = new System.Drawing.Point(259, 320);
            this.btnDisplayImage.Name = "btnDisplayImage";
            this.btnDisplayImage.Size = new System.Drawing.Size(290, 98);
            this.btnDisplayImage.TabIndex = 0;
            this.btnDisplayImage.Text = "button1";
            this.btnDisplayImage.UseVisualStyleBackColor = true;
            this.btnDisplayImage.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(77, 294);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // txtTemp
            // 
            this.txtTemp.AutoSize = true;
            this.txtTemp.Location = new System.Drawing.Point(74, 233);
            this.txtTemp.Name = "txtTemp";
            this.txtTemp.Size = new System.Drawing.Size(100, 13);
            this.txtTemp.TabIndex = 2;
            this.txtTemp.Text = "Enter a temperature";
            // 
            // imgTemp
            // 
            this.imgTemp.Location = new System.Drawing.Point(221, 55);
            this.imgTemp.Name = "imgTemp";
            this.imgTemp.Size = new System.Drawing.Size(362, 259);
            this.imgTemp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgTemp.TabIndex = 3;
            this.imgTemp.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.imgTemp);
            this.Controls.Add(this.txtTemp);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnDisplayImage);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.imgTemp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDisplayImage;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label txtTemp;
        private System.Windows.Forms.PictureBox imgTemp;
    }
}

