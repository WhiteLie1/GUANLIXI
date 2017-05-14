
 
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       

        private void textBox2_TextChanged(object sender, EventArgs e)
       {

        }

        private void button1_Click(object sender, EventArgs e)//登陆
        {
            //使用sqlhelp 来实现
            SqlConnection conn = sqlHelper.getConn();
            conn.Open();

            string selectsql = "Select * from login where userrname = '" + textBox1.Text + "' and passward='" + textBox2.Text + "'";
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
                    int count3 = cmd.ExecuteNonQuery();
                    if (count3 == -1)
                    {
                        MessageBox.Show("登录成功！");
                        MainForm form = new MainForm();//登陆成功显示主界面  
                        form.Show();
                        this.DialogResult = System.Windows.Forms.DialogResult.OK;//这里实现登陆成功后关掉登录界面  

                        return;
                    }
                    else
                    {
                        MessageBox.Show("登陆失败!请检查用户名或者密码重新登陆！");
                    }
                    conn.Close();
                }

            }   

        }

        private void button2_Click(object sender, EventArgs e)//注册
        {
            new System.Threading.Thread(() => { Application.Run(new Register()); }).Start();
            return;
        

           /* SqlConnection conn = sqlHelper.getConn();
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
                }
            }



            int count4 = cmd.ExecuteNonQuery();
            if (count4 == -1)
            {
                MessageBox.Show("注册失败!请重新输入用户名或者密码重新注册！");
                
                return;
            }
          
            else
            {
                MessageBox.Show("注册成功！");
               
            }
            textBox1.Text = "";//使得注册成功以后把数据清除
            textBox2.Text = "";*/


        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
