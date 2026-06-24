using System.IO;
using System.Web.Hosting;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Web.Service;

internal static class SvgService
{
	public static string GetContent(string imageUrl, bool resetColor)
	{
		if (!string.IsNullOrEmpty(imageUrl) && HostingEnvironment.VirtualPathProvider.FileExists(imageUrl))
		{
			VirtualFile file = HostingEnvironment.VirtualPathProvider.GetFile(imageUrl);
			if (file != null)
			{
				using (StreamReader streamReader = new StreamReader(file.Open(), detectEncodingFromByteOrderMarks: true))
				{
					return resetColor ? SvgHelper.ResetColor(streamReader.ReadToEnd()) : streamReader.ReadToEnd();
				}
			}
		}
		return string.Empty;
	}
}
