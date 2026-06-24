using Bridge.React;
using EleWise.ELMA.Core.React.Models;

namespace EleWise.ELMA.Core.React.Views;

public sealed class OuterWrapperComponent : WrapperComponent
{
	public OuterWrapperComponent(IReactInputModel<WrapperComponentInputs> model)
		: base(model)
	{
	}

	public override ReactElement View()
	{
		return OuterWrap(Context.ViewItem.Invoke(), Context.SlotName?.Invoke(), Context.Content.Invoke());
	}
}
