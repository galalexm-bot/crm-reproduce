namespace EleWise.ELMA.FileProvider.Distributed.Models;

internal static class ContentOriginTableConstants
{
	public static class Fields
	{
		public const string Id = "Id";

		public const string FileId = "FileId";

		public const string SourceGateway = "SourceGateway";

		public const int SourceGatewayLength = 256;
	}

	public const string TableName = "FS_ORIGINS";
}
