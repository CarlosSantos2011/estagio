using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebLoja2.DAO;
using WebLoja2.Models;

namespace WebLoja2.Controllers
{
    public class PessoaController : Controller
    {
        // GET: Pessoa
        public ActionResult Index()
        {
            PessoaDAO dao = new PessoaDAO();
            IList <Pessoa> pessoas = dao.Lista();
            ViewBag.Pessoa = pessoas;
            return View();
        }
    }
}