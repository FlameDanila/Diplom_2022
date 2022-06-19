using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using tets_bogdan.Models;
using tets_bogdan.Controllers;

namespace tets_bogdan.Controllers
{
    public class mindController : Controller
    {
        public string Index()
        {
            return "";
        }
        public IActionResult Magic()
        {
            return View();
        }
        public IActionResult Authorize()
        {
            return View();
        }
        public IActionResult DataAggregation(string firtsName, string secondName, string middlename, DateTime date, string mesto, string phone, string email, string docs, string login, string password, string repeatPassword)
        {
            using (RTKDatabaseContext db = new RTKDatabaseContext())
            {
                ViewData["Message"] = "Hello " + firtsName + "," + secondName;

                Participant participant = new Participant();
                    participant.Birthday = date;
                    participant.Mesto = mesto;
                    participant.Email = email;
                    participant.Documents = docs;
                    participant.PhoneNumber = phone;
                    participant.name = firtsName + " " + secondName + " " + middlename;
                    participant.login = login;
                    participant.password = password;

                db.Participants.Add(participant);
                db.SaveChanges();
            }
            return View();
        }
        public IActionResult Authorization(string login, string password)
        {
            using (RTKDatabaseContext db = new RTKDatabaseContext())
            {
                ViewData["Message"] = "Hello " + login;

                var PasswordList = db.Participants.Select(n => n.password).ToList();
                var LoginList = db.Participants.Select(n => n.login).ToList();

                for (int i = 0; i < db.Participants.Count(); i++)
                {
                    if (login == LoginList[i])
                    {
                        if (password == PasswordList[i])
                        {
                            return View();
                            break;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }
            return View();
        }
    }
}
