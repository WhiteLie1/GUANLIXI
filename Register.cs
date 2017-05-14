using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;//此头文件绝对不能少

namespace XueshenguanLi
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = sqlHelper.getConn();
            conn.Open();

            string selectsql = "Insert into login values('" + textBox1.Text + "', '" + textBox2.Text + "')";


            SqlCommand cmd = new SqlCommand(selectsql, conn);//SqlCommand对象允许你指定在数据库上执行的操作的类型。  
            cmd.CommandType = CommandType.Text;

            if (textBox1.Text == "")
            {
                MessageBox.Show("用户名不能为空！");
            }
            else
            {
                if (textBox2.Text == "")
                {
                    MessageBox.Show("密码不能为空！");
                }
                else
                {
                    MessageBox.Show("注册成功！");
                    MainForm form = new MainForm();//登陆成功显示主界面  
                    form.Show();
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;//这里实现登陆成功后关掉登录界面 
                }
            }
        }
    }
}
