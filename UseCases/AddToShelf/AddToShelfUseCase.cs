using Microsoft.EntityFrameworkCore;
using Simuladoprovajava.Entities;

namespace Simuladoprovajava.UseCases.AddToShelf;

public class AddToShelfUseCase(SimuladoprovajavaDbContext ctx)
{
//         public async Task<Result<AddToShelfResponse>> Do(AddToShelfRequest request)
//     {

//         var shelf = await ctx.Shelves.FirstOrDefaultAsync(
//             i => i.Title == request.ShelfName
//         );
//          var NewAddition = new Fanfic
//         {
//             Title = request.Title,
//             OwnerID = request.OwnerID,
//             LastMod = DateTime.UtcNow
//         };
//         ctx.Shelves.Add(NewAddition);
//         await ctx.SaveChangesAsync();
//         return Result<AddToShelfResponse>.Success(new());
//  }
}