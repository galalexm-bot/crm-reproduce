using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.Extensions;

internal static class FormViewItemExtension
{
	internal static ScriptMethodInfo GetMethodInfo(this FormViewItem formViewItem)
	{
		return ScriptMethodInfoHelper.Deserialize(formViewItem.OnLoadScriptName);
	}

	internal static void SetMethodInfo(this FormViewItem formViewItem, ScriptMethodInfo methodInfo)
	{
		formViewItem.OnLoadScriptName = ScriptMethodInfoHelper.Serialize(methodInfo);
	}
}
