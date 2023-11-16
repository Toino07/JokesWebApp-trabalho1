namespace JokesWebApp.Models
{
    public class jokes
    {
        public int id  { get; set; }
        public string autor { get; set; }
        public string jokesPergunta  { get; set; }
        public string JokeResposta { get; set; }

        public jokes()
        {
            id = 0;
            jokesPergunta = string.Empty;
            JokeResposta = string.Empty;
            autor = string.Empty;

        }


    }
}
