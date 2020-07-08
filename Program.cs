using System;
using Aula41MVC.Controllers;

namespace Aula41MVC
{
    class Program
    {
        static void Main(string[] args)
        {
            ProdutoController prod = new ProdutoController();
            prod.buscar("200");
        }
    }
}
