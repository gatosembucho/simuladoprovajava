using Microsoft.EntityFrameworkCore;
using Simuladoprovajava.Entities;
namespace Simuladoprovajava.UseCases.DeleteFanfiction;

public class DeleteFanfictionUseCase(SimuladoprovajavaDbContext ctx)
{
    public async Task<Result<DeleteFanfictionResponse>> Do(DeleteFanfictionRequest request)
    {
        var fanfics = await ctx.Fanfics.Where(
         n => n.Author.ID == request.UserID
        ).ToListAsync();

        var DeleteFanfiction = await ctx.Fanfics.FirstOrDefaultAsync(
           u => u.AuthorID == request.UserID && u.ID == request.FanficID);

        ctx.Remove(DeleteFanfiction);
        await ctx.SaveChangesAsync();

        return Result<DeleteFanfictionResponse>.Success(new());
    }
}