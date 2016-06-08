using System.Collections.Generic;
using System.Data.Entity;

namespace CrudWebForms.Models
{
    public class ProdutoDatabaseInitializer : DropCreateDatabaseIfModelChanges<CrudWebFormsDBContext>
    {
        protected override void Seed(CrudWebFormsDBContext context)
        {
            GetCategorias().ForEach(c => context.Categorias.Add(c));
            GetProdutos().ForEach(p => context.Produtos.Add(p));
            base.Seed(context);
        }

        private static List<Categoria> GetCategorias()
        {
            var categorias = new List<Categoria>
            {
                new Categoria {CategoriaID = 1, NomeCategoria = "Carros" },
                new Categoria {CategoriaID = 2, NomeCategoria = "Aviões"},
                new Categoria {CategoriaID = 3, NomeCategoria = "Caminhões" },
                new Categoria {CategoriaID = 4, NomeCategoria = "Barcos" },
                new Categoria {CategoriaID = 5, NomeCategoria = "Foguetes"}
            };
            return categorias;
        }

        private static List<Produto> GetProdutos()
        {
            var produtos = new List<Produto>
            {
                new Produto
                {
                    ProdutoID = 1, NomeProduto = "Carro Convensível",
                    Descricao = "Este carro convensível é rápido. O Motor é alimentado por uma bateria baseada em neutrino (não incluído)." +
                                "É Ligá-lo e deixá-lo ir!",
                    CaminhoImagem = "carconvert.png", PrecoUnitario = 22.50, CategoriaID = 1
               },
                new Produto
                {
                    ProdutoID = 2, NomeProduto = "Carro Antigo",
                    Descricao = "Não há nada de estranho com este carro de brinquedo, exceto pela aparência compatível com carros antigos.",
                    CaminhoImagem = "carearly.png", PrecoUnitario = 15.95, CategoriaID = 1
               },
                new Produto
                {
                    ProdutoID = 3, NomeProduto = "Carro Rápido",
                    Descricao = "Sim este carrro é rápido, mas também flutua na água.",
                    CaminhoImagem = "carfast.png", PrecoUnitario = 32.99, CategoriaID = 1
                },
                new Produto
                {
                    ProdutoID = 4, NomeProduto = "Carro Super Rápido",
                    Descricao = "Utilize este carro super rápido para entreter os convidados, trabalhe com as luzes e portas.",
                    CaminhoImagem = "carfaster.png", PrecoUnitario = 8.95, CategoriaID = 1
                },
                new Produto
                {
                    ProdutoID = 5, NomeProduto = "Carro de Corrida Estilo Antigo",
                    Descricao = "Esse carro de corrida antigo pode voar (com assistência do usuário). Gravidade controla a duração do voo." +
                                "Não requer baterias.",
                    CaminhoImagem = "carracer.png", PrecoUnitario = 34.95, CategoriaID = 1
                },
                new Produto
                {
                    ProdutoID = 6, NomeProduto = "Ace Plane",
                    Descricao = "Avião de brinquedo autêntico, características cores e detalhes realistas.",
                    CaminhoImagem = "planeace.png", PrecoUnitario = 95.00, CategoriaID = 2
                },
                new Produto
                {
                    ProdutoID = 7, NomeProduto = "Planador",
                    Descricao = "Esse divertido planador é feito a partir de madeira de balsa real. Montagem Obrigatória",
                    CaminhoImagem = "planeglider.png", PrecoUnitario = 4.95, CategoriaID = 2
                },
                new Produto
                {
                    ProdutoID = 8, NomeProduto = "Avião de Papel",
                    Descricao = "Este avião de papel é como nenhum outro avião de papel. Algumas dobragens são necessárias.",
                    CaminhoImagem = "planepaper.png", PrecoUnitario = 2.95, CategoriaID = 2
                },
                new Produto
                {
                    ProdutoID = 9, NomeProduto = "Propeller Plane",
                    Descricao = "Rubber band powered plane features two wheels.",
                    CaminhoImagem = "planeprop.png", PrecoUnitario = 32.95, CategoriaID = 2
                },
                new Produto
                {
                    ProdutoID = 10, NomeProduto = "Early Truck",
                    Descricao = "This toy truck has a real gas powered engine. Requires regular tune ups.",
                    CaminhoImagem = "truckearly.png", PrecoUnitario = 15.00, CategoriaID = 3
                },
                new Produto
                {
                    ProdutoID = 11, NomeProduto = "Fire Truck",
                    Descricao = "You will have endless fun with this one quarter sized fire truck.",
                    CaminhoImagem = "truckfire.png", PrecoUnitario = 26.00, CategoriaID = 3
                },
                new Produto
                {
                    ProdutoID = 12, NomeProduto = "Big Truck",
                    Descricao = "This fun toy truck can be used to tow other trucks that are not as big.",
                    CaminhoImagem = "truckbig.png", PrecoUnitario = 29.00, CategoriaID = 3
                },
                new Produto
                {
                    ProdutoID = 13, NomeProduto = "Big Ship",
                    Descricao = "Is it a boat or a ship. Let this floating vehicle decide by using its " +
                                "artifically intelligent computer brain!",
                    CaminhoImagem = "boatbig.png", PrecoUnitario = 95.00, CategoriaID = 4
                },
                new Produto
                {
                    ProdutoID = 14, NomeProduto = "Paper Boat",
                    Descricao = "Floating fun for all! This toy boat can be assembled in seconds. Floats for minutes!" +
                                "Some folding required.",
                    CaminhoImagem = "boatpaper.png", PrecoUnitario = 4.95, CategoriaID = 4
                },
                new Produto
                {
                    ProdutoID = 15, NomeProduto = "Sail Boat",
                    Descricao = "Put this fun toy sail boat in the water and let it go!",
                    CaminhoImagem = "boatsail.png", PrecoUnitario = 42.95, CategoriaID = 4
                },
                new Produto
                {
                    ProdutoID = 16, NomeProduto = "Rocket",
                    Descricao = "This fun rocket will travel up to a height of 200 feet.",
                    CaminhoImagem = "rocket.png", PrecoUnitario = 122.95, CategoriaID = 5
                }
            };

            return produtos;
        }


    }
}