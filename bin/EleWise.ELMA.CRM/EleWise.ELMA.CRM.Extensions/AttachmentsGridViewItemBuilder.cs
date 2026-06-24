using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.CRM.ViewItems;
using EleWise.ELMA.Model.Views.Builders;

namespace EleWise.ELMA.CRM.Extensions;

public class AttachmentsGridViewItemBuilder<TM> : ViewItemBuilder<TM, AttachmentsGridViewItem, AttachmentsGridViewItemBuilder<TM>> where TM : IContractor
{
	public AttachmentsGridViewItemBuilder()
	{
	}

	internal AttachmentsGridViewItemBuilder(ViewItemBuilder parentViewItemBuilder)
		: base(parentViewItemBuilder)
	{
	}
}
