using MvcOurCompanyDAL;
using System.Collections.Generic;
using System.Data;

namespace MvcOurCompanyBLL
{
    public class MvcOurCompanyBLManager
    {
        //create a data access manager
        MvcOurCompanyDAManager daManager = new MvcOurCompanyDAManager();

        public List<User> GetAllUsers()
        {
            DataTable dt = daManager.GetAllUsers();
            List<User> users = new List<User>();

            foreach (DataRow i in dt.Rows)
            {
                User user = new User();

                user.Id = (int)i["Id"];
                user.FirstName = i["FirstName"].ToString();
                user.LastName = i["LastName"].ToString();
                user.UserName = i["UserName"].ToString();
                user.Password = i["Password"].ToString();
                user.Degree = i["Degree"].ToString();

                users.Add(user);
            }

            return users;
        }

        public User GetUserById(int id)
        {
            DataTable dt = daManager.GetUserById(id);
            User user = new User();

            foreach (DataRow i in dt.Rows)
            {                
                user.Id = (int)i["Id"];
                user.FirstName = i["FirstName"].ToString();
                user.LastName = i["LastName"].ToString();
                user.UserName = i["UserName"].ToString();
                user.Password = i["Password"].ToString();
                user.Degree = i["Degree"].ToString();                
            }

            return user;
        }

        public void InsertUser(User user)
        {
            daManager.InsertUser(user.FirstName, user.LastName, user.UserName, 
                user.Password, user.Degree);
        }

        public void UpdateUser(User user)
        {
            daManager.UpdateUser(user.Id, user.FirstName, user.LastName, 
                user.UserName, user.Password, user.Degree);
        }

        public void DeleteUser(int id)
        {
            daManager.DeleteUser(id);
        }

        public List<Order> GetAllOrders()
        {
            DataTable dt = daManager.GetAllOrders();
            List<Order> orders = new List<Order>();

            foreach (DataRow i in dt.Rows)
            {
                Order order = new Order();

                order.Id = (int)i["Id"];
                order.EmployeeName = i["EmployeeName"].ToString();
                order.Product = i["Product"].ToString();
                order.NumberOfUnits = (int)i["NumberOfUnits"];
                order.Company = i["Company"].ToString();
                order.ContactName = i["ContactName"].ToString();
                order.OrderStatus = i["OrderStatus"].ToString();

                orders.Add(order);
            }

            return orders;
        }

        public Order GetOrderById(int id)
        {
            DataTable dt = daManager.GetOrderById(id);
            Order order = new Order();

            foreach (DataRow i in dt.Rows)
            {                
                order.Id = (int)i["Id"];
                order.EmployeeName = i["EmployeeName"].ToString();
                order.Product = i["Product"].ToString();
                order.NumberOfUnits = (int)i["NumberOfUnits"];
                order.Company = i["Company"].ToString();
                order.ContactName = i["ContactName"].ToString();
                order.OrderStatus = i["OrderStatus"].ToString();                
            }

            return order;
        }

        public void InsertOrder(Order order)
        {
            daManager.InsertOrder(order.EmployeeName, order.Product, 
                order.NumberOfUnits, order.Company, order.ContactName, order.OrderStatus);
        }

        public void UpdateOrder(Order order)
        {
            daManager.UpdateOrder(order.Id, order.EmployeeName, order.Product, 
                order.NumberOfUnits, order.Company, order.ContactName, order.OrderStatus);
        }

        public void DeleteOrder(int id)
        {
            daManager.DeleteOrder(id);
        }

        public string CheckLoginInfo(LoginInfo loginInfo)
        {
            return daManager.CheckLoginInfo(loginInfo.UserName, loginInfo.Password);
        }

        public bool UserNameExists(string userName)
        {
            return daManager.UserNameExists(userName);
        }
    }
}
