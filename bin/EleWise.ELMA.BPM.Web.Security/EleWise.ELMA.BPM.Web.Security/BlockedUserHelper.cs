using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.BPM.Web.Security.Helper;

public static class BlockedUserHelper
{
	public static string GetBlockedText(IUser user)
	{
		if (user != null && user.BlockDate.HasValue)
		{
			return SR.T("Заблокирован с {0:d}", user.BlockDate.Value);
		}
		return "";
	}
}
