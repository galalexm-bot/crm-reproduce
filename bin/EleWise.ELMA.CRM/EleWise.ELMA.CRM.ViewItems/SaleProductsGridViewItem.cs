using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.CRM.ViewItems;

[Serializable]
[DisplayName(typeof(__Resources_SaleProductsGridViewItem), "DisplayName")]
[ViewItemMetadata(Type = typeof(ISale))]
public class SaleProductsGridViewItem : ViewItem, ICountViewItem
{
	[Component(Order = 51)]
	private class ToolboxItem : CRMViewItemToolboxItem<SaleProductsGridViewItem>
	{
	}

	public bool ShowCount => true;

	public override bool IsValid(ViewType viewType, ViewItem parentViewItem)
	{
		return parentViewItem?.IsChildValid(this) ?? true;
	}

	public override bool IsChildValid(ViewItem childViewItem)
	{
		return true;
	}
}
