using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using odec.Framework.Generic;

namespace odec.Server.Model.Marketing.Models
{
    public class DiscountCardState :Glossary<int>
    {
        [StringLength(150)]
        public override string Name { get; set; }
      
        public virtual ICollection<DiscountCard> DiscountCards { get; set; }
    }
}
