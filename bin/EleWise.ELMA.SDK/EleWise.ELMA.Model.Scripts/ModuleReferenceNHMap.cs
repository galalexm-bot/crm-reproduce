using System;
using System.Linq.Expressions;
using System.Reflection;
using j3AmrhgkCleVTGdEwA;
using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode.Impl.CustomizersImpl;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Scripts;

internal sealed class ModuleReferenceNHMap : ClassMapping<ModuleReference>
{
	internal static ModuleReferenceNHMap TFkCh8bVmUPkMoASMn4P;

	public ModuleReferenceNHMap()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e != 0)
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
				WUuvPUbVJUuGu0JIRZrb(this, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x42643203 ^ 0x426675E9));
				num = 2;
				break;
			case 4:
			{
				ParameterExpression parameterExpression = (ParameterExpression)r1oVi9bVlcvi8woawKZN(yU2O37bV96h9qnFFmfSb(typeof(ModuleReference).TypeHandle), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4EA5403C ^ 0x4EA58AE4));
				((PropertyContainerCustomizer<ModuleReference>)(object)this).Property<Guid>(Expression.Lambda<Func<ModuleReference, Guid>>((Expression)G320eXbVrv7GuimdqPFx(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }));
				num = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
				{
					num = 3;
				}
				break;
			}
			case 2:
			{
				ParameterExpression parameterExpression = (ParameterExpression)r1oVi9bVlcvi8woawKZN(yU2O37bV96h9qnFFmfSb(typeof(ModuleReference).TypeHandle), nxA6d3bVdi3Z1xU0LE2Y(-2107978722 ^ -2108029242));
				((ClassCustomizer<ModuleReference>)(object)this).Id<Guid>(Expression.Lambda<Func<ModuleReference, Guid>>((Expression)G320eXbVrv7GuimdqPFx(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }), (Action<IIdMapper>)delegate(IIdMapper p)
				{
					int num2 = 1;
					int num3 = num2;
					while (true)
					{
						switch (num3)
						{
						default:
							return;
						case 0:
							return;
						case 1:
							p.Generator((IGeneratorDef)_003C_003Ec.aOmTERCPHgdmpQGNRpaZ());
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad != 0)
							{
								num3 = 0;
							}
							break;
						}
					}
				});
				num = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0)
				{
					num = 4;
				}
				break;
			}
			case 3:
				((ClassCustomizer<ModuleReference>)(object)this).Cache((Action<ICacheMapper>)delegate(ICacheMapper c)
				{
					int num4 = 1;
					int num5 = num4;
					while (true)
					{
						switch (num5)
						{
						default:
							return;
						case 0:
							return;
						case 1:
							_003C_003Ec.yhvEoPCPAHvrnBj8Z2gk(c, CacheUsage.ReadWrite);
							num5 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
							{
								num5 = 0;
							}
							break;
						}
					}
				});
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	internal static void WUuvPUbVJUuGu0JIRZrb(object P_0, object P_1)
	{
		((ClassCustomizer<ModuleReference>)P_0).Table((string)P_1);
	}

	internal static Type yU2O37bV96h9qnFFmfSb(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object nxA6d3bVdi3Z1xU0LE2Y(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object r1oVi9bVlcvi8woawKZN(Type P_0, object P_1)
	{
		return Expression.Parameter(P_0, (string)P_1);
	}

	internal static object G320eXbVrv7GuimdqPFx(object P_0, object P_1)
	{
		return Expression.Property((Expression)P_0, (MethodInfo)P_1);
	}

	internal static bool l3dqd6bVy6QXDDF2ehcO()
	{
		return TFkCh8bVmUPkMoASMn4P == null;
	}

	internal static ModuleReferenceNHMap rkB4PJbVM4eei59y5iGm()
	{
		return TFkCh8bVmUPkMoASMn4P;
	}
}
