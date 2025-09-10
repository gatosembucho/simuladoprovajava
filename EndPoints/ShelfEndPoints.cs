namespace Simuladoprovajava.EndPoints.Shelf;

public static class ShelfEndPoints{
    
    public static void ConfigureShelfEndPoints(this WebApplication app)
    {
            app.MapPost("shelf", async(
            ));

            app.MapGet("shelf/{title}", async(

            ));

            app.MapPut("shelf", async(

            ));
    }
}