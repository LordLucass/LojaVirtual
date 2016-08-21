using LojaRazor_v2.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LojaRazor_v2.Controllers
{
    public class MenuController : Controller
    {
        // GET: Menu
        public ActionResult Index()
        {
            DepartamentosDAO dao = new DepartamentosDAO();
            ViewBag.Departamentos = dao.Lista();
            return View();
        }
    }
}