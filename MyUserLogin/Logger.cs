using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MyUserLogin
{
    static public class Logger
    {
        static private List<string> currentSessionActivities = new List<string>();

        static public void LogActivity(string activity)
        {
            string activityLine = DateTime.Now + ": "
                /*+ LoginValidation.CurrentUserUsername + ";"*/
                /*+ LoginValidation.CurrentUserRole + ";"*/
                + activity + "\n";

            currentSessionActivities.Add(activityLine);

            logToFile(activityLine);
        }

        static private void logToFile(string line)
        {
            if (File.Exists(@"d:\\my documents\visual studio 2017\\Projects\\YS_44_Yasen\\MyUserLogin\test.txt") == true)
            {
                File.AppendAllText(@"d:\\my documents\visual studio 2017\\Projects\\YS_44_Yasen\\MyUserLogin\test.txt", line);
            }
        }

        static public void showLogFile()
        {

            try
            {
                using (StreamReader sr = new StreamReader("test.txt"))
                {
                    string line;
                    
                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
            }
            
        }

        static public string GetCurrentSessionActivities(string filter)
        {
            StringBuilder sb = new StringBuilder();
            List<string> filteredActivities = ( from activity in currentSessionActivities
                                                where (activity.ToLower()).Contains(filter.ToLower())
                                                select activity).ToList();
            foreach (string activity in filteredActivities)
            {
                sb.Append(activity);
            }
            return sb.ToString();
        }
    }
}
