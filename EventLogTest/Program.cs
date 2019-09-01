using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventLogTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string today = DateTime.Now.ToShortDateString(); // 2019-09-01
            string logType = "Application";
            string logDate = string.Empty;
            EventLog windowEvent = new EventLog(logType);
            EventLogEntryCollection entries = windowEvent.Entries;
            int index = entries.Count - 1;
            Console.WriteLine(index);
            while (index > 0)
            {
                logDate = entries[index].TimeGenerated.ToShortDateString();
                if (logDate.Equals(today))
                {
                    if(entries[index].EntryType== EventLogEntryType.Error)
                    {
                        Console.WriteLine("EntryType: {0}", entries[index].EntryType);
                        Console.WriteLine("Message: {0}", entries[index].Message);
                        Console.WriteLine("TimeGenerated: {0}", entries[index].TimeGenerated);
                        Console.WriteLine("============================================");
                    }
                }
                else
                {
                    break;
                }
                index--;

            }





        }
    }
}
