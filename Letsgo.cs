using System.ComponentModel.DataAnnotations.Schema;

namespace Letsgo.Model
{
    [Table("viagens")]
    public class LetsTodos{

    [Column("id")]
    public int Id { get; set; }
    
    [Column("lets_name")]
    public string Name { get; set; } = string.Empty;

    [Column("lets_genre")]
    public string Genre { get; set; } = string.Empty;

    [Column("lets_url")]
    public string letsURL { get; set; } = string.Empty;

    [Column("lets_preco")]
    public decimal Price { get; set; }
    
    [Column("lets_descricao")]
    public string Descricao { get; set; } = string.Empty;

    }
    
}