using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.DataAccess
{
    class FinancialDao
    {
        public static int TotalSalary(int day)
        {
            int Total = 0;
            String sql = "Select sum(salary) as total from Employee";
            DataTable dt = Dao.GetDataBySQL(sql);
            foreach(DataRow dr in dt.Rows)
            {
                Total = Int32.Parse(dr["total"].ToString());
            }
            return Total/30*day;
        }

        public static int TotalOutComeInRange(DateTime begin , DateTime end)
        {
            String sql = "select sum(money) as total from OutCome where date_of between @begin and @end";
            SqlParameter param1 = new SqlParameter("@begin", SqlDbType.DateTime);
            param1.Value = begin;

            SqlParameter param2 = new SqlParameter("@end", SqlDbType.DateTime);
            param2.Value = end;

            int Total = 0;
            DataTable dt = Dao.GetDataBySQLWithParameters(sql, param1, param2);
            foreach (DataRow dr in dt.Rows)
            {
                Total = Int32.Parse(dr["total"].ToString());
            }
            return Total;
        }
        public static int AllIncomeInRange(DateTime begin , DateTime end)
        {
            String sql = "select dishs.price , dishs.discount , order_detail.quantity " +
                "from order_detail " +
                "left join order_table on order_detail.order_id = order_table.id " +
                "inner join dishs on dishs.id = order_detail.product_id " +
                "where order_date between @begin and @end";
            SqlParameter param1 = new SqlParameter("@begin", SqlDbType.DateTime);
            param1.Value = begin;

            SqlParameter param2 = new SqlParameter("@end", SqlDbType.DateTime);
            param2.Value = end;
            DataTable dt = Dao.GetDataBySQLWithParameters(sql, param1, param2);

            return getTotalMoneyFromTable(dt);

        }
        private static int getTotalMoneyFromTable(DataTable dt)
        {
            double total = 0;
            foreach (DataRow dr in dt.Rows)
            {
                int price = Int32.Parse(dr["price"].ToString());
                int quant = Int32.Parse(dr["quantity"].ToString());
                double dis = Double.Parse(dr["discount"].ToString());
                total += (price - price * dis) * quant;
            }
            return (int)total;
        }

        public static int addOutCome(int money)
        {
            String sql = " insert into OutCome (date_of,money) values(SYSDATETIME(), " + money + ")";
            return Dao.ExecuteSQL(sql);
        }
    }
}
