using System.ComponentModel.DataAnnotations;

namespace Blazor8.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string? Nome { get; set; }

        [Required(ErrorMessage = "O campo Email é obrigatório.")]
        [EmailAddress(ErrorMessage = "Coloque um Email válido.")]
        public string? Email { get; set; }

        [Required (ErrorMessage = "O campo Senha é obrigatório.")]
        [MinLength(8, ErrorMessage = "A senha tem que ter no mínimo 8 caracteres.")]
        public string? Senha { get; set; }
    }
}
