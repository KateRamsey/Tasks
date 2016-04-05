using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Tasks.Models
{
    public class Task
    {
        [Required]
        public string OwnerName { get; set; }
        [Required]
        public string Description { get; set; }
        public bool IsFinished { get; set; }
    }
}