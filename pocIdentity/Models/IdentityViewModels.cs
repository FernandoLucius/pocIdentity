using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace pocIdentity.Models
{
    public class RegisterUserViewModel
    {
        [Required(ErrorMessage ="Campo {0} é obrigatório.")]
        [EmailAddress(ErrorMessage =" Email em formato inválido.") ]
        public string Email { get; set; }

        [Required(ErrorMessage = "Campo {0} é obrigatório.")]
        public string Senha { get; set; }

        [Compare("Senha", ErrorMessage = "Senhas divergentes.")]
        public string ConfirmacaoSenha { get; set; }
    }

    public class LoginUserViemModel
    {
        [Required(ErrorMessage = "Campo {0} é obrigatório.")]
        [EmailAddress(ErrorMessage = " Email em formato inválido.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Campo {0} é obrigatório.")]
        public string Senha { get; set; }
    }
}
