using System;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Model.Views.Toolbox;

namespace EleWise.ELMA.Tasks.ViewItems;

public abstract class WorkLogViewItemToolboxItem<TViewItem> : ViewItemToolboxItem<TViewItem> where TViewItem : ViewItem
{
	public override Guid GroupUid => TasksViewItemToolboxGroup.UID;
}
