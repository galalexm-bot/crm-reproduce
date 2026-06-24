using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.CRM.ViewItems;

[Serializable]
[DisplayName(typeof(__Resources_SaleInpaymentsGridViewItem), "DisplayName")]
[ViewItemMetadata(Type = typeof(ISale))]
public class SaleInpaymentsGridViewItem : ViewItem
{
	[Component(Order = 81)]
	private class ToolboxItem : CRMViewItemToolboxItem<SaleInpaymentsGridViewItem>
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
