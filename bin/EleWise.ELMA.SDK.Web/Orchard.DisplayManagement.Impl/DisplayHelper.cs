using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Orchard.DisplayManagement.Shapes;

namespace Orchard.DisplayManagement.Implementation;

public class DisplayHelper : DynamicObject
{
	public class Combined : IHtmlString
	{
		private readonly IEnumerable<IHtmlString> _fragments;

		public Combined(IEnumerable<IHtmlString> fragments)
		{
			_fragments = fragments;
		}

		public string ToHtmlString()
		{
			return string.Join("", _fragments);
		}

		public override string ToString()
		{
			return ToHtmlString();
		}
	}

	private readonly IDisplayManager _displayManager;

	private readonly IShapeFactory _shapeFactory;

	public ViewContext ViewContext { get; set; }

	public IViewDataContainer ViewDataContainer { get; set; }

	public DisplayHelper(IDisplayManager displayManager, IShapeFactory shapeFactory, ViewContext viewContext, IViewDataContainer viewDataContainer)
	{
		_displayManager = displayManager;
		_shapeFactory = shapeFactory;
		ViewContext = viewContext;
		ViewDataContainer = viewDataContainer;
	}

	public override bool TryInvoke(InvokeBinder binder, object[] args, out object result)
	{
		result = Invoke(null, Arguments.From(args, binder.CallInfo.ArgumentNames));
		return true;
	}

	public override bool TryInvokeMember(InvokeMemberBinder binder, object[] args, out object result)
	{
		result = Invoke(binder.Name, Arguments.From(args, binder.CallInfo.ArgumentNames));
		return true;
	}

	public object Invoke(string name, INamedEnumerable<object> parameters)
	{
		if (!string.IsNullOrEmpty(name))
		{
			return ShapeTypeExecute(name, parameters);
		}
		if (parameters.Positional.Count() == 1)
		{
			return ShapeExecute(parameters.Positional.Single());
		}
		if (parameters.Positional.Any())
		{
			return new Combined(ShapeExecute(parameters.Positional));
		}
		return null;
	}

	private IHtmlString ShapeTypeExecute(string name, INamedEnumerable<object> parameters)
	{
		IShape shape = _shapeFactory.Create(name, parameters);
		return ShapeExecute(shape);
	}

	public IHtmlString ShapeExecute(Shape shape)
	{
		return ShapeExecute((object)shape);
	}

	public IHtmlString ShapeExecute(object shape)
	{
		if (shape == null)
		{
			return new HtmlString(string.Empty);
		}
		DisplayContext context = new DisplayContext
		{
			Display = this,
			Value = shape,
			ViewContext = ViewContext,
			ViewDataContainer = ViewDataContainer
		};
		return _displayManager.Execute(context);
	}

	public IEnumerable<IHtmlString> ShapeExecute(IEnumerable<object> shapes)
	{
		return shapes.Select(ShapeExecute).ToArray();
	}
}
