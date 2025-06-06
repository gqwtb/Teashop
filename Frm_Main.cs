using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teashop
{
    public partial class Frm_Main : Form
    {
        public Frm_Main()
        {
            InitializeComponent();
        }

        private void Frm_Main_Load(object sender, EventArgs e)
        {
            lbl_Name.Text = ConfigurationManager.AppSettings["UserRname"];
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_Time.Text = DateTime.Now.ToString();
        }

        private void menu_Tea_Click(object sender, EventArgs e)
        {
            Frm_Tea frm = new Frm_Tea();
            frm.Show();
        }

        private void menu_Price_Click(object sender, EventArgs e)
        {
            Frm_Price frm = new Frm_Price();
            frm.Show();
        }

        private void menu_Member_Click(object sender, EventArgs e)
        {
            Frm_Member frm = new Frm_Member();
            frm.Show();
        }

        private void menu_User_Click(object sender, EventArgs e)
        {
            Frm_User frm = new Frm_User();
            frm.Show();
        }

        private void btn_Tea_Click(object sender, EventArgs e)
        {
            Frm_Tea frm = new Frm_Tea();
            frm.Show();
        }

        private void btn_Price_Click(object sender, EventArgs e)
        {
            Frm_Price frm = new Frm_Price();
            frm.Show();
        }

        private void btn_Member_Click(object sender, EventArgs e)
        {
            Frm_Member frm = new Frm_Member();
            frm.Show();
        }

        private void btn_User_Click(object sender, EventArgs e)
        {
            Frm_User frm = new Frm_User();
            frm.Show();
        }

        private void Frm_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("确定要退出吗", "退出提示", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Dispose(); // 清理正在使用的资源
                Application.Exit();
            }
            else
            { e.Cancel = true; }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定要退出吗", "退出提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Dispose(); // 清理正在使用的资源
                Application.Exit();
            }
        }

        private void menu_Exit_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("确定要退出吗", "退出提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Dispose(); // 清理正在使用的资源
                Application.Exit();
            }
        }
    }
}
