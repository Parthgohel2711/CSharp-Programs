namespace MessageBox
{
    partial class MessageBox
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Title = new System.Windows.Forms.Label();
            this.Btn2 = new Guna.UI2.WinForms.Guna2Button();
            this.Btn3 = new Guna.UI2.WinForms.Guna2Button();
            this.Text = new System.Windows.Forms.RichTextBox();
            this.Btn1 = new Guna.UI2.WinForms.Guna2Button();
            this.Image = new System.Windows.Forms.PictureBox();
            this.BtnClose = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Image)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.BtnClose);
            this.panel1.Controls.Add(this.Title);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(297, 30);
            this.panel1.TabIndex = 0;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(6, 6);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(96, 19);
            this.Title.TabIndex = 0;
            this.Title.Text = "MessageTitle";
            // 
            // Btn2
            // 
            this.Btn2.BorderThickness = 1;
            this.Btn2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Btn2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Btn2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btn2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Btn2.FillColor = System.Drawing.Color.White;
            this.Btn2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Btn2.ForeColor = System.Drawing.Color.Black;
            this.Btn2.Location = new System.Drawing.Point(104, 261);
            this.Btn2.Name = "Btn2";
            this.Btn2.Size = new System.Drawing.Size(89, 27);
            this.Btn2.TabIndex = 2;
            this.Btn2.Text = "Btn1";
            this.Btn2.Click += new System.EventHandler(this.Btn2_Click);
            // 
            // Btn3
            // 
            this.Btn3.BorderThickness = 1;
            this.Btn3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Btn3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Btn3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btn3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Btn3.FillColor = System.Drawing.Color.White;
            this.Btn3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Btn3.ForeColor = System.Drawing.Color.Black;
            this.Btn3.Location = new System.Drawing.Point(199, 261);
            this.Btn3.Name = "Btn3";
            this.Btn3.Size = new System.Drawing.Size(89, 27);
            this.Btn3.TabIndex = 3;
            this.Btn3.Text = "Btn1";
            this.Btn3.Click += new System.EventHandler(this.Btn3_Click);
            // 
            // Text
            // 
            this.Text.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Text.ForeColor = System.Drawing.Color.White;
            this.Text.Location = new System.Drawing.Point(12, 110);
            this.Text.Name = "Text";
            this.Text.Size = new System.Drawing.Size(276, 91);
            this.Text.TabIndex = 4;
            this.Text.Text = "Envalid !";
            // 
            // Btn1
            // 
            this.Btn1.BorderThickness = 1;
            this.Btn1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Btn1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Btn1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btn1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Btn1.FillColor = System.Drawing.Color.White;
            this.Btn1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Btn1.ForeColor = System.Drawing.Color.Black;
            this.Btn1.Location = new System.Drawing.Point(9, 261);
            this.Btn1.Name = "Btn1";
            this.Btn1.Size = new System.Drawing.Size(89, 27);
            this.Btn1.TabIndex = 1;
            this.Btn1.Text = "Btn1";
            this.Btn1.Click += new System.EventHandler(this.Btn1_Click);
            // 
            // Image
            // 
            this.Image.Image = global::MessageBox.Properties.Resources.Error;
            this.Image.Location = new System.Drawing.Point(9, 46);
            this.Image.Name = "Image";
            this.Image.Size = new System.Drawing.Size(53, 50);
            this.Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Image.TabIndex = 5;
            this.Image.TabStop = false;
            // 
            // BtnClose
            // 
            this.BtnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnClose.FillColor = System.Drawing.Color.White;
            this.BtnClose.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClose.ForeColor = System.Drawing.Color.Black;
            this.BtnClose.Image = global::MessageBox.Properties.Resources.Close;
            this.BtnClose.ImageSize = new System.Drawing.Size(12, 12);
            this.BtnClose.Location = new System.Drawing.Point(266, 0);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(31, 30);
            this.BtnClose.TabIndex = 6;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // MessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(297, 300);
            this.Controls.Add(this.Image);
            this.Controls.Add(this.Text);
            this.Controls.Add(this.Btn3);
            this.Controls.Add(this.Btn2);
            this.Controls.Add(this.Btn1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MessageBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Image)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Title;
        private Guna.UI2.WinForms.Guna2Button Btn2;
        private Guna.UI2.WinForms.Guna2Button Btn3;
        private System.Windows.Forms.RichTextBox Text;
        private System.Windows.Forms.PictureBox Image;
        private Guna.UI2.WinForms.Guna2Button BtnClose;
        private Guna.UI2.WinForms.Guna2Button Btn1;
    }
}

