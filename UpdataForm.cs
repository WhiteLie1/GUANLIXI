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
    public partial class UpdataForm : Form
    {
        public UpdataForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) //添加按钮
        {
            //设置主键的作用 表的唯一识别作用 自己自动增加

            SqlConnection conn = sqlHelper.getConn();
            conn.Open();
            string selectsql = "insert into student ([sname],[score]) values('" + textBox1.Text + "'," + textBox2.Text + ")";
            SqlCommand cmd = new SqlCommand(selectsql, conn);
            cmd.CommandType = CommandType.Text;
            
            int count = cmd.ExecuteNonQuery();
              
            if (count == -1)
            {
                MessageBox.Show("失败！添加失败!请重新输入姓名和分数重新添加！");
                return;
            }
            else
            {
                MessageBox.Show("添加成功！");
            }
            conn.Close();


           
            conn.Close();
            UpdataForm udform = new UpdataForm();  

            this.DialogResult = System.Windows.Forms.DialogResult.OK;  
        }

        private void button2_Click(object sender, EventArgs e)//修改按钮
        {
            SqlConnection conn = sqlHelper.getConn();
            conn.Open();
            string selectsql = "update student set score = " + textBox2.Text + " where sname = '" + textBox1.Text + "'";
            SqlCommand cmd = new SqlCommand(selectsql, conn);
          

            int count2 = cmd.ExecuteNonQuery();

            if (count2 == -1)
            {
                MessageBox.Show("失败！修改失败!请重新输入姓名和分数重新添加！");
                return;
            }
            else
            {
                MessageBox.Show("修改成功！");
            }
            conn.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
