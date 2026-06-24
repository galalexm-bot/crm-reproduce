using System.Collections.Generic;
using System.Globalization;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Web.Mvc.Models.Translate;

public class TranslateSettings
{
	public string TargetLocal { get; set; }

	public string CurrentLocal { get; set; }

	public bool TranslateEnabled
	{
		get
		{
			if (TranslateService.Instance.Initialized)
			{
				return TranslateService.Instance.IsTranslationModeEnabled();
			}
			return false;
		}
	}

	public List<CultureInfo> GetTragets()
	{
		return TranslateService.Instance.GetTargets();
	}
}
