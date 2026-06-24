namespace EleWise.ELMA.API;

public static class PublicContractInfo
{
	public const string SessionContextKey = "PublicContractInfo.SessionContextKey";

	public const string ExecutingApplicationContextKey = "PublicContractInfo.ExecutingApplicationContextKey";

	public const string ContractNamespace = "http://www.elma-bpm.ru/api/";

	public const string ApplicationTokenHeader = "ApplicationToken";

	public const string SessionTokenHeader = "SessionToken";

	public const string AuthTokenHeader = "AuthToken";

	public const string AuthInfoHeader = "Auth-Info";

	public const string SignedHeadersHeader = "Signed-Headers";

	public const string AuthorizationHeader = "Authorization";

	public const string AuthorizationBearerPrefix = "Bearer ";

	public const string JwtLangClaim = "lang";

	public const string ApiVersionString = "1.0.9";
}
