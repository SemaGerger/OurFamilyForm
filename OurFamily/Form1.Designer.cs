namespace OurFamily
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
            this.LoginBtn = new System.Windows.Forms.Button();
            this.userNameTxt = new System.Windows.Forms.TextBox();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.userNameRegBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.signRegBox = new System.Windows.Forms.Button();
            this.nameRegBox = new System.Windows.Forms.TextBox();
            this.genderRegBox = new System.Windows.Forms.GroupBox();
            this.erkekCheck = new System.Windows.Forms.CheckBox();
            this.kadınCheck = new System.Windows.Forms.CheckBox();
            this.surnameRegBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.passwordRegBox = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.genderRegBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginBtn
            // 
            this.LoginBtn.Location = new System.Drawing.Point(39, 161);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(120, 37);
            this.LoginBtn.TabIndex = 3;
            this.LoginBtn.Text = "Login";
            this.LoginBtn.UseVisualStyleBackColor = true;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // userNameTxt
            // 
            this.userNameTxt.Location = new System.Drawing.Point(39, 53);
            this.userNameTxt.Multiline = true;
            this.userNameTxt.Name = "userNameTxt";
            this.userNameTxt.Size = new System.Drawing.Size(120, 20);
            this.userNameTxt.TabIndex = 1;
            // 
            // passwordTxt
            // 
            this.passwordTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.passwordTxt.Location = new System.Drawing.Point(39, 112);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.PasswordChar = '*';
            this.passwordTxt.Size = new System.Drawing.Size(120, 20);
            this.passwordTxt.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.userNameTxt);
            this.groupBox1.Controls.Add(this.LoginBtn);
            this.groupBox1.Controls.Add(this.passwordTxt);
            this.groupBox1.Location = new System.Drawing.Point(544, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox1.Size = new System.Drawing.Size(200, 235);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "User Name";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::OurFamily.Properties.Resources._360_F_392719944_L0LYv3e7QozB2tsj3CfUN0HPC8eZQOWb;
            this.pictureBox2.Location = new System.Drawing.Point(567, 242);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(160, 27);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.userNameRegBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.signRegBox);
            this.groupBox2.Controls.Add(this.nameRegBox);
            this.groupBox2.Controls.Add(this.genderRegBox);
            this.groupBox2.Controls.Add(this.surnameRegBox);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.passwordRegBox);
            this.groupBox2.Location = new System.Drawing.Point(338, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 274);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Register";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(71, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(70, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "User Name";
            // 
            // userNameRegBox
            // 
            this.userNameRegBox.Location = new System.Drawing.Point(86, 19);
            this.userNameRegBox.Name = "userNameRegBox";
            this.userNameRegBox.Size = new System.Drawing.Size(100, 20);
            this.userNameRegBox.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Name";
            // 
            // signRegBox
            // 
            this.signRegBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.signRegBox.Location = new System.Drawing.Point(43, 223);
            this.signRegBox.Name = "signRegBox";
            this.signRegBox.Size = new System.Drawing.Size(126, 36);
            this.signRegBox.TabIndex = 5;
            this.signRegBox.Text = "Sign Up";
            this.signRegBox.UseVisualStyleBackColor = true;
            this.signRegBox.Click += new System.EventHandler(this.signRegBox_Click);
            // 
            // nameRegBox
            // 
            this.nameRegBox.Location = new System.Drawing.Point(86, 56);
            this.nameRegBox.Name = "nameRegBox";
            this.nameRegBox.Size = new System.Drawing.Size(100, 20);
            this.nameRegBox.TabIndex = 1;
            // 
            // genderRegBox
            // 
            this.genderRegBox.Controls.Add(this.erkekCheck);
            this.genderRegBox.Controls.Add(this.kadınCheck);
            this.genderRegBox.Location = new System.Drawing.Point(9, 149);
            this.genderRegBox.Name = "genderRegBox";
            this.genderRegBox.Size = new System.Drawing.Size(181, 49);
            this.genderRegBox.TabIndex = 4;
            this.genderRegBox.TabStop = false;
            this.genderRegBox.Text = "Gander";
            // 
            // erkekCheck
            // 
            this.erkekCheck.AutoSize = true;
            this.erkekCheck.Location = new System.Drawing.Point(93, 19);
            this.erkekCheck.Name = "erkekCheck";
            this.erkekCheck.Size = new System.Drawing.Size(49, 17);
            this.erkekCheck.TabIndex = 1;
            this.erkekCheck.Text = "Male";
            this.erkekCheck.UseVisualStyleBackColor = true;
            // 
            // kadınCheck
            // 
            this.kadınCheck.AutoSize = true;
            this.kadınCheck.Location = new System.Drawing.Point(6, 19);
            this.kadınCheck.Name = "kadınCheck";
            this.kadınCheck.Size = new System.Drawing.Size(60, 17);
            this.kadınCheck.TabIndex = 0;
            this.kadınCheck.Text = "Female";
            this.kadınCheck.UseVisualStyleBackColor = true;
            // 
            // surnameRegBox
            // 
            this.surnameRegBox.Location = new System.Drawing.Point(86, 89);
            this.surnameRegBox.Name = "surnameRegBox";
            this.surnameRegBox.Size = new System.Drawing.Size(100, 20);
            this.surnameRegBox.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Surname";
            // 
            // passwordRegBox
            // 
            this.passwordRegBox.Location = new System.Drawing.Point(86, 122);
            this.passwordRegBox.Name = "passwordRegBox";
            this.passwordRegBox.PasswordChar = '*';
            this.passwordRegBox.Size = new System.Drawing.Size(100, 20);
            this.passwordRegBox.TabIndex = 3;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserName,
            this.Password,
            this.iName,
            this.Surname});
            this.dataGridView2.Location = new System.Drawing.Point(-25, 56);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(357, 150);
            this.dataGridView2.TabIndex = 16;
            // 
            // UserName
            // 
            this.UserName.HeaderText = "UserName";
            this.UserName.Name = "UserName";
            // 
            // Password
            // 
            this.Password.HeaderText = "Password";
            this.Password.Name = "Password";
            // 
            // iName
            // 
            this.iName.HeaderText = "Name";
            this.iName.Name = "iName";
            // 
            // Surname
            // 
            this.Surname.HeaderText = "Surname";
            this.Surname.Name = "Surname";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::OurFamily.Properties.Resources.neon_lights_flickering;
            this.pictureBox1.Location = new System.Drawing.Point(-29, -6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(376, 274);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 277);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Our Family";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.genderRegBox.ResumeLayout(false);
            this.genderRegBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.TextBox userNameTxt;
        private System.Windows.Forms.TextBox passwordTxt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox userNameRegBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button signRegBox;
        private System.Windows.Forms.TextBox nameRegBox;
        private System.Windows.Forms.GroupBox genderRegBox;
        private System.Windows.Forms.CheckBox erkekCheck;
        private System.Windows.Forms.CheckBox kadınCheck;
        private System.Windows.Forms.TextBox surnameRegBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox passwordRegBox;
        public System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn iName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Surname;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
    }
}

