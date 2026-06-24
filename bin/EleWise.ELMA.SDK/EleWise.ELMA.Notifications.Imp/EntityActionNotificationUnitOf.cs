using System;
using System.Reflection;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events.Audit.Impl;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Notifications.Impl;

[Component(Order = 1000010, Type = ComponentType.WebServer)]
internal class EntityActionNotificationUnitOfWorkListener : BaseEntityActionUnitOfWorkListener
{
	internal static readonly string EntityActionHandlerEventName;

	private readonly INotificationManager notificationManager;

	internal static EntityActionNotificationUnitOfWorkListener NnoymkDVDKcfyydIhWe;

	protected override string EventListContextKey => (string)kNuT8NDq00VrDbfnV9K(-740338220 ^ -740306690);

	public EntityActionNotificationUnitOfWorkListener([NotNull] IContextBoundVariableService contextBoundVariableService, [NotNull] ISessionProvider sessionProvider, [NotNull] ILogger logger, [NotNull] INotificationManager notificationManager)
	{
		//Discarded unreachable code: IL_0021, IL_0082
		Qudx3yDRcC4S16KFj67();
		base._002Ector(contextBoundVariableService, sessionProvider, logger);
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
				throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x35C0467B ^ 0x35C0C3B9));
			case 1:
				this.notificationManager = notificationManager;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			case 3:
				if (notificationManager != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 != 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 2;
			}
		}
	}

	protected override void PersistEvent(EntityActionEventArgs e)
	{
		int num = 2;
		int num2 = num;
		EventNotification eventNotification = default(EventNotification);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				gYqSU1DKFOltYCncJG5(notificationManager, eventNotification);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				eventNotification = new EventNotification(EntityActionHandlerEventName, e);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	static EntityActionNotificationUnitOfWorkListener()
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
			case 2:
				Qudx3yDRcC4S16KFj67();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				EntityActionHandlerEventName = (string)HGhKetDTnZVaaVchaG6(JlKrDrDXWgGB5nAnkvx(typeof(IEntityActionHandler)), kNuT8NDq00VrDbfnV9K(-97972138 ^ -97937990));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static void Qudx3yDRcC4S16KFj67()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool fKTQy9DSdRSH63xl6fJ()
	{
		return NnoymkDVDKcfyydIhWe == null;
	}

	internal static EntityActionNotificationUnitOfWorkListener xWVmymDiiuQXqesg8kt()
	{
		return NnoymkDVDKcfyydIhWe;
	}

	internal static object kNuT8NDq00VrDbfnV9K(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void gYqSU1DKFOltYCncJG5(object P_0, object P_1)
	{
		((INotificationManager)P_0).Send((INotification)P_1);
	}

	internal static object JlKrDrDXWgGB5nAnkvx(object P_0)
	{
		return ((MemberInfo)P_0).Name;
	}

	internal static object HGhKetDTnZVaaVchaG6(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}
}
