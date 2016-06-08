using System;

namespace ProjetoMapaMundiDDD.Domain.Entidades
{
    public class Municipio
    {
        public int MunicipioID { get; set; }
        public string NomeMunicipio { get; set; }
        public int CodigoIBGE { get; set; }
        public int NumeroHabitantes { get; set; }
        public decimal RendaPerCapita { get; set; }
        public DateTime DataCadastro { get; set; }
        public int EstadoID { get; set; }
        public virtual Estado Estado { get; set; }
    }
}
