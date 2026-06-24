using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using Orchard.UI;
using Orchard.UI.Navigation;

namespace Orchard.Utility;

public static class Position
{
	public static string GetNext(IEnumerable<MenuItem> menuItems)
	{
		MenuItem menuItem = menuItems.Where((MenuItem mi) => PositionHasMajorNumber(mi)).OrderByDescending((MenuItem mi) => mi.Position, new FlatPositionComparer()).FirstOrDefault();
		if (menuItem != null)
		{
			List<string> source = (from s in menuItem.Position.Split(new char[1] { '.' }, StringSplitOptions.RemoveEmptyEntries)
				where s.Trim().Length > 0
				select s).ToList();
			if (source.Any() && int.TryParse(source.ElementAt(0), out var result))
			{
				return (result + 1).ToString(CultureInfo.InvariantCulture);
			}
		}
		return "1";
	}

	public static string GetNextMinor(int major, IEnumerable<MenuItem> menuItems)
	{
		string text = major.ToString(CultureInfo.InvariantCulture);
		MenuItem menuItem = menuItems.Where((MenuItem mi) => PositionHasMajorNumber(mi, major)).OrderByDescending((MenuItem mi) => mi.Position, new FlatPositionComparer()).FirstOrDefault();
		if (menuItem == null)
		{
			return text;
		}
		List<string> source = (from s in menuItem.Position.Split(new char[1] { '.' }, StringSplitOptions.RemoveEmptyEntries)
			where s.Trim().Length > 0
			select s).ToList();
		if (source.Count() > 1)
		{
			if (int.TryParse(source.ElementAt(1), out var result))
			{
				return text + "." + (result + 1);
			}
		}
		else if (source.Count() == 1)
		{
			return text + ".1";
		}
		return text;
	}

	private static bool PositionHasMajorNumber(MenuItem mi, int? position = null)
	{
		string text = ((mi.Position == null) ? null : mi.Position.Split('.')[0]);
		if (string.IsNullOrEmpty(text))
		{
			return false;
		}
		if (int.TryParse(text, out var result))
		{
			if (position.HasValue)
			{
				return position.Value == result;
			}
			return true;
		}
		return false;
	}
}
