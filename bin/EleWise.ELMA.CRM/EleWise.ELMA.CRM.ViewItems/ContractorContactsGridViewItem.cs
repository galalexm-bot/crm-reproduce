using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.CRM.ViewItems;

[Serializable]
[DisplayName(typeof(__Resources_ContractorContactsGridViewItem), "DisplayName")]
[ViewItemMetadata(Type = typeof(IContractor))]
public class ContractorContactsGridViewItem : ViewItem
{
	[Component(Order = 41)]
	private class ToolboxItem : CRMViewItemToolboxItem<ContractorContactsGridViewItem>
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
