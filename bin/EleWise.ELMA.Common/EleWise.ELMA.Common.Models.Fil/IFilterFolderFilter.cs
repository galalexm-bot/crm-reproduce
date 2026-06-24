using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities.EntityReferences;
using EleWise.ELMA.Model.Ranges;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.Common.Models.Filters;

[FilterFor(typeof(IFilterFolder))]
public interface IFilterFolderFilter : IEntityFilter
{
	string Name { get; set; }

	ReferenceOnEntityType ObjectsType { get; set; }

	IFilterFolder ParentFolder { get; set; }

	FilterType? FilterType { get; set; }

	Int64Range Weight { get; set; }

	Guid? Code { get; set; }

	[CustomFilterProperty]
	[Uid("37b09be6-b96e-4237-ac1b-5553a6dc40c1")]
	[CanBeNull]
	[Property("9cd56a40-6192-4d8a-840c-c4bd4dfb88eb")]
	[BoolSettings(FieldName = "ParentIsNull")]
	[DisplayName(typeof(__Resources_IFilterFolder), "FP_ParentIsNull_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.ForceHidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	bool? ParentIsNull { get; set; }

	[CustomFilterProperty]
	[Uid("74f70e88-4c4f-4012-a276-eef3c7543cc9")]
	[Order(1)]
	[CanBeNull]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[GuidSettings(FieldName = "TypeUid")]
	[DisplayName(typeof(__Resources_IFilterFolder), "FP_TypeUid_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.ForceHidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	Guid? TypeUid { get; set; }
}
