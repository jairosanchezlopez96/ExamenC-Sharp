using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


static class GameServices
{
    static List<Player> players = new List<Player>() { };
    static public List<Player> Players
    {
        get { return players; }
    }
    static List<Game> games = new List<Game>() { };
    static public List<Game> Games

    {
        get { return games; }
    }
    #region ejercicio2
    public static void Export()
    {
        // Convertir todas las canciones en string con el formato
        string playersData = ConvertPlayersToString();
        // Convertir todas las playlists en string con el formato
        string games1Data = ConvertGames1ToString();
        string games2Data = ConvertGames2ToString();

        // Escribir en el fichero los datos anteriores separados por el patron '*+++*'
        try
        {
            StreamWriter file = File.CreateText("Resources/data.txt");
            string completeData = playersData + "*+*+*+*\n" + games1Data + "*+*+*+\n" + games2Data;

            file.Write(completeData);
            file.Close();
            Console.WriteLine("Datos exportados correctamente");
        }
        catch (Exception e)
        {
            Console.WriteLine("Error al exportar los datos. " + e);
        }
    }



    private static string ConvertPlayersToString()
    {
        string data = "";

        foreach (Player player in Players)
        {
            string playersData = "";

            playersData = string.Format("{0}-{1}-{2}-{3}", player.Nickname, player.Email, player.Country);
            playersData += "\n";
            data += playersData;
        }

        return data;
    }

    private static string ConvertGames1ToString()
    {
        string data = "";

        foreach (Game game in games)
        {
            string games1Data = "";
            games1Data = string.Format("{0}-{1}-{2}", game.Name, game.Genre, game.releaseDate);

            foreach (Platforms platform in game.Platforms)
            {
                string platforms = "";
                platforms = string.Format("{0},", game.Platforms);
                data = games1Data + platforms;
            }


        }
        return data;


    }
    private static string ConvertGames2ToString()
    {
        string data = "";

        foreach (Game game in games)
        {


            string games2data = string.Format("{0}-", game.Name);

            data += games2data;

        }
        foreach (Game game in games)
        {
            foreach (Rankings ranking in game.Ranks.Values)
            {
                string rank = "";
                rank = string.Format("{0}", ranking.RankingName);
                data += rank;

                foreach (Score score in ranking.Scores)
                {
                    string sn = "";
                    sn = string.Format("{0}={1}", score.Nickname, score.Points);
                    data += sn;


                }
            }



        }

        return data;
    }
public static void Import()
    {

    }
    #endregion 

    #region ejercicio 3
    public static Game OldGame()
    {
        Game oldestGame = null;
        int year = int.MaxValue;

        foreach (Game game in games)

        {
            int y = game.ReleaseDate;
            if (year > y)
            {
                oldestGame = game;
                year = y;
            }
        }
        return oldestGame;
    }



    public static int ScoreCount(string nickname)
    {
        int res = 0;
        foreach (Game game in games)
        {
            foreach (Rankings ranking in game.Ranks.Values)
            {


                foreach (Score score in ranking.Scores)
                {
                    if (score.Nickname != nickname)
                    {
                        res++;

                    }

                }
            }


        }
        return res;

    }
    public static int GamesCountByGenre(Genres genre)
    {
        int rex = 0;
        foreach (Game game in games) {
            if (game.Genre == genre) { rex++; }

        }
        return rex;
    }
    public static Game MostScores() {
        Score pip = null;
        Game j = null;
        foreach (Game game in games)
        {
            foreach (Rankings ranking in game.Ranks.Values)
            {
                foreach (Score score in ranking.Scores)
                { if (pip == null) { pip = score;
                        if (score.Points > pip.Points)
                        {
                            j = game;
                            pip = score;
                        }
                    } }
            }

        }
        return j;


    }
    public static bool ContainsCall()
    { bool res = false;
        foreach (Game game in games)
        {
            if (game.Name.Contains("Call"))
            {
                res = true;
            }
            else { res = false; }

        }
        return res;
    }
    public static List<Game> GamesPlayed()
    {
        List<Game> gamesplayed = new List<Game>();
        Game x = null;
        foreach (Player player in players)
        { foreach (Game game in games)
            {
                foreach (Rankings ranking in game.Ranks.Values)
                {
                    foreach (Score score in ranking.Scores)
                    {
                        if (score.Nickname == player.Nickname)
                        {
                            gamesplayed.Add(x);
                        }
                    }
                }
            }

        }
        return gamesplayed;
    }
    public static Dictionary<Player, Game> GamesForEachPlayer()
    {
        Dictionary<Player, Game> g4p = new Dictionary<Player, Game>();
        Game x = null;
        Player y = null;

        foreach (Player player in players)
        {
            foreach (Game game in games)
            {
                foreach (Rankings ranking in game.Ranks.Values)
                { foreach (Score score in ranking.Scores)
                    {
                        if (score.Nickname == player.Nickname)
                        {
                            g4p.Add(y, x);
                        }
                    }

                }
            }
        }
        return g4p;
    }
    #endregion
    #region ejercicio 4
    public static string SC() {
        int c = 0;
        string puntuaciones = "";
        Console.WriteLine("Cual juego :");
        string x = Console.ReadLine();
        foreach (Game game in games)
        {
            foreach (Rankings ranking in game.Ranks.Values)
            {
                foreach (Score scores in ranking.Scores)
                {
                    if (scores.Nickname == x)
                    {
                        c = scores.Points;
                        puntuaciones = c.ToString();
                    }
                }
            }
        }
        return puntuaciones;

    }
    public static string NumGenre()

    {// hay que convertiro de genero a string, no me da tiempo 
        Console.WriteLine("Cual genero :");
        string x = Console.ReadLine();
        foreach (Game game in games)
        {
            //if(// convertir game genre a string y compararlo con el string dado en la consola)
        }
        return x;
    }
    public static string GamesByPlayer()
    {
        Dictionary<Player, Game> g4p = new Dictionary<Player, Game>() { };
        Console.WriteLine("Cual jugador :");
        GameServices.GamesForEachPlayer();
        // Incapaz de formatear el diccionario como sale en el ejercicio
        string s = string.Join(";", g4p.Select(x => x.Key + "=" + x.Value));
        return s;
    }

    public static void Pretest()
    {
        Console.WriteLine("Introduce comando: ");
    }

    public static void Switches1()
    {
        while (true)
        {

            string frase = Console.ReadLine();


            frase = frase.ToLower();
            string comando = frase;

            switch (comando)
            {
                case "import":
                    GameServices.Import();
                    break;
                case "export":
                    GameServices.Export();
                    break;

                default:
                    break;
            }
        }
    }

    public static void Switches2()
    {

        while (true)
        {

            string frase = Console.ReadLine();

            frase = frase.ToLower();

            string[] splitted = frase.Split(' ');
            string comando = splitted[0];
            string valor = "";
            if (splitted.Length > 1)
            {
                valor = splitted[1];
                if (splitted.Length > 2)
                {
                    string valor2 = null;
                    valor2 = splitted[2];
                    valor += valor2 + valor;
                }

            }

            switch (comando)
            {
                case "oldest":
                    GameServices.OldGame();
                    break;
                case "scorecount {gamename} {rankingName}":
                    GameServices.SC();
                    break;
                case "gamescountbygenre{gamename}":

                   // GameServices.Export();
                    break;
                 case "gamesbyplayer":
                    GameServices.GamesByPlayer();
                   break;
                default:
                    break;
            }
        }
    }
}
#endregion





