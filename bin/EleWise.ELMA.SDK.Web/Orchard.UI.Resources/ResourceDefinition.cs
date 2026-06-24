using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Web;
using System.Web.Mvc;

namespace Orchard.UI.Resources;

public class ResourceDefinition
{
	private static readonly Dictionary<string, string> _resourceTypeTagNames = new Dictionary<string, string>
	{
		{ "script", "script" },
		{ "stylesheet", "link" }
	};

	private static readonly Dictionary<string, string> _filePathAttributes = new Dictionary<string, string>
	{
		{ "script", "src" },
		{ "link", "href" }
	};

	private static readonly Dictionary<string, Dictionary<string, string>> _resourceAttributes = new Dictionary<string, Dictionary<string, string>>
	{
		{
			"script",
			new Dictionary<string, string> { { "type", "text/javascript" } }
		},
		{
			"stylesheet",
			new Dictionary<string, string>
			{
				{ "type", "text/css" },
				{ "rel", "stylesheet" }
			}
		}
	};

	private static readonly Dictionary<string, TagRenderMode> _fileTagRenderModes = new Dictionary<string, TagRenderMode>
	{
		{
			"script",
			(TagRenderMode)0
		},
		{
			"link",
			(TagRenderMode)3
		}
	};

	private static readonly Dictionary<string, string> _resourceTypeDirectories = new Dictionary<string, string>
	{
		{ "script", "scripts/" },
		{ "stylesheet", "styles/" }
	};

	private string _basePath;

	private readonly Dictionary<RequireSettings, string> _urlResolveCache = new Dictionary<RequireSettings, string>();

	public IResourceManifest Manifest { get; private set; }

	public string TagName => TagBuilder.get_TagName();

	public TagRenderMode TagRenderMode { get; private set; }

	public string Name { get; private set; }

	public string Type { get; private set; }

	public string Version { get; private set; }

	public string BasePath
	{
		get
		{
			if (!string.IsNullOrEmpty(_basePath))
			{
				return _basePath;
			}
			string text = Manifest.BasePath;
			if (!string.IsNullOrEmpty(text))
			{
				text += GetResourcePath(Type);
			}
			return text ?? "";
		}
	}

	public string Url { get; private set; }

	public string UrlDebug { get; private set; }

	public string UrlCdn { get; private set; }

	public string UrlCdnDebug { get; private set; }

	public string[] Cultures { get; private set; }

	public bool CdnSupportsSsl { get; private set; }

	public IEnumerable<string> Dependencies { get; private set; }

	public string FilePathAttributeName { get; private set; }

	public TagBuilder TagBuilder { get; private set; }

	public ResourceDefinition(ResourceManifest manifest, string type, string name)
	{
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		Manifest = manifest;
		Type = type;
		Name = name;
		TagBuilder = new TagBuilder(_resourceTypeTagNames.ContainsKey(type) ? _resourceTypeTagNames[type] : "meta");
		TagRenderMode = (TagRenderMode)(_fileTagRenderModes.ContainsKey(TagBuilder.get_TagName()) ? ((int)_fileTagRenderModes[TagBuilder.get_TagName()]) : 0);
		if (_resourceAttributes.TryGetValue(type, out var value))
		{
			foreach (KeyValuePair<string, string> item in value)
			{
				TagBuilder.get_Attributes()[item.Key] = item.Value;
			}
		}
		FilePathAttributeName = (_filePathAttributes.ContainsKey(TagBuilder.get_TagName()) ? _filePathAttributes[TagBuilder.get_TagName()] : null);
	}

	internal static string GetBasePathFromViewPath(string resourceType, string viewPath)
	{
		if (string.IsNullOrEmpty(viewPath))
		{
			return null;
		}
		string result = null;
		int num = viewPath.IndexOf("/Views", StringComparison.OrdinalIgnoreCase);
		if (num >= 0)
		{
			result = viewPath.Substring(0, num + 1) + GetResourcePath(resourceType);
		}
		return result;
	}

	internal static string GetResourcePath(string resourceType)
	{
		_resourceTypeDirectories.TryGetValue(resourceType, out var value);
		return value ?? "";
	}

	private static string Coalesce(params string[] strings)
	{
		foreach (string text in strings)
		{
			if (!string.IsNullOrEmpty(text))
			{
				return text;
			}
		}
		return null;
	}

	public ResourceDefinition AddAttribute(string name, string value)
	{
		TagBuilder.MergeAttribute(name, value);
		return this;
	}

	public ResourceDefinition SetAttribute(string name, string value)
	{
		TagBuilder.MergeAttribute(name, value, true);
		return this;
	}

	public ResourceDefinition SetBasePath(string virtualPath)
	{
		_basePath = virtualPath;
		return this;
	}

	public ResourceDefinition SetUrl(string url)
	{
		return SetUrl(url, null);
	}

	public ResourceDefinition SetUrl(string url, string urlDebug)
	{
		if (string.IsNullOrEmpty(url))
		{
			throw new ArgumentNullException("url");
		}
		Url = url;
		if (urlDebug != null)
		{
			UrlDebug = urlDebug;
		}
		return this;
	}

	public ResourceDefinition SetCdn(string cdnUrl)
	{
		return SetCdn(cdnUrl, null, null);
	}

	public ResourceDefinition SetCdn(string cdnUrl, string cdnUrlDebug)
	{
		return SetCdn(cdnUrl, cdnUrlDebug, null);
	}

	public ResourceDefinition SetCdn(string cdnUrl, string cdnUrlDebug, bool? cdnSupportsSsl)
	{
		if (string.IsNullOrEmpty(cdnUrl))
		{
			throw new ArgumentNullException("cdnUrl");
		}
		UrlCdn = cdnUrl;
		if (cdnUrlDebug != null)
		{
			UrlCdnDebug = cdnUrlDebug;
		}
		if (cdnSupportsSsl.HasValue)
		{
			CdnSupportsSsl = cdnSupportsSsl.Value;
		}
		else
		{
			CdnSupportsSsl = cdnUrl.StartsWith("https", StringComparison.OrdinalIgnoreCase);
		}
		return this;
	}

	public ResourceDefinition SetVersion(string version)
	{
		Version = version;
		return this;
	}

	public ResourceDefinition SetCultures(params string[] cultures)
	{
		Cultures = cultures;
		return this;
	}

	public ResourceDefinition SetDependencies(params string[] dependencies)
	{
		Dependencies = dependencies;
		return this;
	}

	public string ResolveUrl(RequireSettings settings, string applicationPath)
	{
		return ResolveUrl(settings, applicationPath, ssl: false);
	}

	public string ResolveUrl(RequireSettings settings, string applicationPath, bool ssl)
	{
		if (_urlResolveCache.TryGetValue(settings, out var value))
		{
			return value;
		}
		value = ((ssl && (!ssl || !CdnSupportsSsl)) ? (settings.DebugMode ? Coalesce(UrlDebug, Url) : Coalesce(Url, UrlDebug)) : ((!settings.DebugMode) ? (settings.CdnMode ? Coalesce(UrlCdn, Url, UrlCdnDebug, UrlDebug) : Coalesce(Url, UrlDebug, UrlCdn, UrlCdnDebug)) : (settings.CdnMode ? Coalesce(UrlCdnDebug, UrlDebug, UrlCdn, Url) : Coalesce(UrlDebug, Url, UrlCdnDebug, UrlCdn))));
		if (string.IsNullOrEmpty(value))
		{
			return null;
		}
		if (!string.IsNullOrEmpty(settings.Culture))
		{
			string text = FindNearestCulture(settings.Culture);
			if (!string.IsNullOrEmpty(text))
			{
				value = Path.ChangeExtension(value, text + Path.GetExtension(value));
			}
		}
		if (!Uri.IsWellFormedUriString(value, UriKind.Absolute) && !VirtualPathUtility.IsAbsolute(value) && !VirtualPathUtility.IsAppRelative(value) && !string.IsNullOrEmpty(BasePath))
		{
			value = VirtualPathUtility.Combine(BasePath, value);
		}
		if (VirtualPathUtility.IsAppRelative(value))
		{
			value = ((applicationPath != null) ? VirtualPathUtility.ToAbsolute(value, applicationPath) : VirtualPathUtility.ToAbsolute(value));
		}
		_urlResolveCache[settings] = value;
		return value;
	}

	public string FindNearestCulture(string culture)
	{
		if (Cultures == null)
		{
			return null;
		}
		int num = Array.IndexOf(Cultures, culture);
		if (num != -1)
		{
			return Cultures[num];
		}
		CultureInfo cultureInfo = CultureInfo.GetCultureInfo(culture);
		if (cultureInfo.Parent.Name != culture)
		{
			string text = FindNearestCulture(cultureInfo.Parent.Name);
			if (text != null)
			{
				return text;
			}
		}
		return null;
	}

	public override bool Equals(object obj)
	{
		if (obj == null || obj.GetType() != GetType())
		{
			return false;
		}
		ResourceDefinition resourceDefinition = (ResourceDefinition)obj;
		if (string.Equals(resourceDefinition.Name, Name, StringComparison.Ordinal) && string.Equals(resourceDefinition.Type, Type, StringComparison.Ordinal))
		{
			return string.Equals(resourceDefinition.Version, Version, StringComparison.Ordinal);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return (Name ?? "").GetHashCode() ^ (Type ?? "").GetHashCode();
	}
}
