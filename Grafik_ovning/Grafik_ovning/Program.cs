using Raylib_cs;

Raylib.InitWindow(1920, 1080, "grafiktest");
{
    
}
Raylib.SetTargetFPS(60);


Color hotPink = new Color(255, 105, 180, 255);
Color whitepink = new Color(245, 160, 233, 255);


Texture2D player = Raylib.LoadTexture("F14_1.png");
Texture2D bkg = Raylib.LoadTexture("mil_base.png");
Texture2D bullet = Raylib.LoadTexture("bullet_1.png");

Rectangle playerRect = new Rectangle(400, 300, 64, 64);
Rectangle bulletRect = new Rectangle((int)playerRect.x, (int)playerRect.y, 32, 32);

int speed = 5;
//69
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
    if (Raylib.IsKeyDown(KeyboardKey.KEY_SPACE))
    {
        Raylib.DrawTexture(bullet, (int)bulletRect.x, (int)bulletRect.y, Color.BLANK);
        bulletRect.y += 1;
    }

    Raylib.BeginDrawing();
    Raylib.ClearBackground(hotPink);

    Raylib.DrawTexture(bkg, 0, 0, Color.WHITE);
    Raylib.DrawTexture(player, (int)playerRect.x, (int)playerRect.y, Color.GRAY);
    


    Raylib.EndDrawing();
}



