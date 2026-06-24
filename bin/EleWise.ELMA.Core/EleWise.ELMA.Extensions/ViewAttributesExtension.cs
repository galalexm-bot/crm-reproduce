using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.Extensions;

internal static class ViewAttributesExtension
{
	internal static ScriptMethodInfo GetOnChangeMethodInfo(this ViewAttributes viewAttributes)
	{
		return ScriptMethodInfoHelper.Deserialize(viewAttributes.OnChangeScriptName);
	}

	internal static void SetOnChangeMethodInfo(this ViewAttributes viewAttributes, ScriptMethodInfo methodInfo)
	{
		viewAttributes.OnChangeScriptName = ScriptMethodInfoHelper.Serialize(methodInfo);
	}

	internal static void SetOnFormLoadMethodInfo(this ViewAttributes viewAttributes, ScriptMethodInfo methodInfo)
	{
		viewAttributes.OnViewLoadScriptName = ScriptMethodInfoHelper.Serialize(methodInfo);
	}

	internal static ScriptMethodInfo GetValidationMethodInfo(this ViewAttributes viewAttributes)
	{
		return ScriptMethodInfoHelper.Deserialize(viewAttributes.ValidationScriptName);
	}

	internal static void SetValidationMethodInfo(this ViewAttributes viewAttributes, ScriptMethodInfo methodInfo)
	{
		viewAttributes.ValidationScriptName = ScriptMethodInfoHelper.Serialize(methodInfo);
	}
}
