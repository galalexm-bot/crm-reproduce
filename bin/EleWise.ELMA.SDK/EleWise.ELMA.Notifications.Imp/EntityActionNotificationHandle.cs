using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events.Audit.Impl;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Notifications.Impl;

[Component(Type = ComponentType.WebServer)]
internal class EntityActionNotificationHandler : BaseEntityActionHandler
{
	public const string EventListContextKeyConst = "EleWise.ELMA.Notifications.Impl.EntityActionNotificationHandler.EventsList";

	private static EntityActionNotificationHandler DVBOoHD8xmxFHbmdX9T;

	protected override string EventListContextKey => z2jc63fLkugS1X8Q9N.tE1kD1vbB(-35995181 ^ -36027143);

	public EntityActionNotificationHandler([NotNull] IContextBoundVariableService contextBoundVariableService, [NotNull] IUnitOfWorkManager unitOfWorkManager)
	{
		//Discarded unreachable code: IL_002c, IL_0031
		X4FOMEDIeTCjE1IaklI();
		base._002Ector(contextBoundVariableService, unitOfWorkManager);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	protected override bool NeedPersistEvent(EntityActionEventArgs e)
	{
		//Discarded unreachable code: IL_0052, IL_0061
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (e.Object != null)
				{
					num2 = 3;
					break;
				}
				goto default;
			case 3:
				return e.Action != null;
			default:
				return false;
			case 1:
				if (e == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			}
		}
	}

	internal static void X4FOMEDIeTCjE1IaklI()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool nH3yVBDZqcsNWP8U1Ij()
	{
		return DVBOoHD8xmxFHbmdX9T == null;
	}

	internal static EntityActionNotificationHandler GID5imDu0Yp15ZfDS2Z()
	{
		return DVBOoHD8xmxFHbmdX9T;
	}
}
