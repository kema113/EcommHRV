using System.ComponentModel.DataAnnotations;

namespace EcommHRV.Models
{
    public class Cinema
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Logo { get; set; }
        public ICollection<Movie> Movies { get; set; }

    }
}
