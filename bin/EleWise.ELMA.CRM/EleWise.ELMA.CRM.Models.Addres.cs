using EleWise.ELMA;
using EleWise.ELMA.CRM.Managers;
using EleWise.ELMA.CRM.Components;

namespace EleWise.ELMA.CRM.Models
{
    partial class Address
    {
        protected virtual string GetName()
        {
        	return AddrManager.Instance.GenerateName(AddressHelper.FormatTemplate, this);
        }
    }
}