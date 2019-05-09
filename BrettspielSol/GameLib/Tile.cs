using System;
using System.Collections.Generic;
using System.Text;

namespace GameLib
{
    public class Tile
    {
        private static int IDCounter = 0;

        public int ID { get; set; }
        public string Info { get; set; }
        public int Action { get; set; }
        public string IconText { get; set; }

        public Tile()
        {
            this.ID = IDCounter;
            IDCounter++;
        }

        public Tile(string Info, int Action, string IconText)
        {
            this.ID = IDCounter;
            IDCounter++;
            this.Info = Info;
            this.Action = Action;
            this.IconText = IconText;
        }

    }
}
