using minimal_api.Dominio.Enuns;

namespace minimal_api.Dominio.ModelViews;

public record AdministradorLogado
{
    public string Email { get; set; } = default!;
    public string Perfil { get; set; } = default!;
    public string Token { get; set; } = default!;
    
}