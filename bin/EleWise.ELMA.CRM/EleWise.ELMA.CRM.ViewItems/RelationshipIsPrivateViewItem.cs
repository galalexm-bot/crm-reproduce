using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.CRM.ViewItems;

[Serializable]
[DisplayName(typeof(__Resources_RelationshipIsPrivateViewItem), "DisplayName")]
[ViewItemMetadata(Type = typeof(IRelationship))]
public class RelationshipIsPrivateViewItem : PropertyViewItem
{
	[Component]
	private class ToolboxItem : RelationshipViewItemToolboxItem<RelationshipIsPrivateViewItem>
	{
	}

	public RelationshipIsPrivateViewItem()
	{
		base.Attributes.Name = SR.T("Конфедициально");
	}
}
