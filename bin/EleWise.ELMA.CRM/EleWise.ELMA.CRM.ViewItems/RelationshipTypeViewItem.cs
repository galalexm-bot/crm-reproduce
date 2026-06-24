using System;
using System.Xml.Serialization;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.CRM.ViewItems;

[Serializable]
[DisplayName(typeof(__Resources_RelationshipTypeViewItem), "DisplayName")]
[ViewItemMetadata(Type = typeof(IRelationship))]
public class RelationshipTypeViewItem : PropertyViewItem
{
	[Component]
	private class ToolboxItem : RelationshipViewItemToolboxItem<RelationshipTypeViewItem>
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

	public RelationshipTypeViewItem()
	{
		base.Attributes.Name = SR.T("Тип");
		base.Attributes.ReadOnly = true;
	}
}
