namespace EleWise.ELMA.Security.Services;

public interface IJwtAuthTokenService
{
	JwtTokenContainer CreateToken(AuthInfoContainer authInfo);

	AuthInfoContainer GetAuthInfo(string jwtToken);

	JwtTokenContainer RefreshToken(string refreshToken);

	void Revoke(AuthInfoContainer authInfo);
}
