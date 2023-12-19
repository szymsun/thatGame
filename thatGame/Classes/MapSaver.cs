namespace thatGame.Classes;

public class MapSaver
{
    
    

    private string _Save;

    public void RegisterCell(Cell cell)
    {
        if (cell.GetOccupation() == true)
        {
            _Save += "#";
        }
    }

    public Cell[] ReadCells(string file)
    {
        Cell[] tempCellArray = new Cell[] { };
        Char[] save = file.ToCharArray();
        for (int i = 0; i < save.Length; i++)
        {
            if (save[i] == '#')
            {
                Cell cell = new Cell();
                cell.ChangeOccupation(true);
                tempCellArray[i] = cell;
            }
        }
        

        return tempCellArray;
    }
    
    
}