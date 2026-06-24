using System;
using EleWise.ELMA.BPM.Web.Common.ExtensionPoints;
using EleWise.ELMA.BPM.Web.Common.Extensions;
using EleWise.ELMA.BPM.Web.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Content;
using EleWise.ELMA.Workflow.Models;

namespace EleWise.ELMA.Workflow.Processes.Web.Extensions;

[Component(Order = 100)]
public class FilterPortletFilterTypeTitleExtensions : IFilterPortletFilterTypeTitle
{
	public bool AvailableType(Guid TypeUid)
	{
		return TypeUid == InterfaceActivator.UID<IWorkflowInstance>();
	}

	public string GetTitle(Guid TypeUid, Guid? Code)
	{
		string displayName = ((ClassMetadata)MetadataLoader.LoadMetadata(TypeUid)).DisplayName;
		try
		{
			FilterMenuItem filterMenuItem = Locator.GetServiceNotNull<FilterMenuProvider>().FilterMenuItemByTypeUidandCode(TypeUid, Code);
			ContentAction contentAction = Locator.GetServiceNotNull<ControllerActionRegistry>().Action(filterMenuItem.Routes);
			return $"{displayName} ({contentAction.Name})";
		}
		catch
		{
			return $"{displayName} ({Code})";
		}
	}
}
