using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class MapsLab1
{
    string ID;
    string Name;

    private static string InGame = "Liên Minh Huyền Thoại";
    public MapsLab1(string ID, string Name)
    {
        this.ID = ID;
        this.Name = Name;
        Console.OutputEncoding = Encoding.UTF8;


    }
    public string ShowData()
    {
        return "ID: " +ID + " |Name: " +Name + "InGame " + InGame;
    }


}

