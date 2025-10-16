using backendReactFinal.Model.DTOs.Genre;
using backendReactFinal.Model.Entities;
using backendReactFinal.Repositories.Interfaces;
using backendReactFinal.Services.Interfaces;

namespace backendReactFinal.Services.Implementation
{
    public class GenreService: IGenreService
    {
        private readonly IRepository<Genre> _genreRepository;

        public GenreService(IRepository<Genre> genreRepository)
        {
            _genreRepository = genreRepository;
        }

        public async Task<IEnumerable<GenreResponseDto>> GetAllGenresAsync()
        {
            var genres = await _genreRepository.GetAllAsync();
            var result = genres.Select(x => new GenreResponseDto
            {
                Id = x.Id,
                Name = x.Name
            });
            return result;
        }

        public async Task<GenreResponseDto> GetGenreByIdAsync(int id)
        {
            var genre = await _genreRepository.GetByIdAsync(id);

            if(genre == null)
            {
                return null;
            }
            return new() { Id = id, Name = genre.Name };
        }

        public async Task AddGenreAsync(GenreCreateDTO dto)
        {
            var genre = new Genre()
            {
                Name = dto.Name
            };

            await _genreRepository.AddAsync(genre);
            await _genreRepository.SaveAsync();
        }

        public async Task UpdateGenreAsync(GenreUpdateDto dto)
        {
            var genre = await _genreRepository.GetByIdAsync(dto.Id);
            if(genre == null)
            {
                return;
            }
            genre.Name = dto.Name;
            _genreRepository.Update(genre);
            await _genreRepository.SaveAsync();
        }

        public async Task DeleteGenreAsync(int id)
        {
            var genre = await _genreRepository.GetByIdAsync(id);
            if (genre!= null)
            {
                _genreRepository.Remove(genre);
                await _genreRepository.SaveAsync();
            }
        }      
    }
}
