using System.Runtime.Serialization;
using PacGunMan.Core;
using static PacGunMan.Entities.Manager;
namespace PacGunMan
{
    public static class Tick
    {
        static Entities.Manager.State eState = new();
        public static void Start()
        {
            /* assign a new value to the list by adding an element with the properties of:
             Player Character: "@" and the position of x=6 and y=10 */
            eState.List = eState.Add("@", new int[] { 6, 10 });
            
            //output what eState.GetInfo returns
            Console.WriteLine(eState.GetInfo());
            
            //initialize the direction of player's sight
            string direction = "right";
            //initialize position array 
            int[] pos = Map.GetMap("test").Item2;
            var palyer = eState.List[0];
            
            //call the function by passing eState class 
            Update(eState, palyer, direction);
        }

        private static void Update(State eState, State player, string direction)
        {
            /* set both eState as the value of Item1 and direction as the value of Item2 at the same time.
            after callin it with the arguments of the eState class and the direction string */
            (eState, direction) = Input.Detect(eState, direction);
            //call the Render function with the arguments of what GetMap returns from the Map 
            Graphics.Render(Map.GetMap("test").Item1, eState);
            Update(eState, player, direction);
        }

        private static string GetChar(int x, int y)
        {
            //Get what the ascii-character at the coordinate is
            return Map.GetMap("test").Item1[x, y].ToString();
        }
    }
}
