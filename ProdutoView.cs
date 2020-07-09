using System.Collections.Generic;
using System;
using Aula41MVC.Models;

namespace Aula41MVC.Views
{
    public class ProdutoView
    {

        public void MostrarNoConsole(List<Produto> lista)
        {
            foreach(Produto item in lista){
                System.Console.WriteLine($"R$ {item.Preco} - {item.Nome}");
            }
            
        } 
        
    }
}