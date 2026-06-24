using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Orchard.DisplayManagement.Implementation;

namespace Orchard.DisplayManagement.Descriptors;

public class ShapeDescriptor
{
	public string ShapeType { get; set; }

	public string BindingSource
	{
		get
		{
			if (!Bindings.TryGetValue(ShapeType, out var value))
			{
				return null;
			}
			return value.BindingSource;
		}
	}

	public Func<DisplayContext, IHtmlString> Binding => Bindings[ShapeType].Binding;

	public IDictionary<string, ShapeBinding> Bindings { get; set; }

	public IEnumerable<Action<ShapeCreatingContext>> Creating { get; set; }

	public IEnumerable<Action<ShapeCreatedContext>> Created { get; set; }

	public IEnumerable<Action<ShapeDisplayingContext>> Displaying { get; set; }

	public IEnumerable<Action<ShapeDisplayedContext>> Displayed { get; set; }

	public Func<ShapePlacementContext, PlacementInfo> Placement { get; set; }

	public string DefaultPlacement { get; set; }

	public IList<string> Wrappers { get; set; }

	public IList<string> BindingSources { get; set; }

	public ShapeDescriptor()
	{
		Creating = Enumerable.Empty<Action<ShapeCreatingContext>>();
		Created = Enumerable.Empty<Action<ShapeCreatedContext>>();
		Displaying = Enumerable.Empty<Action<ShapeDisplayingContext>>();
		Displayed = Enumerable.Empty<Action<ShapeDisplayedContext>>();
		Wrappers = new List<string>();
		BindingSources = new List<string>();
		Bindings = new Dictionary<string, ShapeBinding>(StringComparer.OrdinalIgnoreCase);
		Placement = (ShapePlacementContext ctx) => new PlacementInfo
		{
			Location = DefaultPlacement
		};
	}
}
