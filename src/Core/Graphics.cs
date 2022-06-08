namespace PacGunMan
{
    public static class Graphics
    {
        public static void Render(char[,] item, Entities.Manager.State entities)
        {
            
            string line = "";
            int[] currEntityPos = new int[2];
            
            //loop up from 0 to the amount of items in the render item (item) in the x Axis.
            for (int x = 0; x < item.GetLength(0); x++)
            {
                //loop up from 0 to the amount of items in the render item (item) in the y xis.
                for (int y = 0; y < item.GetLength(1); y++)
                {
                    // If there are any entities
                    if (entities.List.Count() > 0) { 
                        //loop through the Entity List
                        for (int e = 0; e < entities.List.Count(); e++)
                        {
                            // initialize varaible "currEntityPos" with the Position of the current entity.
                            currEntityPos = entities.List.ElementAt(e).Position;

                            if (x == currEntityPos[0])
                            {
                                // if the loop is at any of the entities in the list
                                if (y == currEntityPos[1])
                                {
                                    // render the respecitve character into the map/output. 
                                    line += entities.List.ElementAt(e).Type + " ";
                                }
                                // otherwise
                                else
                                {
                                    // Add Whitespace
                                    AddWhiteSpace()
                                }
                            }
                            // otherwise
                            else
                            {
                                // Add Whitespace
                                AddWhiteSpace()
                            }
                        }
                    // otherwise
                    } else {
                        // Add Whitespace
                        AddWhiteSpace()
                    }

                }
                // Add a line breaker for 
                line += "\n";
            }
            // Clear Console
            Console.Clear();
            // Output the contents of the string array.
            Console.WriteLine(line);
        }
        
        private static void AddWhiteSpace() {
            /* if the current item is either a #, =, space or Vertical Boundary*/
            if (item[x, y].ToString() == "#" || item[x, y].ToString() == "=" || item[x, y].ToString() == " " || item[x, y].ToString() == "│") {
                //Add space after the environment object.
                line += item[x, y] + " ";
            } 
            //if the current object is Vertical boundary
            if (item[x, y].ToString() == "─") {
                //Add vertical Boundary after itself.
                line += item[x, y] + "─";
            }
        }
        
    }
}
