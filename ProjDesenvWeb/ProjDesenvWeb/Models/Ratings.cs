using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace ProjDesenvWeb.Models
{
    public class Ratings{

        /// <summary>
        /// Id_rating
        /// </summary>
        public int id_rating { get; set; }

        /// <summary>
        /// rating
        /// </summary>
        public int Rating { get; set; }

        /// <summary>
        /// Id jogo
        /// </summary>
        [ForeignKey(nameof(jogo))]
        [Display(Name = "Jogo")]
        public int id_jogo { get; set; }
        public Jogos jogo { get; set; }

        /// <summary>
        /// Id utilizador
        /// </summary>
        [ForeignKey(nameof(Utilizador))]
        [Display(Name = "Utilizador")]
        public int id_Utilizador { get; set; }
        public Utilizador Utilizador { get; set; }

    }
}
