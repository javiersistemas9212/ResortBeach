using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ResortWeb.Models
{
    public class AddUserViewModel : EditUserViewModel
    {
        [Display(Name = "Correo Electronico")]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        [MaxLength(100, ErrorMessage = "El campo {0} no puede tener mas de {1} caracteres.")]
        [EmailAddress]
        public string Username { get; set; }

        [Display(Name = "Password")]
        [Required(ErrorMessage = "El campo {0} es requerido.")]
        [DataType(DataType.Password)]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "El campo {0} no puede tener menos de 6 caracteres.")]
        public string Password { get; set; }

        [Display(Name = "Confirma Password")]
        [Required(ErrorMessage = "El campo {0} es requerido.")]
        [DataType(DataType.Password)]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "El campo {0} no puede tener menos de 6 caracteres.")]
        [Compare("Password")]
        public string PasswordConfirm { get; set; }

       
    }
}
