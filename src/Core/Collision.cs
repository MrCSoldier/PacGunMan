namespace PacGunMan
{
    public static partial class Collision
    {

        private static Dictionary<string, int> collidables = new() {
            { "#", 2 },
            { "│", 2 },
            { "─", 2 },
            { "X", 2 },
            { "=", 1 }
        };

        public static bool Check(int x, int y, int targetCollisionType = 2)
        {
            if (collidables.ContainsKey(Utils.GetChar(x, y)))
            {
                return targetCollisionType <= collidables[Utils.GetChar(x,y)] ? true : false;
            }
            return false;
        }
    }
}