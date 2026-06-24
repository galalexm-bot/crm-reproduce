using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Runtime.Db.Migrator.Providers;

public class TypeNames
{
	private readonly Dictionary<DbType, SortedList<int, Pair<string, int?>>> typeMapping;

	private readonly Dictionary<DbType, string> defaults;

	public const string LENGTH_PLACE_HOLDER = "$l";

	public const string SCALE_PLACE_HOLDER = "$s";

	internal static TypeNames TKmUJpWOuexbZLXmh9o5;

	private void PutDefaultValue(DbType typecode, string value)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				defaults[typecode] = value;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	private string GetDefaultValue(DbType typecode)
	{
		//Discarded unreachable code: IL_0094, IL_00a3
		int num = 2;
		int num2 = num;
		string value = default(string);
		while (true)
		{
			switch (num2)
			{
			default:
				throw new ArgumentException((string)wwDaptWOSmCWCyWB7u0B(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x66F566B6 ^ 0x66F761FE), typecode), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1824388195 ^ -1824519151));
			case 1:
				return value;
			case 2:
				if (defaults.TryGetValue(typecode, out value))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			}
		}
	}

	private void PutValue(DbType typecode, int length, Pair<string, int?> value)
	{
		if (!typeMapping.TryGetValue(typecode, out var value2))
		{
			value2 = (typeMapping[typecode] = new SortedList<int, Pair<string, int?>>());
		}
		value2[length] = value;
	}

	private Pair<string, int?> GetValue(DbType typecode, int size)
	{
		_003C_003Ec__DisplayClass5_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass5_0();
		CS_0024_003C_003E8__locals0.size = size;
		typeMapping.TryGetValue(typecode, out var value);
		if (value == null)
		{
			return null;
		}
		if (value.Count((KeyValuePair<int, Pair<string, int?>> pair) => pair.Key >= CS_0024_003C_003E8__locals0.size) == 0)
		{
			return null;
		}
		return value.OrderBy((KeyValuePair<int, Pair<string, int?>> pair) => pair.Key).First((KeyValuePair<int, Pair<string, int?>> pair) => pair.Key >= CS_0024_003C_003E8__locals0.size).Value;
	}

	public void Put(DbType typecode, int? length, string value)
	{
		Put(typecode, length, value, null);
	}

	public void Put(DbType typecode, int? length, string value, int? defaultScale)
	{
		if (length.HasValue)
		{
			PutValue(typecode, length.Value, new Pair<string, int?>(value, defaultScale));
		}
		else
		{
			PutDefaultValue(typecode, value);
		}
	}

	public void Put(DbType typecode, string value)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				PutDefaultValue(typecode, value);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public string Get(ColumnType columnType)
	{
		return Get(r8uhNWWOiDLa1fmkbfbY(columnType), columnType.Length, columnType.Scale);
	}

	public string Get(DbType typecode)
	{
		return Get(typecode, null);
	}

	public string Get(DbType typecode, int? length)
	{
		return Get(typecode, length, null);
	}

	public string Get(DbType typecode, int? length, int? scale)
	{
		Pair<string, int?> pair = null;
		if (length.HasValue)
		{
			pair = GetValue(typecode, length.Value);
		}
		if (pair == null)
		{
			pair = new Pair<string, int?>(GetDefaultValue(typecode), null);
		}
		return Replace(pair.First, length, scale ?? pair.Second);
	}

	public bool HasType(DbType type)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return defaults.ContainsKey(type);
			case 1:
				if (typeMapping.ContainsKey(type))
				{
					return true;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private static string Replace(object type, int? size, int? scale)
	{
		if (size.HasValue)
		{
			type = StringUtils.ReplaceOnce((string)type, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x20261A4F ^ 0x20241DEF), size.ToString());
		}
		if (scale.HasValue)
		{
			type = StringUtils.ReplaceOnce((string)type, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5DD55050 ^ 0x5DD757F8), scale.ToString());
		}
		return (string)type;
	}

	public TypeNames()
	{
		//Discarded unreachable code: IL_004a, IL_004f
		SingletonReader.JJCZtPuTvSt();
		typeMapping = new Dictionary<DbType, SortedList<int, Pair<string, int?>>>();
		defaults = new Dictionary<DbType, string>();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool gWZr3KWOIVrQD5dbwZEn()
	{
		return TKmUJpWOuexbZLXmh9o5 == null;
	}

	internal static TypeNames m6fSAeWOVwGZBwpJcMqk()
	{
		return TKmUJpWOuexbZLXmh9o5;
	}

	internal static object wwDaptWOSmCWCyWB7u0B(object P_0, object P_1)
	{
		return string.Concat(P_0, P_1);
	}

	internal static DbType r8uhNWWOiDLa1fmkbfbY(object P_0)
	{
		return ((ColumnType)P_0).DataType;
	}
}
