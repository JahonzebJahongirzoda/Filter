using System.ComponentModel.DataAnnotations;

namespace Domain.Entities;

public class Quote
{
    public int Id { get; set; }
    [MaxLength(100),Required]
    public string? QuoteText { get; set; }
}