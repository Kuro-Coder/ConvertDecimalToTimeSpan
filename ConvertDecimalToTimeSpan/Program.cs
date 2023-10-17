// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!. I'm KuroCoder.");

var workTime = TimeSpan.Parse("00:20:00");
Console.WriteLine($"WorkTime is: {workTime}");

decimal repetitions = 220;
Console.WriteLine($"Repetitions Work is: {repetitions}");

var totalWorkTime = workTime.Minutes * repetitions;
Console.WriteLine($"Total Work Time is: {totalWorkTime}");

var totalWorkHours = String.Format("{0:0.00}", (totalWorkTime / 60));
Console.WriteLine($"Total Work Hours is: {totalWorkHours}");

TimeSpan timespan = TimeSpan.FromHours(double.Parse(totalWorkHours));
Console.WriteLine($"timespan is: {timespan}"); //{3.01:19:48} show day(3)

Console.ReadKey();