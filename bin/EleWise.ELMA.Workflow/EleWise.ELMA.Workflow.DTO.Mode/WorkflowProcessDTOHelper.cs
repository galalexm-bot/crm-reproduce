using System;
using System.Linq;
using AutoMapper;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Workflow.DTO.AutoMaps;
using EleWise.ELMA.Workflow.Models;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.DTO.Models;

public static class WorkflowProcessDTOHelper
{
	internal static WorkflowProcessDTOHelper HsxWt1rMpergMVLKreh;

	public static WorkflowProcessDTO CreateDTO(this IWorkflowProcess process)
	{
		int num = 1;
		int num2 = num;
		Type type = default(Type);
		Type type2 = default(Type);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return (WorkflowProcessDTO)bAvtLhrG67TCSyv9Bp7(process, type, type2);
			case 3:
				type2 = oHpmYprANMbnS3kEYFn(type);
				num2 = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3ab79470996d472f815915b21f45aac1 == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				if (process == null)
				{
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7d23dbc0284240b99ff34f0f55f345f6 == 0)
					{
						num2 = 0;
					}
				}
				else
				{
					type = TKvXpJrVfuoAemL4PIl(process.GetType());
					num2 = 3;
				}
				break;
			default:
				return null;
			}
		}
	}

	public static IWorkflowProcess CreateEntity(this WorkflowProcessDTO dto)
	{
		int num = 1;
		int num2 = num;
		Type type = default(Type);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return (IWorkflowProcess)Mapper.Map((object)dto, dto.GetType(), type);
			default:
				return null;
			case 1:
				if (dto != null)
				{
					type = TjbI0yr7n6FxKFTBl7P(dto.GetType());
					num2 = 2;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8f870ea690334e7ab7599d275d195e9a == 0)
					{
						num2 = 1;
					}
				}
				else
				{
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_eb7de45300244c968ac00be3ffdf3d29 == 0)
					{
						num2 = 0;
					}
				}
				break;
			}
		}
	}

	private static Type GetEntityTypeByDTOType(Type dtoType)
	{
		int num = 2;
		_003C_003Ec__DisplayClass2_0 _003C_003Ec__DisplayClass2_ = default(_003C_003Ec__DisplayClass2_0);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					_003C_003Ec__DisplayClass2_.dtoType = dtoType;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_dcdfd019631e458b9cb5fa34a16a2fe1 == 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					_003C_003Ec__DisplayClass2_ = new _003C_003Ec__DisplayClass2_0();
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_67df302d7a2e4c95b7c8b62f21f3a833 == 0)
					{
						num2 = 1;
					}
					continue;
				case 3:
					return Sj33V7rIvMOj6I8rmbB(((ComponentManager)NWFvv7rFQWMuWsYM9HN()).GetExtensionPoints<IWorkflowProcessMap>().FirstOrDefault(_003C_003Ec__DisplayClass2_._003CGetEntityTypeByDTOType_003Eb__0) ?? throw new Exception((string)kuMKkPriLtdyMOmOCbI(BUqb36r2fnpna9Lfock(0x5F800F5B ^ 0x5F815A11), _003C_003Ec__DisplayClass2_.dtoType.FullName)));
				}
				break;
			}
			wxfLUxroxlNtw8Ubplc(_003C_003Ec__DisplayClass2_.dtoType, BUqb36r2fnpna9Lfock(-29981480 ^ -29896224));
			num = 3;
		}
	}

	private static Type GetDTOTypeByEntityType(Type entityType)
	{
		int num = 2;
		int num2 = num;
		_003C_003Ec__DisplayClass3_0 _003C_003Ec__DisplayClass3_ = default(_003C_003Ec__DisplayClass3_0);
		while (true)
		{
			switch (num2)
			{
			case 3:
				wxfLUxroxlNtw8Ubplc(_003C_003Ec__DisplayClass3_.entityType, BUqb36r2fnpna9Lfock(0x5DB28AD2 ^ 0x5DB3DF66));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c7fe5d092d804f7e91041fb2338cec1a == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				_003C_003Ec__DisplayClass3_.entityType = entityType;
				num2 = 3;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_46e05b4e09174e34a9c81741b8b77a2f != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				_003C_003Ec__DisplayClass3_ = new _003C_003Ec__DisplayClass3_0();
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1a2d7634479d44fb8d3718c31b05f73c == 0)
				{
					num2 = 0;
				}
				break;
			default:
				return (((ComponentManager)NWFvv7rFQWMuWsYM9HN()).GetExtensionPoints<IWorkflowProcessMap>().FirstOrDefault(_003C_003Ec__DisplayClass3_._003CGetDTOTypeByEntityType_003Eb__0) ?? throw new Exception((string)kuMKkPriLtdyMOmOCbI(BUqb36r2fnpna9Lfock(-45832783 ^ -45748099), _003C_003Ec__DisplayClass3_.entityType.FullName))).DTOType;
			}
		}
	}

	internal static Type TKvXpJrVfuoAemL4PIl(Type P_0)
	{
		return P_0.GetTypeWithoutProxy();
	}

	internal static Type oHpmYprANMbnS3kEYFn(Type entityType)
	{
		return GetDTOTypeByEntityType(entityType);
	}

	internal static object bAvtLhrG67TCSyv9Bp7(object P_0, Type P_1, Type P_2)
	{
		return Mapper.Map(P_0, P_1, P_2);
	}

	internal static bool K7CleMrkiTtgraUuoMt()
	{
		return HsxWt1rMpergMVLKreh == null;
	}

	internal static WorkflowProcessDTOHelper iFOT8XrUAFn8TemWnnW()
	{
		return HsxWt1rMpergMVLKreh;
	}

	internal static Type TjbI0yr7n6FxKFTBl7P(Type dtoType)
	{
		return GetEntityTypeByDTOType(dtoType);
	}

	internal static object BUqb36r2fnpna9Lfock(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void wxfLUxroxlNtw8Ubplc(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static object NWFvv7rFQWMuWsYM9HN()
	{
		return ComponentManager.Current;
	}

	internal static object kuMKkPriLtdyMOmOCbI(object P_0, object P_1)
	{
		return string.Format((string)P_0, P_1);
	}

	internal static Type Sj33V7rIvMOj6I8rmbB(object P_0)
	{
		return ((IWorkflowProcessMap)P_0).EntityType;
	}
}
