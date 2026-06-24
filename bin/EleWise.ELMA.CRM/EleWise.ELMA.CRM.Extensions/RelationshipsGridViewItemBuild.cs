using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.CRM.ViewItems;
using EleWise.ELMA.Model.Views.Builders;

namespace EleWise.ELMA.CRM.Extensions;

public class RelationshipsGridViewItemBuilder<TM> : ViewItemBuilder<TM, RelationshipsGridViewItem, RelationshipsGridViewItemBuilder<TM>> where TM : IContractor
{
	public RelationshipsGridViewItemBuilder()
	{
	}

	internal RelationshipsGridViewItemBuilder(ViewItemBuilder parentViewItemBuilder)
		: base(parentViewItemBuilder)
	{
	}
}
