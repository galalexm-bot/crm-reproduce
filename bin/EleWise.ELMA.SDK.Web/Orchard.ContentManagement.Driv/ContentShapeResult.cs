using System;
using Orchard.ContentManagement.Handlers;
using Orchard.DisplayManagement.Descriptors;
using Orchard.DisplayManagement.Shapes;

namespace Orchard.ContentManagement.Drivers;

public class ContentShapeResult : DriverResult
{
	private string _defaultLocation;

	private string _differentiator;

	private readonly string _shapeType;

	private readonly string _prefix;

	private readonly Func<BuildShapeContext, dynamic> _shapeBuilder;

	private string _groupId;

	public ContentShapeResult(string shapeType, string prefix, Func<BuildShapeContext, dynamic> shapeBuilder)
	{
		_shapeType = shapeType;
		_prefix = prefix;
		_shapeBuilder = shapeBuilder;
	}

	public override void Apply(BuildDisplayContext context)
	{
		ApplyImplementation(context, context.DisplayType);
	}

	public override void Apply(BuildEditorContext context)
	{
		ApplyImplementation(context, null);
	}

	private void ApplyImplementation(BuildShapeContext context, string displayType)
	{
		PlacementInfo placementInfo = context.FindPlacement(_shapeType, _differentiator, _defaultLocation);
		if (string.IsNullOrEmpty(placementInfo.Location) || placementInfo.Location == "-")
		{
			return;
		}
		string group = placementInfo.GetGroup();
		if (!string.IsNullOrEmpty(group))
		{
			_groupId = group;
		}
		if (!string.Equals(context.GroupId ?? "", _groupId ?? "", StringComparison.OrdinalIgnoreCase))
		{
			return;
		}
		dynamic val = context.Shape;
		context.ContentPart = base.ContentPart;
		dynamic val2 = _shapeBuilder(context);
		if (val2 == null)
		{
			return;
		}
		if (base.ContentPart != null && val2.ContentPart == null)
		{
			val2.ContentPart = base.ContentPart;
		}
		if (base.ContentField != null && val2.ContentField == null)
		{
			val2.ContentField = base.ContentField;
		}
		ShapeMetadata shapeMetadata = val2.Metadata;
		shapeMetadata.Prefix = _prefix;
		shapeMetadata.DisplayType = displayType;
		shapeMetadata.PlacementSource = placementInfo.Source;
		shapeMetadata.Tab = placementInfo.GetTab();
		if (!string.IsNullOrEmpty(placementInfo.ShapeType))
		{
			shapeMetadata.Type = placementInfo.ShapeType;
			shapeMetadata.Alternates.Clear();
			shapeMetadata.Wrappers.Clear();
		}
		foreach (string alternate in placementInfo.Alternates)
		{
			shapeMetadata.Alternates.Add(alternate);
		}
		foreach (string wrapper in placementInfo.Wrappers)
		{
			shapeMetadata.Wrappers.Add(wrapper);
		}
		if (placementInfo.IsLayoutZone())
		{
			val = context.Layout;
		}
		string position = placementInfo.GetPosition();
		string zone = placementInfo.GetZone();
		if (string.IsNullOrEmpty(position))
		{
			val.Zones[zone].Add(val2);
		}
		else
		{
			val.Zones[zone].Add(val2, position);
		}
	}

	public ContentShapeResult Location(string zone)
	{
		_defaultLocation = zone;
		return this;
	}

	public ContentShapeResult Differentiator(string differentiator)
	{
		_differentiator = differentiator;
		return this;
	}

	public ContentShapeResult OnGroup(string groupId)
	{
		_groupId = groupId;
		return this;
	}

	public string GetDifferentiator()
	{
		return _differentiator;
	}

	public string GetGroup()
	{
		return _groupId;
	}

	public string GetLocation()
	{
		return _defaultLocation;
	}

	public string GetShapeType()
	{
		return _shapeType;
	}

	public bool WasDisplayed(UpdateEditorContext context)
	{
		if (context.ShapeTable.Descriptors.TryGetValue(_shapeType, out var value))
		{
			ShapePlacementContext arg = new ShapePlacementContext
			{
				Content = context.ContentItem,
				ContentType = context.ContentItem.ContentType,
				Differentiator = _differentiator,
				DisplayType = null,
				Path = context.Path
			};
			PlacementInfo placementInfo = value.Placement(arg);
			string location = placementInfo.Location;
			if (string.IsNullOrEmpty(location) || location == "-")
			{
				return false;
			}
			string text = _groupId;
			if (string.IsNullOrEmpty(text))
			{
				text = placementInfo.GetGroup() ?? "";
			}
			string b = context.GroupId ?? "";
			if (!string.Equals(text, b, StringComparison.OrdinalIgnoreCase))
			{
				return false;
			}
		}
		return true;
	}
}
