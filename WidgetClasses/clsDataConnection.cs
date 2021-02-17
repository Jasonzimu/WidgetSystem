using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    class clsDataConnection
    {
        //connection object used to connect to the database
        SqlConnection connectionToDB = new SqlConnection();
        //data adapter used to transfer data to and from the database
        SqlDataAdapter dataChannel = new SqlDataAdapter();
    }
     
}       