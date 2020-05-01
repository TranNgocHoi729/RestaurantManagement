using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.DataAccess
{
    class EmployeeDao
    {
        public static List<Entity.Employee> getAllEmp()
        {
            List<Entity.Employee> list = new List<Entity.Employee>();
            String sql = "Select * from employee";
            DataTable dt = Dao.GetDataBySQL(sql);
            foreach (DataRow dr in dt.Rows)
            {
                Entity.Employee emp = new Entity.Employee();
                emp.id = Int32.Parse(Convert.ToString(dr["id"]));
                emp.Name = Convert.ToString(dr["name"]);
                emp.Identity = Convert.ToString(dr["identify_id"]);
                emp.Dob = Convert.ToString(dr["dob"]);
                emp.Gender = Convert.ToInt32(dr["gender"]);
                emp.Address = Convert.ToString(dr["address"]);
                emp.Phone = Convert.ToString(dr["Phone"]);
                emp.Role = Convert.ToString(dr["role"]);
                emp.Salary = Int32.Parse(Convert.ToString(dr["salary"]));
                emp.Start_date = Convert.ToString(dr["start_date"]);
                list.Add(emp);
            }
            return list;
        }

        public static int InsertEmp(Entity.Employee emp)
        {
            String sql = " insert into employee(name,identify_id,dob,gender,phone,address,role,salary,start_date,description)"
                            + " Values (@name, @iden, @dob, @gen,@phone,@address, @role,@salary,SYSDATETIME(),@dess)";
            SqlParameter param1 = new SqlParameter("@name", SqlDbType.NVarChar);
            param1.Value = emp.Name;

            SqlParameter param2 = new SqlParameter("@iden", SqlDbType.NVarChar);
            param2.Value = emp.Identity;

            SqlParameter param3 = new SqlParameter("@dob", SqlDbType.DateTime);
            param3.Value = emp.Dob;

            SqlParameter param4 = new SqlParameter("@gen", SqlDbType.Int);
            param4.Value = emp.Gender;

            SqlParameter param5 = new SqlParameter("@phone", SqlDbType.VarChar);
            param5.Value = emp.Phone;

            SqlParameter param6 = new SqlParameter("@address", SqlDbType.NVarChar);
            param6.Value = emp.Address;

            SqlParameter param7 = new SqlParameter("@role", SqlDbType.NVarChar);
            param7.Value = emp.Role;

            SqlParameter param8 = new SqlParameter("@salary", SqlDbType.Int);
            param8.Value = emp.Salary;

            SqlParameter param9 = new SqlParameter("@dess", SqlDbType.NVarChar);
            param9.Value = emp.Description;

            int check = Dao.ExecuteSQLWithParameters(sql, param1, param2, param3, param4, param5, param6, param7, param8, param9);
            return check;
        }

        public static int updateEmp(String phone, String address, String role, int salary, String description, int id)
        {
            String sql = "update employee set phone = @phone ,address = @address,role = @role,salary = @salary,description = @des where id = @id";
            SqlParameter param1 = new SqlParameter("@phone", SqlDbType.NVarChar);
            param1.Value = phone;

            SqlParameter param2 = new SqlParameter("@address", SqlDbType.NVarChar);
            param2.Value = address;

            SqlParameter param3 = new SqlParameter("@role", SqlDbType.NVarChar);
            param3.Value = role;

            SqlParameter param4 = new SqlParameter("@salary", SqlDbType.Int);
            param4.Value = salary;

            SqlParameter param5 = new SqlParameter("@des", SqlDbType.NVarChar);
            param5.Value = description;

            SqlParameter param6 = new SqlParameter("@id", SqlDbType.Int);
            param6.Value = id;

            return Dao.ExecuteSQLWithParameters(sql, param1, param2, param3, param4, param5, param6);
        }

        public static int deleteEmp(int id)
        {
            String sql = "delete employee where id =" + id;
            return Dao.ExecuteSQL(sql);
        }
    }
}

