using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using EleWise.ELMA.Model.Types.Validation;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Web.Mvc.Models.Translate;

public class CreateLocalModel
{
	[RequiredField]
	public string LocalId { get; set; }

	public string TargetLocal { get; set; }

	public string CurrentLocal { get; set; }

	public string BaseLanguage { get; set; }

	public bool SetToTarget { get; set; }

	public List<CultureInfo> GetTragets()
	{
		return TranslateService.Instance.GetTargets();
	}

	public List<CultureInfo> GetBaseLocals()
	{
		List<CultureInfo> installedCultures = SR.GetCultureNames();
		return (from c in SR.LanguagesMap.AllBaseCultureInfo()
			where installedCultures.Any((CultureInfo ic) => ic.Name.Equals(c.Name, StringComparison.OrdinalIgnoreCase))
			select c).ToList();
	}

	public CreateLocalModel()
	{
		SetToTarget = true;
	}
}
