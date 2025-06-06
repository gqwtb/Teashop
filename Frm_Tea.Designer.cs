namespace Teashop
{
    partial class Frm_Tea
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
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Operation = new System.Windows.Forms.Label();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.cbb_Status = new System.Windows.Forms.ComboBox();
            this.txt_TeaPriceL = new System.Windows.Forms.TextBox();
            this.txt_TeaPriceM = new System.Windows.Forms.TextBox();
            this.txt_TeaPriceS = new System.Windows.Forms.TextBox();
            this.txt_TeaName = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_StopSell = new System.Windows.Forms.Button();
            this.btn_SoldOut = new System.Windows.Forms.Button();
            this.btn_OnSale = new System.Windows.Forms.Button();
            this.lv_TeaInfo = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_Image = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lbl_Note = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lbl_Operation);
            this.groupBox1.Controls.Add(this.btn_Cancel);
            this.groupBox1.Controls.Add(this.btn_Save);
            this.groupBox1.Controls.Add(this.cbb_Status);
            this.groupBox1.Controls.Add(this.txt_TeaPriceL);
            this.groupBox1.Controls.Add(this.txt_TeaPriceM);
            this.groupBox1.Controls.Add(this.txt_TeaPriceS);
            this.groupBox1.Controls.Add(this.txt_TeaName);
            this.groupBox1.Location = new System.Drawing.Point(46, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(755, 384);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "编辑饮品信息 当前操作：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(269, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 24);
            this.label6.TabIndex = 13;
            this.label6.Text = "（大份）";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(268, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 24);
            this.label5.TabIndex = 12;
            this.label5.Text = "（中份）";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(268, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 24);
            this.label4.TabIndex = 11;
            this.label4.Text = "（正常/小份）";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "状态：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "饮品价格：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "饮品名称：";
            // 
            // lbl_Operation
            // 
            this.lbl_Operation.AutoSize = true;
            this.lbl_Operation.Location = new System.Drawing.Point(282, 0);
            this.lbl_Operation.Name = "lbl_Operation";
            this.lbl_Operation.Size = new System.Drawing.Size(58, 24);
            this.lbl_Operation.TabIndex = 7;
            this.lbl_Operation.Text = "添加";
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(245, 328);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(127, 56);
            this.btn_Cancel.TabIndex = 6;
            this.btn_Cancel.Text = "重置";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(49, 328);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(128, 56);
            this.btn_Save.TabIndex = 5;
            this.btn_Save.Text = "保存";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // cbb_Status
            // 
            this.cbb_Status.FormattingEnabled = true;
            this.cbb_Status.Items.AddRange(new object[] {
            "在售",
            "售完",
            "停售"});
            this.cbb_Status.Location = new System.Drawing.Point(163, 273);
            this.cbb_Status.Name = "cbb_Status";
            this.cbb_Status.Size = new System.Drawing.Size(221, 32);
            this.cbb_Status.TabIndex = 4;
            // 
            // txt_TeaPriceL
            // 
            this.txt_TeaPriceL.Location = new System.Drawing.Point(163, 212);
            this.txt_TeaPriceL.Name = "txt_TeaPriceL";
            this.txt_TeaPriceL.Size = new System.Drawing.Size(100, 35);
            this.txt_TeaPriceL.TabIndex = 3;
            this.txt_TeaPriceL.Text = "0";
            this.txt_TeaPriceL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_TeaPriceL_KeyPress);
            // 
            // txt_TeaPriceM
            // 
            this.txt_TeaPriceM.Location = new System.Drawing.Point(163, 159);
            this.txt_TeaPriceM.Name = "txt_TeaPriceM";
            this.txt_TeaPriceM.Size = new System.Drawing.Size(100, 35);
            this.txt_TeaPriceM.TabIndex = 2;
            this.txt_TeaPriceM.Text = "0";
            this.txt_TeaPriceM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_TeaPriceM_KeyPress);
            // 
            // txt_TeaPriceS
            // 
            this.txt_TeaPriceS.Location = new System.Drawing.Point(163, 103);
            this.txt_TeaPriceS.Name = "txt_TeaPriceS";
            this.txt_TeaPriceS.Size = new System.Drawing.Size(100, 35);
            this.txt_TeaPriceS.TabIndex = 1;
            this.txt_TeaPriceS.Text = "0";
            this.txt_TeaPriceS.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_TeaPriceS_KeyPress);
            // 
            // txt_TeaName
            // 
            this.txt_TeaName.Location = new System.Drawing.Point(163, 48);
            this.txt_TeaName.Name = "txt_TeaName";
            this.txt_TeaName.Size = new System.Drawing.Size(221, 35);
            this.txt_TeaName.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_Delete);
            this.groupBox2.Controls.Add(this.btn_StopSell);
            this.groupBox2.Controls.Add(this.btn_SoldOut);
            this.groupBox2.Controls.Add(this.btn_OnSale);
            this.groupBox2.Controls.Add(this.lv_TeaInfo);
            this.groupBox2.Location = new System.Drawing.Point(60, 493);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(760, 385);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "饮品信息列表";
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(583, 0);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(127, 47);
            this.btn_Delete.TabIndex = 4;
            this.btn_Delete.Text = "删除";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_StopSell
            // 
            this.btn_StopSell.Location = new System.Drawing.Point(449, 0);
            this.btn_StopSell.Name = "btn_StopSell";
            this.btn_StopSell.Size = new System.Drawing.Size(128, 47);
            this.btn_StopSell.TabIndex = 3;
            this.btn_StopSell.Text = "停售";
            this.btn_StopSell.UseVisualStyleBackColor = true;
            this.btn_StopSell.Click += new System.EventHandler(this.btn_StopSell_Click);
            // 
            // btn_SoldOut
            // 
            this.btn_SoldOut.Location = new System.Drawing.Point(314, 0);
            this.btn_SoldOut.Name = "btn_SoldOut";
            this.btn_SoldOut.Size = new System.Drawing.Size(129, 47);
            this.btn_SoldOut.TabIndex = 2;
            this.btn_SoldOut.Text = "售完";
            this.btn_SoldOut.UseVisualStyleBackColor = true;
            this.btn_SoldOut.Click += new System.EventHandler(this.btn_SoldOut_Click);
            // 
            // btn_OnSale
            // 
            this.btn_OnSale.Location = new System.Drawing.Point(174, 0);
            this.btn_OnSale.Name = "btn_OnSale";
            this.btn_OnSale.Size = new System.Drawing.Size(134, 47);
            this.btn_OnSale.TabIndex = 1;
            this.btn_OnSale.Text = "在售";
            this.btn_OnSale.UseVisualStyleBackColor = true;
            this.btn_OnSale.Click += new System.EventHandler(this.btn_OnSale_Click);
            // 
            // lv_TeaInfo
            // 
            this.lv_TeaInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lv_TeaInfo.FullRowSelect = true;
            this.lv_TeaInfo.GridLines = true;
            this.lv_TeaInfo.Location = new System.Drawing.Point(17, 69);
            this.lv_TeaInfo.MultiSelect = false;
            this.lv_TeaInfo.Name = "lv_TeaInfo";
            this.lv_TeaInfo.Size = new System.Drawing.Size(724, 313);
            this.lv_TeaInfo.TabIndex = 0;
            this.lv_TeaInfo.UseCompatibleStateImageBehavior = false;
            this.lv_TeaInfo.View = System.Windows.Forms.View.Details;
            this.lv_TeaInfo.SelectedIndexChanged += new System.EventHandler(this.lv_TeaInfo_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "编号";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "饮品名称";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "价格（小）";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "价格（中）";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "价格（大）";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "状态";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "图片地址";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pictureBox1);
            this.groupBox3.Controls.Add(this.btn_Image);
            this.groupBox3.Location = new System.Drawing.Point(489, 89);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(306, 333);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "饮品图片";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(6, 94);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(294, 233);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btn_Image
            // 
            this.btn_Image.Location = new System.Drawing.Point(46, 34);
            this.btn_Image.Name = "btn_Image";
            this.btn_Image.Size = new System.Drawing.Size(120, 45);
            this.btn_Image.TabIndex = 0;
            this.btn_Image.Text = "选择图片";
            this.btn_Image.UseVisualStyleBackColor = true;
            this.btn_Image.Click += new System.EventHandler(this.btn_Image_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lbl_Note
            // 
            this.lbl_Note.AutoSize = true;
            this.lbl_Note.Location = new System.Drawing.Point(397, 441);
            this.lbl_Note.Name = "lbl_Note";
            this.lbl_Note.Size = new System.Drawing.Size(0, 24);
            this.lbl_Note.TabIndex = 3;
            // 
            // Frm_Tea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 902);
            this.Controls.Add(this.lbl_Note);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Frm_Tea";
            this.Text = "饮品信息管理";
            this.Load += new System.EventHandler(this.Frm_Tea_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.ComboBox cbb_Status;
        private System.Windows.Forms.TextBox txt_TeaPriceL;
        private System.Windows.Forms.TextBox txt_TeaPriceM;
        private System.Windows.Forms.TextBox txt_TeaPriceS;
        private System.Windows.Forms.TextBox txt_TeaName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView lv_TeaInfo;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_Image;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lbl_Operation;
        private System.Windows.Forms.Label lbl_Note;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_StopSell;
        private System.Windows.Forms.Button btn_SoldOut;
        private System.Windows.Forms.Button btn_OnSale;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}