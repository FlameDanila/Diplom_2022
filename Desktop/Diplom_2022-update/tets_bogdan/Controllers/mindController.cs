using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using tets_bogdan.Models;
using tets_bogdan.Controllers;
using Microsoft.AspNetCore.Identity;

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
        public IActionResult BlockViewer(string name, string chalangesScore, string laddersScore, string questionsScore, string towerScore, string penaltyScore, string team)
        {
            using (RTKDatabaseContext db = new RTKDatabaseContext())
            {
                ScoreTable team1 = new ScoreTable();
                team1.PenaltyScore = Convert.ToInt32(penaltyScore);
                team1.QuestionsScore = Convert.ToInt32(questionsScore);
                team1.LaddersScore = Convert.ToInt32(laddersScore);
                team1.PenaltyScore = Convert.ToInt32(penaltyScore);
                team1.ChalangesScore = Convert.ToInt32(chalangesScore);
                team1.TeamId = 1;

                db.ScoreTables.Add(team1);
                db.SaveChanges();
            }
            return View();
        }
        public IActionResult BlockView()
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
                    participant.Name = firtsName + " " + secondName + " " + middlename;
                    participant.Login = login;
                    participant.Password = password;

                db.Participants.Add(participant);
                db.SaveChanges();
            }
            return View();
        }
        async public Task<IActionResult> Authorization(string login, string password)
        {
            try
            {
                using (RTKDatabaseContext db = new RTKDatabaseContext())
                {
                    ViewData["Message"] = "Hello " + login;

                    var PasswordList = db.Participants.Select(n => n.Password).ToList();
                    var LoginList = db.Participants.Select(n => n.Login).ToList();

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
            }
            catch(Exception ex)
            { }
            return View();
        }
    }
}
