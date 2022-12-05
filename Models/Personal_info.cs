using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace TP_3.Models
{
    public class Personal_info
    {
        public static List<Person> GetAllPerson()
        {
            List<Person> people = new List<Person>();

            using (SQLiteConnection con = new SQLiteConnection(@"Data Source = D:\gl3\framework\Project\database.db"))
            {
                try
                {
                    con.Open();
                    SQLiteCommand command = new SQLiteCommand("SELECT * FROM personal_info", con);

                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                int id = (int)reader["id"];
                                string first_name = (string)reader["first_name"];
                                string last_name = (string)reader["last_name"];
                                string email = (string)reader["email"];
                                //string date_birth =(string) reader["date_birth"];
                                string image = (string)reader["image"];
                                string country = (string)reader["country"];
                                people.Add(new Person(id, first_name, last_name, email, image, country));
                            }

                        }
                    }

                }
                catch (Exception ex)
                {
                   Console.WriteLine(ex);
                }
            }
            return people;
        }


        public static Person GetPerson(int id)
        {
            Person person = new Person();
            using (SQLiteConnection con = new SQLiteConnection(@"Data Source = D:\gl3\framework\Project\database.db"))
            {
                try
                {
                    con.Open();
                    SQLiteCommand command = new SQLiteCommand("SELECT * FROM personal_info WHERE id="+id.ToString(), con);

                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                person.id = id;
                                person.first_name = (string)reader["first_name"];
                                person.last_name = (string)reader["last_name"];
                                person.email = (string)reader["email"];
                                //person.date_birth = (string)reader["date_birth"];
                                person.image = (string)reader["image"];
                                person.date_birth = "12/06/1982";
                                person.country = (string)reader["country"];

                            }

                        }
                        else return null;
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
            return person;
        }

        public static int FindPerson(string name, string country)
        {
            int id  = 0;
            using (SQLiteConnection con = new SQLiteConnection(@"Data Source = D:\gl3\framework\Project\database.db"))
            {
                try
                {
                    con.Open();
                    SQLiteCommand command = new SQLiteCommand("SELECT * FROM personal_info WHERE first_name= '" + name + "' and country= '"+country+"'", con);

                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                id = (int)reader["id"];
                            }

                        }
                        else id = -1;
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
                return id;
            }
        }

    }
}
