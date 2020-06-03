namespace EventRest.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    // Her definere vi hvordan vores tabel i databasen skal designes
    [Table("Eventtab")]
    public partial class Eventtab
    {
        [Key]
        public int EventId { get; set; }

        [Required]
        [StringLength(50)]
        public string EventNavn { get; set; }

        [Column(TypeName = "date")]
        public DateTime EventDato { get; set; }

        public TimeSpan EventStart { get; set; }

        public TimeSpan EventSlut { get; set; }

        [Required]
        [StringLength(50)]
        public string EventAddresse { get; set; }

        public int? EventPris { get; set; }

        public int? EventTilmeldte { get; set; }

        [Column(TypeName = "image")]
        public byte[] EventBilled { get; set; }

        [StringLength(50)]
        public string EventBeskrivelse { get; set; }
    }
}
