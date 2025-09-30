using System.ComponentModel.DataAnnotations;

namespace QuestionService.Models;

public class Tag
{
    [MaxLength(64)]
    public string Id { get; set; } = Guid.NewGuid().ToString();
    [MaxLength(64)]
    public required string Name { get; set; }
    [MaxLength(64)]
    public required string Slug { get; set; }
    [MaxLength(1024)]
    public required string Description { get; set; }
}