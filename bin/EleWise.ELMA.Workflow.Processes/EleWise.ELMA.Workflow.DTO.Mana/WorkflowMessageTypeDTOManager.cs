using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using AutoMapper;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Workflow.DTO.Models;
using EleWise.ELMA.Workflow.Managers;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.DTO.Managers;

public class WorkflowMessageTypeDTOManager : DTOManager, IWorkflowMessageTypeDTOManager, IConfigurationService
{
	internal static WorkflowMessageTypeDTOManager JQYhTWPpGDOHCJjTHFp;

	public ProcessHeaderManager ProcessHeaderManager
	{
		[CompilerGenerated]
		get
		{
			return _003CProcessHeaderManager_003Ek__BackingField;
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
				case 0:
					return;
				case 1:
					_003CProcessHeaderManager_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_7b098b7bc47e4d38a5b2691cab1a4e36 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public WorkflowMessageTypeManager WorkflowMessageTypeManager
	{
		[CompilerGenerated]
		get
		{
			return _003CWorkflowMessageTypeManager_003Ek__BackingField;
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
				case 0:
					return;
				case 1:
					_003CWorkflowMessageTypeManager_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_76260b548c684c6c95eb679c837b8945 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public WorkflowProcessManager WorkflowProcessManager
	{
		[CompilerGenerated]
		get
		{
			return _003CWorkflowProcessManager_003Ek__BackingField;
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
					_003CWorkflowProcessManager_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_4db1e829bcb046ad87c01fa1925cdfce != 0)
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

	public virtual WorkflowMessageTypeDTO LoadOrNull(long id)
	{
		return Mapper.Map<IWorkflowMessageType, WorkflowMessageTypeDTO>(EntityManager<IWorkflowMessageType>.Instance.LoadOrNull(id));
	}

	public virtual List<WorkflowMessageTypeDTO> LoadAll(bool includeDeleted = false)
	{
		IEntityManager<IWorkflowMessageType> instance = EntityManager<IWorkflowMessageType>.Instance;
		Filter filter = new Filter();
		if (includeDeleted)
		{
			filter.DisableSoftDeletable = true;
		}
		return (from mt in instance.Find(filter, FetchOptions.All)
			select Mapper.Map<IWorkflowMessageType, WorkflowMessageTypeDTO>(mt)).ToList();
	}

	public virtual WorkflowMessageTypeDTO Save(WorkflowMessageTypeDTO dto)
	{
		int num = 3;
		int num2 = num;
		_003C_003Ec__DisplayClass14_0 _003C_003Ec__DisplayClass14_ = default(_003C_003Ec__DisplayClass14_0);
		while (true)
		{
			switch (num2)
			{
			case 4:
				return Mapper.Map<IWorkflowMessageType, WorkflowMessageTypeDTO>(_003C_003Ec__DisplayClass14_.mt);
			case 1:
				throw new ArgumentException(SR.T((string)dPWXPSPOBprNA6VyxQk(-282877824 ^ -282866290), _003C_003Ec__DisplayClass14_.mt.Name));
			case 2:
				_003C_003Ec__DisplayClass14_.mt = Mapper.Map<WorkflowMessageTypeDTO, IWorkflowMessageType>(dto);
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_71034f51e0444c3592d323fffec09e96 == 0)
				{
					num2 = 0;
				}
				continue;
			case 3:
				_003C_003Ec__DisplayClass14_ = new _003C_003Ec__DisplayClass14_0();
				num2 = 2;
				continue;
			}
			IEntityManager<IWorkflowMessageType> instance = EntityManager<IWorkflowMessageType>.Instance;
			ParameterExpression parameterExpression = (ParameterExpression)R1KRhoP6Iydr8A523Oj(efrejFPyFm2e7xerdfq(typeof(IWorkflowMessageType).TypeHandle), dPWXPSPOBprNA6VyxQk(0x20C96B1E ^ 0x20C90616));
			if (!instance.Find(Expression.Lambda<Func<IWorkflowMessageType, bool>>((Expression)O5vPlTPlG8v6ckJO4t9(ubW7jmPeVpJZYvunNDH(BHRonZP0T8QqkQZTU1y(parameterExpression, (MethodInfo)V8JE1gPRblEVSshtLpa((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), BHRonZP0T8QqkQZTU1y(NG6xVfPHq1aqEdMfBMo(vQLHX9PBarPrI2CKJR2(_003C_003Ec__DisplayClass14_, typeof(_003C_003Ec__DisplayClass14_0)), fL5PUoPWKnJX5R15MWC((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/)), (MethodInfo)V8JE1gPRblEVSshtLpa((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/))), PpfSBsPu6OCaWxGAxQH(BHRonZP0T8QqkQZTU1y(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, typeof(IEntity<long>).TypeHandle)), BHRonZP0T8QqkQZTU1y(NG6xVfPHq1aqEdMfBMo(vQLHX9PBarPrI2CKJR2(_003C_003Ec__DisplayClass14_, efrejFPyFm2e7xerdfq(typeof(_003C_003Ec__DisplayClass14_0).TypeHandle)), fL5PUoPWKnJX5R15MWC((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/)), (MethodInfo)cyAoAgPiVdMnN0m58Xi((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, typeof(IEntity<long>).TypeHandle)))), new ParameterExpression[1] { parameterExpression })).Any())
			{
				_003C_003Ec__DisplayClass14_.mt.Save();
				num2 = 4;
				continue;
			}
			num2 = 1;
			if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_feeb07d467ad474ea937eb4a7eec98da != 0)
			{
				num2 = 0;
			}
		}
	}

	public virtual void Delete(long id)
	{
		int num = 2;
		int num2 = num;
		IWorkflowMessageType workflowMessageType = default(IWorkflowMessageType);
		while (true)
		{
			switch (num2)
			{
			case 3:
				return;
			case 1:
				if (workflowMessageType == null)
				{
					return;
				}
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_48279d3d45e2437b9907d478ce5a47b1 != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				workflowMessageType = EntityManager<IWorkflowMessageType>.Instance.LoadOrNull(id);
				num2 = 1;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_f679e84d83df40c6973457c358e7e4e4 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				e932U8Pf9fmmsovIyf7(workflowMessageType);
				num2 = 3;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_98890646a18d4a91b352a4ea5d1be319 == 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	public virtual void Restore(long id)
	{
		int num = 2;
		int num2 = num;
		_003C_003Ec__DisplayClass16_0 _003C_003Ec__DisplayClass16_ = default(_003C_003Ec__DisplayClass16_0);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
				_003C_003Ec__DisplayClass16_ = new _003C_003Ec__DisplayClass16_0();
				num2 = 1;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_48279d3d45e2437b9907d478ce5a47b1 == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				_003C_003Ec__DisplayClass16_.id = id;
				num2 = 3;
				break;
			case 3:
			{
				IEntityManager<IWorkflowMessageType> instance = EntityManager<IWorkflowMessageType>.Instance;
				ParameterExpression parameterExpression = (ParameterExpression)R1KRhoP6Iydr8A523Oj(efrejFPyFm2e7xerdfq(typeof(IWorkflowMessageType).TypeHandle), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-133069941 ^ -133042557));
				IWorkflowMessageType workflowMessageType = instance.Find(Expression.Lambda<Func<IWorkflowMessageType, bool>>((Expression)ubW7jmPeVpJZYvunNDH(Expression.Property(parameterExpression, (MethodInfo)cyAoAgPiVdMnN0m58Xi((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, typeof(IEntity<long>).TypeHandle)), NG6xVfPHq1aqEdMfBMo(vQLHX9PBarPrI2CKJR2(_003C_003Ec__DisplayClass16_, efrejFPyFm2e7xerdfq(typeof(_003C_003Ec__DisplayClass16_0).TypeHandle)), fL5PUoPWKnJX5R15MWC((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/))), new ParameterExpression[1] { parameterExpression })).FirstOrDefault();
				workflowMessageType.IsDeleted = false;
				g8Bv3ePLTmW28dmHIIM(workflowMessageType);
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_fc30864faaad488ba50da4607dce40b9 == 0)
				{
					num2 = 0;
				}
				break;
			}
			case 0:
				return;
			}
		}
	}

	public virtual List<WorkflowHistoryItemDTO> SearchOccurrencesInProcesses(long msgTypeId, bool inPublished, bool inDrafts, bool inOld)
	{
		List<long> list = WorkflowMessageTypeManager.Search(msgTypeId, inPublished, inDrafts, inOld);
		return (from mt in WorkflowProcessManager.LoadHistoryByProcessIdArray(list.ToArray())
			select Mapper.Map<WorkflowProcessHistoryItem, WorkflowHistoryItemDTO>(mt)).ToList();
	}

	public virtual int CountOccurrencesInProcesses(long msgTypeId, bool inPublished, bool inDrafts, bool inOld)
	{
		return WorkflowMessageTypeManager.Search(msgTypeId, inPublished, inDrafts, inOld).Count();
	}

	public WorkflowMessageTypeDTOManager()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		lmXBLqPJNWLgFVqNLkF();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_67c4b8cf6de246108f53fc3d72e6757a == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool GHa6AEPGuTA4oZM0JJF()
	{
		return JQYhTWPpGDOHCJjTHFp == null;
	}

	internal static WorkflowMessageTypeDTOManager XBgE1TPnWuwMWqKSsrH()
	{
		return JQYhTWPpGDOHCJjTHFp;
	}

	internal static Type efrejFPyFm2e7xerdfq(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object dPWXPSPOBprNA6VyxQk(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object R1KRhoP6Iydr8A523Oj(Type P_0, object P_1)
	{
		return Expression.Parameter(P_0, (string)P_1);
	}

	internal static object V8JE1gPRblEVSshtLpa(RuntimeMethodHandle P_0)
	{
		return MethodBase.GetMethodFromHandle(P_0);
	}

	internal static object BHRonZP0T8QqkQZTU1y(object P_0, object P_1)
	{
		return Expression.Property((Expression)P_0, (MethodInfo)P_1);
	}

	internal static object vQLHX9PBarPrI2CKJR2(object P_0, Type P_1)
	{
		return Expression.Constant(P_0, P_1);
	}

	internal static object fL5PUoPWKnJX5R15MWC(RuntimeFieldHandle P_0)
	{
		return FieldInfo.GetFieldFromHandle(P_0);
	}

	internal static object NG6xVfPHq1aqEdMfBMo(object P_0, object P_1)
	{
		return Expression.Field((Expression)P_0, (FieldInfo)P_1);
	}

	internal static object ubW7jmPeVpJZYvunNDH(object P_0, object P_1)
	{
		return Expression.Equal((Expression)P_0, (Expression)P_1);
	}

	internal static object cyAoAgPiVdMnN0m58Xi(RuntimeMethodHandle P_0, RuntimeTypeHandle P_1)
	{
		return MethodBase.GetMethodFromHandle(P_0, P_1);
	}

	internal static object PpfSBsPu6OCaWxGAxQH(object P_0, object P_1)
	{
		return Expression.NotEqual((Expression)P_0, (Expression)P_1);
	}

	internal static object O5vPlTPlG8v6ckJO4t9(object P_0, object P_1)
	{
		return Expression.AndAlso((Expression)P_0, (Expression)P_1);
	}

	internal static void e932U8Pf9fmmsovIyf7(object P_0)
	{
		((IEntity)P_0).Delete();
	}

	internal static void g8Bv3ePLTmW28dmHIIM(object P_0)
	{
		((IEntity)P_0).Save();
	}

	internal static void lmXBLqPJNWLgFVqNLkF()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.reZueBLff7();
	}
}
