using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model;
using EleWise.ELMA.Model.Views;

namespace EleWise.ELMA.Extensions;

internal static class ButtonViewItemExtension
{
	internal static ScriptMethodInfo GetMethodInfo(this ButtonViewItem buttonViewItem)
	{
		return ScriptMethodInfoHelper.Deserialize(buttonViewItem.ScriptName);
	}

	internal static void SetMethodInfo(this ButtonViewItem buttonViewItem, ScriptMethodInfo methodInfo)
	{
		buttonViewItem.ScriptName = ScriptMethodInfoHelper.Serialize(methodInfo);
	}
}
