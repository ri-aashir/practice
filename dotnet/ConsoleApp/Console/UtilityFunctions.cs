using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Console.Tabs;
using SC = System.Console;
using Console.Models;

namespace Console
{
    internal static class UtilityFunctions
    {

        internal static string[] Domains = { "com", "net", "ru", "org" };
        internal static string[] SubDomains = { "yahoo", "yandex", "gmail", "outlook", "mail" };



        // int iDomain = new Random().Next(Domains.Length - 1);
        // int iSubDomain = new Random().Next(SubDomains.Length - 1);


        internal static void PreviewProgram(_ProgramDTO program)
        {
            SC.WriteLine($"PROGRAM: \t{program.Title}\n\n" +
                $"SUMMARY:\n{program.Summary}\n\n" +
                $"DESCRIPTION:\n{program.Description}\n\n" +
                $"REQUIRED SKILLS;");

            foreach (string skill in program.RequiredSkills)
            {
                SC.WriteLine($"\t{skill}");
            }

            SC.WriteLine($"\n\nBENEFITS: {program.Benefits}\n" +
                $"APPLICATION CRITERIA: {program.ApplicationCriteria}\n\n" +
                $"PROGRAM TYPE: {program.ProgramType}\n\n" +
                $"STARTS on {program.ProgramStartDate}\n" +
                $"APPLICATION OPENS on {program.ApplicationOpenDate}\n" +
                $"APPLICATION CLOSES on {program.ApplicationCloseDate}\n\n" +
                $"PROGRAM WILL SPAN {program.Duration}\n\n" +
                $"PROGRAM WILL HOLD AT: {program.Location}\n\n" +
                $"MINIMUM QUALIFICATION TO APPLY: {program.MinimumQualification}");

            
        }



        internal static void DisplayForm(ApplicationTemplate Form)
        {
            SC.WriteLine("PERSONAL INFORMATION");
            foreach(var question in Form.PersonalInformation)
            {
                SC.WriteLine(question.Text);
            }

            SC.WriteLine("PROFILE");
            foreach (var question in Form.Profile)
            {
                SC.WriteLine(question.Text);
            }

            SC.WriteLine("ADDITIONAL QUESTIONS");
            foreach (var question in Form.AdditionalQuestions)
            {
                SC.WriteLine(question.Text);
            }
        }



        internal static void DisplayWorkflow(Workflow workflow)
        {
            SC.WriteLine("Stages");
            foreach(var stage in workflow.Stages)
            {
                SC.WriteLine(stage.StageName);
            }
        }
    }
}
