using System.Runtime.Serialization;
using PacGunMan.Core;
namespace PacGunMan
{
    public static class Tick
    {
        public static void Start()
        {
            string direction = "right";
            int[] pos = Map.GetMap("test").Item2;
            // Console.WriteLine()
            Console.WriteLine("Initial Pos: " + pos[0] + ":" + pos[1]);
            Update(pos, direction);
        }

        private static void Update(int[] pos, string direction)
        {
            (pos, direction) = Core.Input.Detect(pos, direction);
            // direction = Core.Input.Detect(pos, direction).Item2;
            Graphics.Render(Map.GetMap("test").Item1, pos);
            Update(pos, direction);
        }

        private static string GetChar(int x, int y)
        {
            return Map.GetMap("test").Item1[x, y].ToString();
        }
    }
}

//return new int[] { xy[0] + 1, xy[1] };