namespace Teashop
{
    partial class Frm_User
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Status = new System.Windows.Forms.Label();
            this.cbb_UserType = new System.Windows.Forms.ComboBox();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.txt_UserPwd = new System.Windows.Forms.TextBox();
            this.rbtn_Status2 = new System.Windows.Forms.RadioButton();
            this.rbtn_Status1 = new System.Windows.Forms.RadioButton();
            this.txt_UserRname = new System.Windows.Forms.TextBox();
            this.txt_UserName = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Disable = new System.Windows.Forms.Button();
            this.btn_Able = new System.Windows.Forms.Button();
            this.lv_User = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbl_Note = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lbl_Status);
            this.groupBox1.Controls.Add(this.cbb_UserType);
            this.groupBox1.Controls.Add(this.btn_Cancel);
            this.groupBox1.Controls.Add(this.btn_Save);
            this.groupBox1.Controls.Add(this.txt_UserPwd);
            this.groupBox1.Controls.Add(this.rbtn_Status2);
            this.groupBox1.Controls.Add(this.rbtn_Status1);
            this.groupBox1.Controls.Add(this.txt_UserRname);
            this.groupBox1.Controls.Add(this.txt_UserName);
            this.groupBox1.Location = new System.Drawing.Point(39, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(777, 263);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "编辑员工信息 状态：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(365, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 24);
            this.label5.TabIndex = 16;
            this.label5.Text = "用户类别：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(365, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 24);
            this.label4.TabIndex = 15;
            this.label4.Text = "密 码：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 24);
            this.label3.TabIndex = 14;
            this.label3.Text = "状 态：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 24);
            this.label2.TabIndex = 13;
            this.label2.Text = "姓 名：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "用户名：";
            // 
            // lbl_Status
            // 
            this.lbl_Status.AutoSize = true;
            this.lbl_Status.Location = new System.Drawing.Point(234, 0);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(58, 24);
            this.lbl_Status.TabIndex = 11;
            this.lbl_Status.Text = "添加";
            // 
            // cbb_UserType
            // 
            this.cbb_UserType.FormattingEnabled = true;
            this.cbb_UserType.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cbb_UserType.Location = new System.Drawing.Point(501, 104);
            this.cbb_UserType.Name = "cbb_UserType";
            this.cbb_UserType.Size = new System.Drawing.Size(231, 32);
            this.cbb_UserType.TabIndex = 10;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(384, 202);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(102, 39);
            this.btn_Cancel.TabIndex = 9;
            this.btn_Cancel.Text = "取 消";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(238, 202);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(103, 39);
            this.btn_Save.TabIndex = 8;
            this.btn_Save.Text = "保 存";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // txt_UserPwd
            // 
            this.txt_UserPwd.Location = new System.Drawing.Point(501, 47);
            this.txt_UserPwd.Name = "txt_UserPwd";
            this.txt_UserPwd.Size = new System.Drawing.Size(231, 35);
            this.txt_UserPwd.TabIndex = 6;
            // 
            // rbtn_Status2
            // 
            this.rbtn_Status2.AutoSize = true;
            this.rbtn_Status2.Location = new System.Drawing.Point(238, 158);
            this.rbtn_Status2.Name = "rbtn_Status2";
            this.rbtn_Status2.Size = new System.Drawing.Size(89, 28);
            this.rbtn_Status2.TabIndex = 5;
            this.rbtn_Status2.Text = "禁用";
            this.rbtn_Status2.UseVisualStyleBackColor = true;
            // 
            // rbtn_Status1
            // 
            this.rbtn_Status1.AutoSize = true;
            this.rbtn_Status1.Checked = true;
            this.rbtn_Status1.Location = new System.Drawing.Point(143, 158);
            this.rbtn_Status1.Name = "rbtn_Status1";
            this.rbtn_Status1.Size = new System.Drawing.Size(89, 28);
            this.rbtn_Status1.TabIndex = 4;
            this.rbtn_Status1.TabStop = true;
            this.rbtn_Status1.Text = "启用";
            this.rbtn_Status1.UseVisualStyleBackColor = true;
            // 
            // txt_UserRname
            // 
            this.txt_UserRname.Location = new System.Drawing.Point(143, 104);
            this.txt_UserRname.Name = "txt_UserRname";
            this.txt_UserRname.Size = new System.Drawing.Size(170, 35);
            this.txt_UserRname.TabIndex = 3;
            // 
            // txt_UserName
            // 
            this.txt_UserName.Location = new System.Drawing.Point(143, 50);
            this.txt_UserName.Name = "txt_UserName";
            this.txt_UserName.Size = new System.Drawing.Size(170, 35);
            this.txt_UserName.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_Delete);
            this.groupBox2.Controls.Add(this.btn_Disable);
            this.groupBox2.Controls.Add(this.btn_Able);
            this.groupBox2.Controls.Add(this.lv_User);
            this.groupBox2.Location = new System.Drawing.Point(39, 366);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(777, 504);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "员工信息列表";
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(420, 0);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(114, 37);
            this.btn_Delete.TabIndex = 4;
            this.btn_Delete.Text = "删除";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Disable
            // 
            this.btn_Disable.Location = new System.Drawing.Point(290, 0);
            this.btn_Disable.Name = "btn_Disable";
            this.btn_Disable.Size = new System.Drawing.Size(118, 37);
            this.btn_Disable.TabIndex = 2;
            this.btn_Disable.Text = "禁用";
            this.btn_Disable.UseVisualStyleBackColor = true;
            this.btn_Disable.Click += new System.EventHandler(this.btn_Disable_Click);
            // 
            // btn_Able
            // 
            this.btn_Able.Location = new System.Drawing.Point(165, 0);
            this.btn_Able.Name = "btn_Able";
            this.btn_Able.Size = new System.Drawing.Size(108, 37);
            this.btn_Able.TabIndex = 1;
            this.btn_Able.Text = "启用";
            this.btn_Able.UseVisualStyleBackColor = true;
            this.btn_Able.Click += new System.EventHandler(this.btn_Able_Click);
            // 
            // lv_User
            // 
            this.lv_User.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lv_User.FullRowSelect = true;
            this.lv_User.GridLines = true;
            this.lv_User.Location = new System.Drawing.Point(7, 67);
            this.lv_User.MultiSelect = false;
            this.lv_User.Name = "lv_User";
            this.lv_User.Size = new System.Drawing.Size(764, 402);
            this.lv_User.TabIndex = 0;
            this.lv_User.UseCompatibleStateImageBehavior = false;
            this.lv_User.View = System.Windows.Forms.View.Details;
            this.lv_User.SelectedIndexChanged += new System.EventHandler(this.lv_User_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "编号";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "用户名";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "密码";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "姓名";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "类别";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "状态";
            // 
            // lbl_Note
            // 
            this.lbl_Note.AutoSize = true;
            this.lbl_Note.Location = new System.Drawing.Point(341, 327);
            this.lbl_Note.Name = "lbl_Note";
            this.lbl_Note.Size = new System.Drawing.Size(0, 24);
            this.lbl_Note.TabIndex = 4;
            // 
            // Frm_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 882);
            this.Controls.Add(this.lbl_Note);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Frm_User";
            this.Text = "员工信息管理";
            this.Load += new System.EventHandler(this.Frm_User_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_UserPwd;
        private System.Windows.Forms.RadioButton rbtn_Status2;
        private System.Windows.Forms.RadioButton rbtn_Status1;
        private System.Windows.Forms.TextBox txt_UserRname;
        private System.Windows.Forms.TextBox txt_UserName;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Disable;
        private System.Windows.Forms.Button btn_Able;
        private System.Windows.Forms.ListView lv_User;
        private System.Windows.Forms.ComboBox cbb_UserType;
        private System.Windows.Forms.Label lbl_Status;
        private System.Windows.Forms.Label lbl_Note;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}