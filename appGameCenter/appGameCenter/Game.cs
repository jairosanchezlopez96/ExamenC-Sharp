using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

enum Genres 
{
    Action = 0,
    Strategy = 1, 
    RPG = 2,
    Puzzles = 3,
    Adventure = 4,
    Simulation = 5,
    Survival_Horror = 6,
    Sandbox = 7,
}

    class Game
    {
        string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        Genres genre;

        public Genres Genre
        {
            get { return genre; }
            set { genre = value; }
        }
   public  int releaseDate;
    public int ReleaseDate
    {
        get { if (releaseDate > 1980 && releaseDate < 2017) { return releaseDate; } else { return 0; } }
    }


        List<Platforms> platforms;
        public List<Platforms> Platforms { get { return platforms; } set { platforms = value; } }
        Dictionary<Platforms,Rankings> rankings;
    internal object Platform;

    public Dictionary<Platforms,Rankings> Rankings { get { return rankings; } }

    public override bool Equals(object o)
    {
        if (o is Game)
        {
            Game aux = (Game)o;
            return name == aux.Name;
        }
        else
        {
            return false;
        }
    }
    public override string ToString()

    {
        string s = string.Format("{0}({1}-",Name,ReleaseDate);
        foreach (Platforms platform in platforms)
        {
            s += string.Format("{0},", Platforms);

        }
        s += string.Format("-{0}\n {1}", Genre,Rankings);

        return s;
    }
  
}


