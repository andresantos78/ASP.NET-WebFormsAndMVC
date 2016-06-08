using System;
using System.Collections.Generic;

namespace ProjetoMapaMundiDDD.Domain.Entidades
{
    public class Pais
    {
        public int PaisID { get; set; }
        public string NomePais { get; set; }
        public int Populacao { get; set; }
        public int ContinenteID { get; set; }
        public virtual Continente Continente { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }

        public IEnumerable<Estado> Estados { get; set; }

    }
}
