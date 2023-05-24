using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Console.Models
{
    public enum QuestionType {
        Paragraph = 1,
        ShortAnswer,
        YesOrNo,
        DropDown,
        MultipleChoice,
        Date,
        Number,
        FileUpload,
        VideoQuestion
    }



    public class Question
    {
        public QuestionType Type { get; set; }

        public string Text { get; set; }
    }

    //public class Question<T>
    //{
    //    public QuestionType Type { get; set; }

    //    public string Text { get; set; }

    //    public T? Options { get; set; }

    //    public T? Value { get; set; }
    //}





    // Paragraph
    public class Q_Paragraph : Question
    {
        [StringLength(100, MinimumLength = 30)]
        public string Response { get; set; }
    }

    // Short Answer
    public class Q_ShortAnswer : Question
    {
        [StringLength(10, MinimumLength = 3)]
        public string Response { get; set; }
    }

    // Dropdown
    public class Q_Dropdown : Question
    {
        public enum DDOptions { }

        public IEnumerable<DDOptions> Options { get; set; }
        public DDOptions Response { get; set; }
    }

    // Yes or No
    public class Q_YesOrNo : Question
    {
        public enum YN {Yes, No} 
        public YN Response { get; set; }
    }

    // Multiple Choice
    public class Q_MultipleChoice : Question
    {
        public enum MCOptions {  }
        public IEnumerable<MCOptions> Options { get; set; }
        public IEnumerable<MCOptions> Response { get; set; }
    }

    // Date
    public class Q_Date : Question
    {
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime Response { get; set; }
    }

    // Number
    public class Q_Number : Question
    {
        public int Response { get; set; }
    }

    // File Upload
    public class Q_FileUpload : Question
    {
        // public FileUpload Response { get; set; }
    }

    // Video
    public class Q_Video : Question
    {
        // public Video Response { get; set; }
    }
}
