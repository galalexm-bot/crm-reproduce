using EleWise.ELMA.Model.Attributes;

namespace EleWise.ELMA.Model.Views;

[DynamicPropertyContainer]
public interface IReadOnlyViewItem
{
	[DynamicProperty(false)]
	bool? ReadOnly { get; set; }

	bool ReadOnlyEnabled { get; }
}
