using System;

namespace ASP_MVC_BookShop.Services.Implementations
{
    public class RandomQuoteService : IRandomQuote
    {
        private readonly IQuote _quote;
        private static readonly Random random = new Random();
        private string content;

        public RandomQuoteService(IQuote quote)
        {
            _quote = quote;

            GetNewRandomQuote();
        }

        public string GetNewRandomQuote()
        {
            return this.content = _quote.GetRandomQuote(random.Next(_quote.GetQuotesCount()));
        }

        public string GetCurrentRandomQuote()
        {
            return this.content;
        }
    }
}
