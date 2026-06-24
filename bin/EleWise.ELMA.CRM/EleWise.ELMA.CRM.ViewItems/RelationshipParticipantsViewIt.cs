using System;
using System.Xml.Serialization;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.CRM.ViewItems;

[Serializable]
[DisplayName(typeof(__Resources_RelationshipParticipantsViewItem), "DisplayName")]
[ViewItemMetadata(Type = typeof(IRelationship))]
public class RelationshipParticipantsViewItem : PropertyViewItem
{
	[Component]
	private class ToolboxItem : RelationshipViewItemToolboxItem<RelationshipParticipantsViewItem>
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

	public RelationshipParticipantsViewItem()
	{
		base.Attributes.Name = SR.T("Участники");
	}
}
