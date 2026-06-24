using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Attributes;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Helpers;

internal class BlockComparer : Comparer
{
	private readonly string[] propertiesToIgnore;

	private static BlockComparer BAfC93hzo30WUxaYaFxB;

	public BlockComparer()
	{
		//Discarded unreachable code: IL_008e, IL_0093
		Y82PsnhzGmiE9rSDo9BU();
		propertiesToIgnore = new string[4]
		{
			(string)MCfqwXhzEKPHxLqNyZEC(-289714582 ^ -289866600),
			z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x2A7797B7 ^ 0x2A77F825),
			(string)MCfqwXhzEKPHxLqNyZEC(-1886646897 ^ -1886614319),
			(string)MCfqwXhzEKPHxLqNyZEC(0x1C9495B4 ^ 0x1C940582)
		};
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			}
			Expression = delegate(object x, object y)
			{
				//Discarded unreachable code: IL_0070, IL_007f, IL_0111, IL_01c6, IL_022b, IL_023a, IL_024a, IL_0259, IL_02ae, IL_0337, IL_0378, IL_0387, IL_043b, IL_044a, IL_045a, IL_048a, IL_04a9, IL_04b8, IL_04d5, IL_04e4
				int num2 = 2;
				int num3 = num2;
				IEnumerator<PropertyInfo> enumerator = default(IEnumerator<PropertyInfo>);
				PropertyInfo current = default(PropertyInfo);
				bool result = default(bool);
				_003C_003Ec__DisplayClass1_0 _003C_003Ec__DisplayClass1_ = default(_003C_003Ec__DisplayClass1_0);
				object value = default(object);
				object[] array = default(object[]);
				object obj = default(object);
				while (true)
				{
					switch (num3)
					{
					case 2:
						enumerator = (from property in x.GetType().GetReflectionProperties()
							where !propertiesToIgnore.Contains((string)Vd3oKyhzvRBK3vm1lq9y(property))
							select property).GetEnumerator();
						num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
						{
							num3 = 1;
						}
						continue;
					case 1:
						try
						{
							while (true)
							{
								IL_0283:
								int num4;
								if (!HTuWeihzCiQV2e1p0T64(enumerator))
								{
									num4 = 27;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0)
									{
										num4 = 9;
									}
									goto IL_008e;
								}
								goto IL_0189;
								IL_0189:
								current = enumerator.Current;
								num4 = 19;
								goto IL_008e;
								IL_008e:
								while (true)
								{
									int num5;
									switch (num4)
									{
									case 23:
										return result;
									case 25:
										return result;
									case 9:
										if (is4ewThzQtUMERp3LJ8T(current, x, null).Equals(is4ewThzQtUMERp3LJ8T(current, y, null)))
										{
											num4 = 2;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
											{
												num4 = 4;
											}
											continue;
										}
										goto case 1;
									case 13:
										_003C_003Ec__DisplayClass1_.y1 = (is4ewThzQtUMERp3LJ8T(current, y, null) as IEnumerable).CastToArrayOrNull<object>();
										num4 = 4;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
										{
											num4 = 6;
										}
										continue;
									case 7:
										break;
									case 3:
										value = current.GetValue(y, null);
										num4 = 10;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
										{
											num4 = 1;
										}
										continue;
									case 26:
										if (array.Length == _003C_003Ec__DisplayClass1_.y1.Length)
										{
											num5 = 21;
											goto IL_008a;
										}
										goto case 17;
									case 19:
										if (!current.GetCustomAttributes(hee5nZhzfZ2evA8idHAl(typeof(TablePartPropertyAttribute).TypeHandle), inherit: false).Any())
										{
											num4 = 20;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
											{
												num4 = 6;
											}
											continue;
										}
										goto case 28;
									case 24:
										array = (is4ewThzQtUMERp3LJ8T(current, x, null) as IEnumerable).CastToArrayOrNull<object>();
										num4 = 13;
										continue;
									case 4:
									case 5:
									case 8:
									case 12:
										goto IL_0283;
									case 17:
									case 22:
										result = false;
										num4 = 23;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 != 0)
										{
											num4 = 1;
										}
										continue;
									case 11:
									case 15:
										if (obj == null)
										{
											num4 = 1;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0)
											{
												num4 = 12;
											}
											continue;
										}
										goto case 9;
									case 21:
										if (!array.Where(_003C_003Ec__DisplayClass1_._003C_002Ector_003Eb__2).Any())
										{
											num4 = 5;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
											{
												num4 = 2;
											}
											continue;
										}
										goto case 17;
									case 1:
									case 2:
										result = false;
										num5 = 25;
										goto IL_008a;
									case 28:
										_003C_003Ec__DisplayClass1_ = new _003C_003Ec__DisplayClass1_0();
										num4 = 16;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b != 0)
										{
											num4 = 5;
										}
										continue;
									case 6:
										if (array == null)
										{
											num5 = 22;
											goto IL_008a;
										}
										goto default;
									case 18:
									case 20:
										obj = is4ewThzQtUMERp3LJ8T(current, x, null);
										num4 = 3;
										continue;
									default:
										if (_003C_003Ec__DisplayClass1_.y1 != null)
										{
											num4 = 14;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
											{
												num4 = 26;
											}
											continue;
										}
										goto case 17;
									case 16:
										_003C_003Ec__DisplayClass1_._003C_003E4__this = this;
										num4 = 24;
										continue;
									case 10:
										if (obj != null)
										{
											num4 = 2;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
											{
												num4 = 11;
											}
											continue;
										}
										goto case 14;
									case 14:
										if (value != null)
										{
											num4 = 1;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
											{
												num4 = 1;
											}
											continue;
										}
										goto case 11;
									case 27:
										goto end_IL_0283;
										IL_008a:
										num4 = num5;
										continue;
									}
									break;
								}
								goto IL_0189;
								continue;
								end_IL_0283:
								break;
							}
						}
						finally
						{
							int num6;
							if (enumerator == null)
							{
								num6 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
								{
									num6 = 0;
								}
								goto IL_048e;
							}
							goto IL_04c3;
							IL_04c3:
							enumerator.Dispose();
							num6 = 2;
							goto IL_048e;
							IL_048e:
							switch (num6)
							{
							default:
								goto end_IL_0469;
							case 0:
								goto end_IL_0469;
							case 1:
								break;
							case 2:
								goto end_IL_0469;
							}
							goto IL_04c3;
							end_IL_0469:;
						}
						break;
					}
					break;
				}
				return true;
			};
			num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff != 0)
			{
				num = 1;
			}
		}
	}

	internal static void Y82PsnhzGmiE9rSDo9BU()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object MCfqwXhzEKPHxLqNyZEC(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool aPEDuAhzbnAsVy8No3Y8()
	{
		return BAfC93hzo30WUxaYaFxB == null;
	}

	internal static BlockComparer gFusG1hzhHta5tNwywHm()
	{
		return BAfC93hzo30WUxaYaFxB;
	}

	internal static Type hee5nZhzfZ2evA8idHAl(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object is4ewThzQtUMERp3LJ8T(object P_0, object P_1, object P_2)
	{
		return ((PropertyInfo)P_0).GetValue(P_1, (object[])P_2);
	}

	internal static bool HTuWeihzCiQV2e1p0T64(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static object Vd3oKyhzvRBK3vm1lq9y(object P_0)
	{
		return ((MemberInfo)P_0).Name;
	}
}
