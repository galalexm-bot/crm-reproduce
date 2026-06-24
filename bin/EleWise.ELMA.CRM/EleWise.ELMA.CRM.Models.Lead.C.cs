using System;

namespace EleWise.ELMA.CRM.Models
{
    public partial class Lead
    {

        [Obsolete("Это свойство не используется и будет удалено в ближайших версиях", true)]
        public virtual IContact Parent
        {
            get;
            set;
        }

        [Obsolete("Это свойство не используется и будет удалено в ближайших версиях", true)]
        public virtual bool IsGroup
        {
            get;
            set;
        }

    }
}
