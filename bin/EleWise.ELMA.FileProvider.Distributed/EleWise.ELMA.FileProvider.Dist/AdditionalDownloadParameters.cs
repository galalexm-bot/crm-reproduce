namespace EleWise.ELMA.FileProvider.Distributed.Models;

internal class AdditionalDownloadParameters
{
	internal class SecretCredentials
	{
		public string Salt { get; set; }

		public string Password { get; set; }
	}

	public string ContentType { get; set; }

	public string DownloadName { get; set; }

	public string SourceUrl { get; set; }

	public SecretCredentials Secret { get; set; }
}
