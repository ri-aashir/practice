using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console.Models
{
    public interface IApplicationStage
    {
        public string StageName { get; set; }

        public ICollection<Question>? Questions { get; set; }

        // public _Program program { get; set; }
    }






    // Sub classes can be more specifically designed in the future
    internal class ShortlistingStage : IApplicationStage
    {
        public string StageName { get; set; }

        public ICollection<Question>? Questions { get; set; }
    }


    internal class InterviewStage : IApplicationStage
    {
        public string StageName { get; set; }

        public ICollection<Question>? Questions { get; set; }
    }


    internal class PostingStage : IApplicationStage
    {
        public string StageName { get; set; }

        public ICollection<Question>? Questions { get; set; }
    }
}
