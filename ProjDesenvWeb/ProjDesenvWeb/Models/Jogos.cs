using System.ComponentModel.DataAnnotations;

namespace ProjDesenvWeb.Models
{
    public class Jogos{

        /// <summary>
        /// ID_jogo
        /// </summary>
        public int id_jogo { get; set; }

        /// <summary>
        /// nome
        /// </summary>
        public string nome { get; set; }

        /// <summary>
        /// Id_utilizador
        /// </summary>
        public int id_utilizador { get; set; }

        /// <summary>
        /// Data de Lancamaneto
        /// </summary>
        [DataType(DataType.Date)]
        public DateTime DataDelancamento { get; set; }
        
        /// <summary>
        /// Genero
        /// </summary>
        public string Genero { get; set; }

        /// <summary>
        /// Desenvolvedor
        /// </summary>
        public string Desenvolvedor { get; set; }


        /// <summary>
        /// Plataformas
        /// </summary>
        public string Plataformas { get; set; }


        /// <summary>
        /// Preco
        /// </summary>
        [DataType(DataType.Currency)]
        public decimal Preco { get; set; }
    } 
}
