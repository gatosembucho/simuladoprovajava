namespace Simuladoprovajava.UseCases.DeleteFanfiction;

public record DeleteFanfictionRequest
{
    public int UserID { get; init; }
    public int FanficID { get; init; }
}