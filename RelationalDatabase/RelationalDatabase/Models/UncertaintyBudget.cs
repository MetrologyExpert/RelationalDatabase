using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RelationalDatabase.Models
{
    public class UncertaintyBudget
    {
        [Key]
        public int IdNumber { get; set; }

        public int IdInstrument { get; set; }

        ICollection<Contribution>  Contributions { get; set; }


    }
}