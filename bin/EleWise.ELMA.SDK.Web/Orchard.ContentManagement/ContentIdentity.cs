using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orchard.ContentManagement;

public class ContentIdentity
{
	public class ContentIdentityEqualityComparer : IEqualityComparer<ContentIdentity>
	{
		public static bool AreEquivalent(ContentIdentity contentIdentity1, ContentIdentity contentIdentity2)
		{
			if (contentIdentity1 == null)
			{
				return contentIdentity2 == null;
			}
			if (contentIdentity2 == null)
			{
				return false;
			}
			return contentIdentity1._dictionary.Keys.Any(delegate(string k)
			{
				string text = contentIdentity2.Get(k);
				return text != null && contentIdentity1._dictionary[k] == text;
			});
		}

		public bool Equals(ContentIdentity contentIdentity1, ContentIdentity contentIdentity2)
		{
			if (contentIdentity1._dictionary.Keys.Count != contentIdentity2._dictionary.Keys.Count)
			{
				return false;
			}
			foreach (string key in contentIdentity1._dictionary.Keys)
			{
				if (!contentIdentity2._dictionary.ContainsKey(key))
				{
					return false;
				}
				if (contentIdentity2._dictionary[key] != contentIdentity1._dictionary[key])
				{
					return false;
				}
			}
			return true;
		}

		public int GetHashCode(ContentIdentity contentIdentity)
		{
			return contentIdentity._dictionary.OrderBy((KeyValuePair<string, string> kvp) => kvp.Key).ToString().GetHashCode();
		}
	}

	private readonly Dictionary<string, string> _dictionary;

	public ContentIdentity()
	{
		_dictionary = new Dictionary<string, string>();
	}

	public ContentIdentity(string identity)
	{
		_dictionary = new Dictionary<string, string>();
		if (string.IsNullOrEmpty(identity))
		{
			return;
		}
		foreach (string identityEntry in GetIdentityEntries(identity))
		{
			KeyValuePair<string, string>? identityKeyValue = GetIdentityKeyValue(identityEntry);
			if (identityKeyValue.HasValue)
			{
				_dictionary.Add(identityKeyValue.Value.Key, UnencodeIdentityValue(identityKeyValue.Value.Value));
			}
		}
	}

	public void Add(string name, string value)
	{
		if (_dictionary.ContainsKey(name))
		{
			_dictionary[name] = value;
		}
		else
		{
			_dictionary.Add(name, value);
		}
	}

	public string Get(string name)
	{
		if (!Has(name))
		{
			return null;
		}
		return _dictionary[name];
	}

	public bool Has(string name)
	{
		return _dictionary.ContainsKey(name);
	}

	public override string ToString()
	{
		StringBuilder stringBuilder = new StringBuilder();
		foreach (string item in _dictionary.Keys.OrderBy((string key) => key))
		{
			string text = EncodeIdentityValue(_dictionary[item]);
			stringBuilder.Append("/" + item + "=" + text);
		}
		return stringBuilder.ToString();
	}

	private static string EncodeIdentityValue(string identityValue)
	{
		if (string.IsNullOrEmpty(identityValue))
		{
			return "";
		}
		StringBuilder stringBuilder = new StringBuilder();
		char[] array = identityValue.ToCharArray();
		foreach (char c in array)
		{
			switch (c)
			{
			case '\\':
				stringBuilder.Append('\\');
				stringBuilder.Append('\\');
				break;
			case '/':
				stringBuilder.Append('\\');
				stringBuilder.Append('/');
				break;
			default:
				stringBuilder.Append(c);
				break;
			}
		}
		return stringBuilder.ToString();
	}

	private static string UnencodeIdentityValue(string identityValue)
	{
		StringBuilder stringBuilder = new StringBuilder();
		char[] array = identityValue.ToCharArray();
		int num = array.Length;
		for (int i = 0; i < num; i++)
		{
			char c = array[i];
			if (c == '\\')
			{
				if (i + 1 < num)
				{
					if (array[i + 1] == '\\')
					{
						stringBuilder.Append('\\');
						i++;
					}
				}
				else
				{
					stringBuilder.Append('\\');
				}
			}
			else
			{
				stringBuilder.Append(array[i]);
			}
		}
		return stringBuilder.ToString();
	}

	private static IEnumerable<string> GetIdentityEntries(string identity)
	{
		List<string> list = new List<string>();
		StringBuilder stringBuilder = new StringBuilder();
		bool flag = false;
		char[] array = identity.ToCharArray();
		foreach (char c in array)
		{
			if (flag)
			{
				stringBuilder.Append(c);
				flag = false;
				continue;
			}
			switch (c)
			{
			case '/':
				if (stringBuilder.Length > 0)
				{
					list.Add(stringBuilder.ToString());
					stringBuilder.Clear();
				}
				stringBuilder.Append(c);
				continue;
			case '\\':
				flag = true;
				break;
			}
			stringBuilder.Append(c);
		}
		list.Add(stringBuilder.ToString());
		return list;
	}

	private static KeyValuePair<string, string>? GetIdentityKeyValue(string identityEntry)
	{
		if (string.IsNullOrWhiteSpace(identityEntry))
		{
			return null;
		}
		if (!identityEntry.StartsWith("/"))
		{
			return null;
		}
		int num = identityEntry.IndexOf("=");
		if (num < 0)
		{
			return null;
		}
		string key = identityEntry.Substring(1, num - 1);
		string value = identityEntry.Substring(num + 1);
		return new KeyValuePair<string, string>(key, value);
	}
}
