using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Tryitter.Models
{
    public class Register
    {
        [Key]
        public int RegisterId { get; set; }
        public string? Module { get; set; }
        public string? Status { get; set; }

        [ForeignKey("UserId")]
        public string? Id { get; set; }
        public User? User { get; set; }
    }
}
