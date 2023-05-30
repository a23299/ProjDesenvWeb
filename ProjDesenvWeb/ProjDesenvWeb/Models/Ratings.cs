namespace ProjDesenvWeb.Models
{
    public class Ratings{

        /// <summary>
        /// Id_rating
        /// </summary>
        public int Id_rating { get; set; }

        /// <summary>
        /// rating
        /// </summary>
        public int Rating { get; set; }

        /// <summary>
        /// Id jogo
        /// </summary>
        public int ID_jogo { get; set; }
        public Jogos jogo { get; set; }

        /// <summary>
        /// Id utilizador
        /// </summary>
        public int ID_Utilizador { get; set; }
        public Utilizador Utilizador { get; set; }

    }
}
