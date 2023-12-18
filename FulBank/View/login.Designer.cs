namespace FulBank
{
    partial class login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            bouton_login = new Button();
            Username = new TextBox();
            password = new TextBox();
            pictureBox1 = new PictureBox();
            passwordforgotten = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // bouton_login
            // 
            bouton_login.BackColor = Color.FromArgb(22, 43, 99);
            bouton_login.ForeColor = Color.White;
            bouton_login.Location = new Point(264, 657);
            bouton_login.Name = "bouton_login";
            bouton_login.Size = new Size(278, 32);
            bouton_login.TabIndex = 0;
            bouton_login.Text = "LOGIN";
            bouton_login.UseVisualStyleBackColor = false;
            bouton_login.Click += button1_Click;
            // 
            // Username
            // 
            Username.BackColor = Color.FromArgb(128, 194, 236);
            Username.ForeColor = Color.White;
            Username.Location = new Point(264, 563);
            Username.Name = "Username";
            Username.Size = new Size(278, 23);
            Username.TabIndex = 1;
            Username.Text = "USERNAME";
            Username.TextChanged += textBox1_TextChanged;
            // 
            // password
            // 
            password.BackColor = Color.FromArgb(128, 194, 236);
            password.ForeColor = Color.White;
            password.Location = new Point(264, 606);
            password.Name = "password";
            password.Size = new Size(278, 23);
            password.TabIndex = 2;
            password.Text = "*************";
            password.TextChanged += textBox2_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(224, 123);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(365, 366);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // passwordforgotten
            // 
            passwordforgotten.AutoSize = true;
            passwordforgotten.LinkColor = Color.FromArgb(0, 0, 0, 0);
            passwordforgotten.Location = new Point(330, 703);
            passwordforgotten.Name = "passwordforgotten";
            passwordforgotten.Size = new Size(144, 15);
            passwordforgotten.TabIndex = 6;
            passwordforgotten.TabStop = true;
            passwordforgotten.Text = "PASSWORD FORGOTTEN ?";
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1165, 1087);
            Controls.Add(passwordforgotten);
            Controls.Add(pictureBox1);
            Controls.Add(password);
            Controls.Add(Username);
            Controls.Add(bouton_login);
            Name = "login";
            Text = "Form1";
            Load += login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bouton_login;
        private TextBox Username;
        private TextBox password;
        private PictureBox pictureBox1;
        private LinkLabel passwordforgotten;
    }
}