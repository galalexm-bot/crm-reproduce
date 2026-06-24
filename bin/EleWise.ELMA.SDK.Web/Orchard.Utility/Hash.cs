using System;
using System.Globalization;

namespace Orchard.Utility;

public class Hash
{
	private long _hash;

	public string Value => _hash.ToString("x", CultureInfo.InvariantCulture);

	public override string ToString()
	{
		return Value;
	}

	public void AddString(string value)
	{
		if (!string.IsNullOrEmpty(value))
		{
			_hash += GetStringHashCode(value);
		}
	}

	public void AddStringInvariant(string value)
	{
		if (!string.IsNullOrEmpty(value))
		{
			AddString(value.ToLowerInvariant());
		}
	}

	public void AddTypeReference(Type type)
	{
		AddString(type.AssemblyQualifiedName);
		AddString(type.FullName);
	}

	public void AddDateTime(DateTime dateTime)
	{
		_hash += dateTime.ToBinary();
	}

	private static long GetStringHashCode(string s)
	{
		long num = 352654597L;
		for (int i = 0; i < s.Length; i++)
		{
			long num2 = s[i].GetHashCode();
			num = num + (num2 << 27) + num2;
		}
		return num;
	}
}
