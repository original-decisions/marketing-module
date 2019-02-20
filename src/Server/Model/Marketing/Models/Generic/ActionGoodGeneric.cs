using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace odec.Server.Model.Marketing.Models.Generic
{
    public class ActionGoodGeneric<TGoodId,TGood,TActionId,TAction>
    {

        [Key,Column(Order=0)]
        public TGoodId GoodId { get; set; }

        public TGood Good { get; set; }
        [Key, Column(Order = 1)]
        public TActionId ActionId { get; set; }

        public TAction Action { get; set; }
    }
}
