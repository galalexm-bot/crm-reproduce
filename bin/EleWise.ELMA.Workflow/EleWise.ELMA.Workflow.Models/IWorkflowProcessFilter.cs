using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.Workflow.Models;

[FilterFor(typeof(IWorkflowProcess))]
public interface IWorkflowProcessFilter : IEntityFilter
{
	IProcessHeader Header { get; set; }

	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[CustomFilterProperty]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[CanBeNull]
	[Uid("521a8e5e-8abb-4fb2-ae07-00bf1beac0e1")]
	[Property("9cd56a40-6192-4d8a-840c-c4bd4dfb88eb")]
	[DisplayName(typeof(__Resources_IWorkflowProcess), "FP_NonZeroVersion_DisplayName")]
	[BoolSettings(FieldName = "NonZeroVersion")]
	bool? NonZeroVersion { get; set; }
}
