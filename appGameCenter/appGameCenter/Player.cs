using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
enum Countries
{
    Spain = 0,
    France = 1,
    USA = 2,
    UK = 3,
    Japan = 4,
    Italy = 5,
    Brazil = 6,
    Germany = 7,
    Australia = 8,
    Canada = 9,

}
class Player
    {
    string nickname;
        public string Nickname { get { return nickname; }  }
     string email;

    public string Email
    {
        get { return email; }
        set { email = value; }
    }

    private Countries  country;

    public Countries Country
    {
        get { return country; }
        set { country = value; }
    }

    public override bool Equals(object o)
    {
        if (o is Player)
        {
            Player aux = (Player)o;
            return nickname == aux.Nickname;
        }
        else
        {
            return false;
        }
    }
    public override string ToString()
    {
        return string.Format("{0}-{1}-{2}", Nickname, Email, Country);
    }


}

