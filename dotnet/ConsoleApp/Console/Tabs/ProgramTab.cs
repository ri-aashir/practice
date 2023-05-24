using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Console.Models;
using Console.Data;

namespace Console.Tabs
{
    internal class ProgramTab : IDisposable
    {
        internal ProgramContext? DbContext;
        //internal ProgramTab()
        //{
        //    DbContext = null;
        //}
        internal ProgramTab(ProgramContext _DbContext)
        {
            DbContext = _DbContext;
        }


        // GET {Id}
        // internal async Task<_ProgramDTO> Get(int Id)
        internal _ProgramDTO Get(int  Id)
        {
            // _Program _Program = await DbContext.Programs.FindAsync(Id);
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

        // PUT {Id}
        // internal async Task Update(_ProgramDTO _Program)
        internal void Update(_ProgramDTO _Program)
        {
            // _Program Program = await DbContext.Programs.FindAsync(_Program.Id);
            _Program Program = DbContext.Programs.Find(_Program.Id);
            if (Program == null)
            {
                return;
            }

            Program.Id = _Program.Id;
            Program.Title = _Program.Title;
            Program.Summary = _Program.Summary;
            Program.Description = _Program.Description;
            Program.RequiredSkills = _Program.RequiredSkills;
            Program.Benefits = _Program.Benefits;
            Program.ApplicationCriteria = _Program.ApplicationCriteria;
            Program.ProgramType = _Program.ProgramType;
            Program.ProgramStartDate = _Program.ProgramStartDate;
            Program.ApplicationOpenDate = _Program.ApplicationOpenDate;
            Program.ApplicationCloseDate = _Program.ApplicationCloseDate;
            Program.Duration = _Program.Duration;
            Program.Location = _Program.Location;
            Program.MinimumQualification = _Program.MinimumQualification;
            Program.ApplicationMaxNum = _Program.ApplicationMaxNum;

            DbContext.SaveChanges();
        }

        // POST
        internal void Create(_ProgramDTO _Program)
        {
            var Program = new _Program
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
                ApplicationMaxNum = _Program.ApplicationMaxNum,
                // Team = ;
                // ApplicationForm = ;
                // Stage = ;
            };

            DbContext.Programs.Add(Program);
        }

        public void Dispose()
        {
            ((IDisposable)DbContext).Dispose();
        }
    }
}
