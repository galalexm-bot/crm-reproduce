namespace EleWise.ELMA.IntegrationModules.Models;

internal sealed class AuthenticationDataFillingResult : IAuthenticationDataFillingResult
{
	public bool Success { get; set; }

	public AuthenticationDataFillingResult(bool success)
	{
		Success = success;
	}
}
