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
    public partial class Frm_Price : Form
    {
        protected string priceid = "";
        public Frm_Price()
        {
            InitializeComponent();
        }

        private void Frm_Price_Load(object sender, EventArgs e)
        {
            DataBind_PriceInfo(); //加载价格信息
        }
        protected void DataBind_PriceInfo()
        {
            string sqlstr = "select * from Price_Info";
            DataTable dt = Data.DataQuery(sqlstr);
            lv_PriceInfo.Items.Clear(); //先清空列表视图控件中现有行
            foreach (DataRow dr in dt.Rows)
            {
                ListViewItem myitem = new ListViewItem(dr["PriceID"].ToString()); //价格编号
                myitem.SubItems.Add(dr["TeaID"].ToString()); //饮品编号
                myitem.SubItems.Add(dr["TeaPriceS"].ToString()); //价格(小)
                myitem.SubItems.Add(dr["TeaPriceM"].ToString()); //价格(中)
                myitem.SubItems.Add(dr["TeaPriceL"].ToString()); //价格(大)
                myitem.SubItems.Add(dr["BeginDate"].ToString());//开始日期
                myitem.SubItems.Add(dr["EndDate"].ToString());//结束日期
                lv_PriceInfo.Items.Add(myitem); //将新建项添加到ListView控件中
            }
        }
        private bool IsTeaIDValid(string teaID)
        {
            string checkSql = "SELECT COUNT(TeaID) FROM Tea_Info WHERE TeaID = @TeaID";
            using (SqlConnection conn = new SqlConnection("Data Source=localhost;database=Teashop;Integrated Security=SSPI")) 
            {
                using (SqlCommand cmd = new SqlCommand(checkSql, conn))
                {
                    cmd.Parameters.AddWithValue("@TeaID", teaID);
                    try
                    {
                        conn.Open();
                        int count = (int)cmd.ExecuteScalar();
                        return count > 0;
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("SQL 执行错误：" + ex.Message);
                        return false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("发生错误：" + ex.Message);
                        return false;
                    }
                }
            }
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            string teaID = txt_TeaID.Text.Trim();
            string teaPriceS = txt_PriceS.Text.Trim();
            string teaPriceM = txt_PriceM.Text.Trim();
            string teaPriceL = txt_PriceL.Text.Trim();
            DateTime beginDate = dtp_BeginDate.Value;
            DateTime endDate = dtp_EndDate.Value;
            if (teaID == "") //饮品编号
            {
                lbl_Note.Text = "饮品编号不能为空！";
                lbl_Note.ForeColor = Color.Red;
                txt_TeaID.Focus();
            }
            else if (beginDate >= endDate)
            {
                MessageBox.Show("开始日期不能晚于结束日期，请重新选择！");
                dtp_BeginDate.Focus();
            }
            else if (lbl_Operation.Text == "添加") //如果是“添加”操作
            {
                if (IsTeaIDValid(teaID))
                {
                    string beginDateStr = beginDate.ToString("yyyy-MM-dd");
                    string endDateStr = endDate.ToString("yyyy-MM-dd");
                    string sqlstr = string.Format("insert into Price_Info values('{0}','{1}', '{2}','{3}','{4}','{5}') ", teaID, teaPriceS, teaPriceM, teaPriceL, beginDateStr, endDateStr);
                    int i = Data.DataExcute(sqlstr);
                    if (i > 0)
                    {
                        lbl_Note.Text = "价格信息添加成功！";
                        lbl_Note.ForeColor = Color.Blue;
                        ClearTextBox();
                        DataBind_PriceInfo();
                    }
                    else
                    {
                        lbl_Note.Text = "对不起，价格信息添加失败！";
                        lbl_Note.ForeColor = Color.Red;
                    }
                }
                else
                {
                    MessageBox.Show("饮品编号不存在，请先在饮品列表中添加该饮品编号。");
                }
            }
            else//修改
            {
                string escapedTeaID = teaID.Replace("'", "''");
                string escapedTeaPriceS = teaPriceS.Replace("'", "''");
                string escapedTeaPriceM = teaPriceM.Replace("'", "''");
                string escapedTeaPriceL = teaPriceL.Replace("'", "''");
                // 确保日期格式正确
                string beginDateStr = beginDate.ToString("yyyy-MM-dd");
                string endDateStr = endDate.ToString("yyyy-MM-dd");
                // 构建 SQL 语句
                string sqlstr = string.Format("update Price_Info set TeaID='{0}', TeaPriceS ='{1}', TeaPriceM ='{2}', TeaPriceL ='{3}', BeginDate='{4}', EndDate='{5}' where PriceID = '{6}'", escapedTeaID, escapedTeaPriceS, escapedTeaPriceM, escapedTeaPriceL, beginDateStr, endDateStr, priceid);
                int i = Data.DataExcute(sqlstr);
                if (i > 0)
                {
                    lbl_Note.Text = "价格信息修改成功！";
                    lbl_Note.ForeColor = Color.Blue;
                    ClearTextBox(); //调用函数，清空各控件
                    DataBind_PriceInfo(); //重新加载价格信息
                }
                else
                {
                    lbl_Note.Text = "对不起，价格信息修改失败！";
                    lbl_Note.ForeColor = Color.Red;
                }
            }
        }
        protected void ClearTextBox()
        {
            txt_TeaID.Text = "";
            txt_PriceS.Text = "0";
            txt_PriceM.Text = "0";
            txt_PriceL.Text = "0";
            lbl_Operation.Text = "添加";
            priceid = "";
        }

        private void lv_PriceInfo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_PriceInfo.SelectedItems.Count > 0) //如果有选中项
            {
                ListViewItem myitem= lv_PriceInfo.SelectedItems[0]; //获取选中的第一行(一次只能选一行“ )
                priceid = myitem.SubItems[0].Text;
                txt_TeaID.Text = myitem.SubItems[1].Text;
                txt_PriceS.Text = myitem.SubItems[2].Text; //价格(小）
                txt_PriceM.Text = myitem.SubItems[3].Text; //价格(中）
                txt_PriceL.Text = myitem.SubItems[4].Text; //价格(大）
                DateTime beginDate = dtp_BeginDate.Value;
                DateTime endDate = dtp_EndDate.Value;
                // 将 DateTime 值转换为字符串并存储到 myitem 的子项中
                myitem.SubItems[5].Text = beginDate.ToString("yyyy-MM-dd");
                myitem.SubItems[6].Text = endDate.ToString("yyyy-MM-dd");
                lbl_Operation.Text = "修改"; //当前状态 
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            ClearTextBox(); //调用函数，清空各控件
            lbl_Operation.Text = "添加";
            lbl_Note.Text = "";
        }

        private void txt_PriceS_KeyPress(object sender, KeyPressEventArgs e)
        {
            //如果输入的不是数字，也不是退格键，也不是回车键
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 13)
            {
                e.Handled = true; //不接受此输入，即输入无效
            }
        }

        private void txt_PriceM_KeyPress(object sender, KeyPressEventArgs e)
        {
            //如果输入的不是数字，也不是退格键，也不是回车键
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 13)
            {
                e.Handled = true; //不接受此输入，即输入无效
            }
        }

        private void txt_PriceL_KeyPress(object sender, KeyPressEventArgs e)
        {
            //如果输入的不是数字，也不是退格键，也不是回车键
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 13)
            {
                e.Handled = true; //不接受此输入，即输入无效
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (priceid == "")
            { MessageBox.Show("请先选择要删除的价格"); }
            else
            {
                DialogResult result = MessageBox.Show("确定要删除选中的价格信息？", "删除提示",MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string sqlstr = string.Format("delete from Price_Info where PriceID={0}", priceid);
                    int i = Data.DataExcute(sqlstr);
                    if (i > 0)
                    {
                        lbl_Note.Text = "恭喜您，价格信息删除成功！";
                        lbl_Note.ForeColor = Color.Blue;
                        ClearTextBox(); //调用函数，清空各控件
                        DataBind_PriceInfo(); //重新加载价格信息
                    }
                    else
                    {
                        lbl_Note.Text = "对不起，价格信息删除失败！";
                        lbl_Note.ForeColor = Color.Red;
                    }
                }
            }
        }
    }
}
