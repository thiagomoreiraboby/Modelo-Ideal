using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ModeloIdeal.Application.Interface;
using ModeloIdeal.Domain.Entidade;

namespace WebApplication1.Controllers
{
    public class ContContabilController : Controller
    {
        private readonly IContContContabilApplication _contContContabilApplication;

        public ContContabilController(IContContContabilApplication contContContabilApplication)
        {
            _contContContabilApplication = contContContabilApplication;
        }

        // GET: ContContabil
        public ActionResult Index()
        {
            ViewBag.Resultado =
                _contContContabilApplication.IsValid(new ContContabil() {CoCo_Codigo = 10, CoCo_Nome = "thiago"})
                    .ToString();
            return View();
        }

        public ActionResult Index1()
        {
            ViewBag.Resultado =
                _contContContabilApplication.IsValid(new ContContabil() {CoCo_Codigo = 10, CoCo_Nome = ""}).ToString();
            return View();
        }

    }
}