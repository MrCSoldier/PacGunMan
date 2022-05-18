using System.Runtime.Serialization;
using PacGunMan.Core;
namespace PacGunMan
{
    public static class Tick
    {






        class ProcesseddPart
        {
            public string PartNumber {get; set;}
            public string FileName {get;set;}
        }











        public static void Start()
        {
            
            Dictionary<string, int[]> entities = new() {
                { "@", new int[] { 3, 5 } },
                { "X", new int[] { 4, 5 } }
            };
            // entities.Add("@", new int[] { 3, 5 } );
            string direction = "right";
            int[] pos = Map.GetMap("test").Item2;
            // Console.WriteLine()
            Console.WriteLine("Initial Pos: " + pos[0] + ":" + pos[1]);
            Update(pos, direction, entities);
        }

        private static void Update(int[] pos, string direction, Dictionary<string, int[]> entities)
        {
            (pos, direction) = Core.Input.Detect(pos, direction);
            // direction = Core.Input.Detect(pos, direction).Item2;
            Graphics.Render(Map.GetMap("test").Item1, entities);
            Update(pos, direction, entities);
        }

        private static string GetChar(int x, int y)
        {
            return Map.GetMap("test").Item1[x, y].ToString();
        }
    }
}

//return new int[] { xy[0] + 1, xy[1] };