using System.Runtime.CompilerServices;
using EleWise.ELMA.Cache;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Runtime.NH.Listeners;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Workflow.Constants;
using j3AmrhgkCleVTGdEwA;
using NHibernate.Event;

namespace EleWise.ELMA.Workflow.Listeners;

[Component]
internal class SaveUserOrganizationListener : EntityEventsListener
{
	private static SaveUserOrganizationListener rB41gpqzUuWBpdZMCtQ;

	public ICacheService CacheService
	{
		[CompilerGenerated]
		get
		{
			return _003CCacheService_003Ek__BackingField;
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
					_003CCacheService_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_75a2d0f780b04098ba855df5729e6c30 == 0)
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

	public override void OnPostUpdate(PostUpdateEvent @event)
	{
		//Discarded unreachable code: IL_003a, IL_0049, IL_00bd, IL_00cc
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
			case 4:
				return;
			case 1:
			case 5:
				Clear();
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f8ecc99a1f4a4b6abc73e9b50261ea83 != 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				if (!(epyflm3ZZ8GHFtqrPCR(@event) is IUserGroup))
				{
					num2 = 4;
					break;
				}
				goto case 1;
			case 2:
				if (((AbstractPostDatabaseOperationEvent)@event).get_Entity() is IOrganizationItem)
				{
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a23e27b648a042f098a477c26c4beed1 == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 3;
			}
		}
	}

	public override void OnPostInsert(PostInsertEvent @event)
	{
		//Discarded unreachable code: IL_0063, IL_0072, IL_0082
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (epyflm3ZZ8GHFtqrPCR(@event) is IOrganizationItem)
				{
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_db8eb3e90ad546d4b05544ab6326a49f == 0)
					{
						num2 = 0;
					}
					continue;
				}
				goto case 2;
			case 3:
				return;
			case 2:
				if (!(epyflm3ZZ8GHFtqrPCR(@event) is IUserGroup))
				{
					num2 = 3;
					continue;
				}
				break;
			case 4:
				return;
			}
			Clear();
			num2 = 4;
		}
	}

	public override void OnPostDelete(PostDeleteEvent @event)
	{
		//Discarded unreachable code: IL_0063, IL_0072, IL_00ad
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
			case 2:
				Clear();
				num2 = 4;
				break;
			case 3:
				if (epyflm3ZZ8GHFtqrPCR(@event) is IOrganizationItem)
				{
					num2 = 2;
					break;
				}
				goto case 5;
			case 0:
				return;
			case 5:
				if (!(epyflm3ZZ8GHFtqrPCR(@event) is GroupPermission))
				{
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e8980a9fd9d44c20920ffa276900c96f != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 1;
			case 4:
				return;
			}
		}
	}

	private void Clear()
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
				nHy9oM3vWhs0koWO58B(CacheService, ObjectStartableByRouteConstant.Region);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f19dffab164a41148300de28b2deec39 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public SaveUserOrganizationListener()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		QepyBI3YgHmPmFy8pkh();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_805f3361d2ba4dac8da4174f89314253 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool YK5mYI3Kmtjkdj8Z8vA()
	{
		return rB41gpqzUuWBpdZMCtQ == null;
	}

	internal static SaveUserOrganizationListener OL3dxa3OkBTr3bQQJUJ()
	{
		return rB41gpqzUuWBpdZMCtQ;
	}

	internal static object epyflm3ZZ8GHFtqrPCR(object P_0)
	{
		return ((AbstractPostDatabaseOperationEvent)P_0).get_Entity();
	}

	internal static void nHy9oM3vWhs0koWO58B(object P_0, object P_1)
	{
		((ICacheService)P_0).ClearRegion((string)P_1);
	}

	internal static void QepyBI3YgHmPmFy8pkh()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}
}
