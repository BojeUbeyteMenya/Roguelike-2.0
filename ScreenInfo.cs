﻿

using System.Globalization;

public class ScreenInfo

{
    public const int _SIZE = 10;
    public string[] StringArrayInfo=new string[_SIZE];
    public int count=0;
    public int status;//

    public ScreenInfo(int _status)
    {
        status=_status;//if status == 1 -> it's person info  //  if status == 2 -> it's battle
    }

    public static void ShowLastInfo(ScreenInfo screenInfo) //if status == 1 -> it's person info  //  if status == 2 -> it's battle
    {
        if (screenInfo.status == 1)
        {
            for (int i = 0; i < _SIZE; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.Write("                                                                                                         ");//100 пробелов чтобы очистить предыдущую надпись
                Console.SetCursorPosition(0, i);
                Console.Write(screenInfo.StringArrayInfo[i]);
                screenInfo.StringArrayInfo[i] = "";
            }
        }
        if (screenInfo.status == 2)
        {
            for (int i = 0; i < _SIZE; i++)
            {
                Console.SetCursorPosition(130, i);
                Console.Write("                                                                                                         ");//100 пробелов чтобы очистить предыдущую надпись
                Console.SetCursorPosition(130, i);
                Console.Write(screenInfo.StringArrayInfo[i]);
                screenInfo.StringArrayInfo[i] = ""; //все показанные строки в массиве почистили
            }
        }
        if (screenInfo.status == 3) //Chest Info
        {
            for (int i = 0; i < _SIZE; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.Write("                                                                                                         ");//100 пробелов чтобы очистить предыдущую надпись
                Console.SetCursorPosition(0, i);
                Console.Write(screenInfo.StringArrayInfo[i]);
                screenInfo.StringArrayInfo[i] = "";
            }
        }
        if (screenInfo.status == 4) //Special Skill Info 
        {
            for (int i = 0; i < _SIZE; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.Write("                                                                                                         ");//100 пробелов чтобы очистить предыдущую надпись
                Console.SetCursorPosition(0, i);
                Console.Write(screenInfo.StringArrayInfo[i]);
                screenInfo.StringArrayInfo[i] = "";
            }
        }
        screenInfo.count = 0; // показали и вернулись на первую строку
    }

    public static void AddInfo(string _info, ScreenInfo screenInfo) //if от переполнения
    {   
        if (screenInfo.count < _SIZE) 
        {
            screenInfo.StringArrayInfo[screenInfo.count] = _info;
            screenInfo.count++;
        }
        if (screenInfo.count >= _SIZE)
        {
            screenInfo.count = 0;
            screenInfo.StringArrayInfo[screenInfo.count] = _info;
        }
    }

}
