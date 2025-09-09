
using Simuladoprovajava.Entities;

namespace Simuladoprovajava.UseCases.CreateShelf;

public class CreateShelfUseCase(SimuladoprovajavaDbContext ctx)
{
    public async Task<Result<CreateShelfResponse>> Do(CreateShelfRequest request)
    {
        var shelf = new Shelf
        {
            Title = request.Title,
            OwnerID = request.OwnerID,
            LastMod = DateTime.UtcNow
        };
        ctx.Shelves.Add(shelf);
        await ctx.SaveChangesAsync();
        return Result<CreateShelfResponse>.Success(new());
 }
}