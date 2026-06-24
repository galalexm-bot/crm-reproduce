using System;
using System.Linq.Expressions;
using System.Reflection;
using AutoMapper;
using EleWise.ELMA.Model.AutoMaps;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Workflow.BPMN.DTO.Models;
using EleWise.ELMA.Workflow.BPMN.Models;
using EleWise.ELMA.Workflow.Managers;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.BPMN.DTO.AutoMaps;

public class ResponsibilityMatrixItemMap : BidirectionalMap<IResponsibilityMatrixItem, ResponsibilityMatrixItemDTO>
{
	private static ResponsibilityMatrixItemMap rE5r2BO7fKb6XkBLAY5L;

	protected override void InitMap(IMappingExpression<IResponsibilityMatrixItem, ResponsibilityMatrixItemDTO> map)
	{
		base.InitMap(map);
		ParameterExpression parameterExpression = Expression.Parameter(typeof(ResponsibilityMatrixItemDTO), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-148495695 ^ -148423009));
		map.ForMember<Worker>(Expression.Lambda<Func<ResponsibilityMatrixItemDTO, Worker>>(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }), (Action<IMemberConfigurationExpression<IResponsibilityMatrixItem, ResponsibilityMatrixItemDTO, Worker>>)delegate(IMemberConfigurationExpression<IResponsibilityMatrixItem, ResponsibilityMatrixItemDTO, Worker> mo)
		{
			mo.ResolveUsing<Worker>((Func<IResponsibilityMatrixItem, Worker>)MapWorkerToDTO);
		});
	}

	protected override void InitReverseMap(IMappingExpression<ResponsibilityMatrixItemDTO, IResponsibilityMatrixItem> map)
	{
		base.InitReverseMap(map);
		ParameterExpression parameterExpression = Expression.Parameter(typeof(IResponsibilityMatrixItem), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3C1FFB55 ^ 0x3C1EE77B));
		map.ForMember<long?>(Expression.Lambda<Func<IResponsibilityMatrixItem, long?>>(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }), (Action<IMemberConfigurationExpression<ResponsibilityMatrixItemDTO, IResponsibilityMatrixItem, long?>>)delegate(IMemberConfigurationExpression<ResponsibilityMatrixItemDTO, IResponsibilityMatrixItem, long?> a)
		{
			a.Ignore();
		});
		parameterExpression = Expression.Parameter(typeof(IResponsibilityMatrixItem), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x70EBB9F3 ^ 0x70EAA5DD));
		map.ForMember<Guid>(Expression.Lambda<Func<IResponsibilityMatrixItem, Guid>>(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }), (Action<IMemberConfigurationExpression<ResponsibilityMatrixItemDTO, IResponsibilityMatrixItem, Guid>>)delegate(IMemberConfigurationExpression<ResponsibilityMatrixItemDTO, IResponsibilityMatrixItem, Guid> a)
		{
			a.Ignore();
		});
		map.AfterMap((Action<ResponsibilityMatrixItemDTO, IResponsibilityMatrixItem>)MapWorker);
	}

	protected void MapWorker(ResponsibilityMatrixItemDTO dto, IResponsibilityMatrixItem item)
	{
		int num = 1;
		int num2 = num;
		IBPMNProcess iBPMNProcess = default(IBPMNProcess);
		while (true)
		{
			switch (num2)
			{
			case 5:
				return;
			case 6:
				iBPMNProcess = WorkflowProcessManager.GetManager<IBPMNProcess>().LoadOrNull(dto.BPMNProcessId);
				num2 = 4;
				continue;
			case 4:
				GdFnaPO7q4StuvMyH5b3(item, iBPMNProcess);
				num2 = 3;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_764abb15e52f4036a7a81fce6cb70f30 != 0)
				{
					num2 = 2;
				}
				continue;
			case 1:
				if (dto == null)
				{
					return;
				}
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1b8b735647da470aa2d45d64d6f538d1 != 0)
				{
					num2 = 0;
				}
				continue;
			case 3:
				return;
			case 2:
				item.WorkerType = UqCRfWO76cbgeM8Yibrb(b6LWS1O7jiTp3LBiJhV5(dto));
				num2 = 6;
				continue;
			}
			if (item == null)
			{
				num2 = 5;
				continue;
			}
			item.WorkerId = G44KAoO7ROrrmA2nmMoo(b6LWS1O7jiTp3LBiJhV5(dto));
			num2 = 2;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_558b46b4f4364838b08ac89d77f9a257 == 0)
			{
				num2 = 2;
			}
		}
	}

	protected Worker MapWorkerToDTO(IResponsibilityMatrixItem item)
	{
		Worker worker = new Worker();
		aJqNZYO7T0hpO5ATi1Nm(worker, CtOW1VO73nFPgtlAiuaY(item));
		mZ9BZlO7QexfnKuN2TTL(worker, item.WorkerId.HasValue ? item.WorkerId.Value : 0);
		return worker;
	}

	public ResponsibilityMatrixItemMap()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bb19f93c0a774f6cbdada859bba83212 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object b6LWS1O7jiTp3LBiJhV5(object P_0)
	{
		return ((ResponsibilityMatrixItemDTO)P_0).Worker;
	}

	internal static long G44KAoO7ROrrmA2nmMoo(object P_0)
	{
		return ((Worker)P_0).WorkerId;
	}

	internal static Guid UqCRfWO76cbgeM8Yibrb(object P_0)
	{
		return ((Worker)P_0).WorkerType;
	}

	internal static void GdFnaPO7q4StuvMyH5b3(object P_0, object P_1)
	{
		((IResponsibilityMatrixItem)P_0).BPMNProcess = (IBPMNProcess)P_1;
	}

	internal static bool W3bwEQO79NYGEX0LSYY1()
	{
		return rE5r2BO7fKb6XkBLAY5L == null;
	}

	internal static ResponsibilityMatrixItemMap nbLW0gO7WUQ6wmWb0EtF()
	{
		return rE5r2BO7fKb6XkBLAY5L;
	}

	internal static Guid CtOW1VO73nFPgtlAiuaY(object P_0)
	{
		return ((IResponsibilityMatrixItem)P_0).WorkerType;
	}

	internal static void aJqNZYO7T0hpO5ATi1Nm(object P_0, Guid P_1)
	{
		((Worker)P_0).WorkerType = P_1;
	}

	internal static void mZ9BZlO7QexfnKuN2TTL(object P_0, long P_1)
	{
		((Worker)P_0).WorkerId = P_1;
	}
}
