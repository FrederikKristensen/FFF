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

        public TimeSpan? EventTid { get; set; }

        public DateTime? EventDato { get; set; }

        public string EventAdresse { get; set; }

        public int? EventPostnummer { get; set; }

        public Event()
        {
        }

        public Event(int eventId, string eventNavn, TimeSpan? eventTid, DateTime? eventDato, string eventAdresse, int? eventPostnummer)
        {
            EventId = eventId;
            EventNavn = eventNavn;
            EventTid = eventTid;
            EventDato = eventDato;
            EventAdresse = eventAdresse;
            EventPostnummer = eventPostnummer;
        }

        public override string ToString()
        {
            return $"{nameof(EventId)}: {EventId}, {nameof(EventNavn)}: {EventNavn}, {nameof(EventTid)}: {EventTid}, {nameof(EventDato)}: {EventDato}, {nameof(EventAdresse)}: {EventAdresse}, {nameof(EventPostnummer)}: {EventPostnummer}";
        }
    }
}
