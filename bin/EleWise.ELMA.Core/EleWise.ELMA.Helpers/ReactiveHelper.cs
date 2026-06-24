using Bridge;

namespace EleWise.ELMA.Helpers;

internal static class ReactiveHelper
{
	public static bool InAction()
	{
		return Script.Write<bool>("mobx._getGlobalState().allowStateChanges", new object[0]);
	}

	public static void ChangeStrictMode(bool enabled)
	{
		Script.Write("mobx._getGlobalState().allowStateChanges = {0}", new object[1] { enabled });
	}
}
