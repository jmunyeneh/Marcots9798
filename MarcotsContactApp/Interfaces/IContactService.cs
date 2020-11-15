using MarcotsContactApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarcotsContactApp.Interfaces
{
    public interface IContactService
    {
        IList<Person> GetPersonInfo();
        bool IsRecordAvailable { get; set; }
    }
}
