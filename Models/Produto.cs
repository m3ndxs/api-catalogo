namespace ApiCatalogo.Models;

public class Produto
{
    public int ProdutoId { get; set; }
    public string? NomeProduto { get; set; }
    public string? DescricaoProduto { get; set; }
    public decimal Preco { get; set; }
    public string? ImagemUrl { get; set; }
    public float Estoque { get; set; }
    public DateTime DataCadastro { get; set; }

    //Incluir a propriedade CategoriaId para indicar que é uma chave estrangeira no banco de dados
    //Além disso incluir uma propriedade de navegação Categoria para que um produto está relacionado com uma Categoria 

    public int CategoriaId { get; set; }
    public Categoria? Categoria { get; set; } //Para indicar que cada produto está mapeado a uma categoria
}