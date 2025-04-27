using System.ComponentModel.DataAnnotations;

namespace EcommHRV.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }
        public string FullName { get; set; }
        [Display(Name = "Profile Picture")]
        [Required(ErrorMessage = "Profile Picture is required")]
        public string? ProfilePicture { get; set; }
        //public ICollection<Actor_Movie> Actor_Movies { get; set; }

    }
}
