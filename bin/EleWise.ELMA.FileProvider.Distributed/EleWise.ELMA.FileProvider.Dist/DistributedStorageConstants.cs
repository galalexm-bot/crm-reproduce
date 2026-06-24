using System;

namespace EleWise.ELMA.FileProvider.Distributed;

public static class DistributedStorageConstants
{
	public const string ElmaUriScheme = "elma";

	public const int NoDefaultPort = -1;

	public const GenericUriParserOptions ElmaUriParserOptions = GenericUriParserOptions.AllowEmptyAuthority | GenericUriParserOptions.NoUserInfo | GenericUriParserOptions.NoPort | GenericUriParserOptions.NoQuery | GenericUriParserOptions.NoFragment;
}
