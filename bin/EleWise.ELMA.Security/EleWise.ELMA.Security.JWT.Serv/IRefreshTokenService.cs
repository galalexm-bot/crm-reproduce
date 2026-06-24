namespace EleWise.ELMA.Security.JWT.Services;

internal interface IRefreshTokenService
{
	string CreateToken(AuthInfoContainer authInfo);

	AuthInfoContainer GetAuthInfo(string refreshToken);

	void Revoke(AuthInfoContainer authInfo);

	void RemoveExpired();
}
