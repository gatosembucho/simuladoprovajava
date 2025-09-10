using Simuladoprovajava.UseCases.CreateUser;
namespace Simuladoprovajava.EndPoints.User;

public static class UserEndPoints
{

    public static void ConfigureUserEndPoints(this WebApplication app)
    {
        app.MapPost("user", async(
        ));

    }
}