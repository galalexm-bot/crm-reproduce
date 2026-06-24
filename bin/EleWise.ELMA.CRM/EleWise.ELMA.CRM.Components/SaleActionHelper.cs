using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.CRM.Components;

internal sealed class SaleActionHelper
{
	private static List<Guid> baseProperties;

	public static List<Guid> BaseProperties()
	{
		if (baseProperties == null)
		{
			baseProperties = (from p in ((ClassMetadata)MetadataLoader.LoadMetadata(InterfaceActivator.UID<ISale>())).Properties
				where !p.ViewSettings.GetForView(ViewType.Edit).Visible || p.Name == "StatusChangeDate" || p.Name == "StatusChangeComment" || p.Name == "StageChangeDate" || p.Name == "StageChangeComment"
				select p.Uid).ToList();
		}
		return baseProperties;
	}
}
