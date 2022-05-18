namespace PacGunMan
{
    public static class Graphics
    {
        public static void Render(char[,] item, List<KeyValuePair<string, int[]>> entities)
        {
            string line = "";
            int[] currEntityPos = new int[2];
            Console.Clear();
            for (int y = 0; y < item.GetLength(0); y++) {
                for (int x = 0; x < item.GetLength(1); x++) {
                    for (int e = 0; e < entities.Count(); e++) {
                        currEntityPos = entities.ElementAt(e).Value;
                        if (x == currEntityPos[0]) {
                            if (y == currEntityPos[1]) {
                                line += entities.ElementAt(e).Key; 
                            } else {
                                line += item[x, y]; 
                            }
                        } else {
                            line += item[x, y];
                        }
                    }

                }
                line += "\n";
            }
            Console.WriteLine(line);
        }
    }
}
