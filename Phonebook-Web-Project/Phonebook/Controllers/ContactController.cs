using Microsoft.AspNetCore.Mvc;
using Phonebook.Data;
using Phonebook.Data.Models;
using System.Text.RegularExpressions;

namespace Phonebook.Controllers
{
    public class ContactController : Controller
    {
        [HttpPost]
        public IActionResult Create (Contact contact)
        {
            string namePattern = @"^[A-Z][a-z]+$";
            string phoneNumPattern = @"^\+359[0-9]{9}$";
            Regex nameRegex = new Regex(namePattern);
            Regex phoneRegex = new Regex(phoneNumPattern);

            if (nameRegex.IsMatch(contact.Name) && phoneRegex.IsMatch(contact.Number))
                {
                    DataAccess.Contacts.Add(contact);
                }

            return RedirectToAction("Index", "Home");
        }
    }
}
