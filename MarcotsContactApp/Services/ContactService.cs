using MarcotsContactApp.Data;
using MarcotsContactApp.Interfaces;
using MarcotsContactApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarcotsContactApp.Services
{
    public class ContactService : IContactService
    {
        private readonly ApplicationDbContext db;

        public ContactService(ApplicationDbContext db)
        {
            this.db = db;
        }
        public bool IsRecordAvailable { get; set; } = true;

        public IList<Person> GetPersonInfo()
        {
            DateTime start = DateTime.Now;
            int month = start.Month;
            int day = start.Day;          

             var person =  this.db.Contact.Where(x => x.BirthMonth == month);

            if (person.Any() == true)
            {
                IsRecordAvailable = true;                
            }else
            {
                IsRecordAvailable = false;
            }

            return person.ToList();
        }
    }
}
