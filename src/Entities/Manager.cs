using System.Globalization;
using System.Collections.Generic;
namespace PacGunMan.Entities
{
    public class Manager
    {
        public class State
        {

            /* intialize variables */
            public int ID { get; set; }
            public string Type { get; set; } = "";
            public int[] Position { get; set; } = new int[2];
            public List<State> List { get; set; } = new();

            /*  Function that returns a List with the data type of State class. 
                requrires string variable and integer array variable */
            public List<State> Add(string ent, int[] pos)
            {
                // create and instance of the current class 
                State eState = new State();
                
                // Get the amount of items in the list and output it.
                Console.WriteLine("Number of entities: " + eState.List.Count());
                // Get the current State ID and output it.
                Console.WriteLine("[Entity.Manager.State: eState.ID]: " + eState.ID);
                
                // Assign the ID value to the amount of items in the List, as this value is not used in the list.  
                eState.ID = eState.List.Count() + 1;
                
                // output the new ID value.
                Console.WriteLine("[Entity.Manager.State: eState.ID]: " + eState.ID);
                
                // set the Position and Type and then add them to the  
                eState.Position = pos;
                eState.Type = ent;
                eState.List.Add(eState);
                
                Console.WriteLine("Number of entities: " + eState.List.Count());
                
                return eState.List;
            }

            //change the existing values of the speified key to the new values
            public void Set(int id, string ent, int[] pos)
            {
                State eState = new State();
                eState.List.ElementAt(id).Position = pos;
                eState.List.ElementAt(id).Type = ent;
                // check if the index with the ID Speified exist
            }
            
            // function checks if there are any values passed on. Default is -1/
            public string GetInfo(int ID = -1) {
                // if the ID is smaller than 0, call the argument-less function. otherwise, call the function that needs an argument. 
                if (ID < 0) {
                    return GetInformation();
                } else {
                    return GetInformation(ID);
                }
            }
           
            // Grab all information contained within the List. 
            public static string GetInformation()
            {
                //Create new local instance of the current class 
                State eState = new State();
                // Initialize variable with a string to prevent string from being null or undefined.
                string list = "";
                // Check if the list has any value. Otherwise, return "No Entities" when there are no elements.
                if (eState.List.Count() > 0) {
                    //For every element in the List, add the ID, Type and posititon to the list variable.
                    foreach (var x in eState.List)
                    {
                        list += "ID: " + x.ID.ToString() + "\tCharacter: " + x.Type + "\tPosition: " + x.Position + "\n";
                    }
                    // return the lsit variable
                    return list;
                
                } else {
                    return "No Entities";
                }
            }
    
            // Get information about the specific entity using a valid ID.
            public static string GetInformation(int ID)
            {
                // create a local instance of the current class.
                State eState = new State();
                // Initialize variable with a string to prevent string from being null or undefined.
                string list = "";
                //For every element in the List, if the ID is the same as the current element, output the Type and return the Type and Position.
                foreach (var x in eState.List)
                {
                    if (x.ID == ID)
                    {
                        Console.WriteLine(x.Type);
                        return "Entity Type: " + x.Type + "\nPosition: " + x.Position;
                    }
                }
                // return the list.
                return list;
            }
        }
    }
}
