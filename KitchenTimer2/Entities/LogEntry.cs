using System;

namespace KitchenTimer.Entities
{
    /// <summary>
    /// LogEntry class to track entries.
    /// </summary>
    public class LogEntry
    {
        /// <summary>
        /// Gets or sets the timestamp of the log entry.
        /// </summary>
        public DateTime? TimeStamp { get; set; }

        /// <summary>
        /// Gets or sets the time difference of the log entry.
        /// </summary>
        public TimeSpan? TimeDiff { get; set; }

        /// <summary>
        /// Gets or sets the note of the log entry.
        /// </summary>
        public string? Note { get; set; }
    }
}
