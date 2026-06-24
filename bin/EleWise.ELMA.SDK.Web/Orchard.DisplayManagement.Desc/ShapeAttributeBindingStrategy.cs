using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Autofac;
using Autofac.Core;
using Microsoft.CSharp.RuntimeBinder;
using Orchard.DisplayManagement.Implementation;
using Orchard.Mvc.Spooling;

namespace Orchard.DisplayManagement.Descriptors.ShapeAttributeStrategy;

public class ShapeAttributeBindingStrategy : IShapeTableProvider, IDependency
{
	private readonly IEnumerable<ShapeAttributeOccurrence> _shapeAttributeOccurrences;

	private readonly IComponentContext _componentContext;

	private readonly RouteCollection _routeCollection;

	private static readonly ConcurrentDictionary<string, CallSite<Func<CallSite, object, dynamic>>> _getters = new ConcurrentDictionary<string, CallSite<Func<CallSite, object, object>>>();

	private static readonly ConcurrentDictionary<Type, Func<dynamic, object>> _converters = new ConcurrentDictionary<Type, Func<object, object>>();

	public ShapeAttributeBindingStrategy(IEnumerable<ShapeAttributeOccurrence> shapeAttributeOccurrences, IComponentContext componentContext, RouteCollection routeCollection)
	{
		_shapeAttributeOccurrences = shapeAttributeOccurrences;
		_componentContext = componentContext;
		_routeCollection = routeCollection;
	}

	public void Discover(ShapeTableBuilder builder)
	{
		foreach (ShapeAttributeOccurrence shapeAttributeOccurrence in _shapeAttributeOccurrences)
		{
			ShapeAttributeOccurrence occurrence = shapeAttributeOccurrence;
			string shapeType = occurrence.ShapeAttribute.ShapeType ?? occurrence.MethodInfo.Name;
			builder.Describe(shapeType).From(occurrence.Feature).BoundAs(occurrence.MethodInfo.DeclaringType.FullName + "::" + occurrence.MethodInfo.Name, (ShapeDescriptor descriptor) => CreateDelegate(occurrence, descriptor));
		}
	}

	[DebuggerStepThrough]
	private Func<DisplayContext, IHtmlString> CreateDelegate(ShapeAttributeOccurrence attributeOccurrence, ShapeDescriptor descriptor)
	{
		return delegate(DisplayContext context)
		{
			object serviceInstance = _componentContext.ResolveComponent(attributeOccurrence.Registration, Enumerable.Empty<Parameter>());
			return PerformInvoke(context, attributeOccurrence.MethodInfo, serviceInstance);
		};
	}

	private IHtmlString PerformInvoke(DisplayContext displayContext, MethodInfo methodInfo, object serviceInstance)
	{
		HtmlStringWriter output = new HtmlStringWriter();
		IEnumerable<object> source = from parameter in methodInfo.GetParameters()
			select BindParameter(displayContext, parameter, output);
		try
		{
			object invoke = methodInfo.Invoke(serviceInstance, source.ToArray());
			if (methodInfo.ReturnType != typeof(void))
			{
				output.Write(CoerceHtmlString(invoke));
			}
			return output;
		}
		catch (TargetInvocationException ex)
		{
			throw ex.InnerException;
		}
	}

	private static IHtmlString CoerceHtmlString(object invoke)
	{
		object obj = invoke as IHtmlString;
		if (obj == null)
		{
			if (invoke == null)
			{
				return null;
			}
			obj = new HtmlString(invoke.ToString());
		}
		return (IHtmlString)obj;
	}

	private object BindParameter(DisplayContext displayContext, ParameterInfo parameter, TextWriter output)
	{
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Expected O, but got Unknown
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Expected O, but got Unknown
		if (parameter.Name == "Shape")
		{
			return displayContext.Value;
		}
		if (parameter.Name == "Display")
		{
			return displayContext.Display;
		}
		if (parameter.Name == "Output" && parameter.ParameterType == typeof(TextWriter))
		{
			return output;
		}
		if (parameter.Name == "Output" && parameter.ParameterType == typeof(Action<object>))
		{
			return new Action<object>(output.Write);
		}
		if (parameter.Name == "Html")
		{
			return (object)new HtmlHelper(displayContext.ViewContext, displayContext.ViewDataContainer, _routeCollection);
		}
		if (parameter.Name == "Url" && parameter.ParameterType.IsAssignableFrom(typeof(UrlHelper)))
		{
			return (object)new UrlHelper(((ControllerContext)displayContext.ViewContext).get_RequestContext(), _routeCollection);
		}
		CallSite<Func<CallSite, object, object>> orAdd = _getters.GetOrAdd(parameter.Name, (string n) => CallSite<Func<CallSite, object, object>>.Create(Microsoft.CSharp.RuntimeBinder.Binder.GetMember(CSharpBinderFlags.None, n, null, new CSharpArgumentInfo[1] { CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null) })));
		dynamic val = orAdd.Target(orAdd, displayContext.Value);
		if (val == null)
		{
			return null;
		}
		Func<object, object> orAdd2 = _converters.GetOrAdd(parameter.ParameterType, (Func<Type, Func<object, object>>)CompileConverter);
		return orAdd2.Invoke(val);
	}

	private static Func<dynamic, object> CompileConverter(Type targetType)
	{
		ParameterExpression parameterExpression = Expression.Parameter(typeof(object), "value");
		return Expression.Lambda<Func<object, object>>(Expression.Convert(Expression.Dynamic(Microsoft.CSharp.RuntimeBinder.Binder.Convert(CSharpBinderFlags.ConvertExplicit, targetType, null), targetType, parameterExpression), typeof(object)), new ParameterExpression[1] { parameterExpression }).Compile();
	}
}
