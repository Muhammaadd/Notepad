namespace ADO_Connected_Model
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.txt_newusername = new System.Windows.Forms.TextBox();
            this.txt_newpassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_login = new System.Windows.Forms.Button();
            this.lbl_userfill = new System.Windows.Forms.Label();
            this.lbl_passfill = new System.Windows.Forms.Label();
            this.lbl_alreadyexist = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_newusername
            // 
            this.txt_newusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_newusername.Location = new System.Drawing.Point(204, 119);
            this.txt_newusername.Multiline = true;
            this.txt_newusername.Name = "txt_newusername";
            this.txt_newusername.Size = new System.Drawing.Size(367, 40);
            this.txt_newusername.TabIndex = 1;
            // 
            // txt_newpassword
            // 
            this.txt_newpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_newpassword.Location = new System.Drawing.Point(204, 222);
            this.txt_newpassword.Multiline = true;
            this.txt_newpassword.Name = "txt_newpassword";
            this.txt_newpassword.PasswordChar = '*';
            this.txt_newpassword.Size = new System.Drawing.Size(367, 40);
            this.txt_newpassword.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Location = new System.Drawing.Point(200, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(200, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password";
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.RosyBrown;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_login.Font = new System.Drawing.Font("Elephant", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.Color.White;
            this.btn_login.Location = new System.Drawing.Point(204, 331);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(367, 53);
            this.btn_login.TabIndex = 5;
            this.btn_login.Text = "Sign Up";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // lbl_userfill
            // 
            this.lbl_userfill.AutoSize = true;
            this.lbl_userfill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_userfill.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_userfill.ForeColor = System.Drawing.Color.Red;
            this.lbl_userfill.Location = new System.Drawing.Point(201, 162);
            this.lbl_userfill.Name = "lbl_userfill";
            this.lbl_userfill.Size = new System.Drawing.Size(114, 13);
            this.lbl_userfill.TabIndex = 7;
            this.lbl_userfill.Text = "Please fill this field";
            // 
            // lbl_passfill
            // 
            this.lbl_passfill.AutoSize = true;
            this.lbl_passfill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_passfill.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_passfill.ForeColor = System.Drawing.Color.Red;
            this.lbl_passfill.Location = new System.Drawing.Point(201, 265);
            this.lbl_passfill.Name = "lbl_passfill";
            this.lbl_passfill.Size = new System.Drawing.Size(114, 13);
            this.lbl_passfill.TabIndex = 8;
            this.lbl_passfill.Text = "Please fill this field";
            this.lbl_passfill.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbl_alreadyexist
            // 
            this.lbl_alreadyexist.AutoSize = true;
            this.lbl_alreadyexist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_alreadyexist.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_alreadyexist.ForeColor = System.Drawing.Color.Red;
            this.lbl_alreadyexist.Location = new System.Drawing.Point(201, 162);
            this.lbl_alreadyexist.Name = "lbl_alreadyexist";
            this.lbl_alreadyexist.Size = new System.Drawing.Size(170, 13);
            this.lbl_alreadyexist.TabIndex = 9;
            this.lbl_alreadyexist.Text = "This User name already exist";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_alreadyexist);
            this.Controls.Add(this.lbl_passfill);
            this.Controls.Add(this.lbl_userfill);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_newpassword);
            this.Controls.Add(this.txt_newusername);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_newusername;
        private System.Windows.Forms.TextBox txt_newpassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Label lbl_userfill;
        private System.Windows.Forms.Label lbl_passfill;
        private System.Windows.Forms.Label lbl_alreadyexist;
    }
}