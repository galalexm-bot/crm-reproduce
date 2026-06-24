using System.IO;
using System.Net;
using System.Threading.Tasks;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Extensions;

public static class WebRequestExtensions
{
	public static Task<WebResponse> GetResponseAsync(this WebRequest webRequest)
	{
		Contract.ArgumentNotNull(webRequest, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x35C0467B ^ 0x35C3BE6F));
		return Task<WebResponse>.Factory.FromAsync(webRequest.BeginGetResponse, webRequest.EndGetResponse, webRequest);
	}

	public static Task<Stream> GetRequestStreamAsync(this WebRequest webRequest)
	{
		Contract.ArgumentNotNull(webRequest, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x18A6761F ^ 0x18A58E0B));
		return Task<Stream>.Factory.FromAsync(webRequest.BeginGetRequestStream, webRequest.EndGetRequestStream, webRequest);
	}

	public static Task<byte[]> DownloadDataAsync(this WebRequest webRequest)
	{
		return webRequest.GetResponseAsync().Then((WebResponse response) => response.GetResponseStream().ReadAllBytesAsync());
	}
}
