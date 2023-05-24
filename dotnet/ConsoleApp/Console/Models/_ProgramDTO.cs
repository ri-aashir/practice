using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console.Models
{
    internal class _ProgramDTO
    {

        public int Id { get; set; }

        public string Title { get; set; }

        public string Summary { get; set; }

        public string Description { get; set; } = String.Empty;

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
    }
}
