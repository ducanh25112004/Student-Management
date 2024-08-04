namespace ASM_2_DDD
{
    partial class HomeAdmin
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeAdmin));
			button1 = new Button();
			button4 = new Button();
			pictureBox2 = new PictureBox();
			button2 = new Button();
			((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
			SuspendLayout();
			// 
			// button1
			// 
			button1.Location = new Point(176, 174);
			button1.Name = "button1";
			button1.Size = new Size(150, 73);
			button1.TabIndex = 0;
			button1.Text = "Student Management";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// button4
			// 
			button4.Location = new Point(476, 174);
			button4.Name = "button4";
			button4.Size = new Size(150, 73);
			button4.TabIndex = 3;
			button4.Text = "Class";
			button4.UseVisualStyleBackColor = true;
			button4.Click += button4_Click;
			// 
			// pictureBox2
			// 
			pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
			pictureBox2.Location = new Point(12, 12);
			pictureBox2.Name = "pictureBox2";
			pictureBox2.Size = new Size(141, 75);
			pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
			pictureBox2.TabIndex = 9;
			pictureBox2.TabStop = false;
			// 
			// button2
			// 
			button2.Location = new Point(713, 415);
			button2.Name = "button2";
			button2.Size = new Size(75, 23);
			button2.TabIndex = 10;
			button2.Text = "Logout";
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click_1;
			// 
			// HomeAdmin
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.ActiveCaption;
			ClientSize = new Size(800, 450);
			Controls.Add(button2);
			Controls.Add(pictureBox2);
			Controls.Add(button4);
			Controls.Add(button1);
			Name = "HomeAdmin";
			Text = "HomeAdmin";
			Load += HomeAdmin_Load;
			((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private Button button1;
        private Button button4;
		private PictureBox pictureBox2;
		private Button button2;
	}
}