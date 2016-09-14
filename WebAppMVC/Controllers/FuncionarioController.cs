using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppMVC.Models;

namespace WebAppMVC.Controllers
{
    public class FuncionarioController : Controller
    {
        // GET: Funcionario
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(Funcionario func)
        {
            Repositorio repo = Repositorio.Instance();
            repo.IncluirFuncionario(func);
            return RedirectToAction("Listar");
        }

        public ActionResult Listar()
        {
            IEnumerable<Funcionario> funcs = Repositorio.Instance().listarFuncionarios();
            return View(funcs);
        }

        public ActionResult Editar(int id)
        {
            var func = Repositorio.Instance().listarFuncionario(id);
            return View("Cadastrar", func);
        }

        [HttpPost]
        public ActionResult Editar(Funcionario func)
        {
            Repositorio.Instance().AlterarFuncionario(func);
            return RedirectToAction("Listar");
        }

        [HttpPost]
        public ActionResult Excluir(int id)
        {
            Repositorio repo = Repositorio.Instance();
            repo.ExcluirFuncionario(id);
            return RedirectToAction("Listar");
        }
    }
}