using System.Collections.Generic;
using Aula41MVC.Models;
using Aula41MVC.Views;

namespace Aula41MVC.Controllers
{
    public class ProdutoController
    {
        Produto produtomodel = new Produto();
        ProdutoView produtoView = new ProdutoView();

        public void listar()
        {
            List<Produto> lista = produtomodel.Ler();
            produtoView.MostrarNoConsole(lista);
        }

        public void buscar (string termo)
        {
            List<Produto> lista = produtomodel.Ler().FindAll(x => x.Preco == float.Parse(termo));
            produtoView.MostrarNoConsole(lista);
        }
        
    }
}