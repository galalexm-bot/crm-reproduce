using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Model.Views.Toolbox;

namespace EleWise.ELMA.Tasks.ViewItems;

[Component(Order = 100)]
internal abstract class TaskBaseViewItemToolboxItem<TViewItem> : ViewItemToolboxItem<TViewItem> where TViewItem : ViewItem
{
	public override Guid GroupUid => TasksViewItemToolboxGroup.UID;
}
