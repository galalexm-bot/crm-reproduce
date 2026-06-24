using System;

namespace Orchard.ContentManagement.Handlers;

public class TemplateFilterForPart<TPart> : TemplateFilterBase<ContentPart> where TPart : ContentPart, new()
{
	private readonly string _prefix;

	private string _location = "Content";

	private string _position = "5";

	private readonly string _templateName;

	private string _groupId;

	public TemplateFilterForPart(string prefix, string templateName)
	{
		_prefix = prefix;
		_templateName = templateName;
	}

	public TemplateFilterForPart(string prefix, string templateName, string groupId)
	{
		_prefix = prefix;
		_templateName = templateName;
		_groupId = groupId;
	}

	public TemplateFilterForPart<TPart> Location(string location)
	{
		_location = location;
		return this;
	}

	public TemplateFilterForPart<TPart> Position(string position)
	{
		_position = position;
		return this;
	}

	public TemplateFilterForPart<TPart> Group(string groupId)
	{
		_groupId = groupId;
		return this;
	}

	protected override void BuildEditorShape(BuildEditorContext context, ContentPart part)
	{
		if (string.Equals(_groupId, context.GroupId, StringComparison.OrdinalIgnoreCase))
		{
			TPart val = part.As<TPart>();
			dynamic val2 = context.New.EditorTemplate(TemplateName: _templateName, Model: val, Prefix: _prefix);
			context.Shape.Zones[_location].Add(val2, _position);
		}
	}

	protected override void UpdateEditorShape(UpdateEditorContext context, ContentPart part)
	{
		if (string.Equals(_groupId, context.GroupId, StringComparison.OrdinalIgnoreCase))
		{
			TPart model = part.As<TPart>();
			context.Updater.TryUpdateModel(model, _prefix, null, null);
			BuildEditorShape(context, part);
		}
	}
}
