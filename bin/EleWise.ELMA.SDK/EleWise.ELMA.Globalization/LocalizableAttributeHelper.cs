using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Globalization;

public static class LocalizableAttributeHelper
{
	private class TypeLocalizer
	{
		internal readonly Dictionary<string, PropertyInfo> LocalizableProperties;

		internal static object uUX4PMvgLBnJPAv6tdph;

		internal TypeLocalizer(Type type)
		{
			//Discarded unreachable code: IL_002a, IL_002f, IL_0050, IL_005f, IL_006a, IL_012d, IL_013c, IL_015d, IL_019d, IL_01ac, IL_01b8, IL_01c7
			pCVpnnvgc566yK7cFI9H();
			LocalizableProperties = new Dictionary<string, PropertyInfo>();
			base._002Ector();
			int num = 2;
			IEnumerator<PropertyInfo> enumerator = default(IEnumerator<PropertyInfo>);
			PropertyInfo current = default(PropertyInfo);
			while (true)
			{
				switch (num)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					try
					{
						while (true)
						{
							int num2;
							if (!enumerator.MoveNext())
							{
								num2 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
								{
									num2 = 0;
								}
								goto IL_006e;
							}
							goto IL_0105;
							IL_0105:
							current = enumerator.Current;
							num2 = 2;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c != 0)
							{
								num2 = 2;
							}
							goto IL_006e;
							IL_006e:
							while (true)
							{
								switch (num2)
								{
								default:
									return;
								case 0:
									return;
								case 2:
									if (!VWvCuYv5BKtl2HssOp5M(current, d6naJRv5FYFA3Qoxnq8j(typeof(LocalizableAttribute).TypeHandle), true))
									{
										num2 = 3;
										continue;
									}
									goto case 4;
								case 4:
									LocalizableProperties.Add((string)qYvwCJv5WebdAPH8hkdt(current), current);
									num2 = 4;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
									{
										num2 = 5;
									}
									continue;
								case 3:
								case 5:
									break;
								case 1:
									goto IL_0105;
								}
								break;
							}
						}
					}
					finally
					{
						int num3;
						if (enumerator == null)
						{
							num3 = 2;
							goto IL_0161;
						}
						goto IL_0177;
						IL_0161:
						switch (num3)
						{
						case 2:
							goto end_IL_014c;
						case 1:
							goto end_IL_014c;
						}
						goto IL_0177;
						IL_0177:
						zg6DdMv5o7s0Awm5LTSr(enumerator);
						num3 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0)
						{
							num3 = 0;
						}
						goto IL_0161;
						end_IL_014c:;
					}
				case 2:
					enumerator = ((IEnumerable<PropertyInfo>)Y8nlXLvgzEnJLsWS9mhr(type, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.FlattenHierarchy)).Where(delegate(PropertyInfo p)
					{
						//Discarded unreachable code: IL_0063, IL_0072, IL_0081
						int num4 = 4;
						int num5 = num4;
						while (true)
						{
							switch (num5)
							{
							default:
								return _003C_003Ec.hFSK8nZkcOZsyRCyXO7E(p);
							case 1:
							case 3:
								return false;
							case 2:
								if (!_003C_003Ec.wct7H6Zks7YW3wpQOkIa(p))
								{
									num5 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
									{
										num5 = 0;
									}
									break;
								}
								goto default;
							case 4:
								if (((Array)_003C_003Ec.jdgLmVZkUspP7E33OCsG(p)).Length != 0)
								{
									num5 = 3;
									break;
								}
								goto case 2;
							}
						}
					}).GetEnumerator();
					num = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0)
					{
						num = 1;
					}
					break;
				}
			}
		}

		internal void Localize(ObjectLocalizer objectLocalizer)
		{
			//Discarded unreachable code: IL_0033, IL_003d, IL_0094, IL_0147, IL_0156, IL_018c, IL_0196, IL_0244, IL_0267, IL_0276, IL_02a4, IL_02b3, IL_02d6, IL_038a, IL_039d, IL_03ac
			int num = 2;
			int num2 = num;
			Dictionary<string, PropertyInfo>.ValueCollection.Enumerator enumerator = default(Dictionary<string, PropertyInfo>.ValueCollection.Enumerator);
			PropertyInfo current = default(PropertyInfo);
			object value = default(object);
			string text = default(string);
			object refObject = default(object);
			IEnumerable enumerable = default(IEnumerable);
			IEnumerator enumerator2 = default(IEnumerator);
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 0:
					return;
				case 3:
					try
					{
						while (true)
						{
							int num3;
							if (!enumerator.MoveNext())
							{
								num3 = 15;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 != 0)
								{
									num3 = 15;
								}
								goto IL_0041;
							}
							goto IL_012f;
							IL_012f:
							current = enumerator.Current;
							num3 = 11;
							goto IL_0041;
							IL_0041:
							while (true)
							{
								switch (num3)
								{
								case 15:
									return;
								case 5:
								case 7:
								case 8:
								case 10:
								case 12:
									break;
								default:
									if (value == null)
									{
										num3 = 7;
										continue;
									}
									goto case 13;
								case 16:
									if (HuK4l2v5EE6R4yKuwjLx(text))
									{
										num3 = 8;
										continue;
									}
									goto case 1;
								case 1:
									akALn1v5QxjdwuN7iM6I(current, refObject, m40Z2Dv5fy2tdXpxvdk4(text), null);
									num3 = 8;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0)
									{
										num3 = 12;
									}
									continue;
								case 13:
									if ((enumerable = value as IEnumerable) != null)
									{
										num3 = 14;
										continue;
									}
									goto IL_0321;
								case 6:
									goto IL_012f;
								case 11:
									if (cbl6Kuv5hSZ9hbEGKlTT(CBCLXmv5bcTXKBrWCCxW(current), typeof(string)))
									{
										num3 = 2;
										continue;
									}
									goto case 4;
								case 9:
									try
									{
										while (true)
										{
											int num4;
											if (!enumerator2.MoveNext())
											{
												num4 = 3;
												goto IL_019a;
											}
											goto IL_01ca;
											IL_019a:
											switch (num4)
											{
											case 2:
												goto IL_01ca;
											case 3:
												goto end_IL_01b4;
											}
											continue;
											IL_01ca:
											ILocalizable localizable = GetLocalizable(Qx3CGuv5vy94mkqkMqHG(enumerator2));
											if (localizable == null)
											{
												num4 = 1;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
												{
													num4 = 0;
												}
											}
											else
											{
												localizable.Localize(objectLocalizer);
												num4 = 0;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
												{
													num4 = 0;
												}
											}
											goto IL_019a;
											continue;
											end_IL_01b4:
											break;
										}
									}
									finally
									{
										IDisposable disposable = enumerator2 as IDisposable;
										int num5 = 1;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 != 0)
										{
											num5 = 0;
										}
										while (true)
										{
											switch (num5)
											{
											case 2:
												break;
											default:
												zg6DdMv5o7s0Awm5LTSr(disposable);
												num5 = 3;
												continue;
											case 1:
												if (disposable == null)
												{
													num5 = 2;
													continue;
												}
												goto default;
											case 3:
												break;
											}
											break;
										}
									}
									break;
								case 14:
									enumerator2 = (IEnumerator)c3Th3pv5COfBgqQOKnDt(enumerable);
									num3 = 9;
									continue;
								case 4:
									value = current.GetValue(refObject, null);
									num3 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0)
									{
										num3 = 0;
									}
									continue;
								case 2:
									text = (string)mPXexiv5G1ywkd1daw3l(current, refObject, null);
									num3 = 16;
									continue;
								case 3:
									goto IL_0321;
								}
								break;
								IL_0321:
								object obj = vvt1LTv58hl3fvOIYPhh(value);
								if (obj == null)
								{
									num3 = 5;
									continue;
								}
								E4Lbdav5ZEYXG0PeElCr(obj, objectLocalizer);
								num3 = 10;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
								{
									num3 = 1;
								}
							}
						}
					}
					finally
					{
						((IDisposable)enumerator).Dispose();
						int num6 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0)
						{
							num6 = 0;
						}
						switch (num6)
						{
						case 0:
							break;
						}
					}
				case 2:
					refObject = objectLocalizer.RefObject;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
					{
						num2 = 1;
					}
					break;
				case 1:
					enumerator = LocalizableProperties.Values.GetEnumerator();
					num2 = 3;
					break;
				}
			}
		}

		internal IEnumerable<string> GetStrings(ObjectLocalizer objectLocalizer)
		{
			HashSet<string> hashSet = new HashSet<string>();
			object refObject = objectLocalizer.RefObject;
			foreach (PropertyInfo value2 in LocalizableProperties.Values)
			{
				if (value2.PropertyType == typeof(string))
				{
					string text = (string)value2.GetValue(refObject, null);
					if (!string.IsNullOrEmpty(text))
					{
						hashSet.Add(text);
					}
					continue;
				}
				object value = value2.GetValue(refObject, null);
				if (value == null)
				{
					continue;
				}
				if (value is IEnumerable enumerable)
				{
					foreach (object item in enumerable)
					{
						ILocalizable localizable = GetLocalizable(item);
						if (localizable == null)
						{
							continue;
						}
						foreach (string @string in localizable.GetStrings(objectLocalizer))
						{
							hashSet.Add(@string);
						}
					}
					continue;
				}
				ILocalizable localizable2 = GetLocalizable(value);
				if (localizable2 == null)
				{
					continue;
				}
				foreach (string string2 in localizable2.GetStrings(objectLocalizer))
				{
					hashSet.Add(string2);
				}
			}
			return hashSet;
		}

		internal static void pCVpnnvgc566yK7cFI9H()
		{
			SingletonReader.JJCZtPuTvSt();
		}

		internal static object Y8nlXLvgzEnJLsWS9mhr(Type type, BindingFlags bindingAttr)
		{
			return type.GetReflectionProperties(bindingAttr);
		}

		internal static Type d6naJRv5FYFA3Qoxnq8j(RuntimeTypeHandle P_0)
		{
			return Type.GetTypeFromHandle(P_0);
		}

		internal static bool VWvCuYv5BKtl2HssOp5M(object P_0, Type P_1, bool P_2)
		{
			return ((MemberInfo)P_0).IsDefined(P_1, P_2);
		}

		internal static object qYvwCJv5WebdAPH8hkdt(object P_0)
		{
			return ((MemberInfo)P_0).Name;
		}

		internal static void zg6DdMv5o7s0Awm5LTSr(object P_0)
		{
			((IDisposable)P_0).Dispose();
		}

		internal static bool EW70u2vgUspFxLFHpMw5()
		{
			return uUX4PMvgLBnJPAv6tdph == null;
		}

		internal static TypeLocalizer V0kc1cvgsIjYENwo6HRi()
		{
			return (TypeLocalizer)uUX4PMvgLBnJPAv6tdph;
		}

		internal static Type CBCLXmv5bcTXKBrWCCxW(object P_0)
		{
			return ((PropertyInfo)P_0).PropertyType;
		}

		internal static bool cbl6Kuv5hSZ9hbEGKlTT(Type P_0, Type P_1)
		{
			return P_0 == P_1;
		}

		internal static object mPXexiv5G1ywkd1daw3l(object P_0, object P_1, object P_2)
		{
			return ((PropertyInfo)P_0).GetValue(P_1, (object[])P_2);
		}

		internal static bool HuK4l2v5EE6R4yKuwjLx(object P_0)
		{
			return string.IsNullOrEmpty((string)P_0);
		}

		internal static object m40Z2Dv5fy2tdXpxvdk4(object P_0)
		{
			return SR.T((string)P_0);
		}

		internal static void akALn1v5QxjdwuN7iM6I(object P_0, object P_1, object P_2, object P_3)
		{
			((PropertyInfo)P_0).SetValue(P_1, P_2, (object[])P_3);
		}

		internal static object c3Th3pv5COfBgqQOKnDt(object P_0)
		{
			return ((IEnumerable)P_0).GetEnumerator();
		}

		internal static object Qx3CGuv5vy94mkqkMqHG(object P_0)
		{
			return ((IEnumerator)P_0).Current;
		}

		internal static object vvt1LTv58hl3fvOIYPhh(object P_0)
		{
			return GetLocalizable(P_0);
		}

		internal static void E4Lbdav5ZEYXG0PeElCr(object P_0, object P_1)
		{
			((ILocalizable)P_0).Localize((ILocalizable)P_1);
		}
	}

	private class ObjectLocalizer : ILocalizable
	{
		private readonly object obj;

		private readonly object typeLocalizer;

		private static object sJR7Dxv5uTOtE3Is8xuL;

		internal object RefObject => obj;

		public IDictionary<string, PropertyInfo> LocalizableProperties => ((TypeLocalizer)typeLocalizer).LocalizableProperties;

		internal ObjectLocalizer(object obj, TypeLocalizer typeLocalizer)
		{
			//Discarded unreachable code: IL_001a, IL_001f
			nO1OeOv5S0HySNHxDWw7();
			base._002Ector();
			int num = 2;
			while (true)
			{
				switch (num)
				{
				case 2:
					this.obj = obj;
					num = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
					{
						num = 0;
					}
					break;
				case 1:
					return;
				default:
					this.typeLocalizer = typeLocalizer;
					num = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
					{
						num = 1;
					}
					break;
				}
			}
		}

		public void Localize(ILocalizable parent)
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
					MfyfF7v5i9fAWPwyTZRo(typeLocalizer, this);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}

		public IEnumerable<string> GetStrings(ILocalizable parent)
		{
			return ((TypeLocalizer)typeLocalizer).GetStrings(this);
		}

		internal static void nO1OeOv5S0HySNHxDWw7()
		{
			SingletonReader.JJCZtPuTvSt();
		}

		internal static bool dZJgibv5IUsJS0MexefW()
		{
			return sJR7Dxv5uTOtE3Is8xuL == null;
		}

		internal static ObjectLocalizer aAkqdFv5VNNi9ALYnThp()
		{
			return (ObjectLocalizer)sJR7Dxv5uTOtE3Is8xuL;
		}

		internal static void MfyfF7v5i9fAWPwyTZRo(object P_0, object P_1)
		{
			((TypeLocalizer)P_0).Localize((ObjectLocalizer)P_1);
		}
	}

	private static readonly Dictionary<Type, TypeLocalizer> localizers;

	internal static LocalizableAttributeHelper tPQoR9GfoRCNfkMRlFVw;

	public static void Localize(object obj)
	{
		//Discarded unreachable code: IL_0058, IL_0067
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 2:
				lQT5qcGfEPcefkjTyc2s(WiJs7SGfGTiB1WPmBDpF(obj), null);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				return;
			case 3:
				if (obj == null)
				{
					return;
				}
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	public static IEnumerable<string> GetStrings(object obj)
	{
		if (obj == null)
		{
			return new string[0];
		}
		return GetLocalizable(obj).GetStrings(null);
	}

	private static ILocalizable GetLocalizable(object obj)
	{
		//Discarded unreachable code: IL_007b
		int num = 1;
		int num2 = num;
		ILocalizable result = default(ILocalizable);
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (obj == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
					{
						num2 = 0;
					}
					break;
				}
				if ((result = obj as ILocalizable) == null)
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 3;
			default:
				return null;
			case 3:
				return result;
			case 2:
				return new ObjectLocalizer(obj, (TypeLocalizer)JpcLKgGffM1CXZTtFRrc(obj.GetType()));
			}
		}
	}

	private static TypeLocalizer GetLocalizer(Type type)
	{
		//Discarded unreachable code: IL_0064, IL_00dd, IL_011d, IL_012c, IL_0138, IL_0147
		int num = 2;
		int num2 = num;
		bool lockTaken = default(bool);
		TypeLocalizer value = default(TypeLocalizer);
		Dictionary<Type, TypeLocalizer> dictionary = default(Dictionary<Type, TypeLocalizer>);
		while (true)
		{
			switch (num2)
			{
			case 3:
				lockTaken = false;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
				{
					num2 = 4;
				}
				break;
			default:
				return value;
			case 4:
				try
				{
					Monitor.Enter(dictionary, ref lockTaken);
					int num3 = 2;
					while (true)
					{
						switch (num3)
						{
						default:
							return value;
						case 0:
							return value;
						case 2:
							value = new TypeLocalizer(type);
							num3 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
							{
								num3 = 1;
							}
							break;
						case 1:
							localizers[type] = value;
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
							{
								num3 = 0;
							}
							break;
						}
					}
				}
				finally
				{
					int num4;
					if (!lockTaken)
					{
						num4 = 2;
						goto IL_00e1;
					}
					goto IL_00f7;
					IL_00e1:
					switch (num4)
					{
					default:
						goto end_IL_00cc;
					case 1:
						break;
					case 2:
						goto end_IL_00cc;
					case 0:
						goto end_IL_00cc;
					}
					goto IL_00f7;
					IL_00f7:
					ku2hLeGfQkQX7QEYF5Ei(dictionary);
					num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
					{
						num4 = 0;
					}
					goto IL_00e1;
					end_IL_00cc:;
				}
			case 1:
				dictionary = localizers;
				num2 = 3;
				break;
			case 2:
				if (!localizers.TryGetValue(type, out value))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto default;
			}
		}
	}

	static LocalizableAttributeHelper()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			default:
				localizers = new Dictionary<Type, TypeLocalizer>();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 != 0)
				{
					num2 = 2;
				}
				break;
			case 1:
				Xk2x0sGfCxXE2gCA1m2L();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static object WiJs7SGfGTiB1WPmBDpF(object P_0)
	{
		return GetLocalizable(P_0);
	}

	internal static void lQT5qcGfEPcefkjTyc2s(object P_0, object P_1)
	{
		((ILocalizable)P_0).Localize((ILocalizable)P_1);
	}

	internal static bool rqnwgCGfbtpflSNRfhmk()
	{
		return tPQoR9GfoRCNfkMRlFVw == null;
	}

	internal static LocalizableAttributeHelper HDKBodGfhinnZGbcCqSJ()
	{
		return tPQoR9GfoRCNfkMRlFVw;
	}

	internal static object JpcLKgGffM1CXZTtFRrc(Type type)
	{
		return GetLocalizer(type);
	}

	internal static void ku2hLeGfQkQX7QEYF5Ei(object P_0)
	{
		Monitor.Exit(P_0);
	}

	internal static void Xk2x0sGfCxXE2gCA1m2L()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
