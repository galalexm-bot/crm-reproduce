using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading;
using System.Web;
using EleWise.ELMA.Cache;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Modules;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.Db.Migrator.Providers;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Scheduling;
using EleWise.ELMA.Security.Components;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Models.ActiveUserSession;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.Threading;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Transform;
using NHibernate.Type;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Security;

[Service(Type = ComponentType.WebServer, InjectProperties = true, Scope = ServiceScope.Application, EnableInterceptors = false)]
public sealed class ActiveUserSessionService : IInitHandler, IActiveUserSessionService
{
	private class SetTimeout : IDisposable
	{
		private object _owner;

		private int? _lastTimeout;

		private object _callOwner;

		internal static object JHTJSipAipBNa8UosC39;

		public SetTimeout(ActiveUserSessionService owner)
		{
			//Discarded unreachable code: IL_002c, IL_0031
			PWly4dpAlaJMVhaS6PUP();
			this._002Ector(owner, -1);
			int num = 0;
			if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8fd69cd0bea1432ca401d29377c613cc == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		public SetTimeout(ActiveUserSessionService owner, int timeout)
		{
			//Discarded unreachable code: IL_002a, IL_002f, IL_005e, IL_006d
			PWly4dpAlaJMVhaS6PUP();
			base._002Ector();
			int num = 6;
			if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_fc5e0189a7f447a7b93cd505b96d5f05 != 0)
			{
				num = 1;
			}
			while (true)
			{
				switch (num)
				{
				case 6:
					if (owner == null)
					{
						num = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_c08b0b4e9ab14bedb2a2c7a0048ab814 == 0)
						{
							num = 0;
						}
						continue;
					}
					_owner = owner;
					num = 4;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a33ec05b36714591b0adf150b655c9a8 == 0)
					{
						num = 4;
					}
					continue;
				case 4:
					if (((ActiveUserSessionService)_owner)._transform == null)
					{
						num = 3;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_01fd90314ba945f0a4ee79d2372961e2 == 0)
						{
							num = 2;
						}
						continue;
					}
					break;
				default:
					throw new ArgumentNullException(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-848444002 ^ -848452258));
				case 3:
				case 5:
					_callOwner = nfpSwSpANHbiNK7okxLi();
					num = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_7eacf98b652644699fca43e43408d382 == 0)
					{
						num = 1;
					}
					continue;
				case 1:
					return;
				case 2:
					break;
				}
				_lastTimeout = ((ActiveUserSessionService)_owner)._transform.SetCurrentContextTimeout((timeout > 0) ? timeout : 30);
				num = 5;
			}
		}

		public void Dispose()
		{
			int num = 3;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					if (((ActiveUserSessionService)_owner)._transform != null)
					{
						num2 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_f6614d006512404f8cab65f09d3e1c89 == 0)
						{
							num2 = 0;
						}
						break;
					}
					return;
				default:
					((ActiveUserSessionService)_owner)._transform.SetCurrentContextTimeout(_lastTimeout);
					num2 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_5028d2018b41471c962aaca947e33b9d == 0)
					{
						num2 = 1;
					}
					break;
				case 1:
					return;
				case 3:
					yobA1tpAZZbp2GyWq5J6(_callOwner);
					num2 = 2;
					break;
				}
			}
		}

		internal static void PWly4dpAlaJMVhaS6PUP()
		{
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
		}

		internal static bool gK5XlZpA7HfrjoZOsZWC()
		{
			return JHTJSipAipBNa8UosC39 == null;
		}

		internal static SetTimeout MtumMlpA6Z2fS3YbftXu()
		{
			return (SetTimeout)JHTJSipAipBNa8UosC39;
		}

		internal static object nfpSwSpANHbiNK7okxLi()
		{
			return CallContextSessionOwner.Create();
		}

		internal static void yobA1tpAZZbp2GyWq5J6(object P_0)
		{
			((CallContextSessionOwner)P_0).Dispose();
		}
	}

	[UsedImplicitly]
	[Component(Type = ComponentType.WebServer, EnableInterceptiors = false)]
	private class ActiveUserSessionSweepHandler : ISweepHandler, IThreadPoolContainer
	{
		private readonly object _sweepPool;

		private static object tGJBeHpAxhbe701T88xM;

		IThreadPool IThreadPoolContainer.Pool => (IThreadPool)_sweepPool;

		public ActiveUserSessionSweepHandler()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_5c5fc9a9dec4418fa9513347a116bf27 != 0)
			{
				num = 0;
			}
			while (true)
			{
				switch (num)
				{
				case 1:
					return;
				}
				_sweepPool = new ThreadSubPool(1);
				num = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_562220c988b04dea969b2dc6cde52015 != 0)
				{
					num = 1;
				}
			}
		}

		void ISweepHandler.Execute()
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
				{
					ActiveUserSessionService serviceNotNull = Locator.GetServiceNotNull<ActiveUserSessionService>();
					b8vvSepAmuXdOuEnrvvW(serviceNotNull);
					serviceNotNull.FlushUpdatedSessions();
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_c843c5b509d748f086ceb6be01690351 == 0)
					{
						num2 = 0;
					}
					break;
				}
				}
			}
		}

		internal static bool hVnbmbpABnF2sBmWDiCo()
		{
			return tGJBeHpAxhbe701T88xM == null;
		}

		internal static ActiveUserSessionSweepHandler Q87PimpAucGx1fpMvuvw()
		{
			return (ActiveUserSessionSweepHandler)tGJBeHpAxhbe701T88xM;
		}

		internal static void b8vvSepAmuXdOuEnrvvW(object P_0)
		{
			((ActiveUserSessionService)P_0).ReloadSettings();
		}
	}

	[UsedImplicitly]
	[Component(Type = ComponentType.WebServer)]
	private class ActiveUserSessionInitializer : IModuleContainerEvents
	{
		private static object eJZiHppAeHhlvYr3ORQE;

		public void Activated()
		{
			hdXyZjpAHKka0G53jNME(Locator.GetServiceNotNull<ActiveUserSessionService>());
		}

		public void Terminating()
		{
		}

		public ActiveUserSessionInitializer()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			fgmdSOpAa65xyAuKQ8CG();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_03ad39fc745d49e3be14e8e100fb0203 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static void hdXyZjpAHKka0G53jNME(object P_0)
		{
			((ActiveUserSessionService)P_0).ReloadSettings();
		}

		internal static void fgmdSOpAa65xyAuKQ8CG()
		{
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
		}

		internal static bool I3hdjApALGsbN01NnYIn()
		{
			return eJZiHppAeHhlvYr3ORQE == null;
		}

		internal static ActiveUserSessionInitializer DUHSmRpAj3nVJqCs8WHI()
		{
			return (ActiveUserSessionInitializer)eJZiHppAeHhlvYr3ORQE;
		}
	}

	private readonly ILogger logger;

	private ITransformationProvider _transform;

	private ILockManager _lockManager;

	private ICacheService _cacheService;

	private readonly ReaderWriterLock _updateSessionsLock;

	private IContextBoundVariableService _contextService;

	private List<IAuthenticationServiceEventHandler> _authenticationServiceEventHandlers;

	private List<IAuthenticatedSessionEventHandler> _authenticatedSessionEventHandlers;

	private ISessionProvider sessionProvider;

	private UserManager userManager;

	private IUnitOfWorkManager unitOfWorkManager;

	private long _privilegeGroupId;

	private DateTime? _startTime;

	private DateTime? _lastUpdateTime;

	private static int? savingActivityTimeoutTime;

	private static TimeSpan _freezeTime;

	private static TimeSpan _removeOnPingTimeoutTime;

	private static TimeSpan? _removeOnActionTimeoutTime;

	private static TimeSpan? _removePrivilegedUsersTimeoutTime;

	private static readonly string CacheKey;

	private ConcurrentDictionary<Guid, AuthenticatedSessionInfo> sessionsToUpdate;

	private bool isPrivilegedLicense;

	private long _adminId;

	private IInternalSecurityService internalSecurityService;

	internal static ActiveUserSessionService yEX26R9eNmpB2ECcwy;

	internal static int SavingActivityTimeoutTime
	{
		get
		{
			//Discarded unreachable code: IL_0072, IL_0081, IL_0091, IL_00a0
			int num = 3;
			int num2 = num;
			int num3 = default(int);
			while (true)
			{
				switch (num2)
				{
				case 5:
					num3 = 60;
					num2 = 4;
					break;
				default:
					num3 = SR.GetSetting(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x335D4787 ^ 0x335D4ABB), 60);
					num2 = 7;
					break;
				case 3:
					if (savingActivityTimeoutTime.HasValue)
					{
						num2 = 2;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b1df165db1394c8cbd9914e637f5e083 == 0)
						{
							num2 = 2;
						}
						break;
					}
					goto default;
				case 1:
				case 4:
					savingActivityTimeoutTime = num3;
					num2 = 2;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_97ec140e839b4bd5a711912170945a29 == 0)
					{
						num2 = 6;
					}
					break;
				case 7:
					if (num3 > 0)
					{
						num2 = 1;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0d00d0d8fcd5481b8bdc09ec82b1ea36 == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 5;
				case 2:
				case 6:
					return savingActivityTimeoutTime.Value;
				}
			}
		}
	}

	private IInternalSecurityService InternalSecurityService
	{
		get
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					return internalSecurityService;
				case 1:
					if (internalSecurityService == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_d689f5970f6345a7af332e1f7092123f == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 2;
				default:
					internalSecurityService = (IInternalSecurityService)PZZMer5WZhxJJpgUacX((ILicensedModuleAssembly)q8dwo95AP22Y00Qg9Uc(j930ZG55NPMDaZ5eM3H(d3WY855pWnDnb4j88ks()), __AssemblyInfo.UID));
					num2 = 2;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_651070b1c9bd4381bbb7379d68d6508e == 0)
					{
						num2 = 2;
					}
					break;
				}
			}
		}
	}

	private List<IAuthenticationServiceEventHandler> AuthenticationServiceEventHandlers => _authenticationServiceEventHandlers ?? (_authenticationServiceEventHandlers = ComponentManager.Current.GetExtensionPoints<IAuthenticationServiceEventHandler>().ToList());

	private List<IAuthenticatedSessionEventHandler> AuthenticatedSessionEventHandlers => _authenticatedSessionEventHandlers ?? (_authenticatedSessionEventHandlers = ComponentManager.Current.GetExtensionPoints<IAuthenticatedSessionEventHandler>().ToList());

	private ISessionProvider SessionProvider
	{
		get
		{
			int num = 2;
			int num2 = num;
			ISessionProvider sessionProvider = default(ISessionProvider);
			ISessionProvider obj;
			while (true)
			{
				switch (num2)
				{
				case 1:
					sessionProvider = (this.sessionProvider = Locator.GetServiceNotNull<ISessionProvider>());
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b128c216f9744fbcbc93a88cbe7b4554 != 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					obj = this.sessionProvider;
					if (obj != null)
					{
						break;
					}
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a1d876260ca946cdbdcbec4b9517d613 == 0)
					{
						num2 = 1;
					}
					continue;
				default:
					obj = sessionProvider;
					break;
				}
				break;
			}
			return obj;
		}
	}

	private UserManager UserManager
	{
		get
		{
			int num = 2;
			int num2 = num;
			UserManager obj;
			UserManager userManager = default(UserManager);
			while (true)
			{
				switch (num2)
				{
				case 2:
					obj = this.userManager;
					if (obj == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_d133bac4622e4b5596f3c44ee791169d != 0)
						{
							num2 = 1;
						}
						continue;
					}
					break;
				case 1:
					userManager = (this.userManager = UserManager.Instance);
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_94a7beb9ab90455caa18ecaa3b17b19c == 0)
					{
						num2 = 0;
					}
					continue;
				default:
					obj = userManager;
					break;
				}
				break;
			}
			return obj;
		}
	}

	private IUnitOfWorkManager UnitOfWorkManager
	{
		get
		{
			int num = 1;
			int num2 = num;
			IUnitOfWorkManager obj;
			IUnitOfWorkManager unitOfWorkManager = default(IUnitOfWorkManager);
			while (true)
			{
				switch (num2)
				{
				case 1:
					obj = this.unitOfWorkManager;
					if (obj == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_1c9893e65c104705bb8b228f8a38d9cd != 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				default:
					unitOfWorkManager = (this.unitOfWorkManager = Locator.GetServiceNotNull<IUnitOfWorkManager>());
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6949750552fc4dcdbaec6842e5667482 != 0)
					{
						num2 = 2;
					}
					continue;
				case 2:
					obj = unitOfWorkManager;
					break;
				}
				break;
			}
			return obj;
		}
	}

	public IEnumerable<AuthenticatedSessionInfo> GetSessions(AuthenticatedSessionFilter filter)
	{
		using (new SetTimeout(this))
		{
			List<AuthenticatedSessionInfo> list = new List<AuthenticatedSessionInfo>();
			string text = string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-730071140 ^ -730071586), _transform.Dialect.QuoteIfNeeded(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x28EBA022 ^ 0x28EBA2EA)), _transform.Dialect.QuoteIfNeeded(AuthenticatedSessionInfo.Db.Fields.TicketUid), _transform.Dialect.QuoteIfNeeded(AuthenticatedSessionInfo.Db.Fields.Status), _transform.Dialect.QuoteIfNeeded(AuthenticatedSessionInfo.Db.Fields.Expiration), _transform.Dialect.QuoteIfNeeded(AuthenticatedSessionInfo.Db.Fields.SessionId), _transform.Dialect.QuoteIfNeeded(AuthenticatedSessionInfo.Db.Fields.UserId), _transform.Dialect.QuoteIfNeeded(AuthenticatedSessionInfo.Db.Fields.RemoteAddress), _transform.Dialect.QuoteIfNeeded(AuthenticatedSessionInfo.Db.Fields.CreationDate), _transform.Dialect.QuoteIfNeeded(AuthenticatedSessionInfo.Db.Fields.LastActionDate), _transform.Dialect.QuoteIfNeeded(AuthenticatedSessionInfo.Db.Fields.LastPingDate), _transform.Dialect.QuoteIfNeeded(AuthenticatedSessionInfo.Db.Fields.LastActionInfo));
			Dictionary<string, object> dictionary = new Dictionary<string, object>();
			if (filter != null && filter.UserId != null)
			{
				text += string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xCD88DD8 ^ 0xCD88F36), _transform.Dialect.QuoteIfNeeded(AuthenticatedSessionInfo.Db.Fields.UserId), _transform.ParameterSeparator);
				dictionary[SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x738E3073 ^ 0x738E3369)] = filter.UserId;
			}
			else
			{
				text += string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x62C4BCE8 ^ 0x62C4BFC2), _transform.Dialect.QuoteIfNeeded(AuthenticatedSessionInfo.Db.Fields.UserId));
			}
			if (filter != null && filter.OnlyActive)
			{
				text += string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1842376086 ^ -1842376400), _transform.Dialect.QuoteIfNeeded(AuthenticatedSessionInfo.Db.Fields.Status), _transform.ParameterSeparator);
				dictionary[SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3E79A885 ^ 0x3E79AB1D)] = 0;
			}
			if (filter != null && !string.IsNullOrWhiteSpace(filter.SessionId))
			{
				text += string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1712587919 ^ -1712588593), _transform.Dialect.QuoteIfNeeded(AuthenticatedSessionInfo.Db.Fields.SessionId), _transform.ParameterSeparator);
				dictionary[SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2119527672 ^ -2119528220)] = filter.SessionId;
			}
			List<long> list2 = GetPrivilegeUserIds().ToList();
			using (IDataReader dataReader = _transform.ExecuteQuery(text, dictionary))
			{
				while (dataReader.Read())
				{
					AuthenticatedSessionInfo authenticatedSessionInfo = ReadSessionInfo(dataReader);
					if (filter == null || !filter.OnlyConcurrentUsers || !list2.Contains((long)authenticatedSessionInfo.UserId))
					{
						list.Add(authenticatedSessionInfo);
					}
				}
			}
			return list;
		}
	}

	public IEnumerable<long> GetPrivilegeUserIds()
	{
		return GetPrivilegeUserIds(includeAdmin: true);
	}

	public IEnumerable<long> GetPrivilegeUserIds(bool includeAdmin)
	{
		if (!includeAdmin)
		{
			return new long[0];
		}
		return new long[1] { _adminId };
	}

	public AuthenticatedSessionInfo Get(Guid ticketId)
	{
		//Discarded unreachable code: IL_00d1, IL_0109, IL_0118, IL_0129, IL_018a, IL_01a9, IL_01b8, IL_01e5
		int num = 2;
		SetTimeout setTimeout = default(SetTimeout);
		_003C_003Ec__DisplayClass3_0 _003C_003Ec__DisplayClass3_ = default(_003C_003Ec__DisplayClass3_0);
		AuthenticatedSessionInfo result = default(AuthenticatedSessionInfo);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 5:
					break;
				case 4:
					setTimeout = new SetTimeout(this);
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_06e91bc1320c425bb120c2fac8d1e3be != 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					_003C_003Ec__DisplayClass3_ = new _003C_003Ec__DisplayClass3_0();
					num2 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_f4f2657bf7454f44b4829aa89c711f0d == 0)
					{
						num2 = 1;
					}
					continue;
				default:
					try
					{
						string name = string.Concat(MrYFXQzVOm0PPB0m8p(0x1A9A1A63 ^ 0x1A9A1E61), _003C_003Ec__DisplayClass3_.ticketId);
						int num3 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_c08b0b4e9ab14bedb2a2c7a0048ab814 == 0)
						{
							num3 = 2;
						}
						while (true)
						{
							object obj;
							switch (num3)
							{
							case 2:
								if (_contextService != null)
								{
									num3 = 3;
									break;
								}
								goto default;
							default:
								obj = null;
								goto IL_0148;
							case 3:
								obj = _contextService.GetOrAdd(name, _003C_003Ec__DisplayClass3_._003CGet_003Eb__0);
								goto IL_0148;
							case 1:
								{
									return result;
								}
								IL_0148:
								result = (AuthenticatedSessionInfo)obj;
								num3 = 1;
								if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_01fd90314ba945f0a4ee79d2372961e2 == 0)
								{
									num3 = 1;
								}
								break;
							}
						}
					}
					finally
					{
						int num4;
						if (setTimeout == null)
						{
							num4 = 1;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_61a610c13d6d47c8947a4d2d4016147a == 0)
							{
								num4 = 2;
							}
							goto IL_018e;
						}
						goto IL_01c3;
						IL_01c3:
						RgOqbWpk2dqE60G9eQE(setTimeout);
						num4 = 1;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_56bc39e908f44451b3cdd0d68828e324 == 0)
						{
							num4 = 1;
						}
						goto IL_018e;
						IL_018e:
						switch (num4)
						{
						case 2:
							goto end_IL_0169;
						case 1:
							goto end_IL_0169;
						}
						goto IL_01c3;
						end_IL_0169:;
					}
				case 1:
					_003C_003Ec__DisplayClass3_._003C_003E4__this = this;
					num2 = 5;
					continue;
				case 3:
					return result;
				}
				break;
			}
			_003C_003Ec__DisplayClass3_.ticketId = ticketId;
			num = 4;
		}
	}

	public AuthenticatedSessionInfo FindBySessionId(string sessionId)
	{
		//Discarded unreachable code: IL_0060, IL_023f, IL_024e, IL_02ed, IL_0325, IL_0334
		int num = 1;
		int num2 = num;
		SetTimeout setTimeout = default(SetTimeout);
		AuthenticatedSessionInfo result = default(AuthenticatedSessionInfo);
		AuthenticatedSessionInfo authenticatedSessionInfo = default(AuthenticatedSessionInfo);
		while (true)
		{
			switch (num2)
			{
			case 1:
				setTimeout = new SetTimeout(this);
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b54421a4e10b4c2fa10cef566e462fbd == 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				return result;
			}
			try
			{
				int num3;
				if (ypxEgBppV5v4sUerSMn(sessionId))
				{
					num3 = 3;
					goto IL_0064;
				}
				goto IL_0094;
				IL_0064:
				while (true)
				{
					switch (num3)
					{
					default:
						result = authenticatedSessionInfo;
						num3 = 5;
						continue;
					case 1:
						break;
					case 3:
						result = null;
						num3 = 2;
						continue;
					case 4:
						LZ5k4SpNTfqirqbTcqA(logger, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x22A54A05 ^ 0x22A54F11), new object[2]
						{
							sessionId,
							(authenticatedSessionInfo == null) ? MrYFXQzVOm0PPB0m8p(0x31C71464 ^ 0x31C7113C) : SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x738E3073 ^ 0x738E353B)
						});
						num3 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_d2fa92555e394879ba912e266541f735 != 0)
						{
							num3 = 0;
						}
						continue;
					case 2:
						return result;
					case 5:
						return result;
					}
					break;
				}
				goto IL_0094;
				IL_0094:
				authenticatedSessionInfo = ((IQuery)s5YJaBplyIT317nUfnM(((IQuery)mEx8fTp6issVryqioMW(T4hA8OpiUHTx0bDTHlN(LcJVihpnns7bN9qickt(h9OInup55tCcX8O7MxT(SessionProvider, string.Empty), C5IlQHpXGSGaFN7Q7kq(MrYFXQzVOm0PPB0m8p(0x1618182 ^ 0x16185BA), new object[11]
				{
					CUYDawpW8bm5XiB8TZm(BTMIunpArlEyk2LFVsQ(_transform), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4BBFF2C6 ^ 0x4BBFF00E)),
					CUYDawpW8bm5XiB8TZm(BTMIunpArlEyk2LFVsQ(_transform), AuthenticatedSessionInfo.Db.Fields.SessionId),
					CUYDawpW8bm5XiB8TZm(BTMIunpArlEyk2LFVsQ(_transform), AuthenticatedSessionInfo.Db.Fields.TicketUid),
					CUYDawpW8bm5XiB8TZm(BTMIunpArlEyk2LFVsQ(_transform), AuthenticatedSessionInfo.Db.Fields.Status),
					CUYDawpW8bm5XiB8TZm(_transform.Dialect, AuthenticatedSessionInfo.Db.Fields.Expiration),
					((Dialect)BTMIunpArlEyk2LFVsQ(_transform)).QuoteIfNeeded(AuthenticatedSessionInfo.Db.Fields.UserId),
					CUYDawpW8bm5XiB8TZm(BTMIunpArlEyk2LFVsQ(_transform), AuthenticatedSessionInfo.Db.Fields.RemoteAddress),
					CUYDawpW8bm5XiB8TZm(_transform.Dialect, AuthenticatedSessionInfo.Db.Fields.CreationDate),
					CUYDawpW8bm5XiB8TZm(BTMIunpArlEyk2LFVsQ(_transform), AuthenticatedSessionInfo.Db.Fields.LastActionDate),
					CUYDawpW8bm5XiB8TZm(BTMIunpArlEyk2LFVsQ(_transform), AuthenticatedSessionInfo.Db.Fields.LastPingDate),
					CUYDawpW8bm5XiB8TZm(BTMIunpArlEyk2LFVsQ(_transform), AuthenticatedSessionInfo.Db.Fields.LastActionInfo)
				})), MrYFXQzVOm0PPB0m8p(-236222459 ^ -236221199), sessionId), new AliasToBeanResultTransformer(JT8toip7ZtKvdPJunx8(typeof(AuthenticatedSessionInfo).TypeHandle)))).SetMaxResults(1), false)).UniqueResult<AuthenticatedSessionInfo>();
				num3 = 4;
				goto IL_0064;
			}
			finally
			{
				if (setTimeout != null)
				{
					int num4 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0d00d0d8fcd5481b8bdc09ec82b1ea36 == 0)
					{
						num4 = 1;
					}
					while (true)
					{
						switch (num4)
						{
						case 1:
							RgOqbWpk2dqE60G9eQE(setTimeout);
							num4 = 0;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_fa1b4c3a88294db7b3c25698c3f06dd7 == 0)
							{
								num4 = 0;
							}
							continue;
						case 0:
							break;
						}
						break;
					}
				}
			}
		}
	}

	public void Insert(AuthenticatedSessionInfo sessionInfo, EleWise.ELMA.Security.Models.IUser user)
	{
		//Discarded unreachable code: IL_00ae, IL_01ac, IL_0378, IL_042c, IL_0464, IL_0473
		int num = 3;
		int num2 = num;
		_003C_003Ec__DisplayClass5_0 _003C_003Ec__DisplayClass5_ = default(_003C_003Ec__DisplayClass5_0);
		SetTimeout setTimeout = default(SetTimeout);
		_003C_003Ec__DisplayClass5_1 CS_0024_003C_003E8__locals0;
		ActiveUsersSessionInfo otherUsersCount = default(ActiveUsersSessionInfo);
		while (true)
		{
			switch (num2)
			{
			default:
				_003C_003Ec__DisplayClass5_.sessionInfo = sessionInfo;
				num2 = 4;
				break;
			case 3:
				_003C_003Ec__DisplayClass5_ = new _003C_003Ec__DisplayClass5_0();
				num2 = 2;
				break;
			case 4:
				setTimeout = new SetTimeout(this);
				num2 = 5;
				break;
			case 2:
				_003C_003Ec__DisplayClass5_.user = user;
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_2f11eccd7e8f4339a0b03ad9fe1eb947 == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				return;
			case 5:
				try
				{
					CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass5_1();
					int num3 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0df0152125fa4e148590f3218518a41b == 0)
					{
						num3 = 1;
					}
					while (true)
					{
						switch (num3)
						{
						case 9:
							return;
						default:
							CS_0024_003C_003E8__locals0.currentPrivelegeCount = 0;
							num3 = 4;
							break;
						case 8:
							_003C_003Ec__DisplayClass5_.sessionInfo.CreationIsCurrent = true;
							num3 = 5;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_75955a8c33b24cdca4663f20d9ee3c3b == 0)
							{
								num3 = 16;
							}
							break;
						case 11:
							i9JqIhpBEvCsJiTMj1U(_003C_003Ec__DisplayClass5_.sessionInfo, AuthenticatedSessionStatus.Active);
							num3 = 8;
							break;
						case 19:
							AuthenticationServiceEventHandlers.ForEach(_003C_003Ec__DisplayClass5_._003CInsert_003Eb__4);
							num3 = 9;
							break;
						case 15:
							if (!(ll3GgGpZdyVI7SXjwjf(_003C_003Ec__DisplayClass5_.user) == SecurityConstants.AdminUserUid))
							{
								num3 = 20;
								break;
							}
							goto case 6;
						case 18:
							if (otherUsersCount != null)
							{
								num3 = 17;
								break;
							}
							goto case 12;
						case 13:
							_003C_003Ec__DisplayClass5_.sessionInfo.CreationIsCurrent = false;
							num3 = 3;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_fe0eedb8ce484402a5c9a74346556b9f == 0)
							{
								num3 = 3;
							}
							break;
						case 4:
							CS_0024_003C_003E8__locals0.othersCount = 0;
							num3 = 15;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_7ced317202a44233ac3d0deafcdd1923 != 0)
							{
								num3 = 15;
							}
							break;
						case 10:
							AuthenticatedSessionEventHandlers.ForEach(_003C_003Ec__DisplayClass5_._003CInsert_003Eb__3);
							num3 = 19;
							break;
						case 2:
						case 20:
							otherUsersCount = GetOtherUsersCount(_003C_003Ec__DisplayClass5_.sessionInfo);
							num3 = 18;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_fa1b4c3a88294db7b3c25698c3f06dd7 == 0)
							{
								num3 = 16;
							}
							break;
						case 3:
							Aw8sD4pefH5U2hKGFIy(_contextService, qcegSMpmx8oZ5ARveSi(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1B47BFA1 ^ 0x1B47BBA3), cAyV5gpu8dJaUQst3ki(_003C_003Ec__DisplayClass5_.sessionInfo)), _003C_003Ec__DisplayClass5_.sessionInfo);
							num3 = 10;
							break;
						case 12:
							InternalSecurityService.CheckUserToAuthenticate(_003C_003Ec__DisplayClass5_.user, () => CS_0024_003C_003E8__locals0.loginCount > 0, (int maxPrivilegeCount) => CS_0024_003C_003E8__locals0.currentPrivelegeCount > 0, () => _003C_003Ec__DisplayClass5_1.fU9SBSpAqEFSWiecO6MN(0, CS_0024_003C_003E8__locals0.othersCount - CS_0024_003C_003E8__locals0.currentPrivelegeCount));
							num3 = 11;
							break;
						case 6:
							CS_0024_003C_003E8__locals0.currentPrivelegeCount = nMjBBRpxT7YDaOUoXvp(1, CS_0024_003C_003E8__locals0.currentPrivelegeCount);
							num3 = 2;
							break;
						case 7:
							throw new ArgumentNullException((string)MrYFXQzVOm0PPB0m8p(-192929954 ^ -192931282));
						case 5:
							CS_0024_003C_003E8__locals0.loginCount = 0;
							num3 = 0;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_4b1278f673174e87a9fb6665eab69fc6 != 0)
							{
								num3 = 0;
							}
							break;
						case 16:
							UpsertSessionInfo(_003C_003Ec__DisplayClass5_.sessionInfo);
							num3 = 13;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_f0c2bdf066b1416088266cd84d9c3be2 == 0)
							{
								num3 = 0;
							}
							break;
						case 1:
							if (_003C_003Ec__DisplayClass5_.sessionInfo != null)
							{
								num3 = 5;
								break;
							}
							goto case 7;
						case 17:
							CS_0024_003C_003E8__locals0.loginCount = otherUsersCount.LoginCount ?? CS_0024_003C_003E8__locals0.loginCount;
							num3 = 14;
							break;
						case 14:
							CS_0024_003C_003E8__locals0.othersCount = (otherUsersCount.TotalLoginCount ?? CS_0024_003C_003E8__locals0.othersCount) - CS_0024_003C_003E8__locals0.loginCount;
							num3 = 12;
							break;
						}
					}
				}
				finally
				{
					if (setTimeout != null)
					{
						int num4 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_443cb30a1c3f4e72a61ec4f52377fcc7 != 0)
						{
							num4 = 1;
						}
						while (true)
						{
							switch (num4)
							{
							case 1:
								RgOqbWpk2dqE60G9eQE(setTimeout);
								num4 = 0;
								if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_c78060c4cac8419092e4610bf7a03750 != 0)
								{
									num4 = 0;
								}
								continue;
							case 0:
								break;
							}
							break;
						}
					}
				}
			}
		}
	}

	public void SetUpdated(AuthenticatedSessionInfo sessionInfo, HttpContextBase httpContext)
	{
		//Discarded unreachable code: IL_0072, IL_017e, IL_018d, IL_019d, IL_0212, IL_0221, IL_0319, IL_0391, IL_03c5, IL_03fd, IL_040c
		int num = 1;
		int num2 = num;
		SetTimeout setTimeout = default(SetTimeout);
		AuthenticatedSessionInfo value = default(AuthenticatedSessionInfo);
		string text = default(string);
		while (true)
		{
			switch (num2)
			{
			case 1:
				setTimeout = new SetTimeout(this);
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8ec57fd3f43f4cf7983bc996ab09feb4 == 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				return;
			}
			try
			{
				vvgFTjpL4PtRDy5vgHr(_updateSessionsLock, 100);
				int num3 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_288a03909ebe4f56a0d34bfce957098b != 0)
				{
					num3 = 0;
				}
				switch (num3)
				{
				default:
					try
					{
						zoUJNKpHMx0makd15Ig(logger, MrYFXQzVOm0PPB0m8p(0xA5DAE86 ^ 0xA5DAB0C), new object[2]
						{
							cAyV5gpu8dJaUQst3ki(sessionInfo),
							rRFABopjw1K2oNWulWL(sessionInfo)
						});
						int num4 = 13;
						while (true)
						{
							int num5;
							switch (num4)
							{
							case 10:
								mkPeVDpwP4MQGqf5cXi(sessionInfo, FXeKtepaYBHAmUwWBoF(value));
								num5 = 3;
								goto IL_00cd;
							case 6:
								if (!aBg9eWpvXk49oj2b1Ic(text, sessionInfo.SessionId))
								{
									num4 = 9;
									break;
								}
								goto case 12;
							case 3:
								uXPrI5p2W8EgHxpsaXO(sessionInfo, value.LastActionInfo);
								num4 = 1;
								if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_fc5e0189a7f447a7b93cd505b96d5f05 != 0)
								{
									num4 = 0;
								}
								break;
							case 13:
								if (!sessionsToUpdate.TryGetValue(cAyV5gpu8dJaUQst3ki(sessionInfo), out value))
								{
									num4 = 14;
									break;
								}
								goto case 5;
							default:
								Aw8sD4pefH5U2hKGFIy(_contextService, qcegSMpmx8oZ5ARveSi(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4CD4C8A0 ^ 0x4CD4CCA2), cAyV5gpu8dJaUQst3ki(sessionInfo)), sessionInfo);
								num5 = 15;
								goto IL_00cd;
							case 5:
								if (hebrZVpRoYbsOtZBpPr(FXeKtepaYBHAmUwWBoF(value), FXeKtepaYBHAmUwWBoF(sessionInfo)))
								{
									num4 = 10;
									break;
								}
								goto case 1;
							case 12:
								zoUJNKpHMx0makd15Ig(logger, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x40096392 ^ 0x40096672), new object[3]
								{
									cAyV5gpu8dJaUQst3ki(sessionInfo),
									text,
									sessionInfo.SessionId
								});
								num4 = 7;
								break;
							case 2:
							case 4:
								sessionsToUpdate[cAyV5gpu8dJaUQst3ki(sessionInfo)] = sessionInfo;
								num4 = 0;
								if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6c7be8ec8b6749dcb0601e062f5515fa == 0)
								{
									num4 = 0;
								}
								break;
							case 8:
							case 9:
							case 11:
								LZ5k4SpNTfqirqbTcqA(logger, MrYFXQzVOm0PPB0m8p(0x4177C82C ^ 0x4177CDA6), new object[2]
								{
									cAyV5gpu8dJaUQst3ki(sessionInfo),
									rRFABopjw1K2oNWulWL(sessionInfo)
								});
								num4 = 4;
								if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6e35a1cd804541a884550671c71dbb1c == 0)
								{
									num4 = 4;
								}
								break;
							case 1:
							case 14:
							{
								Guid guid = cAyV5gpu8dJaUQst3ki(sessionInfo);
								text = (string)rRFABopjw1K2oNWulWL(sessionInfo);
								sessionInfo.UpdateFromHttpContext(httpContext);
								if (!EInu0wpPGe6KkFWwlX9(guid, cAyV5gpu8dJaUQst3ki(sessionInfo)))
								{
									num4 = 8;
									break;
								}
								goto case 6;
							}
							case 7:
								UpsertSessionInfo(sessionInfo);
								num4 = 2;
								break;
							case 15:
								return;
								IL_00cd:
								num4 = num5;
								break;
							}
						}
					}
					finally
					{
						m2nY4NpCkKbIfIFR85m(_updateSessionsLock);
						int num6 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_3c78e0d08cb4410a900ca26e4b83108c == 0)
						{
							num6 = 0;
						}
						switch (num6)
						{
						case 0:
							break;
						}
					}
				}
			}
			finally
			{
				if (setTimeout != null)
				{
					int num7 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_06e91bc1320c425bb120c2fac8d1e3be != 0)
					{
						num7 = 1;
					}
					while (true)
					{
						switch (num7)
						{
						case 1:
							RgOqbWpk2dqE60G9eQE(setTimeout);
							num7 = 0;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0d00d0d8fcd5481b8bdc09ec82b1ea36 == 0)
							{
								num7 = 0;
							}
							continue;
						case 0:
							break;
						}
						break;
					}
				}
			}
		}
	}

	public void RemoveSession(Guid ticketId)
	{
		//Discarded unreachable code: IL_005c, IL_01b8, IL_01c7, IL_0236, IL_0255, IL_0264, IL_0281, IL_0290
		int num = 1;
		int num2 = num;
		SetTimeout setTimeout = default(SetTimeout);
		_003C_003Ec__DisplayClass7_0 CS_0024_003C_003E8__locals0;
		while (true)
		{
			switch (num2)
			{
			case 1:
				setTimeout = new SetTimeout(this);
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_7ced317202a44233ac3d0deafcdd1923 == 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				return;
			}
			try
			{
				CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass7_0();
				int num3 = 4;
				while (true)
				{
					switch (num3)
					{
					default:
						return;
					case 6:
						CS_0024_003C_003E8__locals0.user = UserManager.Load(S1NRo6pKC5lm38jW7Qc(U2jIfVpJrVnXHKlFJYy(CS_0024_003C_003E8__locals0.session)));
						num3 = 5;
						break;
					case 2:
						zoUJNKpHMx0makd15Ig(logger, MrYFXQzVOm0PPB0m8p(-219609047 ^ -219607443), new object[2]
						{
							ticketId,
							rRFABopjw1K2oNWulWL(CS_0024_003C_003E8__locals0.session)
						});
						num3 = 3;
						break;
					case 3:
						LEWAMlpouRhmAlYtVro(BFItdOpUp8nrwbW9W4q(LcJVihpnns7bN9qickt(h9OInup55tCcX8O7MxT(SessionProvider, string.Empty), string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6AA79E0 ^ 0x6AA7F40), ((Dialect)BTMIunpArlEyk2LFVsQ(_transform)).QuoteIfNeeded(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-434542700 ^ -434543268)), _transform.Dialect.QuoteIfNeeded(AuthenticatedSessionInfo.Db.Fields.TicketUid))), MrYFXQzVOm0PPB0m8p(0x116C2699 ^ 0x116C206F), ticketId), false);
						num3 = 6;
						break;
					case 5:
						AuthenticatedSessionEventHandlers.ForEach(delegate(IAuthenticatedSessionEventHandler h)
						{
							int num5 = 1;
							int num6 = num5;
							while (true)
							{
								switch (num6)
								{
								default:
									return;
								case 0:
									return;
								case 1:
									h.SessionClosed(CS_0024_003C_003E8__locals0.user, CS_0024_003C_003E8__locals0.session);
									num6 = 0;
									if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_4ca2baab70e44d2ca8271afba4c9a72d != 0)
									{
										num6 = 0;
									}
									break;
								}
							}
						});
						num3 = 1;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_fa1b4c3a88294db7b3c25698c3f06dd7 != 0)
						{
							num3 = 1;
						}
						break;
					case 0:
						return;
					case 7:
						if (CS_0024_003C_003E8__locals0.session == null)
						{
							num3 = 0;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_c843c5b509d748f086ceb6be01690351 == 0)
							{
								num3 = 0;
							}
							break;
						}
						goto case 2;
					case 4:
						CS_0024_003C_003E8__locals0.session = Get(ticketId);
						num3 = 7;
						break;
					case 1:
						return;
					}
				}
			}
			finally
			{
				int num4;
				if (setTimeout == null)
				{
					num4 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_76accc62823f4af5a14c51746ed23095 != 0)
					{
						num4 = 0;
					}
					goto IL_023a;
				}
				goto IL_026f;
				IL_026f:
				RgOqbWpk2dqE60G9eQE(setTimeout);
				num4 = 2;
				goto IL_023a;
				IL_023a:
				switch (num4)
				{
				default:
					goto end_IL_0215;
				case 0:
					goto end_IL_0215;
				case 1:
					break;
				case 2:
					goto end_IL_0215;
				}
				goto IL_026f;
				end_IL_0215:;
			}
		}
	}

	public void RemoveAllUserSessions(object userId)
	{
		//Discarded unreachable code: IL_004b, IL_01ce, IL_01dd, IL_01e8, IL_02c8, IL_0308, IL_0317, IL_0323, IL_0332, IL_0363, IL_039b, IL_03aa
		int num = 2;
		int num2 = num;
		long num6 = default(long);
		IEnumerator<AuthenticatedSessionInfo> enumerator = default(IEnumerator<AuthenticatedSessionInfo>);
		IEnumerable<AuthenticatedSessionInfo> sessions = default(IEnumerable<AuthenticatedSessionInfo>);
		_003C_003Ec__DisplayClass8_1 _003C_003Ec__DisplayClass8_2 = default(_003C_003Ec__DisplayClass8_1);
		SetTimeout setTimeout = default(SetTimeout);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				try
				{
					_003C_003Ec__DisplayClass8_0 _003C_003Ec__DisplayClass8_ = new _003C_003Ec__DisplayClass8_0();
					int num3 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_e0cdbab05b2b455cab94ec0ba1efc443 == 0)
					{
						num3 = 1;
					}
					while (true)
					{
						switch (num3)
						{
						case 2:
							return;
						case 3:
							_003C_003Ec__DisplayClass8_.user = UserManager.Load(num6);
							num3 = 7;
							break;
						case 5:
							zoUJNKpHMx0makd15Ig(logger, MrYFXQzVOm0PPB0m8p(0x1869C442 ^ 0x1869C356), new object[1] { num6 });
							num3 = 0;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_86eb143f59c14824a2785845ea23f248 != 0)
							{
								num3 = 0;
							}
							break;
						default:
							enumerator = sessions.GetEnumerator();
							num3 = 6;
							break;
						case 1:
							num6 = Convert.ToInt64(userId);
							num3 = 3;
							break;
						case 4:
							((IQuery)DIDMCLpO73W78iQNMfC(LcJVihpnns7bN9qickt(SessionProvider.GetSession(string.Empty), EVJwEVphViDUbD3BXn7(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4D3A45F ^ 0x4D3A305), CUYDawpW8bm5XiB8TZm(BTMIunpArlEyk2LFVsQ(_transform), MrYFXQzVOm0PPB0m8p(0xBBC1CCD ^ 0xBBC1E05)), ((Dialect)BTMIunpArlEyk2LFVsQ(_transform)).QuoteIfNeeded(AuthenticatedSessionInfo.Db.Fields.UserId))), MrYFXQzVOm0PPB0m8p(0xA4E904F ^ 0xA4E97E3), num6)).ExecuteUpdate(cleanUpCache: false);
							num3 = 2;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_9a38cebc63824d86b02d76fd37722379 == 0)
							{
								num3 = 2;
							}
							break;
						case 7:
							sessions = GetSessions(new AuthenticatedSessionFilter
							{
								UserId = num6
							});
							num3 = 5;
							break;
						case 6:
							try
							{
								while (true)
								{
									int num4;
									if (!v27rQPptbs1VAyBIGgm(enumerator))
									{
										num4 = 1;
										if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_4b098d453cbc45388569889eb6ab714d == 0)
										{
											num4 = 1;
										}
										goto IL_01ec;
									}
									goto IL_0279;
									IL_0279:
									_003C_003Ec__DisplayClass8_2 = new _003C_003Ec__DisplayClass8_1();
									num4 = 3;
									goto IL_01ec;
									IL_01ec:
									while (true)
									{
										switch (num4)
										{
										case 4:
											AuthenticatedSessionEventHandlers.ForEach(_003C_003Ec__DisplayClass8_2._003CRemoveAllUserSessions_003Eb__0);
											num4 = 0;
											if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_fa1b4c3a88294db7b3c25698c3f06dd7 == 0)
											{
												num4 = 0;
											}
											continue;
										case 3:
											_003C_003Ec__DisplayClass8_2.CS_0024_003C_003E8__locals1 = _003C_003Ec__DisplayClass8_;
											num4 = 5;
											continue;
										case 2:
											goto IL_0279;
										case 5:
											_003C_003Ec__DisplayClass8_2.sessionInfo = enumerator.Current;
											num4 = 2;
											if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_39d15279765e4050b24c0f7d69df46db == 0)
											{
												num4 = 4;
											}
											continue;
										case 1:
											goto end_IL_0240;
										}
										break;
									}
									continue;
									end_IL_0240:
									break;
								}
							}
							finally
							{
								int num5;
								if (enumerator == null)
								{
									num5 = 2;
									goto IL_02cc;
								}
								goto IL_02e2;
								IL_02cc:
								switch (num5)
								{
								default:
									goto end_IL_02b7;
								case 1:
									break;
								case 2:
									goto end_IL_02b7;
								case 0:
									goto end_IL_02b7;
								}
								goto IL_02e2;
								IL_02e2:
								RgOqbWpk2dqE60G9eQE(enumerator);
								num5 = 0;
								if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_df5466d729844e8ea757565832a01037 != 0)
								{
									num5 = 0;
								}
								goto IL_02cc;
								end_IL_02b7:;
							}
							goto case 4;
						}
					}
				}
				finally
				{
					if (setTimeout != null)
					{
						int num7 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_31b4b139e534452696f4bfdfc16f1b03 != 0)
						{
							num7 = 0;
						}
						while (true)
						{
							switch (num7)
							{
							default:
								RgOqbWpk2dqE60G9eQE(setTimeout);
								num7 = 1;
								if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b1df165db1394c8cbd9914e637f5e083 == 0)
								{
									num7 = 1;
								}
								continue;
							case 1:
								break;
							}
							break;
						}
					}
				}
			case 2:
				setTimeout = new SetTimeout(this);
				num2 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_f4f2657bf7454f44b4829aa89c711f0d != 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	private AuthenticatedSessionInfo LoadSessionInfo(Guid ticketId)
	{
		return ((IQuery)mEx8fTp6issVryqioMW(s5YJaBplyIT317nUfnM(OvQBjhpqJVtgVJu5U8i(BFItdOpUp8nrwbW9W4q(LcJVihpnns7bN9qickt(SessionProvider.GetSession(string.Empty), C5IlQHpXGSGaFN7Q7kq(MrYFXQzVOm0PPB0m8p(0x67DFA65E ^ 0x67DFA198), new object[11]
		{
			CUYDawpW8bm5XiB8TZm(_transform.Dialect, MrYFXQzVOm0PPB0m8p(0x335D4787 ^ 0x335D454F)),
			_transform.Dialect.QuoteIfNeeded(AuthenticatedSessionInfo.Db.Fields.TicketUid),
			CUYDawpW8bm5XiB8TZm(BTMIunpArlEyk2LFVsQ(_transform), AuthenticatedSessionInfo.Db.Fields.Status),
			CUYDawpW8bm5XiB8TZm(_transform.Dialect, AuthenticatedSessionInfo.Db.Fields.Expiration),
			CUYDawpW8bm5XiB8TZm(BTMIunpArlEyk2LFVsQ(_transform), AuthenticatedSessionInfo.Db.Fields.SessionId),
			CUYDawpW8bm5XiB8TZm(BTMIunpArlEyk2LFVsQ(_transform), AuthenticatedSessionInfo.Db.Fields.UserId),
			CUYDawpW8bm5XiB8TZm(BTMIunpArlEyk2LFVsQ(_transform), AuthenticatedSessionInfo.Db.Fields.RemoteAddress),
			_transform.Dialect.QuoteIfNeeded(AuthenticatedSessionInfo.Db.Fields.CreationDate),
			CUYDawpW8bm5XiB8TZm(BTMIunpArlEyk2LFVsQ(_transform), AuthenticatedSessionInfo.Db.Fields.LastActionDate),
			CUYDawpW8bm5XiB8TZm(BTMIunpArlEyk2LFVsQ(_transform), AuthenticatedSessionInfo.Db.Fields.LastPingDate),
			CUYDawpW8bm5XiB8TZm(BTMIunpArlEyk2LFVsQ(_transform), AuthenticatedSessionInfo.Db.Fields.LastActionInfo)
		})), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1580392499 ^ -1580394181), ticketId), 1), false), new AliasToBeanResultTransformer(JT8toip7ZtKvdPJunx8(typeof(AuthenticatedSessionInfo).TypeHandle)))).UniqueResult<AuthenticatedSessionInfo>();
	}

	private AuthenticatedSessionInfo ReadSessionInfo(IDataReader r)
	{
		AuthenticatedSessionInfo authenticatedSessionInfo = new AuthenticatedSessionInfo();
		TbIQTnpFamuZPV70xk9(authenticatedSessionInfo, uNGlA9pGQyTvapkqnk9(BTMIunpArlEyk2LFVsQ(_transform), e4hs4XpcA1BKFlxJbs2(r, AuthenticatedSessionInfo.Db.Fields.TicketUid)));
		i9JqIhpBEvCsJiTMj1U(authenticatedSessionInfo, (!(e4hs4XpcA1BKFlxJbs2(r, AuthenticatedSessionInfo.Db.Fields.Status) is DBNull)) ? ((AuthenticatedSessionStatus)Convert.ToInt32(e4hs4XpcA1BKFlxJbs2(r, AuthenticatedSessionInfo.Db.Fields.Status))) : AuthenticatedSessionStatus.Active);
		authenticatedSessionInfo.Expiration = ((!(r[AuthenticatedSessionInfo.Db.Fields.Expiration] is DBNull)) ? ((DateTime?)e4hs4XpcA1BKFlxJbs2(r, AuthenticatedSessionInfo.Db.Fields.Expiration)) : null);
		XEG4NMp07xWfelkrwqh(authenticatedSessionInfo, (!(e4hs4XpcA1BKFlxJbs2(r, AuthenticatedSessionInfo.Db.Fields.SessionId) is DBNull)) ? ((string)e4hs4XpcA1BKFlxJbs2(r, AuthenticatedSessionInfo.Db.Fields.SessionId)) : null);
		jcFv6RpEbNqjrLpOEch(authenticatedSessionInfo, (!(r[AuthenticatedSessionInfo.Db.Fields.UserId] is DBNull)) ? S1NRo6pKC5lm38jW7Qc(e4hs4XpcA1BKFlxJbs2(r, AuthenticatedSessionInfo.Db.Fields.UserId)) : 0);
		LtnSZTpDHXd9O4494Vy(authenticatedSessionInfo, (!(e4hs4XpcA1BKFlxJbs2(r, AuthenticatedSessionInfo.Db.Fields.RemoteAddress) is DBNull)) ? ((string)e4hs4XpcA1BKFlxJbs2(r, AuthenticatedSessionInfo.Db.Fields.RemoteAddress)) : null);
		Q4Te3cpMHQbEMuAQ5MD(authenticatedSessionInfo, (DateTime)e4hs4XpcA1BKFlxJbs2(r, AuthenticatedSessionInfo.Db.Fields.CreationDate));
		authenticatedSessionInfo.LastActionDate = ((!(e4hs4XpcA1BKFlxJbs2(r, AuthenticatedSessionInfo.Db.Fields.LastActionDate) is DBNull)) ? ((DateTime)r[AuthenticatedSessionInfo.Db.Fields.LastActionDate]) : ((Dialect)BTMIunpArlEyk2LFVsQ(_transform)).MinDateTime);
		GoWuMGpsTOsfVamyinC(authenticatedSessionInfo, (DateTime)e4hs4XpcA1BKFlxJbs2(r, AuthenticatedSessionInfo.Db.Fields.LastPingDate));
		uXPrI5p2W8EgHxpsaXO(authenticatedSessionInfo, (!(r[AuthenticatedSessionInfo.Db.Fields.LastActionInfo] is DBNull)) ? ((string)e4hs4XpcA1BKFlxJbs2(r, AuthenticatedSessionInfo.Db.Fields.LastActionInfo)) : null);
		return authenticatedSessionInfo;
	}

	private void UpdateSessionInfo(AuthenticatedSessionInfo sessionInfo)
	{
		//Discarded unreachable code: IL_0051, IL_0060
		int num = 1;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					if (sessionInfo != null)
					{
						num2 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_7ced317202a44233ac3d0deafcdd1923 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 2;
				case 3:
					return;
				case 2:
					throw new ArgumentNullException((string)MrYFXQzVOm0PPB0m8p(--1130812004 ^ 0x4366D714));
				default:
					_transform.Update(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1973849202 ^ -1973849786), new string[7]
					{
						AuthenticatedSessionInfo.Db.Fields.Expiration,
						AuthenticatedSessionInfo.Db.Fields.LastActionDate,
						AuthenticatedSessionInfo.Db.Fields.LastActionInfo,
						AuthenticatedSessionInfo.Db.Fields.LastPingDate,
						AuthenticatedSessionInfo.Db.Fields.RemoteAddress,
						AuthenticatedSessionInfo.Db.Fields.SessionId,
						AuthenticatedSessionInfo.Db.Fields.UserId
					}, new object[7]
					{
						new ParameterValue(sessionInfo.Expiration, convertToDbTime: false),
						NnprEdpYxaBh7jr1tm0(sessionInfo) ? ((object)new SqlExpressionParameter(((Dialect)BTMIunpArlEyk2LFVsQ(_transform)).CurrentTimestamp)) : ((object)new ParameterValue(FXeKtepaYBHAmUwWBoF(sessionInfo), convertToDbTime: false)),
						ChmFkJpIUFIsy1q5L2x(sessionInfo),
						TThQ4kp4PDjLOcxttLF(sessionInfo) ? ((object)new SqlExpressionParameter((string)sAVXwcpQXHJidpYuXZw(BTMIunpArlEyk2LFVsQ(_transform)))) : ((object)new ParameterValue(CV8O22pVijXW9Bq8VEp(sessionInfo), convertToDbTime: false)),
						sessionInfo.RemoteAddress,
						rRFABopjw1K2oNWulWL(sessionInfo),
						U2jIfVpJrVnXHKlFJYy(sessionInfo)
					}, string.Format((string)MrYFXQzVOm0PPB0m8p(0xCDF201B ^ 0xCDF289B), ((Dialect)BTMIunpArlEyk2LFVsQ(_transform)).QuoteIfNeeded(AuthenticatedSessionInfo.Db.Fields.TicketUid), aI0ruspdWp2DrUFn1BH(_transform)), new Dictionary<string, object> { 
					{
						(string)MrYFXQzVOm0PPB0m8p(-930147978 ^ -930146432),
						sessionInfo.TicketUid
					} });
					num = 3;
					break;
				}
				break;
			}
		}
	}

	private void FlushUpdatedSessions()
	{
		//Discarded unreachable code: IL_0181, IL_029f, IL_02bf, IL_0345, IL_03aa, IL_03bd, IL_03cc, IL_0729, IL_0763, IL_0772, IL_0795, IL_07d7, IL_07e6, IL_0a37, IL_0a41, IL_0a6e, IL_0a7d, IL_0c42, IL_0cf7, IL_0d06, IL_0d11, IL_0f42, IL_0f7a, IL_0fbc, IL_105e, IL_106d, IL_1078, IL_1274, IL_12ac, IL_1314, IL_1380, IL_138f, IL_14ac, IL_14e4, IL_14f3
		int num = 1;
		int num2 = num;
		SetTimeout setTimeout = default(SetTimeout);
		IEnumerator<AuthenticatedSessionInfo> enumerator = default(IEnumerator<AuthenticatedSessionInfo>);
		_003C_003Ec__DisplayClass12_1 _003C_003Ec__DisplayClass12_4 = default(_003C_003Ec__DisplayClass12_1);
		TimeSpan? timeSpan5 = default(TimeSpan?);
		TimeSpan timeSpan3 = default(TimeSpan);
		string text4 = default(string);
		_003C_003Ec__DisplayClass12_0 _003C_003Ec__DisplayClass12_3 = default(_003C_003Ec__DisplayClass12_0);
		_003C_003Ec__DisplayClass12_3 _003C_003Ec__DisplayClass12_ = default(_003C_003Ec__DisplayClass12_3);
		TimeSpan? timeSpan4 = default(TimeSpan?);
		TimeSpan timeSpan2 = default(TimeSpan);
		string text = default(string);
		string text3 = default(string);
		DateTime? dateTime3 = default(DateTime?);
		string text2 = default(string);
		IList<AuthenticatedSessionInfo> list = default(IList<AuthenticatedSessionInfo>);
		DateTime? dateTime4 = default(DateTime?);
		_003C_003Ec__DisplayClass12_4 _003C_003Ec__DisplayClass12_5 = default(_003C_003Ec__DisplayClass12_4);
		_003C_003Ec__DisplayClass12_5 _003C_003Ec__DisplayClass12_2 = default(_003C_003Ec__DisplayClass12_5);
		DateTime dateTime2 = default(DateTime);
		while (true)
		{
			switch (num2)
			{
			case 1:
				setTimeout = new SetTimeout(this);
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_9a38cebc63824d86b02d76fd37722379 == 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				return;
			}
			try
			{
				DateTime dateTime = XfoooIpTxNvQcl70yh0();
				int num3 = 40;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_5c3c41b36b4846e0b1701d4e56408883 != 0)
				{
					num3 = 34;
				}
				while (true)
				{
					int num8;
					TimeSpan? timeSpan;
					switch (num3)
					{
					case 23:
						if (!_removeOnActionTimeoutTime.HasValue)
						{
							num3 = 61;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b700f854946b45dfa4de8ce28732acad == 0)
							{
								num3 = 50;
							}
							break;
						}
						goto case 31;
					case 7:
						if (isPrivilegedLicense)
						{
							num3 = 33;
							break;
						}
						goto case 12;
					case 37:
						enumerator = _003C_003Ec__DisplayClass12_4.removeSessionsInfo.GetEnumerator();
						num3 = 20;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_d2fa92555e394879ba912e266541f735 == 0)
						{
							num3 = 32;
						}
						break;
					case 27:
						timeSpan5 = null;
						num3 = 8;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_86eb143f59c14824a2785845ea23f248 == 0)
						{
							num3 = 16;
						}
						break;
					case 34:
					{
						object obj = BTMIunpArlEyk2LFVsQ(_transform);
						string currentTimestamp = ((Dialect)BTMIunpArlEyk2LFVsQ(_transform)).CurrentTimestamp;
						object obj2 = MrYFXQzVOm0PPB0m8p(-737960346 ^ -737961986);
						timeSpan3 = _removePrivilegedUsersTimeoutTime.Value;
						text4 = ((Dialect)obj).AddSecond(currentTimestamp, string.Concat(obj2, timeSpan3.TotalSeconds));
						num3 = 26;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_01fd90314ba945f0a4ee79d2372961e2 == 0)
						{
							num3 = 21;
						}
						break;
					}
					case 36:
					case 55:
						if (!_startTime.HasValue)
						{
							num3 = 44;
							break;
						}
						goto case 43;
					case 8:
						_003C_003Ec__DisplayClass12_3 = new _003C_003Ec__DisplayClass12_0();
						num3 = 38;
						break;
					case 64:
						return;
					case 3:
						AuthenticatedSessionEventHandlers.ForEach(_003C_003Ec__DisplayClass12_._003CFlushUpdatedSessions_003Eb__5);
						num3 = 53;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_c08b0b4e9ab14bedb2a2c7a0048ab814 == 0)
						{
							num3 = 63;
						}
						break;
					case 62:
						AuthenticationServiceEventHandlers.ForEach(_003C_003Ec__DisplayClass12_._003CFlushUpdatedSessions_003Eb__6);
						num3 = 42;
						break;
					case 20:
						try
						{
							_003C_003Ec__DisplayClass12_3.sessionInfos = sessionsToUpdate;
							int num9 = 0;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b54421a4e10b4c2fa10cef566e462fbd != 0)
							{
								num9 = 0;
							}
							while (true)
							{
								switch (num9)
								{
								default:
									sessionsToUpdate = new ConcurrentDictionary<Guid, AuthenticatedSessionInfo>();
									num9 = 1;
									if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_e0cdbab05b2b455cab94ec0ba1efc443 == 0)
									{
										num9 = 1;
									}
									continue;
								case 1:
									break;
								}
								break;
							}
						}
						finally
						{
							odttP8p32pUfr8TROgT(_updateSessionsLock);
							int num10 = 0;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_daaf990ff0c644fb99cfba0a043a9b93 == 0)
							{
								num10 = 0;
							}
							switch (num10)
							{
							case 0:
								break;
							}
						}
						goto case 4;
					case 25:
						_lastUpdateTime = dateTime;
						num3 = 11;
						break;
					case 12:
					case 51:
						if (!isPrivilegedLicense)
						{
							num3 = 22;
							break;
						}
						goto case 69;
					case 63:
						if (j8N0tC5kILvgsZqPbrx(_003C_003Ec__DisplayClass12_.users) > 0)
						{
							num8 = 62;
							goto IL_004a;
						}
						return;
					case 19:
						if (!timeSpan4.HasValue)
						{
							num3 = 30;
							break;
						}
						if (iEBUpOprIJ2G7l4OVZ4(timeSpan4.GetValueOrDefault(), timeSpan3))
						{
							num3 = 1;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_e4840b3cf8a94577862fdc527af9db29 != 0)
							{
								num3 = 1;
							}
							break;
						}
						return;
					case 1:
						_003C_003Ec__DisplayClass12_4 = new _003C_003Ec__DisplayClass12_1();
						num3 = 5;
						break;
					case 43:
						timeSpan2 = BsUs1KpykBAPNmbttcv(dateTime, _startTime.Value);
						num3 = 28;
						break;
					case 21:
						text = string.Format((string)MrYFXQzVOm0PPB0m8p(0x71BC7C31 ^ 0x71BC749D), ((Dialect)BTMIunpArlEyk2LFVsQ(_transform)).QuoteIfNeeded((string)MrYFXQzVOm0PPB0m8p(0x65F93013 ^ 0x65F932DB)), CUYDawpW8bm5XiB8TZm(BTMIunpArlEyk2LFVsQ(_transform), AuthenticatedSessionInfo.Db.Fields.LastPingDate), CUYDawpW8bm5XiB8TZm(BTMIunpArlEyk2LFVsQ(_transform), AuthenticatedSessionInfo.Db.Fields.Expiration), sAVXwcpQXHJidpYuXZw(_transform.Dialect), mKWO1Yp9FQumtfAnHGf(BTMIunpArlEyk2LFVsQ(_transform), sAVXwcpQXHJidpYuXZw(BTMIunpArlEyk2LFVsQ(_transform)), qcegSMpmx8oZ5ARveSi(MrYFXQzVOm0PPB0m8p(0x71CDF2F ^ 0x71CD6B7), _removeOnPingTimeoutTime.TotalSeconds)), _transform.Dialect.QuoteIfNeeded(AuthenticatedSessionInfo.Db.Fields.TicketUid), CUYDawpW8bm5XiB8TZm(BTMIunpArlEyk2LFVsQ(_transform), AuthenticatedSessionInfo.Db.Fields.Status), CUYDawpW8bm5XiB8TZm(BTMIunpArlEyk2LFVsQ(_transform), AuthenticatedSessionInfo.Db.Fields.SessionId), CUYDawpW8bm5XiB8TZm(_transform.Dialect, AuthenticatedSessionInfo.Db.Fields.UserId), CUYDawpW8bm5XiB8TZm(_transform.Dialect, AuthenticatedSessionInfo.Db.Fields.RemoteAddress), _transform.Dialect.QuoteIfNeeded(AuthenticatedSessionInfo.Db.Fields.CreationDate), CUYDawpW8bm5XiB8TZm(_transform.Dialect, AuthenticatedSessionInfo.Db.Fields.LastActionDate), CUYDawpW8bm5XiB8TZm(BTMIunpArlEyk2LFVsQ(_transform), AuthenticatedSessionInfo.Db.Fields.LastActionInfo));
						num3 = 72;
						break;
					case 33:
						if (string.IsNullOrEmpty(text3))
						{
							num8 = 51;
							goto IL_004a;
						}
						goto case 66;
					case 39:
						if (dateTime3.HasValue)
						{
							num3 = 58;
							break;
						}
						goto case 27;
					case 10:
					case 17:
						_003C_003Ec__DisplayClass12_4.removeSessionsInfo = ((IQuery)s5YJaBplyIT317nUfnM(mEx8fTp6issVryqioMW(LcJVihpnns7bN9qickt(h9OInup55tCcX8O7MxT(sessionProvider, string.Empty), text), new AliasToBeanResultTransformer(JT8toip7ZtKvdPJunx8(typeof(AuthenticatedSessionInfo).TypeHandle))), false)).List<AuthenticatedSessionInfo>();
						num3 = 68;
						break;
					case 65:
						if (!(timeSpan2 > _removePrivilegedUsersTimeoutTime.Value))
						{
							num3 = 30;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_3fde536d235f4cd390062db7c7cf1219 == 0)
							{
								num3 = 57;
							}
							break;
						}
						goto default;
					case 2:
					case 22:
						text += (string)EVJwEVphViDUbD3BXn7(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x38328F00 ^ 0x383286F2), CUYDawpW8bm5XiB8TZm(_transform.Dialect, AuthenticatedSessionInfo.Db.Fields.LastActionDate), text2);
						num3 = 13;
						break;
					case 67:
						if (_removeOnActionTimeoutTime.HasValue)
						{
							num3 = 47;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_2df53c26a6094060a56f82d6cf94e7da != 0)
							{
								num3 = 38;
							}
							break;
						}
						goto case 18;
					case 16:
						timeSpan = timeSpan5;
						goto IL_13ad;
					case 47:
						if (timeSpan2 > _removeOnActionTimeoutTime.Value)
						{
							num3 = 9;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_3e35bb8d9f5b4a1d9826edea4d9dca96 != 0)
							{
								num3 = 46;
							}
							break;
						}
						goto case 18;
					case 6:
						enumerator = list.GetEnumerator();
						num3 = 60;
						break;
					case 70:
						list.RemoveAll(_003C_003Ec__DisplayClass12_4._003CFlushUpdatedSessions_003Eb__1);
						num3 = 1;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_3fde536d235f4cd390062db7c7cf1219 == 0)
						{
							num3 = 50;
						}
						break;
					case 45:
						_003C_003Ec__DisplayClass12_.sessionClosedUsersIds = new ConcurrentDictionary<long, List<AuthenticatedSessionInfo>>();
						num3 = 6;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a1d876260ca946cdbdcbec4b9517d613 != 0)
						{
							num3 = 0;
						}
						break;
					case 68:
						list = ((IQuery)mEx8fTp6issVryqioMW(s5YJaBplyIT317nUfnM(((IQuery)LcJVihpnns7bN9qickt(sessionProvider.GetSession(string.Empty), C5IlQHpXGSGaFN7Q7kq(MrYFXQzVOm0PPB0m8p(-76932334 ^ -76934838), new object[12]
						{
							CUYDawpW8bm5XiB8TZm(BTMIunpArlEyk2LFVsQ(_transform), MrYFXQzVOm0PPB0m8p(-1943394692 ^ -1943395148)),
							CUYDawpW8bm5XiB8TZm(BTMIunpArlEyk2LFVsQ(_transform), AuthenticatedSessionInfo.Db.Fields.Status),
							CUYDawpW8bm5XiB8TZm(BTMIunpArlEyk2LFVsQ(_transform), AuthenticatedSessionInfo.Db.Fields.LastPingDate),
							mKWO1Yp9FQumtfAnHGf(BTMIunpArlEyk2LFVsQ(_transform), sAVXwcpQXHJidpYuXZw(BTMIunpArlEyk2LFVsQ(_transform)), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6AA79E0 ^ 0x6AA7078) + _freezeTime.TotalSeconds),
							_transform.Dialect.QuoteIfNeeded(AuthenticatedSessionInfo.Db.Fields.TicketUid),
							CUYDawpW8bm5XiB8TZm(BTMIunpArlEyk2LFVsQ(_transform), AuthenticatedSessionInfo.Db.Fields.Expiration),
							CUYDawpW8bm5XiB8TZm(BTMIunpArlEyk2LFVsQ(_transform), AuthenticatedSessionInfo.Db.Fields.SessionId),
							CUYDawpW8bm5XiB8TZm(BTMIunpArlEyk2LFVsQ(_transform), AuthenticatedSessionInfo.Db.Fields.UserId),
							CUYDawpW8bm5XiB8TZm(BTMIunpArlEyk2LFVsQ(_transform), AuthenticatedSessionInfo.Db.Fields.RemoteAddress),
							CUYDawpW8bm5XiB8TZm(BTMIunpArlEyk2LFVsQ(_transform), AuthenticatedSessionInfo.Db.Fields.CreationDate),
							((Dialect)BTMIunpArlEyk2LFVsQ(_transform)).QuoteIfNeeded(AuthenticatedSessionInfo.Db.Fields.LastActionDate),
							((Dialect)BTMIunpArlEyk2LFVsQ(_transform)).QuoteIfNeeded(AuthenticatedSessionInfo.Db.Fields.LastActionInfo)
						}))).SetInt32((string)MrYFXQzVOm0PPB0m8p(--561310391 ^ 0x2174E199), 0), false), new AliasToBeanResultTransformer(JT8toip7ZtKvdPJunx8(typeof(AuthenticatedSessionInfo).TypeHandle)))).List<AuthenticatedSessionInfo>();
						num8 = 70;
						goto IL_004a;
					case 59:
						if (!iEBUpOprIJ2G7l4OVZ4(dateTime - _lastUpdateTime.Value, WPflTHp8ayFgelhlrAe(TmpJlbpgjpSWNlrTeBF())))
						{
							num3 = 36;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a16ce287ba7944e2afcf4e52864ec01d == 0)
							{
								num3 = 23;
							}
							break;
						}
						goto case 8;
					case 41:
						dateTime3 = dateTime4;
						num3 = 10;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a9bad31b2eb24bb9b571e9b822d133bf == 0)
						{
							num3 = 39;
						}
						break;
					case 50:
						if (XdKCx8p1TmnOD1FJ2MX(list) <= 0)
						{
							num3 = 35;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_d2fa92555e394879ba912e266541f735 != 0)
							{
								num3 = 7;
							}
							break;
						}
						goto case 29;
					case 40:
						if (_lastUpdateTime.HasValue)
						{
							num8 = 59;
							goto IL_004a;
						}
						goto case 8;
					case 29:
						_003C_003Ec__DisplayClass12_ = new _003C_003Ec__DisplayClass12_3();
						num3 = 45;
						break;
					case 35:
						if (XdKCx8p1TmnOD1FJ2MX(_003C_003Ec__DisplayClass12_4.removeSessionsInfo) > 0)
						{
							num3 = 29;
							break;
						}
						return;
					case 26:
						text = (string)v9MaEcpfyLkYersmVGF(text, C5IlQHpXGSGaFN7Q7kq(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-724676315 ^ -724673743), new object[4]
						{
							((Dialect)BTMIunpArlEyk2LFVsQ(_transform)).QuoteIfNeeded(AuthenticatedSessionInfo.Db.Fields.LastActionDate),
							CUYDawpW8bm5XiB8TZm(BTMIunpArlEyk2LFVsQ(_transform), AuthenticatedSessionInfo.Db.Fields.UserId),
							text4,
							text3
						}));
						num3 = 5;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b54421a4e10b4c2fa10cef566e462fbd == 0)
						{
							num3 = 10;
						}
						break;
					case 72:
						text3 = string.Join((string)MrYFXQzVOm0PPB0m8p(-2068904634 ^ -2068902696), GetPrivilegeUserIds().ToArray());
						num3 = 23;
						break;
					case 66:
						text = (string)v9MaEcpfyLkYersmVGF(text, C5IlQHpXGSGaFN7Q7kq(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-179348817 ^ -179350775), new object[4]
						{
							CUYDawpW8bm5XiB8TZm(BTMIunpArlEyk2LFVsQ(_transform), AuthenticatedSessionInfo.Db.Fields.LastActionDate),
							CUYDawpW8bm5XiB8TZm(BTMIunpArlEyk2LFVsQ(_transform), AuthenticatedSessionInfo.Db.Fields.UserId),
							text2,
							text3
						}));
						num3 = 24;
						break;
					case 11:
						_updateSessionsLock.AcquireWriterLock(100);
						num3 = 20;
						break;
					case 52:
						timeSpan3 = srHR7IpSJFHvYW6AQ6g(1.0);
						num3 = 19;
						break;
					case 71:
						if (H6eSYypbVMFuLMCcRZA(timeSpan2, _removeOnPingTimeoutTime))
						{
							num8 = 53;
							goto IL_004a;
						}
						goto case 67;
					case 38:
						_003C_003Ec__DisplayClass12_3._003C_003E4__this = this;
						num3 = 25;
						break;
					case 28:
						if (H6eSYypbVMFuLMCcRZA(timeSpan2, _freezeTime))
						{
							num8 = 15;
							goto IL_004a;
						}
						goto case 71;
					case 14:
						if (ypxEgBppV5v4sUerSMn(text3))
						{
							num3 = 4;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_5adff34accb14bd183b62ef1a2f5f964 == 0)
							{
								num3 = 17;
							}
							break;
						}
						goto case 34;
					case 69:
						if (!ypxEgBppV5v4sUerSMn(text3))
						{
							num3 = 9;
							break;
						}
						goto case 2;
					case 54:
						if (_removePrivilegedUsersTimeoutTime.HasValue)
						{
							num3 = 65;
							break;
						}
						return;
					case 60:
						try
						{
							while (true)
							{
								int num6;
								if (!v27rQPptbs1VAyBIGgm(enumerator))
								{
									num6 = 2;
									if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b700f854946b45dfa4de8ce28732acad != 0)
									{
										num6 = 5;
									}
									goto IL_0d15;
								}
								goto IL_0efb;
								IL_0efb:
								_003C_003Ec__DisplayClass12_5 = new _003C_003Ec__DisplayClass12_4();
								num6 = 1;
								if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_75955a8c33b24cdca4663f20d9ee3c3b == 0)
								{
									num6 = 2;
								}
								goto IL_0d15;
								IL_0d15:
								while (true)
								{
									switch (num6)
									{
									case 1:
										_003C_003Ec__DisplayClass12_.sessionClosedUsersIds.AddOrUpdate(S1NRo6pKC5lm38jW7Qc(_003C_003Ec__DisplayClass12_5.sessionInfo.UserId), _003C_003Ec__DisplayClass12_5._003CFlushUpdatedSessions_003Eb__7, _003C_003Ec__DisplayClass12_5._003CFlushUpdatedSessions_003Eb__8);
										num6 = 6;
										if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8176869ecaf44a0b8819db51e9ec5eb4 == 0)
										{
											num6 = 3;
										}
										continue;
									case 2:
										_003C_003Ec__DisplayClass12_5.sessionInfo = enumerator.Current;
										num6 = 4;
										continue;
									case 3:
										LEWAMlpouRhmAlYtVro(BFItdOpUp8nrwbW9W4q(hWf8rwpzD2G1UDW4Efx(LcJVihpnns7bN9qickt(h9OInup55tCcX8O7MxT(sessionProvider, string.Empty), string.Format((string)MrYFXQzVOm0PPB0m8p(-1329706983 ^ -1329708065), CUYDawpW8bm5XiB8TZm(BTMIunpArlEyk2LFVsQ(_transform), MrYFXQzVOm0PPB0m8p(0x67DFA65E ^ 0x67DFA496)), CUYDawpW8bm5XiB8TZm(BTMIunpArlEyk2LFVsQ(_transform), AuthenticatedSessionInfo.Db.Fields.Status), CUYDawpW8bm5XiB8TZm(BTMIunpArlEyk2LFVsQ(_transform), AuthenticatedSessionInfo.Db.Fields.TicketUid))), MrYFXQzVOm0PPB0m8p(0x4A799728 ^ 0x4A799C06), 1), MrYFXQzVOm0PPB0m8p(0x487E82CC ^ 0x487E8E88), _003C_003Ec__DisplayClass12_5.sessionInfo.TicketUid), false);
										num6 = 1;
										if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0dd863774da04dfd9f21706b4b60a6b9 == 0)
										{
											num6 = 1;
										}
										continue;
									case 6:
										break;
									case 4:
										LZ5k4SpNTfqirqbTcqA(logger, MrYFXQzVOm0PPB0m8p(0x1869C442 ^ 0x1869CF0A), new object[2]
										{
											cAyV5gpu8dJaUQst3ki(_003C_003Ec__DisplayClass12_5.sessionInfo),
											rRFABopjw1K2oNWulWL(_003C_003Ec__DisplayClass12_5.sessionInfo)
										});
										num6 = 3;
										if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_5c3c41b36b4846e0b1701d4e56408883 != 0)
										{
											num6 = 0;
										}
										continue;
									default:
										goto IL_0efb;
									case 5:
										goto end_IL_0e77;
									}
									break;
								}
								continue;
								end_IL_0e77:
								break;
							}
						}
						finally
						{
							if (enumerator != null)
							{
								int num7 = 0;
								if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8523ddc2b5094f2f87aec3d74da64bd2 == 0)
								{
									num7 = 0;
								}
								while (true)
								{
									switch (num7)
									{
									default:
										enumerator.Dispose();
										num7 = 0;
										if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_01fd90314ba945f0a4ee79d2372961e2 != 0)
										{
											num7 = 1;
										}
										continue;
									case 1:
										break;
									}
									break;
								}
							}
						}
						goto case 37;
					case 44:
						_startTime = dateTime;
						num3 = 43;
						break;
					default:
						dateTime4 = _cacheService.Get<DateTime?>(CacheKey);
						num3 = 49;
						break;
					case 31:
					{
						object obj3 = BTMIunpArlEyk2LFVsQ(_transform);
						object arg = sAVXwcpQXHJidpYuXZw(BTMIunpArlEyk2LFVsQ(_transform));
						object obj4 = MrYFXQzVOm0PPB0m8p(-1801396866 ^ -1801399066);
						timeSpan3 = _removeOnActionTimeoutTime.Value;
						text2 = ((Dialect)obj3).AddSecond((string)arg, (string)qcegSMpmx8oZ5ARveSi(obj4, timeSpan3.TotalSeconds));
						num3 = 7;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_9a38cebc63824d86b02d76fd37722379 != 0)
						{
							num3 = 6;
						}
						break;
					}
					case 9:
					case 13:
					case 24:
					case 61:
						if (_removePrivilegedUsersTimeoutTime.HasValue)
						{
							num3 = 14;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_fb7ef78ec97a4842bca66699308784ed == 0)
							{
								num3 = 5;
							}
							break;
						}
						goto case 10;
					case 32:
						try
						{
							while (true)
							{
								IL_1182:
								int num4;
								if (!v27rQPptbs1VAyBIGgm(enumerator))
								{
									num4 = 2;
									goto IL_107c;
								}
								goto IL_1161;
								IL_107c:
								while (true)
								{
									switch (num4)
									{
									case 1:
										_003C_003Ec__DisplayClass12_2.sessionInfo = enumerator.Current;
										num4 = 3;
										continue;
									default:
										((IQuery)BFItdOpUp8nrwbW9W4q(LcJVihpnns7bN9qickt(h9OInup55tCcX8O7MxT(sessionProvider, string.Empty), EVJwEVphViDUbD3BXn7(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1788380826 ^ -1788381820), CUYDawpW8bm5XiB8TZm(BTMIunpArlEyk2LFVsQ(_transform), MrYFXQzVOm0PPB0m8p(-905821499 ^ -905822195)), CUYDawpW8bm5XiB8TZm(BTMIunpArlEyk2LFVsQ(_transform), AuthenticatedSessionInfo.Db.Fields.TicketUid))), MrYFXQzVOm0PPB0m8p(0x46347DA6 ^ 0x463471E2), cAyV5gpu8dJaUQst3ki(_003C_003Ec__DisplayClass12_2.sessionInfo))).ExecuteUpdate(cleanUpCache: false);
										num4 = 5;
										if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_31b4b139e534452696f4bfdfc16f1b03 == 0)
										{
											num4 = 5;
										}
										continue;
									case 6:
										break;
									case 4:
										goto IL_1182;
									case 3:
										LZ5k4SpNTfqirqbTcqA(logger, MrYFXQzVOm0PPB0m8p(0x32A45635 ^ 0x32A45A51), new object[2]
										{
											cAyV5gpu8dJaUQst3ki(_003C_003Ec__DisplayClass12_2.sessionInfo),
											rRFABopjw1K2oNWulWL(_003C_003Ec__DisplayClass12_2.sessionInfo)
										});
										num4 = 0;
										if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6b49024d17a94a69b2948ac938d43b7c != 0)
										{
											num4 = 0;
										}
										continue;
									case 5:
										_003C_003Ec__DisplayClass12_.sessionClosedUsersIds.AddOrUpdate(Convert.ToInt64(U2jIfVpJrVnXHKlFJYy(_003C_003Ec__DisplayClass12_2.sessionInfo)), _003C_003Ec__DisplayClass12_2._003CFlushUpdatedSessions_003Eb__9, _003C_003Ec__DisplayClass12_2._003CFlushUpdatedSessions_003Eb__10);
										num4 = 4;
										if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_d2fa92555e394879ba912e266541f735 != 0)
										{
											num4 = 0;
										}
										continue;
									case 2:
										goto end_IL_1182;
									}
									break;
								}
								goto IL_1161;
								IL_1161:
								_003C_003Ec__DisplayClass12_2 = new _003C_003Ec__DisplayClass12_5();
								num4 = 1;
								if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_66aae9daa3f84bb5931ed90b4759f85c == 0)
								{
									num4 = 0;
								}
								goto IL_107c;
								continue;
								end_IL_1182:
								break;
							}
						}
						finally
						{
							if (enumerator != null)
							{
								int num5 = 0;
								if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6f96338790994363b52cd5c55eb1342f == 0)
								{
									num5 = 0;
								}
								while (true)
								{
									switch (num5)
									{
									default:
										enumerator.Dispose();
										num5 = 1;
										if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_11e42501f5004eefaeaccdfe8bd3b619 == 0)
										{
											num5 = 0;
										}
										continue;
									case 1:
										break;
									}
									break;
								}
							}
						}
						goto case 48;
					case 5:
						_cacheService.Insert(CacheKey, dateTime);
						num3 = 21;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_97ec140e839b4bd5a711912170945a29 != 0)
						{
							num3 = 18;
						}
						break;
					case 4:
						ExecuteWithLock(_003C_003Ec__DisplayClass12_3._003CFlushUpdatedSessions_003Eb__0);
						num3 = 15;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_1c270ab2f5854923a44daf526a7f59af == 0)
						{
							num3 = 55;
						}
						break;
					case 49:
						if (dateTime4.HasValue)
						{
							num3 = 23;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_dee60bd1c491407eb16511279f664d42 != 0)
							{
								num3 = 56;
							}
							break;
						}
						goto case 1;
					case 56:
						dateTime2 = dateTime;
						num3 = 41;
						break;
					case 18:
						if (!_removeOnActionTimeoutTime.HasValue)
						{
							num3 = 40;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_d133bac4622e4b5596f3c44ee791169d != 0)
							{
								num3 = 64;
							}
							break;
						}
						goto case 54;
					case 57:
						return;
					case 58:
						timeSpan = BsUs1KpykBAPNmbttcv(dateTime2, dateTime3.GetValueOrDefault());
						goto IL_13ad;
					case 48:
						_003C_003Ec__DisplayClass12_.users = UserManager.FindByIdArray(_003C_003Ec__DisplayClass12_.sessionClosedUsersIds.Keys.ToArray()).ToDictionary((EleWise.ELMA.Security.Models.IUser k) => k.Id, (EleWise.ELMA.Security.Models.IUser v) => v);
						num3 = 3;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_77bfde1a0739446782f0bda00c988550 != 0)
						{
							num3 = 3;
						}
						break;
					case 30:
						return;
					case 42:
						return;
						IL_004a:
						num3 = num8;
						break;
						IL_13ad:
						timeSpan4 = timeSpan;
						num3 = 17;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8523ddc2b5094f2f87aec3d74da64bd2 == 0)
						{
							num3 = 52;
						}
						break;
					}
				}
			}
			finally
			{
				if (setTimeout != null)
				{
					int num11 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_bed74a20bc6648fab6800acd64e4559d != 0)
					{
						num11 = 0;
					}
					while (true)
					{
						switch (num11)
						{
						default:
							RgOqbWpk2dqE60G9eQE(setTimeout);
							num11 = 0;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_5028d2018b41471c962aaca947e33b9d == 0)
							{
								num11 = 1;
							}
							continue;
						case 1:
							break;
						}
						break;
					}
				}
			}
		}
	}

	private void ExecuteWithLock(Action action)
	{
		//Discarded unreachable code: IL_0054, IL_010b, IL_0133, IL_0173, IL_0182, IL_018e, IL_019d, IL_01e3, IL_023c, IL_025b, IL_026a, IL_0287
		int num = 2;
		int num2 = num;
		ActiveUserSessionService activeUserSessionService = default(ActiveUserSessionService);
		bool lockTaken = default(bool);
		IUnitOfWork unitOfWork = default(IUnitOfWork);
		while (true)
		{
			switch (num2)
			{
			case 1:
				throw new ArgumentNullException((string)MrYFXQzVOm0PPB0m8p(-1965109395 ^ -1965112809));
			case 2:
				if (action != null)
				{
					activeUserSessionService = this;
					num2 = 4;
					continue;
				}
				num2 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_1bc92e0376794fc182b6e366eee82dbd == 0)
				{
					num2 = 0;
				}
				continue;
			case 4:
				lockTaken = false;
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_bed74a20bc6648fab6800acd64e4559d == 0)
				{
					num2 = 0;
				}
				continue;
			case 3:
				return;
			}
			try
			{
				Monitor.Enter(activeUserSessionService, ref lockTaken);
				int num3 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_97ec140e839b4bd5a711912170945a29 != 0)
				{
					num3 = 1;
				}
				while (true)
				{
					switch (num3)
					{
					case 1:
						unitOfWork = (IUnitOfWork)lMu9jA5XDx5SPLNsBSX(UnitOfWorkManager, string.Empty, true, IsolationLevel.Unspecified);
						num3 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8dab57df677749fba2d5364cf752799f == 0)
						{
							num3 = 0;
						}
						continue;
					}
					try
					{
						IDisposable disposable = (IDisposable)suOlfE5nUcxhssqqb64(_lockManager, MrYFXQzVOm0PPB0m8p(-1801396866 ^ -1801400076));
						int num4 = 1;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0a82cc1379bc48bbb836c94da8cb8564 == 0)
						{
							num4 = 1;
						}
						while (true)
						{
							switch (num4)
							{
							case 1:
								try
								{
									d5d6mO5iKyCej8wIOtK(action);
									int num5 = 0;
									if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_f6614d006512404f8cab65f09d3e1c89 != 0)
									{
										num5 = 0;
									}
									switch (num5)
									{
									case 0:
										break;
									}
								}
								finally
								{
									int num6;
									if (disposable == null)
									{
										num6 = 2;
										goto IL_0137;
									}
									goto IL_014d;
									IL_0137:
									switch (num6)
									{
									case 2:
										goto end_IL_0122;
									case 1:
										goto end_IL_0122;
									}
									goto IL_014d;
									IL_014d:
									RgOqbWpk2dqE60G9eQE(disposable);
									num6 = 1;
									if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_94a7beb9ab90455caa18ecaa3b17b19c == 0)
									{
										num6 = 1;
									}
									goto IL_0137;
									end_IL_0122:;
								}
								break;
							case 2:
								return;
							}
							COLv1G578vAymjD6Vol(unitOfWork);
							int num7 = 2;
							num4 = num7;
						}
					}
					finally
					{
						if (unitOfWork != null)
						{
							int num8 = 1;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_5adff34accb14bd183b62ef1a2f5f964 == 0)
							{
								num8 = 1;
							}
							while (true)
							{
								switch (num8)
								{
								case 1:
									RgOqbWpk2dqE60G9eQE(unitOfWork);
									num8 = 0;
									if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_e2be4970ad4d405ab7ed74c6b68c9f7d == 0)
									{
										num8 = 0;
									}
									continue;
								case 0:
									break;
								}
								break;
							}
						}
					}
				}
			}
			finally
			{
				int num9;
				if (!lockTaken)
				{
					num9 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_488725796a2e487f95c022f5056d8a88 != 0)
					{
						num9 = 0;
					}
					goto IL_0240;
				}
				goto IL_0275;
				IL_0275:
				F4lIag56YL0MjxHY1vx(activeUserSessionService);
				num9 = 2;
				goto IL_0240;
				IL_0240:
				switch (num9)
				{
				default:
					goto end_IL_021b;
				case 0:
					goto end_IL_021b;
				case 1:
					break;
				case 2:
					goto end_IL_021b;
				}
				goto IL_0275;
				end_IL_021b:;
			}
		}
	}

	private ActivePrivilegeUsersInfo IsCurrentPrivilege(AuthenticatedSessionInfo sessionInfo, EleWise.ELMA.Security.Models.IUser user)
	{
		//Discarded unreachable code: IL_0145, IL_0375, IL_0384
		int num = 2;
		string text = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					return ((IQuery)mEx8fTp6issVryqioMW(w8tcaV5N6784WoNVukY(w8tcaV5N6784WoNVukY(w8tcaV5N6784WoNVukY(w8tcaV5N6784WoNVukY(s5YJaBplyIT317nUfnM(((ISession)h9OInup55tCcX8O7MxT(SessionProvider, string.Empty)).CreateSQLQuery(text), false), MrYFXQzVOm0PPB0m8p(-848444002 ^ -848439884), 0, NHibernateUtil.Int32), MrYFXQzVOm0PPB0m8p(0x7DABA580 ^ 0x7DABB5CE), SecurityConstants.AdminUserUid, NHibernateUtil.Guid), MrYFXQzVOm0PPB0m8p(-1076846736 ^ -1076848420), S1NRo6pKC5lm38jW7Qc(sessionInfo.UserId), NHibernateUtil.Int64), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-730071140 ^ -730075152), _privilegeGroupId, NHibernateUtil.Int64), new AliasToBeanResultTransformer(JT8toip7ZtKvdPJunx8(typeof(ActivePrivilegeUsersInfo).TypeHandle)))).UniqueResult<ActivePrivilegeUsersInfo>();
				default:
					throw new ArgumentNullException((string)MrYFXQzVOm0PPB0m8p(-566078848 ^ -566077456));
				case 1:
					if (user != null)
					{
						goto end_IL_0012;
					}
					goto case 5;
				case 5:
					throw new ArgumentNullException((string)MrYFXQzVOm0PPB0m8p(0x46347DA6 ^ 0x4634704C));
				case 4:
					text = (string)C5IlQHpXGSGaFN7Q7kq(MrYFXQzVOm0PPB0m8p(0x416A5E3C ^ 0x416A53CA), new object[7]
					{
						zqFFjy5l84nGJTQ9m63(BTMIunpArlEyk2LFVsQ(_transform), string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-95913524 ^ -95914268), CUYDawpW8bm5XiB8TZm(BTMIunpArlEyk2LFVsQ(_transform), MrYFXQzVOm0PPB0m8p(0x6A79A716 ^ 0x6A79A898)), CUYDawpW8bm5XiB8TZm(BTMIunpArlEyk2LFVsQ(_transform), MrYFXQzVOm0PPB0m8p(0x1618182 ^ 0x1618E1C))), MrYFXQzVOm0PPB0m8p(--1130812004 ^ 0x4366DDCC), MrYFXQzVOm0PPB0m8p(0x67DFA65E ^ 0x67DFA9F0)),
						zqFFjy5l84nGJTQ9m63(BTMIunpArlEyk2LFVsQ(_transform), string.Format((string)MrYFXQzVOm0PPB0m8p(-1580392499 ^ -1580396423), CUYDawpW8bm5XiB8TZm(BTMIunpArlEyk2LFVsQ(_transform), MrYFXQzVOm0PPB0m8p(-1788380826 ^ -1788380548))), MrYFXQzVOm0PPB0m8p(-959661060 ^ -959663020), MrYFXQzVOm0PPB0m8p(0x40944BC4 ^ 0x4094446A)),
						CUYDawpW8bm5XiB8TZm(BTMIunpArlEyk2LFVsQ(_transform), MrYFXQzVOm0PPB0m8p(-731479136 ^ -731476868)),
						CUYDawpW8bm5XiB8TZm(_transform.Dialect, MrYFXQzVOm0PPB0m8p(0x28EBA022 ^ 0x28EBAFCA)),
						CUYDawpW8bm5XiB8TZm(BTMIunpArlEyk2LFVsQ(_transform), MrYFXQzVOm0PPB0m8p(0x1B3723C5 ^ 0x1B3733D5)),
						((Dialect)BTMIunpArlEyk2LFVsQ(_transform)).QuoteIfNeeded((string)MrYFXQzVOm0PPB0m8p(0x432996D0 ^ 0x432995CA)),
						CUYDawpW8bm5XiB8TZm(BTMIunpArlEyk2LFVsQ(_transform), MrYFXQzVOm0PPB0m8p(0xC66FB14 ^ 0xC66EB0C))
					});
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b54421a4e10b4c2fa10cef566e462fbd == 0)
					{
						num2 = 3;
					}
					break;
				case 2:
					if (sessionInfo != null)
					{
						num2 = 1;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b54421a4e10b4c2fa10cef566e462fbd != 0)
						{
							num2 = 0;
						}
						break;
					}
					goto default;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 4;
		}
	}

	internal ActiveUsersSessionInfo GetOtherUsersCount(AuthenticatedSessionInfo sessionInfo)
	{
		int num = 1;
		int num2 = num;
		string text = default(string);
		while (true)
		{
			switch (num2)
			{
			case 1:
				text = (string)C5IlQHpXGSGaFN7Q7kq(MrYFXQzVOm0PPB0m8p(-1084772212 ^ -1084776422), new object[5]
				{
					_transform.Dialect.InsertIf((string)x1FdeL5ZpWfDvfmABME(MrYFXQzVOm0PPB0m8p(-1718905545 ^ -1718904189), CUYDawpW8bm5XiB8TZm(BTMIunpArlEyk2LFVsQ(_transform), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5EE4A7B ^ 0x5EE4961))), (string)MrYFXQzVOm0PPB0m8p(0xD946FDB ^ 0xD946073), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-724676315 ^ -724672885)),
					CUYDawpW8bm5XiB8TZm(BTMIunpArlEyk2LFVsQ(_transform), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1B47BFA1 ^ 0x1B47BCBB)),
					CUYDawpW8bm5XiB8TZm(BTMIunpArlEyk2LFVsQ(_transform), MrYFXQzVOm0PPB0m8p(0x1869C442 ^ 0x1869C7AE)),
					_transform.Dialect.QuoteIfNeeded((string)MrYFXQzVOm0PPB0m8p(0x4E6718AE ^ 0x4E671A66)),
					CUYDawpW8bm5XiB8TZm(BTMIunpArlEyk2LFVsQ(_transform), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2104667969 ^ -2104664271))
				});
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b54421a4e10b4c2fa10cef566e462fbd == 0)
				{
					num2 = 0;
				}
				break;
			default:
				return ((IQuery)w8tcaV5N6784WoNVukY(((IQuery)w8tcaV5N6784WoNVukY(((IQuery)s5YJaBplyIT317nUfnM(LcJVihpnns7bN9qickt(h9OInup55tCcX8O7MxT(SessionProvider, string.Empty), text), false)).SetParameter((string)MrYFXQzVOm0PPB0m8p(-2037738356 ^ -2037735518), (object)0, (IType)(object)NHibernateUtil.Int32), MrYFXQzVOm0PPB0m8p(-737960346 ^ -737961326), rRFABopjw1K2oNWulWL(sessionInfo), NHibernateUtil.String)).SetParameter((string)MrYFXQzVOm0PPB0m8p(-192929954 ^ -192931598), (object)Convert.ToInt64(U2jIfVpJrVnXHKlFJYy(sessionInfo)), (IType)(object)NHibernateUtil.Int64), MrYFXQzVOm0PPB0m8p(0xD946FDB ^ 0xD947DA1), _adminId, NHibernateUtil.Int64)).SetResultTransformer((IResultTransformer)(object)new AliasToBeanResultTransformer(JT8toip7ZtKvdPJunx8(typeof(ActiveUsersSessionInfo).TypeHandle))).UniqueResult<ActiveUsersSessionInfo>();
			}
		}
	}

	private void UpsertSessionInfo(AuthenticatedSessionInfo sessionInfo)
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				LEWAMlpouRhmAlYtVro(KbHVUY5mwZ8PPJeKRwx(((IQuery)KbHVUY5mwZ8PPJeKRwx(T4hA8OpiUHTx0bDTHlN(w8tcaV5N6784WoNVukY(w8tcaV5N6784WoNVukY(((IQuery)T4hA8OpiUHTx0bDTHlN(DIDMCLpO73W78iQNMfC(T4hA8OpiUHTx0bDTHlN(w8tcaV5N6784WoNVukY(hWf8rwpzD2G1UDW4Efx(BFItdOpUp8nrwbW9W4q(((ISession)h9OInup55tCcX8O7MxT(SessionProvider, string.Empty)).GetNamedQuery((string)MrYFXQzVOm0PPB0m8p(-1687496463 ^ -1687500277)), v9MaEcpfyLkYersmVGF(AuthenticatedSessionInfo.Db.Fields.TicketUid, MrYFXQzVOm0PPB0m8p(0x84482CB ^ 0x84491FF)), cAyV5gpu8dJaUQst3ki(sessionInfo)), v9MaEcpfyLkYersmVGF(AuthenticatedSessionInfo.Db.Fields.Status, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x43ED0455 ^ 0x43ED1761)), (int)sessionInfo.Status), v9MaEcpfyLkYersmVGF(AuthenticatedSessionInfo.Db.Fields.Expiration, MrYFXQzVOm0PPB0m8p(0x397B0322 ^ 0x397B1016)), sessionInfo.Expiration, NHibernateUtil.DateTime), v9MaEcpfyLkYersmVGF(AuthenticatedSessionInfo.Db.Fields.SessionId, MrYFXQzVOm0PPB0m8p(-1788380826 ^ -1788384686)), sessionInfo.SessionId), v9MaEcpfyLkYersmVGF(AuthenticatedSessionInfo.Db.Fields.UserId, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1278809262 ^ -1278805914)), (long)U2jIfVpJrVnXHKlFJYy(sessionInfo)), v9MaEcpfyLkYersmVGF(AuthenticatedSessionInfo.Db.Fields.RemoteAddress, MrYFXQzVOm0PPB0m8p(0x50A2A0A3 ^ 0x50A2B397)), GFA5YQ5xewAwdfGFCmp(sessionInfo))).SetParameter((string)v9MaEcpfyLkYersmVGF(AuthenticatedSessionInfo.Db.Fields.CreationDate, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-426925384 ^ -426921588)), (object)rc8LjU5B0P1q8Mx5hOe(sessionInfo), (IType)(object)NHibernateUtil.DateTime), v9MaEcpfyLkYersmVGF(AuthenticatedSessionInfo.Db.Fields.LastActionDate, MrYFXQzVOm0PPB0m8p(-930147978 ^ -930151870)), FXeKtepaYBHAmUwWBoF(sessionInfo), NHibernateUtil.DateTime), v9MaEcpfyLkYersmVGF(AuthenticatedSessionInfo.Db.Fields.LastPingDate, MrYFXQzVOm0PPB0m8p(-230994601 ^ -230990237)), CV8O22pVijXW9Bq8VEp(sessionInfo), NHibernateUtil.DateTime), v9MaEcpfyLkYersmVGF(AuthenticatedSessionInfo.Db.Fields.LastActionInfo, MrYFXQzVOm0PPB0m8p(-434542700 ^ -434539360)), sessionInfo.LastActionInfo), MrYFXQzVOm0PPB0m8p(0x3E5BC59F ^ 0x3E5BD6DD), LauFFd5uulD8K6Ikvux(sessionInfo))).SetBoolean((string)MrYFXQzVOm0PPB0m8p(0x4BBFF2C6 ^ 0x4BBFE1AE), NnprEdpYxaBh7jr1tm0(sessionInfo)), MrYFXQzVOm0PPB0m8p(0x1869C442 ^ 0x1869D7D0), TThQ4kp4PDjLOcxttLF(sessionInfo)), false);
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a16ce287ba7944e2afcf4e52864ec01d == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				zoUJNKpHMx0makd15Ig(logger, MrYFXQzVOm0PPB0m8p(-726732645 ^ -726736371), new object[2] { sessionInfo.TicketUid, sessionInfo.SessionId });
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b128c216f9744fbcbc93a88cbe7b4554 == 0)
				{
					num2 = 1;
				}
				break;
			case 0:
				return;
			}
		}
	}

	private void ReloadSettings()
	{
		//Discarded unreachable code: IL_0065, IL_00a1, IL_00b2, IL_00d3, IL_00dd, IL_00ec
		int num = 7;
		int num2 = num;
		SecuritySettingsModule service = default(SecuritySettingsModule);
		TimeSpan? timeSpan = default(TimeSpan?);
		while (true)
		{
			TimeSpan? removePrivilegedUsersTimeoutTime;
			TimeSpan? removeOnActionTimeoutTime;
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 15:
				return;
			case 5:
				isPrivilegedLicense = service.Settings.IsPrivilegedLicense;
				num2 = 8;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_dffee0180fb244db9738339fa28792b4 != 0)
				{
					num2 = 2;
				}
				continue;
			case 10:
				removePrivilegedUsersTimeoutTime = timeSpan;
				break;
			case 2:
				if (!isPrivilegedLicense)
				{
					num2 = 9;
					continue;
				}
				goto case 4;
			case 12:
				removeOnActionTimeoutTime = timeSpan;
				goto IL_0211;
			case 7:
				service = Locator.GetService<SecuritySettingsModule>();
				num2 = 6;
				continue;
			case 1:
			case 9:
				timeSpan = null;
				num2 = 10;
				continue;
			case 16:
				return;
			case 4:
				if (!EQYZpb5aKE1jeIipNhe(service.Settings))
				{
					num2 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_c78060c4cac8419092e4610bf7a03750 != 0)
					{
						num2 = 1;
					}
					continue;
				}
				removePrivilegedUsersTimeoutTime = BkmySH5ReGaO8QR1qDe(service.Settings);
				break;
			case 13:
				if (!LcIXdR5jNP0I6acxV8g(service.Settings))
				{
					num2 = 14;
					continue;
				}
				removeOnActionTimeoutTime = Rib82e5H2HknidulGwB(service.Settings);
				goto IL_0211;
			case 8:
				_freezeTime = d3Awo85eoME3gR9ykJD(service.Settings);
				num2 = 11;
				continue;
			case 6:
				if (service == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_5c5fc9a9dec4418fa9513347a116bf27 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				goto case 3;
			case 14:
				timeSpan = null;
				num2 = 12;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_edc68bc1c90e495e835b4f28be0d6753 == 0)
				{
					num2 = 3;
				}
				continue;
			case 11:
				_removeOnPingTimeoutTime = bx1xBd5LegMo42DKg9V(service.Settings);
				num2 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a3b9996565fb40c18f26b204beedcb7f != 0)
				{
					num2 = 13;
				}
				continue;
			case 3:
				{
					if (service.Settings == null)
					{
						return;
					}
					num2 = 5;
					continue;
				}
				IL_0211:
				_removeOnActionTimeoutTime = removeOnActionTimeoutTime;
				num2 = 2;
				continue;
			}
			_removePrivilegedUsersTimeoutTime = removePrivilegedUsersTimeoutTime;
			num2 = 16;
		}
	}

	void IInitHandler.Init()
	{
	}

	void IInitHandler.InitComplete()
	{
		int num = 1;
		int num2 = num;
		IUserGroup userGroup = default(IUserGroup);
		while (true)
		{
			switch (num2)
			{
			default:
				Locator.GetServiceNotNull<IUnitOfWorkManager>();
				num2 = 5;
				break;
			case 7:
				return;
			case 2:
				userGroup = Locator.GetServiceNotNull<UserGroupManager>().Load(SecurityConstants.PrivilegeUsersGroupUid);
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_39a415f51fd045a981443759203cc0ad == 0)
				{
					num2 = 6;
				}
				break;
			case 1:
				_transform = Locator.GetServiceNotNull<ITransformationProvider>();
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_7fbc19cae8c8414894251bb8ae24a12e == 0)
				{
					num2 = 0;
				}
				break;
			case 8:
				_adminId = UserManager.Load(SecurityConstants.AdminUserUid).Id;
				num2 = 7;
				break;
			case 3:
				_cacheService = Locator.GetServiceNotNull<ICacheService>();
				num2 = 4;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0a82cc1379bc48bbb836c94da8cb8564 == 0)
				{
					num2 = 1;
				}
				break;
			case 5:
				_lockManager = Locator.GetServiceNotNull<ILockManager>();
				num2 = 3;
				break;
			case 4:
				_contextService = Locator.GetServiceNotNull<IContextBoundVariableService>();
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0f3686d2211943308639c187009d1b4a == 0)
				{
					num2 = 2;
				}
				break;
			case 6:
				_privilegeGroupId = userGroup.Id;
				num2 = 5;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_1c270ab2f5854923a44daf526a7f59af == 0)
				{
					num2 = 8;
				}
				break;
			}
		}
	}

	public ActiveUserSessionService()
	{
		//Discarded unreachable code: IL_0064, IL_0069
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
		logger = Logger.GetLogger(typeof(ActiveUserSessionService));
		_updateSessionsLock = new ReaderWriterLock();
		sessionsToUpdate = new ConcurrentDictionary<Guid, AuthenticatedSessionInfo>();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_c843c5b509d748f086ceb6be01690351 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static ActiveUserSessionService()
	{
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				CacheKey = (string)v9MaEcpfyLkYersmVGF(typeof(ActiveUserSessionService).FullName, MrYFXQzVOm0PPB0m8p(-1858473711 ^ -1858477399));
				num2 = 5;
				break;
			case 5:
				return;
			default:
				_removePrivilegedUsersTimeoutTime = null;
				num2 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_f0c2bdf066b1416088266cd84d9c3be2 == 0)
				{
					num2 = 1;
				}
				break;
			case 2:
				_freezeTime = TimeSpan.FromMinutes(3.0);
				num2 = 6;
				break;
			case 4:
				_removeOnActionTimeoutTime = null;
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_daaf990ff0c644fb99cfba0a043a9b93 != 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				XnC5H85wbcSKX20Wd95();
				num2 = 2;
				break;
			case 6:
				_removeOnPingTimeoutTime = KIwmRW52JxTvHia4B6O(1.0);
				num2 = 4;
				break;
			}
		}
	}

	internal static object MrYFXQzVOm0PPB0m8p(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void RgOqbWpk2dqE60G9eQE(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static bool m6ubY1fPZB5sAFuLK3()
	{
		return yEX26R9eNmpB2ECcwy == null;
	}

	internal static ActiveUserSessionService N6Nshy1eBona8PRyNn()
	{
		return yEX26R9eNmpB2ECcwy;
	}

	internal static bool ypxEgBppV5v4sUerSMn(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static object h9OInup55tCcX8O7MxT(object P_0, object P_1)
	{
		return ((ISessionProvider)P_0).GetSession((string)P_1);
	}

	internal static object BTMIunpArlEyk2LFVsQ(object P_0)
	{
		return ((ITransformationProvider)P_0).Dialect;
	}

	internal static object CUYDawpW8bm5XiB8TZm(object P_0, object P_1)
	{
		return ((Dialect)P_0).QuoteIfNeeded((string)P_1);
	}

	internal static object C5IlQHpXGSGaFN7Q7kq(object P_0, object P_1)
	{
		return string.Format((string)P_0, (object[])P_1);
	}

	internal static object LcJVihpnns7bN9qickt(object P_0, object P_1)
	{
		return ((ISession)P_0).CreateSQLQuery((string)P_1);
	}

	internal static object T4hA8OpiUHTx0bDTHlN(object P_0, object P_1, object P_2)
	{
		return ((IQuery)P_0).SetString((string)P_1, (string)P_2);
	}

	internal static Type JT8toip7ZtKvdPJunx8(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object mEx8fTp6issVryqioMW(object P_0, object P_1)
	{
		return ((IQuery)P_0).SetResultTransformer((IResultTransformer)P_1);
	}

	internal static object s5YJaBplyIT317nUfnM(object P_0, bool P_1)
	{
		return ((IQuery)P_0).CleanUpCache(P_1);
	}

	internal static void LZ5k4SpNTfqirqbTcqA(object P_0, object P_1, object P_2)
	{
		((ILogger)P_0).DebugFormat((string)P_1, (object[])P_2);
	}

	internal static Guid ll3GgGpZdyVI7SXjwjf(object P_0)
	{
		return ((EleWise.ELMA.Security.Models.IUser)P_0).Uid;
	}

	internal static int nMjBBRpxT7YDaOUoXvp(int P_0, int P_1)
	{
		return Math.Max(P_0, P_1);
	}

	internal static void i9JqIhpBEvCsJiTMj1U(object P_0, AuthenticatedSessionStatus P_1)
	{
		((AuthenticatedSessionInfo)P_0).Status = P_1;
	}

	internal static Guid cAyV5gpu8dJaUQst3ki(object P_0)
	{
		return ((AuthenticatedSessionInfo)P_0).TicketUid;
	}

	internal static object qcegSMpmx8oZ5ARveSi(object P_0, object P_1)
	{
		return string.Concat(P_0, P_1);
	}

	internal static void Aw8sD4pefH5U2hKGFIy(object P_0, object P_1, object P_2)
	{
		((IAbstractBoundVariableService)P_0).Set((string)P_1, P_2);
	}

	internal static void vvgFTjpL4PtRDy5vgHr(object P_0, int P_1)
	{
		((ReaderWriterLock)P_0).AcquireReaderLock(P_1);
	}

	internal static object rRFABopjw1K2oNWulWL(object P_0)
	{
		return ((AuthenticatedSessionInfo)P_0).SessionId;
	}

	internal static void zoUJNKpHMx0makd15Ig(object P_0, object P_1, object P_2)
	{
		((ILogger)P_0).InfoFormat((string)P_1, (object[])P_2);
	}

	internal static DateTime FXeKtepaYBHAmUwWBoF(object P_0)
	{
		return ((AuthenticatedSessionInfo)P_0).LastActionDate;
	}

	internal static bool hebrZVpRoYbsOtZBpPr(DateTime P_0, DateTime P_1)
	{
		return P_0 > P_1;
	}

	internal static void mkPeVDpwP4MQGqf5cXi(object P_0, DateTime P_1)
	{
		((AuthenticatedSessionInfo)P_0).LastActionDate = P_1;
	}

	internal static void uXPrI5p2W8EgHxpsaXO(object P_0, object P_1)
	{
		((AuthenticatedSessionInfo)P_0).LastActionInfo = (string)P_1;
	}

	internal static bool EInu0wpPGe6KkFWwlX9(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}

	internal static bool aBg9eWpvXk49oj2b1Ic(object P_0, object P_1)
	{
		return (string)P_0 != (string)P_1;
	}

	internal static void m2nY4NpCkKbIfIFR85m(object P_0)
	{
		((ReaderWriterLock)P_0).ReleaseReaderLock();
	}

	internal static object BFItdOpUp8nrwbW9W4q(object P_0, object P_1, Guid P_2)
	{
		return ((IQuery)P_0).SetGuid((string)P_1, P_2);
	}

	internal static int LEWAMlpouRhmAlYtVro(object P_0, bool P_1)
	{
		return ((IQuery)P_0).ExecuteUpdate(P_1);
	}

	internal static object U2jIfVpJrVnXHKlFJYy(object P_0)
	{
		return ((AuthenticatedSessionInfo)P_0).UserId;
	}

	internal static long S1NRo6pKC5lm38jW7Qc(object P_0)
	{
		return Convert.ToInt64(P_0);
	}

	internal static bool v27rQPptbs1VAyBIGgm(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static object EVJwEVphViDUbD3BXn7(object P_0, object P_1, object P_2)
	{
		return string.Format((string)P_0, P_1, P_2);
	}

	internal static object DIDMCLpO73W78iQNMfC(object P_0, object P_1, long P_2)
	{
		return ((IQuery)P_0).SetInt64((string)P_1, P_2);
	}

	internal static object OvQBjhpqJVtgVJu5U8i(object P_0, int P_1)
	{
		return ((IQuery)P_0).SetMaxResults(P_1);
	}

	internal static object e4hs4XpcA1BKFlxJbs2(object P_0, object P_1)
	{
		return ((IDataRecord)P_0)[(string)P_1];
	}

	internal static Guid uNGlA9pGQyTvapkqnk9(object P_0, object P_1)
	{
		return ((Dialect)P_0).GetGuid(P_1);
	}

	internal static void TbIQTnpFamuZPV70xk9(object P_0, Guid P_1)
	{
		((AuthenticatedSessionInfo)P_0).TicketUid = P_1;
	}

	internal static void XEG4NMp07xWfelkrwqh(object P_0, object P_1)
	{
		((AuthenticatedSessionInfo)P_0).SessionId = (string)P_1;
	}

	internal static void jcFv6RpEbNqjrLpOEch(object P_0, object P_1)
	{
		((AuthenticatedSessionInfo)P_0).UserId = P_1;
	}

	internal static void LtnSZTpDHXd9O4494Vy(object P_0, object P_1)
	{
		((AuthenticatedSessionInfo)P_0).RemoteAddress = (string)P_1;
	}

	internal static void Q4Te3cpMHQbEMuAQ5MD(object P_0, DateTime P_1)
	{
		((AuthenticatedSessionInfo)P_0).CreationDate = P_1;
	}

	internal static void GoWuMGpsTOsfVamyinC(object P_0, DateTime P_1)
	{
		((AuthenticatedSessionInfo)P_0).LastPingDate = P_1;
	}

	internal static bool NnprEdpYxaBh7jr1tm0(object P_0)
	{
		return ((AuthenticatedSessionInfo)P_0).LastActionIsCurrent;
	}

	internal static object ChmFkJpIUFIsy1q5L2x(object P_0)
	{
		return ((AuthenticatedSessionInfo)P_0).LastActionInfo;
	}

	internal static bool TThQ4kp4PDjLOcxttLF(object P_0)
	{
		return ((AuthenticatedSessionInfo)P_0).LastPingIsCurrent;
	}

	internal static DateTime CV8O22pVijXW9Bq8VEp(object P_0)
	{
		return ((AuthenticatedSessionInfo)P_0).LastPingDate;
	}

	internal static object sAVXwcpQXHJidpYuXZw(object P_0)
	{
		return ((Dialect)P_0).CurrentTimestamp;
	}

	internal static object aI0ruspdWp2DrUFn1BH(object P_0)
	{
		return ((ITransformationProvider)P_0).ParameterSeparator;
	}

	internal static DateTime XfoooIpTxNvQcl70yh0()
	{
		return DateTime.Now;
	}

	internal static int TmpJlbpgjpSWNlrTeBF()
	{
		return SavingActivityTimeoutTime;
	}

	internal static TimeSpan WPflTHp8ayFgelhlrAe(double P_0)
	{
		return TimeSpan.FromSeconds(P_0);
	}

	internal static bool iEBUpOprIJ2G7l4OVZ4(TimeSpan P_0, TimeSpan P_1)
	{
		return P_0 >= P_1;
	}

	internal static void odttP8p32pUfr8TROgT(object P_0)
	{
		((ReaderWriterLock)P_0).ReleaseWriterLock();
	}

	internal static TimeSpan BsUs1KpykBAPNmbttcv(DateTime P_0, DateTime P_1)
	{
		return P_0 - P_1;
	}

	internal static bool H6eSYypbVMFuLMCcRZA(TimeSpan P_0, TimeSpan P_1)
	{
		return P_0 > P_1;
	}

	internal static TimeSpan srHR7IpSJFHvYW6AQ6g(double P_0)
	{
		return TimeSpan.FromMinutes(P_0);
	}

	internal static object mKWO1Yp9FQumtfAnHGf(object P_0, object P_1, object P_2)
	{
		return ((Dialect)P_0).AddSecond((string)P_1, (string)P_2);
	}

	internal static object v9MaEcpfyLkYersmVGF(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static int XdKCx8p1TmnOD1FJ2MX(object P_0)
	{
		return ((ICollection<AuthenticatedSessionInfo>)P_0).Count;
	}

	internal static object hWf8rwpzD2G1UDW4Efx(object P_0, object P_1, int P_2)
	{
		return ((IQuery)P_0).SetInt32((string)P_1, P_2);
	}

	internal static int j8N0tC5kILvgsZqPbrx(object P_0)
	{
		return ((Dictionary<long, EleWise.ELMA.Security.Models.IUser>)P_0).Count;
	}

	internal static object d3WY855pWnDnb4j88ks()
	{
		return ComponentManager.Current;
	}

	internal static object j930ZG55NPMDaZ5eM3H(object P_0)
	{
		return ((ComponentManager)P_0).ModuleManager;
	}

	internal static object q8dwo95AP22Y00Qg9Uc(object P_0, Guid P_1)
	{
		return ((IModuleManager)P_0).FindUnitByUid(P_1);
	}

	internal static object PZZMer5WZhxJJpgUacX(object P_0)
	{
		return ((ILicensedModuleAssembly)P_0).LicenseUnit;
	}

	internal static object lMu9jA5XDx5SPLNsBSX(object P_0, object P_1, bool P_2, IsolationLevel P_3)
	{
		return ((IUnitOfWorkManager)P_0).Create((string)P_1, P_2, P_3);
	}

	internal static object suOlfE5nUcxhssqqb64(object P_0, object P_1)
	{
		return ((ILockManager)P_0).Lock((string)P_1);
	}

	internal static void d5d6mO5iKyCej8wIOtK(object P_0)
	{
		P_0();
	}

	internal static void COLv1G578vAymjD6Vol(object P_0)
	{
		((IUnitOfWork)P_0).Commit();
	}

	internal static void F4lIag56YL0MjxHY1vx(object P_0)
	{
		Monitor.Exit(P_0);
	}

	internal static object zqFFjy5l84nGJTQ9m63(object P_0, object P_1, object P_2, object P_3)
	{
		return ((Dialect)P_0).InsertIf((string)P_1, (string)P_2, (string)P_3);
	}

	internal static object w8tcaV5N6784WoNVukY(object P_0, object P_1, object P_2, object P_3)
	{
		return ((IQuery)P_0).SetParameter((string)P_1, P_2, (IType)P_3);
	}

	internal static object x1FdeL5ZpWfDvfmABME(object P_0, object P_1)
	{
		return string.Format((string)P_0, P_1);
	}

	internal static object GFA5YQ5xewAwdfGFCmp(object P_0)
	{
		return ((AuthenticatedSessionInfo)P_0).RemoteAddress;
	}

	internal static DateTime rc8LjU5B0P1q8Mx5hOe(object P_0)
	{
		return ((AuthenticatedSessionInfo)P_0).CreationDate;
	}

	internal static bool LauFFd5uulD8K6Ikvux(object P_0)
	{
		return ((AuthenticatedSessionInfo)P_0).CreationIsCurrent;
	}

	internal static object KbHVUY5mwZ8PPJeKRwx(object P_0, object P_1, bool P_2)
	{
		return ((IQuery)P_0).SetBoolean((string)P_1, P_2);
	}

	internal static TimeSpan d3Awo85eoME3gR9ykJD(object P_0)
	{
		return ((SecuritySettings)P_0).FreezeAuthenticationOnPingTimeoutTime;
	}

	internal static TimeSpan bx1xBd5LegMo42DKg9V(object P_0)
	{
		return ((SecuritySettings)P_0).SignOutOnPingTimeoutTime;
	}

	internal static bool LcIXdR5jNP0I6acxV8g(object P_0)
	{
		return ((SecuritySettings)P_0).SignOutOnActionTimeout;
	}

	internal static TimeSpan Rib82e5H2HknidulGwB(object P_0)
	{
		return ((SecuritySettings)P_0).SignOutOnActionTimeoutTime;
	}

	internal static bool EQYZpb5aKE1jeIipNhe(object P_0)
	{
		return ((SecuritySettings)P_0).SignOutPrivilegedUsers;
	}

	internal static TimeSpan BkmySH5ReGaO8QR1qDe(object P_0)
	{
		return ((SecuritySettings)P_0).SignOutPrivilegedUsersTimeoutTime;
	}

	internal static void XnC5H85wbcSKX20Wd95()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
	}

	internal static TimeSpan KIwmRW52JxTvHia4B6O(double P_0)
	{
		return TimeSpan.FromDays(P_0);
	}
}
