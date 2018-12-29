using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connction_Oracle
{
    class Program
    {
        static void Main(string[] args)
        {
            //导入Oraelc 链接包
            string connstr = "Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=tcp)(HOST=192.163.52.227)(PORT=1521))(CONNECT_DATA=(SERVICE_NAME=ORCL)));user id=scott;password=tiger;";
            //创建链接对象
            using (OracleConnection Oconn = new OracleConnection(connstr))
            {
                string sql = string.Format("insert into stu values('{0},'zhangshan','123456')", Guid.NewGuid().ToString().ToUpper());
                //创建命令对象
                using (OracleCommand OCmd = new OracleCommand(sql, Oconn))
                {
                    Oconn.Open();
                    int row = OCmd.ExecuteNonQuery();
                    Console.WriteLine("插入了" + row + "行"); 
			Console.WriteLine("插入了" + row + "行");
			Console.WriteLine("插入了" + row + "行"); 
			Console.WriteLine("插入了" + row + "行"); 

                }
            }
            Console.Read();
        }
    }
}
