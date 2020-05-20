using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFFApp.model
{
    class Event
    {
        public int EventId { get; set; }

        public string EventNavn { get; set; }

        public DateTime EventDato { get; set; }

        public TimeSpan EventStart { get; set; }

        public TimeSpan EventSlut { get; set; }

        public string EventAddresse { get; set; }

        public int? EventPris { get; set; }

        public int? EventTilmeldte { get; set; }

        public byte[] EventBilled { get; set; }

        public string EventBeskrivelse { get; set; }

        public Event()
        {
        }

        
    }
}
