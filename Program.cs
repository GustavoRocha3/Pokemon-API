using System.Threading.Tasks;
using Refit;

namespace PokeApi
{
    class MainClass
    {
        static async Task Main(string[] args)
        {
            try
            {
                var arrayPokemon = new List<string> { "charmander", "Squirtle", "Caterpie", "Weedle", "Pidgey", "Pidgeotto", "Rattata", "Spearow", "Fearow", "Arbok", "Pikachu", "Sandshrew" };
                foreach (var name in arrayPokemon)
                {
                    var pokemonName = RestService.For<IPokemonApiService>("https://pokeapi.co/api/v2");
                    Console.WriteLine("Consultando o Pokemon: "+ name);

                    var pokemon = await pokemonName.GetPokemonAsync(name);

                    Console.Write($"\nPokemon:{pokemon.Name},\nTipos:{pokemon.Types}\nHabilidades:{pokemon.Abilities}\nPeso:{pokemon.Weight}\nTamanho:{pokemon.Height}\nImagem:{pokemon.Sprites}");
                    Console.ReadKey();
                }
                

            } catch (Exception e)
            {
                Console.WriteLine("Erro na consulta do Pokemon: " + e.Message);
            }
        }
    }
}