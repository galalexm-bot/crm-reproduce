using System;
using System.Reflection;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Services;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Deploy.Managers;

public class TypeDTOManager : DTOManager, ITypeDTOManager, IConfigurationService
{
	private static Type typeAttribute;

	private readonly IMetadataRuntimeService metadataRuntimeService;

	private static TypeDTOManager xJADj6EthUQwta1cAmlv;

	public TypeDTOManager(IMetadataRuntimeService metadataRuntimeService)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				this.metadataRuntimeService = metadataRuntimeService;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public virtual bool CheckUniqueName(Guid typeUid, string propertyName, Guid propertyUid)
	{
		//Discarded unreachable code: IL_0068, IL_0077, IL_0138, IL_0147
		int num = 10;
		Type typeByUidOrNull = default(Type);
		PropertyInfo property = default(PropertyInfo);
		UidAttribute uidAttribute = default(UidAttribute);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					if (VO9ckZEtQHyMNLIXd54A(typeByUidOrNull, null))
					{
						num2 = 3;
						continue;
					}
					property = typeByUidOrNull.GetProperty(propertyName, BindingFlags.IgnoreCase | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public);
					num = 6;
					break;
				case 10:
					if (!(typeUid == Guid.Empty))
					{
						num2 = 9;
						continue;
					}
					goto case 2;
				default:
					return pMjNy3Etf2nIoOy4id8h(uidAttribute.Uid, propertyUid);
				case 7:
					return false;
				case 3:
					return true;
				case 6:
					if (pv8IZEEtCFLlk2cxEIx6(property, null))
					{
						num2 = 5;
						continue;
					}
					uidAttribute = BFLc1BEtv8bKNR8ZCyjk(property, typeAttribute) as UidAttribute;
					num2 = 11;
					continue;
				case 9:
					if (pMjNy3Etf2nIoOy4id8h(propertyUid, Guid.Empty))
					{
						num2 = 4;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
						{
							num2 = 4;
						}
						continue;
					}
					goto case 8;
				case 8:
					if (string.IsNullOrEmpty(propertyName))
					{
						num2 = 2;
						continue;
					}
					typeByUidOrNull = metadataRuntimeService.GetTypeByUidOrNull(typeUid);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
					{
						num2 = 0;
					}
					continue;
				case 11:
					if (uidAttribute == null)
					{
						num = 7;
						break;
					}
					goto default;
				case 5:
					return true;
				case 2:
				case 4:
					return true;
				}
				break;
			}
		}
	}

	static TypeDTOManager()
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
				typeAttribute = Wg5UobEt8phDOROtjg9W(typeof(UidAttribute).TypeHandle);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				SingletonReader.JJCZtPuTvSt();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	internal static bool aILd7JEtGnJOFDPN1Tew()
	{
		return xJADj6EthUQwta1cAmlv == null;
	}

	internal static TypeDTOManager cec1o1EtEQaMvipLYNyo()
	{
		return xJADj6EthUQwta1cAmlv;
	}

	internal static bool pMjNy3Etf2nIoOy4id8h(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}

	internal static bool VO9ckZEtQHyMNLIXd54A(Type P_0, Type P_1)
	{
		return P_0 == P_1;
	}

	internal static bool pv8IZEEtCFLlk2cxEIx6(object P_0, object P_1)
	{
		return (PropertyInfo)P_0 == (PropertyInfo)P_1;
	}

	internal static object BFLc1BEtv8bKNR8ZCyjk(object P_0, Type P_1)
	{
		return ((MemberInfo)P_0).GetCustomAttribute(P_1);
	}

	internal static Type Wg5UobEt8phDOROtjg9W(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}
}
