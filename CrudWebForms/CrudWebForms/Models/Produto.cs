using System.ComponentModel.DataAnnotations;

namespace CrudWebForms.Models
{
    public class Produto
    {
        [Key]
        [ScaffoldColumn(false)]
        public int ProdutoID { get; set; }
        [Required, StringLength(100), Display(Name = "Nome Produto")]
        public string NomeProduto { get; set; }
        [Required, StringLength(1000), Display(Name = "Descrição")]
        public string Descricao { get; set; }
        public string CaminhoImagem { get; set; }
        [Display(Name ="Preço Unitário")]
        public double? PrecoUnitario { get; set; }
        public int? CategoriaID { get; set; }
        public virtual Categoria Categoria { get; set; }
    }
}