using System.Collections.Generic;

namespace Order_Management_Blazor_Server.Data
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
