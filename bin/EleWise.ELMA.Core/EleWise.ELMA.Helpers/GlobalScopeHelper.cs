using Bridge;
using EleWise.ELMA.Model.ViewModel;

namespace EleWise.ELMA.Helpers;

public static class GlobalScopeHelper
{
	public static IViewModel GetScope()
	{
		return Script.Write<IViewModel>("window.ComponentGlobalStack ? window.ComponentGlobalStack.slice(-1)[0] : undefined", new object[0]);
	}

	public static void Push(IViewModel scope)
	{
		if (scope != null)
		{
			Script.Write("if (window.ComponentGlobalStack) { window.ComponentGlobalStack.push({0}); } else { window.ComponentGlobalStack = [{0}] } ", new object[1] { scope });
		}
	}

	public static void Pop(IViewModel scope)
	{
		if (scope != null)
		{
			Script.Write("if (window.ComponentGlobalStack) { window.ComponentGlobalStack.pop(); }", new object[0]);
		}
	}
}
