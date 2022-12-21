using System.ComponentModel.DataAnnotations;

public class FormModel
{
    [Required]
    public string? Status { get; set; } = "DOWN";
    public string? Token { get; set; }
}