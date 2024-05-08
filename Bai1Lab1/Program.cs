using System;
public static class UserData
{
    public static string ID;
    public static string UserName;
    public static float Health;
    public static int Point;

    static UserData()
    {
        ID = "2023813";
        UserName = "Le Tai";
        Health = 100f;
        Point = 50;
    }
    public static void Main(string[] args)
    {
        System.Console.WriteLine("ID " + UserData.ID);
        System.Console.WriteLine("Name " + UserData.UserName);
        System.Console.WriteLine("Health " + UserData.Health);
        System.Console.WriteLine("Point " + UserData.Point);

    }

}