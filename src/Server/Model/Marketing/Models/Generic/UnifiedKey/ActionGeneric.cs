using System.ComponentModel.DataAnnotations;
using odec.Framework.Generic;

namespace odec.Server.Model.Marketing.Models.Generic.UnifiedKey
{
    /// <summary>
    /// обобщенное класс акция
    /// </summary>
    /// <typeparam name="TKey">Тип идентификатора</typeparam>
    public class ActionGeneric<TKey> :Glossary<TKey>
    {
        /// <summary>
        /// Наименование
        /// </summary>
        [StringLength(255)]
        public override string Name { get; set; }
        /// <summary>
        /// Описание
        /// </summary>
        public string Description { get; set; }
    }
}
