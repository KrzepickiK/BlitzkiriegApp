using System;
using System.ComponentModel.DataAnnotations;

namespace BlitzkriegApp.Models
{
    public class WorkModels
    {
        public int ID { get; set; }
        [Display(Name = "Tytuł")]
        public string Title { get; set; }
        [Display(Name = "Opis")]
        public string Details { get; set; }
        [Display(Name = "Data")]
        public DateTime Date { get; set; }
        [Display(Name = "Zakończone")]
        public bool IsDone { get; set; }
    }
}