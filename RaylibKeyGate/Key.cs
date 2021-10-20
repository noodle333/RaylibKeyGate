using System;
using System.Numerics;
using Raylib_cs;

public class Key
{
    private Rectangle keyRec = new Rectangle(500, 300, 32, 32);
    public Door targetDoor;

    public Key(Door target)
    {
        targetDoor = target;
    }

    public void UpdatePosition(Rectangle player)
    {
        keyRec.x = player.x;
        keyRec.y = player.y + 40;

        if (targetDoor.CheckCollision(keyRec))
        {
            targetDoor.isLocked = false;
        }
    }

    public bool CheckCollision(Rectangle other)
    {
        if (Raylib.CheckCollisionRecs(keyRec, other))
        {
            return true;
        }
        return false;
    }
    public void DrawKey()
    {
        Raylib.DrawRectangleRec(keyRec, Color.ORANGE);
    }
}