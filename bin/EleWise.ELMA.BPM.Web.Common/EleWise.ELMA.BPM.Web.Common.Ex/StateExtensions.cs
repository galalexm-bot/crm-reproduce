using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Web.Mvc.Portlets;

namespace EleWise.ELMA.BPM.Web.Common.Extensions;

public class StateExtensions
{
	public static T LoadState<T>(string id)
	{
		if (PersonalizationAdministration.Provider == null)
		{
			return default(T);
		}
		return PersonalizationAdministration.LoadState<T>("u_" + AuthenticationService.CurrentUserName, id);
	}

	public static void SaveState<T>(string id, T state)
	{
		if (PersonalizationAdministration.Provider != null)
		{
			PersonalizationAdministration.SaveState("u_" + AuthenticationService.CurrentUserName, id, state);
		}
	}
}
