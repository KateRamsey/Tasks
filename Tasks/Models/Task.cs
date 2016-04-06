using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Tasks.Models
{
    public class Task
    {
        [Required]
        [DisplayName("Your Name")]
        public string OwnerName { get; set; }
        [Required]
        public string Description { get; set; }
        [DisplayName("Completed?")]
        public bool IsFinished { get; set; }
    }
}