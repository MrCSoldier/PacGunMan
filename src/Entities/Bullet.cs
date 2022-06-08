namespace PacGunMan.Entities
{
    public class Bullet
    {
        // function requires return of an integer variable. function requires an integer array and string variable
        public int[] Move(int[] xy, string direction) {
            
            int[] newXY = new int[2];
            int[] chkXY = new int[2];
            chkXY = xy;
            
            // check for any values listed in the switch cases, otherwise, return the current coordinates of entitiy.
            switch(direction) {
                case "up":
                    /* call the Collision Checking function by passing the target coordinates. 
                    If true, return the same coordinate of entity (dont move). */
                    if (Collision.Check(chkXY[0] - 1, chkXY[1])) return new int[] { xy[0], xy[1] };
                    // As the statement is false, the entity gets moved
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
