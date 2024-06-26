using System.Collections.Generic;

namespace ASP_MVC_BookShop.Services.Implementations
{
    public class QuoteService : IQuote
    {
        private static readonly List<string> quotes = new List<string> 
        { 
            "We need never be ashamed of our tears.", 
            "There is no expedient to which a man will not go to avoid the labor of thinking.",
            "To invent, you need a good imagination and a pile of junk.",
            "As a cure for worrying, work is better than whisky.",
            "Hell, there are no rules here-- we're trying to accomplish something.",
            "I never did anything worth doing by accident, nor did any of my inventions come by accident.",
            "Train up a fig tree in the way it should go, and when you are old sit under the shade of it."
        };

        public string GetRandomQuote(int quoteNumber)
        {
            if(quoteNumber <= quotes.Count)
            {
                return quotes[quoteNumber];
            }

            return string.Empty;
        }

        public int GetQuotesCount()
        { 
            return quotes.Count; 
        }
    }
}
