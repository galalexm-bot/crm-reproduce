using EleWise.ELMA.Core.Abstractions.Metadata.Models.Views;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.Extensions;

internal static class ComputedValueExtension
{
	internal static ScriptMethodInfo GetMethodInfo(this ComputedValue computedValue)
	{
		return ScriptMethodInfoHelper.Deserialize(computedValue.get_MethodName());
	}

	internal static void SetMethodInfo(this ComputedValue computedValue, ScriptMethodInfo methodInfo)
	{
		computedValue.set_MethodName(ScriptMethodInfoHelper.Serialize(methodInfo));
	}

	internal static void SetMethodInfo(this ComputedValue computedValue, ScriptMethodInfo methodInfo)
	{
		computedValue.MethodName = ScriptMethodInfoHelper.Serialize(methodInfo);
	}
}
