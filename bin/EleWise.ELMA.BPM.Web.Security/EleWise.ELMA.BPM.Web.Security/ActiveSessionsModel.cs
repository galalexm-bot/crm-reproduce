using System.Collections.Generic;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.BPM.Web.Security.Models;

public class ActiveSessionsModel
{
	public class UserSessionsModel
	{
		public EleWise.ELMA.Security.Models.IUser User { get; set; }

		public bool IsPrivileged { get; set; }

		public List<AuthenticatedSessionInfo> Sessions { get; set; }
	}

	public AuthenticatedSessionFilter Filter { get; set; }

	public EleWise.ELMA.Security.Models.IUser CurrentUser { get; set; }

	public List<UserSessionsModel> UserSessions { get; set; }
}
