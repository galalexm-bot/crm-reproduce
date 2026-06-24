using System.Linq;
using Orchard.ContentManagement.Handlers;

namespace Orchard.ContentManagement.Drivers;

public class ContentTemplateResult : DriverResult
{
	public object Model { get; set; }

	public string TemplateName { get; set; }

	public string Prefix { get; set; }

	public string Zone { get; set; }

	public string Position { get; set; }

	public ContentTemplateResult(object model, string templateName, string prefix)
	{
		Model = model;
		TemplateName = templateName;
		Prefix = prefix;
	}

	public override void Apply(BuildDisplayContext context)
	{
		dynamic val = context.New.DisplayTemplate(TemplateName: TemplateName, Model: Model, Prefix: Prefix);
		context.Shape.Zones[Zone].Add(val, Position);
	}

	public override void Apply(BuildEditorContext context)
	{
		dynamic val = context.New.EditorTemplate(TemplateName: TemplateName, Model: Model, Prefix: Prefix);
		context.Shape.Zones[Zone].Add(val, Position);
	}

	public ContentTemplateResult Location(string zone)
	{
		Zone = zone;
		return this;
	}

	public ContentTemplateResult Location(string zone, string position)
	{
		Zone = zone;
		Position = position;
		return this;
	}

	public ContentTemplateResult Location(ContentLocation location)
	{
		if (location.Position == null)
		{
			return Location(location.Zone);
		}
		return Location(location.Zone, location.Position);
	}

	public ContentTemplateResult LongestMatch(string displayType, params string[] knownDisplayTypes)
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
