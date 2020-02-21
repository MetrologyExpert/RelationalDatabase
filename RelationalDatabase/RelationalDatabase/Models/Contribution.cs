using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RelationalDatabase.Models
{
    public class Contribution
    {
        public int ContributionId { get; set; }
        public string Symbol { get; set; }
        public string Name { get; set; }
        public int IdPdf { get; set; }
        public double StdUncertainty { get; set; }
        public double SensitivityCoefficient { get; set; }
        public double StandardUncertainty { get; set; }

        public int UbId { get; set; }



    }
}