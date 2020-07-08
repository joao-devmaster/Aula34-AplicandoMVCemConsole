using System.Collections.Generic;
using System;
using System.IO;
using System.Linq;

namespace Aula41MVC.Models
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public float Preco { get; set; }

        private const string PATH = "Database/Produto.csv";

        public Produto ()
        {

            string pasta = PATH.Split("/")[0];
            if(!Directory.Exists(pasta))
            {
                Directory.CreateDirectory(pasta);
            }

            if(!File.Exists(PATH))
            {
                File.Create(PATH).Close();
            }
        }


        public List<Produto> Ler()
        {
            List<Produto> produtos = new List<Produto>();
            string[] linhas = File.ReadAllLines(PATH);

            foreach(var linha in linhas)
            {
                string[] dados = linha.Split(";");

                Produto tenis = new Produto();
                tenis.Codigo = Int32.Parse( SepararDado(dados[0]));
                tenis.Nome = SepararDado(dados[1]);
                tenis.Preco = float.Parse ( SepararDado(dados[2]));

                produtos.Add(tenis);
            }

            produtos = produtos.OrderBy(z => z.Codigo).ToList();
            return produtos;

            
            }
             private string SepararDado(string txt){
                return txt.Split("=")[1];
        }
    }
}