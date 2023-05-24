using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console.Models
{
    internal class Workflow
    {
        internal ICollection<IApplicationStage> Stages { get; set; }
    }
}
