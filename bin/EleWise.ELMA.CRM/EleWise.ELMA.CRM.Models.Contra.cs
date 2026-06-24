using System;

namespace EleWise.ELMA.CRM.Models
{
    public partial class Contractor
    {
        [Obsolete("Это свойство не используется и будет удалено в ближайших версиях", true)]
        public virtual bool SameAddress
        {
            get;
            set;
        }
    }
}
