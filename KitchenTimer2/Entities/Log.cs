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
        /// <summary>
        /// Gets or sets the name of the log.
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// Gets or sets the start time of the log.
        /// </summary>
        public DateTime StartTime { get; set; }

        /// <summary>
        /// Gets or sets the end time of the log.
        /// </summary>
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Gets or sets the list of log entries.
        /// </summary>
        public List<LogEntry>? Entries { get; set; } = new List<LogEntry>();

        /// <summary>
        /// Gets or sets the note for the log.
        /// </summary>
        public string? Note { get; set; }

        /// <summary>
        /// Gets or sets the type of the log.
        /// </summary>
        public LogTypes LogType { get; set; } = LogTypes.Other;
    }
}
