using System;

namespace Orchard.Mvc.Routes;

public class UrlPrefix
{
	private readonly string _prefix;

	public UrlPrefix(string prefix)
	{
		_prefix = prefix.TrimStart('~').Trim('/');
	}

	public string RemoveLeadingSegments(string path)
	{
		int num = 0;
		if (path.Length > num && path[num] == '~')
		{
			num++;
		}
		if (path.Length > num && path[num] == '/')
		{
			num++;
		}
		int num2 = num + _prefix.Length;
		if (path.Length != num2)
		{
			if (path.Length <= num2 || path[num2] != '/')
			{
				return path;
			}
			num2++;
		}
		if (string.Compare(path, num, _prefix, 0, _prefix.Length, StringComparison.OrdinalIgnoreCase) == 0)
		{
			return path.Substring(0, num) + path.Substring(num2);
		}
		return path;
	}

	public string PrependLeadingSegments(string path)
	{
		if (path == "~")
		{
			return "~/" + _prefix + "/";
		}
		int num = 0;
		if (path.Length > num && path[num] == '~')
		{
			num++;
		}
		if (path.Length > num && path[num] == '/')
		{
			num++;
		}
		return path.Substring(0, num) + _prefix + "/" + path.Substring(num);
	}
}
