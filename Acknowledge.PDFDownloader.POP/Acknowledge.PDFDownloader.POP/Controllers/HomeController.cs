using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Acknowledge.PDFDownloader.POP.Models;
using Acknowledge.PDFDownloader.POP.ViewModels;
using Rotativa.AspNetCore;

namespace Acknowledge.PDFDownloader.POP.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Download()
        {
            StarrFormViewModel vm = new StarrFormViewModel()
            {
                Title = "De titel van het formulier :P",
                Situation = "Een enorm uitgebreid en gedetaileerd overzicht van willekeurige situaties die je STARR zou moeten helpen aantonen.",
                Task = "De taak die je hebt uitgevoerd die je STARR zou moeten helpen aantonen.",
                Action = "Een handeling(en) die je hebt uitgevoerd om je STARR te proberen aan te tonen.",
                Result = "Het resultaat van de handelingen die je STARR zou moeten aantonen.",
                Reflection = "De terug blik op je process van de gehele situatie.",
                Feeling = "De beschrijving van je gevoel over het process staat hier.",
                HappyLevel = EHappinessLevel.Happy,
                SkillType = ESkillType.Softskill,
                Skill = "Undertale Spelen",
                Softskill = ESoftSkills.Communication,
                FormDateCompleted = DateTime.Now.ToShortDateString(),
                FormDateRequested = DateTime.Now.AddDays(-2.0).ToShortDateString()
            };

            // return View("StarrFormPDF", vm);
            return new ViewAsPdf("StarrFormPDF", vm);
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
