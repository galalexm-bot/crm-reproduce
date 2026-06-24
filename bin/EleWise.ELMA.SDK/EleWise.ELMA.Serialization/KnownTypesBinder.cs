using System;
using System.Linq;
using System.Reflection;
using j3AmrhgkCleVTGdEwA;
using Newtonsoft.Json.Serialization;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Serialization;

internal sealed class KnownTypesBinder : ISerializationBinder
{
	private static KnownTypesBinder instance;

	internal static KnownTypesBinder uqlECqB91KOwfiY6oyq8;

	internal static KnownTypesBinder Instance
	{
		get
		{
			int num = 1;
			int num2 = num;
			KnownTypesBinder knownTypesBinder;
			while (true)
			{
				switch (num2)
				{
				case 1:
					knownTypesBinder = instance;
					if (knownTypesBinder == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				default:
					knownTypesBinder = (instance = new KnownTypesBinder());
					break;
				}
				break;
			}
			return knownTypesBinder;
		}
	}

	public Type BindToType(string assemblyName, string typeName)
	{
		//Discarded unreachable code: IL_0139, IL_0148, IL_01fc, IL_022e, IL_0266
		int num = 1;
		int num2 = num;
		Type type;
		_003C_003Ec__DisplayClass3_0 _003C_003Ec__DisplayClass3_ = default(_003C_003Ec__DisplayClass3_0);
		Type type2 = default(Type);
		while (true)
		{
			switch (num2)
			{
			case 13:
				type = Type.GetType((string)FiYb91B9wGN8UEjqPt9Q(_003C_003Ec__DisplayClass3_.typeName, DIZJQJB9athypMfjtw2F(0x5F3078B6 ^ 0x5F31171C)), throwOnError: false);
				if ((object)type == null)
				{
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
					{
						num2 = 4;
					}
					continue;
				}
				break;
			case 16:
				if (!(type2 != null))
				{
					num2 = 3;
					continue;
				}
				goto case 12;
			case 1:
				_003C_003Ec__DisplayClass3_ = new _003C_003Ec__DisplayClass3_0();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				type = hBx8HlB94msLG37i5Tyl(FiYb91B9wGN8UEjqPt9Q(_003C_003Ec__DisplayClass3_.typeName, DIZJQJB9athypMfjtw2F(-951514650 ^ -951556348)), false);
				if ((object)type == null)
				{
					num2 = 4;
					continue;
				}
				break;
			default:
				_003C_003Ec__DisplayClass3_.typeName = typeName;
				num2 = 9;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
				{
					num2 = 6;
				}
				continue;
			case 9:
				type2 = ReflectionType.GetType(_003C_003Ec__DisplayClass3_.typeName, throwOnError: false);
				num2 = 15;
				continue;
			case 11:
				type = hBx8HlB94msLG37i5Tyl(FiYb91B9wGN8UEjqPt9Q(_003C_003Ec__DisplayClass3_.typeName, DIZJQJB9athypMfjtw2F(0x34185E55 ^ 0x34192E77)), false);
				if ((object)type == null)
				{
					num2 = 5;
					continue;
				}
				break;
			case 15:
				if (sApKfZB9pGpnr6WOCoCe(type2, null))
				{
					num2 = 7;
					continue;
				}
				goto case 16;
			case 7:
				try
				{
					type2 = VASfMwB9tBlSkKZgBjJf(TA630aB9DNNUBDGvdQcA(_003C_003Ec__DisplayClass3_.typeName, DIZJQJB9athypMfjtw2F(0x53FA00CE ^ 0x53FA0CCC), assemblyName), false);
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
					{
						num3 = 0;
					}
					switch (num3)
					{
					case 0:
						break;
					}
				}
				catch
				{
					int num4 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
					{
						num4 = 1;
					}
					while (true)
					{
						switch (num4)
						{
						case 1:
							type2 = null;
							num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
							{
								num4 = 0;
							}
							continue;
						case 0:
							break;
						}
						break;
					}
				}
				goto case 16;
			case 12:
				return type2;
			case 3:
				type = Type.GetType((string)FiYb91B9wGN8UEjqPt9Q(_003C_003Ec__DisplayClass3_.typeName, DIZJQJB9athypMfjtw2F(-2106517564 ^ -2106558082)), throwOnError: false);
				if ((object)type != null)
				{
					break;
				}
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
				{
					num2 = 0;
				}
				continue;
			case 4:
				type = hBx8HlB94msLG37i5Tyl(FiYb91B9wGN8UEjqPt9Q(_003C_003Ec__DisplayClass3_.typeName, DIZJQJB9athypMfjtw2F(-1426094279 ^ -1426135001)), false);
				if ((object)type != null)
				{
					break;
				}
				num2 = 17;
				continue;
			case 17:
				type = hBx8HlB94msLG37i5Tyl(FiYb91B9wGN8UEjqPt9Q(_003C_003Ec__DisplayClass3_.typeName, DIZJQJB9athypMfjtw2F(-951514650 ^ -951556426)), false);
				if ((object)type != null)
				{
					break;
				}
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0)
				{
					num2 = 14;
				}
				continue;
			case 14:
				type = hBx8HlB94msLG37i5Tyl(FiYb91B9wGN8UEjqPt9Q(_003C_003Ec__DisplayClass3_.typeName, DIZJQJB9athypMfjtw2F(0x4EDCBA32 ^ 0x4EDDD54C)), false);
				if ((object)type != null)
				{
					break;
				}
				num2 = 13;
				continue;
			case 6:
				type = hBx8HlB94msLG37i5Tyl(FiYb91B9wGN8UEjqPt9Q(_003C_003Ec__DisplayClass3_.typeName, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1867198571 ^ -1867145141)), false);
				if ((object)type != null)
				{
					break;
				}
				num2 = 11;
				continue;
			case 5:
				type = hBx8HlB94msLG37i5Tyl(FiYb91B9wGN8UEjqPt9Q(_003C_003Ec__DisplayClass3_.typeName, DIZJQJB9athypMfjtw2F(0x18A6761F ^ 0x18A7064B)), false);
				if ((object)type != null)
				{
					break;
				}
				num2 = 8;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
				{
					num2 = 10;
				}
				continue;
			case 10:
				type = hBx8HlB94msLG37i5Tyl(FiYb91B9wGN8UEjqPt9Q(_003C_003Ec__DisplayClass3_.typeName, DIZJQJB9athypMfjtw2F(-1146510045 ^ -1146563233)), false);
				if ((object)type != null)
				{
					break;
				}
				num2 = 6;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 != 0)
				{
					num2 = 8;
				}
				continue;
			case 8:
				type = ReflectionType.GetType(_003C_003Ec__DisplayClass3_.typeName, (AssemblyName asmName) => (Assembly)_003C_003Ec.LXYfM0QOLJLfY0n8TSYV(_003C_003Ec.RbBH8lQOYkE7jmWmlbmi(asmName), false), _003C_003Ec__DisplayClass3_._003CBindToType_003Eb__1, throwOnError: false, ignoreCase: false);
				break;
			}
			break;
		}
		return type;
	}

	public void BindToName(Type serializedType, out string assemblyName, out string typeName)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				typeName = (string)aSwiJoB96uIjs2vR9eQS(serializedType);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
				{
					num2 = 2;
				}
				break;
			case 1:
				assemblyName = serializedType.Assembly.FullName;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return;
			}
		}
	}

	private static string GetFullName(Type serializedType)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (!serializedType.IsGenericType)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0)
					{
						num2 = 0;
					}
					break;
				}
				return serializedType.GetGenericTypeDefinition().FullName + (string)DIZJQJB9athypMfjtw2F(0x307E9FD1 ^ 0x307E6933) + string.Join((string)DIZJQJB9athypMfjtw2F(-675505729 ^ -675506755), from arg in serializedType.GetGenericArguments()
					select (string)_003C_003Ec.EWicrjQOU7l8vBZ9oRjA(-812025778 ^ -812020052) + (string)_003C_003Ec.MxgPr8QOs36mspaGMd5U(arg) + (string)_003C_003Ec.EWicrjQOU7l8vBZ9oRjA(-2106517564 ^ -2106466004)) + (string)DIZJQJB9athypMfjtw2F(-576149596 ^ -576171700);
			default:
				return serializedType.FullName;
			}
		}
	}

	public KnownTypesBinder()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		mFqqGoB9HGvAhSaaLLl2();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool kEf6a3B9NFYUhncS1gEr()
	{
		return uqlECqB91KOwfiY6oyq8 == null;
	}

	internal static KnownTypesBinder PnB9UjB93gkS0l7Xcwsd()
	{
		return uqlECqB91KOwfiY6oyq8;
	}

	internal static bool sApKfZB9pGpnr6WOCoCe(Type P_0, Type P_1)
	{
		return P_0 == P_1;
	}

	internal static object DIZJQJB9athypMfjtw2F(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object TA630aB9DNNUBDGvdQcA(object P_0, object P_1, object P_2)
	{
		return (string)P_0 + (string)P_1 + (string)P_2;
	}

	internal static Type VASfMwB9tBlSkKZgBjJf(object P_0, bool throwOnError)
	{
		return ReflectionType.GetType((string)P_0, throwOnError);
	}

	internal static object FiYb91B9wGN8UEjqPt9Q(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static Type hBx8HlB94msLG37i5Tyl(object P_0, bool P_1)
	{
		return Type.GetType((string)P_0, P_1);
	}

	internal static object aSwiJoB96uIjs2vR9eQS(Type serializedType)
	{
		return GetFullName(serializedType);
	}

	internal static void mFqqGoB9HGvAhSaaLLl2()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
