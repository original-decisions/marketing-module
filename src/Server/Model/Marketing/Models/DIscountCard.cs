using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using odec.CP.Server.Model.Location;
using odec.Framework.Generic;
using odec.Server.Model.Contact;

namespace odec.Server.Model.Marketing.Models
{
    public class DiscountCard :Glossary<int>
    {
        

        public User.User User { get; set; }

        [Required]
        public int UserId { get; set; }


        [Required]
        [Column("CardAdressID"), ForeignKey("CardAdress")]
        public int AddressId { get; set; }


        public Address CardAdress { get; set; }

        public virtual ICollection<Phone> Phones { get; set; }
       // public virtual ICollection<Interest> Interests { get; set; }
        [Column("CardNumber")]
        public override string Name { get; set; }

        [Required]
        public int DiscountCardStateId { get; set; }


        public DiscountCardState DiscountCardState { get; set; }


        
       // public Int32? KidsId { get; set; }

       // public Kids Kids { get; set; }

        [Required]
        public int EmploymentId{ get; set; }


        //public Employment Employment { get; set; }

    }
}
