namespace EleWise.ELMA.Security.JWT;

internal static class TokenConsts
{
	public const string RefreshTokensCacheRegion = "RefreshTokens";

	public const string RefreshTokenLifetimeKey = "RefreshToken.Lifetime";

	public const string RefreshTokenUidClaim = "rtUid";

	public const string JwtAuthTokenLifetimeKey = "JwtAuthToken.Lifetime";

	public const string JwtTokenUserIdClaim = "userId";

	public const string JwtApplicationTokenClaim = "appToken";
}
