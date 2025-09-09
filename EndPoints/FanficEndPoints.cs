namespace Simuladoprovajava.EndPoints.Fanfic;

public static class FanficEndPoints{
    
    public static void ConfigureFanficEndPoints(this WebApplication app)
    {
            app.MapPost("fanfic", async(
            ));

            app.MapGet("fanfic/{title}", async(

            ));

            app.MapDelete("fanfic/{title}", async(

            ));
    }
}