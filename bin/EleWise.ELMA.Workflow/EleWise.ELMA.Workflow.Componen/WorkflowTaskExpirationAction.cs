using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Tasks.ExtensionPoints;
using EleWise.ELMA.Tasks.Models;
using EleWise.ELMA.Workflow.Managers;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Workflow.Components;

[Component(Order = 100)]
public class WorkflowTaskExpirationAction : ITaskExpirationAction
{
	private static WorkflowTaskExpirationAction LmWPXgOBgdJw3Qqueg5r;

	public bool CheckType(ITaskBase task)
	{
		//Discarded unreachable code: IL_0129, IL_0138, IL_0148, IL_0157, IL_0166
		int num = 1;
		_003C_003Ec__DisplayClass0_0 _003C_003Ec__DisplayClass0_ = default(_003C_003Ec__DisplayClass0_0);
		EntityMetadata entityMetadata = default(EntityMetadata);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 12:
					if (_003C_003Ec__DisplayClass0_.bookmark == null)
					{
						num2 = 5;
						continue;
					}
					goto case 6;
				case 3:
				case 5:
					return false;
				case 4:
					if (h00RJ7OBn73An8p2lFVS(entityMetadata.Properties) == 0)
					{
						num2 = 2;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c447ffb64be44c09b6fd398df506785b == 0)
						{
							num2 = 2;
						}
						continue;
					}
					return entityMetadata.Properties.OfType<ProcessInstanceMetric>().Any(_003C_003Ec__DisplayClass0_._003CCheckType_003Eb__0);
				default:
					_003C_003Ec__DisplayClass0_._003C_003E4__this = this;
					num = 10;
					break;
				case 6:
					if (FqfcLOOBXYMb88mEGOTD(_003C_003Ec__DisplayClass0_.bookmark) != null)
					{
						num2 = 9;
						continue;
					}
					goto case 3;
				case 10:
					if (task != null)
					{
						num2 = 11;
						continue;
					}
					goto case 13;
				case 1:
					_003C_003Ec__DisplayClass0_ = new _003C_003Ec__DisplayClass0_0();
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_67df302d7a2e4c95b7c8b62f21f3a833 == 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
				case 8:
					return false;
				case 13:
					return false;
				case 11:
					_003C_003Ec__DisplayClass0_.bookmark = (IWorkflowBookmark)U3CR98OBPeLGAN5Z7H8F((IWorkflowTaskBase)task);
					num2 = 6;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_abfb511163674a3eae959fd60da8f319 == 0)
					{
						num2 = 12;
					}
					continue;
				case 9:
					if (((IWorkflowInstance)FqfcLOOBXYMb88mEGOTD(_003C_003Ec__DisplayClass0_.bookmark)).Process != null)
					{
						entityMetadata = (EntityMetadata)NUSrgfOBDZy9jAwrit7X(OIgvA1OBd9NpRXJldmCj(), z2E73tOBults1IEaTdgq(FqfcLOOBXYMb88mEGOTD(_003C_003Ec__DisplayClass0_.bookmark)));
						num = 7;
						break;
					}
					num2 = 3;
					continue;
				case 7:
					if (entityMetadata == null)
					{
						num2 = 8;
						continue;
					}
					goto case 4;
				}
				break;
			}
		}
	}

	public void DoAction(ITaskBase task, DateTime date)
	{
		//Discarded unreachable code: IL_0132, IL_0141, IL_014c, IL_027b, IL_028e, IL_029d, IL_02ae, IL_02bd, IL_02cd, IL_02dc
		int num = 2;
		int num2 = num;
		EntityMetadata entityMetadata = default(EntityMetadata);
		List<PropertyMetadata>.Enumerator enumerator = default(List<PropertyMetadata>.Enumerator);
		IWorkflowBookmark workflowBookmark = default(IWorkflowBookmark);
		ProcessInstanceMetric processInstanceMetric = default(ProcessInstanceMetric);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 3:
				if (entityMetadata.Properties.Count == 0)
				{
					num2 = 10;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5816b3723c134946ad9294172266312e != 0)
					{
						num2 = 6;
					}
					continue;
				}
				enumerator = entityMetadata.Properties.GetEnumerator();
				num2 = 4;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_abfb511163674a3eae959fd60da8f319 == 0)
				{
					num2 = 4;
				}
				continue;
			case 2:
				workflowBookmark = (IWorkflowBookmark)U3CR98OBPeLGAN5Z7H8F((IWorkflowTaskBase)task);
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d87d9a74c9e14f96a288cc3620965fe0 == 0)
				{
					num2 = 1;
				}
				continue;
			case 7:
				return;
			case 9:
				return;
			case 6:
				if (entityMetadata == null)
				{
					num2 = 8;
					continue;
				}
				goto case 3;
			case 8:
				return;
			case 10:
				return;
			case 1:
				if (workflowBookmark == null)
				{
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6782172e84504a7baf3163b8f6b2a916 == 0)
					{
						num2 = 9;
					}
					continue;
				}
				break;
			case 4:
				try
				{
					while (true)
					{
						IL_01c4:
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 2;
							goto IL_0150;
						}
						goto IL_016e;
						IL_0150:
						while (true)
						{
							switch (num3)
							{
							case 1:
								break;
							case 3:
								if (IsMetricAvailable(processInstanceMetric, workflowBookmark.ElementUid))
								{
									num3 = 4;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_805f3361d2ba4dac8da4174f89314253 != 0)
									{
										num3 = 4;
									}
									continue;
								}
								goto IL_01c4;
							default:
								goto IL_01c4;
							case 4:
							{
								object obj = oMd4RHOBHTTGuMyfXNtu(workflowBookmark.Instance);
								Guid uid = processInstanceMetric.Uid;
								DateTime? creationDate = task.CreationDate;
								((Entity<long>)obj).SetPropertyValue(uid, (object)(date - creationDate));
								num3 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5816b3723c134946ad9294172266312e == 0)
								{
									num3 = 0;
								}
								continue;
							}
							case 2:
								return;
							}
							break;
						}
						goto IL_016e;
						IL_016e:
						processInstanceMetric = (ProcessInstanceMetric)enumerator.Current;
						num3 = 3;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3f508947b0d94af1961e5aa17a8a2044 != 0)
						{
							num3 = 2;
						}
						goto IL_0150;
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
					int num4 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bb19f93c0a774f6cbdada859bba83212 == 0)
					{
						num4 = 0;
					}
					switch (num4)
					{
					case 0:
						break;
					}
				}
			case 0:
				return;
			case 11:
				if (z2E73tOBults1IEaTdgq(FqfcLOOBXYMb88mEGOTD(workflowBookmark)) != null)
				{
					entityMetadata = (EntityMetadata)NUSrgfOBDZy9jAwrit7X(OIgvA1OBd9NpRXJldmCj(), z2E73tOBults1IEaTdgq(FqfcLOOBXYMb88mEGOTD(workflowBookmark)));
					num2 = 6;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_545887e65739480a965b7ddfab7d0632 != 0)
					{
						num2 = 1;
					}
				}
				else
				{
					num2 = 7;
				}
				continue;
			case 5:
				break;
			}
			if (FqfcLOOBXYMb88mEGOTD(workflowBookmark) == null)
			{
				break;
			}
			num2 = 11;
		}
	}

	private bool IsMetricAvailable(ProcessInstanceMetric metric, Guid? elementUid)
	{
		if (metric.Active && metric.Type == ProcessMetricComputationType.Time && metric.TimeMetricCalculationType == ProcessMetricTimeCalculationType.TaskExecutionTime)
		{
			Guid? selectedProcessTaskUid = metric.SelectedProcessTaskUid;
			Guid? guid = elementUid;
			if (selectedProcessTaskUid.HasValue != guid.HasValue)
			{
				return false;
			}
			if (!selectedProcessTaskUid.HasValue)
			{
				return true;
			}
			return selectedProcessTaskUid.GetValueOrDefault() == guid.GetValueOrDefault();
		}
		return false;
	}

	public WorkflowTaskExpirationAction()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		L8YcwTOBLuL40AJYLbsx();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f33560c5d18b4e10b24a458578aa60fd != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object U3CR98OBPeLGAN5Z7H8F(object P_0)
	{
		return ((IWorkflowTaskBase)P_0).WorkflowBookmark;
	}

	internal static object FqfcLOOBXYMb88mEGOTD(object P_0)
	{
		return ((IWorkflowBookmark)P_0).Instance;
	}

	internal static object OIgvA1OBd9NpRXJldmCj()
	{
		return WorkflowInstanceContextService.Instance;
	}

	internal static object z2E73tOBults1IEaTdgq(object P_0)
	{
		return ((IWorkflowInstance)P_0).Process;
	}

	internal static object NUSrgfOBDZy9jAwrit7X(object P_0, object P_1)
	{
		return ((WorkflowInstanceContextService)P_0).GetInstanceMetricValuesMetadata((IWorkflowProcess)P_1);
	}

	internal static int h00RJ7OBn73An8p2lFVS(object P_0)
	{
		return ((List<PropertyMetadata>)P_0).Count;
	}

	internal static bool NuIFpsOBBVR3InC68HqE()
	{
		return LmWPXgOBgdJw3Qqueg5r == null;
	}

	internal static WorkflowTaskExpirationAction XagYRwOBcgJCqLoUScCs()
	{
		return LmWPXgOBgdJw3Qqueg5r;
	}

	internal static object oMd4RHOBHTTGuMyfXNtu(object P_0)
	{
		return ((IWorkflowInstance)P_0).MetricValues;
	}

	internal static void L8YcwTOBLuL40AJYLbsx()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}
}
