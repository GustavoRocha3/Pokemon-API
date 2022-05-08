using System.Threading.Tasks;
using Refit;

namespace PokeApi
{
    public interface IPokemonApiService
    {
        [Get("/pokemon/{name}")]
        Task<PokemonResponse> GetPokemonAsync(string name);
    }
}