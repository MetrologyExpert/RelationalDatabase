using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RelationalDatabase.Models
{
    public class InstrumentUncBudgetViewModel
    {
        public int ConId { get; set; }
        public string Sym { get; set; }
        public string QuantityName { get; set; }
        public int Pdf { get; set; }
        public double StdUnc { get; set; }
        public double Sc { get; set; }
        public double StdUncertainty { get; set; }

        public int UbId { get; set; }
        public int InsId { get; set; }

        public string InsName { get; set; }
        public string InsModel { get; set; }
        public string InsManufacturer { get; set; }
        public string InsSpec { get; set; }

        public int Pdf_id { get; set; }
        public string Pdf_Name { get; set; }
    }
}