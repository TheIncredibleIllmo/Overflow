﻿using System.ComponentModel.DataAnnotations;

namespace QuestionService.Models;

public class Question
{
    [MaxLength(64)]
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime? UpdatedAt { get; set; }
    
    [MaxLength(256)]
    public required string Title { get; set; }
    [MaxLength(4096)]
    public required string Content { get; set; }
    [MaxLength(64)]
    public required string AskerId { get; set; }
    [MaxLength(256)]
    public required string AskerDisplayName { get; set; }
    public int ViewCount { get; set; }
    public List<string> TagSlugs { get; set; } = [];
    public bool HasAcceptedAnswer  { get; set; }
    public int Votes  { get; set; }
}