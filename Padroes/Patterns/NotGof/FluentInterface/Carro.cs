using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Padroes.Patterns.NotGof.FluentInterface
{
    public class Carro
    {
        private Carro()
        {
        }

        public Carro(int id, string cor, string marca, string modelo, string ano, string portas, string ar, string direcao)
        {
            Id = id;
            Cor = cor;
            Marca = marca;
            Modelo = modelo;
            Ano = ano;
            Portas = portas;
            Ar = ar;
            Direcao = direcao;
        }

        public int Id { get; set; }
        public string Cor { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Ano { get; set; }
        public string Portas { get; set; }
        public string Ar { get; set; }
        public string Direcao { get; set; }
    }
}
