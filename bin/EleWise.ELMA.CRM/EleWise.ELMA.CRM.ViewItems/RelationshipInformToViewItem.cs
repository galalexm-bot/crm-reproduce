using System;
using System.Xml.Serialization;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.CRM.ViewItems;

[Serializable]
[DisplayName(typeof(__Resources_RelationshipInformToViewItem), "DisplayName")]
[ViewItemMetadata(Type = typeof(IRelationship))]
public class RelationshipInformToViewItem : PropertyViewItem
{
	[Component]
	private class ToolboxItem : RelationshipViewItemToolboxItem<RelationshipInformToViewItem>
	{
	}

	[XmlIgnore]
	public override Guid PropertyUid
	{
		get
		{
			return Guid.Empty;
		}
		set
		{
		}
	}

	public RelationshipInformToViewItem()
	{
		base.Attributes.Name = SR.T("Информировать");
	}
}
