using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.FeatureFlags.Services;
using EleWise.ELMA.Messaging;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Security;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Notifications.Impl;

[Service(EnableInterceptors = false, Scope = ServiceScope.Shell, Type = ComponentType.WebServer)]
public class NotificationManager : INotificationManager
{
	private static TimeSpan totalGenTime;

	private static TimeSpan totalSendTime;

	private static NotificationManager TC080Kt0AmonHxDHw7r;

	public IMessageManager MessageManager
	{
		[CompilerGenerated]
		get
		{
			return _003CMessageManager_003Ek__BackingField;
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
					_003CMessageManager_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public IEnumerable<INotificationTemplateLoader> TemplateLoaders { get; set; }

	public IContextBoundVariableService ContextService
	{
		[CompilerGenerated]
		get
		{
			return _003CContextService_003Ek__BackingField;
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
					_003CContextService_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public IFeatureFlagService FeatureFlagService
	{
		[CompilerGenerated]
		get
		{
			return _003CFeatureFlagService_003Ek__BackingField;
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
					_003CFeatureFlagService_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
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

	public void Send(INotification notification)
	{
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		int num = 2;
		int num2 = num;
		ValueTaskAwaiter awaiter = default(ValueTaskAwaiter);
		System.Threading.Tasks.ValueTask valueTask = default(System.Threading.Tasks.ValueTask);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				awaiter = valueTask.GetAwaiter();
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
				{
					num2 = 2;
				}
				break;
			case 3:
				((ValueTaskAwaiter)(ref awaiter)).GetResult();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				valueTask = SendAsyncInternal(notification);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca != 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public Task SendAsync(INotification notification, CancellationToken cancellationToken = default(CancellationToken))
	{
		int num = 1;
		int num2 = num;
		System.Threading.Tasks.ValueTask valueTask = default(System.Threading.Tasks.ValueTask);
		while (true)
		{
			switch (num2)
			{
			default:
				return valueTask.AsTask();
			case 1:
				valueTask = SendAsyncInternal(notification, isAsync: true, cancellationToken);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	[AsyncStateMachine(typeof(_003CSendAsyncInternal_003Ed__18))]
	private System.Threading.Tasks.ValueTask SendAsyncInternal(INotification notification, bool isAsync = false, CancellationToken cancellationToken = default(CancellationToken))
	{
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		int num = 1;
		int num2 = num;
		_003CSendAsyncInternal_003Ed__18 _003CSendAsyncInternal_003Ed__ = default(_003CSendAsyncInternal_003Ed__18);
		AsyncValueTaskMethodBuilder _003C_003Et__builder = default(AsyncValueTaskMethodBuilder);
		while (true)
		{
			switch (num2)
			{
			case 1:
				_003CSendAsyncInternal_003Ed__._003C_003E4__this = this;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				_003CSendAsyncInternal_003Ed__._003C_003E1__state = -1;
				num2 = 5;
				break;
			case 6:
				_003CSendAsyncInternal_003Ed__._003C_003Et__builder = zrTJ0XtMUXh67y1ReU1();
				num2 = 3;
				break;
			case 2:
				_003CSendAsyncInternal_003Ed__.isAsync = isAsync;
				num2 = 6;
				break;
			case 5:
				_003C_003Et__builder = _003CSendAsyncInternal_003Ed__._003C_003Et__builder;
				num2 = 7;
				break;
			case 4:
				return ((AsyncValueTaskMethodBuilder)(ref _003CSendAsyncInternal_003Ed__._003C_003Et__builder)).get_Task();
			case 7:
				((AsyncValueTaskMethodBuilder)(ref _003C_003Et__builder)).Start<_003CSendAsyncInternal_003Ed__18>(ref _003CSendAsyncInternal_003Ed__);
				num2 = 4;
				break;
			default:
				_003CSendAsyncInternal_003Ed__.notification = notification;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	public bool AddUserToIgnoreList(IUser user)
	{
		//Discarded unreachable code: IL_003d, IL_004c
		int num = 3;
		int num2 = num;
		List<long> ignoredUserIds = default(List<long>);
		long item = default(long);
		while (true)
		{
			switch (num2)
			{
			case 3:
				if (user == null)
				{
					num2 = 2;
					break;
				}
				ignoredUserIds = GetIgnoredUserIds();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0)
				{
					num2 = 1;
				}
				break;
			case 2:
				return false;
			default:
				if (!ignoredUserIds.Contains(item))
				{
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 != 0)
					{
						num2 = 6;
					}
					break;
				}
				goto case 4;
			case 5:
				return true;
			case 1:
				item = (long)Yp0JyOtJEWot628TMuC(user);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				return false;
			case 6:
				ignoredUserIds.Add(item);
				num2 = 5;
				break;
			}
		}
	}

	public void RemoveUserFromIgnoreList(IUser user)
	{
		//Discarded unreachable code: IL_0051
		int num = 3;
		int num2 = num;
		List<long> ignoredUserIds = default(List<long>);
		long item = default(long);
		while (true)
		{
			switch (num2)
			{
			default:
				ignoredUserIds.Remove(item);
				num2 = 4;
				break;
			case 5:
				item = (long)Yp0JyOtJEWot628TMuC(user);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
				{
					num2 = 1;
				}
				break;
			case 4:
				return;
			case 1:
				if (!ignoredUserIds.Contains(item))
				{
					return;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0)
				{
					num2 = 0;
				}
				break;
			case 6:
				return;
			case 2:
				ignoredUserIds = GetIgnoredUserIds();
				num2 = 5;
				break;
			case 3:
				if (user == null)
				{
					return;
				}
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public bool AddUserToForceSendList(IUser user)
	{
		//Discarded unreachable code: IL_003d
		int num = 1;
		List<long> forceSendUserIds = default(List<long>);
		long item = default(long);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 4:
					if (!forceSendUserIds.Contains(item))
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
						{
							num2 = 2;
						}
						continue;
					}
					break;
				case 6:
					item = (long)Yp0JyOtJEWot628TMuC(user);
					num2 = 4;
					continue;
				default:
					return false;
				case 1:
					if (user != null)
					{
						forceSendUserIds = GetForceSendUserIds();
						num2 = 6;
						continue;
					}
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0)
					{
						num2 = 0;
					}
					continue;
				case 3:
					return true;
				case 5:
					break;
				case 2:
					goto end_IL_0012;
				}
				return false;
				continue;
				end_IL_0012:
				break;
			}
			forceSendUserIds.Add(item);
			num = 3;
		}
	}

	public void RemoveUserFromForceSendList(IUser user)
	{
		//Discarded unreachable code: IL_008d, IL_00bf, IL_00ce
		int num = 3;
		int num2 = num;
		List<long> forceSendUserIds = default(List<long>);
		long item = default(long);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 3:
				if (user != null)
				{
					num2 = 2;
					break;
				}
				return;
			case 1:
				return;
			case 5:
				return;
			case 7:
				forceSendUserIds.Remove(item);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0)
				{
					num2 = 1;
				}
				break;
			case 4:
				item = (long)Yp0JyOtJEWot628TMuC(user);
				num2 = 6;
				break;
			case 0:
				return;
			case 2:
				forceSendUserIds = GetForceSendUserIds();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
				{
					num2 = 4;
				}
				break;
			case 6:
				if (!forceSendUserIds.Contains(item))
				{
					num2 = 5;
					break;
				}
				goto case 7;
			}
		}
	}

	public void AddUsersToAdditionalSendList(IEnumerable<IUser> users)
	{
		List<IUser> additionalSendUsers = GetAdditionalSendUsers();
		foreach (IUser user in users)
		{
			if (!additionalSendUsers.Contains(user))
			{
				additionalSendUsers.Add(user);
			}
		}
	}

	internal List<long> GetIgnoredUserIds()
	{
		return ContextService.GetOrAdd(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x12441CA4 ^ 0x124494FC), () => new List<long>());
	}

	internal List<long> GetForceSendUserIds()
	{
		return ContextService.GetOrAdd(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-35995181 ^ -36026101), () => new List<long>());
	}

	internal List<IUser> GetAdditionalSendUsers()
	{
		return ContextService.GetOrAdd(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1637C429 ^ 0x16374D77), () => new List<IUser>());
	}

	public NotificationManager()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		Jm8kJtt9IH3hqgkRxEC();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static NotificationManager()
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				totalSendTime = TimeSpan.Zero;
				num2 = 3;
				break;
			case 3:
				return;
			case 2:
				Jm8kJtt9IH3hqgkRxEC();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				totalGenTime = TimeSpan.Zero;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static bool hlAOMMtmkiWTlQxqnjN()
	{
		return TC080Kt0AmonHxDHw7r == null;
	}

	internal static NotificationManager QM4IoBtyAg8QIHdOBGZ()
	{
		return TC080Kt0AmonHxDHw7r;
	}

	internal static AsyncValueTaskMethodBuilder zrTJ0XtMUXh67y1ReU1()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return AsyncValueTaskMethodBuilder.Create();
	}

	internal static object Yp0JyOtJEWot628TMuC(object P_0)
	{
		return ((IIdentified)P_0).GetId();
	}

	internal static void Jm8kJtt9IH3hqgkRxEC()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
