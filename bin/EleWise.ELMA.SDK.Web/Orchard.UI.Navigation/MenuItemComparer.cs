using System.Collections.Generic;
using System.Linq;

namespace Orchard.UI.Navigation;

public class MenuItemComparer : IEqualityComparer<MenuItem>
{
	public bool Equals(MenuItem x, MenuItem y)
	{
		string a = ((x.Text == null) ? null : x.Text.TextHint);
		string b = ((y.Text == null) ? null : y.Text.TextHint);
		if (!string.Equals(a, b))
		{
			return false;
		}
		if (!string.IsNullOrWhiteSpace(x.Url) && !string.IsNullOrWhiteSpace(y.Url) && !string.Equals(x.Url, y.Url))
		{
			return false;
		}
		if (x.RouteValues != null && y.RouteValues != null)
		{
			if (x.RouteValues.Keys.Any((string key) => !y.RouteValues.ContainsKey(key)))
			{
				return false;
			}
			if (y.RouteValues.Keys.Any((string key) => !x.RouteValues.ContainsKey(key)))
			{
				return false;
			}
			foreach (string key in x.RouteValues.Keys)
			{
				if (!object.Equals(x.RouteValues[key], y.RouteValues[key]))
				{
					return false;
				}
			}
		}
		if (!string.IsNullOrWhiteSpace(x.Url) && y.RouteValues != null)
		{
			return false;
		}
		if (!string.IsNullOrWhiteSpace(y.Url) && x.RouteValues != null)
		{
			return false;
		}
		if (!string.IsNullOrWhiteSpace(x.Position) && !string.IsNullOrWhiteSpace(y.Position))
		{
			string[] array = (from ss in x.Position.Split('.')
				where ss != "0"
				select ss).ToArray();
			string[] array2 = (from ss in y.Position.Split('.')
				where ss != "0"
				select ss).ToArray();
			string a2 = ((array.Length != 0) ? string.Join(".", array.Take(array.Length - 1)) : null);
			string b2 = ((array2.Length != 0) ? string.Join(".", array2.Take(array2.Length - 1)) : null);
			if (!string.Equals(a2, b2))
			{
				return false;
			}
		}
		return true;
	}

	public int GetHashCode(MenuItem obj)
	{
		int num = 0;
		if (obj.Text != null && obj.Text.TextHint != null)
		{
			num ^= obj.Text.TextHint.GetHashCode();
		}
		return num;
	}
}
