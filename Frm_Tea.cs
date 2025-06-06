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
    public partial class Frm_Tea : Form
    {
        private string teaid="";
        public Frm_Tea()
        {
            InitializeComponent();
        }

        private void Frm_Tea_Load(object sender, EventArgs e)
        {
            DataBind_TeaInfo(); //加载饮品信息
            cbb_Status.SelectedIndex = 0;
        }
        protected void DataBind_TeaInfo()
        {
            string sqlstr = "select * from Tea_Info";
            DataTable dt = Data.DataQuery(sqlstr);
            lv_TeaInfo.Items.Clear(); //先清空列表视图控件中现有行
            foreach (DataRow dr in dt.Rows)
            {
                ListViewItem myitem = new ListViewItem(dr["TeaID"].ToString()); //饮品编号
                myitem.SubItems.Add(dr["TeaName"].ToString()); //饮品名称
                myitem.SubItems.Add(dr["TeaPriceS"].ToString()); //价格(小)
                myitem.SubItems.Add(dr["TeaPriceM"].ToString()); //价格(中)
                myitem.SubItems.Add(dr["TeaPriceL"].ToString()); //价格(大)
                switch (dr["TeaStatus"].ToString()) //状态
                {
                    case "1": myitem.SubItems.Add("在售"); break;
                    case "2": myitem.SubItems.Add("售完"); break;
                    case "3": myitem.SubItems.Add("停售"); break;
                    default: break;
                }
                myitem.SubItems.Add(dr["TeaImage"].ToString()); //图片路径
                lv_TeaInfo.Items.Add(myitem); //将新建项添加到ListView控件中}}
            }
        }

        private void btn_Image_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "图片|*.jpg;*.png";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = openFileDialog1.FileName;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            string teaName = txt_TeaName.Text.Trim();
            string teaPriceS = txt_TeaPriceS.Text.Trim();//价格（小）
            string teaPriceM = txt_TeaPriceM.Text.Trim();//价格（中）
            string teaPriceL = txt_TeaPriceL.Text.Trim(); //价格(大）
            int status=1; //状态(1在售, 2售完, 3:停售）
            string teaImage = pictureBox1.ImageLocation; //饮品图片
            switch (cbb_Status.SelectedIndex)
            {
                case 0:status = 1; break;
                case 1:status = 2; break;
                case 2:status = 3; break;
                default:status = 1; break;
            }
            if (teaName == "") //饮品名称
            {
                lbl_Note.Text = "饮品名称不能为空！";
                lbl_Note.ForeColor = Color.Red;
                txt_TeaName.Focus();
            }
            else if (lbl_Operation.Text == "添加") //如果是“添加”操作
            {
                string sqlstr = string.Format("insert into Tea_Info values('{0}','{1}', '{2}','{3}',{4},'{5}') ", teaName, teaPriceS, teaPriceM, teaPriceL, status, teaImage);
                int i = Data.DataExcute(sqlstr);
                if (i > 0)
                {
                    lbl_Note.Text = "饮品信息添加成功！";
                    lbl_Note.ForeColor = Color.Blue;
                    ClearTextBox(); //调用函数，清空各控件
                    DataBind_TeaInfo(); //重新加载饮品信息
                }
                else
                {
                    lbl_Note.Text = "对不起，饮品信息添加失败！";
                    lbl_Note.ForeColor = Color.Red;
                }
            }
            else //如果是“修改”操作 (后续步骤将会实现该功能)
            {
                string sqlstr = string.Format("update Tea_Info set TeaName='{0}', TeaImage='{1}', TeaPriceS ='{2}', TeaPriceM ='{3}', TeaPriceL ='{4}', TeaStatus ={5} where TeaID = '{6}'", teaName, teaImage, teaPriceS, teaPriceM, teaPriceL, status, teaid);
                int i = Data.DataExcute(sqlstr);
                if (i > 0)
                {
                    lbl_Note.Text = "饮品信息添加成功！";
                    lbl_Note.ForeColor = Color.Blue;
                    ClearTextBox();
                    DataBind_TeaInfo();
                }
                else
                {
                    lbl_Note.Text = "对不起，饮品信息添加失败！";
                    lbl_Note.ForeColor = Color.Red;
                }
            }
        }
        protected void ClearTextBox()
        {
            txt_TeaName.Text = "";
            pictureBox1.ImageLocation = "";
            txt_TeaPriceS.Text = "0";
            txt_TeaPriceM.Text = "0";
            txt_TeaPriceL.Text = "0";
            cbb_Status.SelectedIndex = 0;
            lbl_Operation.Text = "添加";
            teaid = "";
        }

        private void lv_TeaInfo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv_TeaInfo.SelectedItems.Count > 0)//如果有选中项
            {
                ListViewItem myitem = lv_TeaInfo.SelectedItems[0]; //获取选中的第一行(一次只能选一行“ )
                teaid = myitem.SubItems[0].Text;//将选中行第1列的值赋值全局变量，饮品编号
                txt_TeaName.Text = myitem.SubItems[1].Text; //饮品名称
                txt_TeaPriceS.Text = myitem.SubItems[2].Text; //价格(小）
                txt_TeaPriceM.Text = myitem.SubItems[3].Text; //价格(中）
                txt_TeaPriceL.Text = myitem.SubItems[4].Text; //价格(大）
                switch (myitem.SubItems[5].Text) //状态
                {
                    case "在售": cbb_Status.SelectedIndex = 0; break;
                    case "售完": cbb_Status.SelectedIndex = 1; break;
                    case "停售": cbb_Status.SelectedIndex = 2; break;
                    default: cbb_Status.SelectedIndex = 0; break;
                }
                pictureBox1.ImageLocation = myitem.SubItems[6].Text; //饮品图片
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                lbl_Operation.Text = "修改"; //当前状态 }
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            ClearTextBox(); //调用函数，清空各控件
            lbl_Operation.Text = "添加";
            lbl_Note.Text = "";
            teaid = "";
        }

        private void btn_OnSale_Click(object sender, EventArgs e)
        {
            if (teaid == "")//如果没有选中要在售的饮品信息
            { MessageBox.Show("请先选择要在售的饮品信息"); }
            else
            {
                DialogResult result = MessageBox.Show("确定要设置选中的饮品状态为“在售”？", "操作提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string sqlstr = string.Format("update Tea_Info set TeaStatus = 1 where TeaID={0}", teaid);
                    int i = Data.DataExcute(sqlstr);
                    if (i > 0)
                    {
                        lbl_Note.Text = "恭喜您，饮品状态成功修改为“在售”！";
                        lbl_Note.ForeColor = Color.Blue;
                        ClearTextBox(); //调用函数，清空各控件
                        DataBind_TeaInfo(); //重新加载饮品信息
                    }
                    else
                    {
                        lbl_Note.Text = "对不起，饮品状态修改失败！";
                        lbl_Note.ForeColor = Color.Red;
                    }
                }
            }
        }

        private void btn_SoldOut_Click(object sender, EventArgs e)
        {
            if (teaid == "")//如果没有选中要售完的饮品信息
            { MessageBox.Show("请先选择要售完的饮品信息"); }
            else
            {
                DialogResult result = MessageBox.Show("确定要设置选中的饮品状态为“售完”？", "操作提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string sqlstr = string.Format("update Tea_Info set TeaStatus = 2 where TeaID={0}", teaid);
                    int i = Data.DataExcute(sqlstr);
                    if (i > 0)
                    {
                        lbl_Note.Text = "恭喜您，饮品状态成功修改为“售完”！";
                        lbl_Note.ForeColor = Color.Blue;
                        ClearTextBox(); //调用函数，清空各控件
                        DataBind_TeaInfo(); //重新加载饮品信息
                    }
                    else
                    {
                        lbl_Note.Text = "对不起，饮品状态修改失败！";
                        lbl_Note.ForeColor = Color.Red;
                    }
                }
            }
        }

        private void btn_StopSell_Click(object sender, EventArgs e)
        {
            if (teaid == "")//如果没有选中要停售的饮品信息
            { MessageBox.Show("请先选择要停售的饮品信息"); }
            else
            {
                DialogResult result = MessageBox.Show("确定要设置选中的饮品状态为“停售”？", "操作提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string sqlstr = string.Format("update Tea_Info set TeaStatus = 3 where TeaID={0}", teaid);
                    int i = Data.DataExcute(sqlstr);
                    if (i > 0)
                    {
                        lbl_Note.Text = "恭喜您，饮品状态成功修改为“停售”！";
                        lbl_Note.ForeColor = Color.Blue;
                        ClearTextBox(); //调用函数，清空各控件
                        DataBind_TeaInfo(); //重新加载饮品信息
                    }
                    else
                    {
                        lbl_Note.Text = "对不起，饮品状态修改失败！";
                        lbl_Note.ForeColor = Color.Red;
                    }
                }
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (teaid == "") //如果没有选中要删除的饮品信息
            {
                MessageBox.Show("请先选择要删除的饮品信息");
            }
            else
            {
                DialogResult result = MessageBox.Show("确定要删除选中的饮品信息？", "删除提示",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    string sqlstr = string.Format("delete from Tea_Info where TeaID={0}", teaid);
                    int i = Data.DataExcute(sqlstr);
                    if (i > 0)
                    {
                        lbl_Note.Text = "恭喜您，饮品信息删除成功！";
                        lbl_Note.ForeColor = Color.Blue;
                        ClearTextBox(); //调用函数，清空各控件
                        DataBind_TeaInfo(); //重新加载饮品信息
                    }
                    else
                    {
                        lbl_Note.Text = "对不起，饮品信息删除失败！";
                        lbl_Note.ForeColor = Color.Red;
                    }
                }
            }
        }

        private void txt_TeaPriceS_KeyPress(object sender, KeyPressEventArgs e)
        {
            //如果输入的不是数字，也不是退格键，也不是回车键
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 13)
            {
                e.Handled = true; //不接受此输入，即输入无效
            }
        }

        private void txt_TeaPriceM_KeyPress(object sender, KeyPressEventArgs e)
        {
            //如果输入的不是数字，也不是退格键，也不是回车键
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 13)
            {
                e.Handled = true; //不接受此输入，即输入无效
            }
        }

        private void txt_TeaPriceL_KeyPress(object sender, KeyPressEventArgs e)
        {
            //如果输入的不是数字，也不是退格键，也不是回车键
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 13)
            {
                e.Handled = true; //不接受此输入，即输入无效
            }
        }
    }
}
