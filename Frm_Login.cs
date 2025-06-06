using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teashop
{
    public partial class Frm_Login : Form
    {
        public Frm_Login()
        {
            InitializeComponent();
        }
        protected string StringFilter(string str)
        {
            //去掉空格
            str = str.Replace(" ", "");
            //过滤掉or, and, --等SQL关键词或者注释符，防止SQL注入式攻击
            str = str.Replace(" or ", "");
            str = str.Replace(" and ", "");
            str = str.Replace("--", "");
            return str;
        }
        private void btn_Login_Click(object sender, EventArgs e)
        {
            //获取用户名和密码，并过滤非法字符
            string username = StringFilter(txt_UserName.Text);
            string password = StringFilter(txt_Password.Text);
            if (username == "")
            {
                lbl_Note.Text = "帐号不能为空！";
                txt_UserName.Focus(); //将焦点移入“帐号”文本框
            }
            else if (password == "")
            {
                lbl_Note.Text = "密码不能为空！";
                txt_Password.Focus(); //将焦点移入“密码”文本框 
            }
            else
            { //SQL查询语句（根据用户名查询）
                string sqlstr = string.Format("select * from User_Info where UserName = '{0}'", username);
                DataTable dt = Data.DataQuery(sqlstr);
                if (dt.Rows.Count == 0) //如果查询结果为空，说明用户名不存在
                { MessageBox.Show("对不起，用户名不存在！"); }
                else if (dt.Rows[0]["UserPwd"].ToString() != password)
                //如果用户名存在，则继续判断密码是否正确（用户名具有唯一性，因此记录数最多为1）
                { MessageBox.Show("对不起，密码不正确！"); }
                else if (dt.Rows[0]["UserStatus"].ToString() != "1")
                { MessageBox.Show("对不起，该用户状态已经失效，请联系系统管理人员进行设置！"); }
                else //如果密码正确，则用户状态为1，则可以进入系统主界面
                {
                    MessageBox.Show("恭喜您，登录成功！");
                    Frm_Main frm_main = new Frm_Main();
                    //将当前用户编号和用户名存储在配置文件中,在主界面和收银界面中有用
                    ConfigurationManager.AppSettings["UserID"] = dt.Rows[0]["UserID"].ToString();
                    ConfigurationManager.AppSettings["UserName"] = dt.Rows[0]["UserName"].ToString();
                    ConfigurationManager.AppSettings["UserRname"] = dt.Rows[0]["UserRname"].ToString();
                    frm_main.Show(); //显示主界面
                    this.Hide();
                }
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
            Application.Exit();
        }
    }
}
