using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Console.Models;

namespace Console.Data
{
    internal static class DbInitializer
    {
        internal static void Initialize(ProgramContext DbContext)
        {
            if (DbContext.interviewers.ToList().Count > 0)
            {
                return;
            }

            var interviewers = new List<Interviewer>
            {
                new Interviewer {FirstName = "Shawn", LastName = "Loren"},
                new Interviewer {FirstName = "Sherlock", LastName = "Holmes"},
                new Interviewer {FirstName = "Klaus", LastName = "Mikaelson"},
                new Interviewer {FirstName = "Marcel", LastName = "Giroud"},
                new Interviewer {FirstName = "Tywin", LastName = "Lanister"},
                new Interviewer {FirstName = "Hayley", LastName = "Marshall"},
                new Interviewer {FirstName = "Ragnar", LastName = "Lothbruk"},
                new Interviewer {FirstName = "Tommy", LastName = "Shelby"},
            };
            DbContext.interviewers.AddRange(interviewers);

            var randTeam = new List<Interviewer>(5);
            for (var i = 0; i < randTeam.Count; ++i)
            {
                randTeam[i] = interviewers[new Random().Next(interviewers.Count)];
            }

            var defaultForm = new ApplicationTemplate
            {
                PersonalInformation = new List<Question>
                {
                    new Q_ShortAnswer { Text = "First Name", Type = (QuestionType)2},
                    new Q_ShortAnswer { Text = "Last Name", Type = (QuestionType)2},
                    new Q_Date { Text = "Date of Birth", Type = (QuestionType)6},
                    new Q_Paragraph { Text = "Tell us about yourself", Type = (QuestionType)1},
                },

                Profile = new List<Question>
                {
                    new Q_Number { Text = "Years of Experience", Type = (QuestionType)7},
                    // new Q_
                },

                AdditionalQuestions = null
            };

            var basicWorkflow = new List<IApplicationStage>
            {
                new ShortlistingStage { StageName = "Applied"},
                new ShortlistingStage { StageName = "Coding Challenge", /* Questions = */},
                new InterviewStage { StageName = "Video Interview"},
                new InterviewStage { StageName = "Physical Interview"},
                new PostingStage { StageName = "Department"}
            };

            var program1 = new _Program
            {
                Title = "First Program",
                Summary = "Noontide mine dwell haply by know in or not his she harolds a venerable within that chill drop and one",
                Description = "Come come né reputiamo quale propria novella da forza cospetto d'angoscia uomini verso in non per in sí allo e giudice lui forse audaci mortali divenuti non sia quale la noi nel 'l esperienza lui quale segreto l'acume sua e che l'uomo quegli degli a alcun quale che e nella",
                RequiredSkills = new List<string> { "php", "c++", "R" },
                Benefits = "Divina lui noi oportune maesta e incominciare forse la avvedimento avvien avvien discerniamo d'esse sue quali fu al coloro da riguardando discenda spezial senza e",
                ApplicationCriteria = "Invidunt facilisis nonumy et voluptua hendrerit aliquyam sed amet duis",
                ProgramType = new List<string> { "internship", "fellowship", "seminar" },
                ProgramStartDate = new DateTime(2023, 7, 1),
                ApplicationOpenDate = DateTime.Now,
                ApplicationCloseDate = new DateTime(2023, 5, 29),
                Duration = "6 months",
                Location = "Veniam duo facilisis voluptua elitr",
                MinimumQualification = new List<string> { "NCE", "OND", "HND", "BSC" },
                ApplicationMaxNum = 20,

                // Secrets: although these are not necessarily secrets in this context but just to make a point in creating _ProgramDTO
                Team = randTeam,
                ApplicationForm = defaultForm,
                ApplicationStages = new Workflow { Stages = basicWorkflow }
            };


            for (var i = 0; i < randTeam.Count; ++i)
            {
                randTeam[i] = interviewers[new Random().Next(interviewers.Count)];
            }

            var program2 = new _Program
            {
                Title = "Second Program",
                Summary = "s a venerable within that chill drop and one",
                Description = "reputiamo quale propria noveetto d'angoscia uomini verso in nonlo e giudice lui forse audaci mortali divenuti non sia quale la noi nel 'l esperienza lui quale segreto l'acume sua e che l'uomo quegli degli a alcun quale che e nella",
                RequiredSkills = new List<string> { "php", "c++", "python", "R" },
                Benefits = "Divina lui noi oportune maesta e incominciare forse la avvedimento avvien avvien discerniamo d'esse sue quali fu al coloro da riguardando discenda spezial senza e",
                ApplicationCriteria = "Invidunt facilisis nonumy et voluptua hendrerit aliquyam sed amet duis",
                ProgramType = new List<string> { "internship", "fellowship", "seminar" },
                ProgramStartDate = new DateTime(2023, 7, 1),
                ApplicationOpenDate = DateTime.Now,
                ApplicationCloseDate = new DateTime(2023, 5, 29),
                Duration = "6 months",
                Location = "Veniam duo facilisis voluptua elitr",
                MinimumQualification = new List<string> { "NCE", "OND", "HND", },
                ApplicationMaxNum = 20,

                // Secrets: although these are not necessarily secrets in this context but just to make a point in creating _ProgramDTO
                Team = randTeam,
                ApplicationForm = defaultForm,
                ApplicationStages = new Workflow { Stages = basicWorkflow }
            };

            DbContext.Programs.Add(program1);
            DbContext.Programs.Add(program2);

            DbContext.SaveChanges();
        }
    }
}
