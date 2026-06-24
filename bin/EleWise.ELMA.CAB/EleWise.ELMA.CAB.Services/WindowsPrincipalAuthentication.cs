using System;
using System.Security.Principal;

namespace EleWise.ELMA.CAB.Services;

public class WindowsPrincipalAuthenticationService : IAuthenticationService
{
	public void Authenticate()
	{
		AppDomain.CurrentDomain.SetPrincipalPolicy(PrincipalPolicy.WindowsPrincipal);
	}
}
