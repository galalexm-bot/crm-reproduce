using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Workflow.DTO.Models;
using EleWise.ELMA.Workflow.Managers;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Workflow.DTO.Managers;

public class InstancesByProcesDTOManager : DTOManager, IInstancesByProcesDTOManager, IConfigurationService
{
	internal static InstancesByProcesDTOManager iCGWgDeQrZbPQ0nWI4C;

	public WorkflowInstanceManager Manager
	{
		[CompilerGenerated]
		get
		{
			return _003CManager_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					_003CManager_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6fe3beca34a9422e873cd6ef331760ae == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	public virtual Dictionary<long, InstancesByProcesDTO> LoadInstanse(long id)
	{
		List<WorkflowInstanceStatus> list = new List<WorkflowInstanceStatus>();
		list.Add(WorkflowInstanceStatus.Running);
		list.Add(WorkflowInstanceStatus.None);
		list.Add(WorkflowInstanceStatus.Completed);
		list.Add(WorkflowInstanceStatus.Aborted);
		list.Add(WorkflowInstanceStatus.Terminated);
		IOrganizationItem entity = OrganizationItemManager.Instance.Load(id);
		List<IWorkflowInstance> list2 = WorkflowInstanceManager.Instance.GetInstancesByEntity(entity, null, list).ToList();
		Dictionary<long, InstancesByProcesDTO> dictionary = new Dictionary<long, InstancesByProcesDTO>();
		foreach (IWorkflowInstance item in list2)
		{
			if (!dictionary.ContainsKey(item.Process.Header.Id))
			{
				InstancesByProcesDTO value = new InstancesByProcesDTO
				{
					process = item.Process.Uid
				};
				dictionary.Add(item.Process.Header.Id, value);
			}
			switch (item.Status)
			{
			case WorkflowInstanceStatus.Running:
				dictionary[item.Process.Header.Id].RunningInstans++;
				break;
			case WorkflowInstanceStatus.Completed:
				dictionary[item.Process.Header.Id].CompletedInstans++;
				break;
			default:
				dictionary[item.Process.Header.Id].AbortedInstans++;
				break;
			}
		}
		return dictionary;
	}

	public InstancesByProcesDTOManager()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		ifmNAleMggfoy3M1kGo();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ecf910d183864897a7c8ec77e01689a4 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool upO64qep4kcfPAEZY4t()
	{
		return iCGWgDeQrZbPQ0nWI4C == null;
	}

	internal static InstancesByProcesDTOManager OBER66eCNRcNYXg3vxU()
	{
		return iCGWgDeQrZbPQ0nWI4C;
	}

	internal static void ifmNAleMggfoy3M1kGo()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}
}
