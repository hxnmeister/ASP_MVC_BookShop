using System.Collections.Generic;

namespace ASP_MVC_BookShop.Services.Implementations
{
    public class DaysOfWeekService : ICalendarValues
    {
        private static readonly List<string> DAYS_OF_WEEK = new List<string>
        {
            "Sunday", "Monday", "Tuesday",
            "Wednesday", "Thursday", "Friday", "Saturday"
        };

        public List<string> GetValues()
        {
            return DAYS_OF_WEEK;
        }
    }
}
