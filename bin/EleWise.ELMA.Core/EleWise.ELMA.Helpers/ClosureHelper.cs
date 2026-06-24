using System;
using Bridge;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Actions;

namespace EleWise.ELMA.Helpers;

public static class ClosureHelper
{
	private const string IsEmptyAction = "IsEmptyAction";

	public static object CreateForActionWithParam(IAction action)
	{
		object obj = null;
		GlobalScopeHelper.GetScope();
		Script.Write("\r\n            closure = function(param) {\r\n                var res;\r\n                EleWise_ELMA_Core.EleWise.ELMA.Helpers.GlobalScopeHelper.Push(vm);\r\n                try {\r\n                    res = action.Call(param);\r\n                }\r\n                catch(ex) {\r\n                    throw ex;\r\n                }\r\n                finally {\r\n                    EleWise_ELMA_Core.EleWise.ELMA.Helpers.GlobalScopeHelper.Pop(vm);\r\n                }\r\n                \r\n                return res;\r\n            };", new object[0]);
		obj.SetAndCreatePlainPropertyValue("IsEmptyAction", action.IsEmpty);
		return obj;
	}

	public static void Closure(object bindedThis, Action action)
	{
		Script.Write("\r\n            (function () {\r\n                    action.apply(this);\r\n            }).bind({0})()", new object[1] { bindedThis });
	}

	public static void Closure<T1>(object bindedThis, Action<T1> action, params object[] args)
	{
		Script.Write("\r\n            (function () {\r\n                    action.apply(this, arguments[0]);\r\n            }).bind({0})({1})", new object[2] { bindedThis, args });
	}

	public static void Closure<T1, T2>(object bindedThis, Action<T1, T2> action, params object[] args)
	{
		Script.Write("\r\n            (function () {\r\n                    action.apply(this, arguments[0]);\r\n            }).bind({0})({1})", new object[2] { bindedThis, args });
	}

	public static void Closure<T1, T2, T3>(object bindedThis, Action<T1, T2, T3> action, params object[] args)
	{
		Script.Write("\r\n            (function () {\r\n                    action.apply(this, arguments[0]);\r\n            }).bind({0})({1})", new object[2] { bindedThis, args });
	}

	public static void Closure<T1, T2, T3, T4>(object bindedThis, Action<T1, T2, T3, T4> action, params object[] args)
	{
		Script.Write("\r\n            (function () {\r\n                    action.apply(this, arguments[0]);\r\n            }).bind({0})({1})", new object[2] { bindedThis, args });
	}

	public static void Closure<T1, T2, T3, T4, T5>(object bindedThis, Action<T1, T2, T3, T4, T5> action, params object[] args)
	{
		Script.Write("\r\n            (function () {\r\n                    action.apply(this, arguments[0]);\r\n            }).bind({0})({1})", new object[2] { bindedThis, args });
	}

	public static void Closure<T1, T2, T3, T4, T5, T6>(object bindedThis, Action<T1, T2, T3, T4, T5, T6> action, params object[] args)
	{
		Script.Write("\r\n            (function () {\r\n                    action.apply(this, arguments[0]);\r\n            }).bind({0})({1})", new object[2] { bindedThis, args });
	}

	public static void Closure<T1, T2, T3, T4, T5, T6, T7>(object bindedThis, Action<T1, T2, T3, T4, T5, T6, T7> action, params object[] args)
	{
		Script.Write("\r\n            (function () {\r\n                    action.apply(this, arguments[0]);\r\n            }).bind({0})({1})", new object[2] { bindedThis, args });
	}
}
