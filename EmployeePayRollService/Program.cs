using System;

namespace EmployeePay
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome in Employee Payroll Service");
            EmployeePayRoll employeepayroll = new EmployeePayRoll();
            int option = 0;
            do
            {
                Console.WriteLine("1: Establish Connection");
                Console.WriteLine("2: Close Connection");
                Console.WriteLine("3: Add Employee Data");
                Console.WriteLine("0: Exit");
                option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        employeepayroll.EstablishConnection();
                        break;
                    case 2:
                        employeepayroll.CloseConnection();
                        break;
                    case 3:
                        Employee emp = new Employee();
                        Console.WriteLine("Enter The Name");
                        string name = Console.ReadLine();
                        emp.Name = name;
                        Console.WriteLine("Enter a salary");
                        string Salary = Console.ReadLine();
                        emp.Salary = Salary;
                        Console.WriteLine("Enter a Gender");
                        string gender = Console.ReadLine();
                        emp.Gender = gender;
                        Console.WriteLine("Enter Phone number");
                        double Phone = Convert.ToInt64(Console.ReadLine());
                        emp.PhoneNumber = Phone;
                        Console.WriteLine("Enter a Address");
                        string address = Console.ReadLine();
                        emp.Address = address;
                        Console.WriteLine("Enter a Department");
                        string Department = Console.ReadLine();
                        emp.Department = Department;
                        Console.WriteLine(" Emplyoee Join Date");
                        string date = Console.ReadLine();
                        emp.StartDate = Convert.ToDateTime(date);
                       
                        Console.WriteLine("Enter a Basic Pay");
                        double basicpay = Convert.ToInt64(Console.ReadLine());
                        emp.BasicPay = basicpay;
                        Console.WriteLine("Enter a Deduction");
                        int Deduictions = int.Parse(Console.ReadLine());
                        emp.Deduictions = Deduictions;
                        Console.WriteLine("Enter a Taxable Pay");
                        int taxablepay = int.Parse(Console.ReadLine());
                        emp.TaxablePay = taxablepay;
                        Console.WriteLine("Enter a Income Tax");
                        int Incometax = int.Parse(Console.ReadLine());
                        emp.IncomeTax = Incometax;
                        Console.WriteLine("Enter a NetPay");
                        int netpay = int.Parse(Console.ReadLine());
                        emp.NetPay = netpay;
                        employeepayroll.sp_payroll_service(emp);
                        break;
                    case 0:
                        Console.WriteLine("Exit");
                        break;
                    default:
                        Console.WriteLine("Invalid Option:---Please Enter Correct Option");
                        break;
                }
            }
            while (option != 0);
        }
    }
}

