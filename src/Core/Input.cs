namespace PacGunMan.Core
{
    public static class Input
    {
        private static Entities.Manager.State eState = new();
        public static (Entities.Manager.State, string) Detect(Entities.Manager.State eState, string direction)
        {
            int[] chkXY = new int[2];
            chkXY = eState.List[0].Position;

            var key = Console.ReadKey(true).KeyChar.ToString();
            var playerPos = eState.List[0].Position;
            switch (key)
            {
                case "LeftArrow":
                    direction = "left";
                    return (eState, direction);
                case "RightArrow":
                    direction = "right";
                    return (eState, direction);
                case "UpArrow":
                    direction = "up";
                    return (eState, direction);
                case "DownArrow":
                    direction = "down";
                    return (eState, direction);
                case "w":
                    if (Collision.Check(chkXY[0] - 1, chkXY[1], 1)) return (eState, direction);
                    eState.List[0].Position = new int[] { playerPos[0] - 1, playerPos[1] };
                    return (eState, direction);
                case "s":
                    if (Collision.Check(chkXY[0] + 1, chkXY[1], 1)) return (eState, direction);
                    eState.List[0].Position = new int[] { playerPos[0] + 1, playerPos[1] };
                    return (eState, direction);
                case "a":
                    if (Collision.Check(chkXY[0], chkXY[1] - 1, 1)) return (eState, direction);
                    eState.List[0].Position = new int[] { playerPos[0], playerPos[1] - 1 };
                    return (eState, direction);
                case "d":
                    if (Collision.Check(chkXY[0], chkXY[1] + 1, 1)) return (eState, direction);
                    eState.List[0].Position = new int[] { playerPos[0], playerPos[1] + 1 };
                    return (eState, direction);
                case "W":
                    if (Collision.Check(chkXY[0] - 1, chkXY[1])) return (eState, direction);
                    eState.List[0].Position = new int[] { playerPos[0] - 1, playerPos[1] };
                    return (eState, direction);
                case "S":
                    if (Collision.Check(chkXY[0] + 1, chkXY[1])) return (eState, direction);
                    eState.List[0].Position = new int[] { playerPos[0] + 1, playerPos[1] };
                    return (eState, direction);
                case "A":
                    if (Collision.Check(chkXY[0], chkXY[1] - 1)) return (eState, direction);
                    eState.List[0].Position = new int[] { playerPos[0], playerPos[1] - 1 };
                    return (eState, direction);
                case "D":
                    if (Collision.Check(chkXY[0], chkXY[1] + 1)) return (eState, direction);
                    eState.List[0].Position = new int[] { playerPos[0], playerPos[1] + 1 };
                    return (eState, direction);
                case " ":
                    // Entities.Bullet
                    return (eState, direction);
                default:
                    return (eState, direction);
            }
        }
    }
}