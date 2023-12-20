using System;
using System.Drawing;
using System.IO;
using thatGame.Classes;


namespace thatGame
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            MapGenerator _mapGenerator = new MapGenerator();
            
            _mapGenerator.InitMap();
        }


        
    }
}