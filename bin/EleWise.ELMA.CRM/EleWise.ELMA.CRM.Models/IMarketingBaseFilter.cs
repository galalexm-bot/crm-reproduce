using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Ranges;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.CRM.Models;

[FilterFor(typeof(IMarketingBase))]
public interface IMarketingBaseFilter : IEntityFilter
{
	string Name { get; set; }

	DateTimeRange CreationDate { get; set; }

	IUser CreationAuthor { get; set; }

	IUser Responsible { get; set; }

	MarketingObjectStatus? Status { get; set; }

	[CustomFilterProperty]
	[Uid("8910c10c-18b3-41c0-bbe3-5c4296900346")]
	[CanBeNull]
	[Property("eb6e8ddc-fafe-4e0e-9018-1a7667012579")]
	[GuidSettings(FieldName = "TypeUid")]
	[DisplayName(typeof(__Resources_IMarketingBase), "FP_TypeUid_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.ForceHidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	Guid? TypeUid { get; set; }
}
