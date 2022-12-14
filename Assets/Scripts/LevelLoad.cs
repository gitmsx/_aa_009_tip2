using System;
using System.IO;


public class LevelLoad 
{

    private static LevelLoad _levelLoad_instance;


    public static string[] ReadData(int Level,int Part)
    {
        string[] lines0 = new string[0];
        string path = "Assets/Resources/level1.txt";

        if (!File.Exists(path))
        {

            return lines0;
        }
        try
        {
            return System.IO.File.ReadAllLines(path); 

        }
        catch (Exception e)
        {
            Console.WriteLine("The file could not be read:");
            Console.WriteLine(e.Message);
        }
        return lines0;
    }


}
