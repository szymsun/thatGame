namespace thatGame.Classes;

public class Cell
{
    private bool isOccupied;
    public int[,] CellPosition;
    
    public bool GetOccupation()
    {
        return isOccupied;
    }

    public void ChangeOccupation(bool occupation)
    {
        // validation

        isOccupied = occupation;
    }
}