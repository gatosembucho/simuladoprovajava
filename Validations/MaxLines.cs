using System.ComponentModel.DataAnnotations;

namespace SimuladoProvaJava.Validations;

public class MaxLinesAttribute : ValidationAttribute
{
    public int MaxLines { get; set; } = 100;
   
    public override bool IsValid(object value)
    {
        if (value is not string text)
            return true;
            
        var lines = text.Count(c => c == '\n') + 1;
        
    }
    public override string FormatErrorMessage(string name)
        => $"The field '{name}' must not exceed {MaxLines} lines";

}