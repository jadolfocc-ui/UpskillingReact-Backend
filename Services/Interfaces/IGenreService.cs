using backendReactFinal.Model.DTOs.Genre;

namespace backendReactFinal.Services.Interfaces
{
    public interface IGenreService
    {
        Task<IEnumerable<GenreResponseDto>> GetAllGenresAsync();
        Task<GenreResponseDto> GetGenreByIdAsync(int id);
        Task AddGenreAsync(GenreCreateDTO dto);
        Task UpdateGenreAsync(GenreUpdateDto dto);
        Task DeleteGenreAsync(int id);

    }
}
