using RelationalDatabase.Models;
using RelationalDatabase.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RelationalDatabase.Controllers
{
    public class UBController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: UB
        public ActionResult Index()
        {

            var uncertaintyList = from co in db.Contributions
                                  join ub in db.UncertaintyBudgets on co.UbId equals ub.IdNumber
                                  join ins in db.Instruments on ub.IdInstrument equals ins.InstrumentId
                                  join p in db.Pdfs on co.IdPdf equals p.PdfId
                                  select new InstrumentUncBudgetViewModel()
                                  {
                                      ConId = co.ContributionId,
                                      QuantityName = co.Name,
                                      Pdf_Name = p.PdfName,
                                      StdUnc = co.StandardUncertainty,
                                      Sc = co.SensitivityCoefficient,
                                      Pdf = p.PdfId,
                                      StdUncertainty = co.StdUncertainty,
                                      UbId = co.UbId,

                                      InsId = ins.InstrumentId,
                                      InsManufacturer = ins.Manufacturer,
                                      InsSpec = ins.Specification,
                                      InsName = ins.InstrumentName


                                  };
               


            return View(uncertaintyList);
        }  
    }
}


