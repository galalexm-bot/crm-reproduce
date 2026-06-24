using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.ExpressionUtil;

internal static class Tools
{
	private static class EmptyArray<T>
	{
		public static readonly T[] Value;

		private static object BnBg6888JR2qgeWkGGB3;

		static EmptyArray()
		{
			int num = 2;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					Value = new T[0];
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				case 2:
					SingletonReader.JJCZtPuTvSt();
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
					{
						num2 = 1;
					}
					break;
				}
			}
		}

		internal static bool cFUCLM889ggo4ACWUtHl()
		{
			return BnBg6888JR2qgeWkGGB3 == null;
		}

		internal static object LI2FiD88dFGLfplq0Ox2()
		{
			return BnBg6888JR2qgeWkGGB3;
		}
	}

	internal static MethodInfo DelegateTargetGetterMethod;

	internal static Tools brv0bJGrbENj8dJdyka2;

	internal static bool IsValueType(this Type type)
	{
		return type.GetTypeInfo().IsValueType;
	}

	internal static bool IsPrimitive(this Type type)
	{
		return type.GetTypeInfo().IsPrimitive;
	}

	internal static bool IsClass(this Type type)
	{
		return type.GetTypeInfo().IsClass;
	}

	internal static bool IsUnsigned(this Type type)
	{
		//Discarded unreachable code: IL_0039, IL_0077, IL_0086
		int num = 4;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					if (!cCsqYHGrf12VIfbSV7t8(type, aItOFvGrEWH6f3abWgvu(typeof(ushort).TypeHandle)))
					{
						num2 = 5;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
						{
							num2 = 5;
						}
						break;
					}
					goto case 1;
				case 2:
					return cCsqYHGrf12VIfbSV7t8(type, aItOFvGrEWH6f3abWgvu(typeof(ulong).TypeHandle));
				case 1:
				case 3:
					return true;
				case 4:
					if (cCsqYHGrf12VIfbSV7t8(type, aItOFvGrEWH6f3abWgvu(typeof(byte).TypeHandle)))
					{
						goto end_IL_0012;
					}
					goto default;
				case 5:
					if (cCsqYHGrf12VIfbSV7t8(type, aItOFvGrEWH6f3abWgvu(typeof(uint).TypeHandle)))
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0)
						{
							num2 = 1;
						}
						break;
					}
					goto case 2;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 3;
		}
	}

	internal static bool IsNullable(this Type type)
	{
		//Discarded unreachable code: IL_004a, IL_0059
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return cCsqYHGrf12VIfbSV7t8(((Type)XHYPfQGrQDHsoGIrhDrJ(type)).GetGenericTypeDefinition(), aItOFvGrEWH6f3abWgvu(typeof(Nullable<>).TypeHandle));
			case 1:
				return false;
			case 2:
				if (!((Type)XHYPfQGrQDHsoGIrhDrJ(type)).IsGenericType)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			}
		}
	}

	internal static MethodInfo FindMethod(this Type type, string methodName)
	{
		//Discarded unreachable code: IL_005e, IL_008a, IL_0099
		int num = 3;
		int num3 = default(int);
		MethodInfo[] array = default(MethodInfo[]);
		TypeInfo typeInfo = default(TypeInfo);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
				case 5:
					if (num3 >= array.Length)
					{
						num2 = 7;
						continue;
					}
					goto default;
				case 4:
					num3 = 0;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
					{
						num2 = 1;
					}
					continue;
				case 3:
					typeInfo = (TypeInfo)XHYPfQGrQDHsoGIrhDrJ(type);
					num2 = 2;
					continue;
				case 7:
				{
					Type baseType = typeInfo.BaseType;
					if ((object)baseType == null)
					{
						num2 = 8;
						continue;
					}
					return (MethodInfo)mvJNeOGrCbIOM4kvQdVY(baseType, methodName);
				}
				default:
					if (!(array[num3].Name == methodName))
					{
						num2 = 9;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
						{
							num2 = 9;
						}
						continue;
					}
					goto case 6;
				case 6:
					return array[num3];
				case 9:
					break;
				case 2:
					array = typeInfo.DeclaredMethods.AsArray();
					num2 = 4;
					continue;
				case 8:
					return null;
				}
				break;
			}
			num3++;
			num = 5;
		}
	}

	internal static MethodInfo FindDelegateInvokeMethod(this Type type)
	{
		return type.GetTypeInfo().GetDeclaredMethod((string)SdpooBGrvReQNfVRg4LM(-672123589 ^ -672127133));
	}

	internal static MethodInfo FindNullableGetValueOrDefaultMethod(this Type type)
	{
		//Discarded unreachable code: IL_008d, IL_009c, IL_0109, IL_0118, IL_0174
		int num = 2;
		int num2 = num;
		MethodInfo methodInfo = default(MethodInfo);
		int num3 = default(int);
		MethodInfo[] array = default(MethodInfo[]);
		while (true)
		{
			switch (num2)
			{
			case 9:
				return methodInfo;
			case 8:
			case 10:
				num3++;
				num2 = 7;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
				{
					num2 = 6;
				}
				break;
			case 5:
				if (((Array)Mnw0OvGr8qogxQXi6xUR(methodInfo)).Length != 0)
				{
					num2 = 8;
					break;
				}
				goto case 3;
			case 6:
				return null;
			case 4:
			case 7:
				if (num3 < array.Length)
				{
					num2 = 11;
					break;
				}
				goto case 6;
			case 1:
				num3 = 0;
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
				{
					num2 = 4;
				}
				break;
			case 3:
				if (!((string)IE62N6GrZlJqyRybPcFT(methodInfo) == (string)SdpooBGrvReQNfVRg4LM(0x3B36AB09 ^ 0x3B32BA03)))
				{
					num2 = 10;
					break;
				}
				goto case 9;
			default:
				methodInfo = array[num3];
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
				{
					num2 = 5;
				}
				break;
			case 2:
				array = ((TypeInfo)XHYPfQGrQDHsoGIrhDrJ(type)).DeclaredMethods.AsArray();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	internal static MethodInfo FindValueGetterMethod(this Type type)
	{
		return (MethodInfo)baXoZPGruGlrdXDJFHTO(type, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7247028A ^ 0x7247A4DE));
	}

	internal static MethodInfo FindNullableHasValueGetterMethod(this Type type)
	{
		return (MethodInfo)baXoZPGruGlrdXDJFHTO(type, SdpooBGrvReQNfVRg4LM(-1411196499 ^ -1410938723));
	}

	internal static MethodInfo FindPropertyGetMethod(this Type propHolderType, string propName)
	{
		//Discarded unreachable code: IL_0093, IL_00a2, IL_0274, IL_0283
		int num = 16;
		int num4 = default(int);
		string text = default(string);
		MethodInfo methodInfo = default(MethodInfo);
		int num3 = default(int);
		MethodInfo[] array = default(MethodInfo[]);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 7:
				case 13:
					if (num4 != -1)
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
						{
							num2 = 5;
						}
						continue;
					}
					goto case 1;
				case 9:
				{
					Type baseType = ((Type)XHYPfQGrQDHsoGIrhDrJ(propHolderType)).BaseType;
					if ((object)baseType == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					return (MethodInfo)baXoZPGruGlrdXDJFHTO(baseType, propName);
				}
				case 8:
					if (text[0] == 'g')
					{
						num2 = 6;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
						{
							num2 = 5;
						}
						continue;
					}
					goto case 4;
				case 1:
					if (num4 == -1)
					{
						num2 = 10;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
						{
							num2 = 4;
						}
						continue;
					}
					goto case 4;
				case 11:
					num4 = VZ5Tj8GrVSW9ZUCNCU3W(propName) - 1;
					num2 = 9;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
					{
						num2 = 13;
					}
					continue;
				case 6:
					if (text[3] == '_')
					{
						num2 = 11;
						continue;
					}
					goto case 4;
				case 19:
					text = (string)IE62N6GrZlJqyRybPcFT(methodInfo);
					num2 = 3;
					continue;
				case 5:
					if (JwP2VVGrSAsMjqWxyAgL(propName, num4) != JwP2VVGrSAsMjqWxyAgL(text, num4 + 4))
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0)
						{
							num2 = 1;
						}
						continue;
					}
					break;
				case 17:
				case 18:
					if (num3 >= array.Length)
					{
						num2 = 9;
						continue;
					}
					goto case 12;
				case 14:
					break;
				case 3:
					if (VZ5Tj8GrVSW9ZUCNCU3W(text) == VZ5Tj8GrVSW9ZUCNCU3W(propName) + 4)
					{
						num2 = 8;
						continue;
					}
					goto case 4;
				case 15:
					num3 = 0;
					num2 = 17;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
					{
						num2 = 17;
					}
					continue;
				case 16:
					array = ((TypeInfo)XHYPfQGrQDHsoGIrhDrJ(propHolderType)).DeclaredMethods.AsArray();
					num2 = 15;
					continue;
				case 10:
					return methodInfo;
				case 4:
					num3++;
					num2 = 18;
					continue;
				case 2:
					if (!i1ew18GrItxWr4HQPSsP(methodInfo))
					{
						num2 = 4;
						continue;
					}
					goto case 19;
				case 12:
					methodInfo = array[num3];
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0)
					{
						num2 = 2;
					}
					continue;
				default:
					return null;
				}
				break;
			}
			num4--;
			num = 7;
		}
	}

	internal static MethodInfo FindPropertySetMethod(this Type propHolderType, string propName)
	{
		//Discarded unreachable code: IL_00e6, IL_00f5, IL_015e, IL_0213
		int num = 19;
		MethodInfo[] array = default(MethodInfo[]);
		int num3 = default(int);
		string text = default(string);
		MethodInfo methodInfo = default(MethodInfo);
		int num4 = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 19:
					array = ((TypeInfo)XHYPfQGrQDHsoGIrhDrJ(propHolderType)).DeclaredMethods.AsArray();
					num2 = 18;
					break;
				case 17:
					if (num3 == -1)
					{
						num2 = 8;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto IL_0149;
				default:
					num3 = VZ5Tj8GrVSW9ZUCNCU3W(propName) - 1;
					num2 = 2;
					break;
				case 4:
					text = (string)IE62N6GrZlJqyRybPcFT(methodInfo);
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
					{
						num2 = 12;
					}
					break;
				case 18:
					num4 = 0;
					num2 = 9;
					break;
				case 5:
					if (JwP2VVGrSAsMjqWxyAgL(text, 0) == 's')
					{
						num2 = 6;
						break;
					}
					goto IL_0149;
				case 3:
					num3--;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
					{
						num2 = 1;
					}
					break;
				case 8:
					return methodInfo;
				case 14:
				{
					Type baseType = ((Type)XHYPfQGrQDHsoGIrhDrJ(propHolderType)).BaseType;
					if ((object)baseType == null)
					{
						num2 = 7;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
						{
							num2 = 11;
						}
						break;
					}
					return (MethodInfo)nWEOlxGriVDGQqFF4Qyl(baseType, propName);
				}
				case 7:
				case 10:
					methodInfo = array[num4];
					num2 = 16;
					break;
				case 12:
					if (VZ5Tj8GrVSW9ZUCNCU3W(text) == VZ5Tj8GrVSW9ZUCNCU3W(propName) + 4)
					{
						num2 = 5;
						break;
					}
					goto IL_0149;
				case 9:
				case 15:
					if (num4 < array.Length)
					{
						num2 = 10;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
						{
							num2 = 10;
						}
						break;
					}
					goto case 14;
				case 13:
					if (propName[num3] != JwP2VVGrSAsMjqWxyAgL(text, num3 + 4))
					{
						goto end_IL_0012;
					}
					goto case 3;
				case 6:
					if (JwP2VVGrSAsMjqWxyAgL(text, 3) == '_')
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
						{
							num2 = 0;
						}
						break;
					}
					goto IL_0149;
				case 16:
					if (i1ew18GrItxWr4HQPSsP(methodInfo))
					{
						num2 = 4;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
						{
							num2 = 3;
						}
						break;
					}
					goto IL_0149;
				case 1:
				case 2:
					if (num3 != -1)
					{
						num2 = 13;
						break;
					}
					goto case 17;
				case 11:
					{
						return null;
					}
					IL_0149:
					num4++;
					num2 = 15;
					break;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 17;
		}
	}

	internal static MethodInfo FindConvertOperator(this Type type, Type sourceType, Type targetType)
	{
		//Discarded unreachable code: IL_00c0, IL_00cf, IL_00df, IL_00ee, IL_0262, IL_02ac
		int num = 16;
		int num2 = num;
		string text = default(string);
		int num3 = default(int);
		MethodInfo methodInfo = default(MethodInfo);
		MethodInfo[] array = default(MethodInfo[]);
		while (true)
		{
			switch (num2)
			{
			case 19:
				return null;
			case 12:
				if (text[6] == 'l')
				{
					num2 = 17;
					break;
				}
				goto case 13;
			case 22:
				if (VZ5Tj8GrVSW9ZUCNCU3W(text) == 11)
				{
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
					{
						num2 = 3;
					}
					break;
				}
				goto case 13;
			case 15:
				num3 = 0;
				num2 = 6;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
				{
					num2 = 4;
				}
				break;
			case 14:
				if (JwP2VVGrSAsMjqWxyAgL(text, 5) == 'p')
				{
					num2 = 12;
					break;
				}
				goto case 13;
			case 18:
				if (!cCsqYHGrf12VIfbSV7t8(HAHDouGrqBR75jySb0gy(((object[])Mnw0OvGr8qogxQXi6xUR(methodInfo))[0]), sourceType))
				{
					num2 = 20;
					break;
				}
				goto case 2;
			case 1:
				if (i1ew18GrItxWr4HQPSsP(methodInfo))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 13;
			default:
				if (cCsqYHGrf12VIfbSV7t8(P5TqOBGrR0tGEqqvCZTd(methodInfo), targetType))
				{
					num2 = 11;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0)
					{
						num2 = 2;
					}
					break;
				}
				goto case 13;
			case 17:
				if (JwP2VVGrSAsMjqWxyAgL(text, 7) == 'i')
				{
					num2 = 3;
					break;
				}
				goto case 13;
			case 5:
			case 6:
				if (num3 < array.Length)
				{
					num2 = 8;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
					{
						num2 = 2;
					}
					break;
				}
				goto case 19;
			case 11:
				text = (string)IE62N6GrZlJqyRybPcFT(methodInfo);
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
				{
					num2 = 22;
				}
				break;
			case 9:
				if (!methodInfo.IsStatic)
				{
					num2 = 10;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
					{
						num2 = 13;
					}
					break;
				}
				goto case 1;
			case 7:
				if (text[2] == '_')
				{
					num2 = 14;
					break;
				}
				goto case 13;
			case 3:
				if (text[8] == 'c')
				{
					num2 = 4;
					break;
				}
				goto case 13;
			case 8:
			case 21:
				methodInfo = array[num3];
				num2 = 9;
				break;
			case 4:
				if (JwP2VVGrSAsMjqWxyAgL(text, 9) == 'i')
				{
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0)
					{
						num2 = 10;
					}
					break;
				}
				goto case 13;
			case 16:
				array = ((TypeInfo)XHYPfQGrQDHsoGIrhDrJ(type)).DeclaredMethods.AsArray();
				num2 = 15;
				break;
			case 2:
				return methodInfo;
			case 13:
			case 20:
				num3++;
				num2 = 5;
				break;
			case 10:
				if (JwP2VVGrSAsMjqWxyAgL(text, 10) == 't')
				{
					num2 = 18;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
					{
						num2 = 2;
					}
					break;
				}
				goto case 13;
			}
		}
	}

	internal static ConstructorInfo FindSingleParamConstructor(this Type type, Type paramType)
	{
		//Discarded unreachable code: IL_009e, IL_0116, IL_0125, IL_0180
		int num = 7;
		ConstructorInfo constructorInfo = default(ConstructorInfo);
		int num3 = default(int);
		ConstructorInfo[] array = default(ConstructorInfo[]);
		ParameterInfo[] parameters = default(ParameterInfo[]);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					return constructorInfo;
				case 2:
					num3++;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
					{
						num2 = 4;
					}
					continue;
				case 4:
				case 10:
					if (num3 < array.Length)
					{
						num = 5;
						break;
					}
					goto case 11;
				case 3:
				case 5:
					constructorInfo = array[num3];
					num2 = 8;
					continue;
				case 7:
					array = type.GetTypeInfo().DeclaredConstructors.AsArray();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b != 0)
					{
						num2 = 6;
					}
					continue;
				case 11:
					return null;
				case 8:
					parameters = constructorInfo.GetParameters();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
					{
						num2 = 0;
					}
					continue;
				default:
					if (parameters.Length == 1)
					{
						num = 9;
						break;
					}
					goto case 2;
				case 6:
					num3 = 0;
					num2 = 9;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
					{
						num2 = 10;
					}
					continue;
				case 9:
					if (!cCsqYHGrf12VIfbSV7t8(HAHDouGrqBR75jySb0gy(parameters[0]), paramType))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
						{
							num2 = 2;
						}
						continue;
					}
					goto case 1;
				}
				break;
			}
		}
	}

	public static T[] AsArray<T>(this IEnumerable<T> xs)
	{
		if (xs is T[] result)
		{
			return result;
		}
		return xs?.ToArray();
	}

	public static T[] Empty<T>()
	{
		return EmptyArray<T>.Value;
	}

	public static T[] WithLast<T>(this T[] source, T value)
	{
		if (source == null || source.Length == 0)
		{
			return new T[1] { value };
		}
		if (source.Length == 1)
		{
			return new T[2]
			{
				source[0],
				value
			};
		}
		if (source.Length == 2)
		{
			return new T[3]
			{
				source[0],
				source[1],
				value
			};
		}
		int num = source.Length;
		T[] array = new T[num + 1];
		Array.Copy(source, 0, array, 0, num);
		array[num] = value;
		return array;
	}

	public static Type[] GetParamTypes(IReadOnlyList<ParameterExpression> paramExprs)
	{
		if (paramExprs == null || paramExprs.Count == 0)
		{
			return Empty<Type>();
		}
		if (paramExprs.Count == 1)
		{
			return new Type[1] { paramExprs[0].IsByRef ? paramExprs[0].Type.MakeByRefType() : paramExprs[0].Type };
		}
		Type[] array = new Type[paramExprs.Count];
		for (int i = 0; i < array.Length; i++)
		{
			ParameterExpression parameterExpression = paramExprs[i];
			array[i] = (parameterExpression.IsByRef ? parameterExpression.Type.MakeByRefType() : parameterExpression.Type);
		}
		return array;
	}

	public static Type GetFuncOrActionType(Type[] paramTypes, Type returnType)
	{
		//Discarded unreachable code: IL_02db, IL_02ea, IL_035d, IL_036c
		int num = 4;
		int num3 = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 5:
					switch (num3)
					{
					default:
						num = 2;
						goto end_IL_0012;
					case 0:
						break;
					case 1:
						return aItOFvGrEWH6f3abWgvu(typeof(Action<>).TypeHandle).MakeGenericType(paramTypes);
					case 2:
						return aItOFvGrEWH6f3abWgvu(typeof(Action<, >).TypeHandle).MakeGenericType(paramTypes);
					case 3:
						return aItOFvGrEWH6f3abWgvu(typeof(Action<, , >).TypeHandle).MakeGenericType(paramTypes);
					case 4:
						return aItOFvGrEWH6f3abWgvu(typeof(Action<, , , >).TypeHandle).MakeGenericType(paramTypes);
					case 5:
						return aItOFvGrEWH6f3abWgvu(typeof(Action<, , , , >).TypeHandle).MakeGenericType(paramTypes);
					case 6:
						return typeof(Action<, , , , , >).MakeGenericType(paramTypes);
					case 7:
						return aItOFvGrEWH6f3abWgvu(typeof(Action<, , , , , , >).TypeHandle).MakeGenericType(paramTypes);
					}
					goto default;
				case 6:
					return aItOFvGrEWH6f3abWgvu(typeof(Func<>).TypeHandle).MakeGenericType(returnType);
				case 7:
					throw new NotSupportedException((string)b6utReGrKVQ4nVLu1QjY(SdpooBGrvReQNfVRg4LM(0x63ABA4E8 ^ 0x63AFB55C), paramTypes.Length));
				default:
					return typeof(Action);
				case 2:
					throw new NotSupportedException((string)b6utReGrKVQ4nVLu1QjY(SdpooBGrvReQNfVRg4LM(0x5A4C7B29 ^ 0x5A486A6D), paramTypes.Length));
				case 1:
					switch (num3)
					{
					case 0:
						break;
					case 1:
						return typeof(Func<, >).MakeGenericType(paramTypes[0], returnType);
					case 2:
						return typeof(Func<, , >).MakeGenericType(paramTypes[0], paramTypes[1], returnType);
					case 3:
						return aItOFvGrEWH6f3abWgvu(typeof(Func<, , , >).TypeHandle).MakeGenericType(paramTypes[0], paramTypes[1], paramTypes[2], returnType);
					case 4:
						return aItOFvGrEWH6f3abWgvu(typeof(Func<, , , , >).TypeHandle).MakeGenericType(paramTypes[0], paramTypes[1], paramTypes[2], paramTypes[3], returnType);
					case 5:
						return aItOFvGrEWH6f3abWgvu(typeof(Func<, , , , , >).TypeHandle).MakeGenericType(paramTypes[0], paramTypes[1], paramTypes[2], paramTypes[3], paramTypes[4], returnType);
					case 6:
						return typeof(Func<, , , , , , >).MakeGenericType(paramTypes[0], paramTypes[1], paramTypes[2], paramTypes[3], paramTypes[4], paramTypes[5], returnType);
					case 7:
						return aItOFvGrEWH6f3abWgvu(typeof(Func<, , , , , , , >).TypeHandle).MakeGenericType(paramTypes[0], paramTypes[1], paramTypes[2], paramTypes[3], paramTypes[4], paramTypes[5], paramTypes[6], returnType);
					default:
						num2 = 7;
						continue;
					}
					goto case 6;
				case 4:
					if (!cCsqYHGrf12VIfbSV7t8(returnType, aItOFvGrEWH6f3abWgvu(typeof(void).TypeHandle)))
					{
						num3 = paramTypes.Length;
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
						{
							num2 = 0;
						}
					}
					else
					{
						num2 = 3;
					}
					continue;
				case 3:
					{
						num3 = paramTypes.Length;
						num = 5;
						break;
					}
					end_IL_0012:
					break;
				}
				break;
			}
		}
	}

	public static T GetFirst<T>(this IEnumerable<T> source)
	{
		if (source is IList<T> list)
		{
			if (list.Count != 0)
			{
				return list[0];
			}
			return default(T);
		}
		using IEnumerator<T> enumerator = source.GetEnumerator();
		return enumerator.MoveNext() ? enumerator.Current : default(T);
	}

	public static T GetFirst<T>(this IList<T> source)
	{
		if (source.Count != 0)
		{
			return source[0];
		}
		return default(T);
	}

	public static T GetFirst<T>(this T[] source)
	{
		if (source.Length != 0)
		{
			return source[0];
		}
		return default(T);
	}

	static Tools()
	{
		int num = 2;
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
				DelegateTargetGetterMethod = (MethodInfo)baXoZPGruGlrdXDJFHTO(aItOFvGrEWH6f3abWgvu(typeof(Delegate).TypeHandle), SdpooBGrvReQNfVRg4LM(-70007027 ^ -69741267));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				lA97rVGrXDgEgYD6NJE7();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	internal static bool TuhTVIGrheo40gF4FA1k()
	{
		return brv0bJGrbENj8dJdyka2 == null;
	}

	internal static Tools lICJq6GrGX42KPFwmXh8()
	{
		return brv0bJGrbENj8dJdyka2;
	}

	internal static Type aItOFvGrEWH6f3abWgvu(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static bool cCsqYHGrf12VIfbSV7t8(Type P_0, Type P_1)
	{
		return P_0 == P_1;
	}

	internal static object XHYPfQGrQDHsoGIrhDrJ(Type P_0)
	{
		return P_0.GetTypeInfo();
	}

	internal static object mvJNeOGrCbIOM4kvQdVY(Type type, object P_1)
	{
		return type.FindMethod((string)P_1);
	}

	internal static object SdpooBGrvReQNfVRg4LM(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object Mnw0OvGr8qogxQXi6xUR(object P_0)
	{
		return ((MethodBase)P_0).GetParameters();
	}

	internal static object IE62N6GrZlJqyRybPcFT(object P_0)
	{
		return ((MemberInfo)P_0).Name;
	}

	internal static object baXoZPGruGlrdXDJFHTO(Type propHolderType, object P_1)
	{
		return propHolderType.FindPropertyGetMethod((string)P_1);
	}

	internal static bool i1ew18GrItxWr4HQPSsP(object P_0)
	{
		return ((MethodBase)P_0).IsSpecialName;
	}

	internal static int VZ5Tj8GrVSW9ZUCNCU3W(object P_0)
	{
		return ((string)P_0).Length;
	}

	internal static char JwP2VVGrSAsMjqWxyAgL(object P_0, int P_1)
	{
		return ((string)P_0)[P_1];
	}

	internal static object nWEOlxGriVDGQqFF4Qyl(Type propHolderType, object P_1)
	{
		return propHolderType.FindPropertySetMethod((string)P_1);
	}

	internal static Type P5TqOBGrR0tGEqqvCZTd(object P_0)
	{
		return ((MethodInfo)P_0).ReturnType;
	}

	internal static Type HAHDouGrqBR75jySb0gy(object P_0)
	{
		return ((ParameterInfo)P_0).ParameterType;
	}

	internal static object b6utReGrKVQ4nVLu1QjY(object P_0, object P_1)
	{
		return string.Format((string)P_0, P_1);
	}

	internal static void lA97rVGrXDgEgYD6NJE7()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
