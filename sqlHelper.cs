using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XueshenguanLi
{
    public class sqlHelper
    {
        public static SqlConnection getConn()//代码访问数据库的代码
        {
            // 要记住 以后改链接字符串可以这里改 
            // string str = @"Data Source=LAPTOP-IG8UTAEQ;Initial catalog=Login Table;integrated Security=True";
            SqlConnection conn = new SqlConnection("server=.\\SQLEXPRESS;Initial Catalog=Login Table;Integrated Security=SSPI");
            return conn;
        }
    }
}
