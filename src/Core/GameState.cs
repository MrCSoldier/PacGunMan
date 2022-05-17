namespace PacGunMan
{
    public class GameState
    {
        string state = "";

        public void SetState(string state) {
            this.state = state;
            switch(state) {
                case "run":
                    Tick.Start();
                    break;
                case "stop":
                    break;
            }
        }

        public string GetState() {
            return this.state;
        }
        public void pulse() {
            // while (liveThreads.TryGetValue(ID, out bool live)) {
            //     Console.WriteLine(ID+": Heart Beat");
            //     Console.WriteLine($"{pos[0]}:{pos[1]}");
            //     Thread.Sleep(1000);
            // }
        }

        public void kill(int ID) {
            // thread.Abort(ID);
        }
    }
}