using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web.Mvc;

namespace EleWise.ELMA.BPM.Web.Security.Models;

public class LanguageSelectorModel
{
	private Lazy<List<SelectListItem>> _cultures;

	public long UserId { get; set; }

	public string SelectedCulture { get; set; }

	public List<SelectListItem> AllCultures
	{
		get
		{
			if (_cultures == null)
			{
				_cultures = new Lazy<List<SelectListItem>>(() => ((IEnumerable<CultureInfo>)SR.GetCultureNames()).Select((Func<CultureInfo, SelectListItem>)delegate(CultureInfo c)
				{
					//IL_0000: Unknown result type (might be due to invalid IL or missing references)
					//IL_0005: Unknown result type (might be due to invalid IL or missing references)
					//IL_0031: Unknown result type (might be due to invalid IL or missing references)
					//IL_003e: Expected O, but got Unknown
					SelectListItem val = new SelectListItem();
					val.set_Text((!string.IsNullOrEmpty(c.NativeName)) ? c.TextInfo.ToTitleCase(c.NativeName) : c.EnglishName);
					val.set_Value(c.Name);
					return val;
				}).ToList());
			}
			return _cultures.Value;
		}
	}
}
