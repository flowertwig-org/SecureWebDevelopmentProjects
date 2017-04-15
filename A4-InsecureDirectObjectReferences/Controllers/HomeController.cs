using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using A4_InsecureDirectObjectReferences.Models;
using Microsoft.AspNet.Identity;

namespace A4_InsecureDirectObjectReferences.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Messages()
        {
            ViewBag.Message = "Your messages page.";

            var list = new List<Message>();

            var connectionString =
                @"Data Source=(LocalDb)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\aspnet-A4-InsecureDirectObjectReferences-20170401043044.mdf;Initial Catalog=aspnet-A4-InsecureDirectObjectReferences-20170401043044;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand("select * from Messages where UserId = @User ORDER BY Id desc", connection))
            {
                command.Parameters.Add(new SqlParameter { ParameterName = "User", Value = User.Identity.Name });

                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Message
                        {
                            Id = reader["Id"].ToString().Trim(),
                            Subject = reader["Subject"].ToString().Trim(),
                            To = reader["UserId"].ToString().Trim(),
                            From = reader["FromUserId"].ToString().Trim()
                        });
                    }
                }
            }
            return View(list);
        }
    }
}