#define TRACE
using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Diagnostics.Attributes;
using EleWise.ELMA.Diagnostics.Counters;
using EleWise.ELMA.Diagnostics.Events;
using EleWise.ELMA.Diagnostics.Glimpse;
using EleWise.ELMA.Diagnostics.Logs;
using EleWise.ELMA.Diagnostics.Metrics;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Ranges;
using EleWise.ELMA.Modules;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Scheduling;
using EleWise.ELMA.Security;
using EleWise.ELMA.Services;
using EleWise.ELMA.Threading;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Stat;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Diagnostics;

[Service(Type = ComponentType.Server, EnableInterceptors = false, InjectProperties = true)]
[DeveloperApi(DeveloperApiType.Service)]
public sealed class DiagnosticsManager : IInitHandler, IDisposable
{
	[Component]
	private class SettingsLoader : IModuleContainerEvents
	{
		internal static object E8EOes8STR0issOrYKLn;

		public void Activated()
		{
			//Discarded unreachable code: IL_0056, IL_0065
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
				case 3:
					return;
				case 1:
					if (!Initialized)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				case 2:
					break;
				}
				wg0PPo8SOCdOObIeJ2Au(Instance);
				num2 = 3;
			}
		}

		public void Terminating()
		{
		}

		public SettingsLoader()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			LVTEXA8S2pnnENfkHv6O();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static void wg0PPo8SOCdOObIeJ2Au(object P_0)
		{
			((DiagnosticsManager)P_0).RefreshSettings();
		}

		internal static bool EK8FOg8SkxNKuKnRAS0s()
		{
			return E8EOes8STR0issOrYKLn == null;
		}

		internal static SettingsLoader YTJWHR8SnmVWDFo8dO4c()
		{
			return (SettingsLoader)E8EOes8STR0issOrYKLn;
		}

		internal static void LVTEXA8S2pnnENfkHv6O()
		{
			SingletonReader.JJCZtPuTvSt();
		}
	}

	[Component(Type = ComponentType.WebServer)]
	private class SettingsRefreshHandler : ISweepHandler, IThreadPoolContainer
	{
		private readonly object _sweepPool;

		internal static object Q4vXp78SeKCWi4K8A4hc;

		IThreadPool IThreadPoolContainer.Pool => (IThreadPool)_sweepPool;

		public SettingsRefreshHandler()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			gFMxmK8SN92PbJPxCWkS();
			base._002Ector();
			int num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
			{
				num = 0;
			}
			while (true)
			{
				switch (num)
				{
				default:
					return;
				case 1:
					_sweepPool = new ThreadSubPool(1);
					num = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 != 0)
					{
						num = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}

		public void Execute()
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
					I8C61f8SaJfpcyuYfJe4(ElEdwR8SpdJjcLHTHQla());
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				case 2:
					if (!thfi7D8S3f24BPRaDmUG())
					{
						return;
					}
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}

		internal static void gFMxmK8SN92PbJPxCWkS()
		{
			SingletonReader.JJCZtPuTvSt();
		}

		internal static bool sMEtqH8SPbopKbJRwR5Q()
		{
			return Q4vXp78SeKCWi4K8A4hc == null;
		}

		internal static SettingsRefreshHandler TuKZdO8S1XsaQWqdRNwR()
		{
			return (SettingsRefreshHandler)Q4vXp78SeKCWi4K8A4hc;
		}

		internal static bool thfi7D8S3f24BPRaDmUG()
		{
			return Initialized;
		}

		internal static object ElEdwR8SpdJjcLHTHQla()
		{
			return Instance;
		}

		internal static void I8C61f8SaJfpcyuYfJe4(object P_0)
		{
			((DiagnosticsManager)P_0).RefreshSettings();
		}
	}

	internal static class Helper
	{
		internal static Helper eMIWT18SDbBYTXU4UZ55;

		internal static void StartCallHelper(AbstractCallInfo callInfo)
		{
			//Discarded unreachable code: IL_011a, IL_0129, IL_015d, IL_0170, IL_017f, IL_01b6, IL_01c5, IL_01d5, IL_02d9, IL_035c, IL_036b
			int num = 3;
			int num2 = num;
			object obj = default(object);
			Type type3 = default(Type);
			DiagnosticEventsAttribute attribute = default(DiagnosticEventsAttribute);
			Type type2 = default(Type);
			while (true)
			{
				switch (num2)
				{
				case 1:
					return;
				case 3:
					if (callInfo == null)
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e != 0)
						{
							num2 = 2;
						}
					}
					else
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
						{
							num2 = 0;
						}
					}
					continue;
				case 2:
					return;
				}
				try
				{
					int num3;
					if (qMJaB68S456FBsgRAtba(callInfo) == null)
					{
						num3 = 8;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
						{
							num3 = 5;
						}
						goto IL_0077;
					}
					goto IL_0101;
					IL_0077:
					while (true)
					{
						switch (num3)
						{
						default:
							return;
						case 0:
							return;
						case 3:
							return;
						case 8:
							return;
						case 9:
							return;
						case 11:
						{
							JhcJSE8S0CTiIGZdmrPe(b6tibn8SxJaNP6iia7Q7(), obj as DiagnosticsEvent);
							int num4 = 9;
							num3 = num4;
							continue;
						}
						case 15:
							type3 = null;
							num3 = 12;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
							{
								num3 = 8;
							}
							continue;
						case 10:
							break;
						case 12:
							attribute = AttributeHelper<DiagnosticEventsAttribute>.GetAttribute(type2, inherited: true);
							num3 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
							{
								num3 = 1;
							}
							continue;
						case 6:
						case 14:
							if (!rg4WWy8SAJkpsEihqb5p(type3, null))
							{
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
								{
									num3 = 0;
								}
								continue;
							}
							goto case 4;
						case 2:
							type3 = A9GZXZ8SHLHPCj10Zlds(attribute);
							num3 = 9;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
							{
								num3 = 14;
							}
							continue;
						case 5:
							if (rg4WWy8SAJkpsEihqb5p(A9GZXZ8SHLHPCj10Zlds(attribute), null))
							{
								num3 = 2;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
								{
									num3 = 0;
								}
								continue;
							}
							goto case 6;
						case 1:
							if (attribute == null)
							{
								num3 = 13;
								continue;
							}
							goto case 5;
						case 4:
							obj = c5kj8k8S7p6tctigg0Fi(type3, new object[1] { callInfo });
							num3 = 7;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0)
							{
								num3 = 11;
							}
							continue;
						case 16:
							goto IL_026c;
						case 7:
						case 13:
							type3 = callStartEventTypes.GetOrAdd(type2, (Type type) => AbstractCallStartEventType.MakeGenericType(type));
							num3 = 6;
							continue;
						}
						break;
					}
					goto IL_0101;
					IL_026c:
					type2 = callInfo.GetType();
					num3 = 15;
					goto IL_0077;
					IL_0101:
					if (!LK8pwy8S6OXLHpQIIOJX())
					{
						num3 = 3;
						goto IL_0077;
					}
					goto IL_026c;
				}
				catch (Exception exception)
				{
					int num5 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
					{
						num5 = 0;
					}
					while (true)
					{
						switch (num5)
						{
						case 2:
							return;
						case 1:
							((ILogger)rWvJEY8Sm9PDA4tFZHvW(Instance)).Error(duUFvH8SM7q46Vq7wapC(X73T3H8Sy0FYWiGuWNR8(-218496594 ^ -218223586)), exception);
							num5 = 2;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
							{
								num5 = 2;
							}
							continue;
						}
						if (!LK8pwy8S6OXLHpQIIOJX())
						{
							return;
						}
						num5 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
						{
							num5 = 1;
						}
					}
				}
			}
		}

		internal static void StopCallHelper(AbstractCallInfo callInfo)
		{
			//Discarded unreachable code: IL_0035, IL_0044, IL_00cc, IL_00db, IL_0163, IL_016d, IL_017c, IL_018c, IL_01c6, IL_026b, IL_02db, IL_034e, IL_035d
			int num = 4;
			int num2 = num;
			Type type2 = default(Type);
			DiagnosticEventsAttribute attribute = default(DiagnosticEventsAttribute);
			Type type4 = default(Type);
			object obj = default(object);
			while (true)
			{
				switch (num2)
				{
				case 4:
					if (callInfo != null)
					{
						num2 = 3;
						continue;
					}
					return;
				case 2:
					return;
				case 1:
					return;
				case 3:
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
					{
						num2 = 0;
					}
					continue;
				}
				try
				{
					if (qMJaB68S456FBsgRAtba(callInfo) == null)
					{
						return;
					}
					int num3 = 4;
					while (true)
					{
						int num4;
						Type orAdd;
						Type type3;
						switch (num3)
						{
						case 8:
							type2 = callInfo.GetType();
							num3 = 7;
							break;
						case 16:
							attribute = AttributeHelper<DiagnosticEventsAttribute>.GetAttribute(type2, inherited: true);
							num3 = 9;
							break;
						case 7:
							type4 = null;
							num4 = 16;
							goto IL_0075;
						case 12:
						case 14:
							if (TCUEUe8SJ5p4qInOZgbo(callInfo) != null)
							{
								num3 = 10;
								break;
							}
							orAdd = callEndEventTypes.GetOrAdd(type2, (Type type) => AbstractCallEndEventType.MakeGenericType(type));
							goto IL_029e;
						case 5:
							if (TCUEUe8SJ5p4qInOZgbo(callInfo) == null)
							{
								num3 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
								{
									num3 = 6;
								}
								break;
							}
							goto case 1;
						case 1:
							type3 = attribute.ErrorEvent;
							goto IL_0228;
						case 2:
							return;
						case 4:
							if (!LK8pwy8S6OXLHpQIIOJX())
							{
								num3 = 2;
								break;
							}
							goto case 8;
						default:
							if (rg4WWy8SAJkpsEihqb5p(type4, null))
							{
								num3 = 15;
								break;
							}
							return;
						case 9:
							if (attribute == null)
							{
								num4 = 12;
								goto IL_0075;
							}
							goto case 5;
						case 15:
							obj = c5kj8k8S7p6tctigg0Fi(type4, new object[1] { callInfo });
							num3 = 3;
							break;
						case 3:
							((DiagnosticsManager)b6tibn8SxJaNP6iia7Q7()).OnEvent(obj as DiagnosticsEvent);
							num3 = 13;
							break;
						case 6:
							type3 = SShM6j8S9QynKtfPxyJ5(attribute);
							goto IL_0228;
						case 10:
							orAdd = callErrorEventTypes.GetOrAdd(type2, (Type type) => AbstractCallErrorEventType.MakeGenericType(type));
							goto IL_029e;
						case 13:
							return;
							IL_0228:
							type4 = type3;
							num4 = 11;
							goto IL_0075;
							IL_0075:
							num3 = num4;
							break;
							IL_029e:
							type4 = orAdd;
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
							{
								num3 = 0;
							}
							break;
						}
					}
				}
				catch (Exception ex)
				{
					int num5 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0)
					{
						num5 = 1;
					}
					while (true)
					{
						switch (num5)
						{
						default:
							return;
						case 1:
							if (LK8pwy8S6OXLHpQIIOJX())
							{
								num5 = 2;
								break;
							}
							return;
						case 2:
							LtpVbi8SdS9pdhEUWa4E(((DiagnosticsManager)b6tibn8SxJaNP6iia7Q7()).Logger, duUFvH8SM7q46Vq7wapC(X73T3H8Sy0FYWiGuWNR8(-87337865 ^ -87066169)), ex);
							num5 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
							{
								num5 = 0;
							}
							break;
						case 0:
							return;
						}
					}
				}
			}
		}

		internal static object qMJaB68S456FBsgRAtba(object P_0)
		{
			return ((AbstractCallInfo)P_0).ContextInfo;
		}

		internal static bool LK8pwy8S6OXLHpQIIOJX()
		{
			return Initialized;
		}

		internal static Type A9GZXZ8SHLHPCj10Zlds(object P_0)
		{
			return ((DiagnosticEventsAttribute)P_0).StartEvent;
		}

		internal static bool rg4WWy8SAJkpsEihqb5p(Type P_0, Type P_1)
		{
			return P_0 != P_1;
		}

		internal static object c5kj8k8S7p6tctigg0Fi(Type P_0, object P_1)
		{
			return Activator.CreateInstance(P_0, (object[])P_1);
		}

		internal static object b6tibn8SxJaNP6iia7Q7()
		{
			return Instance;
		}

		internal static void JhcJSE8S0CTiIGZdmrPe(object P_0, object P_1)
		{
			((DiagnosticsManager)P_0).OnEvent((DiagnosticsEvent)P_1);
		}

		internal static object rWvJEY8Sm9PDA4tFZHvW(object P_0)
		{
			return ((DiagnosticsManager)P_0).Logger;
		}

		internal static object X73T3H8Sy0FYWiGuWNR8(int _0020)
		{
			return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}

		internal static object duUFvH8SM7q46Vq7wapC(object P_0)
		{
			return SR.T((string)P_0);
		}

		internal static bool eGZXmJ8Stj79RVRgLVbw()
		{
			return eMIWT18SDbBYTXU4UZ55 == null;
		}

		internal static Helper KvjLGN8SwlZlU8SMZ1cx()
		{
			return eMIWT18SDbBYTXU4UZ55;
		}

		internal static object TCUEUe8SJ5p4qInOZgbo(object P_0)
		{
			return ((AbstractCallInfo)P_0).Exception;
		}

		internal static Type SShM6j8S9QynKtfPxyJ5(object P_0)
		{
			return ((DiagnosticEventsAttribute)P_0).EndEvent;
		}

		internal static void LtpVbi8SdS9pdhEUWa4E(object P_0, object P_1, object P_2)
		{
			((ILogger)P_0).Error(P_1, (Exception)P_2);
		}
	}

	private static readonly ConcurrentDictionary<Type, Type> callStartEventTypes;

	private static readonly ConcurrentDictionary<Type, Type> callEndEventTypes;

	private static readonly ConcurrentDictionary<Type, Type> callErrorEventTypes;

	private readonly GlimpseHelper glimpseHelper;

	private static DiagnosticsManager _instance;

	private readonly ConcurrentBag<CallContextInfo> activeContext;

	private static AsyncLocal<CallContextInfo> currentContext;

	private static bool _enabled;

	private bool _countersInitializeInvoked;

	private bool _countersInitialized;

	private bool _countersEnabled;

	private string _folder;

	private DiagnosticsSettings _settings;

	private Dictionary<Type, IPerformanceCounter> _counters;

	private ILogger _logger;

	private DiagnosticsLogManager _logManager;

	private MetricsContainer _metrics;

	private IEnumerable<IMetricAggregator> metricAggregators;

	private IEnumerable<IDiagnosticsEventProcessor> _eventProcessors;

	private static readonly Type AbstractCallStartEventType;

	private static readonly Type AbstractCallEndEventType;

	private static readonly Type AbstractCallErrorEventType;

	internal static DiagnosticsManager zlvdFFEoDsblYpiVC5rQ;

	public static DiagnosticsManager Instance
	{
		get
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					throw new InvalidOperationException((string)GFrT5REo6ZlxcEniDpry(kvor04Eo4Cc5Fia7LVfg(-2099751081 ^ -2099480039)));
				case 1:
					if (_instance != null)
					{
						return _instance;
					}
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public static bool Initialized => _instance != null;

	public static bool Enabled
	{
		get
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return _enabled;
				case 1:
					if (_instance == null)
					{
						return false;
					}
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public string Folder => _folder;

	public DiagnosticsSettings Settings => _settings;

	public MetricsContainer Metrics => _metrics;

	public DiagnosticsLogManager LogManager => _logManager;

	public bool CountersEnabled
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
					return _countersEnabled;
				case 1:
					InitCounters();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				if (_countersInitialized)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
					{
						num2 = 2;
					}
					continue;
				}
				return false;
			}
		}
	}

	private ILogger Logger => _logger;

	public event DiagnosticsEventHandler EventOccured
	{
		[CompilerGenerated]
		add
		{
			int num = 4;
			int num2 = num;
			DiagnosticsEventHandler diagnosticsEventHandler2 = default(DiagnosticsEventHandler);
			DiagnosticsEventHandler diagnosticsEventHandler = default(DiagnosticsEventHandler);
			DiagnosticsEventHandler value2 = default(DiagnosticsEventHandler);
			while (true)
			{
				switch (num2)
				{
				case 1:
					if ((object)diagnosticsEventHandler2 == diagnosticsEventHandler)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0)
						{
							num2 = 5;
						}
						break;
					}
					goto case 3;
				case 4:
					diagnosticsEventHandler2 = this.EventOccured;
					num2 = 3;
					break;
				case 5:
					return;
				case 2:
					value2 = (DiagnosticsEventHandler)RH6HDREb8Ai3yQLlnl5O(diagnosticsEventHandler, value);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0)
					{
						num2 = 0;
					}
					break;
				case 3:
					diagnosticsEventHandler = diagnosticsEventHandler2;
					num2 = 2;
					break;
				default:
					diagnosticsEventHandler2 = Interlocked.CompareExchange(ref this.EventOccured, value2, diagnosticsEventHandler);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
		[CompilerGenerated]
		remove
		{
			int num = 4;
			DiagnosticsEventHandler diagnosticsEventHandler2 = default(DiagnosticsEventHandler);
			DiagnosticsEventHandler diagnosticsEventHandler = default(DiagnosticsEventHandler);
			DiagnosticsEventHandler value2 = default(DiagnosticsEventHandler);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 3:
						diagnosticsEventHandler2 = diagnosticsEventHandler;
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0)
						{
							num2 = 5;
						}
						continue;
					case 5:
						value2 = (DiagnosticsEventHandler)sIuLh1EbZWHlWOj4IZKr(diagnosticsEventHandler2, value);
						num2 = 2;
						continue;
					case 2:
						diagnosticsEventHandler = Interlocked.CompareExchange(ref this.EventOccured, value2, diagnosticsEventHandler2);
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 != 0)
						{
							num2 = 0;
						}
						continue;
					case 1:
						return;
					case 4:
						break;
					default:
						if ((object)diagnosticsEventHandler == diagnosticsEventHandler2)
						{
							num2 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc != 0)
							{
								num2 = 0;
							}
							continue;
						}
						goto case 3;
					}
					break;
				}
				diagnosticsEventHandler = this.EventOccured;
				num = 3;
			}
		}
	}

	public static object Point(string message)
	{
		//Discarded unreachable code: IL_0035
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (message == null)
				{
					num2 = 3;
					continue;
				}
				break;
			case 2:
				if (Enabled)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
					{
						num2 = 1;
					}
					continue;
				}
				goto default;
			default:
				return null;
			case 4:
				break;
			}
			WEkjNdEoA5oqY5TNT0x3(cfEwLOEoHIORnHXTg734(), message);
			num2 = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0)
			{
				num2 = 0;
			}
		}
	}

	[DebuggerHidden]
	[CanBeNull]
	public static TCallInfo StartCall<TCallInfo>(Func<TCallInfo> callInfoCreator) where TCallInfo : AbstractCallInfo, IEmptyCallInfo, new()
	{
		CallContextInfo callContextInfo = (Enabled ? Instance.GetCurrentDiagnosticSession() : null);
		TCallInfo val = null;
		if (callContextInfo != null && callInfoCreator != null)
		{
			try
			{
				val = callInfoCreator();
			}
			catch (Exception exception)
			{
				val = null;
				EleWise.ELMA.Logging.Logger.Log.Error(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xA592A41 ^ 0xA5D07F1)), exception);
			}
		}
		if (Initialized && callContextInfo != null && callInfoCreator != null && val != null)
		{
			return Instance.StartCall(val, callContextInfo);
		}
		return null;
	}

	[DebuggerHidden]
	public static void StartCall<TCallInfo>(Func<TCallInfo> callInfoCreator, Action action) where TCallInfo : AbstractCallInfo, IEmptyCallInfo, new()
	{
		if (callInfoCreator == null)
		{
			action();
			return;
		}
		using TCallInfo val = StartCall(callInfoCreator);
		try
		{
			action();
		}
		catch (Exception exception)
		{
			if (val != null)
			{
				val.Exception = exception;
			}
			throw;
		}
	}

	[AsyncStateMachine(typeof(_003CStartAsyncCall_003Ed__12<>))]
	[DebuggerHidden]
	public static Task StartAsyncCall<TCallInfo>(Func<TCallInfo> callInfoCreator, Func<CancellationToken, Task> action, CancellationToken cancellationToken) where TCallInfo : IEmptyCallInfo, AbstractCallInfo, new()
	{
		_003CStartAsyncCall_003Ed__12<TCallInfo> stateMachine = default(_003CStartAsyncCall_003Ed__12<TCallInfo>);
		stateMachine.callInfoCreator = callInfoCreator;
		stateMachine.action = action;
		stateMachine.cancellationToken = cancellationToken;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		stateMachine._003C_003E1__state = -1;
		AsyncTaskMethodBuilder _003C_003Et__builder = stateMachine._003C_003Et__builder;
		_003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[CanBeNull]
	public static AbstractCallInfo StartCall(AbstractCallInfo callInfo)
	{
		//Discarded unreachable code: IL_0072, IL_007c
		int num = 2;
		int num2 = num;
		CallContextInfo callContextInfo = default(CallContextInfo);
		while (true)
		{
			object obj;
			switch (num2)
			{
			case 5:
				if (callInfo != null)
				{
					num2 = 4;
					continue;
				}
				goto IL_0094;
			case 2:
				if (D7eFTsEo75UZYJP0RHcU())
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
					{
						num2 = 1;
					}
					continue;
				}
				goto case 6;
			case 6:
				obj = null;
				break;
			default:
				return Instance.StartCall(callInfo, callContextInfo);
			case 4:
				if (callContextInfo != null)
				{
					num2 = 3;
					continue;
				}
				goto IL_0094;
			case 3:
				if (D7eFTsEo75UZYJP0RHcU())
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e != 0)
					{
						num2 = 0;
					}
					continue;
				}
				goto IL_0094;
			case 1:
				{
					obj = s0gqoCEox6ORDoc2gbdF(cfEwLOEoHIORnHXTg734());
					break;
				}
				IL_0094:
				return null;
			}
			callContextInfo = (CallContextInfo)obj;
			num2 = 5;
		}
	}

	public static void StopCall(AbstractCallInfo callInfo, Exception ex = null)
	{
		//Discarded unreachable code: IL_006f, IL_00c6, IL_00e9, IL_00f8, IL_0172, IL_0181, IL_01b1, IL_01c0
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 4:
				return;
			case 0:
				return;
			case 2:
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				try
				{
					jj1vamEo0BbxV7NPRFYI(callInfo, ex);
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
					{
						num3 = 0;
					}
					while (true)
					{
						switch (num3)
						{
						case 1:
							return;
						}
						pdbbSQEomoVj2vV4GTNW(callInfo);
						num3 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0)
						{
							num3 = 1;
						}
					}
				}
				catch (Exception exception)
				{
					int num4 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0)
					{
						num4 = 3;
					}
					while (true)
					{
						switch (num4)
						{
						default:
							return;
						case 0:
							return;
						case 2:
							return;
						case 3:
							if (!ap6D33EoymnnryL7eNbO())
							{
								num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
								{
									num4 = 0;
								}
								continue;
							}
							break;
						case 1:
							break;
						}
						Instance.Logger.Error(SR.T((string)kvor04Eo4Cc5Fia7LVfg(0x66F566B6 ^ 0x66F14B06)), exception);
						num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0)
						{
							num4 = 2;
						}
					}
				}
			case 3:
				if (callInfo == null)
				{
					return;
				}
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	internal static Guid? GetCurrentCallContextUid()
	{
		if (!Enabled)
		{
			return null;
		}
		return Instance.GetCurrentDiagnosticSession()?.Uid;
	}

	internal static long? GetCurrentCallId()
	{
		if (!Enabled)
		{
			return null;
		}
		CallContextInfo currentDiagnosticSession = Instance.GetCurrentDiagnosticSession();
		if (currentDiagnosticSession == null)
		{
			return null;
		}
		if (currentDiagnosticSession.CurrentCall != null)
		{
			return currentDiagnosticSession.CurrentCall.Id;
		}
		return null;
	}

	public DiagnosticsManager(ILogger logger, DiagnosticsLogManager logManager, IEnumerable<IDiagnosticsEventProcessor> processors)
	{
		SingletonReader.JJCZtPuTvSt();
		glimpseHelper = new GlimpseHelper();
		activeContext = new ConcurrentBag<CallContextInfo>();
		_settings = new DiagnosticsSettings();
		_counters = new Dictionary<Type, IPerformanceCounter>();
		_metrics = new MetricsContainer();
		base._002Ector();
		_eventProcessors = processors;
		_logger = logger ?? EleWise.ELMA.Logging.Logger.Log;
		_folder = Path.Combine(Path.GetDirectoryName(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1DE3DD89 ^ 0x1DE7F065), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1C9495B4 ^ 0x1C90B84C));
		if (!Directory.Exists(_folder))
		{
			Directory.CreateDirectory(_folder);
		}
		_logManager = logManager;
	}

	public void Dispose()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				_instance = null;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				return;
			case 1:
				if (_instance != this)
				{
					return;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal void ValidateSettings(DiagnosticsSettings settings)
	{
		//Discarded unreachable code: IL_003e, IL_0079, IL_0088, IL_0093, IL_00ce, IL_020e, IL_0246, IL_0255
		int num = 1;
		int num2 = num;
		IEnumerator<IDiagnosticsEventProcessor> enumerator = default(IEnumerator<IDiagnosticsEventProcessor>);
		_003C_003Ec__DisplayClass19_0 _003C_003Ec__DisplayClass19_ = default(_003C_003Ec__DisplayClass19_0);
		IDiagnosticsSettingsValidator diagnosticsSettingsValidator = default(IDiagnosticsSettingsValidator);
		EventProcessorsInfo eventProcessorsInfo = default(EventProcessorsInfo);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 3:
				return;
			case 6:
				return;
			case 5:
				enumerator = _eventProcessors.GetEnumerator();
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
				{
					num2 = 1;
				}
				break;
			case 2:
				try
				{
					while (true)
					{
						IL_0155:
						int num3;
						if (!Okkv6hEoJB4AhgQfdpRH(enumerator))
						{
							num3 = 3;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 != 0)
							{
								num3 = 3;
							}
							goto IL_0097;
						}
						goto IL_00d8;
						IL_00d8:
						_003C_003Ec__DisplayClass19_ = new _003C_003Ec__DisplayClass19_0();
						num3 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0)
						{
							num3 = 8;
						}
						goto IL_0097;
						IL_0097:
						while (true)
						{
							switch (num3)
							{
							case 3:
								return;
							case 7:
								break;
							case 9:
								diagnosticsSettingsValidator = _003C_003Ec__DisplayClass19_.ep as IDiagnosticsSettingsValidator;
								num3 = 4;
								continue;
							case 6:
								h19F4hEoMEQ1QnxyBsnY(diagnosticsSettingsValidator, eventProcessorsInfo);
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
								{
									num3 = 0;
								}
								continue;
							case 5:
								if (eventProcessorsInfo == null)
								{
									num3 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
									{
										num3 = 1;
									}
									continue;
								}
								goto case 6;
							default:
								goto IL_0155;
							case 8:
								_003C_003Ec__DisplayClass19_.ep = enumerator.Current;
								num3 = 9;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
								{
									num3 = 4;
								}
								continue;
							case 4:
								if (diagnosticsSettingsValidator != null)
								{
									num3 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0)
									{
										num3 = 2;
									}
									continue;
								}
								goto IL_0155;
							case 2:
								eventProcessorsInfo = settings.EventProcessorsInfos.FirstOrDefault(_003C_003Ec__DisplayClass19_._003CValidateSettings_003Eb__0);
								num3 = 5;
								continue;
							}
							break;
						}
						goto IL_00d8;
					}
				}
				finally
				{
					if (enumerator != null)
					{
						int num4 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
						{
							num4 = 0;
						}
						while (true)
						{
							switch (num4)
							{
							case 1:
								enumerator.Dispose();
								num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 != 0)
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
			case 1:
				if (settings == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 4;
			case 4:
				if (_eventProcessors == null)
				{
					num2 = 6;
					break;
				}
				goto case 5;
			}
		}
	}

	public void RefreshSettings()
	{
		//Discarded unreachable code: IL_006b, IL_00f1, IL_0149, IL_0158, IL_017c, IL_018b, IL_01f7, IL_0206, IL_0215, IL_026d, IL_027c, IL_0287, IL_0307, IL_04aa, IL_04e2, IL_05d7, IL_05f6, IL_0605, IL_0622, IL_0631
		int num = 2;
		int num2 = num;
		bool lockTaken = default(bool);
		DiagnosticsManager diagnosticsManager = default(DiagnosticsManager);
		DiagnosticsSettings settings = default(DiagnosticsSettings);
		DiagnosticsSettingsModule service = default(DiagnosticsSettingsModule);
		IEnumerator<IDiagnosticsEventProcessor> enumerator = default(IEnumerator<IDiagnosticsEventProcessor>);
		_003C_003Ec__DisplayClass20_0 _003C_003Ec__DisplayClass20_ = default(_003C_003Ec__DisplayClass20_0);
		EventProcessorsInfo eventProcessorsInfo = default(EventProcessorsInfo);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				lockTaken = false;
				num2 = 3;
				break;
			case 0:
				return;
			case 2:
				diagnosticsManager = this;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
				{
					num2 = 1;
				}
				break;
			case 3:
				try
				{
					Monitor.Enter(diagnosticsManager, ref lockTaken);
					int num3 = 8;
					while (true)
					{
						switch (num3)
						{
						case 13:
							return;
						case 17:
							return;
						case 18:
							_countersEnabled = IKKfM5Eor72B5hxyGEEb(_settings);
							num3 = 10;
							break;
						case 9:
							if (_enabled)
							{
								num3 = 19;
								break;
							}
							goto case 12;
						case 3:
						case 5:
						case 15:
						case 21:
							_settings = settings;
							num3 = 20;
							break;
						case 6:
							settings = service.Settings;
							num3 = 14;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f != 0)
							{
								num3 = 6;
							}
							break;
						case 7:
						case 19:
							if (!_enabled)
							{
								num3 = 21;
								break;
							}
							goto case 11;
						case 8:
							service = Locator.GetService<DiagnosticsSettingsModule>();
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e != 0)
							{
								num3 = 0;
							}
							break;
						case 2:
							yh1YBcEodZ5as4eVq223(_metrics, iLcRN3Eo9X1r3BvpHCsM());
							num3 = 15;
							break;
						default:
							if (service == null)
							{
								return;
							}
							num3 = 6;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
							{
								num3 = 2;
							}
							break;
						case 14:
							if (settings == null)
							{
								num3 = 5;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0)
								{
									num3 = 17;
								}
								break;
							}
							goto case 9;
						case 12:
							if (settings.Enabled)
							{
								num3 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
								{
									num3 = 2;
								}
								break;
							}
							goto case 7;
						case 4:
							try
							{
								while (true)
								{
									int num4;
									if (!enumerator.MoveNext())
									{
										num4 = 7;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
										{
											num4 = 6;
										}
										goto IL_028b;
									}
									goto IL_0463;
									IL_0463:
									_003C_003Ec__DisplayClass20_ = new _003C_003Ec__DisplayClass20_0();
									num4 = 8;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde != 0)
									{
										num4 = 4;
									}
									goto IL_028b;
									IL_028b:
									while (true)
									{
										switch (num4)
										{
										case 7:
											return;
										case 8:
											_003C_003Ec__DisplayClass20_.ep = enumerator.Current;
											num4 = 3;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
											{
												num4 = 3;
											}
											continue;
										case 1:
											if (eventProcessorsInfo != null)
											{
												num4 = 12;
												continue;
											}
											break;
										case 9:
										case 11:
											break;
										case 10:
											if (_enabled)
											{
												num4 = 3;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
												{
													num4 = 4;
												}
												continue;
											}
											break;
										case 12:
											LLTS5WEogesiXQaXOOt8(_003C_003Ec__DisplayClass20_.ep, eventProcessorsInfo, _enabled);
											num4 = 5;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
											{
												num4 = 6;
											}
											continue;
										case 3:
											EventOccured -= _003C_003Ec__DisplayClass20_.ep.Process;
											num4 = 2;
											continue;
										case 2:
											eventProcessorsInfo = settings.EventProcessorsInfos.FirstOrDefault(_003C_003Ec__DisplayClass20_._003CRefreshSettings_003Eb__0);
											num4 = 1;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc != 0)
											{
												num4 = 1;
											}
											continue;
										default:
											if (!JNTcR8Eojm2acA0qTdmR(settings))
											{
												num4 = 9;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
												{
													num4 = 11;
												}
												continue;
											}
											goto case 10;
										case 6:
											if (lClo2SEo5p31Kef2QXeE(eventProcessorsInfo))
											{
												num4 = 0;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
												{
													num4 = 0;
												}
												continue;
											}
											break;
										case 4:
											EventOccured += _003C_003Ec__DisplayClass20_.ep.Process;
											num4 = 9;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
											{
												num4 = 3;
											}
											continue;
										case 5:
											goto IL_0463;
										}
										break;
									}
								}
							}
							finally
							{
								if (enumerator != null)
								{
									int num5 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
									{
										num5 = 1;
									}
									while (true)
									{
										switch (num5)
										{
										case 1:
											p1jMDkEoY3vQUMpHyOge(enumerator);
											num5 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
											{
												num5 = 0;
											}
											continue;
										case 0:
											break;
										}
										break;
									}
								}
							}
						case 16:
							enumerator = _eventProcessors.GetEnumerator();
							num3 = 2;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
							{
								num3 = 4;
							}
							break;
						case 11:
							if (settings.Enabled)
							{
								num3 = 5;
								break;
							}
							goto case 1;
						case 1:
							_metrics.Periods.Add(new DateTimeRange(HNeKw6EolNJvs9RfYKVQ(_metrics), DateTime.Now));
							num3 = 3;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
							{
								num3 = 2;
							}
							break;
						case 10:
							if (_eventProcessors == null)
							{
								return;
							}
							num3 = 16;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 != 0)
							{
								num3 = 8;
							}
							break;
						case 20:
							_enabled = _settings.Enabled;
							num3 = 18;
							break;
						}
					}
				}
				finally
				{
					int num6;
					if (!lockTaken)
					{
						num6 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0)
						{
							num6 = 0;
						}
						goto IL_05db;
					}
					goto IL_0610;
					IL_0610:
					uq82RVEoLDU1VYwt7Rg4(diagnosticsManager);
					num6 = 2;
					goto IL_05db;
					IL_05db:
					switch (num6)
					{
					case 1:
						goto end_IL_05b6;
					case 2:
						goto end_IL_05b6;
					}
					goto IL_0610;
					end_IL_05b6:;
				}
			}
		}
	}

	public IEnumerable<CallContextInfo> GetCurrentCalls()
	{
		return activeContext.ToArray();
	}

	public CallContextInfo StartNewDiagnosticSession(string name)
	{
		return StartNewDiagnosticSessionInternal(name, isSubContext: true);
	}

	public CallContextInfo GetCurrentDiagnosticSession()
	{
		//Discarded unreachable code: IL_0082, IL_0091, IL_00a1, IL_0144, IL_018c, IL_01bc, IL_01cb
		int num = 4;
		int num2 = num;
		CallContextInfo callContextInfo = default(CallContextInfo);
		CallContextType contextType = default(CallContextType);
		while (true)
		{
			switch (num2)
			{
			case 2:
			case 5:
			case 12:
				return callContextInfo;
			case 3:
				contextType = GetContextType();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
				{
					num2 = 1;
				}
				break;
			case 7:
				callContextInfo = NwAMAIEos89Q3mIwwEjt(SXn6LmEoUGa9Gh6jmEnX(HttpContext.Current), kvor04Eo4Cc5Fia7LVfg(--1333735954 ^ 0x4F7B1C00)) as CallContextInfo;
				num2 = 11;
				break;
			case 14:
				if (uAMEobEocHRVeHwi0oCt(callContextInfo) == null)
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
					{
						num2 = 2;
					}
					break;
				}
				goto case 6;
			case 6:
				callContextInfo = callContextInfo.ChildContextInfo;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0)
				{
					num2 = 0;
				}
				break;
			case 13:
				goto IL_0129;
			case 4:
				callContextInfo = null;
				num2 = 3;
				break;
			case 8:
			case 9:
				throw new InvalidOperationException((string)GFrT5REo6ZlxcEniDpry(kvor04Eo4Cc5Fia7LVfg(0x61EC0CB8 ^ 0x61E822F4)));
			default:
				goto IL_0176;
			case 1:
				{
					switch (contextType)
					{
					case CallContextType.WebRequest:
						break;
					case CallContextType.Background:
					case CallContextType.BackgroundTask:
						goto IL_0129;
					case CallContextType.SubContext:
						goto IL_0176;
					default:
						goto IL_01ad;
					}
					goto case 7;
				}
				IL_01ad:
				num2 = 9;
				break;
				IL_0176:
				if (callContextInfo == null)
				{
					num2 = 12;
					break;
				}
				goto case 14;
				IL_0129:
				callContextInfo = currentContext.Value;
				num2 = 10;
				break;
			}
		}
	}

	public CallContextInfo CloseCurrentSession(Exception ex = null)
	{
		int num = 2;
		int num2 = num;
		_003C_003Ec__DisplayClass32_0 _003C_003Ec__DisplayClass32_ = default(_003C_003Ec__DisplayClass32_0);
		while (true)
		{
			CallContextInfo result;
			switch (num2)
			{
			case 3:
				if (_003C_003Ec__DisplayClass32_.currentContextInfo == null)
				{
					num2 = 14;
					break;
				}
				pQEqDFEozWqTitxX76QH(_003C_003Ec__DisplayClass32_.currentContextInfo, ex);
				num2 = 5;
				break;
			case 14:
				return null;
			case 5:
				if (GeHF9jEbFHAisGXOMb3m(_003C_003Ec__DisplayClass32_.currentContextInfo) != null)
				{
					num2 = 11;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
					{
						num2 = 0;
					}
					break;
				}
				RemoveCurrentCallContext();
				num2 = 9;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc != 0)
				{
					num2 = 6;
				}
				break;
			case 12:
				_003C_003Ec__DisplayClass32_.currentContextInfo = GetCurrentDiagnosticSession();
				num2 = 3;
				break;
			case 10:
				return _003C_003Ec__DisplayClass32_.currentContextInfo;
			case 7:
				CxwZXyEbot7NejWn62Z9(((CallContextInfo)GeHF9jEbFHAisGXOMb3m(_003C_003Ec__DisplayClass32_.currentContextInfo)).Metrics, AK1GJDEbWX2wM64MsFeU(_003C_003Ec__DisplayClass32_.currentContextInfo));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				_003C_003Ec__DisplayClass32_._003C_003E4__this = this;
				num2 = 9;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
				{
					num2 = 12;
				}
				break;
			case 8:
				CxwZXyEbot7NejWn62Z9(_metrics, AK1GJDEbWX2wM64MsFeU(_003C_003Ec__DisplayClass32_.currentContextInfo));
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
				{
					num2 = 4;
				}
				break;
			case 4:
				metricAggregators.ForEach(_003C_003Ec__DisplayClass32_._003CCloseCurrentSession_003Eb__1);
				num2 = 10;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
				{
					num2 = 6;
				}
				break;
			case 6:
				activeContext.TryTake(out result);
				num2 = 8;
				break;
			case 11:
				TSVbRGEbBOCqTT34Rl39(GeHF9jEbFHAisGXOMb3m(_003C_003Ec__DisplayClass32_.currentContextInfo), null);
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0)
				{
					num2 = 7;
				}
				break;
			case 2:
				_003C_003Ec__DisplayClass32_ = new _003C_003Ec__DisplayClass32_0();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 != 0)
				{
					num2 = 0;
				}
				break;
			case 9:
				result = null;
				num2 = 6;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0)
				{
					num2 = 3;
				}
				break;
			case 13:
				return _003C_003Ec__DisplayClass32_.currentContextInfo;
			default:
				metricAggregators.ForEach(_003C_003Ec__DisplayClass32_._003CCloseCurrentSession_003Eb__0);
				num2 = 13;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
				{
					num2 = 9;
				}
				break;
			}
		}
	}

	public void ClearStatistics()
	{
		//Discarded unreachable code: IL_0059, IL_00ba, IL_00d9, IL_0105
		int num = 1;
		MetricsContainer metrics = default(MetricsContainer);
		bool lockTaken = default(bool);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 4:
					return;
				case 2:
					try
					{
						Monitor.Enter(metrics, ref lockTaken);
						int num3 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
						{
							num3 = 0;
						}
						while (true)
						{
							switch (num3)
							{
							case 1:
								_metrics = new MetricsContainer();
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
								{
									num3 = 0;
								}
								continue;
							case 0:
								break;
							}
							break;
						}
					}
					finally
					{
						int num4;
						if (!lockTaken)
						{
							num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
							{
								num4 = 1;
							}
							goto IL_00be;
						}
						goto IL_00e3;
						IL_00e3:
						uq82RVEoLDU1VYwt7Rg4(metrics);
						num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
						{
							num4 = 0;
						}
						goto IL_00be;
						IL_00be:
						switch (num4)
						{
						default:
							goto end_IL_0099;
						case 1:
							goto end_IL_0099;
						case 2:
							break;
						case 0:
							goto end_IL_0099;
						}
						goto IL_00e3;
						end_IL_0099:;
					}
					break;
				case 1:
					metrics = _metrics;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
					{
						num2 = 0;
					}
					continue;
				default:
					lockTaken = false;
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
					{
						num2 = 2;
					}
					continue;
				case 5:
					break;
				case 3:
					goto end_IL_0012;
				}
				((IStatistics)qd12ToEbhGG0lRo2skTE(H9RQrCEbbd4T3KT4oJTh(Locator.GetServiceNotNull<SessionFactoryHolder>()))).Clear();
				num2 = 3;
				continue;
				end_IL_0012:
				break;
			}
			_metrics.StartTime = iLcRN3Eo9X1r3BvpHCsM();
			num = 4;
		}
	}

	public void OnEvent(DiagnosticsEvent e)
	{
		//Discarded unreachable code: IL_0079, IL_00ac, IL_0109, IL_01a0
		int num = 1;
		int num2 = num;
		DiagnosticsEventHandler eventOccured = default(DiagnosticsEventHandler);
		while (true)
		{
			switch (num2)
			{
			case 6:
				MJ4gf3EbCF8AK2qwKmqj(LogManager, e);
				num2 = 7;
				continue;
			case 3:
				try
				{
					X7j5HTEbflDDlKWrnOlx(eventOccured, e);
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0)
					{
						num3 = 0;
					}
					switch (num3)
					{
					case 0:
						break;
					}
				}
				catch (Exception ex)
				{
					int num4 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
					{
						num4 = 0;
					}
					while (true)
					{
						switch (num4)
						{
						case 1:
							bG4CT0EbQPuKMi3bRsqT(Logger, SR.T((string)kvor04Eo4Cc5Fia7LVfg(0x7E6E5A0B ^ 0x7E6A7485)), ex);
							num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
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
				break;
			case 4:
				e8L6dZEbEKSVueyhmOH4(glimpseHelper, e);
				num2 = 8;
				continue;
			case 1:
				if (!by43HJEbGDYRCPdQxNNU(Settings))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
					{
						num2 = 0;
					}
					continue;
				}
				goto case 4;
			case 2:
				if (eventOccured != null)
				{
					num2 = 3;
					continue;
				}
				break;
			case 7:
				return;
			default:
				eventOccured = this.EventOccured;
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
				{
					num2 = 2;
				}
				continue;
			case 5:
				break;
			}
			if (!Enabled)
			{
				break;
			}
			num2 = 6;
		}
	}

	public void MessagePoint(string message)
	{
		//Discarded unreachable code: IL_0047, IL_00c7, IL_00d6, IL_0102, IL_0168, IL_0177, IL_01c8, IL_01d7
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 4:
				try
				{
					CallContextInfo currentDiagnosticSession = GetCurrentDiagnosticSession();
					int num3 = 3;
					while (true)
					{
						switch (num3)
						{
						default:
							OnEvent(new MessagePointEvent(currentDiagnosticSession, message));
							num3 = 4;
							break;
						case 1:
							Trace.WriteLine(message);
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
							{
								num3 = 0;
							}
							break;
						case 3:
							if (currentDiagnosticSession == null)
							{
								num3 = 2;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
								{
									num3 = 2;
								}
								break;
							}
							goto case 1;
						case 2:
							return;
						case 4:
							return;
						}
					}
				}
				catch (Exception ex)
				{
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
					{
						num4 = 0;
					}
					while (true)
					{
						switch (num4)
						{
						case 1:
							return;
						}
						vUZYoWEbvtP5rrvDSJAR(Logger, SR.T((string)kvor04Eo4Cc5Fia7LVfg(0x49E27B8A ^ 0x49E6563A), ex));
						num4 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
						{
							num4 = 1;
						}
					}
				}
			case 2:
				if (message != null)
				{
					num2 = 5;
					break;
				}
				return;
			case 1:
				return;
			case 5:
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0)
				{
					num2 = 4;
				}
				break;
			case 0:
				return;
			case 3:
				if (!Enabled)
				{
					return;
				}
				num2 = 2;
				break;
			}
		}
	}

	public TCounter GetCounter<TCounter>() where TCounter : IPerformanceCounter
	{
		InitCounters();
		if (!_counters.TryGetValue(TypeOf<TCounter>.Raw, out var value))
		{
			throw new InvalidOperationException(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-309639236 ^ -309368476), TypeOf<TCounter>.Name));
		}
		return (TCounter)value;
	}

	public void WebRequestStart(HttpContext context)
	{
		//Discarded unreachable code: IL_003a, IL_007d, IL_008c, IL_0176, IL_01d6, IL_01e5
		switch (1)
		{
		case 0:
			break;
		case 1:
			try
			{
				int num;
				if (!D7eFTsEo75UZYJP0RHcU())
				{
					num = 5;
					goto IL_003e;
				}
				goto IL_0097;
				IL_003e:
				CallContextInfo callContextInfo = default(CallContextInfo);
				while (true)
				{
					switch (num)
					{
					case 2:
						return;
					case 5:
						return;
					default:
						OnEvent(new WebRequestStartEvent(callContextInfo, context));
						num = 2;
						continue;
					case 1:
						break;
					case 3:
						n1xSp8EbV1QV4Uf6aKVd(callContextInfo, (context.Request != null) ? RpWGsYEbIj2HgsP4HDYR(NFuqw8Ebu36QpghEgO6I(context)) : "");
						num = 4;
						continue;
					case 4:
						f1eqAEEbiAjAMOSdWMcB(callContextInfo, (NFuqw8Ebu36QpghEgO6I(context) != null) ? xRZZuTEbSDnBkWk9BVFJ(NFuqw8Ebu36QpghEgO6I(context)) : "");
						num = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
						{
							num = 0;
						}
						continue;
					}
					break;
				}
				goto IL_0097;
				IL_0097:
				callContextInfo = StartNewDiagnosticSessionInternal((context.Request != null) ? ((HttpRequest)NFuqw8Ebu36QpghEgO6I(context)).RawUrl : "");
				num = 3;
				goto IL_003e;
			}
			catch (Exception ex)
			{
				int num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
				{
					num2 = 0;
				}
				while (true)
				{
					switch (num2)
					{
					case 1:
						return;
					}
					vUZYoWEbvtP5rrvDSJAR(Logger, SR.T((string)kvor04Eo4Cc5Fia7LVfg(0x5A4C7B29 ^ 0x5A485699), ex));
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
					{
						num2 = 1;
					}
				}
			}
		}
	}

	public void WebRequestAuthorized(IUser user)
	{
		//Discarded unreachable code: IL_003a, IL_0049, IL_0083, IL_0152, IL_01a9, IL_01b8
		int num = 4;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 3:
				return;
			case 5:
				return;
			case 1:
				try
				{
					CallContextInfo currentDiagnosticSession = GetCurrentDiagnosticSession();
					int num3 = 2;
					while (true)
					{
						switch (num3)
						{
						case 4:
							return;
						case 2:
							if (currentDiagnosticSession != null)
							{
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
								{
									num3 = 1;
								}
								break;
							}
							goto default;
						case 1:
							cJEETMEbqxp3RqLSPVQk(currentDiagnosticSession, jTLxYZEbRAxogBNkbBUW(user));
							num3 = 3;
							break;
						default:
							OnEvent(new WebRequestAuthorizedEvent(currentDiagnosticSession, (HttpContext)Eyma3yEbTZE79B3YbiMN(), user));
							num3 = 4;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0)
							{
								num3 = 4;
							}
							break;
						case 3:
							TgrBllEbXVQf24xdPMW1(currentDiagnosticSession, K2JUeWEbKPEQ4oZ3f4dJ(user));
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
							{
								num3 = 0;
							}
							break;
						}
					}
				}
				catch (Exception ex)
				{
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
					{
						num4 = 1;
					}
					while (true)
					{
						switch (num4)
						{
						default:
							return;
						case 0:
							return;
						case 1:
							bG4CT0EbQPuKMi3bRsqT(Logger, GFrT5REo6ZlxcEniDpry(kvor04Eo4Cc5Fia7LVfg(-643786247 ^ -643517367)), ex);
							num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
							{
								num4 = 0;
							}
							break;
						}
					}
				}
			case 2:
				if (user != null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0)
					{
						num2 = 1;
					}
				}
				else
				{
					num2 = 5;
				}
				break;
			case 4:
				if (!D7eFTsEo75UZYJP0RHcU())
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0)
					{
						num2 = 3;
					}
					break;
				}
				goto case 2;
			}
		}
	}

	public void WebRequestEnd(HttpContext context)
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
				WebRequestError(context, null);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public void WebRequestError(HttpContext context, Exception ex)
	{
		//Discarded unreachable code: IL_003a, IL_0049, IL_00c8, IL_00ff, IL_0178, IL_0187, IL_0218, IL_0270
		int num = 5;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 3:
				return;
			case 4:
				if (context != null)
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
					{
						num2 = 2;
					}
					continue;
				}
				return;
			case 5:
				if (Enabled)
				{
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
					{
						num2 = 2;
					}
					continue;
				}
				return;
			case 1:
				return;
			case 2:
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0)
				{
					num2 = 0;
				}
				continue;
			}
			try
			{
				CallContextInfo callContextInfo = CloseCurrentSession(ex);
				int num3 = 3;
				while (true)
				{
					switch (num3)
					{
					case 5:
						return;
					case 7:
						return;
					case 4:
					case 6:
						if (ex != null)
						{
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f != 0)
							{
								num3 = 0;
							}
							break;
						}
						goto case 1;
					case 8:
						GetCounter<WebRequestAvgTimeCounter>().IncrementBy(callContextInfo.TotalTime.Ticks);
						num3 = 6;
						break;
					case 3:
						if (callContextInfo == null)
						{
							return;
						}
						num3 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
						{
							num3 = 2;
						}
						break;
					case 1:
						OnEvent(new WebRequestEndEvent(callContextInfo, context));
						num3 = 7;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0)
						{
							num3 = 0;
						}
						break;
					case 2:
						if (!CountersEnabled)
						{
							num3 = 4;
							break;
						}
						goto case 8;
					default:
						OnEvent(new WebRequestErrorEvent(callContextInfo, context));
						num3 = 5;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
						{
							num3 = 5;
						}
						break;
					}
				}
			}
			catch (Exception ex2)
			{
				int num4 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
				{
					num4 = 0;
				}
				while (true)
				{
					switch (num4)
					{
					case 1:
						return;
					}
					bG4CT0EbQPuKMi3bRsqT(Logger, GFrT5REo6ZlxcEniDpry(kvor04Eo4Cc5Fia7LVfg(--1418440330 ^ 0x548F833A)), ex2);
					num4 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 != 0)
					{
						num4 = 1;
					}
				}
			}
		}
	}

	internal void BackgroundThreadStart([NotNull] MethodInfo methodInfo, Guid createdParentContextInfoUid, string description)
	{
		//Discarded unreachable code: IL_0090, IL_015c, IL_01b3, IL_01c2, IL_01d2, IL_01e1
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 3:
				return;
			case 1:
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				if (!D7eFTsEo75UZYJP0RHcU())
				{
					return;
				}
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
				{
					num2 = 0;
				}
				continue;
			case 4:
				return;
			}
			try
			{
				CallContextInfo callContextInfo = StartNewDiagnosticSessionInternal((string)NCRMTQEberDK7VT66GIy(fhfIwLEbkdi1k6ZyYpxk(methodInfo.DeclaringType, methodInfo), jDWKlxEb2bil84gyFQjX(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-606654180 ^ -606644682), SSAfpxEbOaOmuCktGcGB(LUpwk1EbnIUlHlKnaEto(methodInfo), useFullName: true), kvor04Eo4Cc5Fia7LVfg(-2106517564 ^ -2106521480))));
				int num3 = 4;
				while (true)
				{
					switch (num3)
					{
					case 3:
						prNnH2EbNlbVCSxyRwKN(GetCounter<BackgroundThreadCounter>());
						num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0)
						{
							num3 = 0;
						}
						break;
					default:
						OnEvent(new BackgroundThreadStartEvent(callContextInfo));
						num3 = 2;
						break;
					case 5:
						if (CountersEnabled)
						{
							num3 = 3;
							break;
						}
						goto default;
					case 4:
						UptJ24EbPj39ioRfvarm(callContextInfo, description);
						num3 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
						{
							num3 = 1;
						}
						break;
					case 1:
						vjN1hjEb1NDJbao5ORnn(callContextInfo, createdParentContextInfoUid);
						num3 = 5;
						break;
					case 2:
						return;
					}
				}
			}
			catch (Exception exception)
			{
				int num4 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
				{
					num4 = 1;
				}
				while (true)
				{
					switch (num4)
					{
					default:
						return;
					case 1:
						Logger.Error(SR.T((string)kvor04Eo4Cc5Fia7LVfg(-542721635 ^ -542993363)), exception);
						num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
						{
							num4 = 0;
						}
						break;
					case 0:
						return;
					}
				}
			}
		}
	}

	internal void BackgroundThreadEnd(Exception ex = null)
	{
		//Discarded unreachable code: IL_0071, IL_00a4, IL_00b3, IL_0198, IL_01ef, IL_01fe
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			case 3:
				if (D7eFTsEo75UZYJP0RHcU())
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
					{
						num2 = 0;
					}
				}
				else
				{
					num2 = 2;
				}
				continue;
			case 1:
				return;
			}
			try
			{
				CallContextInfo callContextInfo = CloseCurrentSession(ex);
				int num3 = 3;
				while (true)
				{
					switch (num3)
					{
					case 2:
						return;
					case 6:
						return;
					case 5:
						OnEvent(new BackgroundThreadEndEvent(callContextInfo));
						num3 = 6;
						continue;
					case 4:
						LPg3gHEb3QqpD2OOpN7B(GetCounter<BackgroundThreadCounter>());
						num3 = 7;
						continue;
					case 3:
						if (callContextInfo == null)
						{
							return;
						}
						num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
						{
							num3 = 0;
						}
						continue;
					case 7:
						if (ex == null)
						{
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
							{
								num3 = 5;
							}
							continue;
						}
						break;
					default:
						if (CountersEnabled)
						{
							num3 = 2;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
							{
								num3 = 4;
							}
							continue;
						}
						goto case 7;
					case 1:
						break;
					}
					OnEvent(new BackgroundThreadErrorEvent(callContextInfo));
					num3 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
					{
						num3 = 0;
					}
				}
			}
			catch (Exception ex2)
			{
				int num4 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
				{
					num4 = 0;
				}
				while (true)
				{
					switch (num4)
					{
					case 1:
						return;
					}
					bG4CT0EbQPuKMi3bRsqT(Logger, GFrT5REo6ZlxcEniDpry(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x34185E55 ^ 0x341C73E5)), ex2);
					num4 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 != 0)
					{
						num4 = 1;
					}
				}
			}
		}
	}

	public void BackgroundTaskStart(string name, Type ownerType, string description)
	{
		//Discarded unreachable code: IL_0059, IL_0068, IL_00f0, IL_0196, IL_01ed, IL_01fc
		int num = 4;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 4:
				if (D7eFTsEo75UZYJP0RHcU())
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
					{
						num2 = 3;
					}
					break;
				}
				return;
			case 2:
				try
				{
					CallContextInfo callContextInfo = StartNewDiagnosticSessionInternal((string)NCRMTQEberDK7VT66GIy(name, WQgXJ2EbpAJdMfuFuMhF(ownerType, null) ? ((string)kvor04Eo4Cc5Fia7LVfg(-1822890472 ^ -1822916302) + DiagnosticsHelper.GetTypeName(ownerType, useFullName: true) + (string)kvor04Eo4Cc5Fia7LVfg(0x1C9495B4 ^ 0x1C90BA84)) : ""), isSubContext: true, CallContextType.BackgroundTask);
					int num3 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
					{
						num3 = 0;
					}
					while (true)
					{
						switch (num3)
						{
						case 2:
							OnEvent(new BackgroundTaskStartEvent(callContextInfo));
							num3 = 4;
							break;
						case 3:
							prNnH2EbNlbVCSxyRwKN(GetCounter<BackgroundTaskCounter>());
							num3 = 2;
							break;
						case 1:
							callContextInfo.Description = description;
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
							{
								num3 = 0;
							}
							break;
						default:
							if (CountersEnabled)
							{
								num3 = 3;
								break;
							}
							goto case 2;
						case 4:
							return;
						}
					}
				}
				catch (Exception ex)
				{
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
					{
						num4 = 1;
					}
					while (true)
					{
						switch (num4)
						{
						default:
							return;
						case 1:
							bG4CT0EbQPuKMi3bRsqT(Logger, GFrT5REo6ZlxcEniDpry(kvor04Eo4Cc5Fia7LVfg(-35995181 ^ -35722141)), ex);
							num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
							{
								num4 = 0;
							}
							break;
						case 0:
							return;
						}
					}
				}
			case 1:
				return;
			case 3:
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
				{
					num2 = 2;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public void BackgroundTaskEnd()
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
				BackgroundTaskError(null);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public void BackgroundTaskError(Exception ex)
	{
		//Discarded unreachable code: IL_00c2, IL_00d1, IL_0146, IL_018b, IL_01b6, IL_020e, IL_021d
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
				return;
			case 1:
				try
				{
					CallContextInfo callContextInfo = CloseCurrentSession(ex);
					int num3 = 7;
					while (true)
					{
						switch (num3)
						{
						case 3:
							OnEvent(new BackgroundTaskEndEvent(callContextInfo));
							num3 = 10;
							break;
						case 1:
						case 8:
							if (ex != null)
							{
								num3 = 6;
								break;
							}
							goto case 3;
						case 9:
							return;
						case 6:
						{
							OnEvent(new BackgroundTaskErrorEvent(callContextInfo));
							int num4 = 2;
							num3 = num4;
							break;
						}
						case 4:
							rGBLKxEbDwDuaynuiKpy(GetCounter<BackgroundAvgTimeCounter>(), YiV8OCEbapi9LotMMhs7(callContextInfo).Ticks);
							num3 = 8;
							break;
						default:
							if (!CountersEnabled)
							{
								num3 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
								{
									num3 = 1;
								}
								break;
							}
							goto case 5;
						case 2:
							return;
						case 5:
							LPg3gHEb3QqpD2OOpN7B(GetCounter<BackgroundTaskCounter>());
							num3 = 4;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0)
							{
								num3 = 3;
							}
							break;
						case 7:
							if (callContextInfo == null)
							{
								num3 = 9;
								break;
							}
							goto default;
						case 10:
							return;
						}
					}
				}
				catch (Exception ex2)
				{
					int num5 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 != 0)
					{
						num5 = 0;
					}
					while (true)
					{
						switch (num5)
						{
						case 1:
							return;
						}
						bG4CT0EbQPuKMi3bRsqT(Logger, GFrT5REo6ZlxcEniDpry(kvor04Eo4Cc5Fia7LVfg(-289714582 ^ -289446950)), ex2);
						num5 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0)
						{
							num5 = 1;
						}
					}
				}
			case 0:
				return;
			case 3:
				if (D7eFTsEo75UZYJP0RHcU())
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
					{
						num2 = 1;
					}
				}
				else
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	private void InitCounters()
	{
		//Discarded unreachable code: IL_0085, IL_00ac, IL_00bb, IL_0101, IL_0133, IL_0163, IL_0172, IL_017d, IL_020e, IL_0246, IL_02c5, IL_02d3, IL_037e, IL_03b6, IL_03e1, IL_0454, IL_0488, IL_04b8, IL_04c7, IL_04d3, IL_04e2
		int num = 1;
		int num2 = num;
		bool lockTaken = default(bool);
		Dictionary<Type, IPerformanceCounter> counters = default(Dictionary<Type, IPerformanceCounter>);
		IEnumerator<IPerformanceCounter> enumerator = default(IEnumerator<IPerformanceCounter>);
		IPerformanceCounter current = default(IPerformanceCounter);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
				return;
			case 4:
				lockTaken = false;
				num2 = 3;
				break;
			case 0:
				return;
			case 3:
				try
				{
					Monitor.Enter(counters, ref lockTaken);
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
					{
						num3 = 0;
					}
					while (true)
					{
						switch (num3)
						{
						case 4:
							return;
						case 1:
						case 3:
							_countersInitialized = false;
							num3 = 2;
							break;
						default:
							if (_countersInitializeInvoked)
							{
								return;
							}
							num3 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
							{
								num3 = 1;
							}
							break;
						case 2:
							try
							{
								IEnumerable<IPerformanceCounter> extensionPoints = ((ComponentManager)Qj6V1DEbtFE5njYYFDn7()).GetExtensionPoints<IPerformanceCounter>();
								int num4 = 4;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
								{
									num4 = 5;
								}
								while (true)
								{
									switch (num4)
									{
									case 4:
										return;
									case 3:
										try
										{
											while (true)
											{
												int num7;
												if (!Okkv6hEoJB4AhgQfdpRH(enumerator))
												{
													num7 = 0;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
													{
														num7 = 0;
													}
													goto IL_0181;
												}
												goto IL_01bd;
												IL_01bd:
												w890vyEbwcB5cjdjBD6S(enumerator.Current, PerformanceCategoryRegistrar.DefaultCategoryName);
												num7 = 2;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 != 0)
												{
													num7 = 2;
												}
												goto IL_0181;
												IL_0181:
												switch (num7)
												{
												case 2:
													continue;
												case 1:
													goto IL_01bd;
												case 0:
													break;
												}
												break;
											}
										}
										finally
										{
											if (enumerator != null)
											{
												int num8 = 0;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
												{
													num8 = 0;
												}
												while (true)
												{
													switch (num8)
													{
													default:
														enumerator.Dispose();
														num8 = 1;
														if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
														{
															num8 = 1;
														}
														continue;
													case 1:
														break;
													}
													break;
												}
											}
										}
										goto case 2;
									case 6:
										Locator.GetServiceNotNull<IPerformanceCategoryRegistrar>().CheckRegisterDefault();
										num4 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
										{
											num4 = 0;
										}
										break;
									case 2:
										_countersInitialized = true;
										num4 = 4;
										break;
									default:
										enumerator = extensionPoints.GetEnumerator();
										num4 = 3;
										break;
									case 5:
										enumerator = extensionPoints.GetEnumerator();
										num4 = 1;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
										{
											num4 = 1;
										}
										break;
									case 1:
										try
										{
											while (true)
											{
												IL_0342:
												int num5;
												if (!Okkv6hEoJB4AhgQfdpRH(enumerator))
												{
													num5 = 3;
													goto IL_02d7;
												}
												goto IL_02f1;
												IL_02d7:
												while (true)
												{
													switch (num5)
													{
													case 2:
														break;
													case 1:
														_counters[current.GetType()] = current;
														num5 = 0;
														if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0)
														{
															num5 = 0;
														}
														continue;
													default:
														goto IL_0342;
													case 3:
														goto end_IL_0342;
													}
													break;
												}
												goto IL_02f1;
												IL_02f1:
												current = enumerator.Current;
												num5 = 1;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
												{
													num5 = 1;
												}
												goto IL_02d7;
												continue;
												end_IL_0342:
												break;
											}
										}
										finally
										{
											if (enumerator != null)
											{
												int num6 = 0;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0)
												{
													num6 = 0;
												}
												while (true)
												{
													switch (num6)
													{
													default:
														enumerator.Dispose();
														num6 = 0;
														if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
														{
															num6 = 1;
														}
														continue;
													case 1:
														break;
													}
													break;
												}
											}
										}
										goto case 6;
									}
								}
							}
							catch (Exception exception)
							{
								int num9 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
								{
									num9 = 0;
								}
								while (true)
								{
									switch (num9)
									{
									case 1:
										return;
									}
									Logger.Error(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3C5338FF ^ 0x3C5717C7), exception);
									num9 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0)
									{
										num9 = 1;
									}
								}
							}
							finally
							{
								_countersInitializeInvoked = true;
								int num10 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
								{
									num10 = 0;
								}
								switch (num10)
								{
								case 0:
									break;
								}
							}
						}
					}
				}
				finally
				{
					int num11;
					if (!lockTaken)
					{
						num11 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
						{
							num11 = 0;
						}
						goto IL_048c;
					}
					goto IL_04a2;
					IL_04a2:
					uq82RVEoLDU1VYwt7Rg4(counters);
					num11 = 2;
					goto IL_048c;
					IL_048c:
					switch (num11)
					{
					default:
						goto end_IL_0467;
					case 1:
						break;
					case 0:
						goto end_IL_0467;
					case 2:
						goto end_IL_0467;
					}
					goto IL_04a2;
					end_IL_0467:;
				}
			case 1:
				if (!_countersInitializeInvoked)
				{
					counters = _counters;
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0)
					{
						num2 = 4;
					}
				}
				else
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0)
					{
						num2 = 0;
					}
				}
				break;
			}
		}
	}

	private CallContextType GetContextType()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (Eyma3yEbTZE79B3YbiMN() != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 != 0)
					{
						num2 = 0;
					}
					break;
				}
				return CallContextType.Background;
			default:
				return CallContextType.WebRequest;
			}
		}
	}

	private void SaveCallContext(CallContextInfo callContext)
	{
		//Discarded unreachable code: IL_0059, IL_0068
		int num = 5;
		CallContextType contextType = default(CallContextType);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 6:
					return;
				case 2:
					throw new InvalidOperationException((string)GFrT5REo6ZlxcEniDpry(kvor04Eo4Cc5Fia7LVfg(-1822890472 ^ -1822635948)));
				default:
					X5F91wEb4IHcNW97Zsle(SXn6LmEoUGa9Gh6jmEnX(Eyma3yEbTZE79B3YbiMN()), kvor04Eo4Cc5Fia7LVfg(-542721635 ^ -542992497), callContext);
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 != 0)
					{
						num2 = 3;
					}
					continue;
				case 1:
					if (contextType != CallContextType.Background)
					{
						num2 = 2;
						continue;
					}
					currentContext.Value = callContext;
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
					{
						num2 = 0;
					}
					continue;
				case 5:
					break;
				case 3:
					return;
				case 4:
					if (contextType != 0)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto default;
				}
				break;
			}
			contextType = GetContextType();
			num = 4;
		}
	}

	private void RemoveCurrentCallContext()
	{
		//Discarded unreachable code: IL_0039
		int num = 4;
		int num2 = num;
		CallContextType contextType = default(CallContextType);
		while (true)
		{
			switch (num2)
			{
			case 1:
				return;
			case 5:
				return;
			default:
				currentContext.Value = null;
				num2 = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 != 0)
				{
					num2 = 5;
				}
				continue;
			case 3:
				if (contextType == CallContextType.WebRequest)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de != 0)
					{
						num2 = 1;
					}
					continue;
				}
				break;
			case 4:
				contextType = GetContextType();
				num2 = 3;
				continue;
			case 2:
				break;
			}
			if (contextType != CallContextType.Background)
			{
				break;
			}
			num2 = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
			{
				num2 = 0;
			}
		}
		throw new InvalidOperationException((string)GFrT5REo6ZlxcEniDpry(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3CE17B75 ^ 0x3CE55539)));
	}

	private CallContextInfo StartNewDiagnosticSessionInternal(string name, bool isSubContext = false, CallContextType? subContextType = null)
	{
		CallContextInfo currentDiagnosticSession = GetCurrentDiagnosticSession();
		if (currentDiagnosticSession == null)
		{
			currentDiagnosticSession = new CallContextInfo((!isSubContext) ? GetContextType() : (subContextType ?? CallContextType.SubContext))
			{
				Name = name
			};
			SaveCallContext(currentDiagnosticSession);
			activeContext.Add(currentDiagnosticSession);
			return currentDiagnosticSession;
		}
		if (!isSubContext)
		{
			return currentDiagnosticSession;
		}
		CallContextInfo callContextInfo2 = (currentDiagnosticSession.ChildContextInfo = new CallContextInfo(subContextType ?? CallContextType.SubContext)
		{
			Name = name,
			ParentContextInfo = currentDiagnosticSession
		});
		if (currentDiagnosticSession.CurrentCall != null)
		{
			currentDiagnosticSession.CurrentCall.AddWorkTreeElement(callContextInfo2);
		}
		else
		{
			currentDiagnosticSession.AddWorkTreeElement(callContextInfo2);
		}
		return callContextInfo2;
	}

	private TCallInfo StartCall<TCallInfo>(TCallInfo callInfo, CallContextInfo callContextInfo) where TCallInfo : AbstractCallInfo
	{
		try
		{
			callInfo.StartCall(callContextInfo);
			return callInfo;
		}
		catch (Exception exception)
		{
			Instance.Logger.Error(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1C9495B4 ^ 0x1C90B804)), exception);
			return callInfo;
		}
	}

	void IInitHandler.Init()
	{
		_instance = this;
	}

	void IInitHandler.InitComplete()
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
				metricAggregators = ((ComponentManager)Qj6V1DEbtFE5njYYFDn7()).GetExtensionPoints<IMetricAggregator>();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	static DiagnosticsManager()
	{
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 6:
				return;
			case 4:
				AbstractCallEndEventType = JhubSEEbHgmpCoJhZZAS(typeof(AbstractCallEndEvent<>).TypeHandle);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 != 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				callErrorEventTypes = new ConcurrentDictionary<Type, Type>();
				num2 = 7;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
				{
					num2 = 4;
				}
				break;
			case 2:
				callStartEventTypes = new ConcurrentDictionary<Type, Type>();
				num2 = 5;
				break;
			case 5:
				callEndEventTypes = new ConcurrentDictionary<Type, Type>();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
				{
					num2 = 1;
				}
				break;
			case 8:
				AbstractCallStartEventType = typeof(AbstractCallStartEvent<>);
				num2 = 4;
				break;
			default:
				AbstractCallErrorEventType = JhubSEEbHgmpCoJhZZAS(typeof(AbstractCallErrorEvent<>).TypeHandle);
				num2 = 6;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0)
				{
					num2 = 2;
				}
				break;
			case 7:
				currentContext = new AsyncLocal<CallContextInfo>();
				num2 = 8;
				break;
			case 3:
				oGEU9SEb6YBUvSDTDwKU();
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	internal static object kvor04Eo4Cc5Fia7LVfg(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object GFrT5REo6ZlxcEniDpry(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static bool b6qOjtEot81kwlmHBWIA()
	{
		return zlvdFFEoDsblYpiVC5rQ == null;
	}

	internal static DiagnosticsManager BRyZDlEow910xauGca3C()
	{
		return zlvdFFEoDsblYpiVC5rQ;
	}

	internal static object cfEwLOEoHIORnHXTg734()
	{
		return Instance;
	}

	internal static void WEkjNdEoA5oqY5TNT0x3(object P_0, object P_1)
	{
		((DiagnosticsManager)P_0).MessagePoint((string)P_1);
	}

	internal static bool D7eFTsEo75UZYJP0RHcU()
	{
		return Enabled;
	}

	internal static object s0gqoCEox6ORDoc2gbdF(object P_0)
	{
		return ((DiagnosticsManager)P_0).GetCurrentDiagnosticSession();
	}

	internal static void jj1vamEo0BbxV7NPRFYI(object P_0, object P_1)
	{
		((AbstractCallInfo)P_0).Exception = (Exception)P_1;
	}

	internal static void pdbbSQEomoVj2vV4GTNW(object P_0)
	{
		((AbstractCallInfo)P_0).Dispose();
	}

	internal static bool ap6D33EoymnnryL7eNbO()
	{
		return Initialized;
	}

	internal static void h19F4hEoMEQ1QnxyBsnY(object P_0, object P_1)
	{
		((IDiagnosticsSettingsValidator)P_0).ValidateSettings((EventProcessorsInfo)P_1);
	}

	internal static bool Okkv6hEoJB4AhgQfdpRH(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static DateTime iLcRN3Eo9X1r3BvpHCsM()
	{
		return DateTime.Now;
	}

	internal static void yh1YBcEodZ5as4eVq223(object P_0, DateTime value)
	{
		((MetricsContainer)P_0).StartTime = value;
	}

	internal static DateTime HNeKw6EolNJvs9RfYKVQ(object P_0)
	{
		return ((MetricsContainer)P_0).StartTime;
	}

	internal static bool IKKfM5Eor72B5hxyGEEb(object P_0)
	{
		return ((DiagnosticsSettings)P_0).CountersEnabled;
	}

	internal static void LLTS5WEogesiXQaXOOt8(object P_0, object P_1, bool diagnosticsEnable)
	{
		((IDiagnosticsEventProcessor)P_0).RefreshSettings((EventProcessorsInfo)P_1, diagnosticsEnable);
	}

	internal static bool lClo2SEo5p31Kef2QXeE(object P_0)
	{
		return ((EventProcessorsInfo)P_0).Enabled;
	}

	internal static bool JNTcR8Eojm2acA0qTdmR(object P_0)
	{
		return ((DiagnosticsSettings)P_0).LogsEnabled;
	}

	internal static void p1jMDkEoY3vQUMpHyOge(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static void uq82RVEoLDU1VYwt7Rg4(object P_0)
	{
		Monitor.Exit(P_0);
	}

	internal static object SXn6LmEoUGa9Gh6jmEnX(object P_0)
	{
		return ((HttpContext)P_0).Items;
	}

	internal static object NwAMAIEos89Q3mIwwEjt(object P_0, object P_1)
	{
		return ((IDictionary)P_0)[P_1];
	}

	internal static object uAMEobEocHRVeHwi0oCt(object P_0)
	{
		return ((CallContextInfo)P_0).ChildContextInfo;
	}

	internal static void pQEqDFEozWqTitxX76QH(object P_0, object P_1)
	{
		((CallContextInfo)P_0).CloseCallContext((Exception)P_1);
	}

	internal static object GeHF9jEbFHAisGXOMb3m(object P_0)
	{
		return ((CallContextInfo)P_0).ParentContextInfo;
	}

	internal static void TSVbRGEbBOCqTT34Rl39(object P_0, object P_1)
	{
		((CallContextInfo)P_0).ChildContextInfo = (CallContextInfo)P_1;
	}

	internal static object AK1GJDEbWX2wM64MsFeU(object P_0)
	{
		return ((CallContextInfo)P_0).Metrics;
	}

	internal static void CxwZXyEbot7NejWn62Z9(object P_0, object P_1)
	{
		((MetricsContainer)P_0).Merge((MetricsContainer)P_1);
	}

	internal static object H9RQrCEbbd4T3KT4oJTh(object P_0)
	{
		return ((SessionFactoryHolder)P_0).SessionFactory;
	}

	internal static object qd12ToEbhGG0lRo2skTE(object P_0)
	{
		return ((ISessionFactory)P_0).get_Statistics();
	}

	internal static bool by43HJEbGDYRCPdQxNNU(object P_0)
	{
		return ((DiagnosticsSettings)P_0).GlimpseDiagnostic;
	}

	internal static void e8L6dZEbEKSVueyhmOH4(object P_0, object P_1)
	{
		((GlimpseHelper)P_0).OnDiagnosticEvent((DiagnosticsEvent)P_1);
	}

	internal static void X7j5HTEbflDDlKWrnOlx(object P_0, object P_1)
	{
		P_0((DiagnosticsEvent)P_1);
	}

	internal static void bG4CT0EbQPuKMi3bRsqT(object P_0, object P_1, object P_2)
	{
		((ILogger)P_0).Error(P_1, (Exception)P_2);
	}

	internal static void MJ4gf3EbCF8AK2qwKmqj(object P_0, object P_1)
	{
		((DiagnosticsLogManager)P_0).Log((DiagnosticsEvent)P_1);
	}

	internal static void vUZYoWEbvtP5rrvDSJAR(object P_0, object P_1)
	{
		((ILogger)P_0).Error(P_1);
	}

	internal static object RH6HDREb8Ai3yQLlnl5O(object P_0, object P_1)
	{
		return Delegate.Combine((Delegate)P_0, (Delegate)P_1);
	}

	internal static object sIuLh1EbZWHlWOj4IZKr(object P_0, object P_1)
	{
		return Delegate.Remove((Delegate)P_0, (Delegate)P_1);
	}

	internal static object NFuqw8Ebu36QpghEgO6I(object P_0)
	{
		return ((HttpContext)P_0).Request;
	}

	internal static object RpWGsYEbIj2HgsP4HDYR(object P_0)
	{
		return ((HttpRequest)P_0).UserHostAddress;
	}

	internal static void n1xSp8EbV1QV4Uf6aKVd(object P_0, object P_1)
	{
		((CallContextInfo)P_0).UserHostAddress = (string)P_1;
	}

	internal static object xRZZuTEbSDnBkWk9BVFJ(object P_0)
	{
		return ((HttpRequest)P_0).HttpMethod;
	}

	internal static void f1eqAEEbiAjAMOSdWMcB(object P_0, object P_1)
	{
		((CallContextInfo)P_0).HttpMethod = (string)P_1;
	}

	internal static object jTLxYZEbRAxogBNkbBUW(object P_0)
	{
		return ((IIdentified)P_0).GetId();
	}

	internal static void cJEETMEbqxp3RqLSPVQk(object P_0, object P_1)
	{
		((CallContextInfo)P_0).UserId = P_1;
	}

	internal static object K2JUeWEbKPEQ4oZ3f4dJ(object P_0)
	{
		return ((IUser)P_0).UserName;
	}

	internal static void TgrBllEbXVQf24xdPMW1(object P_0, object P_1)
	{
		((CallContextInfo)P_0).UserName = (string)P_1;
	}

	internal static object Eyma3yEbTZE79B3YbiMN()
	{
		return HttpContext.Current;
	}

	internal static object fhfIwLEbkdi1k6ZyYpxk(Type ownerType, object P_1)
	{
		return DiagnosticsHelper.GetMethodCallName(ownerType, (MethodInfo)P_1);
	}

	internal static Type LUpwk1EbnIUlHlKnaEto(object P_0)
	{
		return ((MemberInfo)P_0).DeclaringType;
	}

	internal static object SSAfpxEbOaOmuCktGcGB(Type type, bool useFullName)
	{
		return DiagnosticsHelper.GetTypeName(type, useFullName);
	}

	internal static object jDWKlxEb2bil84gyFQjX(object P_0, object P_1, object P_2)
	{
		return (string)P_0 + (string)P_1 + (string)P_2;
	}

	internal static object NCRMTQEberDK7VT66GIy(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static void UptJ24EbPj39ioRfvarm(object P_0, object P_1)
	{
		((CallContextInfo)P_0).Description = (string)P_1;
	}

	internal static void vjN1hjEb1NDJbao5ORnn(object P_0, Guid value)
	{
		((CallContextInfo)P_0).CreatedParentContextInfoUid = value;
	}

	internal static void prNnH2EbNlbVCSxyRwKN(object P_0)
	{
		((NumberOfItemsCounter)P_0).Increment();
	}

	internal static void LPg3gHEb3QqpD2OOpN7B(object P_0)
	{
		((NumberOfItemsCounter)P_0).Decrement();
	}

	internal static bool WQgXJ2EbpAJdMfuFuMhF(Type P_0, Type P_1)
	{
		return P_0 != P_1;
	}

	internal static TimeSpan YiV8OCEbapi9LotMMhs7(object P_0)
	{
		return ((CallContextInfo)P_0).TotalTime;
	}

	internal static void rGBLKxEbDwDuaynuiKpy(object P_0, long ticks)
	{
		((AvgTimeCounter)P_0).IncrementBy(ticks);
	}

	internal static object Qj6V1DEbtFE5njYYFDn7()
	{
		return ComponentManager.Current;
	}

	internal static void w890vyEbwcB5cjdjBD6S(object P_0, object P_1)
	{
		((IPerformanceCounter)P_0).Init((string)P_1);
	}

	internal static void X5F91wEb4IHcNW97Zsle(object P_0, object P_1, object P_2)
	{
		((IDictionary)P_0)[P_1] = P_2;
	}

	internal static void oGEU9SEb6YBUvSDTDwKU()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static Type JhubSEEbHgmpCoJhZZAS(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}
}
