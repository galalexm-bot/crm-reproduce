using System.Web.Mvc;

namespace EleWise.ELMA.Web.Mvc.Models.Inputs;

public class ModernSwitchButtonBuilder : ModernCheckBoxBaseBuilder<ModernSwitchButton, ModernSwitchButtonBuilder>
{
	public ModernSwitchButtonBuilder(ModernSwitchButton component, HtmlHelper htmlHelper)
		: base(component, htmlHelper)
	{
	}

	public virtual ModernSwitchButtonBuilder RenderUncheckedInput(bool renderUncheckedInput)
	{
		base.Component.RenderUncheckedInput = renderUncheckedInput;
		return this;
	}

	public virtual ModernSwitchButtonBuilder UncheckedValue(object uncheckedValue)
	{
		base.Component.UncheckedValue = uncheckedValue;
		return this;
	}

	public virtual ModernSwitchButtonBuilder TextPosition(ModernSwitchButton.LabelPosition position)
	{
		base.Component.TextPosition = position;
		return this;
	}
}
