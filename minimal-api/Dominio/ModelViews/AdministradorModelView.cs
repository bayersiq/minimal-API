using minimal_api.Dominio.Enuns;

namespace minimal_api.Dominio.ModelViews;

public record AdministradorModelView
{
    public int Id { get; set; }
    public string Email { get; set; } = default!;
        public string Perfil { get; set; } = default!;
    
}