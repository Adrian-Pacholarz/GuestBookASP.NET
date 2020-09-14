using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace GuestBookPrework_AdrianPacholarz.Models
{
    public class GuestEntryViewModel
    {
        public string message { get; set; }
        public string name { get; set; }
        public DateTime date { get; set; }

        public GuestEntryViewModel(string message, string name)
        {
            this.message = message;
            this.name = name;
            this.date = DateTime.Now;
        }

        public GuestEntryViewModel(string message, string name, DateTime date)
        {
            this.message = message;
            this.name = name;
            this.date = date;
        }
    }
}
