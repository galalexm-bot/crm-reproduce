using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.Messages.Models;

[FilterFor(typeof(IInformationChannel))]
public interface IInformationChannelFilter : IEntityFilter
{
	string Name { get; set; }

	bool? IsActive { get; set; }

	string Description { get; set; }

	string DisplayName { get; set; }

	Guid? GroupUid { get; set; }

	bool? IsArchive { get; set; }

	[CustomFilterProperty]
	[Uid("71363d66-0687-4d82-bbc1-ae89ad05e8eb")]
	[NotNull]
	[Property("9cd56a40-6192-4d8a-840c-c4bd4dfb88eb")]
	[BoolSettings(FieldName = "Assigned")]
	[DisplayName(typeof(__Resources_IInformationChannel), "FP_Assigned_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	bool Assigned { get; set; }

	[CustomFilterProperty]
	[Uid("9ee0adab-9a4c-40ec-b9f3-98c7c00d8ad0")]
	[Order(1)]
	[CanBeNull]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[GuidSettings(FieldName = "NotGroupUid")]
	[DisplayName(typeof(__Resources_IInformationChannel), "FP_NotGroupUid_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	Guid? NotGroupUid { get; set; }

	[CustomFilterProperty]
	[Uid("e3c72f47-ddd9-4c0b-abdf-886cdd752ad4")]
	[Order(2)]
	[Property("5c281e64-ddc8-4bc9-991a-84d9dc4e7649")]
	[ListOfSimpleTypeSettings(SimpleTypeUidStr = "d90a59af-7e47-48c5-8c4c-dad04834e6e3", FieldName = "WithoutIds")]
	[DisplayName(typeof(__Resources_IInformationChannel), "FP_WithoutIds_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.ForceHidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	List<long> WithoutIds { get; set; }

	[CustomFilterProperty]
	[Uid("a3c10860-6b39-425f-908c-06444b2c932d")]
	[Order(3)]
	[Property("5c281e64-ddc8-4bc9-991a-84d9dc4e7649")]
	[ListOfSimpleTypeSettings(SimpleTypeUidStr = "d90a59af-7e47-48c5-8c4c-dad04834e6e3", FieldName = "Ids")]
	[DisplayName(typeof(__Resources_IInformationChannel), "FP_Ids_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.ForceHidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	List<long> Ids { get; set; }
}
