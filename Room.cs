using System.Security.Cryptography.X509Certificates;
using System.Text.Json;

public class Room
{
    protected int _weight;
    protected int _height;
    protected int _xGenPos;
    protected int _yGenPos;
    protected int _roomEvent;
    protected string[][] _roomGraphics;
    protected int[][] _roomObjects;

    public int weight
    {
        get { return _weight; }
        protected set { _weight = value; }
    }
    public int height
    {
        get { return _height; }
        protected set { _height = value; }
    }
    public int xGenPos
    {
        get { return _xGenPos; }
        protected set { _xGenPos = value; }
    }
    public int yGenPos
    {
        get { return _yGenPos; }
        protected set { _yGenPos = value; }
    }
    public int roomEvent
    {
        get { return _roomEvent; }
        protected set { _roomEvent = value; }
    }
    public string[][] roomGraphics
    {
        get { return _roomGraphics; }
        protected set { _roomGraphics = value; }
    }
    public int[][] roomObjects
    {
        get { return _roomObjects; }
        protected set { _roomObjects = value; }
    }
    public static void generateEvent(string[][] Graph, int[][] Objec, int wei, int hei,int roomEvent)
    {
        int idkX = new Random().Next(0, wei);
        int idkY = new Random().Next(0, hei);
        int ok = 0;
        int roomEve;
        if (roomEvent == 0) {roomEve = new Random().Next(3, 7); }
        else {roomEve = roomEvent; }
        while (ok != 1)
        {
            if (Graph[idkY][idkX] == ".")
            {
                if (roomEve == 3) //������
                {
                    Graph[idkY][idkX] = "e";
                    Objec[idkY][idkX] = 3;
                }
                if (roomEve == 4) //������ ��� / �����
                {
                    Graph[idkY][idkX] = "?";
                    Objec[idkY][idkX] = 4;
                }
                if (roomEve == 5) //������
                {
                    Graph[idkY][idkX] = "�";
                    Objec[idkY][idkX] = 5;
                }
                if (roomEve == 6) //�������
                {
                    Graph[idkY][idkX] = "m";
                    Objec[idkY][idkX] = 6;
                }
                if (roomEve == 10) //����
                {
                    Graph[idkY][idkX] = "K";
                    Objec[idkY][idkX] = 10;
                }
                ok = 1;
            }
            idkX = new Random().Next(0, wei);
            idkY = new Random().Next(0, hei);
        }
    }

    public static Room init(string path)
    {
        Stream stream = new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
        string fileText;
        fileText = new StreamReader(stream).ReadToEnd();
        temproom obj = JsonSerializer.Deserialize<temproom>(fileText);
        generateEvent(obj._roomGraphics, obj._roomObjects, obj.weight, obj.height, obj.roomEvent);
        return obj; 
    }
}

public class temproom : Room
{


    public int weight
    {
        get { return _weight; }
        set { _weight = value; }
    }
    public int height
    {
        get { return _height; }
        set { _height = value; }
    }
    public int xGenPos
    {
        get { return _xGenPos; }
        set { _xGenPos = value; }
    }
    public int yGenPos
    {
        get { return _yGenPos; }
        set { _yGenPos = value; }
    }
    public int roomEvent
    {
        get { return _roomEvent; }
        set { _roomEvent = value; }
    }
    public string[][] roomGraphics
    {
        get { return _roomGraphics; }
        set { _roomGraphics = value; }
    }
    public int[][] roomObjects
    {
        get { return _roomObjects; }
        set { _roomObjects = value; }
    }


}




// ������� ��������
// id0  : �����(��� �� ����������)
// id1  : ��� �� �������� ����� ������
// id2  : ������ ��� ������ (���� ��� �� �����������)
// id3  : ���������� ���
// id4  : ������ ��� / �����
// id5  : ������
// id6  : �������
// id10 : ����1!!!!!!!!!!!!
// id82 : �����1
// id83 : �����2
// id84 : �����3
// id85 : �����4
// id86 : �����5
//
//
//