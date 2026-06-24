using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.CRM.ViewItems;

[Serializable]
[DisplayName(typeof(__Resources_RelationshipContactInfoViewItem), "TabDisplayName")]
[ViewItemMetadata(Type = typeof(IRelationship))]
public class RelationshipContactInfoTabViewItem : TabViewItem
{
	[Component]
	private class ToolboxItem : RelationshipViewItemToolboxItem<RelationshipContactInfoTabViewItem>
	{
	}

	public RelationshipContactInfoTabViewItem()
	{
		Caption = SR.T("Контактная информация");
	}
}
