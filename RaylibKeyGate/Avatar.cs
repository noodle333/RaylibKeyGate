using System;
using Raylib_cs;

public class Avatar
{
    public Rectangle player = new Rectangle(80, 80, 32, 32);

    private Key CarriedKey { get; set; }

    public float speed = 5;

    public Rectangle PlayerMovement(Rectangle p)
    {
        if (Raylib.IsKeyDown(KeyboardKey.KEY_A))
        {
            p.x -= speed;
        }
        if (Raylib.IsKeyDown(KeyboardKey.KEY_D))
        {
            p.x += speed;
        }
        if (Raylib.IsKeyDown(KeyboardKey.KEY_W))
        {
            p.y -= speed;
        }
        if (Raylib.IsKeyDown(KeyboardKey.KEY_S))
        {
            p.y += speed;
        }

        if (CarriedKey != null)
        {
            CarriedKey.UpdatePosition(player);
        }
        return p;
    }

    public void CheckKeyCollision(Key key)
    {
        if (key.CheckCollision(player))
        {
            CarriedKey = key;
        }
    }
    public bool CheckDoorCollision(Door door)
    {
        return door.CheckCollision(player);
    }
    public void DrawAvatar()
    {
        Raylib.DrawRectangleRec(player, Color.WHITE);
    }
}
