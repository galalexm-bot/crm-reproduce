using System;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Web.Common.ExtensionPoints;
using EleWise.ELMA.BPM.Web.Tasks.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Managers;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.CRM.Web.Components;

[Component]
public class CrmTaskParametersActionWebHandler : ICommentActionWebHandler
{
	public void BeforeCreateProcess(IValueProvider valueProvider, object target)
	{
		if (!(target is TaskModel taskModel) || !(taskModel.Entity is ICRMTaskBase iCRMTaskBase))
		{
			return;
		}
		long result = 0L;
		ValueProviderResult value = valueProvider.GetValue("crmEntityId");
		if (value != null)
		{
			long.TryParse(value.get_AttemptedValue(), out result);
		}
		Guid? guid = null;
		ValueProviderResult value2 = valueProvider.GetValue("crmEntityTypeUid");
		if (value2 != null)
		{
			guid = Guid.Parse(value2.get_AttemptedValue());
		}
		if (guid.HasValue && result > 0)
		{
			Type typeByUid = Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUid(guid.Value);
			if (typeof(IContractor).IsAssignableFrom(typeByUid))
			{
				iCRMTaskBase.Contractor = ContractorManager.Instance.LoadOrNull(result);
			}
			if (typeof(IContact).IsAssignableFrom(typeByUid))
			{
				iCRMTaskBase.Contact = ContactManager.Instance.LoadOrNull(result);
			}
			if (typeof(ILead).IsAssignableFrom(typeByUid))
			{
				iCRMTaskBase.Lead = LeadManager.Instance.LoadOrNull(result);
			}
			if (typeof(ISale).IsAssignableFrom(typeByUid))
			{
				iCRMTaskBase.Sale = SaleManager.Instance.LoadOrNull(result);
			}
		}
	}
}
