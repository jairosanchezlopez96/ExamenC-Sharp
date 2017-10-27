using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


static class GameServices
{
    static List<Player> players;
    static public List<Player> Players
    {
        get { return players; }
    }
    static List<Game> games;
    static public List<Game> Games
    {
        get { return games; }
    }
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

        foreach (Player player in players)
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
        { string games1Data = "";
            games1Data = string.Format("{0}-{1}-{2}", game.Name, game.Genre, game.releaseDate);
            games1Data += "\n";
            foreach( Game platform in games)
            {
                string platforms = "";
                platforms = string.Format("{0},", game.Platform);
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
            string games2Data = "";
            games2Data = string.Format("{0}-", game.Name, );
            games2Data += "\n";
            foreach (Game ranking in games)
            {
                string platforms = "";
                platforms = string.Format("{0},", game.Rankings);
                data = games2Data + platforms;
            }


        }
        return data;


    }
}

