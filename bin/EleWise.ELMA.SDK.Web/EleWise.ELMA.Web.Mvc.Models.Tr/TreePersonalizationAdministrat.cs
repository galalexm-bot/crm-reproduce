using EleWise.ELMA.Exceptions;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Web.Mvc.Portlets;

namespace EleWise.ELMA.Web.Mvc.Models.Trees;

public static class TreePersonalizationAdministration
{
	private static string CurrentUserName => "u_" + AuthenticationService.CurrentUserName;

	static TreePersonalizationAdministration()
	{
		if (PersonalizationAdministration.Provider == null)
		{
			throw new NotInitializedException("Cannot find default Personalization provider");
		}
	}

	public static TreeState LoadState(string tree)
	{
		return PersonalizationAdministration.LoadState<TreeState>(CurrentUserName, tree);
	}

	public static void SaveState(string tree, TreeState state)
	{
		PersonalizationAdministration.SaveState(CurrentUserName, tree, state);
	}
}
