using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CrudWebForms.Models
{
    public class Categoria
    {
        [Key]
        [ScaffoldColumn(false)]
        public int CategoriaID { get; set; }
        [Required, StringLength(100), Display(Name = "Nome Categoria")]
        public string NomeCategoria { get; set; }
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }
        public virtual ICollection<Produto> Produtos { get; set; }


    }
}