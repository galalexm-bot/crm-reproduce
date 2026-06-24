using EleWise.ELMA;
using EleWise.ELMA.CRM.Managers;
using EleWise.ELMA.CRM.Components;

namespace EleWise.ELMA.CRM.Models
{
    partial class Phone
    {
        protected virtual string GetFormatedPhone()
        {
        	return PhoneHelper.GetFormatedPhone(this);
        }
    }
}