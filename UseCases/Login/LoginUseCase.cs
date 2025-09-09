using Simuladoprovajava.Entities;

namespace Simuladoprovajava.UseCases.Login;

public class LoginUseCase (SimuladoprovajavaDbContext ctx)
{
      public async Task<Result<LoginResponse>> Do(LoginRequest request)
    {
        var user = await ctx.Users
            .FirstOrDefaultAsync(u => u.Email == request.Email);

        if (user is null)
            return Result<LoginResponse>
                .Fail("User not found!");

        var PassWordMatch = passwordService
            .Compare(request.Password, user.Password);
        if (PassWordMatch is false)
            return Result<LoginResponse>.Fail("User not found!");

        var jwt = jWTService.CreateToken(new(
            user.ID, user.Name
        ));

        return Result<LoginResponse>.Success(new LoginResponse(jwt));
    }
}