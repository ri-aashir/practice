﻿using System.ComponentModel.DataAnnotations;

#nullable enable
namespace TodoApi.Models
{
    public class TodoItem
    {
        public long Id { get; set; }
        [Required]
	    public string? Name { get; set; }
	    public bool IsComplete { get; set; }
        public string? Secret { get; set; }
    }
}