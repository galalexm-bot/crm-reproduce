using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Web;
using EleWise.ELMA.Logging;
using Microsoft.CSharp.RuntimeBinder;
using Orchard.DisplayManagement.Descriptors;
using Orchard.DisplayManagement.Shapes;
using Orchard.Localization;
using Orchard.Mvc;

namespace Orchard.DisplayManagement.Implementation;

public class DefaultDisplayManager : IDisplayManager, IDependency
{
	private class ForgivingConvertBinder : ConvertBinder
	{
		private readonly ConvertBinder _innerBinder;

		public ForgivingConvertBinder(ConvertBinder innerBinder)
			: base(innerBinder.ReturnType, innerBinder.Explicit)
		{
			_innerBinder = innerBinder;
		}

		public override DynamicMetaObject FallbackConvert(DynamicMetaObject target, DynamicMetaObject errorSuggestion)
		{
			return _innerBinder.FallbackConvert(target, errorSuggestion ?? new DynamicMetaObject(Expression.Default(_innerBinder.ReturnType), GetTypeRestriction(target)));
		}

		private static BindingRestrictions GetTypeRestriction(DynamicMetaObject obj)
		{
			if (obj.Value == null && obj.HasValue)
			{
				return BindingRestrictions.GetInstanceRestriction(obj.Expression, null);
			}
			return BindingRestrictions.GetTypeRestriction(obj.Expression, obj.LimitType);
		}
	}

	private readonly Lazy<IShapeTableLocator> _shapeTableLocator;

	private readonly IWorkContextAccessor _workContextAccessor;

	private readonly IEnumerable<IShapeDisplayEvents> _shapeDisplayEvents;

	private readonly IHttpContextAccessor _httpContextAccessor;

	private readonly IEnumerable<IShapeBindingResolver> _shapeBindingResolvers;

	private static readonly CallSite<Func<CallSite, object, Shape>> _convertAsShapeCallsite = CallSite<Func<CallSite, object, Shape>>.Create(new ForgivingConvertBinder((ConvertBinder)Binder.Convert(CSharpBinderFlags.ConvertExplicit, typeof(Shape), null)));

	public Localizer T { get; set; }

	public ILogger Logger { get; set; }

	public DefaultDisplayManager(IWorkContextAccessor workContextAccessor, IEnumerable<IShapeDisplayEvents> shapeDisplayEvents, IEnumerable<IShapeBindingResolver> shapeBindingResolvers, IHttpContextAccessor httpContextAccessor, Lazy<IShapeTableLocator> shapeTableLocator)
	{
		_shapeTableLocator = shapeTableLocator;
		_workContextAccessor = workContextAccessor;
		_shapeDisplayEvents = shapeDisplayEvents;
		_httpContextAccessor = httpContextAccessor;
		_shapeBindingResolvers = shapeBindingResolvers;
		T = NullLocalizer.Instance;
		Logger = NullLogger.Instance;
	}

	public IHtmlString Execute(DisplayContext context)
	{
		Shape shape = _convertAsShapeCallsite.Target(_convertAsShapeCallsite, context.Value);
		if (shape == null)
		{
			return CoerceHtmlString(context.Value);
		}
		ShapeMetadata metadata = shape.Metadata;
		if (metadata == null || string.IsNullOrEmpty(metadata.Type))
		{
			return CoerceHtmlString(context.Value);
		}
		WorkContext context2 = _workContextAccessor.GetContext();
		ShapeTable shapeTable = ((_httpContextAccessor.Current() != null) ? _shapeTableLocator.Value.Lookup(context2.CurrentTheme.Id) : _shapeTableLocator.Value.Lookup(null));
		ShapeDisplayingContext displayingContext = new ShapeDisplayingContext
		{
			Shape = shape,
			ShapeMetadata = metadata
		};
		_shapeDisplayEvents.Invoke(delegate(IShapeDisplayEvents sde)
		{
			sde.Displaying(displayingContext);
		}, Logger);
		if (TryGetDescriptorBinding(metadata.Type, Enumerable.Empty<string>(), shapeTable, out var shapeBinding))
		{
			shapeBinding.ShapeDescriptor.Displaying.Invoke(delegate(Action<ShapeDisplayingContext> action)
			{
				action(displayingContext);
			}, Logger);
			metadata.BindingSources = shapeBinding.ShapeDescriptor.BindingSources.Where((string x) => x != null).ToList();
			if (!metadata.BindingSources.Any())
			{
				metadata.BindingSources.Add(shapeBinding.ShapeDescriptor.BindingSource);
			}
		}
		metadata.Displaying.Invoke(delegate(Action<ShapeDisplayingContext> action)
		{
			action(displayingContext);
		}, Logger);
		if (displayingContext.ChildContent != null)
		{
			shape.Metadata.ChildContent = displayingContext.ChildContent;
		}
		else
		{
			if (!TryGetDescriptorBinding(metadata.Type, metadata.Alternates, shapeTable, out var shapeBinding2))
			{
				throw new OrchardException(T("Shape type {0} not found", metadata.Type));
			}
			shape.Metadata.ChildContent = Process(shapeBinding2, shape, context);
		}
		foreach (string wrapper in shape.Metadata.Wrappers)
		{
			if (TryGetDescriptorBinding(wrapper, Enumerable.Empty<string>(), shapeTable, out var shapeBinding3))
			{
				shape.Metadata.ChildContent = Process(shapeBinding3, shape, context);
			}
		}
		ShapeDisplayedContext displayedContext = new ShapeDisplayedContext
		{
			Shape = shape,
			ShapeMetadata = shape.Metadata,
			ChildContent = shape.Metadata.ChildContent
		};
		_shapeDisplayEvents.Invoke(delegate(IShapeDisplayEvents sde)
		{
			IHtmlString htmlString2 = (displayedContext.ChildContent = displayedContext.ShapeMetadata.ChildContent);
			sde.Displayed(displayedContext);
			if (htmlString2 != displayedContext.ChildContent)
			{
				displayedContext.ShapeMetadata.ChildContent = displayedContext.ChildContent;
			}
		}, Logger);
		shapeBinding?.ShapeDescriptor.Displayed.Invoke(delegate(Action<ShapeDisplayedContext> action)
		{
			IHtmlString htmlString = (displayedContext.ChildContent = displayedContext.ShapeMetadata.ChildContent);
			action(displayedContext);
			if (htmlString != displayedContext.ChildContent)
			{
				displayedContext.ShapeMetadata.ChildContent = displayedContext.ChildContent;
			}
		}, Logger);
		metadata.Displayed.Invoke(delegate(Action<ShapeDisplayedContext> action)
		{
			action(displayedContext);
		}, Logger);
		return shape.Metadata.ChildContent;
	}

	private bool TryGetDescriptorBinding(string shapeType, IEnumerable<string> shapeAlternates, ShapeTable shapeTable, out ShapeBinding shapeBinding)
	{
		foreach (string item in shapeAlternates.Reverse())
		{
			foreach (IShapeBindingResolver shapeBindingResolver in _shapeBindingResolvers)
			{
				if (shapeBindingResolver.TryGetDescriptorBinding(item, out shapeBinding))
				{
					return true;
				}
			}
			if (shapeTable.Bindings.TryGetValue(item, out shapeBinding))
			{
				return true;
			}
		}
		string text = shapeType;
		while (true)
		{
			foreach (IShapeBindingResolver shapeBindingResolver2 in _shapeBindingResolvers)
			{
				if (shapeBindingResolver2.TryGetDescriptorBinding(text, out shapeBinding))
				{
					return true;
				}
			}
			if (shapeTable.Bindings.TryGetValue(text, out shapeBinding))
			{
				return true;
			}
			int num = text.LastIndexOf("__");
			if (num < 0)
			{
				break;
			}
			text = text.Substring(0, num);
		}
		shapeBinding = null;
		return false;
	}

	private static IHtmlString CoerceHtmlString(object value)
	{
		if (value == null)
		{
			return null;
		}
		if (value is IHtmlString result)
		{
			return result;
		}
		return new HtmlString(HttpUtility.HtmlEncode(value));
	}

	private static IHtmlString Process(ShapeBinding shapeBinding, IShape shape, DisplayContext context)
	{
		if (shapeBinding == null || shapeBinding.Binding == null)
		{
			return shape.Metadata.ChildContent ?? new HtmlString("");
		}
		return CoerceHtmlString(shapeBinding.Binding(context));
	}
}
