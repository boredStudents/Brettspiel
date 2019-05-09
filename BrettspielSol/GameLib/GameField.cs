using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Linq;

namespace GameLib
{
    public class GameField
    {
        public List<Tile> Tiles { get; private set; }

        public List<Player> CurrentPlayer { get; private set; }

        public int TileCount { get; private set; }

        public GameField(string TileFileInfo, int TileCount)
        {
            Tiles = new List<Tile>();
            this.TileCount = TileCount;
            for (int i = 0; i < TileCount; i++)
            {
                Tiles.Add(new Tile());
            }
            AddTileInfo(TileFileInfo);
        }

        public void AddPlayer(string name, string dt)
        {
            CurrentPlayer.Add(new Player(name, dt, Tiles[0]));
        }

        public void NextPlayerMove(Guid g)
        {
            var p = CurrentPlayer.Where(x => x.ID.Equals(g)).First();
            int r = Roll();
            if(p.CurrentPos.ID + r > TileCount)
            {
                InstantWin();
            }
            else
            {
                p.CurrentPos = Tiles.Where(x => x.ID == (p.CurrentPos.ID + r)).First();
            }
        }

        public int Roll()
        {
            Dice d1 = new Dice(6), d2 = new Dice(6);

            return d1.Roll() + d2.Roll();
        }

        public void InstantWin()
        {
            throw new NotImplementedException();
        }

        private void AddTileInfo(string path)
        {
            try
            {
                var fieldInfo = File.ReadAllLines(path).Select(x => x.Split(";")).Select(x => (int.Parse(x[0]), x[1], int.Parse(x[2]))).ToList();
                Tiles.ForEach(x =>
                {
                    var f = fieldInfo.Where(i => i.Item1 == x.ID);
                    
                    if (f.Count() > 0)
                    {
                        var fl = f.FirstOrDefault();
                        x.Info = fl.Item2;
                        x.IconText = fl.Item1.ToString();
                        x.Action = fl.Item3;
                    }
                });

            }
            catch(Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Could not read FieldInfoFile.");
                Console.WriteLine(ex.ToString());
                Console.ResetColor();
            }

        }
    }
}
