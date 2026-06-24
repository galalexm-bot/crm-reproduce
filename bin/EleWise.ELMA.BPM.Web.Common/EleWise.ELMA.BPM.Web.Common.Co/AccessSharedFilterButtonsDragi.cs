using System;
using EleWise.ELMA.BPM.Web.Common.ExtensionPoints;
using EleWise.ELMA.BPM.Web.Common.Models;
using EleWise.ELMA.Common.Managers;
using EleWise.ELMA.Common.Models.Filters;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities.EntityReferences;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.BPM.Web.Common.Components;

[Component]
public class AccessSharedFilterButtonsDraging : IFilterTreeButtonsDraging
{
	private bool AccessSharedFilter(Guid typeUid, Guid? code)
	{
		return Locator.GetServiceNotNull<IContextBoundVariableService>().GetOrAdd($"AccessSharedFilterButtonsDraging_{typeUid}_{code}", delegate
		{
			ReferenceOnEntityType type = new ReferenceOnEntityType
			{
				TypeUid = typeUid
			};
			IFilterFolder filter = FilterFolderManager.Instance.LoadSharedFilterFolder(type, code);
			return FilterFolderManager.Instance.HasSharedFilterPermission(filter);
		});
	}

	public string DragStartCondition(FilterTreeEditModel model)
	{
		if (AccessSharedFilter(model.TypeUid, model.Code))
		{
			return "";
		}
		return "filterType == 'SharedFilter'";
	}

	public string DraggingCondition(FilterTreeEditModel model)
	{
		if (AccessSharedFilter(model.TypeUid, model.Code))
		{
			return "";
		}
		return "filterType == 'SharedFilter'";
	}
}
