using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console.Models
{
    internal class ApplicationTemplate
    {
        // public FileUpload CoverImage { get; set; }

        public ICollection<Question> PersonalInformation { get; set; }

        public ICollection<Question> Profile { get; set; }

        public ICollection<Question>? AdditionalQuestions { get; set; }

        // public _Program program { get; set; }
    }
}
