using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace ProjDesenvWeb.Models
{
<<<<<<< HEAD
    public class Utilizador { 
=======
    public class Utilizador
    {
        /// <summary>
        /// id do user
        /// </summary>
        public int ID_Utilizador { get; set; }

        /// <summary>
        /// Nome Completo do user
        /// </summary>
        [Required(ErrorMessage = "O {0} é de preenchimento obrigatório")]
        [Display(Name = "Nome do Utilizador")]
        [StringLength(50)]
        public string userName { get; set; }

        /// <summary>
        /// username do utilizador
        /// </summary>
        [Required(ErrorMessage = "O {0} é de preenchimento obrigatório")]
        [Display(Name = "Nome Completo")]
        [StringLength(50)]
        public string NomeCompleto { get; set; }

        /// <summary>
        /// email do user
        /// </summary>
        [EmailAddress(ErrorMessage = "O {0} não está corretamente escrito")]
        [Required(ErrorMessage = "O {0} é de preenchimento obrigatório")]
        [RegularExpression("[a-z._0-9]+@gmail.com", ErrorMessage = "O {0} tem de ser do GMail")]
        [StringLength(40)]
        public string Email { get; set; }

        /// <summary>
        /// password do user
        /// </summary>
        [Required(ErrorMessage = "O {0} é de preenchimento obrigatório")]
        [StringLength(50)]
        public string password { get; set; }
>>>>>>> 73fe2ad3b4b6d433ac436d5360db5a6dae586574

    }
}
