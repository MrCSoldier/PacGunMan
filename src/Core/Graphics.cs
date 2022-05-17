namespace PacGunMan
{
    public static class Graphics
    {
        public static void Render(char[,] item, int[] pos)
        {
            string line = "";
            Console.Clear();
            for (int i = 0; i < item.GetLength(0); i++)
            {
                for (int o = 0; o < item.GetLength(1); o++)
                {
                    if (i == pos[0])
                    {
                        if (o == pos[1])
                        {
                            line += "@";
                        }
                        else
                        {
                            line += item[i, o];
                        }
                    }
                    else
                    {
                        line += item[i, o];
                    }
                }
                line += "\n";
                // Console.SetCursorPosition((Console.WindowWidth - line.Length) / 2, Console.CursorTop);
            }
            Console.WriteLine(line);
        }
    }
}