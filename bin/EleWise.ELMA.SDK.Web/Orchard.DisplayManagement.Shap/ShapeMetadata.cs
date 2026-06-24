using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Orchard.DisplayManagement.Implementation;

namespace Orchard.DisplayManagement.Shapes;

public class ShapeMetadata
{
	public string Type { get; set; }

	public string DisplayType { get; set; }

	public string Position { get; set; }

	public string Tab { get; set; }

	public string PlacementSource { get; set; }

	public string Prefix { get; set; }

	public IList<string> Wrappers { get; set; }

	public IList<string> Alternates { get; set; }

	public bool WasExecuted { get; set; }

	public IHtmlString ChildContent { get; set; }

	public IEnumerable<Action<ShapeDisplayingContext>> Displaying { get; private set; }

	public IEnumerable<Action<ShapeDisplayedContext>> Displayed { get; private set; }

	public IList<string> BindingSources { get; set; }

	public ShapeMetadata()
	{
		Wrappers = new List<string>();
		Alternates = new List<string>();
		BindingSources = new List<string>();
		Displaying = Enumerable.Empty<Action<ShapeDisplayingContext>>();
		Displayed = Enumerable.Empty<Action<ShapeDisplayedContext>>();
	}

	public void OnDisplaying(Action<ShapeDisplayingContext> action)
	{
		IEnumerable<Action<ShapeDisplayingContext>> first = Displaying ?? Enumerable.Empty<Action<ShapeDisplayingContext>>();
		Displaying = first.Concat(new Action<ShapeDisplayingContext>[1] { action });
	}

	public void OnDisplayed(Action<ShapeDisplayedContext> action)
	{
		IEnumerable<Action<ShapeDisplayedContext>> first = Displayed ?? Enumerable.Empty<Action<ShapeDisplayedContext>>();
		Displayed = first.Concat(new Action<ShapeDisplayedContext>[1] { action });
	}
}
