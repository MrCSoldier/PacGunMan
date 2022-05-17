// namespace PacGunMan.Entities
// {
//     public class Enemy
//     {
//         int ID;
//         int[] pos = new int[2];
//         int[] spawnPnt = new int[2];
//         Thread thread;

//         // Dictionary<>


//         Dictionary<int, bool> liveThreads = new Dictionary<int, bool>() { };
//         Dictionary<int, int[]> threadLocation = new Dictionary<int, int[]>() { };

//         public void ThreadWorker(int ID)
//         {
//             this.ID = ID;
//             // this.pos = pos;
//             thread = new Thread(new ThreadStart(pulse));
//             liveThreads.Add(ID, true);
//             thread.Start();
//         }

//         public void pulse()
//         {
//             while (liveThreads.TryGetValue(ID, out bool live))
//             {
//                 Console.WriteLine(ID + ": Heart Beat");
//                 Console.WriteLine($"{pos[0]}:{pos[1]}");
//                 Thread.Sleep(1000);
//             }
//         }

//         public void kill(int ID)
//         {
//             // thread.Abort(ID);
//         }
//     }
// }