using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nuget__Serializer_e_Atributos_no_C_.Models
{
    public class Venda
    {
        public Venda(){}

        public Venda(int id, string produto, decimal preco, DateTime dataVenda)
        {
            Id = id;
            Produto = produto;
            Preco = preco;
            DataVenda = dataVenda;
        }
        public int Id { get; set; }
        public string Produto { get; set; }
        public decimal Preco { get; set; }
        public DateTime DataVenda { get; set; }
    }
}