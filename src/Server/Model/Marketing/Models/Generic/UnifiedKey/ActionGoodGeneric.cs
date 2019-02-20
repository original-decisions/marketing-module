using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace odec.Server.Model.Marketing.Models.Generic.UnifiedKey
{
    /// <summary>
    /// Класс связывающий акцию и товар
    /// </summary>
    /// <typeparam name="TKey">тип идентификатора</typeparam>
    /// <typeparam name="TGood">тип товара</typeparam>
    /// <typeparam name="TAction">тип акции</typeparam>
    public class ActionGoodGeneric<TKey,TGood,TAction>
    {
        /// <summary>
        /// Идентификтор товара
        /// </summary>
        [Key,Column(Order=0)]
        public TKey GoodId { get; set; }
        /// <summary>
        /// Товар
        /// </summary>
        public TGood Good { get; set; }
        /// <summary>
        /// Идентификтаор акции
        /// </summary>
        [Key, Column(Order = 1)]
        public TKey ActionId { get; set; }
        /// <summary>
        /// Акция
        /// </summary>
        public TAction Action { get; set; }
    }
}
