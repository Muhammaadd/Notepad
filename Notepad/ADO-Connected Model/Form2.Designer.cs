namespace ADO_Connected_Model
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.lbl_hello = new System.Windows.Forms.Label();
            this.dgv_loaded = new System.Windows.Forms.DataGridView();
            this.btn_create = new System.Windows.Forms.Button();
            this.lbl_here = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_loaded)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_hello
            // 
            this.lbl_hello.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_hello.AutoSize = true;
            this.lbl_hello.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_hello.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_hello.Font = new System.Drawing.Font("Andalus", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hello.ForeColor = System.Drawing.Color.LavenderBlush;
            this.lbl_hello.Location = new System.Drawing.Point(284, 42);
            this.lbl_hello.Name = "lbl_hello";
            this.lbl_hello.Size = new System.Drawing.Size(236, 43);
            this.lbl_hello.TabIndex = 0;
            this.lbl_hello.Text = "Hello Muhammed";
            this.lbl_hello.Click += new System.EventHandler(this.lbl_hello_Click);
            // 
            // dgv_loaded
            // 
            this.dgv_loaded.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_loaded.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_loaded.Location = new System.Drawing.Point(12, 239);
            this.dgv_loaded.Name = "dgv_loaded";
            this.dgv_loaded.Size = new System.Drawing.Size(363, 199);
            this.dgv_loaded.TabIndex = 1;
            // 
            // btn_create
            // 
            this.btn_create.BackColor = System.Drawing.Color.RosyBrown;
            this.btn_create.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_create.Font = new System.Drawing.Font("Elephant", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_create.ForeColor = System.Drawing.Color.White;
            this.btn_create.Location = new System.Drawing.Point(586, 387);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(202, 51);
            this.btn_create.TabIndex = 6;
            this.btn_create.Text = "Create New";
            this.btn_create.UseVisualStyleBackColor = false;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // lbl_here
            // 
            this.lbl_here.AutoSize = true;
            this.lbl_here.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_here.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_here.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_here.Location = new System.Drawing.Point(12, 220);
            this.lbl_here.Name = "lbl_here";
            this.lbl_here.Size = new System.Drawing.Size(100, 15);
            this.lbl_here.TabIndex = 7;
            this.lbl_here.Text = "Here your files";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_here);
            this.Controls.Add(this.btn_create);
            this.Controls.Add(this.dgv_loaded);
            this.Controls.Add(this.lbl_hello);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_loaded)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_hello;
        private System.Windows.Forms.DataGridView dgv_loaded;
        private System.Windows.Forms.Button btn_create;
        private System.Windows.Forms.Label lbl_here;
    }
}