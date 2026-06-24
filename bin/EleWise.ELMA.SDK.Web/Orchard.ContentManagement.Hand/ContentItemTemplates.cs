using System;
using System.Linq;
using System.Web.Mvc;

namespace Orchard.ContentManagement.Handlers;

public class ContentItemTemplates<TContent> : TemplateFilterBase<TContent> where TContent : class, IContent
{
	private class ViewDataContainer : IViewDataContainer
	{
		public ViewDataDictionary ViewData { get; set; }
	}

	private readonly string _templateName;

	private readonly string[] _displayTypes;

	private Action<UpdateEditorContext, IContent> _updater;

	public ContentItemTemplates(string templateName)
		: this(templateName, "")
	{
	}

	public ContentItemTemplates(string templateName, string displayTypes)
	{
		_templateName = templateName;
		_displayTypes = (displayTypes ?? "").Split(new char[1] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
		_updater = delegate(UpdateEditorContext context, IContent viewModel)
		{
			context.Updater.TryUpdateModel(viewModel, "", null, null);
		};
	}

	protected override void BuildDisplayShape(BuildDisplayContext context, TContent instance)
	{
	}

	private string LongestMatch(string displayType)
	{
		if (string.IsNullOrEmpty(displayType))
		{
			return displayType;
		}
		return _displayTypes.Aggregate("", (string best, string x) => (displayType.StartsWith(x) && x.Length > best.Length) ? x : best);
	}

	protected override void BuildEditorShape(BuildEditorContext context, TContent instance)
	{
	}

	protected override void UpdateEditorShape(UpdateEditorContext context, TContent instance)
	{
	}

	public void Updater(Action<UpdateEditorContext, IContent> updater)
	{
		_updater = updater;
	}
}
