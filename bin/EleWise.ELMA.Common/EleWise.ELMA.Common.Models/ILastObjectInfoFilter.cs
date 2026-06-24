using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities.EntityReferences;
using EleWise.ELMA.Model.Ranges;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.Common.Models;

[FilterFor(typeof(ILastObjectInfo))]
public interface ILastObjectInfoFilter : IEntityFilter
{
	IUser User { get; set; }

	ReferenceOnEntity Object { get; set; }

	DateTimeRange CreationDate { get; set; }

	DateTimeRange ChangeDate { get; set; }

	ReferenceOnEntityType ObjectType { get; set; }

	ReferenceOnEntityType RealObjectType { get; set; }

	[CustomFilterProperty]
	[Uid("3c076187-7363-4eb6-ae65-fc154fa0e16b")]
	[Property("c77cd813-1dfb-4777-ab7e-87b54bd09e38")]
	[AnyTypeSettings(FullTypeName = "System.Collections.Generic.List<System.Guid>")]
	[DisplayName(typeof(__Resources_ILastObjectInfo), "FP_ObjectTypes_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	List<Guid> ObjectTypes { get; set; }

	[CustomFilterProperty]
	[Uid("e1afe12d-7c72-4a9e-81c5-3174d0f9b4f8")]
	[Order(1)]
	[Property("c77cd813-1dfb-4777-ab7e-87b54bd09e38")]
	[AnyTypeSettings(FullTypeName = "System.Collections.Generic.List<System.Guid>")]
	[DisplayName(typeof(__Resources_ILastObjectInfo), "FP_RealObjectTypes_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	List<Guid> RealObjectTypes { get; set; }

	[CustomFilterProperty]
	[Uid("64caf442-4803-4cd1-b5ab-464796356b8c")]
	[Order(2)]
	[CanBeNull]
	[Property("9cd56a40-6192-4d8a-840c-c4bd4dfb88eb")]
	[BoolSettings(FieldName = "UniqueObjects")]
	[DisplayName(typeof(__Resources_ILastObjectInfo), "FP_UniqueObjects_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	bool? UniqueObjects { get; set; }
}
