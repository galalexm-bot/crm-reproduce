using System;
using System.Linq.Expressions;
using System.Reflection;
using EleWise.ELMA.Runtime.NH.CustomTypes;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;
using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode.Impl.CustomizersImpl;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Mappings;

internal class CustomActivityParametersMap : JoinedSubclassMapping<CustomActivityParameters>
{
	private static CustomActivityParametersMap Igo5VthSFv50IkA853o;

	public CustomActivityParametersMap()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.reZueBLff7();
		base._002Ector();
		int num = 4;
		if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_25eedcea124a48258fd18106b7da9d93 != 0)
		{
			num = 0;
		}
		while (true)
		{
			ParameterExpression parameterExpression;
			switch (num)
			{
			case 4:
				pa0tyshmOADlkdOUcNt(this, Nb8pb7hU9PE9rofnqLd(0x927D360 ^ 0x927FC86));
				num = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_e496a9998cf542ff98d1a5e001d6c664 == 0)
				{
					num = 1;
				}
				continue;
			case 3:
				return;
			case 5:
				((JoinedSubclassCustomizer<CustomActivityParameters>)(object)this).Lazy(false);
				num = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_f44d857a149741d8874c141a12a734dc != 0)
				{
					num = 0;
				}
				continue;
			case 1:
				((JoinedSubclassCustomizer<CustomActivityParameters>)(object)this).Key((Action<IKeyMapper<CustomActivityParameters>>)delegate(IKeyMapper<CustomActivityParameters> k)
				{
					((IColumnsMapper)k).Column(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x47356CA4 ^ 0x47355B5E));
				});
				num = 5;
				continue;
			case 2:
				parameterExpression = (ParameterExpression)rKm4y2hpje4dCb4TbBA(typeof(CustomActivityParameters), Nb8pb7hU9PE9rofnqLd(-869419654 ^ -869431968));
				((PropertyContainerCustomizer<CustomActivityParameters>)(object)this).Property<byte[]>(Expression.Lambda<Func<CustomActivityParameters, byte[]>>((Expression)bDLPAehnXcZLHllEBi3(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }), (Action<IPropertyMapper>)delegate(IPropertyMapper p)
				{
					int num4 = 1;
					int num5 = num4;
					while (true)
					{
						switch (num5)
						{
						case 2:
							return;
						case 1:
							p.Length(int.MaxValue);
							num5 = 0;
							if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_36c7cf283a024daf893e3b9d58dc5698 == 0)
							{
								num5 = 0;
							}
							break;
						default:
							p.Type<FixedBinaryUserType>();
							num5 = 2;
							if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_77bc2455d9c3443ca1c76a1788888437 != 0)
							{
								num5 = 1;
							}
							break;
						}
					}
				});
				num = 3;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_19817a6c27b8478eb2c8f07b7fca8477 == 0)
				{
					num = 3;
				}
				continue;
			}
			parameterExpression = (ParameterExpression)rKm4y2hpje4dCb4TbBA(jq8ZvEhAYCbNnRmt2MR(typeof(CustomActivityParameters).TypeHandle), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x48FD6D2E ^ 0x48FD5D34));
			((PropertyContainerCustomizer<CustomActivityParameters>)(object)this).Property<string>(Expression.Lambda<Func<CustomActivityParameters, string>>((Expression)bDLPAehnXcZLHllEBi3(parameterExpression, (MethodInfo)nU2CYGhGTo68IOVSIOK((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }), (Action<IPropertyMapper>)delegate(IPropertyMapper p)
			{
				int num2 = 1;
				int num3 = num2;
				while (true)
				{
					switch (num3)
					{
					default:
						return;
					case 1:
						_003C_003Ec.Ckk5YQphbPTSBuo1lAL(p, int.MaxValue);
						num3 = 0;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_3600d9e606e544d2b67d1fc1ad9becc3 == 0)
						{
							num3 = 0;
						}
						break;
					case 0:
						return;
					}
				}
			});
			num = 2;
			if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_766d50e1f7cc46f1bc746fe53086708c == 0)
			{
				num = 2;
			}
		}
	}

	internal static object Nb8pb7hU9PE9rofnqLd(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void pa0tyshmOADlkdOUcNt(object P_0, object P_1)
	{
		((JoinedSubclassCustomizer<CustomActivityParameters>)P_0).Table((string)P_1);
	}

	internal static Type jq8ZvEhAYCbNnRmt2MR(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object rKm4y2hpje4dCb4TbBA(Type P_0, object P_1)
	{
		return Expression.Parameter(P_0, (string)P_1);
	}

	internal static object nU2CYGhGTo68IOVSIOK(RuntimeMethodHandle P_0)
	{
		return MethodBase.GetMethodFromHandle(P_0);
	}

	internal static object bDLPAehnXcZLHllEBi3(object P_0, object P_1)
	{
		return Expression.Property((Expression)P_0, (MethodInfo)P_1);
	}

	internal static bool rd0YfUhkv737Hk7Q062()
	{
		return Igo5VthSFv50IkA853o == null;
	}

	internal static CustomActivityParametersMap yYjOpJhbxjBa7laKUoe()
	{
		return Igo5VthSFv50IkA853o;
	}
}
