using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Doceria.Models;
using Doceria.Repositorio;

namespace D.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult Doces()
        {
            var doces = new Doces();
            return View(doces);
        }

        Acoes ac = new Acoes();

        [HttpPost]

        public ActionResult DocesCadastrados(Doces doces)
        {
            ac.CadastrarDoce(doces);
            return View(doces);
        }

        public ActionResult ListarDoces()
        {
            var ExibeDoces = new Acoes();
            var TodosDoces = ExibeDoces.ListarDoces();
            return View(TodosDoces);
        }



        public ActionResult Fornecedor()
        {
            var fornecedor = new Fornecedor();
            return View(fornecedor);
        }

        [HttpPost]

        public ActionResult FornecedorCad(Fornecedor fornecedor)
        {
            ac.CadastrarFornecedor(fornecedor);
            return View(fornecedor);
        }

        public ActionResult FornecedorListar()
        {
            var ExibeForn = new Acoes();
            var TodosForn = ExibeForn.ListarForn();
            return View(TodosForn);
        }
    }
}