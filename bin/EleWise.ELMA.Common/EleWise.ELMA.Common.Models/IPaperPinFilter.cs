using System;
using System.Collections.Generic;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.Common.Models;

[FilterFor(typeof(IPaperPin))]
public interface IPaperPinFilter : IEntityFilter
{
	Guid? TypeUid { get; set; }

	IUser User { get; set; }

	string EntityId { get; set; }

	[CustomFilterProperty]
	[Uid("d8f93814-fe1a-4cdb-ab7d-70856802d1e4")]
	[Property("5c281e64-ddc8-4bc9-991a-84d9dc4e7649")]
	[ListOfSimpleTypeSettings(SimpleTypeUidStr = "eb6e8ddc-fafe-4e0e-9018-1a7667012579", FieldName = "TypeUids")]
	[DisplayName(typeof(__Resources_IPaperPin), "FP_TypeUids_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	List<Guid> TypeUids { get; set; }
}
