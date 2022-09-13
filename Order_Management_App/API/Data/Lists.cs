using System.Collections.Generic;

namespace API.Data
{
    public static class Lists
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
