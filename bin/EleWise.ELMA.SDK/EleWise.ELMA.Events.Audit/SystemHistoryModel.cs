using System;
using System.Dynamic;
using System.Runtime.CompilerServices;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Security;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Events.Audit;

public sealed class SystemHistoryModel : IHistoryBaseModel
{
	private readonly EntityActionEventArgs _originalEvent;

	private readonly IUser _originalAuthor;

	private readonly dynamic _eventData;

	private static SystemHistoryModel QRLkn5GUzZDCnnw7lroG;

	public IUser OriginalAuthor => _originalAuthor;

	public EntityActionEventArgs OriginalEvent => _originalEvent;

	public DateTime ActionDate
	{
		[CompilerGenerated]
		get
		{
			return _003CActionDate_003Ek__BackingField;
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
					_003CActionDate_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
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

	public IUser ActionAuthor
	{
		[CompilerGenerated]
		get
		{
			return _003CActionAuthor_003Ek__BackingField;
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
					_003CActionAuthor_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public string ActionTheme
	{
		[CompilerGenerated]
		get
		{
			return _003CActionTheme_003Ek__BackingField;
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
					_003CActionTheme_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public IAuditAction AuditAction
	{
		[CompilerGenerated]
		get
		{
			return _003CAuditAction_003Ek__BackingField;
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
					_003CAuditAction_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public IAuditObject AuditObject
	{
		[CompilerGenerated]
		get
		{
			return _003CAuditObject_003Ek__BackingField;
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
					_003CAuditObject_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0)
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

	public dynamic EventData => _eventData;

	internal SystemHistoryModel([NotNull] EntityActionEventArgs originalEvent, string actionTheme)
	{
		//Discarded unreachable code: IL_002a, IL_00ca, IL_00d9
		G8GSXSGsWkaTjnRXfCxC();
		_eventData = new ExpandoObject();
		base._002Ector();
		int num = 7;
		while (true)
		{
			switch (num)
			{
			case 3:
				_originalAuthor = (IUser)TvqF3pGsETOpnEqiRCsp(originalEvent);
				num = 2;
				break;
			default:
				throw new ArgumentNullException((string)OqDNcjGsoIk0BJsPUx72(--1418440330 ^ 0x548FB3A8));
			case 4:
				_originalEvent = originalEvent;
				num = 6;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
				{
					num = 6;
				}
				break;
			case 8:
				AuditAction = (IAuditAction)j1hPZEGsbsTrW8H2eeDG(originalEvent);
				num = 5;
				break;
			case 5:
				AuditObject = (IAuditObject)NyZCpmGshACrCfsCIeBu(originalEvent);
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
				{
					num = 1;
				}
				break;
			case 7:
				if (originalEvent != null)
				{
					int num2 = 4;
					num = num2;
					break;
				}
				goto default;
			case 6:
				ActionTheme = actionTheme;
				num = 8;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
				{
					num = 8;
				}
				break;
			case 2:
				return;
			case 1:
				ActionDate = fpexoGGsGdoOwRXmyK7E(originalEvent);
				num = 3;
				break;
			}
		}
	}

	internal static void G8GSXSGsWkaTjnRXfCxC()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object OqDNcjGsoIk0BJsPUx72(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object j1hPZEGsbsTrW8H2eeDG(object P_0)
	{
		return ((AuditEventArgs)P_0).Action;
	}

	internal static object NyZCpmGshACrCfsCIeBu(object P_0)
	{
		return ((AuditEventArgs)P_0).Object;
	}

	internal static DateTime fpexoGGsGdoOwRXmyK7E(object P_0)
	{
		return ((EntityActionEventArgs)P_0).ActionDate;
	}

	internal static object TvqF3pGsETOpnEqiRCsp(object P_0)
	{
		return ((EntityActionEventArgs)P_0).ActionAuthor;
	}

	internal static bool VIwILLGsFqkdjMvxVoFm()
	{
		return QRLkn5GUzZDCnnw7lroG == null;
	}

	internal static SystemHistoryModel QNZDvSGsBrP7KdIIcM86()
	{
		return QRLkn5GUzZDCnnw7lroG;
	}
}
