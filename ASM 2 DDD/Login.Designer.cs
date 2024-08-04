namespace ASM_2_DDD
{
    partial class Login
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			txtUsername = new TextBox();
			txtPassword = new TextBox();
			btnLogin = new Button();
			button2 = new Button();
			pictureBox1 = new PictureBox();
			pictureBox2 = new PictureBox();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
			label1.Location = new Point(191, 107);
			label1.Name = "label1";
			label1.Size = new Size(206, 25);
			label1.TabIndex = 0;
			label1.Text = "Student Management";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(96, 167);
			label2.Name = "label2";
			label2.Size = new Size(60, 15);
			label2.TabIndex = 1;
			label2.Text = "Username";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(96, 211);
			label3.Name = "label3";
			label3.Size = new Size(57, 15);
			label3.TabIndex = 2;
			label3.Text = "Password";
			label3.Click += label3_Click;
			// 
			// txtUsername
			// 
			txtUsername.Location = new Point(177, 164);
			txtUsername.Name = "txtUsername";
			txtUsername.Size = new Size(261, 23);
			txtUsername.TabIndex = 3;
			// 
			// txtPassword
			// 
			txtPassword.Location = new Point(177, 208);
			txtPassword.Name = "txtPassword";
			txtPassword.PasswordChar = '*';
			txtPassword.Size = new Size(261, 23);
			txtPassword.TabIndex = 4;
			txtPassword.TextChanged += txtPassword_TextChanged;
			// 
			// btnLogin
			// 
			btnLogin.Location = new Point(250, 263);
			btnLogin.Name = "btnLogin";
			btnLogin.Size = new Size(75, 23);
			btnLogin.TabIndex = 5;
			btnLogin.Text = "Login";
			btnLogin.UseVisualStyleBackColor = true;
			btnLogin.Click += button1_Click;
			// 
			// button2
			// 
			button2.Location = new Point(488, 333);
			button2.Name = "button2";
			button2.Size = new Size(75, 23);
			button2.TabIndex = 6;
			button2.Text = "Exit";
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click;
			// 
			// pictureBox1
			// 
			pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
			pictureBox1.Location = new Point(436, 12);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(127, 86);
			pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBox1.TabIndex = 7;
			pictureBox1.TabStop = false;
			// 
			// pictureBox2
			// 
			pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
			pictureBox2.Location = new Point(12, 12);
			pictureBox2.Name = "pictureBox2";
			pictureBox2.Size = new Size(141, 75);
			pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBox2.TabIndex = 8;
			pictureBox2.TabStop = false;
			// 
			// Login
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.PaleTurquoise;
			ClientSize = new Size(575, 368);
			Controls.Add(pictureBox2);
			Controls.Add(pictureBox1);
			Controls.Add(button2);
			Controls.Add(btnLogin);
			Controls.Add(txtPassword);
			Controls.Add(txtUsername);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Name = "Login";
			Text = "Form1";
			Load += Form1_Load;
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnLogin;
        private Button button2;
		private PictureBox pictureBox1;
		private PictureBox pictureBox2;
	}
}