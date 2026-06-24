using System.Collections.Generic;
using System.Linq;

namespace Orchard.DisplayManagement.Descriptors;

public class PlacementInfo
{
	private static readonly char[] Delimiters = new char[3] { ':', '#', '@' };

	public string Location { get; set; }

	public string Source { get; set; }

	public string ShapeType { get; set; }

	public IEnumerable<string> Alternates { get; set; }

	public IEnumerable<string> Wrappers { get; set; }

	public PlacementInfo()
	{
		Alternates = Enumerable.Empty<string>();
		Wrappers = Enumerable.Empty<string>();
	}

	public string GetZone()
	{
		int num = Location.IndexOfAny(Delimiters);
		if (num == -1)
		{
			return Location.TrimStart('/');
		}
		return Location.Substring(0, num).TrimStart('/');
	}

	public string GetPosition()
	{
		int num = Location.IndexOf(':');
		if (num == -1)
		{
			return "";
		}
		int num2 = Location.IndexOfAny(Delimiters, num + 1);
		if (num2 == -1)
		{
			return Location.Substring(num + 1);
		}
		return Location.Substring(num + 1, num2 - num - 1);
	}

	public bool IsLayoutZone()
	{
		return Location.StartsWith("/");
	}

	public string GetTab()
	{
		int num = Location.IndexOf('#');
		if (num == -1)
		{
			return "";
		}
		int num2 = Location.IndexOfAny(Delimiters, num + 1);
		if (num2 == -1)
		{
			return Location.Substring(num + 1);
		}
		return Location.Substring(num + 1, num2 - num - 1);
	}

	public string GetGroup()
	{
		int num = Location.IndexOf('@');
		if (num == -1)
		{
			return "";
		}
		int num2 = Location.IndexOfAny(Delimiters, num + 1);
		if (num2 == -1)
		{
			return Location.Substring(num + 1);
		}
		return Location.Substring(num + 1, num2 - num - 1);
	}
}
