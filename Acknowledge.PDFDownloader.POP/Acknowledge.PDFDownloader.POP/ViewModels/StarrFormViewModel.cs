using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Acknowledge.PDFDownloader.POP.Models;

namespace Acknowledge.PDFDownloader.POP.ViewModels
{
    public class StarrFormViewModel
    {
        public string Title { get; set; }
        public string Situation { get; set; }
        public string Task { get; set; }
        public string Action { get; set; }
        public string Result { get; set; }
        public string Reflection { get; set; }
        public string Feeling { get; set; }
        public EHappinessLevel HappyLevel { get; set; }
        public ESkillType SkillType { get; set; }
        public string Skill { get; set; }
        public string FormDateRequested { get; set; }
        public string FormDateCompleted { get; set; }
    }
}
