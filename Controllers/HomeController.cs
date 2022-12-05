using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Data.SQLite;
using System.Diagnostics;

namespace TP_3.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            SQLiteConnection con = new SQLiteConnection(@"Data Source = D:\gl3\framework\Project\database.db");
            try
            {
                con.Open();
                Debug.WriteLine("Connection opened");
                SQLiteCommand command = new SQLiteCommand("SELECT * FROM personal_info", con);

                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    Debug.WriteLine("reader returned " + reader.FieldCount + " columns");

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            int id = (int)reader["id"];
                            string first_name = (string)reader["first_name"];
                            string last_name = (string)reader["last_name"];
                            string email = (string)reader["email"];
                            //string date_birth = (string)reader["date_birth"];
                            //Debug.WriteLine(date_birth);

                            string image = (string)reader["image"];
                            string country = (string)reader["country"];
                            Debug.WriteLine(id.ToString() + " " + first_name + " " + last_name + " " + email + " " + image + " " + country);
                        }

                    }
                    con.Close();
                }


            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            return View();
        }
    }

}