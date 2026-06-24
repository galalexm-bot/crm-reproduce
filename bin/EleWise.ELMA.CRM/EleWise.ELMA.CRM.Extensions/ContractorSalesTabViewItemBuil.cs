using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.CRM.ViewItems;
using EleWise.ELMA.Model.Views.Builders;

namespace EleWise.ELMA.CRM.Extensions;

public class ContractorSalesTabViewItemBuilder<TM> : TabViewItemBuilder<TM, ContractorSalesTabViewItem, ContractorSalesTabViewItemBuilder<TM>> where TM : IContractor
{
	public ContractorSalesTabViewItemBuilder()
	{
	}

	internal ContractorSalesTabViewItemBuilder(ViewItemBuilder parentViewItemBuilder)
		: base(parentViewItemBuilder)
	{
		base.ViewItem.Caption = SR.T("Сделки");
	}
}
