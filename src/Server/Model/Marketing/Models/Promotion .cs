using System;
using System.ComponentModel.DataAnnotations;
using odec.Framework.Generic;

namespace odec.Server.Model.Marketing.Models
{
    public class Promotion:Glossary<int>
    {  
        [Required]
        [StringLength(50)]
        public string Email { get; set; }
    }
}