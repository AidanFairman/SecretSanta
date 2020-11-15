using System;
using System.Collections.Generic;

namespace SecretSanta.Games.Data
{
    public class Game
    {
        public long ID { get; set; }
        public List<long> Players { get; set; }
        public long Admin { get; set; }
        public string Name { get; set; }
        public float MaxCost { get; set; }
        public List<Santa> Relations { get; set; }
        public bool InviteOnly { get; set; }
        public bool IsLocked { get; set; }
    }
}