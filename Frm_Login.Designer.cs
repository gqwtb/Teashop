namespace Teashop
{
    partial class Frm_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Login));
            this.label1 = new System.Windows.Forms.Label();
            this.txt_UserName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.btn_Login = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.lbl_Note = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(636, 296);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "账 号：";
            // 
            // txt_UserName
            // 
            this.txt_UserName.Location = new System.Drawing.Point(757, 293);
            this.txt_UserName.Name = "txt_UserName";
            this.txt_UserName.Size = new System.Drawing.Size(246, 35);
            this.txt_UserName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(636, 408);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "密 码：";
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(757, 405);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(246, 35);
            this.txt_Password.TabIndex = 3;
            // 
            // btn_Login
            // 
            this.btn_Login.Location = new System.Drawing.Point(704, 529);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(120, 44);
            this.btn_Login.TabIndex = 4;
            this.btn_Login.Text = "登 录";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(896, 529);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(116, 45);
            this.btn_Exit.TabIndex = 5;
            this.btn_Exit.Text = "退 出";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // lbl_Note
            // 
            this.lbl_Note.AutoSize = true;
            this.lbl_Note.Location = new System.Drawing.Point(728, 641);
            this.lbl_Note.Name = "lbl_Note";
            this.lbl_Note.Size = new System.Drawing.Size(0, 24);
            this.lbl_Note.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 151);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(572, 578);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(340, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(415, 43);
            this.label3.TabIndex = 8;
            this.label3.Text = "饮品店点餐收银系统";
            // 
            // Frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 741);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_Note);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_UserName);
            this.Controls.Add(this.label1);
            this.Name = "Frm_Login";
            this.Text = "饮品店点餐收银系统";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_UserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Label lbl_Note;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
    }
}