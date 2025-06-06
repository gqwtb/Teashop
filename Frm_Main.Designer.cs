namespace Teashop
{
    partial class Frm_Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.系统管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Tea = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Price = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Member = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_User = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_Tea = new System.Windows.Forms.ToolStripButton();
            this.btn_Price = new System.Windows.Forms.ToolStripButton();
            this.btn_Member = new System.Windows.Forms.ToolStripButton();
            this.btn_User = new System.Windows.Forms.ToolStripButton();
            this.btn_Exit = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_Name = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_Time = new System.Windows.Forms.ToolStripStatusLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.系统管理ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1110, 39);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 系统管理ToolStripMenuItem
            // 
            this.系统管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_Tea,
            this.menu_Price,
            this.menu_Member,
            this.menu_User,
            this.toolStripMenuItem2,
            this.menu_Exit});
            this.系统管理ToolStripMenuItem.Name = "系统管理ToolStripMenuItem";
            this.系统管理ToolStripMenuItem.Size = new System.Drawing.Size(122, 35);
            this.系统管理ToolStripMenuItem.Text = "系统管理";
            // 
            // menu_Tea
            // 
            this.menu_Tea.Name = "menu_Tea";
            this.menu_Tea.Size = new System.Drawing.Size(262, 38);
            this.menu_Tea.Text = "饮品信息管理";
            this.menu_Tea.Click += new System.EventHandler(this.menu_Tea_Click);
            // 
            // menu_Price
            // 
            this.menu_Price.Name = "menu_Price";
            this.menu_Price.Size = new System.Drawing.Size(262, 38);
            this.menu_Price.Text = "饮品价格管理";
            this.menu_Price.Click += new System.EventHandler(this.menu_Price_Click);
            // 
            // menu_Member
            // 
            this.menu_Member.Name = "menu_Member";
            this.menu_Member.Size = new System.Drawing.Size(262, 38);
            this.menu_Member.Text = "会员信息管理";
            this.menu_Member.Click += new System.EventHandler(this.menu_Member_Click);
            // 
            // menu_User
            // 
            this.menu_User.Name = "menu_User";
            this.menu_User.Size = new System.Drawing.Size(262, 38);
            this.menu_User.Text = "员工信息管理";
            this.menu_User.Click += new System.EventHandler(this.menu_User_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(262, 38);
            this.toolStripMenuItem2.Text = "---------------";
            // 
            // menu_Exit
            // 
            this.menu_Exit.Name = "menu_Exit";
            this.menu_Exit.Size = new System.Drawing.Size(262, 38);
            this.menu_Exit.Text = "退出系统";
            this.menu_Exit.Click += new System.EventHandler(this.menu_Exit_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_Tea,
            this.btn_Price,
            this.btn_Member,
            this.btn_User,
            this.btn_Exit});
            this.toolStrip1.Location = new System.Drawing.Point(0, 39);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1110, 70);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btn_Tea
            // 
            this.btn_Tea.Image = ((System.Drawing.Image)(resources.GetObject("btn_Tea.Image")));
            this.btn_Tea.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Tea.Name = "btn_Tea";
            this.btn_Tea.Size = new System.Drawing.Size(162, 67);
            this.btn_Tea.Text = "饮品信息管理";
            this.btn_Tea.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Tea.Click += new System.EventHandler(this.btn_Tea_Click);
            // 
            // btn_Price
            // 
            this.btn_Price.Image = ((System.Drawing.Image)(resources.GetObject("btn_Price.Image")));
            this.btn_Price.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Price.Name = "btn_Price";
            this.btn_Price.Size = new System.Drawing.Size(162, 67);
            this.btn_Price.Text = "饮品价格管理";
            this.btn_Price.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Price.Click += new System.EventHandler(this.btn_Price_Click);
            // 
            // btn_Member
            // 
            this.btn_Member.Image = ((System.Drawing.Image)(resources.GetObject("btn_Member.Image")));
            this.btn_Member.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Member.Name = "btn_Member";
            this.btn_Member.Size = new System.Drawing.Size(162, 67);
            this.btn_Member.Text = "会员信息管理";
            this.btn_Member.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Member.Click += new System.EventHandler(this.btn_Member_Click);
            // 
            // btn_User
            // 
            this.btn_User.Image = ((System.Drawing.Image)(resources.GetObject("btn_User.Image")));
            this.btn_User.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_User.Name = "btn_User";
            this.btn_User.Size = new System.Drawing.Size(162, 67);
            this.btn_User.Text = "员工信息管理";
            this.btn_User.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_User.Click += new System.EventHandler(this.btn_User_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Image = ((System.Drawing.Image)(resources.GetObject("btn_Exit.Image")));
            this.btn_Exit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(114, 67);
            this.btn_Exit.Text = "退出系统";
            this.btn_Exit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lbl_Name,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel4,
            this.lbl_Time});
            this.statusStrip1.Location = new System.Drawing.Point(0, 950);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1110, 36);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(158, 31);
            this.toolStripStatusLabel1.Text = "当前操作员：";
            // 
            // lbl_Name
            // 
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(28, 31);
            this.lbl_Name.Text = "2";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(21, 31);
            this.toolStripStatusLabel3.Text = " ";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(134, 31);
            this.toolStripStatusLabel4.Text = "当前时间：";
            // 
            // lbl_Time
            // 
            this.lbl_Time.Name = "lbl_Time";
            this.lbl_Time.Size = new System.Drawing.Size(257, 31);
            this.lbl_Time.Text = "toolStripStatusLabel5";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 161);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1110, 786);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 986);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Frm_Main";
            this.Text = "饮品店点餐收银系统";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_Main_FormClosing);
            this.Load += new System.EventHandler(this.Frm_Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 系统管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menu_Tea;
        private System.Windows.Forms.ToolStripMenuItem menu_Price;
        private System.Windows.Forms.ToolStripMenuItem menu_Member;
        private System.Windows.Forms.ToolStripMenuItem menu_User;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripButton btn_Tea;
        private System.Windows.Forms.ToolStripButton btn_Price;
        private System.Windows.Forms.ToolStripButton btn_Member;
        private System.Windows.Forms.ToolStripButton btn_User;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lbl_Name;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel lbl_Time;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem menu_Exit;
        private System.Windows.Forms.ToolStripButton btn_Exit;
    }
}