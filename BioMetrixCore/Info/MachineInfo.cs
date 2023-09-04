using System;

namespace BioMetrixCore
{
    public class MachineInfo
    {
        public int MachineNumber { get; set; }
        public int IndRegID { get; set; }
        public string DateTimeRecord { get; set; }
        public int DailyRecordCount { get; set; }
        public String DateOnlyRecord
        {
            get { return DateTime.Parse(DateTimeRecord).ToString("MMM/dd/yyyy"); }
        }
        public String TimeOnlyRecord
        {
            get { return DateTime.Parse(DateTimeRecord).ToString("hh:mm:ss tt"); }
        }

        public string Remarks { get; set; }

    }
}
