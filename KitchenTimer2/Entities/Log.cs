using KitchenTimer2.Enums;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitchenTimer.Entities
{
    public class Log
    {
        public string? Name { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public List<LogEntry>? Entries { get; set; } = new List<LogEntry>();
        public string? Note { get; set; }
        public LogTypes LogType { get; set; } = LogTypes.Other;
    }
}
