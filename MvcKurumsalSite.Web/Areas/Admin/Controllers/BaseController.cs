using MvcKurumsalSite.Infrasturcture;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcKurumsalSite.Web.Areas.Admin.Controllers
{
    public class BaseController : Controller
    {
        public readonly GenericUnitofWork _uow;

        public BaseController()
        {
            _uow = new GenericUnitofWork();
        }
    }
}