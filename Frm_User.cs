using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teashop
{
    public partial class Frm_User : Form
    {
        private string userid="";

        public Frm_User()
        {
            InitializeComponent();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            string name = txt_UserName.Text.Trim();
            string realname = txt_UserRname.Text.Trim();
            int status = rbtn_Status1.Checked == true ? 1 : 2;
            int type;
            switch (cbb_UserType.SelectedIndex)
            {
                case 0:type = 1; break;
                case 1:type = 2; break;
                default:type = 1; break;
            }
            string password = txt_UserPwd.Text.Trim();
            if (name == "")
            {
                lbl_Note.Text = "用户名不能为空！";
                lbl_Note.ForeColor = Color.Red;
                txt_UserName.Focus();
            }
            else if (password == "")
            {
                lbl_Note.Text = "密码不能为空！";
                lbl_Note.ForeColor = Color.Red;
                txt_UserPwd.Focus();
            }
            else if (realname == "")
            {
                lbl_Note.Text = "姓名不能为空！";
                lbl_Note.ForeColor = Color.Red;
                txt_UserRname.Focus();
            }
            else if (lbl_Status.Text == "添加")
            {
                string sqlstr = string.Format("insert into User_Info values('{0}','{1}','{2}',{3},{4})", name, password, realname, type, status);
                int i = Data.DataExcute(sqlstr);
                if (i > 0)
                {
                    lbl_Note.Text = "恭喜您，员工信息添加成功！";
                    lbl_Note.ForeColor = Color.Blue;
                    ClearTextBox();
                    DataBind_UserInfo();
                }
                else
                {
                    lbl_Note.Text = "对不起，员工信息添加失败！";
                    lbl_Note.ForeColor = Color.Red;
                }
            }
            else
            {
                string sqlstr = string.Format("update User_Info set UserName='{0}',UserPwd='{1}',UserRname='{2}',UserType={3},UserStatus={4} where UserID='{5}'", name, password, realname, type, status, userid);
                int i = Data.DataExcute(sqlstr);
                if (i > 0)
                {
                    lbl_Note.Text = "恭喜您，员工信息修改成功！";
                    lbl_Note.ForeColor = Color.Blue;
                    ClearTextBox();
                    DataBind_UserInfo();
                }
                else
                {
                    lbl_Note.Text = "对不起，员工信息修改失败！";
                    lbl_Note.ForeColor = Color.Red;
                }
            }
        }
        protected void ClearTextBox()
        {
            txt_UserName.Text = "";
            txt_UserRname.Text = "";
            txt_UserPwd.Text = "";
            rbtn_Status1.Checked = true;
            cbb_UserType.SelectedIndex = 0;
            lbl_Status.Text = "添加";
            userid = "";
        }
        protected void DataBind_UserInfo()
        {
            string sqlstr = "select * from User_Info";
            DataTable dt = Data.DataQuery(sqlstr);
            lv_User.Items.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                ListViewItem myitem = new ListViewItem(dr["UserID"].ToString());
                myitem.SubItems.Add(dr["UserName"].ToString());
                myitem.SubItems.Add(dr["UserPwd"].ToString());
                myitem.SubItems.Add(dr["UserRname"].ToString());
                myitem.SubItems.Add(dr["UserType"].ToString());
                myitem.SubItems.Add(dr["UserStatus"].ToString());
                lv_User.Items.Add(myitem);
            }
        }

        private void Frm_User_Load(object sender, EventArgs e)
        {
            DataBind_UserInfo();
            cbb_UserType.SelectedIndex = 0;
        }

        private void lv_User_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_User.SelectedItems.Count > 0)
            {
                ListViewItem myitem = lv_User.SelectedItems[0];
                userid = myitem.SubItems[0].Text;
                txt_UserName.Text = myitem.SubItems[1].Text;
                txt_UserPwd.Text = myitem.SubItems[2].Text;
                txt_UserRname.Text = myitem.SubItems[3].Text;
                rbtn_Status1.Checked = myitem.SubItems[4].Text == "1" ? true : false;
                rbtn_Status2.Checked = myitem.SubItems[4].Text == "2" ? true : false;
                lbl_Status.Text = "修改";
                switch (myitem.SubItems[4].Text) //状态
                {
                    case "1": cbb_UserType.SelectedIndex = 0; break;
                    case "2": cbb_UserType.SelectedIndex = 1; break;
                    default: cbb_UserType.SelectedIndex = 0; break;
                }
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (userid == "")
            {
                MessageBox.Show("请先选择要删除的员工信息");
            }
            else
            {
                DialogResult result = MessageBox.Show("确定要删除选中的员工信息？", "删除提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string sqlstr = string.Format("delete from User_Info where UserID={0}", userid);
                    int i = Data.DataExcute(sqlstr);
                    if (i > 0)
                    {
                        lbl_Note.Text = "恭喜您，员工信息删除成功！";
                        lbl_Note.ForeColor = Color.Blue;
                        ClearTextBox();
                        DataBind_UserInfo();
                    }
                    else
                    {
                        lbl_Note.Text = "对不起，员工信息删除失败！";
                        lbl_Note.ForeColor = Color.Red;
                    }
                }
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            ClearTextBox();
            lbl_Note.Text = "";
        }

        private void btn_Able_Click(object sender, EventArgs e)
        {
            if (userid == "")//如果没有选中要启用的员工信息
            { MessageBox.Show("请先选择要启用的员工信息"); }
            else
            {
                DialogResult result = MessageBox.Show("确定要设置选中的员工状态为“启用”？", "操作提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string sqlstr = string.Format("update User_Info set UserStatus = 1 where UserID={0}", userid);
                    int i = Data.DataExcute(sqlstr);
                    if (i > 0)
                    {
                        lbl_Note.Text = "恭喜您，员工状态成功修改为“启用”！";
                        lbl_Note.ForeColor = Color.Blue;
                        ClearTextBox(); //调用函数，清空各控件
                        DataBind_UserInfo(); //重新加载员工信息
                    }
                    else
                    {
                        lbl_Note.Text = "对不起，员工状态修改失败！";
                        lbl_Note.ForeColor = Color.Red;
                    }
                }
            }
        }

        private void btn_Disable_Click(object sender, EventArgs e)
        {
            if (userid == "")//如果没有选中要禁用的员工信息
            { MessageBox.Show("请先选择要禁用的员工信息"); }
            else
            {
                DialogResult result = MessageBox.Show("确定要设置选中的员工状态为“禁用”？", "操作提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string sqlstr = string.Format("update User_Info set UserStatus = 2 where UserID={0}", userid);
                    int i = Data.DataExcute(sqlstr);
                    if (i > 0)
                    {
                        lbl_Note.Text = "恭喜您，员工状态成功修改为“禁用”！";
                        lbl_Note.ForeColor = Color.Blue;
                        ClearTextBox(); //调用函数，清空各控件
                        DataBind_UserInfo(); //重新加载员工信息
                    }
                    else
                    {
                        lbl_Note.Text = "对不起，员工状态修改失败！";
                        lbl_Note.ForeColor = Color.Red;
                    }
                }
            }
        }
    }
}
