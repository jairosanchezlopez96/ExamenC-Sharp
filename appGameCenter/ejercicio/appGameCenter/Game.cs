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

 public enum Platforms
{
    PC = 0,
    MAC = 1,
    Linux = 2,
    PS4 = 3,
    XBOXONE = 4,
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
   


        List<Platforms> platforms = new List<Platforms>() { };
        public List<Platforms> Platforms { get { return platforms; } }

    Dictionary<Platforms, Rankings> ranks;
       
        public Dictionary<Platforms,Rankings> Ranks { get { return ranks; }}// le ponemos el set para darle valores

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

        foreach (Platforms platforms in Ranks.Keys)
        {
            s += string.Format("{0}-", Platforms);
        }
        s += string.Format("{0}", Genre);
        foreach (Rankings ranks in Ranks.Values)
        {
            s += string.Format("Rankings:\n");

        }
       
        s += string.Format("-{0}\n ", Name);

        return s;
    }

    public Game(string name, Genres genre, int releaseDate, List<Platforms> platforms, Dictionary<Platforms,Rankings> ranks)

    {
     
        Name = name;
        Genre = genre;
        this.releaseDate = releaseDate;
        this.ranks = ranks;
    }








   

}



