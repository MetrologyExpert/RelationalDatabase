using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RelationalDatabase.Models
{
    public class Instrument
    {
        [Key]
        public int InstrumentId { get; set; }
        public string InstrumentName { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public string Specification { get; set; }
    }
}