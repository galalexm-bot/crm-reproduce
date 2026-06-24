using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Managers;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Modules;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.CRM.Components;

[Component]
internal class DublicateLeadCheckStart : IModuleContainerEvents
{
	public void Init()
	{
	}

	public void InitComplete()
	{
	}

	public void Activated()
	{
		if (Locator.GetServiceNotNull<CrmSettingsModule>().Settings.LeadSearchDublicate)
		{
			LeadDublicateStateManager.Instance.GetLeads4CheckDublicate().ForEach(LeadManager.Instance.CheckDublicateLeadInternal);
		}
	}

	public void Terminating()
	{
	}
}
