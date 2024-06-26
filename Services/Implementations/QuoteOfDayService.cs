using System;

namespace ASP_MVC_BookShop.Services.Implementations
{
    public class QuoteOfDayService : IQuoteOfDay
    {
        private readonly IQuote _quote;
        private static readonly Random random = new Random();
        private string content;

        public QuoteOfDayService(IQuote quote)
        {
            this._quote = quote;

            GetNewQuoteOfDay();
        }

        public string GetNewQuoteOfDay()
        {
            return this.content = _quote.GetRandomQuote(random.Next(_quote.GetQuotesCount()));
        }

        public string GetCurrentQuoteOfDay()
        {
            return this.content;
        }
    }
}
