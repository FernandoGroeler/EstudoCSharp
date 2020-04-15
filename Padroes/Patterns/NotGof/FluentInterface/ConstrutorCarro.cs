using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Padroes.Patterns.NotGof.FluentInterface
{
    public class ConstrutorCarro
    {
        private int _id;
        private string _cor;
        private string _marca;
        private string _modelo;
        private string _ano;
        private string _portas;
        private string _ar;
        private string _direcao;

        public ConstrutorCarro Id(int id)
        {
            _id = id;
            return this;
        }

        public ConstrutorCarro Cor(string cor)
        {
            _cor = cor;
            return this;
        }

        public ConstrutorCarro Marca(string marca)
        {
            _marca = marca;
            return this;
        }

        public ConstrutorCarro Modelo(string modelo)
        {
            _modelo = modelo;
            return this;
        }

        public ConstrutorCarro Ano(string ano)
        {
            _ano = ano;
            return this;
        }

        public ConstrutorCarro Portas(string portas)
        {
            _portas = portas;
            return this;
        }

        public ConstrutorCarro Ar(string ar)
        {
            _ar = ar;
            return this;
        }

        public ConstrutorCarro Direcao(string direcao)
        {
            _direcao = direcao;
            return this;
        }

        public Carro Construir()
        {
            return new Carro(_id, _cor, _marca, _modelo, _ano, _portas, _ar, _direcao);
        }
    }
}
