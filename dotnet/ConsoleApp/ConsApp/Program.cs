// See https://aka.ms/new-console-template for more information
using ConsApp;

Console.WriteLine("Hello, World!");

foreach (var item in DailyTemperature.data)
    Console.WriteLine(item);

var heatingDegreeDays = new HeatingDegreeDays(65, DailyTemperature.data);
Console.WriteLine(heatingDegreeDays);
var coolingDegreeDays = new CoolingDegreeDays(65, DailyTemperature.data);
Console.WriteLine(coolingDegreeDays);

// Growing degree days measure warming to determine plant growing rates
var growingDegreeDays = coolingDegreeDays with { BaseTemperature = 41 };
Console.WriteLine(growingDegreeDays);

// showing moving accumulation of 5 days using range syntax
List<CoolingDegreeDays> movingAccumulation = new();
int rangeSize = (DailyTemperature.data.Length > 5) ? 5 : DailyTemperature.data.Length;
for (int start = 0; start < DailyTemperature.data.Length - rangeSize; start++)
{
    var fiveDayTotal = growingDegreeDays with { TempRecords = DailyTemperature.data[start..(start + rangeSize)] };
    movingAccumulation.Add(fiveDayTotal);
}
Console.WriteLine();
Console.WriteLine("Total degree days in the last five days");
foreach (var item in movingAccumulation)
{
    Console.WriteLine(item);
}