using MvcKurumsalSite.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcKurumsalSite.Web.Areas.Admin.Controllers
{
    public class SayfalarController : BaseController
    {
        // GET: Admin/Sayfalar
        public ActionResult Index()
        {
            
            return View(_uow.Repository<Sayfa>().GetAll(m=>m.Aktif==true).OrderByDescending(m=>m.Id).ToList());
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Create(Sayfa model)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    _uow.Repository<Sayfa>().Insert(model);
                    _uow.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            catch (Exception)
            {

                return View(model);
            }

            return View(model);
           
        }


        public ActionResult Update(int id)
        {
            return View(_uow.Repository<Sayfa>().GetById(id));
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Update(Sayfa model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _uow.Repository<Sayfa>().Update(model);
                    _uow.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            catch (Exception)
            {

                return View(model);
            }

            return View(model);

        }

        public ActionResult Delete(int id)
        {
            if (id == null)
                HttpNotFound();

           Sayfa model =  _uow.Repository<Sayfa>().GetById(id);
            model.Aktif = false;
            _uow.Repository<Sayfa>().Update(model);
            _uow.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}