namespace PacGunMan.Core
{
    public class Input
    {
        public static (int[], string) Detect(int[] xy, string direction)
        {
            int[] newXY = new int[2];
            int[] chkXY = new int[2];
            chkXY = xy;
            

            var key = Console.ReadKey(true).KeyChar.ToString();

            switch (key)
            {
                case "LeftArrow":
                    direction = "left";
                    return (xy, direction);
                case "RightArrow":
                    direction = "right";
                    return (xy, direction);
                case "UpArrow":
                    direction = "up";
                    return (xy, direction);
                case "DownArrow":
                    direction = "down";
                    return (xy, direction);
                case "w":
                    if (Collision.Check(chkXY[0] - 1, chkXY[1], 1)) return (new int[] { xy[0], xy[1]}, direction);
                    return (new int[] { xy[0] - 1, xy[1] }, direction);
                case "s":
                    if (Collision.Check(chkXY[0] + 1, chkXY[1], 1)) return (new int[] { xy[0], xy[1]}, direction);
                    return (new int[] { xy[0] + 1, xy[1]}, direction);
                case "a":
                    if (Collision.Check(chkXY[0], chkXY[1] - 1, 1)) return (new int[] { xy[0], xy[1]}, direction);
                    return (new int[] { xy[0], xy[1] - 1}, direction);
                case "d":
                    if (Collision.Check(chkXY[0], chkXY[1] + 1, 1)) return (new int[] { xy[0], xy[1]}, direction);
                    return (new int[] { xy[0], xy[1] + 1}, direction);
                case "W":
                    if (Collision.Check(chkXY[0] - 1, chkXY[1])) return (new int[] { xy[0], xy[1]}, direction);
                    return (new int[] { xy[0] - 1, xy[1]}, direction);
                case "S":
                    if (Collision.Check(chkXY[0] + 1, chkXY[1])) return (new int[] { xy[0], xy[1]}, direction);
                    return (new int[] { xy[0] + 1, xy[1]}, direction);
                case "A":
                    if (Collision.Check(chkXY[0], chkXY[1] - 1)) return (new int[] { xy[0], xy[1]}, direction);
                    return (new int[] { xy[0], xy[1] - 1}, direction);
                case "D":
                    if (Collision.Check(chkXY[0], chkXY[1] + 1)) return (new int[] { xy[0], xy[1]}, direction);
                    return (new int[] { xy[0], xy[1] + 1}, direction);
                case " ":
                    // Entities.Bullet
                    return (xy, direction);
                default:
                    return (new int[] { xy[0], xy[1]}, direction);
            }
        }
    }
}