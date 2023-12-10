﻿namespace WinFormsApp4
{
    partial class Account
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Account));
            button2 = new Button();
            openFileDialog1 = new OpenFileDialog();
            checkBox1 = new CheckBox();
            button4 = new Button();
            button3 = new Button();
            label8 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            panel1 = new Panel();
            button5 = new Button();
            pictureBox1 = new PictureBox();
            openFileDialog2 = new OpenFileDialog();
            button6 = new Button();
            label7 = new Label();
            user_txtbox = new TextBox();
            label6 = new Label();
            National_id_txtbox = new TextBox();
            label5 = new Label();
            cpass_txtbox = new TextBox();
            label4 = new Label();
            email_txtbox = new TextBox();
            label3 = new Label();
            password_txtbox = new TextBox();
            label2 = new Label();
            phone_num_txtbox = new TextBox();
            label1 = new Label();
            name_txtbox = new TextBox();
            button7 = new Button();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = Color.LightGreen;
            button2.Location = new Point(552, 448);
            button2.Name = "button2";
            button2.Size = new Size(184, 40);
            button2.TabIndex = 7;
            button2.Text = "Delete Account";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(304, 398);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(181, 19);
            checkBox1.TabIndex = 44;
            checkBox1.Text = "I Agree Terms and Conditions";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.BackColor = Color.SeaGreen;
            button4.FlatStyle = FlatStyle.Popup;
            button4.ForeColor = SystemColors.ControlDarkDark;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.Location = new Point(112, 3);
            button4.Name = "button4";
            button4.Size = new Size(34, 30);
            button4.TabIndex = 29;
            button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.SeaGreen;
            button3.FlatStyle = FlatStyle.Popup;
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Image = Properties.Resources.icons8_minus_24;
            button3.Location = new Point(11, 3);
            button3.Name = "button3";
            button3.Size = new Size(34, 30);
            button3.TabIndex = 28;
            button3.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.SeaGreen;
            label8.Location = new Point(290, 67);
            label8.Name = "label8";
            label8.Size = new Size(103, 32);
            label8.TabIndex = 42;
            label8.Text = "Sign Up";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Design_a_modern_and_sleek_logo_for_a_Computer_Center_Management;
            pictureBox2.Location = new Point(30, 39);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(94, 87);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 19;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(-28, 198);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(315, 300);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 21;
            pictureBox3.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(266, 545);
            panel1.TabIndex = 41;
            // 
            // button5
            // 
            button5.BackColor = Color.SeaGreen;
            button5.FlatStyle = FlatStyle.Popup;
            button5.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = SystemColors.ButtonHighlight;
            button5.Location = new Point(74, 166);
            button5.Name = "button5";
            button5.Size = new Size(98, 21);
            button5.TabIndex = 18;
            button5.Text = "Select Photo";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.SeaGreen;
            pictureBox1.Image = Properties.Resources.icons8_person_641;
            pictureBox1.Location = new Point(63, 23);
            pictureBox1.Margin = new Padding(0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 128);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // openFileDialog2
            // 
            openFileDialog2.FileName = "openFileDialog1";
            // 
            // button6
            // 
            button6.BackColor = Color.SeaGreen;
            button6.FlatStyle = FlatStyle.Popup;
            button6.ForeColor = SystemColors.ControlDarkDark;
            button6.Image = (Image)resources.GetObject("button6.Image");
            button6.Location = new Point(62, 3);
            button6.Name = "button6";
            button6.Size = new Size(34, 30);
            button6.TabIndex = 27;
            button6.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.SeaGreen;
            label7.Location = new Point(293, 270);
            label7.Name = "label7";
            label7.Size = new Size(100, 16);
            label7.TabIndex = 40;
            label7.Text = "Phone Number";
            // 
            // user_txtbox
            // 
            user_txtbox.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            user_txtbox.ForeColor = SystemColors.ActiveCaptionText;
            user_txtbox.Location = new Point(540, 143);
            user_txtbox.Multiline = true;
            user_txtbox.Name = "user_txtbox";
            user_txtbox.Size = new Size(182, 30);
            user_txtbox.TabIndex = 39;
            user_txtbox.TextAlign = HorizontalAlignment.Center;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.SeaGreen;
            label6.Location = new Point(540, 121);
            label6.Name = "label6";
            label6.Size = new Size(75, 16);
            label6.TabIndex = 38;
            label6.Text = "User Name";
            // 
            // National_id_txtbox
            // 
            National_id_txtbox.Enabled = false;
            National_id_txtbox.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            National_id_txtbox.ForeColor = SystemColors.ActiveCaptionText;
            National_id_txtbox.Location = new Point(293, 213);
            National_id_txtbox.Multiline = true;
            National_id_txtbox.Name = "National_id_txtbox";
            National_id_txtbox.Size = new Size(189, 30);
            National_id_txtbox.TabIndex = 37;
            National_id_txtbox.TextAlign = HorizontalAlignment.Center;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.SeaGreen;
            label5.Location = new Point(540, 270);
            label5.Name = "label5";
            label5.Size = new Size(101, 16);
            label5.TabIndex = 36;
            label5.Text = "New Password";
            // 
            // cpass_txtbox
            // 
            cpass_txtbox.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            cpass_txtbox.ForeColor = SystemColors.ActiveCaptionText;
            cpass_txtbox.Location = new Point(540, 289);
            cpass_txtbox.Multiline = true;
            cpass_txtbox.Name = "cpass_txtbox";
            cpass_txtbox.PasswordChar = '*';
            cpass_txtbox.Size = new Size(182, 30);
            cpass_txtbox.TabIndex = 35;
            cpass_txtbox.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.SeaGreen;
            label4.Location = new Point(293, 194);
            label4.Name = "label4";
            label4.Size = new Size(74, 16);
            label4.TabIndex = 34;
            label4.Text = "National id";
            // 
            // email_txtbox
            // 
            email_txtbox.Enabled = false;
            email_txtbox.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            email_txtbox.ForeColor = SystemColors.ActiveCaptionText;
            email_txtbox.Location = new Point(293, 358);
            email_txtbox.Multiline = true;
            email_txtbox.Name = "email_txtbox";
            email_txtbox.Size = new Size(429, 30);
            email_txtbox.TabIndex = 33;
            email_txtbox.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.SeaGreen;
            label3.Location = new Point(296, 339);
            label3.Name = "label3";
            label3.Size = new Size(39, 16);
            label3.TabIndex = 32;
            label3.Text = "Email";
            // 
            // password_txtbox
            // 
            password_txtbox.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            password_txtbox.ForeColor = SystemColors.ActiveCaptionText;
            password_txtbox.Location = new Point(540, 213);
            password_txtbox.Multiline = true;
            password_txtbox.Name = "password_txtbox";
            password_txtbox.PasswordChar = '*';
            password_txtbox.Size = new Size(182, 30);
            password_txtbox.TabIndex = 31;
            password_txtbox.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.SeaGreen;
            label2.Location = new Point(545, 194);
            label2.Name = "label2";
            label2.Size = new Size(70, 16);
            label2.TabIndex = 30;
            label2.Text = "Password";
            // 
            // phone_num_txtbox
            // 
            phone_num_txtbox.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            phone_num_txtbox.ForeColor = SystemColors.ActiveCaptionText;
            phone_num_txtbox.Location = new Point(293, 289);
            phone_num_txtbox.Multiline = true;
            phone_num_txtbox.Name = "phone_num_txtbox";
            phone_num_txtbox.Size = new Size(189, 30);
            phone_num_txtbox.TabIndex = 29;
            phone_num_txtbox.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.SeaGreen;
            label1.Location = new Point(293, 121);
            label1.Name = "label1";
            label1.Size = new Size(42, 16);
            label1.TabIndex = 28;
            label1.Text = "Name";
            // 
            // name_txtbox
            // 
            name_txtbox.Font = new Font("Tahoma", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            name_txtbox.ForeColor = SystemColors.ActiveCaptionText;
            name_txtbox.Location = new Point(293, 143);
            name_txtbox.Multiline = true;
            name_txtbox.Name = "name_txtbox";
            name_txtbox.Size = new Size(189, 30);
            name_txtbox.TabIndex = 27;
            name_txtbox.TextAlign = HorizontalAlignment.Center;
            // 
            // button7
            // 
            button7.BackColor = Color.SeaGreen;
            button7.FlatStyle = FlatStyle.Popup;
            button7.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button7.ForeColor = SystemColors.Control;
            button7.Location = new Point(304, 448);
            button7.Name = "button7";
            button7.Size = new Size(208, 35);
            button7.TabIndex = 26;
            button7.Text = "Save Changes";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(button6);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(783, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(156, 545);
            panel2.TabIndex = 43;
            // 
            // Account
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(939, 545);
            Controls.Add(checkBox1);
            Controls.Add(label8);
            Controls.Add(panel1);
            Controls.Add(label7);
            Controls.Add(user_txtbox);
            Controls.Add(label6);
            Controls.Add(National_id_txtbox);
            Controls.Add(label5);
            Controls.Add(cpass_txtbox);
            Controls.Add(label4);
            Controls.Add(email_txtbox);
            Controls.Add(label3);
            Controls.Add(password_txtbox);
            Controls.Add(label2);
            Controls.Add(phone_num_txtbox);
            Controls.Add(label1);
            Controls.Add(name_txtbox);
            Controls.Add(button7);
            Controls.Add(panel2);
            Controls.Add(button2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Account";
            Text = "Account";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button2;
        private OpenFileDialog openFileDialog1;
        private CheckBox checkBox1;
        private Button button4;
        private Button button3;
        private Label label8;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Panel panel1;
        private Button button5;
        private PictureBox pictureBox1;
        private OpenFileDialog openFileDialog2;
        private Button button6;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button7;
        private Panel panel2;
        // --------------
        private TextBox National_id_txtbox;
        private TextBox cpass_txtbox;
        private TextBox email_txtbox;
        private TextBox password_txtbox;
        private TextBox phone_num_txtbox;
        private TextBox name_txtbox;
        private TextBox user_txtbox;
    }
}