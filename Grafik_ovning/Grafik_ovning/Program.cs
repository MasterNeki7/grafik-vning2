using Raylib_cs;

Raylib.InitWindow(800, 600, "grafiktest");
Raylib.SetTargetFPS(60);

Color hotPink = new Color(255, 105, 180, 255);
Color whitepink = new Color(245, 160, 233, 255);


Texture2D player = Raylib.LoadTexture("F14_1.png");
Texture2D bkg = Raylib.LoadTexture("vietnam.png");

Rectangle playerRect = new Rectangle(400, 300, 64, 64);

int speed = 5;

while (Raylib.WindowShouldClose() == false)
{
    if (Raylib.IsKeyDown(KeyboardKey.KEY_D))
    {
        playerRect.x += speed;
    }
    else if (Raylib.IsKeyDown(KeyboardKey.KEY_A))
    {
        playerRect.x -= speed;
    }
    if (Raylib.IsKeyDown(KeyboardKey.KEY_S))
    {
        playerRect.y += speed;
    }
    else if (Raylib.IsKeyDown(KeyboardKey.KEY_W))
    {
        playerRect.y -= speed;
    }


    Raylib.BeginDrawing();
    Raylib.ClearBackground(hotPink);

    Raylib.DrawTexture(bkg, 0, 0, Color.WHITE);
    Raylib.DrawTexture(player, (int)playerRect.x, (int)playerRect.y, Color.GRAY);



    Raylib.EndDrawing();
}



