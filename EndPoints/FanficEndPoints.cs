using Simuladoprovajava.UseCases.WriteFanfiction;
namespace Simuladoprovajava.EndPoints.Fanfic;

public static class FanficEndPoints {

    public static void ConfigureFanficEndPoints(this WebApplication app)
    {
        app.MapPost("fanfic", async(
            [FromBody] WriteFanfictionRequest request,
            [FromServices] WriteFanfictionUseCase useCase) =>
        {
            var result = await useCase.Do(request);
            if (result.IsSuccess)
                return Results.Created();

            return Results.BadRequest(result.Reason);
        });
    

        app.MapGet("fanfic/{title}", async(

        ));

        app.MapDelete("fanfic/{title}", async(

        ));
    }
}