using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Rankings
    {
        string name;
        public string Name { get { return name; } set { name = value; } }

        private List<Score> scores;

        public List<Score> Scores
        {
            get { return scores; }
          
        }
        public override string ToString()
        {
            string s = string.Format("Ranking: {0}\n", Name);
            foreach(Score score in scores)
            {
                s += string.Format("{0}\n", Scores);
              
            }
           
        }

    }

