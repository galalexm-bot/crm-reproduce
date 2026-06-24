using EleWise.ELMA.Exceptions;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Web.Mvc.Portlets;

namespace EleWise.ELMA.Web.Mvc.Models.Panels;

public class PanelPersonalizationAdministration
{
	private static string CurrentUserName => "u_" + AuthenticationService.CurrentUserName;

	static PanelPersonalizationAdministration()
	{
		if (PersonalizationAdministration.Provider == null)
		{
			throw new NotInitializedException("Cannot find default Personalization provider");
		}
	}

	public static PanelState LoadState(string panel)
	{
		return PersonalizationAdministration.LoadState<PanelState>(CurrentUserName, panel);
	}

	public static void SaveState(string panel, PanelState state)
	{
		PersonalizationAdministration.SaveState(CurrentUserName, panel, state);
	}
}
