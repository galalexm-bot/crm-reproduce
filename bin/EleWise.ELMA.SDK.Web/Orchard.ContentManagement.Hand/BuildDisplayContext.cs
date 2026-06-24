using System;
using System.Linq;
using Microsoft.CSharp.RuntimeBinder;
using Orchard.DisplayManagement;

namespace Orchard.ContentManagement.Handlers;

public class BuildDisplayContext : BuildShapeContext
{
	private static readonly CallSiteCollection _shapeHelperCalls = new CallSiteCollection((string shapeTypeName) => Binder.InvokeMember(CSharpBinderFlags.None, shapeTypeName, Enumerable.Empty<Type>(), null, new CSharpArgumentInfo[1] { CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null) }));

	public string DisplayType { get; private set; }

	public BuildDisplayContext(IShape model, IContent content, string displayType, string groupId, IShapeFactory shapeFactory)
		: base(model, content, groupId, shapeFactory)
	{
		DisplayType = displayType;
	}

	public dynamic NewShapeWithTypeName(string shapeTypeName)
	{
		return _shapeHelperCalls.Invoke(base.New, shapeTypeName);
	}
}
