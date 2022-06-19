using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePay
{
    public class EmployeePayRoll
    {
       
        static string connectionstring = @"Data source=(localdb)\MSSQLLocalDB;Initial Catalog=payroll_service;Integrated Security=SSPI";
        static SqlConnection connection = new SqlConnection(connectionstring);

        public void EstablishConnection()
        {
            if (connection != null && connection.State.Equals(ConnectionState.Closed))
            {
                try
                {
                    connection.Open();
                }
                catch (Exception)
                {
                    throw new EmployeeException(EmployeeException.ExceptionType.CONNECTION_FAILED, "Connection Not Found");
                }
            }
        }
        public void CloseConnection()
        {
            if (connection != null && connection.State.Equals(ConnectionState.Open))
            {
                try
                {
                    connection.Close();
                }
                catch (Exception)
                {
                    throw new EmployeeException(EmployeeException.ExceptionType.CONNECTION_FAILED, "Connection Not Found");
                }
            }
        }
        public int sp_payroll_service(Employee employee)
        {
            SqlConnection connection = new SqlConnection(connectionstring);
            try
            {
                using (connection)
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand("sp_payroll_service", connection)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                  
                    cmd.Parameters.AddWithValue("@Name", employee.Name);
                    cmd.Parameters.AddWithValue("@salary", employee.Salary);
                    cmd.Parameters.AddWithValue("@Gender", employee.Gender);
                    cmd.Parameters.AddWithValue("@StartDate", employee.StartDate);
                    cmd.Parameters.AddWithValue("@Phone", employee.PhoneNumber);
                    cmd.Parameters.AddWithValue("@Address", employee.Address);
                    cmd.Parameters.AddWithValue("@Department", employee.Department);
                    cmd.Parameters.AddWithValue("@Basic_Pay", employee.BasicPay);
                    cmd.Parameters.AddWithValue("@Deductuions", employee.Deduictions);
                    cmd.Parameters.AddWithValue("@Taxable_Pay", employee.TaxablePay);
                    cmd.Parameters.AddWithValue("@Income_Tax", employee.IncomeTax);
                    cmd.Parameters.AddWithValue("@Net_pay", employee.NetPay);
                    
                    var returnParameter = cmd.Parameters.Add("@new_identity", SqlDbType.Int);
                    returnParameter.Direction = ParameterDirection.ReturnValue;
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    var result = returnParameter.Value;
                    return (int)result;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return 0;
        }
    }
}

