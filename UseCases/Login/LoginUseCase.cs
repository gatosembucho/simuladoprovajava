using Microsoft.EntityFrameworkCore;
using Simuladoprovajava.Entities;
using SimuladoProvaJava.Services.JWT;
using SimuladoProvaJava.Services.Password;

namespace Simuladoprovajava.UseCases.Login;

public class LoginUseCase (SimuladoprovajavaDbContext ctx,  IJWTService JWTService)
{
      public async Task<Result<LoginResponse>> Do(Login request)
    {
        var user = await ctx.Users
            .FirstOrDefaultAsync(u => u.Email == request.Email);

        if (user is null)
            return Result<LoginResponse>
                .Fail("User not found!");


        var jwt = JWTService.CreateToken(new(
            user.ID, user.Name
        ));

        return Result<LoginResponse>.Success(new LoginResponse(jwt));
    }
}