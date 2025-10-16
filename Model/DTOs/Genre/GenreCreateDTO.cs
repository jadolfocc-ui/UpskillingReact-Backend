using System.ComponentModel.DataAnnotations;

namespace backendReactFinal.Model.DTOs.Genre
{
    public class GenreCreateDTO
    {
        [Required]
        public string Name { get; set; }
    }
}
