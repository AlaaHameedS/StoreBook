using System.ComponentModel.DataAnnotations;

namespace BookStoreAppMVC6.Models.Domain
{
    public class Genre
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
    }
}
