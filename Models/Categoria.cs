using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace ApiCatalogo.Models;

public class Categoria
{
    //Como boa prática, inicializar a coleção
    public Categoria()
    {
        Produtos = new Collection<Produto>();
    }

    public int CategoriaId { get; set; }

    [Required]
    [StringLength(80)]
    public string? NomeCategoria { get; set; }

    [Required]
    [StringLength(300)]
    public string? ImagemUrl { get; set; }

    //Propriedade de navegação para indicar que Categoria pode conter uma coleção de Produtos - Relacionamento 1 para Muitos
    //A partir dessa definição a Entity Framework transforma CategoriaId em chave estrangeira para relacionar com a tabela Produtos
    //As propriedades de navegação não são mapeadas no banco
    public ICollection<Produto>? Produtos { get; set; } // Propriedade de navegação
}