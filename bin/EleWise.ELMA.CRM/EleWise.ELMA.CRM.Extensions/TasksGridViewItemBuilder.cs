using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.CRM.ViewItems;
using EleWise.ELMA.Model.Views.Builders;

namespace EleWise.ELMA.CRM.Extensions;

public class TasksGridViewItemBuilder<TM> : ViewItemBuilder<TM, TasksGridViewItem, TasksGridViewItemBuilder<TM>> where TM : IContractor
{
	public TasksGridViewItemBuilder()
	{
	}

	internal TasksGridViewItemBuilder(ViewItemBuilder parentViewItemBuilder)
		: base(parentViewItemBuilder)
	{
	}
}
