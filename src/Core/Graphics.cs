namespace PacGunMan
{
    public static class Graphics
    {
        public static void Render(char[,] item, Entities.Manager.State entities)
        {
            string line = "";
            int[] currEntityPos = new int[2];
            for (int x = 0; x < item.GetLength(0); x++)
            {
                for (int y = 0; y < item.GetLength(1); y++)
                {
                    if (entities.List.Count() > 0) { 
                        for (int e = 0; e < entities.List.Count(); e++)
                        {
                            currEntityPos = entities.List.ElementAt(e).Position;

                            if (x == currEntityPos[0])
                            {
                                if (y == currEntityPos[1])
                                {
                                    line += entities.List.ElementAt(e).Type + " ";
                                }
                                else
                                {
                                    if (item[x, y].ToString() == "#" || item[x, y].ToString() == "=" || item[x, y].ToString() == " ") {
                                        line += item[x, y] + " ";
                                    } 
                                    if (item[x, y].ToString() == "─") {
                                        line += item[x, y] + "─";
                                    }
                                }
                            }
                            else
                            {
                                if (item[x, y].ToString() == "#" || item[x, y].ToString() == "=" || item[x, y].ToString() == " ") {
                                    line += item[x, y] + " ";
                                } 
                                if (item[x, y].ToString() == "─") {
                                    line += item[x, y] + "─";
                                }
                            }
                        }
                    } else {
                        if (item[x, y].ToString() == "#" || item[x, y].ToString() == "=" || item[x, y].ToString() == " " || item[x, y].ToString() == "│") {
                            line += item[x, y] + " ";
                        } 
                        if (item[x, y].ToString() == "─") {
                            line += item[x, y] + "─";
                        }
                    }

                }
                // line = "";
                line += "\n";
            }
            Console.Clear();
            Console.WriteLine(line);
        }
    }
}