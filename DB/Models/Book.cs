using System.Collections.Generic;

namespace ASP_MVC_BookShop.DB.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string PublisherName { get; set; }
        public int PublishingYear { get; set; }
        public int Pages { get; set; }
        public int Rating { get; set; }
        public decimal Price { get; set; }
        public decimal PreviousPrice { get; set; }
        public bool IsOnAuction { get; set; }
        public int AuthorId { get; set; }

        public Author Author { get; set; }
    }
}
