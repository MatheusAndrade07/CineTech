using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineTech
{
    public class Filme
    {
        public string Nome { get; set; }
        public int IdadeMinima { get; set; }
        public int IdadeMaxima { get; set; }

        public Filme(string nome, int idadeMinima, int idadeMaxima)
        {
            Nome = nome;
            IdadeMinima = idadeMinima;
            IdadeMaxima = idadeMaxima;
        }

        public override string ToString()
        {
            return Nome;
        }
    }
}
