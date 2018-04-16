using System;
using System.ComponentModel.DataAnnotations;

namespace exp_web.Models
{
    public class User
    {
        public int ID { get; set; }
        [Required, StringLength(100)]
        public string Username { get; set; }
        public string Password { get; set; }
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Birthday { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}