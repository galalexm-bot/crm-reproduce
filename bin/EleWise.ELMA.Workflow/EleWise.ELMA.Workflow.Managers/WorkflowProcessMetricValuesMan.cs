using System;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Managers;

public class WorkflowProcessMetricValuesManager<T> : WorkflowBaseManager<T> where T : WorkflowProcessMetricValues
{
	private static object etUEFm9kKo86khKeHqu;

	public WorkflowInstanceContextService WorkflowInstanceContextService
	{
		[CompilerGenerated]
		get
		{
			return _003CWorkflowInstanceContextService_003Ek__BackingField;
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
					_003CWorkflowInstanceContextService_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0262725a60774e44a84fd2b93b79ee8a == 0)
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

	public override void Save(T obj)
	{
		Entity<long> entity = null;
		foreach (Entity<long> compositeEntity in obj.GetCompositeEntities())
		{
			if (entity == null)
			{
				entity = compositeEntity;
			}
			else if (compositeEntity.Id <= 0 && entity != null)
			{
				compositeEntity.Id = entity.Id;
			}
			GetPartialManager(compositeEntity).Save(compositeEntity);
		}
	}

	public override T LoadOrNull(long id)
	{
		Contract.ServiceNotNull(WorkflowInstanceContextService, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4940763B ^ 0x49401A83));
		return (T)WorkflowInstanceContextService.LoadWorkflowProcessMetricValues(typeof(T), id);
	}

	public WorkflowProcessMetricValuesManager()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5c45a6e5a4614bfba7591d8a1c7ced1d != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool QaB4899Uy5SFUjr7U4o()
	{
		return etUEFm9kKo86khKeHqu == null;
	}

	internal static object aCe6679V7BtnX2uwd5m()
	{
		return etUEFm9kKo86khKeHqu;
	}
}
public class WorkflowProcessMetricValuesManagerMaker : IManagerMaker
{
	internal static WorkflowProcessMetricValuesManagerMaker x3HSbl9AbqObA3fCsus;

	public Type MakeManager(Type objectType)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				Ig4U8O92xAsvZGmNhq6(objectType, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x56F860D7 ^ 0x56F8C315));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3b4403f77a00495e957e5e4a6840e5d3 != 0)
				{
					num2 = 0;
				}
				break;
			default:
				return F9tN429oEJMqM1o95TX(typeof(WorkflowProcessMetricValuesManager<>).TypeHandle).MakeGenericType(objectType);
			}
		}
	}

	public WorkflowProcessMetricValuesManagerMaker()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		hccKk09F441yp87ZcBY();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_58fb165cafed422d973d4a7156526541 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static void Ig4U8O92xAsvZGmNhq6(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static Type F9tN429oEJMqM1o95TX(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static bool uDR1pJ9GfNSfRIxZQtu()
	{
		return x3HSbl9AbqObA3fCsus == null;
	}

	internal static WorkflowProcessMetricValuesManagerMaker NxE6Lo978RiJB9Rknd4()
	{
		return x3HSbl9AbqObA3fCsus;
	}

	internal static void hccKk09F441yp87ZcBY()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}
}
