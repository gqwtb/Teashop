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
    public partial class Frm_Member : Form
    {
        private string memberid="";
        public Frm_Member()
        {
            InitializeComponent();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            string number = txt_MemberNumber.Text.Trim();
            string name = txt_MemberName.Text.Trim();
            string telephone = txt_MemberTel.Text.Trim();
            int sex = rbtn_Sex1.Checked == true ? 1 : 2;
            int status = rbtn_Status1.Checked == true ? 1 : 2;
            string remark = txt_MemberRemark.Text;
            if (number == "")
            {
                lbl_Note.Text = "会员卡号不能为空！";
                lbl_Note.ForeColor = Color.Red;
                txt_MemberNumber.Focus();
            }
            else if (name == "")
            {
                lbl_Note.Text = "姓名不能为空！";
                lbl_Note.ForeColor = Color.Red;
                txt_MemberName.Focus();
            }
            else if (telephone == "")
            {
                lbl_Note.Text = "电话不能为空！";
                lbl_Note.ForeColor = Color.Red;
                txt_MemberTel.Focus();
            }
            else if (lbl_Status.Text == "添加")
            {
                string sqlstr = string.Format("insert into Member_Info values('{0}','{1}','{2}',{3},{4},'{5}')", name, number,telephone, status,sex, remark);
                int i = Data.DataExcute(sqlstr);
                if (i > 0)
                {
                    lbl_Note.Text = "恭喜您，会员信息添加成功！";
                    lbl_Note.ForeColor = Color.Blue;
                    ClearTextBox();
                    DataBind_MemberInfo();
                }
                else
                {
                    lbl_Note.Text = "对不起，会员信息添加失败！";
                    lbl_Note.ForeColor = Color.Red;
                }
            }
            else
            {
                string sqlstr = string.Format("update Member_Info set MemberName='{0}',MemberNumber='{1}',MemberTel='{2}',MemberStatus='{3}',MemberSex='{4}',MemberRemark='{5}' where MemberID={6}", name, number, telephone, status, sex, remark, memberid);
                int i = Data.DataExcute(sqlstr);
                if (i > 0)
                {
                    lbl_Note.Text = "恭喜您，会员信息修改成功！";
                    lbl_Note.ForeColor = Color.Blue;
                    ClearTextBox();
                    DataBind_MemberInfo();
                }
                else
                {
                    lbl_Note.Text = "对不起，会员信息修改失败！";
                    lbl_Note.ForeColor = Color.Red;
                }
            }
        }
        protected void ClearTextBox()
        {
            txt_MemberName.Text = "";
            txt_MemberTel.Text = "";
            txt_MemberNumber.Text = "";
            txt_MemberRemark.Text = "";
            rbtn_Sex1.Checked = true;
            rbtn_Status1.Checked = true;
            lbl_Status.Text = "添加";
            memberid = "";
        }
        protected void DataBind_MemberInfo()
        {
            string sqlstr = "select * from Member_Info";
            DataTable dt = Data.DataQuery(sqlstr);
            lv_Member.Items.Clear();
            foreach (DataRow dr in dt.Rows)
            {
                ListViewItem myitem = new ListViewItem(dr["MemberID"].ToString());
                myitem.SubItems.Add(dr["MemberName"].ToString());
                myitem.SubItems.Add(dr["MemberNumber"].ToString());
                myitem.SubItems.Add(dr["MemberTel"].ToString());
                switch (dr["MemberStatus"].ToString())
                {
                    case "1": myitem.SubItems.Add("正常"); break;
                    case "2": myitem.SubItems.Add("删除"); break;
                }
                switch (dr["MemberSex"].ToString())
                {
                    case "1": myitem.SubItems.Add("男");break;
                    case "2": myitem.SubItems.Add("女"); break;
                }
                
                myitem.SubItems.Add(dr["MemberRemark"].ToString());
                lv_Member.Items.Add(myitem);
            }
        }

        private void Frm_Member_Load(object sender, EventArgs e)
        {
            DataBind_MemberInfo();
        }

        private void lv_Member_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_Member.SelectedItems.Count > 0)
            {
                ListViewItem myitem = lv_Member.SelectedItems[0];
                memberid = myitem.SubItems[0].Text;
                txt_MemberName.Text = myitem.SubItems[1].Text;
                txt_MemberNumber.Text = myitem.SubItems[2].Text;
                txt_MemberTel.Text = myitem.SubItems[3].Text;
                rbtn_Status1.Checked = myitem.SubItems[4].Text == "正常" ? true : false;
                rbtn_Status2.Checked = myitem.SubItems[4].Text == "删除" ? true : false;
                rbtn_Sex1.Checked = myitem.SubItems[5].Text == "男" ? true : false;
                rbtn_Sex2.Checked = myitem.SubItems[5].Text == "女" ? true : false;
                txt_MemberRemark.Text = myitem.SubItems[6].Text;
                lbl_Status.Text = "修改";
            }
        }

        private void btn_Del_Click(object sender, EventArgs e)
        {
            if (memberid == "")
            {
                MessageBox.Show("请先选择要删除的会员信息");
            }
            else
            {
                DialogResult result = MessageBox.Show("确定要删除选中的会员信息？", "删除提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string sqlstr = string.Format("delete from Member_Info where MemberID={0}", memberid);
                    int i = Data.DataExcute(sqlstr);
                    if (i > 0)
                    {
                        lbl_Note.Text = "恭喜您，会员信息删除成功！";
                        lbl_Note.ForeColor = Color.Blue;
                        ClearTextBox();
                        DataBind_MemberInfo();
                    }
                    else
                    {
                        lbl_Note.Text = "对不起，会员信息删除失败！";
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

        private void btn_Normal_Click(object sender, EventArgs e)
        {
            if (memberid == "")//如果没有选中要设为正常的会员信息
            { MessageBox.Show("请先选择要设为正常的会员信息"); }
            else
            {
                DialogResult result = MessageBox.Show("确定要设置选中的会员状态为“正常”？", "操作提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string sqlstr = string.Format("update Member_Info set MemberStatus = 1 where MemberID={0}", memberid);
                    int i = Data.DataExcute(sqlstr);
                    if (i > 0)
                    {
                        lbl_Note.Text = "恭喜您，会员状态成功修改为“正常”！";
                        lbl_Note.ForeColor = Color.Blue;
                        ClearTextBox(); //调用函数，清空各控件
                        DataBind_MemberInfo(); //重新加载会员信息
                    }
                    else
                    {
                        lbl_Note.Text = "对不起，会员状态修改失败！";
                        lbl_Note.ForeColor = Color.Red;
                    }
                }
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (memberid == "")//如果没有选中要删除的会员信息
            { MessageBox.Show("请先选择要删除的会员信息"); }
            else
            {
                DialogResult result = MessageBox.Show("确定要设置选中的会员状态为“删除”？", "操作提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string sqlstr = string.Format("update Member_Info set MemberStatus = 2 where MemberID={0}", memberid);
                    int i = Data.DataExcute(sqlstr);
                    if (i > 0)
                    {
                        lbl_Note.Text = "恭喜您，会员状态成功修改为“删除”！";
                        lbl_Note.ForeColor = Color.Blue;
                        ClearTextBox(); //调用函数，清空各控件
                        DataBind_MemberInfo(); //重新加载会员信息
                    }
                    else
                    {
                        lbl_Note.Text = "对不起，会员状态修改失败！";
                        lbl_Note.ForeColor = Color.Red;
                    }
                }
            }
        }
    }
}
