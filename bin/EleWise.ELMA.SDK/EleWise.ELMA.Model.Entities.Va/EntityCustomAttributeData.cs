using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using EleWise.ELMA.Extensions;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Entities.ValueContainerObjectTypeDelegator;

internal class EntityCustomAttributeData : CustomAttributeData, IEquatable<EntityCustomAttributeData>
{
	private class CustomAttributeTypedArgumentComparer : IEqualityComparer<CustomAttributeTypedArgument>
	{
		private static object GmDFh5vWhUS5n8MqRhwR;

		public bool Equals(CustomAttributeTypedArgument x, CustomAttributeTypedArgument y)
		{
			//Discarded unreachable code: IL_0076, IL_0085
			int num = 4;
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 5:
						return x.Value.Equals(y.Value);
					case 3:
						return true;
					case 1:
						if (x.Value == y.Value)
						{
							return true;
						}
						goto end_IL_0012;
					case 2:
						if (x.Value == null)
						{
							return false;
						}
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
						{
							num2 = 5;
						}
						break;
					default:
						if (!TjZNtfvWQ02q1ZoH0KxU(x.ArgumentType, y.ArgumentType))
						{
							return false;
						}
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
						{
							num2 = 1;
						}
						break;
					case 4:
						if (OhKB7CvWf7Pn2Td6JmiH(x, y))
						{
							num2 = 3;
							break;
						}
						goto default;
					}
					continue;
					end_IL_0012:
					break;
				}
				num = 2;
			}
		}

		public int GetHashCode(CustomAttributeTypedArgument obj)
		{
			//Discarded unreachable code: IL_00f5
			int num = 7;
			int num6 = default(int);
			int? num5 = default(int?);
			int? num8 = default(int?);
			int? num3 = default(int?);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					int? num7;
					int? num4;
					switch (num2)
					{
					case 7:
						num6 = (811832965 * -1521134295 + obj.ArgumentType.GetHashCode()) * -1521134295;
						num2 = 6;
						continue;
					case 3:
						if (!num5.HasValue)
						{
							num2 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
							{
								num2 = 0;
							}
							continue;
						}
						num7 = num6 + num5.GetValueOrDefault();
						break;
					case 1:
						if (num8.HasValue)
						{
							return num8.GetValueOrDefault();
						}
						goto end_IL_0012;
					case 8:
						num3 = null;
						num2 = 5;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0)
						{
							num2 = 2;
						}
						continue;
					default:
						num3 = null;
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
						{
							num2 = 2;
						}
						continue;
					case 2:
						num7 = num3;
						break;
					case 4:
						return 0;
					case 6:
					{
						object value = obj.Value;
						if (value == null)
						{
							num2 = 8;
							continue;
						}
						num4 = value.GetHashCode();
						goto IL_012d;
					}
					case 5:
						{
							num4 = num3;
							goto IL_012d;
						}
						IL_012d:
						num5 = num4;
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
						{
							num2 = 3;
						}
						continue;
					}
					num8 = num7;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
					{
						num2 = 0;
					}
					continue;
					end_IL_0012:
					break;
				}
				num = 4;
			}
		}

		public CustomAttributeTypedArgumentComparer()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			SingletonReader.JJCZtPuTvSt();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static bool OhKB7CvWf7Pn2Td6JmiH(CustomAttributeTypedArgument P_0, CustomAttributeTypedArgument P_1)
		{
			return P_0 == P_1;
		}

		internal static bool TjZNtfvWQ02q1ZoH0KxU(Type P_0, Type P_1)
		{
			return P_0 == P_1;
		}

		internal static bool PRAlRQvWG4MM1Amb3woF()
		{
			return GmDFh5vWhUS5n8MqRhwR == null;
		}

		internal static CustomAttributeTypedArgumentComparer hwOo04vWEcmUb2t7yFGl()
		{
			return (CustomAttributeTypedArgumentComparer)GmDFh5vWhUS5n8MqRhwR;
		}
	}

	private class CustomAttributeNamedArgumentComparer : IEqualityComparer<CustomAttributeNamedArgument>
	{
		internal static object fQm2CavWCmkBSVFyVfjD;

		public bool Equals(CustomAttributeNamedArgument x, CustomAttributeNamedArgument y)
		{
			int num = 2;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					if (!u8cmPCvWZ4xmdoJnq8Gr(x, y))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
						{
							num2 = 1;
						}
						break;
					}
					return true;
				case 1:
					if (x.MemberName == y.MemberName)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0)
						{
							num2 = 0;
						}
						break;
					}
					return false;
				default:
					return typedArgumentComparer.Equals(x.TypedValue, y.TypedValue);
				}
			}
		}

		public int GetHashCode(CustomAttributeNamedArgument obj)
		{
			return (811832965 * -1521134295 + obj.MemberName.GetHashCode()) * -1521134295 + typedArgumentComparer.GetHashCode(obj.TypedValue);
		}

		public CustomAttributeNamedArgumentComparer()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			suEVBwvWuqTnHSlNyWEk();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static bool u8cmPCvWZ4xmdoJnq8Gr(CustomAttributeNamedArgument P_0, CustomAttributeNamedArgument P_1)
		{
			return P_0 == P_1;
		}

		internal static bool DSte6PvWvhues5XERx93()
		{
			return fQm2CavWCmkBSVFyVfjD == null;
		}

		internal static CustomAttributeNamedArgumentComparer GQn66svW8UKXK6nFcl7H()
		{
			return (CustomAttributeNamedArgumentComparer)fQm2CavWCmkBSVFyVfjD;
		}

		internal static void suEVBwvWuqTnHSlNyWEk()
		{
			SingletonReader.JJCZtPuTvSt();
		}
	}

	private static IEqualityComparer<CustomAttributeTypedArgument> typedArgumentComparer;

	private static IEqualityComparer<CustomAttributeNamedArgument> namedArgumentComparer;

	internal static EntityCustomAttributeData TelA8HhSPfnXGs9Wpvie;

	public override ConstructorInfo Constructor { get; }

	public override IList<CustomAttributeTypedArgument> ConstructorArguments { get; }

	public override IList<CustomAttributeNamedArgument> NamedArguments { get; }

	public EntityCustomAttributeData(ConstructorInfo constructor)
	{
		//Discarded unreachable code: IL_0031, IL_0036
		xj2cn6hS3ZJ35pQ4LOJ2();
		this._002Ector(constructor, new CustomAttributeTypedArgument[0]);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public EntityCustomAttributeData(ConstructorInfo constructor, IList<CustomAttributeTypedArgument> constructorArguments)
	{
		SingletonReader.JJCZtPuTvSt();
		this._002Ector(constructor, constructorArguments, new CustomAttributeNamedArgument[0]);
	}

	public EntityCustomAttributeData(ConstructorInfo constructor, IList<CustomAttributeTypedArgument> constructorArguments, IList<CustomAttributeNamedArgument> namedArguments)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		Constructor = constructor;
		ConstructorArguments = constructorArguments;
		NamedArguments = namedArguments;
	}

	public bool Equals(EntityCustomAttributeData data)
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (ConstructorArguments.EmptyIfNull().SequenceEqual(data.ConstructorArguments.EmptyIfNull(), typedArgumentComparer))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto IL_0088;
			default:
				return NamedArguments.EmptyIfNull().SetEqual(data.NamedArguments.EmptyIfNull(), namedArgumentComparer);
			case 2:
				{
					if ((ConstructorInfo)qQUkpphSpBiIlSiwxD25(this) == data.Constructor)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0)
						{
							num2 = 1;
						}
						break;
					}
					goto IL_0088;
				}
				IL_0088:
				return false;
			}
		}
	}

	public override bool Equals(object obj)
	{
		int num = 1;
		int num2 = num;
		EntityCustomAttributeData data = default(EntityCustomAttributeData);
		while (true)
		{
			switch (num2)
			{
			default:
				return Equals(data);
			case 1:
				if ((data = obj as EntityCustomAttributeData) == null)
				{
					return false;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public override int GetHashCode()
	{
		int num = ((414553146 * -1521134295 + qQUkpphSpBiIlSiwxD25(this).GetHashCode()) * -1521134295 + (ConstructorArguments?.Count ?? 0).GetHashCode()) * -1521134295;
		IList<CustomAttributeNamedArgument> namedArguments = NamedArguments;
		return num + ((namedArguments != null) ? AHxP9AhSaGKywwNyHvRV(namedArguments) : 0).GetHashCode();
	}

	static EntityCustomAttributeData()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				namedArgumentComparer = new CustomAttributeNamedArgumentComparer();
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
				{
					num2 = 3;
				}
				break;
			case 3:
				return;
			default:
				typedArgumentComparer = new CustomAttributeTypedArgumentComparer();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0)
				{
					num2 = 2;
				}
				break;
			case 1:
				SingletonReader.JJCZtPuTvSt();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static void xj2cn6hS3ZJ35pQ4LOJ2()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool poPKb3hS17vv87v0wvoT()
	{
		return TelA8HhSPfnXGs9Wpvie == null;
	}

	internal static EntityCustomAttributeData oY6ReQhSNooZflkKsLq5()
	{
		return TelA8HhSPfnXGs9Wpvie;
	}

	internal static object qQUkpphSpBiIlSiwxD25(object P_0)
	{
		return ((CustomAttributeData)P_0).Constructor;
	}

	internal static int AHxP9AhSaGKywwNyHvRV(object P_0)
	{
		return ((ICollection<CustomAttributeNamedArgument>)P_0).Count;
	}
}
