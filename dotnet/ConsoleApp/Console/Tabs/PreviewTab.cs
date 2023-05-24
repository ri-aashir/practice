using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Console.Models;
using Console.Data;

namespace Console.Tabs
{
    internal class PreviewTab
    {
        internal ProgramContext DbContext;
        internal PreviewTab(ProgramContext _DbContext)
        {
            DbContext = _DbContext;
        }


        // GET {Id}
        internal _ProgramDTO Get(int Id)
        {
            _Program _Program = DbContext.Programs.Find(Id);

            return new _ProgramDTO
            {
                Id = _Program.Id,
                Title = _Program.Title,
                Summary = _Program.Summary,
                Description = _Program.Description,
                RequiredSkills = _Program.RequiredSkills,
                Benefits = _Program.Benefits,
                ApplicationCriteria = _Program.ApplicationCriteria,
                ProgramType = _Program.ProgramType,
                ProgramStartDate = _Program.ProgramStartDate,
                ApplicationOpenDate = _Program.ApplicationOpenDate,
                ApplicationCloseDate = _Program.ApplicationCloseDate,
                Duration = _Program.Duration,
                Location = _Program.Location,
                MinimumQualification = _Program.MinimumQualification,
                ApplicationMaxNum = _Program.ApplicationMaxNum
            };
        }
    }
}
