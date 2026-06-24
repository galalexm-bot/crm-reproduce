using EleWise.ELMA.Core.Abstractions.Metadata.Models;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model;

namespace EleWise.ELMA.Extensions;

internal static class ActionValueExtension
{
	internal static ScriptMethodInfo GetMethodInfo(this ActionValue actionValue)
	{
		return ScriptMethodInfoHelper.Deserialize(actionValue.get_MethodName());
	}

	internal static void SetMethodInfo(this ActionValue actionValue, ScriptMethodInfo methodInfo)
	{
		actionValue.set_MethodName(ScriptMethodInfoHelper.Serialize(methodInfo));
	}

	internal static void SetMethodInfo(this ActionValue actionValue, ScriptMethodInfo methodInfo)
	{
		actionValue.MethodName = ScriptMethodInfoHelper.Serialize(methodInfo);
	}
}
