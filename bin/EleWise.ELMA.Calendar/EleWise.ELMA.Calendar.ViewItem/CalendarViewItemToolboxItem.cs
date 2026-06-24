using System;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Model.Views.Toolbox;

namespace EleWise.ELMA.Calendar.ViewItems;

public abstract class CalendarViewItemToolboxItem<TViewItem> : ViewItemToolboxItem<TViewItem> where TViewItem : ViewItem
{
	public override Guid GroupUid => CalendarViewItemToolboxGroup.UID;
}
