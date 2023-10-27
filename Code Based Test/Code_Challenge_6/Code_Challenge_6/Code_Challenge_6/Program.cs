using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace Code_Challenge_6
{
    class Program
    {
        public static SqlConnection con;
        public static SqlCommand cmd;
        static SqlConnection GetConnection()
        {
            con = new SqlConnection("Data Source=ICS-LT-8ZLV6D3; Initial Catalog=Code_Challenge_6;Integrated Security = True");
            con.Open();
            return con;
        }
        static void Main(string[] args)
        {
            //AddEmployee();
            DisplayAllEmployees();
            Console.Read();
        }

        // Adding New Employee Details
        static void AddEmployee()
        {
            try
            {
                con = GetConnection();

                con.Open();
                Console.WriteLine("Enter Employee Name :");
                string eName = Console.ReadLine();
                Console.WriteLine("Enter employee Salary :");
                decimal eSal = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Enter Employee type PartTime 'P' or FullTime 'F' ");
                char eType = Convert.ToChar(Console.Read());

                // Command to call the stored procedure
                cmd = new SqlCommand("AddEmployee", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add(new SqlParameter("@empname", SqlDbType.VarChar, 35) { Value = eName });
                cmd.Parameters.Add(new SqlParameter("@empsal", SqlDbType.Decimal) { Value = eSal });
                cmd.Parameters.Add(new SqlParameter("@emptype", SqlDbType.Char, 1) { Value = eType });

               // Executing the stored procedure
                cmd.ExecuteNonQuery();

                Console.WriteLine("Employee record added successfully.");

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        static void DisplayAllEmployees()
        {
            con = GetConnection();
            cmd = new SqlCommand("SELECT * FROM Code_Employee", con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();

            try
            {
                adapter.Fill(dataTable);

                foreach (DataRow row in dataTable.Rows)
                {
                    int empno = Convert.ToInt32(row["empno"]);
                    string empname = row["empname"].ToString();
                    decimal empsal = Convert.ToDecimal(row["empsal"]);
                    char emptype = Convert.ToChar(row["emptype"]);

                    Console.WriteLine($"EmpNo: {empno}, EmpName: {empname}, EmpSal: {empsal}, EmpType: {emptype}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: Try Again\n" + ex.Message);
            }
            finally
            {
               con.Close();
            }
        }

    }
}