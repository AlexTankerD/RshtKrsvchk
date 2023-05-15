namespace SF2022User_NN_Lib
{
    public static class Calculations
    {
        public static string[] AvailablePeriods(TimeSpan[] startTime, int[] durations, 
            int consultationtime, TimeSpan beginWorkingTime, TimeSpan endWorkingTime)
        {
            TimeSpan time1 = beginWorkingTime;
            TimeSpan time2 = time1;
            int stringorder = 0;
            List<string> periods = new List<string>();

            for(int i = 0; i < startTime.Length && i < durations.Length  ; i++) 
            {
                for (; time1 <= endWorkingTime; time1 += new TimeSpan(0,consultationtime,0))
                {
                    
                    if (time1 >= startTime[i] && time1 <=startTime[i] + new TimeSpan(0, durations[i], 0))
                    {
                        time1 = startTime[i] + new TimeSpan(0, durations[i], 0);
                        break;
                        
                    }
                    periods.Add($"{time1}-{time2 = time1 + new TimeSpan(0, consultationtime, 0)}");
                    stringorder++;
                }

            }
            return periods.ToArray();
        }
    }
}