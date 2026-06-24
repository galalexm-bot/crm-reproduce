using System;

public static class Helpers
{
	public static string GetRepositoryUrl(Uri currentUrl, string applicationPath)
	{
		return GetBaseUrl(currentUrl, applicationPath) + "nuget";
	}

	public static string GetPushUrl(Uri currentUrl, string applicationPath)
	{
		return GetBaseUrl(currentUrl, applicationPath);
	}

	public static string GetBaseUrl(Uri currentUrl, string applicationPath)
	{
		UriBuilder uriBuilder = new UriBuilder(currentUrl);
		string text = uriBuilder.Scheme + "://" + uriBuilder.Host;
		if (uriBuilder.Port != 80)
		{
			text = text + ":" + uriBuilder.Port;
		}
		text += applicationPath;
		return EnsureTrailingSlash(text);
	}

	internal static string EnsureTrailingSlash(string path)
	{
		if (string.IsNullOrEmpty(path))
		{
			return path;
		}
		if (!path.EndsWith("/"))
		{
			return path + "/";
		}
		return path;
	}
}
