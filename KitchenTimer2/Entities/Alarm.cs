using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitchenTimer.Entities
{
    public class Alarm
    {
        /// <summary>
        /// Gets or sets the name of the WAV file associated with the alarm.
        /// </summary>
        public string? WavName { get; set; }

        /// <summary>
        /// Gets or sets the title of the alarm.
        /// </summary>
        public string? Title { get; set; }

        /// <summary>
        /// Gets or sets the description of the alarm.
        /// </summary>
        public string? Description { get; set; }
    }
}
