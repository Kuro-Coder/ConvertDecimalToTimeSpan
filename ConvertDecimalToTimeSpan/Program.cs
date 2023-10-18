// See https://aka.ms/new-console-template for more information
using System;

Console.WriteLine("Hello, World!. I'm KuroCoder.");

var workTime = TimeSpan.Parse("00:20:00");
Console.WriteLine($"WorkTime is: {workTime}"); // 00:20:00

decimal repetitions = 220;
Console.WriteLine($"Repetitions Work is: {repetitions}"); // 220

var totalWorkTime = workTime.Minutes * repetitions;
Console.WriteLine($"Total Work Time is: {totalWorkTime}"); // 4400

var totalWorkHours = String.Format("{0:0.00}", (totalWorkTime / 60));
Console.WriteLine($"Total Work Hours is: {totalWorkHours}"); // 73/33

//===========================================================

//TimeSpan timespan = TimeSpan.FromHours(double.Parse(totalWorkHours));
//Console.WriteLine($"timespan is: {timespan}"); //{3.01:19:48} show with day(3)

//=========================================================== 

//TimeSpan timespan = TimeSpan.FromHours(double.Parse(totalWorkHours));
//var totalWorkedTime = string.Format("{0}:{1}:{2}", timespan.Days * 24 + timespan.Hours, timespan.Minutes, timespan.Seconds);
//Console.WriteLine($"timespan is: {totalWorkedTime}"); // 73:19:48

//=========================================================== 

var time = "73:54";
var date = new TimeSpan(int.Parse(time.Split(':')[0]),    // hours
                           int.Parse(time.Split(':')[1]),    // minutes
                           0);
Console.WriteLine($"timespan is: {date}"); // 73:54 => 3.01:54:00

Console.ReadKey();