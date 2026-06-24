using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Orchard.DisplayManagement.Implementation;
using Orchard.Environment.Extensions.Models;

namespace Orchard.DisplayManagement.Descriptors;

public class ShapeAlterationBuilder
{
	private Feature _feature;

	private readonly string _shapeType;

	private readonly string _bindingName;

	private readonly IList<Action<ShapeDescriptor>> _configurations = new List<Action<ShapeDescriptor>>();

	public ShapeAlterationBuilder(Feature feature, string shapeType)
	{
		_feature = feature;
		_bindingName = shapeType;
		int num = shapeType.IndexOf("__");
		if (num < 0)
		{
			_shapeType = shapeType;
		}
		else
		{
			_shapeType = shapeType.Substring(0, num);
		}
	}

	public ShapeAlterationBuilder From(Feature feature)
	{
		_feature = feature;
		return this;
	}

	public ShapeAlterationBuilder Configure(Action<ShapeDescriptor> action)
	{
		_configurations.Add(action);
		return this;
	}

	public ShapeAlterationBuilder BoundAs(string bindingSource, Func<ShapeDescriptor, Func<DisplayContext, IHtmlString>> binder)
	{
		return Configure(delegate(ShapeDescriptor descriptor)
		{
			Func<DisplayContext, IHtmlString> target = null;
			ShapeBinding value = new ShapeBinding
			{
				ShapeDescriptor = descriptor,
				BindingName = _bindingName,
				BindingSource = bindingSource,
				Binding = delegate(DisplayContext displayContext)
				{
					if (target == null)
					{
						target = binder(descriptor);
					}
					return target(displayContext);
				}
			};
			descriptor.Bindings[_bindingName] = value;
		});
	}

	public ShapeAlterationBuilder OnCreating(Action<ShapeCreatingContext> action)
	{
		return Configure(delegate(ShapeDescriptor descriptor)
		{
			IEnumerable<Action<ShapeCreatingContext>> first = descriptor.Creating ?? Enumerable.Empty<Action<ShapeCreatingContext>>();
			descriptor.Creating = first.Concat(new Action<ShapeCreatingContext>[1] { action });
		});
	}

	public ShapeAlterationBuilder OnCreated(Action<ShapeCreatedContext> action)
	{
		return Configure(delegate(ShapeDescriptor descriptor)
		{
			IEnumerable<Action<ShapeCreatedContext>> first = descriptor.Created ?? Enumerable.Empty<Action<ShapeCreatedContext>>();
			descriptor.Created = first.Concat(new Action<ShapeCreatedContext>[1] { action });
		});
	}

	public ShapeAlterationBuilder OnDisplaying(Action<ShapeDisplayingContext> action)
	{
		return Configure(delegate(ShapeDescriptor descriptor)
		{
			IEnumerable<Action<ShapeDisplayingContext>> first = descriptor.Displaying ?? Enumerable.Empty<Action<ShapeDisplayingContext>>();
			descriptor.Displaying = first.Concat(new Action<ShapeDisplayingContext>[1] { action });
		});
	}

	public ShapeAlterationBuilder OnDisplayed(Action<ShapeDisplayedContext> action)
	{
		return Configure(delegate(ShapeDescriptor descriptor)
		{
			IEnumerable<Action<ShapeDisplayedContext>> first = descriptor.Displayed ?? Enumerable.Empty<Action<ShapeDisplayedContext>>();
			descriptor.Displayed = first.Concat(new Action<ShapeDisplayedContext>[1] { action });
		});
	}

	public ShapeAlterationBuilder Placement(Func<ShapePlacementContext, PlacementInfo> action)
	{
		return Configure(delegate(ShapeDescriptor descriptor)
		{
			Func<ShapePlacementContext, PlacementInfo> next = descriptor.Placement;
			descriptor.Placement = (ShapePlacementContext ctx) => action(ctx) ?? next(ctx);
		});
	}

	public ShapeAlterationBuilder Placement(Func<ShapePlacementContext, bool> predicate, PlacementInfo location)
	{
		return Configure(delegate(ShapeDescriptor descriptor)
		{
			Func<ShapePlacementContext, PlacementInfo> next = descriptor.Placement;
			descriptor.Placement = (ShapePlacementContext ctx) => (!predicate(ctx)) ? next(ctx) : location;
		});
	}

	public ShapeAlteration Build()
	{
		return new ShapeAlteration(_shapeType, _feature, _configurations.ToArray());
	}
}
