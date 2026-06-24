using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;

namespace EleWise.ELMA.Web.Mvc.Components;

[Component]
internal sealed class ErrorViewsDynamicAssemblyIgnore : IDynamicAssemblyIgnore
{
	private static readonly HashSet<string> Views = new HashSet<string> { "/Views/Shared/Error.cshtml", "/Views/Shared/Error404.cshtml", "/Views/Shared/Error500.cshtml", "/Views/Shared/_ErrorLayout.cshtml" };

	public bool ShouldIgnore(string virtualPath)
	{
		return Views.Contains(virtualPath);
	}
}
