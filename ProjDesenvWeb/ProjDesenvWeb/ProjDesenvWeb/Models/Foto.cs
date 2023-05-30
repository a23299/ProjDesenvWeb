using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace ProjDesenvWeb.Models
{
    public class Foto
    {
        /// <summary>
        /// id foto
        /// </summary>
        public int Id_foto { get; set; }

        /// <summary>
        /// id do jogo
        /// </summary>
        [ForeignKey(nameof(jogo))]
        [Display(Name = "jogo")]
        public int Id_jogo { get; set; }
        public Jogos Jogo { get; set; }

        /// <summary>
        /// Nome ficheiro
        /// </summary>
        public string Nomefichéiro { get; set; }

        /// <summary>
        /// titulo da foto
        /// </summary>
        public string Titulo { get; set; }

    }
}