using EleWise.ELMA.Model.Attributes;

namespace EleWise.ELMA.Model.Views;

[DynamicPropertyContainer]
public interface IGridColumnViewItem : IViewItem, IReactive
{
	WidthType WidthType { get; set; }

	[DynamicProperty(false)]
	int? Width { get; set; }
}
