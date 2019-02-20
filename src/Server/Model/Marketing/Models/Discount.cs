using System.ComponentModel.DataAnnotations;
using odec.Framework.Generic;

namespace odec.Server.Model.Marketing.Models
{
    public class Discount:Glossary<int>
    {
        [StringLength(100)]
        public override string Name { get; set; }

        public string Description { get; set; }

        public decimal StaticDiscount { get; set; }

        

    }
}