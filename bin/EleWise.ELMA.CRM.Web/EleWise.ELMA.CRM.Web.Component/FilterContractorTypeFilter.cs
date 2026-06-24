using System;
using EleWise.ELMA.Common.ExtensionPoints;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.CRM.Web.Attributes;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;

namespace EleWise.ELMA.CRM.Web.Components;

[Component]
public class FilterContractorTypeFilter : IFilterTypeFilter
{
	public Guid EntityTypeUid => InterfaceActivator.UID<IContractor>();

	public Func<ClassMetadata, bool> GetFilter()
	{
		return delegate(ClassMetadata md)
		{
			UIExtensions.SearchAction<ContractorCreateAttribute>(md.Uid, out var actionName, out var controllerName, out var _, out var _);
			return !string.IsNullOrEmpty(actionName) && !string.IsNullOrEmpty(controllerName);
		};
	}
}
