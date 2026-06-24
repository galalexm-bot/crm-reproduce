using System;

namespace EleWise.ELMA.Security.Models
{
    public partial class Replacement
    {
        [Obsolete("Свойство больше не используется", true)]
        public virtual bool RedirectControlTask
        {
            get { return false; }
            set { }
        }
    }
}