using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Score
    {
        private string nickname;

        public string  Nickname
        {
            get { return nickname; }
         
        }
        private int points;

        public int Points
        {
            get { if (points > 0) { return points; } else { return 0; } }
            set { if (points > 0) { points = value; } else { points = 0; } }
        }

    public Score(string nickname, int points)
    {
        this.nickname = nickname;
        
        Points = points;
    }

    public override string ToString()
        {
            return string.Format("{0}-{1}", Nickname, Points);
        }

    }

