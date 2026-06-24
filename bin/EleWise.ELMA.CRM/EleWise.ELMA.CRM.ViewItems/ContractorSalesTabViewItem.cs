using System;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.CRM.ViewItems;

[Serializable]
[DisplayName(typeof(__Resources_ContractorSalesGridViewItem), "TabDisplayName")]
[ViewItemMetadata(Type = typeof(IContractor))]
[Obsolete("Use TabViewItem instead", false)]
public class ContractorSalesTabViewItem : TabViewItem
{
	public ContractorSalesTabViewItem()
	{
		Caption = SR.T("Сделки");
	}
}
