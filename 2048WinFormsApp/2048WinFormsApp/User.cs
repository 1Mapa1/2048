using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2048ClassLibrary
{
    public class User
    {
        public string NameUser;

        public int Score;

        public User(string NameUser, int Score)
        {
            this.NameUser = NameUser;
            this.Score = Score;
        }

        public User()
        { }
    }
}
