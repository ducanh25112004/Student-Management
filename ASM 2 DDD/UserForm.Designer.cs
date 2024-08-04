namespace ASM_2_DDD
{
    partial class UserForm
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
			dataGridView1 = new DataGridView();
			txtSearch = new TextBox();
			button1 = new Button();
			label1 = new Label();
			label2 = new Label();
			txtStudentID = new TextBox();
			txtStudentName = new TextBox();
			label3 = new Label();
			label4 = new Label();
			txtClassID = new TextBox();
			cmbGender = new ComboBox();
			button2 = new Button();
			((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
			SuspendLayout();
			// 
			// dataGridView1
			// 
			dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridView1.Location = new Point(42, 198);
			dataGridView1.Name = "dataGridView1";
			dataGridView1.RowTemplate.Height = 25;
			dataGridView1.Size = new Size(493, 221);
			dataGridView1.TabIndex = 0;
			dataGridView1.CellContentClick += dataGridView1_CellContentClick;
			// 
			// txtSearch
			// 
			txtSearch.Location = new Point(595, 285);
			txtSearch.Name = "txtSearch";
			txtSearch.Size = new Size(168, 23);
			txtSearch.TabIndex = 18;
			// 
			// button1
			// 
			button1.Location = new Point(645, 348);
			button1.Name = "button1";
			button1.Size = new Size(75, 23);
			button1.TabIndex = 19;
			button1.Text = "Search";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(122, 67);
			label1.Name = "label1";
			label1.Size = new Size(62, 15);
			label1.TabIndex = 10;
			label1.Text = "Student ID";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(101, 135);
			label2.Name = "label2";
			label2.Size = new Size(83, 15);
			label2.TabIndex = 11;
			label2.Text = "Student Name";
			// 
			// txtStudentID
			// 
			txtStudentID.Location = new Point(202, 64);
			txtStudentID.Name = "txtStudentID";
			txtStudentID.Size = new Size(147, 23);
			txtStudentID.TabIndex = 12;
			// 
			// txtStudentName
			// 
			txtStudentName.Location = new Point(202, 127);
			txtStudentName.Name = "txtStudentName";
			txtStudentName.Size = new Size(147, 23);
			txtStudentName.TabIndex = 13;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(470, 67);
			label3.Name = "label3";
			label3.Size = new Size(45, 15);
			label3.TabIndex = 14;
			label3.Text = "Gender";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(470, 135);
			label4.Name = "label4";
			label4.Size = new Size(48, 15);
			label4.TabIndex = 15;
			label4.Text = "Class ID";
			// 
			// txtClassID
			// 
			txtClassID.Location = new Point(533, 127);
			txtClassID.Name = "txtClassID";
			txtClassID.Size = new Size(121, 23);
			txtClassID.TabIndex = 16;
			// 
			// cmbGender
			// 
			cmbGender.FormattingEnabled = true;
			cmbGender.Items.AddRange(new object[] { "Male", "Female", "Other" });
			cmbGender.Location = new Point(533, 64);
			cmbGender.Name = "cmbGender";
			cmbGender.Size = new Size(121, 23);
			cmbGender.TabIndex = 17;
			// 
			// button2
			// 
			button2.Location = new Point(713, 415);
			button2.Name = "button2";
			button2.Size = new Size(75, 23);
			button2.TabIndex = 20;
			button2.Text = "Logout";
			button2.UseVisualStyleBackColor = true;
			button2.Click += button2_Click;
			// 
			// UserForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.Plum;
			ClientSize = new Size(800, 450);
			Controls.Add(button2);
			Controls.Add(button1);
			Controls.Add(txtSearch);
			Controls.Add(cmbGender);
			Controls.Add(txtClassID);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(txtStudentName);
			Controls.Add(txtStudentID);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(dataGridView1);
			ForeColor = SystemColors.ActiveCaptionText;
			Name = "UserForm";
			Text = "UserForm";
			Load += UserForm_Load;
			((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DataGridView dataGridView1;
        private TextBox txtSearch;
        private Button button1;
		private Label label1;
		private Label label2;
		private TextBox txtStudentID;
		private TextBox txtStudentName;
		private Label label3;
		private Label label4;
		private TextBox txtClassID;
		private ComboBox cmbGender;
		private Button button2;
	}
}