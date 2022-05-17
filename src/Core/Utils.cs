using PacGunMan.Entities;
namespace PacGunMan
{
    public class Utils
    {
        public static string GetChar(int x, int y)
        {
            return Map.GetMap("test").Item1[x, y].ToString();
        }

        // public static void createNME()
        // {
        //     // Enemy e = new Enemy();
        //     Random random = new Random();
        //     e.ThreadWorker((int)random.NextInt64());
        // }

        // public static void killNME(Enemy enemy, int ID)
        // {
        //     enemy.kill(ID);
        // }
    }
}