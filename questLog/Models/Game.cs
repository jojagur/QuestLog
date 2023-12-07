using System.ComponentModel.DataAnnotations;

namespace questLogGame.Models;

public class Game{
    [Key]
    public int Id { get; set;}
    public string? Title {get; set; }
    public string? Genre {get; set; }
    [DataType(DataType.Date)]
    public DateTime ReleaseDate {get; set;}
    public string? Devloper {get; set; }
    public string? Publisher {get; set; }
}