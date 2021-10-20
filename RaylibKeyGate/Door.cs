using System;
using Raylib_cs;

public class Door
{
    private Rectangle doorRec = new Rectangle(550, 150, 32, 32);
    public bool isLocked = true;

    public Door(int x, int y)
    {
        doorRec.x = x;
        doorRec.y = y;
    }

    public bool CheckCollision(Rectangle other)
    {
        if (Raylib.CheckCollisionRecs(doorRec, other))
        {
            return true;
        }
        return false;
    }

    public void DrawDoor()
    {
        if (isLocked)
        {
            Raylib.DrawRectangleRec(doorRec, Color.BLACK);
        }
        else
        {
            Raylib.DrawRectangleRec(doorRec, Color.LIME);
        }

    }
}
