using EleWise.ELMA.Globalization;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Web.Mvc.Models.Translate;

public class PoRowModel
{
	private LocalizationHolder _current;

	public string FileName { get; set; }

	public string CurrentLocal { get; set; }

	public string TargetLocal { get; set; }

	public string Key { get; set; }

	public PoLineDescriptor CurrentLine { get; set; }

	public PoLineDescriptor TargetLine { get; set; }

	public LocalizationHolder Current => _current ?? (_current = TranslateService.Instance.GetTranslation(CurrentLocal));
}
