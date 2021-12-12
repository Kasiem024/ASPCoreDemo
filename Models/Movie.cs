using System.ComponentModel.DataAnnotations;

namespace ASPCoreDemo.Models
{
    public class Movie
    {
        // ID field is required by database
        public int Id { get; set; }

        // "?" indicates that the property is nullable
        public string? Title { get; set; }

        // DataTpe attribute specifies the type of data
        // Only date is displayed
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string? Genre { get; set; }
        public string? Rating { get; set; }
        public decimal Price { get; set; }
    }
}