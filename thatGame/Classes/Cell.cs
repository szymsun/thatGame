namespace thatGame.Classes;

public struct Cell
{
    private bool isOccupied;
    public int[,] CellPosition;

    public bool GetOccupation()
    {
        return isOccupied;
    }
}