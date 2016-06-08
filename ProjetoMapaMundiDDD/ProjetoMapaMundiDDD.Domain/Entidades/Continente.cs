using System.Collections.Generic;

namespace ProjetoMapaMundiDDD.Domain.Entidades
{
    public class Continente
    {
        public int ContinenteID { get; set; }
        public string NomeContinente { get; set; }

        public IEnumerable<Pais> Paises { get; set; }
    }
}
