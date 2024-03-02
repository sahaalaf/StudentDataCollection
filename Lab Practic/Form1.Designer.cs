namespace Lab_Practic
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.close = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.fname = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.lname = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.email = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.address = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.registerButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(37)))), ((int)(((byte)(68)))));
            this.panel1.Controls.Add(this.close);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(517, 77);
            this.panel1.TabIndex = 0;
            // 
            // close
            // 
            this.close.Image = ((System.Drawing.Image)(resources.GetObject("close.Image")));
            this.close.Location = new System.Drawing.Point(481, 6);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(30, 30);
            this.close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.close.TabIndex = 5;
            this.close.TabStop = false;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic Paneuropean SemB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(126, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Data Collection";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic Paneuropean SemB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic Paneuropean SemB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 28);
            this.label3.TabIndex = 0;
            this.label3.Text = "Email";
            // 
            // fname
            // 
            this.fname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fname.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.fname.ForeColor = System.Drawing.Color.White;
            this.fname.HintForeColor = System.Drawing.Color.Empty;
            this.fname.HintText = "First Name";
            this.fname.isPassword = false;
            this.fname.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(37)))), ((int)(((byte)(68)))));
            this.fname.LineIdleColor = System.Drawing.Color.White;
            this.fname.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(37)))), ((int)(((byte)(68)))));
            this.fname.LineThickness = 3;
            this.fname.Location = new System.Drawing.Point(13, 128);
            this.fname.Margin = new System.Windows.Forms.Padding(4);
            this.fname.Name = "fname";
            this.fname.Size = new System.Drawing.Size(182, 44);
            this.fname.TabIndex = 1;
            this.fname.TabStop = false;
            this.fname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // lname
            // 
            this.lname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lname.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.lname.ForeColor = System.Drawing.Color.White;
            this.lname.HintForeColor = System.Drawing.Color.Empty;
            this.lname.HintText = "Last Name";
            this.lname.isPassword = false;
            this.lname.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(37)))), ((int)(((byte)(68)))));
            this.lname.LineIdleColor = System.Drawing.Color.White;
            this.lname.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(37)))), ((int)(((byte)(68)))));
            this.lname.LineThickness = 3;
            this.lname.Location = new System.Drawing.Point(236, 128);
            this.lname.Margin = new System.Windows.Forms.Padding(4);
            this.lname.Name = "lname";
            this.lname.Size = new System.Drawing.Size(182, 44);
            this.lname.TabIndex = 2;
            this.lname.TabStop = false;
            this.lname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // email
            // 
            this.email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.email.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.email.ForeColor = System.Drawing.Color.White;
            this.email.HintForeColor = System.Drawing.Color.Empty;
            this.email.HintText = "Email";
            this.email.isPassword = false;
            this.email.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(37)))), ((int)(((byte)(68)))));
            this.email.LineIdleColor = System.Drawing.Color.White;
            this.email.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(37)))), ((int)(((byte)(68)))));
            this.email.LineThickness = 3;
            this.email.Location = new System.Drawing.Point(13, 224);
            this.email.Margin = new System.Windows.Forms.Padding(4);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(410, 47);
            this.email.TabIndex = 3;
            this.email.TabStop = false;
            this.email.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic Paneuropean SemB", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 311);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 28);
            this.label4.TabIndex = 0;
            this.label4.Text = "Address";
            // 
            // address
            // 
            this.address.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.address.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.address.ForeColor = System.Drawing.Color.White;
            this.address.HintForeColor = System.Drawing.Color.Empty;
            this.address.HintText = "Address";
            this.address.isPassword = false;
            this.address.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(37)))), ((int)(((byte)(68)))));
            this.address.LineIdleColor = System.Drawing.Color.White;
            this.address.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(37)))), ((int)(((byte)(68)))));
            this.address.LineThickness = 3;
            this.address.Location = new System.Drawing.Point(13, 340);
            this.address.Margin = new System.Windows.Forms.Padding(4);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(410, 45);
            this.address.TabIndex = 4;
            this.address.TabStop = false;
            this.address.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // registerButton
            // 
            this.registerButton.ActiveBorderThickness = 1;
            this.registerButton.ActiveCornerRadius = 20;
            this.registerButton.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.registerButton.ActiveForecolor = System.Drawing.Color.White;
            this.registerButton.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.registerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(79)))), ((int)(((byte)(122)))));
            this.registerButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("registerButton.BackgroundImage")));
            this.registerButton.ButtonText = "Register";
            this.registerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.registerButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerButton.ForeColor = System.Drawing.Color.SeaGreen;
            this.registerButton.IdleBorderThickness = 1;
            this.registerButton.IdleCornerRadius = 20;
            this.registerButton.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(37)))), ((int)(((byte)(68)))));
            this.registerButton.IdleForecolor = System.Drawing.Color.White;
            this.registerButton.IdleLineColor = System.Drawing.Color.White;
            this.registerButton.Location = new System.Drawing.Point(170, 427);
            this.registerButton.Margin = new System.Windows.Forms.Padding(5);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(181, 46);
            this.registerButton.TabIndex = 2;
            this.registerButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(79)))), ((int)(((byte)(122)))));
            this.ClientSize = new System.Drawing.Size(517, 507);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.lname);
            this.Controls.Add(this.address);
            this.Controls.Add(this.email);
            this.Controls.Add(this.fname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox fname;
        private Bunifu.Framework.UI.BunifuMaterialTextbox lname;
        private Bunifu.Framework.UI.BunifuMaterialTextbox email;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox address;
        private Bunifu.Framework.UI.BunifuThinButton2 registerButton;
        private System.Windows.Forms.PictureBox close;
    }
}

