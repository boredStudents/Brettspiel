using System;
using System.Collections.Generic;
using System.Text;

namespace BrettspielClient
{
    public class Player
    {
        public string Name;
        public DateTime BirthDay;

        public Player(string name, DateTime birthDay)
        {
            Name = name;
            BirthDay = birthDay;
        }
        public Player()
        {

        }
    }
}
