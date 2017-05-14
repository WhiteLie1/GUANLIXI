using System.Data.SqlClient;//此头文件绝对不能少
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XueshenguanLi
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)//查询按键
        {
            SqlConnection conn = sqlHelper.getConn();
            conn.Open();

            SqlDataAdapter sqlDap = new SqlDataAdapter("Select * from student", conn);
            DataSet dds = new DataSet();
            sqlDap.Fill(dds);
            DataTable _table = dds.Tables[0];
            int count = _table.Rows.Count;
            dataGridView1.DataSource = _table;
            conn.Close();
           
            conn.Close();  
        }

        private void button4_Click(object sender, EventArgs e)//删除按键
        {
            SqlConnection conn = sqlHelper.getConn();
            conn.Open();
            if (dataGridView1.SelectedRows.Count != 1) return;
            if (dataGridView1.CurrentRow == null) return;
             

            DataRowView row = dataGridView1.CurrentRow.DataBoundItem as DataRowView;
            if (row["id"] == null) return;//可以进行快速监视  
            string bd = Convert.ToString(row["id"]);
            string selectsql = "delete from student where id = " + bd + "";
            SqlCommand cmd = new SqlCommand(selectsql, conn);
            cmd.CommandType = CommandType.Text;
            
            int ret = cmd.ExecuteNonQuery();//受影响的行数（总数）  
            if (ret == -1)
            {
                MessageBox.Show("删除失败！");
                return;
            }
            else
            {
                MessageBox.Show("删除成功！");
            }
            conn.Close();  
        }

        private void button2_Click(object sender, EventArgs e)
        {

            new System.Threading.Thread(() => { Application.Run(new UpdataForm ()); }).Start();
                return;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new System.Threading.Thread(() => { Application.Run(new UpdataForm()); }).Start();
            return;

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
           /* if (MessageBox.Show("确定要退出系统吗？", "提示"，MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.ok)
            {
                Application.Exit();

            }
            else
                e.Cancel = true;*/
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
          /*  toolStripStatusLabel2.Text = "||操作用户：" + Form.userrname;
            toolStripStatusLabel3.Text="||操作权限："+
                toolStripStatusLabel1.Text = "||登录时间"+DataSetDateTime.now*/

        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Red;
        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {

        }
    }
}
