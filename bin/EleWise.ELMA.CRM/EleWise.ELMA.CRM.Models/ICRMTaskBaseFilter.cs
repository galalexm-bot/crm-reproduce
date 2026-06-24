using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.CRM.Models;

[FilterFor(typeof(ICRMTaskBase))]
public interface ICRMTaskBaseFilter : ITaskBaseFilter, IEntityFilter
{
	IContractor Contractor { get; set; }

	IContact Contact { get; set; }

	ILead Lead { get; set; }

	ISale Sale { get; set; }

	[CustomFilterProperty]
	[Uid("3e704ade-5b91-4fa1-b260-768956e5f8b0")]
	[NotNull]
	[Property("9cd56a40-6192-4d8a-840c-c4bd4dfb88eb")]
	[BoolSettings(FieldName = "FilterByEntity")]
	[DisplayName(typeof(__Resources_ICRMTaskBase), "FP_FilterByEntity_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	bool FilterByEntity { get; set; }
}
