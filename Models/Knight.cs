using System;
using System.ComponentModel.DataAnnotations;

namespace Castles.Models
{
    public class Knight
    {
      public int Id { get; set; }
      [Required]
      public int Name { get; set; }
      public DateTime CreatedAt { get; set; }
      public DateTime UpdatedAt { get; set; }
    }
}