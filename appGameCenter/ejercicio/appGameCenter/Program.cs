using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appGameCenter
{
    class Program
    {
        static void Main(string[] args)
        {
            //    List<Platforms> plat = new List<Platforms>
            //    {
            //       Platforms.PC,
            //       Platforms.XBOXONE

            //    };
            //    List<Score> pepito = new List<Score>(40);
            //    Rankings panks = new Rankings("Pepaso",pepito);
            //    List<Platforms> polt = new List<Platforms>(2 );
            //    Dictionary<Platforms, Rankings> dict = new Dictionary<Platforms, Rankings>();
            //    Player p1 = new Player("Hokeh", "asdads@gmail.com", Countries.Brazil);
            //    Player p2 = new Player("papu", "asdasdasdads@gmail.com", Countries.Japan);
            //    Player p3 = new Player("paasdaspu", "asdas12333dasdads@gmail.com", Countries.Spain);
            //    Game g1 = new Game("Fifa", Genres.Action, 2015, plat, dict);
            //    Game g2 = new Game("Lol", Genres.Strategy, 1999, polt, dict);
            //    Rankings ranking1 = new Rankings("Pechofrio", pepito);
            //    GameServices.Games.Add(g1);
            //    Console.WriteLine(p1);

            GameServices.Pretest();
            GameServices.Switches1();
            GameServices.Switches2();
        }
        // COSAS QUE FALTAN:
        // COMPROBACIONES DEBIDO A QUE NO SABIA COMO AÑADIR A LAS LISTAS Y A LAS COSAS X BLOQUEO Y IMPORTACION Y ENUM TO STRING
    }
}
