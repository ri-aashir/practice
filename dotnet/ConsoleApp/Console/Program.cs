using SC = System.Console;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Console.Data;
using Console.Tabs;
using Microsoft.EntityFrameworkCore.Cosmos;
using Microsoft.EntityFrameworkCore;
using Console.Models;
using Console;

// See https://aka.ms/new-console-template for more information
SC.WriteLine("Hello, World!");


var json_config = new ConfigurationBuilder()
                        .AddJsonFile("appsettings.json", false)
                        .Build();

var config = json_config.GetSection("ConnectionStrings").GetRequiredSection("PRogramContext");

var provider = new ServiceCollection()
                    .AddDbContext<ProgramContext>(options => options.UseCosmos(config["EndPoint"], config["Key"], databaseName: config["DbName"]))
                    .BuildServiceProvider();

var _DbContext = provider.GetRequiredService<ProgramContext>();

DbInitializer.Initialize(_DbContext);







SC.WriteLine("All Currently Existing Programs\n");

var ExistingPrograms = _DbContext.Programs.ToList();

foreach (var Program in ExistingPrograms)
{
    int i = 1;
    SC.WriteLine($"{i++}. {Program.Title}");
}


SC.Write("\n\n" + @"
What will you like to do today ??
1. Preview a Program
2. Add a Program
3. Edit a Program

" + "Choice Number: ");

SelectOperation:
int selector = int.Parse(SC.ReadLine());

using (var PFuncs = new ProgramTab(_DbContext))
{
    // var PFuncs = new ProgramTab();
    switch (selector)
    {
        case 1:
            {
                SC.Write("Program Number: ");
                var index = int.Parse(SC.ReadLine());
                UtilityFunctions.PreviewProgram(new PreviewTab(_DbContext).Get(index));
                Next(index);
            }
            break;
            
        case 2:
            {
                SC.Write("Enter Program Name: ");
                string name = SC.ReadLine();

                SC.Write("Enter Program Summary: ");
                string summary = SC.ReadLine();

                SC.Write("Enter Program Description: ");
                string description = SC.ReadLine();

                var program = new _ProgramDTO()
                {
                    Title = name,
                    Summary = summary,
                    Description = description
                };

                PFuncs.Create(program);
            }
            break;

        case 3:
            {
                SC.Write("Program Number: ");
                var index = int.Parse(SC.ReadLine());
                var x = PFuncs.Get(index);
                // Edit properties
                PFuncs.Update(x);
                Next(index);
            }
            break;

        default:
            {
                SC.Write("enter a valid number!");
                goto SelectOperation;
            }
            // break;
    }
}

void Next(int Index)
{


    SC.WriteLine(@"
    Next ...
    1. Checkout Application Form
    2. Examine Program Workflow
    3. Exit

    " + $"Enter Selection: ");

    selector = int.Parse(SC.ReadLine());
    switch (selector)
    {
        case 1:
            var AFfuncs = new ApplicationTab(_DbContext);
            var applicationForm = AFfuncs.Get(Index);
            SC.Write("Edit form template? enter '1'...  ");
            if (SC.ReadLine() == "1")
            {
                // Edit applicationForm properties
                AFfuncs.Update(Index, applicationForm);
            } else
            {
                return;
            }
            break;
        case 2:
            var WFfuncs = new ApplicationTab(_DbContext);
            var wflow = WFfuncs.Get(Index);
            SC.Write("Edit workflow? enter '1'...  ");
            if (SC.ReadLine() == "1")
            {
                // Edit applicationForm properties
                WFfuncs.Update(Index, wflow);
            }
            else
            {
                return;
            }
            break;
        default:
            return;
    }
}

SC.ReadKey();
