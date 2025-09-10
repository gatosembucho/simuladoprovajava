using Microsoft.EntityFrameworkCore;
using Simuladoprovajava.Entities;

namespace Simuladoprovajava.UseCases.CreateUser;

public class CreateUserUseCase(SimuladoprovajavaDbContext ctx)
{
    public async Task<Result<CreateUserResponse>> Do(CreateUserRequest request)
    {
        var user = new User
        {
            Name = request.Username,
            Email = request.Email,
            Description = request.Description,
            Password = request.Password,
            Entry = DateTime.UtcNow
        };
        ctx.Users.Add(user);
        await ctx.SaveChangesAsync();

        return Result<CreateUserResponse>.Success(new());
 }
}