﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class AddressBookData
    {
       
        public static void Create_Database()
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB; Initial Catalog =master; Integrated Security = True;");
                con.Open();
                SqlCommand cmd = new SqlCommand("Create database AddressbookService;", con);
                cmd.ExecuteNonQuery();
                Console.WriteLine("AddressbookService Database created successfully!");
                con.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("exception occured while creating database:" + e.Message + "\t");
            }
        }
        
        public static void CreateTables()
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB; Initial Catalog =AddressbookService; Integrated Security = True;");
                con.Open();
                SqlCommand cmd = new SqlCommand("Create table AddressBook(id int identity(1,1)primary key,First_Name varchar(200),Last_Name varchar(200),Address varchar(200), City varchar(200), State varchar(200), Zip varchar(200), Phone_Number varchar(50), Email varchar(200)); ", con);
                cmd.ExecuteNonQuery();
                Console.WriteLine("AddressBook table has been  created successfully!");
                con.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("exception occured while creating table:" + e.Message + "\t");
            }
        }
    }
}
