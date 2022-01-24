namespace Cafe_Management
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.btnguest = new Guna.UI.WinForms.GunaLinkLabel();
            this.btnlogin = new Guna.UI.WinForms.GunaButton();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.authcheck = new Guna.UI.WinForms.GunaLabel();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.txtuname = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtpass = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(37, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(298, 221);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.White;
            this.gunaLabel1.Location = new System.Drawing.Point(38, 328);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Padding = new System.Windows.Forms.Padding(2);
            this.gunaLabel1.Size = new System.Drawing.Size(84, 27);
            this.gunaLabel1.TabIndex = 1;
            this.gunaLabel1.Text = "Password";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.gunaLabel2.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.ForeColor = System.Drawing.Color.White;
            this.gunaLabel2.Location = new System.Drawing.Point(38, 254);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Padding = new System.Windows.Forms.Padding(2);
            this.gunaLabel2.Size = new System.Drawing.Size(94, 27);
            this.gunaLabel2.TabIndex = 1;
            this.gunaLabel2.Text = "UserName";
            // 
            // btnguest
            // 
            this.btnguest.AutoSize = true;
            this.btnguest.BackColor = System.Drawing.Color.Transparent;
            this.btnguest.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguest.ForeColor = System.Drawing.Color.Cyan;
            this.btnguest.LinkColor = System.Drawing.Color.Cyan;
            this.btnguest.Location = new System.Drawing.Point(183, 535);
            this.btnguest.Name = "btnguest";
            this.btnguest.Padding = new System.Windows.Forms.Padding(2);
            this.btnguest.Size = new System.Drawing.Size(169, 24);
            this.btnguest.TabIndex = 7;
            this.btnguest.TabStop = true;
            this.btnguest.Text = "Continue As Sales Man";
            this.btnguest.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnguest_LinkClicked);
            // 
            // btnlogin
            // 
            this.btnlogin.Animated = true;
            this.btnlogin.AnimationHoverSpeed = 0.4F;
            this.btnlogin.AnimationSpeed = 0.5F;
            this.btnlogin.BackColor = System.Drawing.Color.Transparent;
            this.btnlogin.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnlogin.BorderColor = System.Drawing.Color.Black;
            this.btnlogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlogin.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnlogin.FocusedColor = System.Drawing.Color.Empty;
            this.btnlogin.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.ForeColor = System.Drawing.Color.White;
            this.btnlogin.Image = null;
            this.btnlogin.ImageSize = new System.Drawing.Size(0, 0);
            this.btnlogin.Location = new System.Drawing.Point(112, 415);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.OnHoverBaseColor = System.Drawing.Color.White;
            this.btnlogin.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnlogin.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            this.btnlogin.OnHoverImage = null;
            this.btnlogin.OnPressedColor = System.Drawing.Color.Black;
            this.btnlogin.Radius = 20;
            this.btnlogin.Size = new System.Drawing.Size(135, 37);
            this.btnlogin.TabIndex = 6;
            this.btnlogin.Text = "Login";
            this.btnlogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.gunaLabel3.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.ForeColor = System.Drawing.Color.Red;
            this.gunaLabel3.Location = new System.Drawing.Point(125, 23);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(137, 26);
            this.gunaLabel3.TabIndex = 8;
            this.gunaLabel3.Text = "Authentication";
            // 
            // authcheck
            // 
            this.authcheck.AutoSize = true;
            this.authcheck.BackColor = System.Drawing.Color.Transparent;
            this.authcheck.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.authcheck.ForeColor = System.Drawing.Color.Red;
            this.authcheck.Location = new System.Drawing.Point(136, 223);
            this.authcheck.Name = "authcheck";
            this.authcheck.Size = new System.Drawing.Size(0, 21);
            this.authcheck.TabIndex = 9;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(5, 5);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(363, 580);
            this.shapeContainer1.TabIndex = 10;
            this.shapeContainer1.TabStop = false;
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.rectangleShape1.BorderWidth = 3;
            this.rectangleShape1.Location = new System.Drawing.Point(3, 3);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(354, 570);
            // 
            // txtuname
            // 
            this.txtuname.AutoRoundedCorners = true;
            this.txtuname.BorderRadius = 17;
            this.txtuname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtuname.DefaultText = "admin";
            this.txtuname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtuname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtuname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtuname.DisabledState.Parent = this.txtuname;
            this.txtuname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtuname.FillColor = System.Drawing.Color.Gray;
            this.txtuname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtuname.FocusedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(45)))));
            this.txtuname.FocusedState.ForeColor = System.Drawing.Color.White;
            this.txtuname.FocusedState.Parent = this.txtuname;
            this.txtuname.FocusedState.PlaceholderForeColor = System.Drawing.Color.White;
            this.txtuname.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtuname.ForeColor = System.Drawing.Color.White;
            this.txtuname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtuname.HoverState.FillColor = System.Drawing.Color.DimGray;
            this.txtuname.HoverState.Parent = this.txtuname;
            this.txtuname.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtuname.IconLeft")));
            this.txtuname.Location = new System.Drawing.Point(48, 285);
            this.txtuname.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtuname.Name = "txtuname";
            this.txtuname.PasswordChar = '\0';
            this.txtuname.PlaceholderText = "Enter User Name";
            this.txtuname.SelectedText = "";
            this.txtuname.ShadowDecoration.Parent = this.txtuname;
            this.txtuname.Size = new System.Drawing.Size(264, 36);
            this.txtuname.TabIndex = 11;
            // 
            // txtpass
            // 
            this.txtpass.AutoRoundedCorners = true;
            this.txtpass.BorderRadius = 17;
            this.txtpass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtpass.DefaultText = "admin";
            this.txtpass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtpass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtpass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtpass.DisabledState.Parent = this.txtpass;
            this.txtpass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtpass.FillColor = System.Drawing.Color.Gray;
            this.txtpass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtpass.FocusedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(45)))));
            this.txtpass.FocusedState.ForeColor = System.Drawing.Color.White;
            this.txtpass.FocusedState.Parent = this.txtpass;
            this.txtpass.FocusedState.PlaceholderForeColor = System.Drawing.Color.White;
            this.txtpass.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.txtpass.ForeColor = System.Drawing.Color.White;
            this.txtpass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtpass.HoverState.FillColor = System.Drawing.Color.DimGray;
            this.txtpass.HoverState.Parent = this.txtpass;
            this.txtpass.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtpass.IconLeft")));
            this.txtpass.Location = new System.Drawing.Point(48, 360);
            this.txtpass.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtpass.Name = "txtpass";
            this.txtpass.PasswordChar = '*';
            this.txtpass.PlaceholderText = "Enter Password";
            this.txtpass.SelectedText = "";
            this.txtpass.SelectionStart = 5;
            this.txtpass.ShadowDecoration.Parent = this.txtpass;
            this.txtpass.Size = new System.Drawing.Size(264, 36);
            this.txtpass.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(373, 590);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.txtuname);
            this.Controls.Add(this.authcheck);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.btnguest);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.shapeContainer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLinkLabel btnguest;
        private Guna.UI.WinForms.GunaButton btnlogin;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel authcheck;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private Guna.UI2.WinForms.Guna2TextBox txtuname;
        private Guna.UI2.WinForms.Guna2TextBox txtpass;
    }
}

