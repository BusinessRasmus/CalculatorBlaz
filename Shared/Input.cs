using System.ComponentModel.DataAnnotations;

namespace Shared;

public class Input
{
    [Required]
    public double A { get; set; }
    [Required]
    public double B { get; set; }
    public double Results { get; set; }
}