using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.CRM.ViewItems;
using EleWise.ELMA.Model.Views.Builders;

namespace EleWise.ELMA.CRM.Extensions;

public class ContractorContactsGridViewItemBuilder<TM> : ViewItemBuilder<TM, ContractorContactsGridViewItem, ContractorContactsGridViewItemBuilder<TM>> where TM : IContractor
{
	public ContractorContactsGridViewItemBuilder()
	{
	}

	internal ContractorContactsGridViewItemBuilder(ViewItemBuilder parentViewItemBuilder)
		: base(parentViewItemBuilder)
	{
	}
}
