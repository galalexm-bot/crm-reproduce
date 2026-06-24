using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events.Audit;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Notifications.Impl;

[Component(Type = ComponentType.WebServer)]
public class EventNotificationProvider : IAuditEventProviderAsync, IAuditEventProvider
{
	internal static EventNotificationProvider wkpO9xtkoI6sdYo5Qrp;

	public INotificationManager NotificationManager
	{
		[CompilerGenerated]
		get
		{
			return _003CNotificationManager_003Ek__BackingField;
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
					_003CNotificationManager_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public virtual void Notify(string eventName, IAuditEventArgs e)
	{
		//Discarded unreachable code: IL_0041, IL_0050, IL_008f, IL_009e
		int num = 2;
		EventNotification eventNotification = default(EventNotification);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 3:
					return;
				case 7:
					if (!(e is AuditableEventArgs))
					{
						num2 = 5;
						continue;
					}
					return;
				case 1:
					if (eventName == EntityActionNotificationUnitOfWorkListener.EntityActionHandlerEventName)
					{
						num2 = 3;
						continue;
					}
					goto case 7;
				case 2:
					sjDcZEteiNfZS0pF2Gu(NotificationManager, Paq4e9t2xubpMWNxMDk(0xE1229CF ^ 0xE12A1E1));
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
					{
						num2 = 0;
					}
					continue;
				case 0:
					return;
				case 5:
					eventNotification = new EventNotification(eventName, e);
					num2 = 6;
					continue;
				case 4:
					return;
				case 6:
					break;
				}
				break;
			}
			QW6W0vtPqR7uS8sTM4I(NotificationManager, eventNotification);
			num = 4;
		}
	}

	public Task NotifyAsync(string eventName, IAuditEventArgs e, CancellationToken cancellationToken = default(CancellationToken))
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return (Task)EdRKiFtNXhybWoqwbNU();
			case 1:
				cX4bust17Y1qHyyALS4(this, eventName, e);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public EventNotificationProvider()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		KabbNvt3hyxeh327QMU();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool DfcUtEtngaB9RK8eSyK()
	{
		return wkpO9xtkoI6sdYo5Qrp == null;
	}

	internal static EventNotificationProvider B1fyqRtOIQYNhG7h5L3()
	{
		return wkpO9xtkoI6sdYo5Qrp;
	}

	internal static object Paq4e9t2xubpMWNxMDk(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void sjDcZEteiNfZS0pF2Gu(object P_0, object P_1)
	{
		Contract.ServiceNotNull(P_0, (string)P_1);
	}

	internal static void QW6W0vtPqR7uS8sTM4I(object P_0, object P_1)
	{
		((INotificationManager)P_0).Send((INotification)P_1);
	}

	internal static void cX4bust17Y1qHyyALS4(object P_0, object P_1, object P_2)
	{
		((EventNotificationProvider)P_0).Notify((string)P_1, (IAuditEventArgs)P_2);
	}

	internal static object EdRKiFtNXhybWoqwbNU()
	{
		return Task.CompletedTask;
	}

	internal static void KabbNvt3hyxeh327QMU()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
