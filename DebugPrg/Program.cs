using SF2022User_NN_Lib;

TimeSpan[] startTime = new TimeSpan[] { new TimeSpan(10, 0, 0), new TimeSpan(11, 0, 0),
               new TimeSpan(15, 0, 0) ,new TimeSpan(15, 30, 0), new TimeSpan(16, 50, 0) };
int[] duration = { 60, 30, 10, 10, 40 };
var actual = Calculations.AvailablePeriods(startTime, duration, 30, new TimeSpan(8, 0, 0), new TimeSpan(18, 0, 0));
        