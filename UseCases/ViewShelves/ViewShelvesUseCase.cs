using Microsoft.EntityFrameworkCore;
using Simuladoprovajava.Entities;
using SimuladoProvaJava.Payloads;
namespace Simuladoprovajava.UseCases.ViewShelves;

public class ViewShelvesUseCase(SimuladoprovajavaDbContext ctx)
{
    public async Task<Result<ViewShelvesResponse>> Do(ViewShelvesRequest request)
    {
        var shelfs = await ctx.Shelves.Where(
         n => n.Owner.ID == request.OwnerID
        ).ToListAsync();

        ICollection<FanfictionDataPayload>? fanfictions;
        return Result<ViewShelvesResponse>.Success(null);
    }

}  