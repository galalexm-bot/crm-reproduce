using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.CRM.ViewItems;
using EleWise.ELMA.Model.Views.Builders;

namespace EleWise.ELMA.CRM.Extensions;

public class PermissionGridViewItemBuilder<TM> : ViewItemBuilder<TM, PermissionGridViewItem, PermissionGridViewItemBuilder<TM>> where TM : IContractor
{
	public PermissionGridViewItemBuilder()
	{
	}

	internal PermissionGridViewItemBuilder(ViewItemBuilder parentViewItemBuilder)
		: base(parentViewItemBuilder)
	{
	}
}
