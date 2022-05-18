namespace PacGunMan.Entities
{
    public class Bullet
    {

        public int[] Move(int[] xy, string direction) {
            int[] newXY = new int[2];
            int[] chkXY = new int[2];
            chkXY = xy;
            
            switch(direction) {
                case "up":
                    if (Collision.Check(chkXY[0] - 1, chkXY[1])) return new int[] { xy[0], xy[1] };
                    return new int[] { xy[0] - 1, xy[1] };
                case "down":
                    if (Collision.Check(chkXY[0] + 1, chkXY[1])) return new int[] { xy[0], xy[1] };
                    return new int[] { xy[0] + 1, xy[1] };
                case "left":
                    if (Collision.Check(chkXY[0], chkXY[1] - 1)) return new int[] { xy[0], xy[1] };
                    return new int[] { xy[0], xy[1] - 1 };
                case "right":
                    if (Collision.Check(chkXY[0], chkXY[1] + 1)) return new int[] { xy[0], xy[1] };
                    return new int[] { xy[0], xy[1] + 1 };
                default:
                    return new int[] { 0, 0 };
            }
        }
    }
}