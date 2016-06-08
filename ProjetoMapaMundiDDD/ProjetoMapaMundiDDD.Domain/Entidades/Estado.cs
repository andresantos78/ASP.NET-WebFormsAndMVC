using System;
using System.Collections.Generic;

namespace ProjetoMapaMundiDDD.Domain.Entidades
{
    public class Estado
    {
        public int EstadoID { get; set; }
        public string Sigla { get; set; }
        public string NomeEstado { get; set; }
        public DateTime DataCadastro { get; set; }
        public int PaisID { get; set; }
        public virtual Pais Pais { get; set; }

        public IEnumerable<Municipio>  Municipios { get; set; }

    }
}
