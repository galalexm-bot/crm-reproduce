using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.CRM.ViewItems;
using EleWise.ELMA.Model.Views.Builders;

namespace EleWise.ELMA.CRM.Extensions;

public class ContractorSalesGridViewItemBuilder<TM> : ViewItemBuilder<TM, ContractorSalesGridViewItem, ContractorSalesGridViewItemBuilder<TM>> where TM : IContractor
{
	public ContractorSalesGridViewItemBuilder()
	{
	}

	internal ContractorSalesGridViewItemBuilder(ViewItemBuilder parentViewItemBuilder)
		: base(parentViewItemBuilder)
	{
	}
}
