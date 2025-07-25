using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace minimal_api.Dominio.Entidades;

public class Veiculo
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; } = default!;
    [Required]
    [StringLength(150)]
    public string Nome { get; set; } = default!;
    [StringLength(100)]
    [Required]
    public string Marca { get; set; } = default!;
    [Required]
    public int Ano { get; set; } = default!;
}