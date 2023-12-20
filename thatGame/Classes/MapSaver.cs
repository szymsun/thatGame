using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace thatGame.Classes;

public class MapSaver
{
    public string _save;

    public void RegisterCell(Cell cell)
    {
        if (cell.GetOccupation() == true)
        {
            _save += "#";
        }
        else
        {
            _save += "*";
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

    public void SaveWorld()
    {
        Directory.CreateDirectory(Environment.SpecialFolder.LocalApplicationData + "/thatThing/saves/");
        var __Save = File.Create(Environment.SpecialFolder.LocalApplicationData+"/thatThing/saves/map.gmp");
        
        byte[] tempInfo = new UTF8Encoding(true).GetBytes(_save);
        
        
        __Save.Write(tempInfo, 0, tempInfo.Length);
        __Save.Close();
        
        Console.WriteLine("Map Saved. \n");
    }

}