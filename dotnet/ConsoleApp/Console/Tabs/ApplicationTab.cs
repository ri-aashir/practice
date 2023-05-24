using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Console.Models;
using Console.Data;

namespace Console.Tabs
{
    internal class ApplicationTab
    {
        internal ProgramContext? DbContext;

        //internal ApplicationTab()
        //{
        //    DbContext = null;
        //}
        internal ApplicationTab(ProgramContext _DbContext)
        {
            DbContext = _DbContext;
        }


        // GET {Id}
        internal ApplicationTemplate Get(int Id)
        {
            _Program _Program = DbContext.Programs.Find(Id);
            return _Program.ApplicationForm;
        }

        // PUT {Id}
        internal void Update(int Id, ApplicationTemplate newForm)
        {
            _Program _Program = DbContext.Programs.Find(Id);
            _Program.ApplicationForm = newForm;

            DbContext.SaveChanges();
        }
    }
}
