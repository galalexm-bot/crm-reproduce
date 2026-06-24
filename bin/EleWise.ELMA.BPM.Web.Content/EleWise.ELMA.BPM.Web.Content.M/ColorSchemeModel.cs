using EleWise.ELMA.Content.Models;
using EleWise.ELMA.Model.Entities;

namespace EleWise.ELMA.BPM.Web.Content.Models;

public class ColorSchemeModel : EntityModel<IColorScheme>
{
	public ColorSchemeSettingsModel ColorSchemeSettings { get; set; }

	public ColorSchemeModel(IColorScheme colorScheme)
		: base(colorScheme)
	{
		ColorSchemeSettings = ColorSchemeSettingsModel.FromColorScheme(colorScheme);
	}

	public ColorSchemeModel()
	{
		ColorSchemeSettings = new ColorSchemeSettingsModel();
	}
}
