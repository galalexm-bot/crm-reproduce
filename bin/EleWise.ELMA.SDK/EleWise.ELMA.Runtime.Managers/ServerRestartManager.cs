using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Runtime.Managers;

[Component(Type = ComponentType.WebServer)]
public class ServerRestartManager : DTOManager, IServerRestartManager, IConfigurationService
{
	private IServerRestartService service;

	internal static ServerRestartManager S5W00ZWMKB2XuJRxykT1;

	public ServerRestartManager(IServerRestartService service)
	{
		//Discarded unreachable code: IL_001a, IL_001f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 2;
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 2:
				Contract.ArgumentNotNull(service, (string)AiFV7OWMksSOu014ZwgH(--1867379187 ^ 0x6F4C9193));
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
				{
					num = 1;
				}
				break;
			case 0:
				return;
			case 1:
				this.service = service;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public virtual Guid Schedule(long userId, DateTime targetDate, string reason, bool sendNotifications)
	{
		return yBSX1YWMnN49vixfNTyr(service, userId, targetDate, reason, sendNotifications);
	}

	public virtual void CancelRestart(Guid restartId)
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
				qVIPEjWMO2j86Ivfgwt4(service, restartId);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public virtual TimeSpan GetMinimumRestartTime()
	{
		return WansdlWM24eip04epmjQ(service);
	}

	internal static object AiFV7OWMksSOu014ZwgH(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool vVBl8eWMXpbnBmOQZNP9()
	{
		return S5W00ZWMKB2XuJRxykT1 == null;
	}

	internal static ServerRestartManager tX4vY2WMTRlBHvtMhtGw()
	{
		return S5W00ZWMKB2XuJRxykT1;
	}

	internal static Guid yBSX1YWMnN49vixfNTyr(object P_0, long userId, DateTime restartDate, object P_3, bool sendNotifications)
	{
		return ((IServerRestartService)P_0).Schedule(userId, restartDate, (string)P_3, sendNotifications);
	}

	internal static void qVIPEjWMO2j86Ivfgwt4(object P_0, Guid restartId)
	{
		((IServerRestartService)P_0).CancelRestart(restartId);
	}

	internal static TimeSpan WansdlWM24eip04epmjQ(object P_0)
	{
		return ((IServerRestartService)P_0).GetMinimumRestartTime();
	}
}
