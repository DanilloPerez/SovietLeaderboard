using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer
{
    public class ConnectionFactory
    {
        public ISqlConnection SqlConnection()
        {
            return new SqlConnection();
        }
    }
}
