using EleWise.ELMA.Model.Types.Settings;

namespace EleWise.ELMA.Web.Mvc.Models.Translate;

public class TranslateEditModel
{
	public string TrueKey { get; set; }

	[StringSettings(MultiLine = true)]
	public string CurrentValue { get; set; }

	[StringSettings(MultiLine = true)]
	public string TargetValue { get; set; }

	[StringSettings(MultiLine = true)]
	public string CurrentFormatValue { get; set; }

	[StringSettings(MultiLine = true)]
	public string TargetFormatValue { get; set; }

	public string CurrentLocal { get; set; }

	public string TargetLocal { get; set; }

	public bool Block { get; set; }
}
