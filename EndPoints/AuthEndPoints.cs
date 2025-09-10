namespace Simuladoprovajava.EndPoints.Auth;

public static class AuthEndpoints
{
   public static void ConfigureAuthEndpoints(this WebApplication app)
    {
        app.MapPost("auth", async (
            HttpContext http,
            [FromBody] LoginRequest request,
            [FromServices]LoginUseCase useCase) =>
        {
            var response = await useCase.Do(request);

            if (!response.IsSuccess)
                return Results.BadRequest(response.Reason);
            return Results.Ok(response);
        });
    }
}