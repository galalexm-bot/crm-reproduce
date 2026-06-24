using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Services;

namespace EleWise.ELMA.Web.Mvc.Util;

[Component]
internal class GridExportExcelSessionHandler : IAuthenticatedSessionEventHandler, IEventHandler
{
	void IAuthenticatedSessionEventHandler.SessionRegistered(IUser user, AuthenticatedSessionInfo sessionInfo)
	{
	}

	void IAuthenticatedSessionEventHandler.SessionClosed(IUser user, AuthenticatedSessionInfo sessionInfo)
	{
		GridExportExcelUtility.ClearExportExcelStatusForSession(sessionInfo.SessionId);
	}
}
