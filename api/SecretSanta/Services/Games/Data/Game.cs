using System;
using System.Collections.Generic;

namespace SecretSanta.Services.Games
{
    public class Game
    {
        public long ID { get; set; }
        public List<long> Players { get; set; }
        public string Name { get; set; }
        public float MaxCost { get; set; }
        public string Secret { get; set; }
        public List<Santa> Relations { get; set; }
        public bool InviteOnly { get; set; }

    }
}