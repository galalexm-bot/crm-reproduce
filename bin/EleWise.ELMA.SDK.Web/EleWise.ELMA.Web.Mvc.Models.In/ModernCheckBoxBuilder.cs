using System.Web.Mvc;

namespace EleWise.ELMA.Web.Mvc.Models.Inputs;

public class ModernCheckBoxBuilder : ModernCheckBoxBaseBuilder<ModernCheckBox, ModernCheckBoxBuilder>
{
	public ModernCheckBoxBuilder(ModernCheckBox component, HtmlHelper htmlHelper)
		: base(component, htmlHelper)
	{
	}

	public virtual ModernCheckBoxBuilder RenderUncheckedInput(bool renderUncheckedInput)
	{
		base.Component.RenderUncheckedInput = renderUncheckedInput;
		return this;
	}

	public virtual ModernCheckBoxBuilder UncheckedValue(object uncheckedValue)
	{
		base.Component.UncheckedValue = uncheckedValue;
		return this;
	}
}
