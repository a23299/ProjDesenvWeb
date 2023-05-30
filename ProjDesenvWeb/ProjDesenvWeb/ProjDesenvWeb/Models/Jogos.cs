using System.ComponentModel.DataAnnotations;

namespace ProjDesenvWeb.Models
{
    public class Jogos
    {
        /// <summary>
        /// id do jogo
        /// </summary>
        public int Id_jogo { get; set; }

        /// <summary>
        /// nome do jogo
        /// </summary>
        public string Nome { get; set; }

        /// <summary>
        /// data de lancamaneto do jogo
        /// </summary>
        [DataType(DataType.Date)]
        public DateTime DataDelancamento { get; set; }
        
        /// <summary>
        /// género do jogo
        /// </summary>
        public string Genero { get; set; }

        /// <summary>
        /// desenvolvedor do jogo
        /// </summary>
        public string Desenvolvedor { get; set; }


        /// <summary>
        /// plataformas do jogo
        /// </summary>
        public string Plataformas { get; set; }


        /// <summary>
        /// preço do jogo
        /// </summary>
        [DataType(DataType.Currency)]
        public decimal Preco { get; set; }
    } 
}
