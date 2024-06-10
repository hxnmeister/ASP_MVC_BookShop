using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ASP_MVC_BookShop.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Title is required")]
        [StringLength(100, ErrorMessage = "Title cannot be longer than 100 characters")]
        [DisplayName("Title: ")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Publisher name is required")]
        [StringLength(100, ErrorMessage = "Publisher name cannot be longer than 100 characters")]
        [DisplayName("Publisher: ")]
        public string PublisherName { get; set; }

        [Range(1500, 2024, ErrorMessage = "Publishing year must be between 1500 and 2024")]
        [DisplayName("Publishing Year: ")]
        public int PublishingYear { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Pages amount must be a positive number")]
        [DisplayName("Pages: ")]
        public int PagesAmount { get; set; }

        [Range(1, 5, ErrorMessage = "Rating must be between 1 and 5")]
        [DisplayName("Rating: ")]
        public int Rating { get; set; }

        [Required(ErrorMessage = "Price is required!")]
        [Range(0.50, double.MaxValue, ErrorMessage = "Price must be greater than 0.50")]
        [DisplayName("Price: ")]
        public decimal Price { get; set; }

        public decimal PreviousPrice { get; set; }

        [DisplayName("Is on auction: ")]
        public bool IsOnAuction { get; set; } = false;

        [Required(ErrorMessage = "Author is required")]
        [DisplayName("Author: ")]
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
