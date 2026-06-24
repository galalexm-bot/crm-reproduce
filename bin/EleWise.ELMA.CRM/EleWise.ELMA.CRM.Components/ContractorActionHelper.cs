using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.CRM.Components;

internal class ContractorActionHelper
{
	private static Lazy<List<Guid>> baseProperties;

	public static List<Guid> BaseProperties()
	{
		if (baseProperties == null)
		{
			baseProperties = new Lazy<List<Guid>>(() => (from p in ((ClassMetadata)MetadataLoader.LoadMetadata(InterfaceActivator.UID<IContractor>())).Properties
				where !p.ViewSettings.GetForView(ViewType.Edit).Visible && (p.Name == "ChangeDate" || p.Name == "ChangeAuthor")
				select p.Uid).ToList());
		}
		return baseProperties.Value;
	}
}
