using System;
using EleWise.ELMA.CRM.Managers;

namespace EleWise.ELMA.CRM.Models
{
    /// <summary>
    /// Письмо
    /// </summary>
    public partial class RelationshipMail
    {
        private bool IsEndDateSet;

        /// <summary>
        /// Дата окончания
        /// </summary>
        public override System.DateTime EndDate
        {
            get
            {
                return IsEndDateSet ? base.EndDate : StartDate.AddMinutes(RelationshipManager.DEFAULT_MAIL_DURATION);
            }
            set
            {
                base.EndDate = value;
                IsEndDateSet = true;
            }
        }
    }
}