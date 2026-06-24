using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Engine;
using NHibernate.Impl;
using NHibernate.Type;
using NHibernate.Util;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Runtime.NH;

public class SqlSubQuery
{
	private string baseSql;

	private string resultSql;

	private TypedValue[] resultParameters;

	private Dictionary<string, TypedValue> parameters;

	private Dictionary<string, TypedValue> parametersLists;

	private bool changed;

	private EntityMode entityMode;

	internal static SqlSubQuery JpOeDjWwBL2bKPmk0C57;

	public string Sql
	{
		get
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return resultSql;
				case 1:
					Prepare();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public TypedValue[] Parameters
	{
		get
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					Prepare();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0)
					{
						num2 = 0;
					}
					break;
				default:
					return resultParameters;
				}
			}
		}
	}

	public object[] ParametersValues
	{
		get
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					Prepare();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
					{
						num2 = 0;
					}
					break;
				default:
					return resultParameters.Select((TypedValue p) => _003C_003Ec.JTCURKQdAKoLLjKdxRRM(p)).ToArray();
				}
			}
		}
	}

	public IType[] ParametersTypes
	{
		get
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					Prepare();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
					{
						num2 = 0;
					}
					break;
				default:
					return resultParameters.Select((TypedValue p) => p.get_Type()).ToArray();
				}
			}
		}
	}

	public SqlSubQuery(SqlQueryImpl query, ISession session)
	{
		//Discarded unreachable code: IL_0031, IL_0036
		YJsG5GWwbxdE1pOv6HT0();
		this._002Ector((string)rRIZnrWwhm3BtSFEdWrC(query), session);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public SqlSubQuery(string queryString, ISession session)
	{
		//Discarded unreachable code: IL_0056, IL_005b
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		YJsG5GWwbxdE1pOv6HT0();
		parameters = new Dictionary<string, TypedValue>();
		parametersLists = new Dictionary<string, TypedValue>();
		changed = true;
		base._002Ector();
		int num = 2;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			default:
				entityMode = (EntityMode)0;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
				{
					num = 1;
				}
				break;
			case 2:
				baseSql = queryString;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public SqlSubQuery SetParameter(string name, object val)
	{
		//Discarded unreachable code: IL_0082, IL_0091
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (val != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			case 2:
				throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-345420348 ^ -345287386));
			default:
				SetParameter(name, val, DetermineType(name, val));
				num2 = 3;
				break;
			case 3:
				return this;
			}
		}
	}

	public SqlSubQuery SetParameter(string name, object val, IType type)
	{
		//Discarded unreachable code: IL_006f, IL_007e
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected O, but got Unknown
		int num = 4;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				throw new ArgumentNullException((string)fAlk1hWwGd78S7SHFM9d(0x12441CA4 ^ 0x124410B2));
			case 3:
				changed = true;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
				{
					num2 = 2;
				}
				break;
			case 1:
				return this;
			case 2:
				parameters[name] = new TypedValue(type, val);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0)
				{
					num2 = 1;
				}
				break;
			case 4:
				if (name != null)
				{
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
					{
						num2 = 3;
					}
					break;
				}
				goto default;
			}
		}
	}

	public SqlSubQuery SetParameterList(string name, ICollection vals)
	{
		//Discarded unreachable code: IL_00b8
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		int num = 1;
		int num2 = num;
		IEnumerator enumerator = default(IEnumerator);
		while (true)
		{
			switch (num2)
			{
			case 2:
				SetParameterList(name, vals, null);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
				{
					num2 = 3;
				}
				continue;
			case 3:
			case 6:
				return this;
			case 1:
				if (vals == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f != 0)
					{
						num2 = 0;
					}
					continue;
				}
				if (gxu5RVWwfmPeYKsO15oU(vals) == 0)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
					{
						num2 = 2;
					}
					continue;
				}
				break;
			case 5:
				SetParameterList(name, vals, DetermineType(name, XnuBmvWwvLI71QWYaP4p(enumerator)));
				num2 = 6;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
				{
					num2 = 3;
				}
				continue;
			case 7:
				zs3X2lWwCfc33t27T8GJ(enumerator);
				num2 = 5;
				continue;
			default:
				throw new QueryException((string)F3x0dOWwEA6qHVSxCifF(fAlk1hWwGd78S7SHFM9d(-105199646 ^ -105322738)));
			case 4:
				break;
			}
			enumerator = (IEnumerator)hgJHrZWwQLL0ADJSYJG8(vals);
			num2 = 7;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
			{
				num2 = 2;
			}
		}
	}

	public SqlSubQuery SetParameterList(string name, ICollection values, IType type)
	{
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected O, but got Unknown
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return this;
			case 2:
				changed = true;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc != 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				parametersLists[name] = new TypedValue(type, (object)values);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private string ExpandParameterList(string query, string name, TypedValue typedList, IDictionary<string, TypedValue> namedParamsCopy)
	{
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Expected O, but got Unknown
		ICollection collection = (ICollection)typedList.get_Value();
		IType type = typedList.get_Type();
		if (collection.Count == 1)
		{
			IEnumerator enumerator = collection.GetEnumerator();
			enumerator.MoveNext();
			namedParamsCopy[name] = new TypedValue(type, enumerator.Current);
			return query;
		}
		StringBuilder stringBuilder = new StringBuilder(16);
		int num = 0;
		bool flag = false;
		foreach (object item in collection)
		{
			if (num > 0)
			{
				stringBuilder.Append(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x2A7797B7 ^ 0x2A779BB5));
			}
			string text = (flag ? (z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2099751081 ^ -2099612057) + name) : (name + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1633514411 ^ -1633517521))) + num++ + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1767720453 ^ -1767721599);
			namedParamsCopy[text] = new TypedValue(type, item);
			stringBuilder.Append(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3A6135BE ^ 0x3A6064FC)).Append(text);
		}
		string text2 = (flag ? z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1998538950 ^ -1998540944) : z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x18A6761F ^ 0x18A7275D));
		return StringHelper.Replace(query, text2 + name, stringBuilder.ToString(), true);
	}

	private string ExpandParameterLists(IDictionary<string, TypedValue> namedParamsCopy)
	{
		string text = baseSql;
		foreach (KeyValuePair<string, TypedValue> parametersList in parametersLists)
		{
			text = ExpandParameterList(text, parametersList.Key, parametersList.Value, namedParamsCopy);
		}
		return text;
	}

	private void Prepare()
	{
		//Discarded unreachable code: IL_00ba, IL_00c4, IL_0186, IL_0199, IL_01a8, IL_01cf, IL_01de, IL_0225, IL_022f, IL_0376, IL_0389, IL_0398, IL_042a, IL_0434, IL_052c, IL_059e, IL_05b1
		int num = 15;
		Dictionary<string, TypedValue> dictionary = default(Dictionary<string, TypedValue>);
		List<Tuple<int, string, TypedValue>> list = default(List<Tuple<int, string, TypedValue>>);
		List<TypedValue> list2 = default(List<TypedValue>);
		Dictionary<string, TypedValue>.Enumerator enumerator = default(Dictionary<string, TypedValue>.Enumerator);
		KeyValuePair<string, TypedValue> current3 = default(KeyValuePair<string, TypedValue>);
		List<Tuple<int, string, TypedValue>>.Enumerator enumerator2 = default(List<Tuple<int, string, TypedValue>>.Enumerator);
		string text3 = default(string);
		Tuple<int, string, TypedValue> current2 = default(Tuple<int, string, TypedValue>);
		string text2 = default(string);
		int num7 = default(int);
		KeyValuePair<string, TypedValue> current = default(KeyValuePair<string, TypedValue>);
		int num4 = default(int);
		string text = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 0:
					return;
				case 14:
					dictionary = new Dictionary<string, TypedValue>();
					num2 = 6;
					continue;
				case 10:
					list = new List<Tuple<int, string, TypedValue>>();
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
					{
						num2 = 1;
					}
					continue;
				case 13:
					list2 = new List<TypedValue>();
					num2 = 16;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
					{
						num2 = 6;
					}
					continue;
				case 5:
					try
					{
						while (true)
						{
							IL_0111:
							int num9;
							if (!enumerator.MoveNext())
							{
								num9 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 != 0)
								{
									num9 = 0;
								}
								goto IL_00c8;
							}
							goto IL_0137;
							IL_0137:
							current3 = enumerator.Current;
							num9 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
							{
								num9 = 3;
							}
							goto IL_00c8;
							IL_00c8:
							while (true)
							{
								switch (num9)
								{
								case 3:
									dictionary[current3.Key] = current3.Value;
									num9 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad != 0)
									{
										num9 = 1;
									}
									continue;
								case 1:
									goto IL_0111;
								case 2:
									goto IL_0137;
								case 0:
									break;
								}
								break;
							}
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator).Dispose();
						int num10 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
						{
							num10 = 0;
						}
						switch (num10)
						{
						case 0:
							break;
						}
					}
					goto case 9;
				case 1:
					goto end_IL_0012;
				case 7:
					changed = false;
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
					{
						num2 = 2;
					}
					continue;
				case 15:
					if (!changed)
					{
						return;
					}
					num2 = 14;
					continue;
				case 8:
					try
					{
						while (true)
						{
							IL_02cc:
							int num6;
							if (!enumerator2.MoveNext())
							{
								num6 = 6;
								goto IL_0233;
							}
							goto IL_02a9;
							IL_0233:
							while (true)
							{
								switch (num6)
								{
								case 3:
									text3 = (string)tRwGLeWw8tVGn7vmnciE(fAlk1hWwGd78S7SHFM9d(0x35C0467B ^ 0x35C11739), current2.Item2);
									num6 = 5;
									continue;
								case 1:
									list2.Add(current2.Item3);
									num6 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
									{
										num6 = 0;
									}
									continue;
								case 4:
									break;
								default:
									goto IL_02cc;
								case 2:
									text2 = (string)HaEhXkWwSBAP7J22ZZjq(GrkU7jWwIHvQNwyrPj9a(text2, 0, num7), fAlk1hWwGd78S7SHFM9d(0x34A6D230 ^ 0x34A6CA7A), B08VfZWwVQlTofUTw4ZR(text2, num7 + text3.Length));
									num6 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0)
									{
										num6 = 0;
									}
									continue;
								case 5:
									num7 = xjr6ipWwZWlV7BlfJaeA(text2, text3, StringComparison.InvariantCultureIgnoreCase);
									num6 = 2;
									continue;
								case 6:
									goto end_IL_02cc;
								}
								break;
							}
							goto IL_02a9;
							IL_02a9:
							current2 = enumerator2.Current;
							num6 = 3;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
							{
								num6 = 3;
							}
							goto IL_0233;
							continue;
							end_IL_02cc:
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator2).Dispose();
						int num8 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0)
						{
							num8 = 0;
						}
						switch (num8)
						{
						case 0:
							break;
						}
					}
					goto case 12;
				case 12:
					resultSql = text2;
					num2 = 3;
					continue;
				case 3:
					resultParameters = (TypedValue[])nr03M7WwimDSo9ZFFx0o(list2);
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
					{
						num2 = 7;
					}
					continue;
				case 9:
					text2 = ExpandParameterLists(dictionary);
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
					{
						num2 = 10;
					}
					continue;
				case 16:
					enumerator2 = list.GetEnumerator();
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0)
					{
						num2 = 8;
					}
					continue;
				case 2:
					return;
				case 11:
					try
					{
						while (true)
						{
							IL_054c:
							int num3;
							if (!enumerator.MoveNext())
							{
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
								{
									num3 = 0;
								}
								goto IL_0438;
							}
							goto IL_048c;
							IL_048c:
							current = enumerator.Current;
							num3 = 4;
							goto IL_0438;
							IL_0438:
							while (true)
							{
								switch (num3)
								{
								case 1:
									num4 = xjr6ipWwZWlV7BlfJaeA(text2, text, StringComparison.InvariantCultureIgnoreCase);
									num3 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
									{
										num3 = 3;
									}
									continue;
								case 6:
									goto IL_048c;
								case 4:
									text = (string)tRwGLeWw8tVGn7vmnciE(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x35C0467B ^ 0x35C11739), current.Key);
									num3 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0)
									{
										num3 = 1;
									}
									continue;
								case 7:
									list.Add(new Tuple<int, string, TypedValue>(num4, current.Key, current.Value));
									num3 = 2;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
									{
										num3 = 2;
									}
									continue;
								case 2:
									num4 = YPKmONWwu5Cwe83oDgei(text2, text, num4 + 1, StringComparison.InvariantCultureIgnoreCase);
									num3 = 5;
									continue;
								case 3:
								case 5:
									if (num4 <= 0)
									{
										num3 = 8;
										continue;
									}
									goto case 7;
								case 8:
									goto IL_054c;
								case 0:
									break;
								}
								break;
							}
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator).Dispose();
						int num5 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0)
						{
							num5 = 0;
						}
						switch (num5)
						{
						case 0:
							break;
						}
					}
					break;
				case 6:
					enumerator = parameters.GetEnumerator();
					num2 = 5;
					continue;
				case 4:
					break;
				}
				list = list.OrderBy((Tuple<int, string, TypedValue> t) => t.Item1).ToList();
				num2 = 13;
				continue;
				end_IL_0012:
				break;
			}
			enumerator = dictionary.GetEnumerator();
			num = 11;
		}
	}

	private IType DetermineType(string paramName, object paramValue)
	{
		return NHibernateUtil.GuessType(paramValue);
	}

	internal static void YJsG5GWwbxdE1pOv6HT0()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object rRIZnrWwhm3BtSFEdWrC(object P_0)
	{
		return ((AbstractQueryImpl)P_0).get_QueryString();
	}

	internal static bool sfaWg2WwWBml1EsRyrCh()
	{
		return JpOeDjWwBL2bKPmk0C57 == null;
	}

	internal static SqlSubQuery AgvZgcWwoFFfw1ppk0Wf()
	{
		return JpOeDjWwBL2bKPmk0C57;
	}

	internal static object fAlk1hWwGd78S7SHFM9d(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object F3x0dOWwEA6qHVSxCifF(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static int gxu5RVWwfmPeYKsO15oU(object P_0)
	{
		return ((ICollection)P_0).Count;
	}

	internal static object hgJHrZWwQLL0ADJSYJG8(object P_0)
	{
		return ((IEnumerable)P_0).GetEnumerator();
	}

	internal static bool zs3X2lWwCfc33t27T8GJ(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static object XnuBmvWwvLI71QWYaP4p(object P_0)
	{
		return ((IEnumerator)P_0).Current;
	}

	internal static object tRwGLeWw8tVGn7vmnciE(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static int xjr6ipWwZWlV7BlfJaeA(object P_0, object P_1, StringComparison P_2)
	{
		return ((string)P_0).IndexOf((string)P_1, P_2);
	}

	internal static int YPKmONWwu5Cwe83oDgei(object P_0, object P_1, int P_2, StringComparison P_3)
	{
		return ((string)P_0).IndexOf((string)P_1, P_2, P_3);
	}

	internal static object GrkU7jWwIHvQNwyrPj9a(object P_0, int P_1, int P_2)
	{
		return ((string)P_0).Substring(P_1, P_2);
	}

	internal static object B08VfZWwVQlTofUTw4ZR(object P_0, int P_1)
	{
		return ((string)P_0).Substring(P_1);
	}

	internal static object HaEhXkWwSBAP7J22ZZjq(object P_0, object P_1, object P_2)
	{
		return (string)P_0 + (string)P_1 + (string)P_2;
	}

	internal static object nr03M7WwimDSo9ZFFx0o(object P_0)
	{
		return ((List<TypedValue>)P_0).ToArray();
	}
}
