using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.CRM.Components;

internal sealed class RelationshipActionHelper
{
	private static List<Guid> baseProperties;

	public static List<Guid> BaseProperties()
	{
		if (baseProperties == null)
		{
			baseProperties = (from p in ((ClassMetadata)MetadataLoader.LoadMetadata(InterfaceActivator.UID<IRelationship>())).Properties
				where !p.ViewSettings.GetForView(ViewType.Edit).Visible && (p.Name == "ChangeDate" || p.Name == "RelationshipUsersHash" || p.Name == "ChangeAuthor")
				select p.Uid).ToList();
		}
		return baseProperties;
	}
}
