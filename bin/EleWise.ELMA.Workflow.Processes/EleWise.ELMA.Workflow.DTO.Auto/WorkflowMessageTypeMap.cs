using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using AutoMapper;
using EleWise.ELMA.Model.AutoMaps;
using EleWise.ELMA.Workflow.DTO.Models;
using EleWise.ELMA.Workflow.Models;
using Iesi.Collections.Generic;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.DTO.AutoMaps;

public class WorkflowMessageTypeMap : EntityDTOMap<IWorkflowMessageType, WorkflowMessageTypeDTO>
{
	internal static WorkflowMessageTypeMap k7cOqE4PNQLwrcH5Wym;

	protected override void InitMap(IMappingExpression<IWorkflowMessageType, WorkflowMessageTypeDTO> map)
	{
		base.InitMap(map);
		ParameterExpression parameterExpression = Expression.Parameter(typeof(WorkflowMessageTypeDTO), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4CBDA8D5 ^ 0x4CBDC54B));
		map.ForMember<List<WorkflowMessageTypeParameterDTO>>(Expression.Lambda<Func<WorkflowMessageTypeDTO, List<WorkflowMessageTypeParameterDTO>>>(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }), (Action<IMemberConfigurationExpression<IWorkflowMessageType, WorkflowMessageTypeDTO, List<WorkflowMessageTypeParameterDTO>>>)delegate(IMemberConfigurationExpression<IWorkflowMessageType, WorkflowMessageTypeDTO, List<WorkflowMessageTypeParameterDTO>> a)
		{
			ParameterExpression parameterExpression2 = Expression.Parameter(typeof(IWorkflowMessageType), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-802458460 ^ -802481892));
			MethodInfo method = (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/);
			Expression[] array = new Expression[1];
			MethodInfo method2 = (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/);
			Expression[] obj = new Expression[2]
			{
				Expression.Property(parameterExpression2, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)),
				null
			};
			ParameterExpression parameterExpression3 = Expression.Parameter(typeof(IWorkflowMessageTypeParameter), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x48FD6D2E ^ 0x48FD5D34));
			obj[1] = Expression.Lambda<Func<IWorkflowMessageTypeParameter, WorkflowMessageTypeParameterDTO>>(Expression.Call(null, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/), parameterExpression3), new ParameterExpression[1] { parameterExpression3 });
			array[0] = Expression.Call(null, method2, obj);
			a.MapFrom<List<WorkflowMessageTypeParameterDTO>>(Expression.Lambda<Func<IWorkflowMessageType, List<WorkflowMessageTypeParameterDTO>>>(Expression.Call(null, method, array), new ParameterExpression[1] { parameterExpression2 }));
		});
	}

	protected override void InitReverseMap(IMappingExpression<WorkflowMessageTypeDTO, IWorkflowMessageType> map)
	{
		base.InitReverseMap(map);
		ParameterExpression parameterExpression = Expression.Parameter(typeof(IWorkflowMessageType), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-680549150 ^ -680539814));
		map.ForMember<ISet<IWorkflowMessageTypeParameter>>(Expression.Lambda<Func<IWorkflowMessageType, ISet<IWorkflowMessageTypeParameter>>>(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }), (Action<IMemberConfigurationExpression<WorkflowMessageTypeDTO, IWorkflowMessageType, ISet<IWorkflowMessageTypeParameter>>>)delegate(IMemberConfigurationExpression<WorkflowMessageTypeDTO, IWorkflowMessageType, ISet<IWorkflowMessageTypeParameter>> o)
		{
			o.Ignore();
		});
		map.AfterMap((Action<WorkflowMessageTypeDTO, IWorkflowMessageType>)delegate(WorkflowMessageTypeDTO dto, IWorkflowMessageType mt)
		{
			int num = 5;
			int num2 = num;
			_003C_003Ec__DisplayClass1_0 _003C_003Ec__DisplayClass1_ = default(_003C_003Ec__DisplayClass1_0);
			while (true)
			{
				switch (num2)
				{
				case 1:
					_003C_003Ec__DisplayClass1_.mt.Parameters.AddAll((ICollection<IWorkflowMessageTypeParameter>)_003C_003Ec__DisplayClass1_.currentParams.Where(_003C_003Ec__DisplayClass1_._003CInitReverseMap_003Eb__5).ToList());
					num2 = 3;
					break;
				case 4:
					_003C_003Ec__DisplayClass1_.mt = mt;
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_7f79a06dec5f490c93fd11725200b9b3 != 0)
					{
						num2 = 0;
					}
					break;
				case 5:
					_003C_003Ec__DisplayClass1_ = new _003C_003Ec__DisplayClass1_0();
					num2 = 4;
					break;
				case 2:
					_003C_003Ec__DisplayClass1_.mt.Parameters.RemoveAll((ICollection<IWorkflowMessageTypeParameter>)((IEnumerable<IWorkflowMessageTypeParameter>)_003C_003Ec__DisplayClass1_.mt.Parameters).Where(_003C_003Ec__DisplayClass1_._003CInitReverseMap_003Eb__4).ToList());
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_7ff589a2577e4ae68ceb125a419ed974 != 0)
					{
						num2 = 1;
					}
					break;
				case 3:
					return;
				default:
					_003C_003Ec__DisplayClass1_.currentParams = dto.Parameters.Select((WorkflowMessageTypeParameterDTO paramDto) => Mapper.Map<WorkflowMessageTypeParameterDTO, IWorkflowMessageTypeParameter>(paramDto));
					num2 = 2;
					break;
				}
			}
		});
	}

	public WorkflowMessageTypeMap()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		qm1PB74TaMmy45KBfsB();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_2f22e6eeec1e40a4b9dae10f79ea3ae0 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static void qm1PB74TaMmy45KBfsB()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.reZueBLff7();
	}

	internal static bool HOamEa44RCZu5YraaAO()
	{
		return k7cOqE4PNQLwrcH5Wym == null;
	}

	internal static WorkflowMessageTypeMap nEPnXt49vaXW2fES3ZH()
	{
		return k7cOqE4PNQLwrcH5Wym;
	}
}
