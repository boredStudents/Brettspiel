using System;
using System.Collections.Generic;
using System.Text;

namespace BrettspielClient
{
    public class LocalPlayer : Player
    {
        public string Guid;

        public LocalPlayer(string name, DateTime bday) : base(name, bday)
        {

        }

        public bool validated => Guid != null;




    }
}
