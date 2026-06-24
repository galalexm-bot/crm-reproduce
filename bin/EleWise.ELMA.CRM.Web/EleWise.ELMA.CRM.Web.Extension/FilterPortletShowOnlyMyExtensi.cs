using System;
using EleWise.ELMA.BPM.Web.Common.ExtensionPoints;
using EleWise.ELMA.BPM.Web.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Model.Services;

namespace EleWise.ELMA.CRM.Web.Extensions;

[Component]
public class FilterPortletShowOnlyMyExtensions : IFilterPortletShowOnlyMy
{
	public bool SetShowOnlyMy(FilterModel filterModel, bool showOnlyMy)
	{
		if (filterModel.FilterTypeUid == InterfaceActivator.UID<IContractor>())
		{
			((IContractorFilter)filterModel.Filter).ShowOnlyMy = showOnlyMy;
			return true;
		}
		if (filterModel.FilterTypeUid == InterfaceActivator.UID<IContact>())
		{
			((IContactFilter)filterModel.Filter).ShowOnlyMy = showOnlyMy;
			return true;
		}
		if (filterModel.FilterTypeUid == InterfaceActivator.UID<ILead>())
		{
			((ILeadFilter)filterModel.Filter).ShowOnlyMy = showOnlyMy;
			return true;
		}
		if (filterModel.FilterTypeUid == InterfaceActivator.UID<ISale>())
		{
			((ISaleFilter)filterModel.Filter).ShowOnlyMy = showOnlyMy;
			return true;
		}
		return false;
	}

	public bool CheckShowOnlyMy(Guid TypeUid)
	{
		if (!(TypeUid == InterfaceActivator.UID<IContractor>()) && !(TypeUid == InterfaceActivator.UID<IContact>()) && !(TypeUid == InterfaceActivator.UID<ILead>()))
		{
			return TypeUid == InterfaceActivator.UID<ISale>();
		}
		return true;
	}
}
