using System;
using System.Collections.Generic;
using System.Linq;

namespace EGZ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ProtocolLine> protocol = new List<ProtocolLine>
            {
                new ProtocolLine() { duration = 10, number = "10", quarter = 1, start = 45 },
                new ProtocolLine() { duration = 10, number = "10", quarter = 2, start = 45 },
                new ProtocolLine() { duration = 12, number = "9", quarter = 1, start = 45 },
                new ProtocolLine() { duration = 9, number = "9", quarter = 2, start = 45 },
                new ProtocolLine() { duration = 2, number = "8", quarter = 1, start = 45 },
                new ProtocolLine() { duration = 2, number = "8", quarter = 2, start = 45 },
                new ProtocolLine() { duration = 15, number = "7", quarter = 1, start = 45 }
            };

            List<Player> players = new List<Player>
            {
                new Player() { number = "10", inches = 7, name = "Jonas", surname = "Jonaitis" },
                new Player() { number = "9", inches = 8, name = "Petras", surname = "Petraitis" },
                new Player() { number = "8", inches = 6, name = "Mantas", surname = "Mantaitis" },
                new Player() { number = "7", inches = 9, name = "Tadas", surname = "Tadaitis" }
            };

            // First LINQ
            int mins = protocol.Where(s => s.number == "10").Sum(s => s.duration);

            // Result: 20

            // Second LINQ
            var results = protocol.Where(x => x.quarter == 1 && x.duration > 5).Select(s => new
            {
                Name = players.First(a => a.number == s.number).name,
                    Surname = players.First(a => a.number == s.number).surname,
                    Number = s.number,
                    Time = s.duration

            }).OrderByDescending(s => s.Time);

            // Results:
            // { Name = Tadas, Surname = Tadaitis, Number = 7, Time = 15 }
            // { Name = Petras, Surname = Petraitis, Number = 9, Time = 12 }
            // { Name = Jonas, Surname = Jonaitis, Number = 10, Time = 10 }
        }
    }
    class Player
    {

        public string number { get; set; }
        public string surname { get; set; }
        public string name { get; set; }
        public int inches { get; set; }
    }
    class ProtocolLine
    {
        public string number { get; set; }
        public int quarter { get; set; }
        public int start { get; set; }
        // time to start playing
        public int duration { get; set; }
        // time of playing
    }
}
