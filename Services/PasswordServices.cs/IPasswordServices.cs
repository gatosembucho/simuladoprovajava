namespace ProjetoFinal.Services.Password;

public interface IPasswordService
{
    bool Compare(string password, string hash);
}