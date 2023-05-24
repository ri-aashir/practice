using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console.Models
{
    internal class _Program
    {
        public int Id { get; set; } 

        // public int ApplicationTemplateId { get; set; }

        // public int ApplicationStageId { get; set; }

        public string Title { get; set; }

        public string Summary { get; set; }

        public string Description { get; set; }

        // public ICollection<string> RequiredSkills { get; set; }
        public List<string> RequiredSkills { get; set; }

        public string Benefits { get; set; }

        public string ApplicationCriteria { get; set; }

        // public IEnumerable<string> ProgramType { get; set; }
        public List<string> ProgramType { get; set; }

        public DateTime ProgramStartDate { get; set; }

        public DateTime ApplicationOpenDate { get; set; }

        public DateTime ApplicationCloseDate { get; set; }

        public string Duration { get; set; }

        public string Location { get; set; }

        // public ICollection<string> MinimumQualification { get; set; }
        public List<string> MinimumQualification { get; set; }

        public int ApplicationMaxNum { get; set; }

        // Secrets: although these are not necessarily secrets in this context but just to make a point in creating _ProgramDTO
        // public ICollection<Interviewer>? Team { get; set; }
        public List<Interviewer>? Team { get; set; }

        public ApplicationTemplate? ApplicationForm { get; set; }

        public Workflow? ApplicationStages { get; set; }
    }
}
