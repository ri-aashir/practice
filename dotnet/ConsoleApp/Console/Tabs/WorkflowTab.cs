using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Console.Models;
using Console.Data;

namespace Console.Tabs
{
    internal class WorkflowTab
    {
        internal ProgramContext DbContext;
        internal WorkflowTab(ProgramContext _DbContext)
        {
            DbContext = _DbContext;
        }


        // GET {Id}
        internal Workflow Get(int Id)
        {
            _Program _Program = DbContext.Programs.Find(Id);
            return _Program.ApplicationStages;
        }

        // PUT {Id}
        internal void Update(int Id, Workflow newStageCollection)
        {
            _Program _Program = DbContext.Programs.Find(Id);
            _Program.ApplicationStages = newStageCollection;

            DbContext.SaveChanges();
        }
    }
}
