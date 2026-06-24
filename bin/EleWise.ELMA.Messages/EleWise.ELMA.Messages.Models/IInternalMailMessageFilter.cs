using System;
using System.Collections.Generic;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.Messages.Models;

[FilterFor(typeof(IInternalMailMessage))]
public interface IInternalMailMessageFilter : IBaseMessageFilter, IEntityFilter
{
	Guid? ObjectUid { get; set; }

	Guid? ActionUid { get; set; }

	MessagePriority? Priority { get; set; }

	string ObjectId { get; set; }

	[CustomFilterProperty]
	[Uid("4ef8cc22-4d07-451d-995d-348a93e637ae")]
	[Property("5c281e64-ddc8-4bc9-991a-84d9dc4e7649")]
	[ListOfSimpleTypeSettings(SimpleTypeUidStr = "d90a59af-7e47-48c5-8c4c-dad04834e6e3", FieldName = "ObjectIds")]
	[DisplayName(typeof(__Resources_IInternalMailMessage), "FP_ObjectIds_DisplayName")]
	[Description(typeof(__Resources_IInternalMailMessage), "FP_ObjectIds_Description")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	List<long> ObjectIds { get; set; }
}
