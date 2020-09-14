using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GuestBookPrework_AdrianPacholarz.Models;
using Microsoft.AspNetCore.Mvc;

namespace GuestBookPrework_AdrianPacholarz.Controllers
{
    public class GuestBookController : Controller
    {
        public static GuestBookViewModel guestBook;

        public IActionResult Index()
        {
            guestBook = GetBookWithEntries();
            return View(guestBook);
        }

        public GuestBookViewModel GetBookWithEntries()
        {
            
            var guestBookwithEntries = new GuestBookViewModel();

            guestBookwithEntries.allEntries.Add(new GuestEntryViewModel("Tu bylem", "Codecooler", new DateTime(2014, 03, 02, 21, 37, 18)));
            guestBookwithEntries.allEntries.Add(new GuestEntryViewModel("Tutaj nie bylem", "Mentor", new DateTime(2018, 01, 23, 13, 15, 37)));

            return guestBookwithEntries;
        }

        [HttpPost]
        public IActionResult Index(string feedback, string name)
        {
            guestBook.allEntries.Add(new GuestEntryViewModel(feedback, name));
            return View(guestBook);
        }
    }
}
