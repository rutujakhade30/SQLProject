namespace HostelManagement
{
    partial class Dashboard
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ManageRoomsFinal = new System.Windows.Forms.Button();
            this.Logout = new System.Windows.Forms.Button();
            this.NewStudent = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mistral", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "NAVIGATOR BAR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(476, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(685, 49);
            this.label2.TabIndex = 2;
            this.label2.Text = "HOSTEL MANAGEMENT SYSTEM";
            // 
            // ManageRoomsFinal
            // 
            this.ManageRoomsFinal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ManageRoomsFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManageRoomsFinal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ManageRoomsFinal.Location = new System.Drawing.Point(12, 117);
            this.ManageRoomsFinal.Name = "ManageRoomsFinal";
            this.ManageRoomsFinal.Size = new System.Drawing.Size(259, 134);
            this.ManageRoomsFinal.TabIndex = 3;
            this.ManageRoomsFinal.Text = "Manage Rooms";
            this.ManageRoomsFinal.UseVisualStyleBackColor = false;
            this.ManageRoomsFinal.Click += new System.EventHandler(this.ManageRoomsFinal_Click);
            // 
            // Logout
            // 
            this.Logout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Logout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Logout.Location = new System.Drawing.Point(1365, 25);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(89, 36);
            this.Logout.TabIndex = 12;
            this.Logout.Text = "LogOut";
            this.Logout.UseVisualStyleBackColor = false;
            this.Logout.Click += new System.EventHandler(this.button10_Click);
            // 
            // NewStudent
            // 
            this.NewStudent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.NewStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewStudent.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.NewStudent.Location = new System.Drawing.Point(12, 324);
            this.NewStudent.Name = "NewStudent";
            this.NewStudent.Size = new System.Drawing.Size(259, 137);
            this.NewStudent.TabIndex = 14;
            this.NewStudent.Text = "New Students";
            this.NewStudent.UseVisualStyleBackColor = false;
            this.NewStudent.Click += new System.EventHandler(this.NewStudent_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HostelManagement.Properties.Resources.hostel;
            this.pictureBox1.Location = new System.Drawing.Point(291, 81);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1163, 689);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(48)))), ((int)(((byte)(103)))));
            this.ClientSize = new System.Drawing.Size(1485, 797);
            this.Controls.Add(this.NewStudent);
            this.Controls.Add(this.Logout);
            this.Controls.Add(this.ManageRoomsFinal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Cursor = System.Windows.Forms.Cursors.NoMoveVert;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ManageRoomsFinal;
        private System.Windows.Forms.Button Logout;
        private System.Windows.Forms.Button NewStudent;
    }
}