namespace PacGunMan
{
    public static partial class Collision
    {
        // create and initialize a Dictionary whre the keys are the objects and the values are the collision type.
        private static Dictionary<string, int> collidables = new() {
            { "#", 2 },
            { "│", 2 },
            { "─", 2 },
            { "X", 2 },
            { "=", 1 }
        };
        
        // static function that returns a boolean and takes x and y integers as well as a target collision type that is 2 by default 
        public static bool Check(int x, int y, int targetCollisionType = 2)
        {
            /* if the target object in the coordinates exist within the Dictionary, 
                    if the targetCollision type is less than or equal to colidables, return true. 
                    Otherwise, return false 
               Otherwise, return false. */
            if (collidables.ContainsKey(Utils.GetChar(x, y)))
            {
                return targetCollisionType <= collidables[Utils.GetChar(x,y)] ? true : false;
            }
            
            return false;
        }
    }
}
