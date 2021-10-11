using System;
using Raylib_cs;

public class Key
{
    private Rectangle keyRec = new Rectangle(500, 300, 32, 32);
    public string targetDoor;

    public void DrawKey()
    {
        Raylib.DrawRectangleRec(keyRec, Color.ORANGE);
    }
}