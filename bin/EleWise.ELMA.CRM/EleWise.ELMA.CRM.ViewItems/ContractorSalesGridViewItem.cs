using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.CRM.ViewItems;

[Serializable]
[DisplayName(typeof(__Resources_ContractorSalesGridViewItem), "DisplayName")]
[ViewItemMetadata(Type = typeof(IContractor))]
public class ContractorSalesGridViewItem : ViewItem, ICountViewItem
{
	[Component(Order = 61)]
	private class ToolboxItem : CRMViewItemToolboxItem<ContractorSalesGridViewItem>
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
