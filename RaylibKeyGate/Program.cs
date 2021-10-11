using System;
using Raylib_cs;

Raylib.InitWindow(800, 600, "KeyGate");
Raylib.SetTargetFPS(60);

Key key = new Key();
Door door = new Door();
Avatar avatar = new Avatar();

while (!Raylib.WindowShouldClose())
{
    //CREATE INSTANCES

    avatar.player = avatar.PlayerMovement(avatar.player);

    DrawRaylib();
    Raylib.DrawRectangleRec(avatar.player, Color.BLACK);
}



static void DrawRaylib()
{
    Raylib.BeginDrawing();
    Raylib.ClearBackground(Color.WHITE);
    Raylib.EndDrawing();
}