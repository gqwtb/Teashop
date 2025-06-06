namespace Teashop
{
    partial class Frm_Price
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
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.dtp_EndDate = new System.Windows.Forms.DateTimePicker();
            this.dtp_BeginDate = new System.Windows.Forms.DateTimePicker();
            this.txt_PriceL = new System.Windows.Forms.TextBox();
            this.txt_PriceM = new System.Windows.Forms.TextBox();
            this.txt_PriceS = new System.Windows.Forms.TextBox();
            this.txt_TeaID = new System.Windows.Forms.TextBox();
            this.lbl_Operation = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.lv_PriceInfo = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbl_Note = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_Cancel);
            this.groupBox1.Controls.Add(this.btn_Save);
            this.groupBox1.Controls.Add(this.dtp_EndDate);
            this.groupBox1.Controls.Add(this.dtp_BeginDate);
            this.groupBox1.Controls.Add(this.txt_PriceL);
            this.groupBox1.Controls.Add(this.txt_PriceM);
            this.groupBox1.Controls.Add(this.txt_PriceS);
            this.groupBox1.Controls.Add(this.txt_TeaID);
            this.groupBox1.Controls.Add(this.lbl_Operation);
            this.groupBox1.Location = new System.Drawing.Point(29, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(821, 335);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "编辑价格信息 当前操作：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(441, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 24);
            this.label7.TabIndex = 15;
            this.label7.Text = "结束日期：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(437, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 24);
            this.label6.TabIndex = 14;
            this.label6.Text = "开始日期：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(265, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 24);
            this.label5.TabIndex = 13;
            this.label5.Text = "（大份）";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(265, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 24);
            this.label4.TabIndex = 12;
            this.label4.Text = "（中份）";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(265, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 24);
            this.label3.TabIndex = 11;
            this.label3.Text = "（正常/小份）";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "价格：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "饮品编号：";
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(471, 264);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(145, 49);
            this.btn_Cancel.TabIndex = 8;
            this.btn_Cancel.Text = "取消";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(245, 264);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(126, 49);
            this.btn_Save.TabIndex = 7;
            this.btn_Save.Text = "保存";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // dtp_EndDate
            // 
            this.dtp_EndDate.Location = new System.Drawing.Point(573, 94);
            this.dtp_EndDate.Name = "dtp_EndDate";
            this.dtp_EndDate.Size = new System.Drawing.Size(200, 35);
            this.dtp_EndDate.TabIndex = 6;
            this.dtp_EndDate.Value = new System.DateTime(2025, 1, 3, 0, 0, 0, 0);
            // 
            // dtp_BeginDate
            // 
            this.dtp_BeginDate.Location = new System.Drawing.Point(573, 38);
            this.dtp_BeginDate.Name = "dtp_BeginDate";
            this.dtp_BeginDate.Size = new System.Drawing.Size(200, 35);
            this.dtp_BeginDate.TabIndex = 5;
            this.dtp_BeginDate.Value = new System.DateTime(2025, 1, 2, 0, 0, 0, 0);
            // 
            // txt_PriceL
            // 
            this.txt_PriceL.Location = new System.Drawing.Point(159, 208);
            this.txt_PriceL.Name = "txt_PriceL";
            this.txt_PriceL.Size = new System.Drawing.Size(100, 35);
            this.txt_PriceL.TabIndex = 4;
            this.txt_PriceL.Text = "0";
            this.txt_PriceL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_PriceL_KeyPress);
            // 
            // txt_PriceM
            // 
            this.txt_PriceM.Location = new System.Drawing.Point(159, 151);
            this.txt_PriceM.Name = "txt_PriceM";
            this.txt_PriceM.Size = new System.Drawing.Size(100, 35);
            this.txt_PriceM.TabIndex = 3;
            this.txt_PriceM.Text = "0";
            this.txt_PriceM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_PriceM_KeyPress);
            // 
            // txt_PriceS
            // 
            this.txt_PriceS.Location = new System.Drawing.Point(159, 98);
            this.txt_PriceS.Name = "txt_PriceS";
            this.txt_PriceS.Size = new System.Drawing.Size(100, 35);
            this.txt_PriceS.TabIndex = 2;
            this.txt_PriceS.Text = "0";
            this.txt_PriceS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_PriceS_KeyPress);
            // 
            // txt_TeaID
            // 
            this.txt_TeaID.Location = new System.Drawing.Point(159, 42);
            this.txt_TeaID.Name = "txt_TeaID";
            this.txt_TeaID.Size = new System.Drawing.Size(205, 35);
            this.txt_TeaID.TabIndex = 1;
            // 
            // lbl_Operation
            // 
            this.lbl_Operation.AutoSize = true;
            this.lbl_Operation.Location = new System.Drawing.Point(290, 0);
            this.lbl_Operation.Name = "lbl_Operation";
            this.lbl_Operation.Size = new System.Drawing.Size(58, 24);
            this.lbl_Operation.TabIndex = 0;
            this.lbl_Operation.Text = "添加";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_Delete);
            this.groupBox2.Controls.Add(this.lv_PriceInfo);
            this.groupBox2.Location = new System.Drawing.Point(29, 435);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(821, 487);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "价格信息列表";
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(184, 0);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(129, 41);
            this.btn_Delete.TabIndex = 1;
            this.btn_Delete.Text = "删除";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // lv_PriceInfo
            // 
            this.lv_PriceInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lv_PriceInfo.FullRowSelect = true;
            this.lv_PriceInfo.GridLines = true;
            this.lv_PriceInfo.Location = new System.Drawing.Point(43, 47);
            this.lv_PriceInfo.MultiSelect = false;
            this.lv_PriceInfo.Name = "lv_PriceInfo";
            this.lv_PriceInfo.Size = new System.Drawing.Size(751, 402);
            this.lv_PriceInfo.TabIndex = 0;
            this.lv_PriceInfo.UseCompatibleStateImageBehavior = false;
            this.lv_PriceInfo.View = System.Windows.Forms.View.Details;
            this.lv_PriceInfo.SelectedIndexChanged += new System.EventHandler(this.lv_PriceInfo_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "价格编号";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "饮品编号";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "价格（小）";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "价格（大）";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "价格（大）";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "开始日期";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "结束日期";
            // 
            // lbl_Note
            // 
            this.lbl_Note.AutoSize = true;
            this.lbl_Note.Location = new System.Drawing.Point(411, 389);
            this.lbl_Note.Name = "lbl_Note";
            this.lbl_Note.Size = new System.Drawing.Size(0, 24);
            this.lbl_Note.TabIndex = 2;
            // 
            // Frm_Price
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 974);
            this.Controls.Add(this.lbl_Note);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Frm_Price";
            this.Text = "饮品价格管理";
            this.Load += new System.EventHandler(this.Frm_Price_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.DateTimePicker dtp_EndDate;
        private System.Windows.Forms.DateTimePicker dtp_BeginDate;
        private System.Windows.Forms.TextBox txt_PriceL;
        private System.Windows.Forms.TextBox txt_PriceM;
        private System.Windows.Forms.TextBox txt_PriceS;
        private System.Windows.Forms.TextBox txt_TeaID;
        private System.Windows.Forms.Label lbl_Operation;
        private System.Windows.Forms.ListView lv_PriceInfo;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Label lbl_Note;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}