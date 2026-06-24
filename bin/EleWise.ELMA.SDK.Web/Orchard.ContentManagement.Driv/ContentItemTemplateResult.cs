using System.Linq;
using System.Web.Mvc;
using Orchard.ContentManagement.Handlers;

namespace Orchard.ContentManagement.Drivers;

public class ContentItemTemplateResult<TContent> : DriverResult where TContent : class, IContent
{
	private class ViewDataContainer : IViewDataContainer
	{
		public ViewDataDictionary ViewData { get; set; }
	}

	public string TemplateName { get; set; }

	public ContentItemTemplateResult(string templateName)
	{
		TemplateName = templateName;
	}

	public override void Apply(BuildDisplayContext context)
	{
	}

	public override void Apply(BuildEditorContext context)
	{
	}

	public ContentItemTemplateResult<TContent> LongestMatch(string displayType, params string[] knownDisplayTypes)
	{
		if (string.IsNullOrEmpty(displayType))
		{
			return this;
		}
		string text = knownDisplayTypes.Aggregate("", (string best, string x) => (displayType.StartsWith(x) && x.Length > best.Length) ? x : best);
		if (string.IsNullOrEmpty(text))
		{
			return this;
		}
		TemplateName = TemplateName + "." + text;
		return this;
	}
}
