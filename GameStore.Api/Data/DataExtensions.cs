using GameStore.Api.Entities;
using Microsoft.EntityFrameworkCore;

namespace GameStore.Api.Data;

public static class DataExtensions
{
    public static async Task MigrateDbAsync(this WebApplication app)
    {
        using var scope = app.Services.CreateScope();
        var dbContext = scope.ServiceProvider.GetRequiredService<GameStoreContext>();

        await dbContext.Database.MigrateAsync();

        if (!dbContext.Genres.Any())
        {
            dbContext.Genres.AddRange(
                new Genre { Id = 1, Name = "Fighting" },
                new Genre { Id = 2, Name = "Roleplaying" },
                new Genre { Id = 3, Name = "Sports" },
                new Genre { Id = 4, Name = "Racing" },
                new Genre { Id = 5, Name = "Kids and Family" }
            );
            await dbContext.SaveChangesAsync();
        }

        if (!dbContext.Games.Any())
        {
            dbContext.Games.AddRange(
                new Game { Id = 1, Name = "Street Fighter II", Price = 19.99M, GenreId = 1, ReleaseDate = new DateOnly(1922, 7, 15) },
                new Game { Id = 2, Name = "Final Fantasy XIV", Price = 59.99M, GenreId = 2, ReleaseDate = new DateOnly(2010, 9, 30) },
                new Game { Id = 3, Name = "FIFA 23", Price = 69.99M, GenreId = 3, ReleaseDate = new DateOnly(2022, 9, 27) }
            );
            await dbContext.SaveChangesAsync();
        }
    }
}
