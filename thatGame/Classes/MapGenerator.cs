namespace thatGame.Classes;

public class MapGenerator
{
    public Cell[,] _Cells;
    public int MapSize = 50;
    public void InitMap()
    {
        for (int x = 0; x < MapSize; x++)
        {
            for (int y = 0; y < MapSize; y++)
            {
                // Create new Cell
                Cell cell = new Cell();
                

                if (x == 0 || x == MapSize - 1 || y == 0 || y == MapSize - 1)
                {
                    
                }
                _Cells[x, y] = cell;
            }
        }
        Console.WriteLine("Map Initialized");
    }
}