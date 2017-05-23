using MvcKurumsalSite.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcKurumsalSite.Web.Controllers
{
    public class HomeController : BaseController
    {
        //_uow base den geliyor.
        // GET: Hom
        public ActionResult Index()
        {
            
            return View(_uow.Repository<Sayfa>().GetAll());
        }
    }
}