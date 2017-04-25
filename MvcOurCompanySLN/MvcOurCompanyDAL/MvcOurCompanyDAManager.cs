using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace MvcOurCompanyDAL
{
    public class MvcOurCompanyDAManager
    {
        //create a connection
        SqlConnection cn = new SqlConnection(
            ConfigurationManager.ConnectionStrings["mvcConnectionString"].ConnectionString);

        public DataTable GetAllUsers()
        {
            SqlDataAdapter adp = new SqlDataAdapter("spGetAllUsers", cn);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;

            DataTable dt = new DataTable();
            adp.Fill(dt);

            return dt;
        }

        public DataTable GetUserById(int id)
        {
            SqlDataAdapter adp = new SqlDataAdapter("spGetUserById", cn);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;

            SqlParameter parameterId = new SqlParameter()
            {
                ParameterName = "@Id",
                Value = id
            };
            adp.SelectCommand.Parameters.Add(parameterId);

            DataTable dt = new DataTable();
            adp.Fill(dt);

            return dt;
        }

        public void InsertUser(string firstName, string lastName, string userName,
            string password, string degree)
        {
            SqlCommand com = new SqlCommand("spInsertUser", cn);
            com.CommandType = CommandType.StoredProcedure;

            SqlParameter parameterFirstName = new SqlParameter()
            {
                ParameterName = "@FirstName",
                Value = firstName
            };
            com.Parameters.Add(parameterFirstName);

            SqlParameter parameterLastName = new SqlParameter()
            {
                ParameterName = "@LastName",
                Value = lastName
            };
            com.Parameters.Add(parameterLastName);

            SqlParameter parameterUserName = new SqlParameter()
            {
                ParameterName = "@UserName",
                Value = userName
            };
            com.Parameters.Add(parameterUserName);

            SqlParameter parameterPassword = new SqlParameter()
            {
                ParameterName = "@Password",
                Value = password
            };
            com.Parameters.Add(parameterPassword);

            SqlParameter parameterDegree = new SqlParameter()
            {
                ParameterName = "@Degree",
                Value = degree
            };
            com.Parameters.Add(parameterDegree);

            cn.Open();
            com.ExecuteNonQuery();
            cn.Close();
        }

        public void UpdateUser(int id, string firstName, string lastName, 
            string userName, string password, string degree)
        {
            SqlCommand com = new SqlCommand("spUpdateUser", cn);
            com.CommandType = CommandType.StoredProcedure;

            SqlParameter parameterId = new SqlParameter()
            {
                ParameterName = "@Id",
                Value = id
            };
            com.Parameters.Add(parameterId);

            SqlParameter parameterFirstName = new SqlParameter()
            {
                ParameterName = "@FirstName",
                Value = firstName
            };
            com.Parameters.Add(parameterFirstName);

            SqlParameter parameterLastName = new SqlParameter()
            {
                ParameterName = "@LastName",
                Value = lastName
            };
            com.Parameters.Add(parameterLastName);

            SqlParameter parameterUserName = new SqlParameter()
            {
                ParameterName = "@UserName",
                Value = userName
            };
            com.Parameters.Add(parameterUserName);

            SqlParameter parameterPassword = new SqlParameter()
            {
                ParameterName = "@Password",
                Value = password
            };
            com.Parameters.Add(parameterPassword);

            SqlParameter parameterDegree = new SqlParameter()
            {
                ParameterName = "@Degree",
                Value = degree
            };
            com.Parameters.Add(parameterDegree);

            cn.Open();
            com.ExecuteNonQuery();
            cn.Close();
        }

        public void DeleteUser(int id)
        {
            SqlCommand com = new SqlCommand("spDeleteUser", cn);
            com.CommandType = CommandType.StoredProcedure;

            SqlParameter parameterId = new SqlParameter()
            {
                ParameterName = "@Id",
                Value = id
            };
            com.Parameters.Add(parameterId);

            cn.Open();
            com.ExecuteNonQuery();
            cn.Close();
        }

        public DataTable GetAllOrders()
        {
            SqlDataAdapter adp = new SqlDataAdapter("spGetAllOrders", cn);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;

            DataTable dt = new DataTable();
            adp.Fill(dt);

            return dt;
        }

        public DataTable GetOrderById(int id)
        {
            SqlDataAdapter adp = new SqlDataAdapter("spGetOrderById", cn);
            adp.SelectCommand.CommandType = CommandType.StoredProcedure;

            SqlParameter parameterId = new SqlParameter()
            {
                ParameterName = "@Id",
                Value = id
            };
            adp.SelectCommand.Parameters.Add(parameterId);

            DataTable dt = new DataTable();
            adp.Fill(dt);

            return dt;
        }

        public void InsertOrder(string employeeName, string product, int numberOfUnits,
            string company, string contactName, string orderStatus)
        {
            SqlCommand com = new SqlCommand("spInsertOrder", cn);
            com.CommandType = CommandType.StoredProcedure;

            SqlParameter parameterEmployeeName = new SqlParameter()
            {
                ParameterName = "@EmployeeName",
                Value = employeeName
            };
            com.Parameters.Add(parameterEmployeeName);

            SqlParameter parameterProduct = new SqlParameter()
            {
                ParameterName = "@Product",
                Value = product
            };
            com.Parameters.Add(parameterProduct);

            SqlParameter parameterNumberOfUnits = new SqlParameter()
            {
                ParameterName = "@NumberOfUnits",
                Value = numberOfUnits
            };
            com.Parameters.Add(parameterNumberOfUnits);

            SqlParameter parameterCompany = new SqlParameter()
            {
                ParameterName = "@Company",
                Value = company
            };
            com.Parameters.Add(parameterCompany);

            SqlParameter parameterContactName = new SqlParameter()
            {
                ParameterName = "@ContactName",
                Value = contactName
            };
            com.Parameters.Add(parameterContactName);

            SqlParameter parameterOrderStatus = new SqlParameter()
            {
                ParameterName = "@OrderStatus",
                Value = orderStatus
            };
            com.Parameters.Add(parameterOrderStatus);

            cn.Open();
            com.ExecuteNonQuery();
            cn.Close();
        }

        public void UpdateOrder(int id, string employeeName, string product, 
            int numberOfUnits, string company, string contactName, string orderStatus)
        {
            SqlCommand com = new SqlCommand("spUpdateOrder", cn);
            com.CommandType = CommandType.StoredProcedure;

            SqlParameter parameterId = new SqlParameter()
            {
                ParameterName = "@Id",
                Value = id
            };
            com.Parameters.Add(parameterId);

            SqlParameter parameterEmployeeName = new SqlParameter()
            {
                ParameterName = "@EmployeeName",
                Value = employeeName
            };
            com.Parameters.Add(parameterEmployeeName);

            SqlParameter parameterProduct = new SqlParameter()
            {
                ParameterName = "@Product",
                Value = product
            };
            com.Parameters.Add(parameterProduct);

            SqlParameter parameterNumberOfUnits = new SqlParameter()
            {
                ParameterName = "@NumberOfUnits",
                Value = numberOfUnits
            };
            com.Parameters.Add(parameterNumberOfUnits);

            SqlParameter parameterCompany = new SqlParameter()
            {
                ParameterName = "@Company",
                Value = company
            };
            com.Parameters.Add(parameterCompany);

            SqlParameter parameterContactName = new SqlParameter()
            {
                ParameterName = "@ContactName",
                Value = contactName
            };
            com.Parameters.Add(parameterContactName);

            SqlParameter parameterOrderStatus = new SqlParameter()
            {
                ParameterName = "@OrderStatus",
                Value = orderStatus
            };
            com.Parameters.Add(parameterOrderStatus);

            cn.Open();
            com.ExecuteNonQuery();
            cn.Close();
        }

        public void DeleteOrder(int id)
        {
            SqlCommand com = new SqlCommand("spDeleteOrder", cn);
            com.CommandType = CommandType.StoredProcedure;

            SqlParameter parameterId = new SqlParameter()
            {
                ParameterName = "@Id",
                Value = id
            };
            com.Parameters.Add(parameterId);

            cn.Open();
            com.ExecuteNonQuery();
            cn.Close();
        }

        public string CheckLoginInfo(string userName, string password)
        {
            SqlCommand com = new SqlCommand("spCheckLoginInfo", cn);
            com.CommandType = CommandType.StoredProcedure;

            SqlParameter parameterUserName = new SqlParameter()
            {
                ParameterName = "@UserName",
                Value = userName
            };
            com.Parameters.Add(parameterUserName);

            SqlParameter parameterPassword = new SqlParameter()
            {
                ParameterName = "@Password",
                Value = password
            };
            com.Parameters.Add(parameterPassword);

            cn.Open();
            string result = com.ExecuteScalar().ToString();
            cn.Close();

            return result;
        }

        public bool UserNameExists(string userName)
        {
            SqlCommand com = new SqlCommand("spUserNameExists", cn);
            com.CommandType = CommandType.StoredProcedure;

            SqlParameter parameterUserName = new SqlParameter()
            {
                ParameterName = "@UserName",
                Value = userName
            };
            com.Parameters.Add(parameterUserName);

            cn.Open();
            string result = com.ExecuteScalar().ToString();
            cn.Close();

            if (result == "false")
                return false;

            return true;
        }
    }
}
