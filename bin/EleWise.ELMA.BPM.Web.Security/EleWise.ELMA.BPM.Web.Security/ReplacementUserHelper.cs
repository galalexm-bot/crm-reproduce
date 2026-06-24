using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.BPM.Web.Security.Helper;

public static class ReplacementUserHelper
{
	public static string GetReplacementsAbsencesText(IUser user)
	{
		if (user.Replacement != null)
		{
			IReplacement replacement = user.Replacement;
			return SR.T("Заместитель: {0} с {1:d} по {2:d}", replacement.TargetUser, replacement.StartDate, replacement.EndDate);
		}
		IAbsence nearAbsence = AbsenceManager.Instance.GetNearAbsence(user);
		if (nearAbsence != null)
		{
			return SR.T("Отсутствует с {0:g} по {1:g}", nearAbsence.StartDate, nearAbsence.EndDate);
		}
		return "";
	}
}
