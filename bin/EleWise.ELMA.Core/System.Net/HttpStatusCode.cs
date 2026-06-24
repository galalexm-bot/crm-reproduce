namespace System.Net;

public static class HttpStatusCode
{
	public const ushort Continue = 100;

	public const ushort SwitchingProtocols = 101;

	public const ushort OK = 200;

	public const ushort Created = 201;

	public const ushort Accepted = 202;

	public const ushort NonAuthoritativeInformation = 203;

	public const ushort NoContent = 204;

	public const ushort ResetContent = 205;

	public const ushort PartialContent = 206;

	public const ushort MultipleChoices = 300;

	public const ushort Ambiguous = 300;

	public const ushort MovedPermanently = 301;

	public const ushort Moved = 301;

	public const ushort Found = 302;

	public const ushort Redirect = 302;

	public const ushort SeeOther = 303;

	public const ushort RedirectMethod = 303;

	public const ushort NotModified = 304;

	public const ushort UseProxy = 305;

	public const ushort Unused = 306;

	public const ushort TemporaryRedirect = 307;

	public const ushort RedirectKeepVerb = 307;

	public const ushort BadRequest = 400;

	public const ushort Unauthorized = 401;

	public const ushort PaymentRequired = 402;

	public const ushort Forbidden = 403;

	public const ushort NotFound = 404;

	public const ushort MethodNotAllowed = 405;

	public const ushort NotAcceptable = 406;

	public const ushort ProxyAuthenticationRequired = 407;

	public const ushort RequestTimeout = 408;

	public const ushort Conflict = 409;

	public const ushort Gone = 410;

	public const ushort LengthRequired = 411;

	public const ushort PreconditionFailed = 412;

	public const ushort RequestEntityTooLarge = 413;

	public const ushort RequestUriTooLong = 414;

	public const ushort UnsupportedMediaType = 415;

	public const ushort RequestedRangeNotSatisfiable = 416;

	public const ushort ExpectationFailed = 417;

	public const ushort UpgradeRequired = 426;

	public const ushort InternalServerError = 500;

	public const ushort NotImplemented = 501;

	public const ushort BadGateway = 502;

	public const ushort ServiceUnavailable = 503;

	public const ushort GatewayTimeout = 504;

	public const ushort HttpVersionNotSupported = 505;
}
