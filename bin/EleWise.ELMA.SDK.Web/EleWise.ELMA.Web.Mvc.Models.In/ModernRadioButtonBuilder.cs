using System.Web.Mvc;

namespace EleWise.ELMA.Web.Mvc.Models.Inputs;

public class ModernRadioButtonBuilder : ModernCheckBoxBaseBuilder<ModernRadioButton, ModernRadioButtonBuilder>
{
	public ModernRadioButtonBuilder(ModernRadioButton component, HtmlHelper htmlHelper)
		: base(component, htmlHelper)
	{
	}
}
