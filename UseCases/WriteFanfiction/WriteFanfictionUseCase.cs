using Simuladoprovajava.Entities;
namespace Simuladoprovajava.UseCases.WriteFanfiction;

public class WriteFanfictionUseCase (SimuladoprovajavaDbContext ctx)
{
     public async Task<Result<WriteFanfictionResponse>> Do(WriteFanfictionRequest request)
    {
        var fanfic = new Fanfic
        {
            Title = request.Title,
            Text = request.Text,
            AuthorID = request.AuthorID

        };
        ctx.Fanfics.Add(fanfic);
        await ctx.SaveChangesAsync();

        return Result<WriteFanfictionResponse>.Success(new());
 }
}
