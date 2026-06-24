using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Ranges;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.CRM.Models;

[FilterFor(typeof(IMarketingEffect))]
public interface IMarketingEffectFilter : IMarketingBaseFilter, IEntityFilter
{
	IMarketingActivity MarketingActivity { get; set; }

	IMarketingEffectType EffectType { get; set; }

	[CustomFilterProperty]
	[Uid("fef34d3a-9e3d-466c-9413-4f773fa9d9d9")]
	[Property("6fbbca7c-a693-4791-902c-30b5984671a2")]
	[DateTimeSettings(FieldName = "DateRange")]
	[DisplayName(typeof(__Resources_IMarketingEffect), "FP_DateRange_DisplayName")]
	[View(ViewType = ViewType.Create, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Edit, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	[View(ViewType = ViewType.Display, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = true)]
	[View(ViewType = ViewType.List, ItemType = ItemType.Default, Visibility = Visibility.Hidden, ReadOnly = false)]
	[View(ViewType = ViewType.Filter, ItemType = ItemType.Default, Visibility = Visibility.Visible, ReadOnly = false)]
	DateTimeRange DateRange { get; set; }
}
