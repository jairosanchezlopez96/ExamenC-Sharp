using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Rankings
    {
        string rankingname;
        public string RankingName { get { return rankingname; } set { rankingname = value; } }

        private List<Score> scores;

        public List<Score> Scores
        {
            get { return scores; }
          
        }

    public Rankings(string rankingname,  List<Score> scores)
    {
       
        RankingName = rankingname;
        this.scores = scores;
    }

    public override string ToString()
        {
            string s = string.Format("Ranking: {0}\n", RankingName);
            foreach(Score score in scores)
            {
                s += string.Format("{0}\n", Scores);
              
            }
        return s;
           
        }

    }

