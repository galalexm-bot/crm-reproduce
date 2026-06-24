using EleWise.ELMA.Cache;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Runtime.NH.Listeners;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Services;
using EleWise.ELMA.Workflow.BPMN.Models;
using EleWise.ELMA.Workflow.Managers;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;
using NHibernate.Event;

namespace EleWise.ELMA.Workflow.Listeners;

[Component]
public class MonitorProcessesAllInfoListener : EntityEventsListener
{
	private static MonitorProcessesAllInfoListener j2IGgLjrlrsSpMD0D5a;

	public override bool OnPreInsert(PreInsertEvent @event)
	{
		//Discarded unreachable code: IL_0064, IL_0073
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (!IsNeedReset(((AbstractPreDatabaseOperationEvent)@event).get_Entity()))
				{
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1c37d4e24e094858975336738e156495 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			case 1:
			case 3:
				return UmkCE0jx12sukpESTBy(this, @event);
			}
			ResetInfoCache();
			num2 = 3;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a680afde07ce4ae5b71c411a1f75109b == 0)
			{
				num2 = 2;
			}
		}
	}

	public override bool OnPreUpdate(PreUpdateEvent @event)
	{
		//Discarded unreachable code: IL_0084, IL_0093
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (!IsNeedReset(NsoXaojSc8vNbJCs0hT(@event)))
				{
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c447ffb64be44c09b6fd398df506785b != 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 3;
			case 3:
				ResetInfoCache();
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_75a2d0f780b04098ba855df5729e6c30 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				return base.OnPreUpdate(@event);
			}
		}
	}

	public override bool OnPreDelete(PreDeleteEvent @event)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return zlC4I2j1VjQ4pB9OaNU(this, @event);
			case 1:
				if (IsNeedReset(NsoXaojSc8vNbJCs0hT(@event)))
				{
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_90dfe18b3d784ead92a1e4e4e2547482 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			default:
				ResetInfoCache();
				num2 = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e632863bfb124ba083e3ba9b363fd70e == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public override void OnPreUpdateCollection(PreCollectionUpdateEvent @event)
	{
		//Discarded unreachable code: IL_0091, IL_00a0
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 3:
				ResetInfoCache();
				num2 = 4;
				break;
			case 1:
			case 4:
				base.OnPreUpdateCollection(@event);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d087ae72a2134de08266411226c5f060 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				if (!IsNeedReset(iVuuUXjhqibRZbeu5gE(@event)))
				{
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d2d2252621ae43ad8d38af812176c290 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 3;
			case 0:
				return;
			}
		}
	}

	private bool IsNeedReset(object obj)
	{
		//Discarded unreachable code: IL_0045, IL_0054
		int num = 6;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 6:
				if (obj == null)
				{
					num2 = 5;
					break;
				}
				if (!(obj is IProcessHeader))
				{
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8f870ea690334e7ab7599d275d195e9a != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 1;
			default:
				if (obj is IResponsibilityMatrixItem)
				{
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_160bffb148c14c5da92d8d6ddf481bdc != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 8;
			case 2:
				return obj is IUser;
			case 1:
			case 3:
				return true;
			case 8:
				if (!(obj is IOrganizationItem))
				{
					num2 = 7;
					break;
				}
				goto case 1;
			case 5:
				return false;
			case 7:
				if (obj is IUserGroup)
				{
					num2 = 3;
					break;
				}
				goto case 4;
			case 4:
				if (!(obj is IProcessHeaderPermission))
				{
					num2 = 2;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bae2bde9e5844c638021cdb56fc01122 == 0)
					{
						num2 = 2;
					}
					break;
				}
				goto case 1;
			}
		}
	}

	private void ResetInfoCache()
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
				I4gRP4jEAQvuv4XEc6L(Locator.GetServiceNotNull<IComplexCacheService>(), ProcessHeaderManager.GetProcessMonitorAllHeaderInfoTimeStamp);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7d23dbc0284240b99ff34f0f55f345f6 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public MonitorProcessesAllInfoListener()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		U0d1o9jw77i3hVqhoOl();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cb262bcfe4074a1ab16e653815d57f28 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool UmkCE0jx12sukpESTBy(object P_0, object P_1)
	{
		return ((EntityEventsListener)P_0).OnPreInsert((PreInsertEvent)P_1);
	}

	internal static bool xudBRxjeBVWCvqIIs3I()
	{
		return j2IGgLjrlrsSpMD0D5a == null;
	}

	internal static MonitorProcessesAllInfoListener hePLxLjN1lbCImAdg2u()
	{
		return j2IGgLjrlrsSpMD0D5a;
	}

	internal static object NsoXaojSc8vNbJCs0hT(object P_0)
	{
		return ((AbstractPreDatabaseOperationEvent)P_0).get_Entity();
	}

	internal static bool zlC4I2j1VjQ4pB9OaNU(object P_0, object P_1)
	{
		return ((EntityEventsListener)P_0).OnPreDelete((PreDeleteEvent)P_1);
	}

	internal static object iVuuUXjhqibRZbeu5gE(object P_0)
	{
		return ((AbstractCollectionEvent)P_0).get_AffectedOwnerOrNull();
	}

	internal static void I4gRP4jEAQvuv4XEc6L(object P_0, object P_1)
	{
		((IComplexCacheService)P_0).RefreshTimestamp((string)P_1);
	}

	internal static void U0d1o9jw77i3hVqhoOl()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}
}
