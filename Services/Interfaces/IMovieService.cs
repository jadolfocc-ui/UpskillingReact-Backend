using backendReactFinal.Model.DTOs.Movie;

namespace backendReactFinal.Services.Interfaces
{
    public interface IMovieService
    {
        Task<IEnumerable<MovieCatalogResponseDto>> GetMoviesCatalogWithMetadata();
        Task<MovieResponseDto> GetMovieWithMetadata(int movieId);

    }
}
