using System;
using Raylib_cs;

public class Avatar
{
    public Rectangle player = new Rectangle(80, 80, 32, 32);

    public Rectangle PlayerMovement(Rectangle p)
    {
        float speed = 3;

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
        return p;
    }
    public void DrawAvatar()
    {
        Raylib.DrawRectangleRec(player, Color.WHITE);
    }
}
