using System.Collections.Generic;

namespace ASP_MVC_BookShop.Services.Implementations
{
    public class MonthValuesService : ICalendarValues
    {
        private static readonly List<string> MONTHS = new List<string> 
        { 
            "January", "February", "March", 
            "April", "May", "June", 
            "July", "August", "September", 
            "October", "November", "December" 
        };

        public List<string> GetValues()
        {
            return MONTHS;
        }
    }
}
