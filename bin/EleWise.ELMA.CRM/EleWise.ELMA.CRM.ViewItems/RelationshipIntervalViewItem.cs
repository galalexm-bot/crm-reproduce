using System;
using System.Xml.Serialization;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.CRM.ViewItems;

[Serializable]
[DisplayName(typeof(__Resources_RelationshipIntervalViewItem), "DisplayName")]
[ViewItemMetadata(Type = typeof(IRelationship))]
public class RelationshipIntervalViewItem : PropertyViewItem
{
	[Component]
	private class ToolboxItem : RelationshipViewItemToolboxItem<RelationshipIntervalViewItem>
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

	public RelationshipIntervalViewItem()
	{
		base.Attributes.Name = SR.T("Период");
	}
}
