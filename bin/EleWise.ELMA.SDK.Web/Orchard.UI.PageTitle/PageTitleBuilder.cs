using System.Collections.Generic;
using System.Linq;
using Orchard.Settings;

namespace Orchard.UI.PageTitle;

public class PageTitleBuilder : IPageTitleBuilder, IDependency
{
	private readonly ISiteService _siteService;

	private readonly List<string> _titleParts;

	private string _titleSeparator;

	public PageTitleBuilder(ISiteService siteService)
	{
		_siteService = siteService;
		_titleParts = new List<string>(5);
	}

	public void AddTitleParts(params string[] titleParts)
	{
		if (titleParts.Length == 0)
		{
			return;
		}
		foreach (string text in titleParts)
		{
			if (!string.IsNullOrEmpty(text))
			{
				_titleParts.Add(text);
			}
		}
	}

	public void AppendTitleParts(params string[] titleParts)
	{
		if (titleParts.Length == 0)
		{
			return;
		}
		foreach (string text in titleParts)
		{
			if (!string.IsNullOrEmpty(text))
			{
				_titleParts.Insert(0, text);
			}
		}
	}

	public string GenerateTitle()
	{
		if (_titleSeparator == null)
		{
			_titleSeparator = _siteService.GetSiteSettings().PageTitleSeparator;
		}
		if (_titleParts.Count != 0)
		{
			return string.Join(_titleSeparator, _titleParts.AsEnumerable().Reverse().ToArray());
		}
		return string.Empty;
	}
}
