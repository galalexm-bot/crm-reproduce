using System.Collections.Generic;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.Security.Models;

[FilterFor(typeof(IUserGroup))]
public interface IUserGroupFilter : IEntityFilter
{
	bool? AddToNewUser { get; set; }

	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[DisplayName("SR.M('Список возможных групп')")]
	[CustomFilterProperty]
	[Property("c77cd813-1dfb-4777-ab7e-87b54bd09e38")]
	[Uid("cdc37d3c-90d0-4b18-b736-670b0802ef9c")]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[AnyTypeSettings(FullTypeName = "System.Collections.Generic.List<EleWise.ELMA.Security.Models.Worker>")]
	List<Worker> Workers { get; set; }
}
