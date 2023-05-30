using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace ProjDesenvWeb.Models
{
    public class Ratings{

        /// <summary>
        /// id do rating
        /// </summary>
        public int Id_rating { get; set; }

        /// <summary>
        /// rating
        /// </summary>
        [Required]
        public int Rating { get; set; }

        /// <summary>
        /// id do jogo
        /// </summary>
        [Required]
        [ForeignKey(nameof(jogo))]
        [Display(Name = "Jogo")]
        public int Id_jogo { get; set; }
        public Jogos Jogo { get; set; }

        /// <summary>
        /// id do utilizador
        /// </summary>
        [Required]
        [ForeignKey(nameof(Utilizador))]
        [Display(Name = "Utilizador")]
        public int Id_Utilizador { get; set; }
        public Utilizador Utilizador { get; set; }

    }
}
