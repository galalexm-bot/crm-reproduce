using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.CRM.ViewItems;

[Serializable]
[DisplayName(typeof(__Resources_LeadContactsGridViewItem), "DisplayName")]
[ViewItemMetadata(Type = typeof(ILead))]
public class LeadContactsGridViewItem : ViewItem
{
	[Component(Order = 91)]
	private class ToolboxItem : CRMViewItemToolboxItem<LeadContactsGridViewItem>
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
