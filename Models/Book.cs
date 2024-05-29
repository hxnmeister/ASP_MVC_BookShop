using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASP_MVC_BookShop.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Title { get; set; }

        [Required]
        [StringLength(100)]
        public string PublisherName { get; set; }

        [Range(1500, 2024)]
        public int PublishingYear { get; set; }

        [Range(0, int.MaxValue)]
        public int PagesAmount { get; set; }

        [Range(1, 5)]
        public int Rating { get; set; }

        [Required]
        public Author Author { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}\n" + 
                $"Title: {Title}\n" + 
                $"Publisher: {PublisherName}\n" + 
                $"Publishing Year: {PublishingYear}\n" + 
                $"Pages Amount: {PagesAmount}\n" + 
                $"Rating: {Rating}\n" +
                $"Author: {Author.FirstName} {Author?.LastName}\n";
        }
    }
}
