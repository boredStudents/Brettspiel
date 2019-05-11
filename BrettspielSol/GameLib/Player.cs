using System;

namespace GameLib
{
    public class Player
    {
        public Guid ID { get; private set; }
        public string Name { get; private set; }
        public string BirthDate { get; private set; }

        public Tile CurrentPos { get; set; }

        public Player(string name, string birthDate, Tile CurrentPos)
        {
            this.ID = Guid.NewGuid();
            this.Name = name;
            this.BirthDate = birthDate;
            this.CurrentPos = CurrentPos;
        }

        public override string ToString()
        {
            return "ID: " + this.ID + " Name: " + this.Name + " BirthDate: " + this.BirthDate;
        }

    }
}
