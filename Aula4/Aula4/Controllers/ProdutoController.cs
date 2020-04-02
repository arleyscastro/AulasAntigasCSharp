using Aula4.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Aula4.Controllers
{
    public class ProdutoController : Controller
    {
        List<ProdutoViewModel> ListaDeProdutos = new List<ProdutoViewModel>();
        private int idgeral;
        public ProdutoController()
        {
            for (int i = 1; i <= 10; i++)
            {
                ListaDeProdutos.Add(new ProdutoViewModel { id  = i, Nome = $"Produto {i}" , Descricao = $"Descrição {i}"} );
            }

            idgeral = 10;
        }

        public ActionResult Index()
        {
            return View(ListaDeProdutos);
        }



        [System.Web.Mvc.HttpGet]
        public ActionResult Criar()
        {
            return View(new ProdutoViewModel());
        }

        [System.Web.Http.HttpPost]
        public ActionResult Criar(ProdutoViewModel produto)
        {
            idgeral++;
            produto.id = idgeral;
            ListaDeProdutos.Add(produto);
            return View(produto);
        }

    }
}
