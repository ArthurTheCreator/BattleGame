﻿namespace BattleEntities.Characters
{
    public class Player
    {
        public string Name { get; set; }
        public int Hp { get; set; } = 100;

        public Player(string name) { Name = name; }

        public Player() { }
    }
}
