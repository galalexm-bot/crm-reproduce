using System;
using System.Linq;
using AutoMapper;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Workflow.DTO.AutoMaps;
using EleWise.ELMA.Workflow.Models;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.DTO.Models;

public static class CustomActivityDTOHelper
{
	private static CustomActivityDTOHelper UTBnXR9OmWkSgAUZJj4;

	public static CustomActivityDTO CreateDTO(this ICustomActivity ca)
	{
		//Discarded unreachable code: IL_00a1
		int num = 2;
		int num2 = num;
		Type type = default(Type);
		Type type2 = default(Type);
		while (true)
		{
			switch (num2)
			{
			case 3:
				return null;
			case 1:
				type = DjmcV890F0yAfXrw0p7(ca.GetType());
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_e496a9998cf542ff98d1a5e001d6c664 != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				if (ca != null)
				{
					num2 = 1;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_427a79594804461da96485ca77914e7b == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 3;
			default:
				type2 = zh4k1R9B28pqfrBabTb(type);
				num2 = 4;
				break;
			case 4:
				return (CustomActivityDTO)pXOWC29WI1aUkrOyFUg(ca, type, type2);
			}
		}
	}

	public static ICustomActivity CreateEntity(this CustomActivityDTO dto)
	{
		//Discarded unreachable code: IL_0031
		int num = 2;
		int num2 = num;
		Type type = default(Type);
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (dto != null)
				{
					num2 = 1;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_d526d6cd8ea24dfca60f96f0f0be6307 != 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 3;
			case 3:
				return null;
			case 1:
				type = cm5olN9HPwrISNwCBtr(dto.GetType());
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_d526d6cd8ea24dfca60f96f0f0be6307 != 0)
				{
					num2 = 0;
				}
				break;
			default:
				return (ICustomActivity)pXOWC29WI1aUkrOyFUg(dto, dto.GetType(), type);
			}
		}
	}

	private static Type GetEntityTypeByDTOType(Type dtoType)
	{
		int num = 2;
		int num2 = num;
		_003C_003Ec__DisplayClass2_0 _003C_003Ec__DisplayClass2_ = default(_003C_003Ec__DisplayClass2_0);
		while (true)
		{
			switch (num2)
			{
			case 1:
				_003C_003Ec__DisplayClass2_.dtoType = dtoType;
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_67c4b8cf6de246108f53fc3d72e6757a == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				_003C_003Ec__DisplayClass2_ = new _003C_003Ec__DisplayClass2_0();
				num2 = 1;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_b813a6ed0be8497dbd700b40350f9732 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				Contract.ArgumentNotNull(_003C_003Ec__DisplayClass2_.dtoType, (string)kxdSoZ9e91T3L5CJg9v(0x3C126B81 ^ 0x3C121B37));
				num2 = 3;
				break;
			case 3:
				return p0Kw5c9uPdOpe9LKVfq(((ComponentManager)cR2bRo9iWhA2mMWS548()).GetExtensionPoints<ICustomActivityMap>().FirstOrDefault(_003C_003Ec__DisplayClass2_._003CGetEntityTypeByDTOType_003Eb__0) ?? throw new Exception(string.Format((string)kxdSoZ9e91T3L5CJg9v(-2038019883 ^ -2038024163), _003C_003Ec__DisplayClass2_.dtoType.FullName)));
			}
		}
	}

	private static Type GetDTOTypeByEntityType(Type entityType)
	{
		int num = 1;
		int num2 = num;
		_003C_003Ec__DisplayClass3_0 _003C_003Ec__DisplayClass3_ = default(_003C_003Ec__DisplayClass3_0);
		while (true)
		{
			switch (num2)
			{
			case 2:
				Contract.ArgumentNotNull(_003C_003Ec__DisplayClass3_.entityType, (string)kxdSoZ9e91T3L5CJg9v(-1587393812 ^ -1587397714));
				num2 = 3;
				break;
			case 1:
				_003C_003Ec__DisplayClass3_ = new _003C_003Ec__DisplayClass3_0();
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_ec7d0b62d0f94d70bbee4df19d5df325 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				_003C_003Ec__DisplayClass3_.entityType = entityType;
				num2 = 2;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_25eedcea124a48258fd18106b7da9d93 != 0)
				{
					num2 = 1;
				}
				break;
			case 3:
				return (ComponentManager.Current.GetExtensionPoints<ICustomActivityMap>().FirstOrDefault(_003C_003Ec__DisplayClass3_._003CGetDTOTypeByEntityType_003Eb__0) ?? throw new Exception((string)FGP8lj9lQxwj3vNZD4r(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x624F2FBE ^ 0x624F5EE4), _003C_003Ec__DisplayClass3_.entityType.FullName))).DTOType;
			}
		}
	}

	internal static Type DjmcV890F0yAfXrw0p7(Type P_0)
	{
		return P_0.GetTypeWithoutProxy();
	}

	internal static Type zh4k1R9B28pqfrBabTb(Type entityType)
	{
		return GetDTOTypeByEntityType(entityType);
	}

	internal static object pXOWC29WI1aUkrOyFUg(object P_0, Type P_1, Type P_2)
	{
		return Mapper.Map(P_0, P_1, P_2);
	}

	internal static bool mM25Ox96QSKWrcQESkL()
	{
		return UTBnXR9OmWkSgAUZJj4 == null;
	}

	internal static CustomActivityDTOHelper G6PwLE9R1KIFonZqfgY()
	{
		return UTBnXR9OmWkSgAUZJj4;
	}

	internal static Type cm5olN9HPwrISNwCBtr(Type dtoType)
	{
		return GetEntityTypeByDTOType(dtoType);
	}

	internal static object kxdSoZ9e91T3L5CJg9v(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object cR2bRo9iWhA2mMWS548()
	{
		return ComponentManager.Current;
	}

	internal static Type p0Kw5c9uPdOpe9LKVfq(object P_0)
	{
		return ((ICustomActivityMap)P_0).EntityType;
	}

	internal static object FGP8lj9lQxwj3vNZD4r(object P_0, object P_1)
	{
		return string.Format((string)P_0, P_1);
	}
}
