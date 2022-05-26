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
            eState.List = eState.Add("@", new int[] { 2 * 3, 2* 5 });
            Console.WriteLine(eState.GetInfo());
            // var player = 
            string direction = "right";
            // Console.WriteLine("[Tick.Start]: " + entities.List.Count());
            // entities.Add("@", new int[] { 3, 5 });
            int[] pos = Map.GetMap("test").Item2;
            // Console.WriteLine("[Tick.Start]: " + eState.List.Count());
            var palyer = eState.List[0];
            Update(eState, palyer, direction);
        }

        private static void Update(State eState, State player, string direction)
        {
            (eState, direction) = Input.Detect(eState, direction);
            Graphics.Render(Map.GetMap("test").Item1, eState);
            Update(eState, player, direction);
        }

        private static string GetChar(int x, int y)
        {
            return Map.GetMap("test").Item1[x, y].ToString();
        }
    }
}
