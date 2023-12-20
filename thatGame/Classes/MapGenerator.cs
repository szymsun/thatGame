

namespace thatGame.Classes;

public class MapGenerator
{
    public Cell[,] _Cells = new Cell[999,999];
    public int MapSize = 50;
    public void InitMap()
    {
        MapSaver mapSaver = new MapSaver();
        
        for (int x = 0; x < MapSize; x++)
        {
            for (int y = 0; y < MapSize; y++)
            {
                // Create new Cell
                Cell cell = new Cell();
                

                if (x == 0 || x == MapSize - 1 || y == 0 || y == MapSize - 1)
                {
                    //borders
                    cell.ChangeOccupation(true);
                }
                _Cells[x, y] = cell;
                mapSaver.RegisterCell(_Cells[x,y]);
                
            }
            mapSaver._save += "\n";
        }
        Console.WriteLine("Map Initialized. \n");
        
        
        Console.WriteLine(mapSaver._save);
        mapSaver.SaveWorld();
        
        
    }
}