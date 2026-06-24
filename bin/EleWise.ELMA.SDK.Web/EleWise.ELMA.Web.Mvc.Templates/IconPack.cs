using System;
using System.IO;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;

namespace EleWise.ELMA.Web.Mvc.Templates.Content.IconPack;

public static class IconPack
{
	public const string SvgExtension = ".svg";

	public static bool HasSvgExtension(string imageUrl)
	{
		if (!string.IsNullOrEmpty(imageUrl))
		{
			string extension = Path.GetExtension(imageUrl);
			if (!string.IsNullOrEmpty(extension))
			{
				return extension.ToLower() == ".svg";
			}
		}
		return false;
	}

	public static string GetIcon([NotNull] this UrlHelper url, string relativeUrl)
	{
		if (url == null)
		{
			throw new ArgumentNullException("url");
		}
		if (string.IsNullOrEmpty(relativeUrl))
		{
			return string.Empty;
		}
		if (relativeUrl.StartsWith("#"))
		{
			string text = relativeUrl.Substring(1);
			if (!HasSvgExtension(text))
			{
				return string.Empty;
			}
			relativeUrl = "~/Content/IconPack/" + text;
		}
		return url.Content(relativeUrl);
	}

	public static bool IsMetadataIcon(string imageUrl)
	{
		return Path.GetExtension(imageUrl).IsNullOrWhiteSpace();
	}
}
