using System;
using System.Linq.Expressions;
using System.Reflection;
using j3AmrhgkCleVTGdEwA;
using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode.Impl.CustomizersImpl;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Scripts;

internal sealed class DataClassTypeReferenceNHMap : ClassMapping<DataClassTypeReference>
{
	internal static DataClassTypeReferenceNHMap ErHVU2bITD9KfGGNZ9ey;

	public DataClassTypeReferenceNHMap()
	{
		//Discarded unreachable code: IL_001e
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 3:
				((ClassCustomizer<DataClassTypeReference>)(object)this).Table((string)BMTmtPbIOnFVGuSy0dxd(0xD3DEF7E ^ 0xD3FA758));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 != 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				return;
			default:
			{
				ParameterExpression parameterExpression = (ParameterExpression)cEly3rbIegIBtMK1xInb(gycfZbbI2csEox12nEkg(typeof(DataClassTypeReference).TypeHandle), BMTmtPbIOnFVGuSy0dxd(-1870892489 ^ -1870874385));
				((PropertyContainerCustomizer<DataClassTypeReference>)(object)this).Property<Guid>(Expression.Lambda<Func<DataClassTypeReference, Guid>>((Expression)AsdVF3bI1Msm4IAt6fec(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }));
				num2 = 4;
				break;
			}
			case 2:
			{
				ParameterExpression parameterExpression = (ParameterExpression)cEly3rbIegIBtMK1xInb(gycfZbbI2csEox12nEkg(typeof(DataClassTypeReference).TypeHandle), BMTmtPbIOnFVGuSy0dxd(0x4A1640F ^ 0x4A1AED7));
				((PropertyContainerCustomizer<DataClassTypeReference>)(object)this).Property<Guid>(Expression.Lambda<Func<DataClassTypeReference, Guid>>((Expression)AsdVF3bI1Msm4IAt6fec(parameterExpression, (MethodInfo)EVPFKVbIPfGey6Hh3h3r((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
				{
					num2 = 0;
				}
				break;
			}
			case 1:
			{
				ParameterExpression parameterExpression = (ParameterExpression)cEly3rbIegIBtMK1xInb(gycfZbbI2csEox12nEkg(typeof(DataClassTypeReference).TypeHandle), BMTmtPbIOnFVGuSy0dxd(-951514650 ^ -951467202));
				((ClassCustomizer<DataClassTypeReference>)(object)this).Id<long>(Expression.Lambda<Func<DataClassTypeReference, long>>(Expression.Property(parameterExpression, (MethodInfo)EVPFKVbIPfGey6Hh3h3r((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }), (Action<IIdMapper>)delegate(IIdMapper p)
				{
					int num3 = 1;
					int num4 = num3;
					while (true)
					{
						switch (num4)
						{
						default:
							return;
						case 0:
							return;
						case 1:
							_003C_003Ec.MF0aDaCPRhsiDNLDgGoW(p, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4D1C1EE4 ^ 0x4D1E56C2), _003C_003Ec.CgSL2JCPiT5tau41IW5n(0x3A5D5EF ^ 0x3A554B1));
							num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
							{
								num4 = 0;
							}
							break;
						}
					}
				});
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
				{
					num2 = 2;
				}
				break;
			}
			}
		}
	}

	internal static object BMTmtPbIOnFVGuSy0dxd(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static Type gycfZbbI2csEox12nEkg(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object cEly3rbIegIBtMK1xInb(Type P_0, object P_1)
	{
		return Expression.Parameter(P_0, (string)P_1);
	}

	internal static object EVPFKVbIPfGey6Hh3h3r(RuntimeMethodHandle P_0)
	{
		return MethodBase.GetMethodFromHandle(P_0);
	}

	internal static object AsdVF3bI1Msm4IAt6fec(object P_0, object P_1)
	{
		return Expression.Property((Expression)P_0, (MethodInfo)P_1);
	}

	internal static bool dkiRrUbIkO7N08yAt8gB()
	{
		return ErHVU2bITD9KfGGNZ9ey == null;
	}

	internal static DataClassTypeReferenceNHMap aaNpXibInBN61xT3qvCV()
	{
		return ErHVU2bITD9KfGGNZ9ey;
	}
}
