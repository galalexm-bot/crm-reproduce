using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Common;

[Serializable]
public class QueryParameters : IDictionary<string, object>, ICollection<KeyValuePair<string, object>>, IEnumerable<KeyValuePair<string, object>>, IEnumerable
{
	private readonly IDictionary<string, object> dictionary;

	internal static QueryParameters PaJpNChqDibWZk1LYm6f;

	public int Count => P9vII1hq65E3QT6JQabO(dictionary);

	public object this[string key]
	{
		get
		{
			return dictionary[TrimKey(key)];
		}
		set
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
					dictionary[TrimKey(key)] = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	public ICollection<string> ParameterNames => dictionary.Keys;

	ICollection<string> IDictionary<string, object>.Keys => ParameterNames;

	ICollection<object> IDictionary<string, object>.Values => dictionary.Values;

	bool ICollection<KeyValuePair<string, object>>.IsReadOnly => false;

	protected IDictionary<string, object> Dictionary => dictionary;

	public QueryParameters()
	{
		//Discarded unreachable code: IL_002f, IL_0034
		MOyjGIhq420tgJPUkJtu();
		this._002Ector(new SerializableDictionary<string, object>());
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	protected QueryParameters(IDictionary<string, object> dictionary)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		this.dictionary = dictionary;
	}

	public bool Contains(string name)
	{
		return dictionary.ContainsKey(TrimKey(name));
	}

	public object Get(string name)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				throw new VariableNotFoundException(name);
			case 1:
			{
				if (TryGetValue(name, out var value))
				{
					return value;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0)
				{
					num2 = 0;
				}
				break;
			}
			}
		}
	}

	[Obsolete("Not used", true)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public void FillPropertyParams(string key, string propertyName, Guid parentTypeUid)
	{
	}

	public bool TryGetValue(string name, out object value)
	{
		return dictionary.TryGetValue(TrimKey(name), out value);
	}

	public QueryParameters Set(string name, object value)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				this[name] = value;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca != 0)
				{
					num2 = 0;
				}
				break;
			default:
				return this;
			}
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[Obsolete("Use Set(string name, object value) instead", true)]
	public QueryParameters Set(string name, QueryParameter value)
	{
		return Set(name, QjVRkLhqHPBkgYscUtXL(value));
	}

	public void Remove(string key)
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
				dictionary.Remove(TrimKey(key));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public void Clear()
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
				dictionary.Clear();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public IEnumerator<KeyValuePair<string, object>> GetEnumerator()
	{
		return dictionary.GetEnumerator();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}

	void IDictionary<string, object>.Add(string key, object value)
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
				dictionary.Add(TrimKey(key), value);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	bool IDictionary<string, object>.Remove(string key)
	{
		return dictionary.Remove(TrimKey(key));
	}

	void ICollection<KeyValuePair<string, object>>.Add(KeyValuePair<string, object> item)
	{
		dictionary.Add(TrimKey(item.Key), item.Value);
	}

	bool ICollection<KeyValuePair<string, object>>.Contains(KeyValuePair<string, object> item)
	{
		if (dictionary.TryGetValue(TrimKey(item.Key), out var value))
		{
			return value == item.Value;
		}
		return false;
	}

	bool IDictionary<string, object>.ContainsKey(string key)
	{
		return Contains(key);
	}

	void ICollection<KeyValuePair<string, object>>.CopyTo(KeyValuePair<string, object>[] array, int arrayIndex)
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
				dictionary.CopyTo(array, arrayIndex);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	bool ICollection<KeyValuePair<string, object>>.Remove(KeyValuePair<string, object> item)
	{
		string key = TrimKey(item.Key);
		if (dictionary.TryGetValue(key, out var value) && value == item.Value)
		{
			return dictionary.Remove(key);
		}
		return false;
	}

	protected string TrimKey(string key)
	{
		//Discarded unreachable code: IL_005f, IL_01a4
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				if (MmmZgJhqAKb2xXp6faSE(key) <= 2)
				{
					num2 = 4;
					continue;
				}
				goto case 9;
			case 7:
				key = ((string)EanyvThq0FFlXBFE1EBK(key, 1, MmmZgJhqAKb2xXp6faSE(key) - 2)).Replace((string)cCUvQphqmrMj7UGSbFA6(0x12441CA4 ^ 0x124759F0), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1979251663 ^ -1979190573)).Replace(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-398663332 ^ -398715392), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1876063057 ^ -1876067769));
				num2 = 6;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
				{
					num2 = 5;
				}
				continue;
			case 9:
				if (wQM5IZhq7JosTBeUsR6g(key, 0) == '[')
				{
					num2 = 3;
					continue;
				}
				break;
			case 3:
				if (wQM5IZhq7JosTBeUsR6g(key, MmmZgJhqAKb2xXp6faSE(key) - 1) == ']')
				{
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
					{
						num2 = 7;
					}
					continue;
				}
				break;
			case 8:
				key = (string)kfOGLrhqxaefG9Y1HbJq(key, 1);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
				{
					num2 = 2;
				}
				continue;
			case 5:
				if (wQM5IZhq7JosTBeUsR6g(key, 0) == '@')
				{
					num2 = 8;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc != 0)
					{
						num2 = 5;
					}
					continue;
				}
				goto default;
			case 1:
				if (MmmZgJhqAKb2xXp6faSE(key) <= 1)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 != 0)
					{
						num2 = 0;
					}
					continue;
				}
				goto case 5;
			case 4:
			case 6:
				break;
			}
			break;
		}
		return key;
	}

	internal static void MOyjGIhq420tgJPUkJtu()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool OIcTJDhqtcDUESuNUdB0()
	{
		return PaJpNChqDibWZk1LYm6f == null;
	}

	internal static QueryParameters G9eTdPhqwAlOM6C9pFx8()
	{
		return PaJpNChqDibWZk1LYm6f;
	}

	internal static int P9vII1hq65E3QT6JQabO(object P_0)
	{
		return ((ICollection<KeyValuePair<string, object>>)P_0).Count;
	}

	internal static object QjVRkLhqHPBkgYscUtXL(object P_0)
	{
		return ((QueryParameter)P_0).Value;
	}

	internal static int MmmZgJhqAKb2xXp6faSE(object P_0)
	{
		return ((string)P_0).Length;
	}

	internal static char wQM5IZhq7JosTBeUsR6g(object P_0, int P_1)
	{
		return ((string)P_0)[P_1];
	}

	internal static object kfOGLrhqxaefG9Y1HbJq(object P_0, int P_1)
	{
		return ((string)P_0).Substring(P_1);
	}

	internal static object EanyvThq0FFlXBFE1EBK(object P_0, int P_1, int P_2)
	{
		return ((string)P_0).Substring(P_1, P_2);
	}

	internal static object cCUvQphqmrMj7UGSbFA6(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}
}
