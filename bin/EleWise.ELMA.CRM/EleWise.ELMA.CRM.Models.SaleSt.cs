using System;

namespace EleWise.ELMA.CRM.Models
{
    public partial class SaleStage
    {
        [Obsolete("Это свойство не используется и будет удалено в ближайших версиях", true)]
        public virtual bool IsFinal
        {
            get;
            set;
        }
    }
}
