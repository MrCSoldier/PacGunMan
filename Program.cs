//If Linux doesnt have dotnet, for development, go to this link to get the Snap Command to get dot net: https://docs.microsoft.com/en-us/dotnet/core/install/linux-snap

using System.Collections.Generic;
using PacGunMan;
using PacGunMan.Entities;
Console.Clear();
Console.WriteLine("[QUICK NOTE]\n\nMove: WASD\nLook Around [Coming soon]: Up Arrow, Down Arow, Left Arrow, Right Arrow\nAttack: <Spacebar>\nExit: Esc [Will change to pause after initial release]\n\n[Please press any key to continue]");
Console.ReadKey();
Console.Clear();

// Enemy e = new Enemy(); // Commented out since Enemies are uner development ("Enemies" located at PacGunMan/src/Entitites/Enemy.cs)
Tick.Start();