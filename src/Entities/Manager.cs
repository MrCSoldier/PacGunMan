using System.Globalization;
using System.Collections.Generic;
namespace PacGunMan.Entities
{
    public class Manager
    {
        public class State
        {

            //Make Properties of position, Id and enitty
            public int ID { get; set; }
            public string Type { get; set; } = "";
            public int[] Position { get; set; } = new int[2];
            public List<State> List { get; set; } = new();

            // public List<State> entities = new List<State>();



            // public int[] Position { get; set; }
            // public string Entity { get; set; }
            // public int ID { get; set; }
            // public List<State> List { get; set; }

            // public EntityState eState = new();
            public List<State> Add(string ent, int[] pos)
            {
                State eState = new State();
                // Console.WriteLine("Number of entities: " + eState.List.Count());
                Console.WriteLine("Number of entities: " + eState.List.Count());
                Console.WriteLine("[Entity.Manager.State: eState.ID]: " + eState.ID);
                eState.ID = eState.List.Count() + 1;
                Console.WriteLine("[Entity.Manager.State: eState.ID]: " + eState.ID);
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

            public string GetInfo(int ID = -1) {
                if (ID < 0) {
                    return GetInformation();
                } else {
                    return GetInformation(ID);
                }
            }

            public static string GetInformation()
            {
                State eState = new State();
                string list = "";
                if (eState.List.Count() > 0) {
                    foreach (var x in eState.List)
                    {
                        list += "ID: " + x.ID.ToString() + "\tCharacter: " + x.Type + "\tPosition: " + x.Position + "\n";
                    }
                    return list;
                } else {
                    return "No Entities";
                }
            }

            public static string GetInformation(int ID)
            {
                State eState = new State();
                string list = "";
                foreach (var x in eState.List)
                {
                    if (x.ID == ID)
                    {
                        Console.WriteLine(x.Type);
                        return "Entity Type: " + x.Type + "\nPosition: " + x.Position;
                    }
                }
                return list;
            }
        }
    }
}