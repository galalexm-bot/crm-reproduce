using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy;
using EleWise.ELMA.Deploy.Export;
using EleWise.ELMA.Deploy.Export.ExtensionPoints;
using EleWise.ELMA.Deploy.ExportHelper;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Services;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Tasks;
using EleWise.ELMA.Workflow.Managers;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Deploy.Export;

[Component(Order = 400)]
public class WorkflowProcessExportExtension : IConfigExportExtension
{
	private ExportRuleBuilder<IWorkflowMessageType> customExportRuleBuilder;

	internal static WorkflowProcessExportExtension xWZV3STKy13gF5QdvNK;

	public Dictionary<Guid, object> GetNewSettingObj()
	{
		return new Dictionary<Guid, object>();
	}

	private void AddCustomRules()
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 1:
			{
				ExportRuleBuilderSelectType<IWorkflowMessageType> exportRuleBuilderSelectType = customExportRuleBuilder.Rule();
				ParameterExpression parameterExpression = Expression.Parameter(typeof(IWorkflowMessageType), (string)zv7oEDTYq6Pkyrxg4tB(-92270799 ^ -92242653));
				XoefYYTPgNdfXU6ZHvP(exportRuleBuilderSelectType.ForPropertyName(Expression.Lambda<Func<IWorkflowMessageType, object>>(Expression.Property(parameterExpression, (MethodInfo)eqYo5uTvf98IGrYuM9M((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression })));
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_e284642f05f54785bb4c3e22d7a51872 == 0)
				{
					num2 = 0;
				}
				break;
			}
			case 2:
				customExportRuleBuilder = new ExportRuleBuilder<IWorkflowMessageType>(new ExportRuleList());
				num2 = 1;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_48279d3d45e2437b9907d478ce5a47b1 != 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	private List<IEntity> GetEntities(IWorkflowMessageType wfMessage)
	{
		ExportHelperBuilder<IWorkflowMessageType> exportHelperBuilder = ExportHelperBuilder.Create(wfMessage);
		exportHelperBuilder.ExportRuleList = customExportRuleBuilder.ExportRules;
		return exportHelperBuilder.EntityExportList();
	}

	public void AddExportObjects(ExportExtensionParams parameters)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			case 1:
				AddCustomRules();
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_2a51554405284f038cd375280fa9ccb8 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				AddExportObjectsCustom(parameters.Parameters, parameters.PacketEntities);
				num2 = 1;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_c5274b5f82c74d1e8e92ea099532df1e != 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	private void AddExportObjectsCustom(Dictionary<Guid, object> parameters, List<PacketEntity> packetEntities)
	{
		if (parameters[WorkflowExportConsts.ExportExtensionUid] is WorkflowExportSetting workflowExportSetting && workflowExportSetting.ExportProcesses)
		{
			ICollection<IProcessHeader> headers = GetHeaders(workflowExportSetting);
			AddMessageType(packetEntities, headers);
		}
	}

	private void AddMessageType(List<PacketEntity> packetEntities, ICollection<IProcessHeader> headers)
	{
		ProcessHeaderManager serviceNotNull = Locator.GetServiceNotNull<ProcessHeaderManager>();
		IEntityManager<IWorkflowMessageType> instance = EntityManager<IWorkflowMessageType>.Instance;
		using IEnumerator<IProcessHeader> enumerator = headers.GetEnumerator();
		while (enumerator.MoveNext())
		{
			_003C_003Ec__DisplayClass6_0 CS_0024_003C_003E8__locals1 = new _003C_003Ec__DisplayClass6_0();
			CS_0024_003C_003E8__locals1.header = enumerator.Current;
			List<IWorkflowMessageTypeParameter> collection = new List<IWorkflowMessageTypeParameter>();
			List<IWorkflowMessageType> list = new List<IWorkflowMessageType>();
			List<IProcessHeader> subprocessTreeList = serviceNotNull.GetSubprocessTreeList(CS_0024_003C_003E8__locals1.header);
			List<PacketEntity> list2 = packetEntities.Where(delegate(PacketEntity p)
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 1:
						if (!(p.Entity is IProcessHeader))
						{
							return false;
						}
						num2 = 0;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_69deb269d49f4dd296bf46a0a542f92b == 0)
						{
							num2 = 0;
						}
						break;
					default:
						return (long)p.Entity.GetId() == CS_0024_003C_003E8__locals1.header.Id;
					}
				}
			}).ToList();
			PacketEntity packetEntity = (list2.Any() ? list2[0] : new PacketEntity(CS_0024_003C_003E8__locals1.header));
			List<MessageElement> list3 = new List<MessageElement>();
			List<IProcessHeader> list4 = new List<IProcessHeader>();
			list4.Add(CS_0024_003C_003E8__locals1.header);
			list4.AddRange(subprocessTreeList);
			foreach (IProcessHeader item in list4)
			{
				IWorkflowProcess current = item.Current;
				if (current != null && current.Diagram != null && current.Diagram.Elements != null)
				{
					list3.AddRange(current.Diagram.Elements.OfType<MessageElement>());
				}
			}
			foreach (MessageElement item2 in list3)
			{
				_003C_003Ec__DisplayClass6_1 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass6_1();
				CS_0024_003C_003E8__locals0.uidMessage = default(Guid);
				if (item2 is MessageSendElement)
				{
					CS_0024_003C_003E8__locals0.uidMessage = ((MessageSendElement)item2).UIDMessage;
				}
				if (item2 is MessageReceiveElement)
				{
					CS_0024_003C_003E8__locals0.uidMessage = ((MessageReceiveElement)item2).UIDMessage;
				}
				if (list.FirstOrDefault((IWorkflowMessageType k) => _003C_003Ec__DisplayClass6_1.jxon4WREeUYndiwPKCP(_003C_003Ec__DisplayClass6_1.L3tfFP6z7Amp9FKhwoC(k), CS_0024_003C_003E8__locals0.uidMessage)) != null)
				{
					continue;
				}
				IWorkflowMessageType workflowMessageType = instance.LoadOrNull(CS_0024_003C_003E8__locals0.uidMessage);
				if (workflowMessageType == null)
				{
					continue;
				}
				if (packetEntity.ExportRules == null)
				{
					packetEntity.ExportRules = customExportRuleBuilder.ExportRules;
				}
				else
				{
					packetEntity.ExportRules.AddRange(customExportRuleBuilder.ExportRules);
				}
				foreach (IEntity entity in GetEntities(workflowMessageType))
				{
					if (!packetEntity.SubEntities.Contains(entity))
					{
						packetEntity.SubEntities.Add(entity);
					}
				}
				if (packetEntities.Any((PacketEntity p) => p.Entity == CS_0024_003C_003E8__locals1.header))
				{
					PacketEntity packetEntity2 = packetEntities.First((PacketEntity p) => p.Entity == CS_0024_003C_003E8__locals1.header);
					packetEntity2.SubEntities.AddRange(collection);
					packetEntity2.SubEntities.AddRange(list);
				}
				else
				{
					PacketEntity packetEntity3 = new PacketEntity(CS_0024_003C_003E8__locals1.header);
					packetEntity3.SubEntities.AddRange(collection);
					packetEntity3.SubEntities.AddRange(list);
					packetEntities.Add(packetEntity3);
				}
			}
		}
	}

	private ICollection<IProcessHeader> GetHeaders(WorkflowExportSetting workflowExportSettings)
	{
		List<IProcessHeader> list = new List<IProcessHeader>();
		HashSet<Guid> hashSet = new HashSet<Guid>();
		ProcessHeaderManager serviceNotNull = Locator.GetServiceNotNull<ProcessHeaderManager>();
		if (workflowExportSettings.ProcessesIds != null)
		{
			foreach (long processesId in workflowExportSettings.ProcessesIds)
			{
				IProcessHeader processHeader = serviceNotNull.Load(processesId);
				if (processHeader != null)
				{
					list.Add(processHeader);
					hashSet.Add(processHeader.Uid);
				}
			}
		}
		if (workflowExportSettings.ProcessesUids != null)
		{
			foreach (Guid processesUid in workflowExportSettings.ProcessesUids)
			{
				if (!hashSet.Contains(processesUid))
				{
					IProcessHeader processHeader2 = serviceNotNull.Load(processesUid);
					if (processHeader2 != null)
					{
						list.Add(processHeader2);
						hashSet.Add(processHeader2.Uid);
					}
				}
			}
			return list;
		}
		return list;
	}

	public WorkflowProcessExportExtension()
	{
		//Discarded unreachable code: IL_003f, IL_0044
		rOTJPxT45eQrSDH8tYE();
		customExportRuleBuilder = new ExportRuleBuilder<IWorkflowMessageType>(new ExportRuleList());
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_368897dda30d41e8b26c6b065203d16b == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object zv7oEDTYq6Pkyrxg4tB(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object eqYo5uTvf98IGrYuM9M(RuntimeMethodHandle P_0)
	{
		return MethodBase.GetMethodFromHandle(P_0);
	}

	internal static void XoefYYTPgNdfXU6ZHvP(object P_0)
	{
		((ExportRuleBuilderSelectAction<IWorkflowMessageType>)P_0).ExportDeep();
	}

	internal static bool O6J3CoTMUSQFKGT1ZIZ()
	{
		return xWZV3STKy13gF5QdvNK == null;
	}

	internal static WorkflowProcessExportExtension sGggm2TaX0WiQK3wr4s()
	{
		return xWZV3STKy13gF5QdvNK;
	}

	internal static void rOTJPxT45eQrSDH8tYE()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.reZueBLff7();
	}
}
