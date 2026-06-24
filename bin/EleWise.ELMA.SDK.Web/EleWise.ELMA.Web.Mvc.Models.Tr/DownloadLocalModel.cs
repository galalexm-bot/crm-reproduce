using System.Collections.Generic;
using System.Globalization;
using EleWise.ELMA.Model.Types.Validation;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Web.Mvc.Models.Translate;

public class DownloadLocalModel
{
	[RequiredField]
	public string DownloadedLocalId { get; set; }

	public string TargetLocal { get; set; }

	public string CurrentLocal { get; set; }

	public List<CultureInfo> GetTragets()
	{
		return TranslateService.Instance.GetTargets();
	}
}
