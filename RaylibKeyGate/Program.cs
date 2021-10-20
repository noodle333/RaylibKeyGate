using System;
using Raylib_cs;

//INIT RAYLIB
Raylib.InitWindow(800, 600, "KeyGate");
Raylib.SetTargetFPS(60);

//CREATE INSTANCES
Door door = new Door(400, 100);
Key key = new Key(door);
Avatar avatar = new Avatar();

//VARIABLES
bool win = false;

while (!Raylib.WindowShouldClose())
{
    //DRAW GAME ELEMENTS
    DrawRaylib();
    avatar.DrawAvatar();
    door.DrawDoor();
    if (door.isLocked)
    {
        key.DrawKey();
    }
    if (!win)
    {
        //PLAYER MOVEMENT
        avatar.player = avatar.PlayerMovement(avatar.player);
        avatar.CheckKeyCollision(key);
        if (avatar.CheckDoorCollision(door) && !door.isLocked)
        {
            win = true;
        }
    }
    else
    {
        Raylib.DrawText("YOU WIN!", 200, 200, 32, Color.GOLD);
    }
}

static void DrawRaylib()
{
    Raylib.BeginDrawing();
    Raylib.ClearBackground(Color.PURPLE);
    Raylib.EndDrawing();
}