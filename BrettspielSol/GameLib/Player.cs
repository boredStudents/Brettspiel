using System;

namespace GameLib
{
    public class Player
    {
        public static int IDCounter = 0;

        public int ID { get; set; }
        public string Name { get; set; }
        public string BirthDate { get; set; }

        public Player(int iD, string name, string birthDate)
        {
            this.ID = iD;
            this.Name = name;
            this.BirthDate = birthDate;
        }

        public override string ToString()
        {
            return "ID: " + this.ID + " Name: " + this.Name + " BirthDate: " + this.BirthDate;
        }

    }
}
