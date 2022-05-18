namespace PacGunMan
{
    public static class Graphics
    {
        public static void Render(char[,] item, List<KeyValuePair<string, int[]>> entities)
        {

            string line = "";
            int[] currEntityPos = new int[2];
            Console.Clear();
            for (int x = 0; x < item.GetLength(0); x++)
            {
                for (int y = 0; y < item.GetLength(1); y++)
                {
                    // line += item[x, y];

                    for (int e = 0; e < entities.Count(); e++)
                    {
                        currEntityPos = entities.ElementAt(e).Value;

                        if (x == currEntityPos[0])
                        {
                            if (y == currEntityPos[1])
                            {
                                line += entities.ElementAt(e).Key;
                            }
                            else
                            {
                                line += item[x, y];
                            }
                        }
                        else
                        {
                            line += item[x, y];
                        }
                        // Console.WriteLine(entities.ElementAt(e).Key + ": " + currEntityPos[0] + ":" + currEntityPos[1]);
                        // Console.WriteLine(entities[entities.First().Key.ToString()][0] + ":" + entities[entities.First().Key.ToString()][1]);
                    }

                }
                // line = "";
                line += "\n";
            }
            Console.WriteLine(line);
            // Console.WriteLine(line);

            // for (int i = 0; i < item.GetLength(0); i++)
            // {
            //     for (int o = 0; o < item.GetLength(1); o++)
            //     {
            //         if (i == pos[0])
            //         {
            //             if (o == pos[1])
            //             {
            //                 line += "@";
            //             }
            //             else
            //             {
            //                 line += item[x, y];
            //             }
            //         }
            //         else
            //         {
            //             line += item[x, y];
            //         }
            //     }
            //     line += "\n";
            //     // Console.SetCursorPosition((Console.WindowWidth - line.Length) / 2, Console.CursorTop);
            // }
        }
    }
}