using System.ComponentModel.DataAnnotations;

namespace SimuladoProvaJava.Validations;

public class MaxWordsAttribute : ValidationAttribute
{
   
    public int MaxWords { get; set; } = 1000;
    
    public override bool IsValid(object value)
    {
        if (value is not string text)
            return true;
            
        var words = text.Split(new[] { ' ', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries).Length;
        return lines <= MaxLines && words <= MaxWords;
    }
    public override string FormatErrorMessage(string name)
        => $"The field '{name}' must not exceed {MaxWords} words.";

}