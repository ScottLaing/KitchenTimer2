using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitchenTimer.Entities
{
    public class LogEntry
    {
        public DateTime? TimeStamp { get; set; }
        public TimeSpan? TimeDiff { get; set; }
        public string? Note { get; set; }
    }
}
