namespace EleWise.ELMA.CRM.Models
//using System.Attribute
{
    public partial class Sale
    {
        /// <summary>
        /// Author 
        /// </summary>
        public virtual EleWise.ELMA.Security.Models.User CreationAuthor
        {
            get
            {
                return Author;
            }
            set
            {
                Author = value;
            }
        }
    }

}