using BlazorBlog.Entities;

namespace BlazorBlog.Services
{
    public interface IGameService
    {
        Task<List<Game>> GetAllGames();
        Task<Game> AddGame(Game game);
    }
}
