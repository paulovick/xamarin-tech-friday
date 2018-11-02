using System.Threading;
using System.Threading.Tasks;

namespace XamarinTechFriday.Services
{
    public class PokemonRestService
    {
        public async Task<string> GetName()
        {
            Thread.Sleep(3000);
            return "Bulbasaur";
        }
    }
}
