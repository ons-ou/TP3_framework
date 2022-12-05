using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TP_3.Models;

namespace TP_3.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult All()
        {
            List<Person> allPeople = Personal_info.GetAllPerson();
            return View(allPeople);
        }

        public ViewResult PersonById(int id)
        {
            Person person = Personal_info.GetPerson(id);

            return View(person);
        }

        [HttpGet]
        public ViewResult Search()
        {
            Debug.WriteLine("this is the get request");
            return View();
        }

        [HttpPost]
        public RedirectToActionResult Search(Person p)
        { 
            int id = Personal_info.FindPerson(p.first_name, p.country);
            Debug.WriteLine(id);
            return RedirectToAction("PersonById", "Person", new { id = id });
        }
    }
}
