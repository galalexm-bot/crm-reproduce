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

internal class ProcessMetricsContainerMap : JoinedSubclassMapping<ProcessMetricsContainer>
{
	internal static ProcessMetricsContainerMap S5R32Lve6wEOXZ4MhIW;

	public ProcessMetricsContainerMap()
	{
		//Discarded unreachable code: IL_001a
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		base._002Ector();
		int num = 5;
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 3:
			{
				((JoinedSubclassCustomizer<ProcessMetricsContainer>)(object)this).Lazy(true);
				int num2 = 2;
				num = num2;
				break;
			}
			case 0:
				return;
			case 5:
				((JoinedSubclassCustomizer<ProcessMetricsContainer>)(object)this).Table((string)Oiy7K4vSmkttm52P1Sq(-2077784392 ^ -2077783706));
				num = 4;
				break;
			case 4:
				((JoinedSubclassCustomizer<ProcessMetricsContainer>)(object)this).Key((Action<IKeyMapper<ProcessMetricsContainer>>)delegate(IKeyMapper<ProcessMetricsContainer> k)
				{
					((IColumnsMapper)k).Column(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x46EA3D1 ^ 0x46EE557));
				});
				num = 3;
				break;
			case 2:
			{
				ParameterExpression parameterExpression = (ParameterExpression)zkrWW9v1YgixNwimaXm(typeof(ProcessMetricsContainer), Oiy7K4vSmkttm52P1Sq(-452127399 ^ -452125981));
				((PropertyContainerCustomizer<ProcessMetricsContainer>)(object)this).Property<string>(Expression.Lambda<Func<ProcessMetricsContainer, string>>((Expression)u6QTNDvEOv48GxiBneU(parameterExpression, (MethodInfo)MZsTlPvh61wRFewHbjB((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }), (Action<IPropertyMapper>)delegate(IPropertyMapper p)
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
							_003C_003Ec.Xlo0uNZL31LwrKo20fqv(p, int.MaxValue);
							num4 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8a6cf36da0b84f319a7cf27018f28f5b == 0)
							{
								num4 = 0;
							}
							break;
						}
					}
				});
				num = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f2d402219199402696ade21eab23d086 != 0)
				{
					num = 1;
				}
				break;
			}
			case 1:
			{
				ParameterExpression parameterExpression = (ParameterExpression)zkrWW9v1YgixNwimaXm(DZNNwsvwtOoDVda9YlP(typeof(ProcessMetricsContainer).TypeHandle), Oiy7K4vSmkttm52P1Sq(-885093259 ^ -885095473));
				((PropertyContainerCustomizer<ProcessMetricsContainer>)(object)this).Property<byte[]>(Expression.Lambda<Func<ProcessMetricsContainer, byte[]>>((Expression)u6QTNDvEOv48GxiBneU(parameterExpression, (MethodInfo)MZsTlPvh61wRFewHbjB((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }), (Action<IPropertyMapper>)delegate(IPropertyMapper p)
				{
					int num5 = 2;
					int num6 = num5;
					while (true)
					{
						switch (num6)
						{
						default:
							return;
						case 2:
							_003C_003Ec.Xlo0uNZL31LwrKo20fqv(p, int.MaxValue);
							num6 = 1;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5c45a6e5a4614bfba7591d8a1c7ced1d == 0)
							{
								num6 = 1;
							}
							break;
						case 1:
							p.Type<FixedBinaryUserType>();
							num6 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f453500aaab143479696408f48a03c17 != 0)
							{
								num6 = 0;
							}
							break;
						case 0:
							return;
						}
					}
				});
				num = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6d48f3b4557a49578bf7f5ef0517e0be != 0)
				{
					num = 0;
				}
				break;
			}
			}
		}
	}

	internal static object Oiy7K4vSmkttm52P1Sq(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object zkrWW9v1YgixNwimaXm(Type P_0, object P_1)
	{
		return Expression.Parameter(P_0, (string)P_1);
	}

	internal static object MZsTlPvh61wRFewHbjB(RuntimeMethodHandle P_0)
	{
		return MethodBase.GetMethodFromHandle(P_0);
	}

	internal static object u6QTNDvEOv48GxiBneU(object P_0, object P_1)
	{
		return Expression.Property((Expression)P_0, (MethodInfo)P_1);
	}

	internal static Type DZNNwsvwtOoDVda9YlP(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static bool NtSvaOvNwcuCYVhOunu()
	{
		return S5R32Lve6wEOXZ4MhIW == null;
	}

	internal static ProcessMetricsContainerMap Ig1Cnmvx5iRFlQ6r9ew()
	{
		return S5R32Lve6wEOXZ4MhIW;
	}
}
