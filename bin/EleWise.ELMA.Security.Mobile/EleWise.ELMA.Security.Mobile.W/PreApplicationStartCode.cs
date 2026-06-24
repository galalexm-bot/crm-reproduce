using Microsoft.Web.Infrastructure.DynamicModuleHelper;

namespace EleWise.ELMA.Security.Mobile.Web;

public static class PreApplicationStartCode
{
	private static bool startWasCalled;

	public static void Start()
	{
		if (!startWasCalled)
		{
			startWasCalled = true;
			DynamicModuleUtility.RegisterModule(typeof(AuthenticationHandler));
		}
	}
}
