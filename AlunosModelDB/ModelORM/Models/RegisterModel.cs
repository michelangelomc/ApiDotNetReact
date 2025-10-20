

using System.ComponentModel.DataAnnotations;

namespace ModelORM.Models
{
    public class RegisterModel
    {
        [Required]
        [EmailAddress]
        public string? Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public String? Password { get; set; }

        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "As senhas não conferem")]
        [Display(Name = "Confirnar Senha")]
        public string? ConfirmPassword { get; set; }
    }
}
