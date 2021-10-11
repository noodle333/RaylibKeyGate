using System;
using Raylib_cs;

//INIT RAYLIB
Raylib.InitWindow(800, 600, "KeyGate");
Raylib.SetTargetFPS(60);

//CREATE INSTANCES
Key key = new Key();
Door door = new Door();
Avatar avatar = new Avatar();

while (!Raylib.WindowShouldClose())
{
    //PLAYER MOVEMENT
    avatar.player = avatar.PlayerMovement(avatar.player);

    //DRAW GAME ELEMENTS
    DrawRaylib();
    avatar.DrawAvatar();
    key.DrawKey();
}



static void DrawRaylib()
{
    Raylib.BeginDrawing();
    Raylib.ClearBackground(Color.PURPLE);
    Raylib.EndDrawing();
}