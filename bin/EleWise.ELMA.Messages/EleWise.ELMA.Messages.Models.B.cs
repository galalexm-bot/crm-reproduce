namespace EleWise.ELMA.Messages.Models
{ 
    public partial class BaseMessage : IBaseMessage
    {
        [System.Obsolete("Это свойство не используется и будет удалено в ближайших версиях.", true)]
        public virtual Iesi.Collections.Generic.ISet<EleWise.ELMA.Messages.Models.RecipientMessageStatus> Statuses
        {
            get;
            set;
        }
        [System.Obsolete("Это свойство не используется и будет удалено в ближайших версиях.", true)]
        Iesi.Collections.Generic.ISet<EleWise.ELMA.Messages.Models.IRecipientMessageStatus> IBaseMessage.Statuses
        {
            get;
            set;
        }
    }
}