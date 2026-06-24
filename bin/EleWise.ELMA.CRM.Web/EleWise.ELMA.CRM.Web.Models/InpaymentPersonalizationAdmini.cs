using EleWise.ELMA.Exceptions;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Web.Mvc.Portlets;

namespace EleWise.ELMA.CRM.Web.Models;

public class InpaymentPersonalizationAdministration
{
	private static string CurrentUserName => "u_" + AuthenticationService.CurrentUserName;

	static InpaymentPersonalizationAdministration()
	{
		if (PersonalizationAdministration.Provider == null)
		{
			throw new NotInitializedException("Cannot find default Personalization provider");
		}
	}

	public static InpaymentStatusFilterModel LoadState(string statusFilter)
	{
		return PersonalizationAdministration.LoadState<InpaymentStatusFilterModel>(CurrentUserName, statusFilter);
	}

	public static void SaveState(string statusFilter, InpaymentStatusFilterModel state)
	{
		PersonalizationAdministration.SaveState(CurrentUserName, statusFilter, state);
	}
}
