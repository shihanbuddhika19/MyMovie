using InventoryBeginners.Models;

namespace InventoryBeginners.Interfaces
{
    public interface iMovie
    {
        List<Movie> GetItems();
        Movie GetMovie(int id);
        Movie Create(Movie movie);

        Movie Edit(Movie movie);
        Movie Delete(Movie movie);

    }
}
