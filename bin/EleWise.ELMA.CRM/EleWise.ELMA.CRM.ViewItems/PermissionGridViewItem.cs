using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.CRM.ViewItems;

[Serializable]
[DisplayName(typeof(__Resources_PermissionGridViewItem), "DisplayName")]
[ViewItemMetadata(Type = typeof(IContractor))]
[ViewItemMetadata(Type = typeof(IContact))]
[ViewItemMetadata(Type = typeof(ILead))]
[ViewItemMetadata(Type = typeof(ISale))]
[ViewItemMetadata(Type = typeof(IRelationship))]
public class PermissionGridViewItem : ViewItem
{
	[Component(Order = 81)]
	private class ToolboxItem : CRMViewItemToolboxItem<PermissionGridViewItem>
	{
	}

	public override bool IsValid(ViewType viewType, ViewItem parentViewItem)
	{
		return parentViewItem?.IsChildValid(this) ?? true;
	}

	public override bool IsChildValid(ViewItem childViewItem)
	{
		return true;
	}
}
