using Raylib_cs;

Raylib.InitWindow(1920, 1080, "grafiktest");

Raylib.SetTargetFPS(60);

int bkgSpeed = 3;
int bkg1PosY = 0;
int bkg2PosY = -1080;
int speed = 10;
int bulletSpeed = 5;



Texture2D player = Raylib.LoadTexture("F14_1.png");
Texture2D bkg1 = Raylib.LoadTexture("galax 2.png");
Texture2D bkg2 = Raylib.LoadTexture("galax 1.png");
Texture2D bullet = Raylib.LoadTexture("bullet_1.png");

Rectangle playerRect = new Rectangle(960, 540, 64, 64);
Rectangle bulletRect = new Rectangle((int)playerRect.x, (int)playerRect.y, bullet.width, bullet.height);
Rectangle bkg1rect = new Rectangle(0, 0, (int)bkg1.width, (int)bkg1.height);
Rectangle bkg2rect = new Rectangle(0, -1080, (int)bkg2.width, (int)bkg2.height);

float bulletPosX = playerRect.x - bullet.width;
float bulletPosY = playerRect.y;

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

    if (Raylib.IsKeyPressed(KeyboardKey.KEY_SPACE))
    {
        bulletPosX = playerRect.x + bullet.width;
        bulletPosY = playerRect.y;
    }

    if (bkg1PosY > 1080)
    {
        bkg1PosY = -1080;
    }
    if (bkg2PosY > 1080)
    {
        bkg2PosY = -1080;
    }
    if (playerRect.x > 1920 - player.width)
    {
        playerRect.x = 1920 - player.width;
    }
    if (playerRect.x < 0)
    {
        playerRect.x = 0;
    }
    if (playerRect.y > 1080 - player.height)
    {
        playerRect.y = 1080 - player.height;
    }
    if (playerRect.y < 0)
    {
        playerRect.y = 0;
    }


    bulletPosY -= bulletSpeed;

    bkg1PosY += bkgSpeed;

    bkg2PosY += bkgSpeed;

    Raylib.BeginDrawing();
    Raylib.ClearBackground(Color.BLACK);

    Raylib.DrawTexture(bkg1, 0, (int)bkg1PosY, Color.WHITE);
    Raylib.DrawTexture(bkg2, 0, (int)bkg2PosY, Color.WHITE);

    Raylib.DrawTexture(player, (int)playerRect.x, (int)playerRect.y, Color.GRAY);

    Raylib.DrawTexture(bullet, (int)bulletPosX, (int)bulletPosY, Color.RED);


    Raylib.EndDrawing();
}



