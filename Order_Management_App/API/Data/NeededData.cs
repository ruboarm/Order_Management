using System.Collections.Generic;

namespace API.Data
{
    public class NeededData
    {
        public static List<string> GetStates() 
        { 
            return new List<string>()
            {
                "Available",
                "Out of Stock"
            }; 
        }
    }
}
