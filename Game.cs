﻿namespace GameLauncher
{
    public class Game
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public string Arguments { get; set; }
        public string ArtworkPath { get; set; }
        public double PlayTime { get; set; }
        public bool IsFavorite { get; set; }

        public Game(
            string name = "",
            string location = "",
            string arguments = "",
            string artworkPath = "",
            double playTime = 0,
            bool isFavorite = false
        )
        {
            Name = name;
            Location = location;
            Arguments = arguments;
            ArtworkPath = artworkPath;
            PlayTime = playTime;
            IsFavorite = isFavorite;
        }
    }
}