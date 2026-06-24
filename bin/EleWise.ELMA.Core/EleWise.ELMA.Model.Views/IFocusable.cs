using EleWise.ELMA.Model.Attributes;

namespace EleWise.ELMA.Model.Views;

[DynamicPropertyContainer]
public interface IFocusable
{
	[DynamicProperty(false)]
	FocusableType FocusableType { get; set; }

	bool FocusableEnabled { get; }
}
