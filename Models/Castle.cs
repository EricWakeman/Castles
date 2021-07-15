using System;
using System.ComponentModel.DataAnnotations;

namespace Castles.Models
{
    public class Castle
    {
      public int Id { get; set; }
      [Required]
      public string Name {get; set;}
      public DateTime CreatedAt { get; set; }
      public DateTime UpdatedAt { get; set; }
    }
}