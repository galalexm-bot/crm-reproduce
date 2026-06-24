using EleWise.ELMA.Workflow.Models;

namespace EleWise.ELMA.Workflow.Helpers;

public static class WorkflowInstanceHelper
{
	internal static WorkflowInstanceHelper iolorDpzwo6oOxsFCsH;

	public static string InstanceName(this IWorkflowInstance instance)
	{
		//Discarded unreachable code: IL_003e
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return (string)O6HkaaCZni3i6X21sUl(instance);
			case 3:
				return null;
			default:
				if (CgwnE7CvNNm0C3ouKhJ(O6HkaaCZni3i6X21sUl(instance)))
				{
					return SR.Untitled;
				}
				num2 = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1c37d4e24e094858975336738e156495 == 0)
				{
					num2 = 2;
				}
				break;
			case 1:
				if (instance != null)
				{
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7ed81ca3cf804abbade4684f28f485d1 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 3;
			}
		}
	}

	internal static object O6HkaaCZni3i6X21sUl(object P_0)
	{
		return ((IWorkflowInstance)P_0).Name;
	}

	internal static bool CgwnE7CvNNm0C3ouKhJ(object P_0)
	{
		return string.IsNullOrWhiteSpace((string)P_0);
	}

	internal static bool KPA85kCKaDCsbjVbXph()
	{
		return iolorDpzwo6oOxsFCsH == null;
	}

	internal static WorkflowInstanceHelper cwfY5NCO4hyW60IoR5H()
	{
		return iolorDpzwo6oOxsFCsH;
	}
}
