using System;
using System.Drawing;
using thatGame.Classes;


namespace thatGame
{
    internal class Program
    {
        private static MapGenerator _mapGenerator = new MapGenerator();
        static void Main(string[] args)
        {
            initializeMap();
        }


        static void initializeMap()
        {
            _mapGenerator.InitMap();
        }
    }
}