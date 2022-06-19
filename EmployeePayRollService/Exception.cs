using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePay
{
    public class EmployeeException : Exception
    {
        public enum ExceptionType
        {
            NO_DATA_FOUND,
            INSERTION_ERROR,
            NO_SUCH_SQL_PROCEDURE,
            CONNECTION_FAILED,
        }
        ExceptionType type;
       
        public EmployeeException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
    }
}

