using EleWise.ELMA.Model.Attributes;

namespace EleWise.ELMA.Model.Views;

[DynamicPropertyContainer]
public interface ITooltipViewItem : IViewItem, IReactive
{
	[DynamicProperty(false)]
	string Tooltip { get; set; }
}
