using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.Workflow.Models;

[FilterFor(typeof(IWorkflowQueueItem))]
public interface IWorkflowQueueItemFilter : IEntityFilter
{
	IWorkflowInstance Instance { get; set; }

	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[NotNull]
	[Uid("11cb02b2-15c0-4789-b31f-5f1aa403c945")]
	[CustomFilterProperty]
	[DisplayName("SR.M('Статус выполнения \"Ошибка\" или \"Запланированно\" (ошибки в пред. запусках)')")]
	[BoolSettings(FieldName = "StatusExecutionError")]
	[Property("9cd56a40-6192-4d8a-840c-c4bd4dfb88eb")]
	bool StatusExecutionError { get; set; }

	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[DisplayName("SR.M('Статус выполнения \"выполняется\", \"В очереди\", \"Запланированно\" (запуски не производились)')")]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[Order(1)]
	[Uid("f88699ce-1194-4ad3-b909-860a426a9c24")]
	[CustomFilterProperty]
	[BoolSettings(FieldName = "StatusExecutionActive")]
	[Property("9cd56a40-6192-4d8a-840c-c4bd4dfb88eb")]
	[NotNull]
	bool StatusExecutionActive { get; set; }

	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[DisplayName("SR.M('Показать запланированные')")]
	[Order(2)]
	[Uid("7ca7feaa-f168-452b-b1a1-55db84da7369")]
	[CustomFilterProperty]
	[BoolSettings(DisplayType = BoolDisplayType.Checkbox, FieldName = "ShowExecuteProcessOnTimer")]
	[NotNull]
	[Property("9cd56a40-6192-4d8a-840c-c4bd4dfb88eb")]
	bool ShowTimer { get; set; }
}
