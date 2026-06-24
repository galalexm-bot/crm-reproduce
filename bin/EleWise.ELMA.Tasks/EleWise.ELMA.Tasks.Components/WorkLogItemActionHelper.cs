using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.Tasks.Components;

public static class WorkLogItemActionHelper
{
	private static Lazy<List<Guid>> baseProperties;

	public static List<Guid> BaseProperties()
	{
		if (baseProperties == null)
		{
			baseProperties = new Lazy<List<Guid>>(() => (from p in ((ClassMetadata)MetadataLoader.LoadMetadata(InterfaceActivator.UID<IWorkLogItem>())).Properties
				where !p.ViewSettings.GetForView(ViewType.Edit).Visible
				select p.Uid).ToList());
		}
		return baseProperties.Value.ToList();
	}
}
