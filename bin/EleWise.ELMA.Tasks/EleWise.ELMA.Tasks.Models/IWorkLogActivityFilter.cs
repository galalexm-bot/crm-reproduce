using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.Tasks.Models;

[FilterFor(typeof(IWorkLogActivity))]
public interface IWorkLogActivityFilter : IEntityFilter
{
	string Name { get; set; }

	bool? AllObjectTypes { get; set; }

	[CustomFilterProperty]
	[Uid("7fef28b3-ab41-46ab-95fb-18e1bdcd4631")]
	[Property("5c281e64-ddc8-4bc9-991a-84d9dc4e7649")]
	[ListOfSimpleTypeSettings(SimpleTypeUidStr = "d90a59af-7e47-48c5-8c4c-dad04834e6e3", FieldName = "HideIds")]
	[DisplayName(typeof(__Resources_IWorkLogActivity), "FP_HideIds_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.ForceHidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	List<long> HideIds { get; set; }

	[CustomFilterProperty]
	[Uid("8a32a020-45b4-4888-8bae-860d63cbbd04")]
	[Order(1)]
	[CanBeNull]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[GuidSettings(FieldName = "EntityTypeUid")]
	[DisplayName(typeof(__Resources_IWorkLogActivity), "FP_EntityTypeUid_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	Guid? EntityTypeUid { get; set; }

	[CustomFilterProperty]
	[Uid("440c5388-4a99-4154-86ce-02bbf12431cc")]
	[Order(2)]
	[CanBeNull]
	[Property("9cd56a40-6192-4d8a-840c-c4bd4dfb88eb")]
	[BoolSettings(FieldName = "AllOrEntityTypeUid")]
	[DisplayName(typeof(__Resources_IWorkLogActivity), "FP_AllOrEntityTypeUid_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.ForceHidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	bool? AllOrEntityTypeUid { get; set; }
}
