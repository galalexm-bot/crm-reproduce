using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.CRM.Components;

internal sealed class MarketingBaseActionHelper
{
	private static readonly string[] SkipProperties = new string[2] { "Status", "ArchiveDate" };

	public static List<Guid> BaseProperties()
	{
		return (from p in ((ClassMetadata)MetadataLoader.LoadMetadata(InterfaceActivator.UID<IMarketingBase>())).Properties
			where !p.ViewSettings.GetForView(ViewType.Edit).Visible && !SkipProperties.Contains(p.Name)
			select p.Uid).ToList();
	}
}
