using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.DataAccess
{
    class DetailDao
    {
        public static DataTable Select_Detail_by_ID(int id)
        {
            String sql = "select order_detail.id as ID ,customer.name as Customer," +
                "dishs.name as Product , " +
                "dishs.price as Price,dishs.discount as Discount ,order_table.order_date as OrderDate," +
                "order_table.num_of_table as Num_Table, order_detail.quantity as Quantity " +
                "from order_detail left join dishs on dishs.id = order_detail.product_id " +            
                "left join order_table on order_table.id = order_detail.order_id  " +
                 "inner join customer on customer.id = order_table.customer_id " +
                "where order_table.id = " + id;
            return Dao.GetDataBySQL(sql);
        }
    }
}
