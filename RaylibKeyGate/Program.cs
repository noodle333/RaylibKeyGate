using System;
using Raylib_cs;

Raylib.InitWindow(800, 600, "KeyGate");
Raylib.SetTargetFPS(60);

while (!Raylib.WindowShouldClose())
{
    DrawRaylib();
    // Raylib.DrawRectangleRec(player, Color.BLACK);
}



static void DrawRaylib()
{
    Raylib.BeginDrawing();
    Raylib.ClearBackground(Color.WHITE);
    Raylib.EndDrawing();
}