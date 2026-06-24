using System;
using System.Collections.Generic;
using System.Reflection;
using j3AmrhgkCleVTGdEwA;
using NHibernate.Proxy;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Deploy.ExportHelper;

public class ExportRuleList : List<ExportRule>
{
	private static ExportRuleList YqEt8SEDZq1QMEiW1CIS;

	private bool IsType(object obj, ExportRuleType exportRuleType)
	{
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		int num = 1;
		_003C_003Ec__DisplayClass0_0 _003C_003Ec__DisplayClass0_ = default(_003C_003Ec__DisplayClass0_0);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					_003C_003Ec__DisplayClass0_.obj = jbkC0FEDimCXDXidFlG1(VMKajaEDSbwU4tA2lb7A((object)(INHibernateProxy)_003C_003Ec__DisplayClass0_.obj));
					num2 = 4;
					continue;
				case 1:
					_003C_003Ec__DisplayClass0_ = new _003C_003Ec__DisplayClass0_0();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
					{
						num2 = 0;
					}
					continue;
				case 5:
					if (ksLJBoEDViZjXPnDmmgZ(_003C_003Ec__DisplayClass0_.obj))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0)
						{
							num2 = 2;
						}
						continue;
					}
					break;
				case 3:
					_003C_003Ec__DisplayClass0_.obj = obj;
					num2 = 5;
					continue;
				case 4:
					break;
				default:
					goto end_IL_0012;
				}
				return hOOql3EDRRfK70UhQNFi(FindAll(_003C_003Ec__DisplayClass0_._003CIsType_003Eb__0)) > 0;
				continue;
				end_IL_0012:
				break;
			}
			_003C_003Ec__DisplayClass0_.exportRuleType = exportRuleType;
			num = 3;
		}
	}

	public bool IsTypeIgnore(object obj)
	{
		return IsType(obj, ExportRuleType.Ignore);
	}

	public bool IsTypeExport(object obj)
	{
		return IsType(obj, ExportRuleType.Export);
	}

	public bool IsTypeDeepExport(object obj)
	{
		return IsType(obj, ExportRuleType.ExportDeep);
	}

	private bool IsProperty(PropertyInfo propertyInfo, ExportRuleType exportSettingType)
	{
		int num = 3;
		int num2 = num;
		_003C_003Ec__DisplayClass4_0 _003C_003Ec__DisplayClass4_ = default(_003C_003Ec__DisplayClass4_0);
		while (true)
		{
			switch (num2)
			{
			default:
				return hOOql3EDRRfK70UhQNFi(FindAll(_003C_003Ec__DisplayClass4_._003CIsProperty_003Eb__0)) > 0;
			case 3:
				_003C_003Ec__DisplayClass4_ = new _003C_003Ec__DisplayClass4_0();
				num2 = 2;
				break;
			case 1:
				_003C_003Ec__DisplayClass4_.propertyInfo = propertyInfo;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				_003C_003Ec__DisplayClass4_.exportSettingType = exportSettingType;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public bool IsPropertyIgnore(PropertyInfo propertyInfo)
	{
		//Discarded unreachable code: IL_00d1
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 3:
				if (!NnktKwEDK8tnVBXbdcqj(propertyInfo.PropertyType, Wk9wfZEDqaD7uZ8Cn6xE(typeof(long).TypeHandle)))
				{
					num2 = 2;
					continue;
				}
				goto case 4;
			case 4:
				if (!PKpRqeEDknAvMYK5Taeh(Dh7jNYEDX5LMFiXclqxv(propertyInfo), R8VR0xEDT8wfO5f9ieVH(0x49E27B8A ^ 0x49E2FAD4)))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			default:
				if (NnktKwEDK8tnVBXbdcqj(AkLl5dEDn5Lt2htAyL8x(propertyInfo), typeof(Guid)))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
					{
						num2 = 5;
					}
					continue;
				}
				goto case 1;
			case 5:
				if (!PKpRqeEDknAvMYK5Taeh(propertyInfo.Name, R8VR0xEDT8wfO5f9ieVH(-1765851862 ^ -1765846344)))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			case 1:
				return IsProperty(propertyInfo, ExportRuleType.Ignore);
			}
			break;
		}
		return true;
	}

	public bool IsPropertyExport(PropertyInfo propertyInfo)
	{
		return IsProperty(propertyInfo, ExportRuleType.Export);
	}

	public bool IsPropertyDeepExport(PropertyInfo propertyInfo)
	{
		return IsProperty(propertyInfo, ExportRuleType.ExportDeep);
	}

	public ExportRuleList()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool ksLJBoEDViZjXPnDmmgZ(object P_0)
	{
		return NHibernateProxyHelper.IsProxy(P_0);
	}

	internal static object VMKajaEDSbwU4tA2lb7A(object P_0)
	{
		return ((INHibernateProxy)P_0).get_HibernateLazyInitializer();
	}

	internal static object jbkC0FEDimCXDXidFlG1(object P_0)
	{
		return ((ILazyInitializer)P_0).GetImplementation();
	}

	internal static int hOOql3EDRRfK70UhQNFi(object P_0)
	{
		return ((List<ExportRule>)P_0).Count;
	}

	internal static bool h9jxACEDuI7oSR1NrMvF()
	{
		return YqEt8SEDZq1QMEiW1CIS == null;
	}

	internal static ExportRuleList CZ7uKDEDIdEKleuX3hg5()
	{
		return YqEt8SEDZq1QMEiW1CIS;
	}

	internal static Type Wk9wfZEDqaD7uZ8Cn6xE(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static bool NnktKwEDK8tnVBXbdcqj(Type P_0, Type P_1)
	{
		return P_0 == P_1;
	}

	internal static object Dh7jNYEDX5LMFiXclqxv(object P_0)
	{
		return ((MemberInfo)P_0).Name;
	}

	internal static object R8VR0xEDT8wfO5f9ieVH(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool PKpRqeEDknAvMYK5Taeh(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static Type AkLl5dEDn5Lt2htAyL8x(object P_0)
	{
		return ((PropertyInfo)P_0).PropertyType;
	}
}
