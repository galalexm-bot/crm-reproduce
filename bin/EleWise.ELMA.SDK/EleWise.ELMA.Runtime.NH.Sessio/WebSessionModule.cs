using System;
using System.Collections.Generic;
using System.Web;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Runtime.Context;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Runtime.NH.SessionProviders;

public class WebSessionModule : IHttpModule
{
	private class WebELMAContext : ELMAContext
	{
		private readonly object currentHttpContext;

		internal static object aO6TitQrS1Uq2K87Q6Ak;

		protected override object KeyObject => HttpContext.Current;

		private WebELMAContext()
		{
			//Discarded unreachable code: IL_002b, IL_0030
			TboMlvQrq5an6bNAcnjv();
			base._002Ector(isolatedContext: false);
			int num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
			{
				num = 1;
			}
			while (true)
			{
				switch (num)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					currentHttpContext = hUDjTEQrK5Le2MM5kE6n();
					num = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
					{
						num = 0;
					}
					break;
				}
			}
		}

		public override void Dispose()
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					base.Dispose();
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
					{
						num2 = 2;
					}
					break;
				case 2:
					return;
				case 1:
					V4EyWZQrXZpPKY5G62Uw(ELMAContext.Items);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}

		protected override void SetAsCurrentInnerLogic()
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
					k2GgNnQrTXiLQ4BP0JFX(currentHttpContext);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}

		public static void OnBeginRequest()
		{
			new WebELMAContext();
		}

		public static void OnEndRequest()
		{
			//Discarded unreachable code: IL_0035
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
				case 2:
					new WebELMAContext();
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0)
					{
						num2 = 1;
					}
					break;
				case 1:
				case 3:
					ELMAContext.Current.Dispose();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
					{
						num2 = 0;
					}
					break;
				case 4:
					if (eRpVxmQrk3pEs7RTemMJ())
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
						{
							num2 = 3;
						}
						break;
					}
					goto case 2;
				}
			}
		}

		internal static void TboMlvQrq5an6bNAcnjv()
		{
			SingletonReader.JJCZtPuTvSt();
		}

		internal static object hUDjTEQrK5Le2MM5kE6n()
		{
			return HttpContext.Current;
		}

		internal static bool x1dxkeQriM9T0KbgVOgm()
		{
			return aO6TitQrS1Uq2K87Q6Ak == null;
		}

		internal static WebELMAContext dqxkevQrRZ88TN2FfJRp()
		{
			return (WebELMAContext)aO6TitQrS1Uq2K87Q6Ak;
		}

		internal static void V4EyWZQrXZpPKY5G62Uw(object P_0)
		{
			((ICollection<KeyValuePair<string, object>>)P_0).Clear();
		}

		internal static void k2GgNnQrTXiLQ4BP0JFX(object P_0)
		{
			HttpContext.Current = (HttpContext)P_0;
		}

		internal static bool eRpVxmQrk3pEs7RTemMJ()
		{
			return ELMAContext.Initialized;
		}
	}

	private static ISessionProvider sessionProvider;

	[Obsolete("Use GetSessionTable and RemoveSessionTable", true)]
	protected const string SESSION_KEY = "NHibernateModule.Session";

	private static readonly ILogger Logger;

	private static WebSessionModule XfNKqsWH22OgVoePrqwV;

	private static ISessionProvider SessionProvider
	{
		get
		{
			int num = 1;
			int num2 = num;
			ISessionProvider obj;
			while (true)
			{
				switch (num2)
				{
				case 1:
					obj = sessionProvider;
					if (obj != null)
					{
						break;
					}
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0)
					{
						num2 = 0;
					}
					continue;
				default:
					obj = (sessionProvider = Locator.GetServiceNotNull<ISessionProvider>());
					break;
				}
				break;
			}
			return obj;
		}
	}

	void IHttpModule.Init(HttpApplication context)
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
				xsAseSWH1ng56wisaIX9(this, context);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public virtual void Init(HttpApplication context)
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
				context.BeginRequest += OnBeginRequest;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				Idw7O6WHNXbSTo00SRWQ(context, new EventHandler(OnEndRequest));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public void Dispose()
	{
	}

	public static ISession GetSession(string dbName)
	{
		return SessionProvider.GetSession(dbName);
	}

	public static void SetSession(string dbName, ISession session)
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
				((ISessionProvider)dUqxBoWH3tHJk9ynMKuG()).SetCurrentSession(session, dbName);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public static void CloseSession(string dbName)
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
				JIE5NnWHpb13EWbpNlSk(SessionProvider, dbName);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public static void ReleaseSession(string dbName)
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
				JIE5NnWHpb13EWbpNlSk(dUqxBoWH3tHJk9ynMKuG(), dbName);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public static void InitSessions()
	{
	}

	public static void ReleaseSessions()
	{
		//Discarded unreachable code: IL_0045, IL_0078, IL_00cf, IL_00de
		switch (1)
		{
		case 0:
			break;
		case 1:
			try
			{
				cPTcWtWHa1sPXirhJ4OQ();
				int num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
				{
					num = 0;
				}
				switch (num)
				{
				case 0:
					break;
				}
				break;
			}
			catch (Exception ex)
			{
				int num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 != 0)
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
					D2iEY6WHtStNPGILMO4a(Logger, cLVOLBWHDVYBbC0xM0CB(0x18A6761F ^ 0x18A453BB), ex);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 != 0)
					{
						num2 = 1;
					}
				}
			}
		}
	}

	protected internal static Dictionary<string, ISession> GetSessionTable()
	{
		return Locator.GetService<SessionProvider>().GetSessionTable();
	}

	protected static void RemoveSessionTable()
	{
		lehm34WHw5CdZMtcJIYQ();
	}

	protected static ISession OpenSession(ISessionFactory sessionFactory)
	{
		//Discarded unreachable code: IL_006c, IL_0081
		int num = 1;
		int num2 = num;
		IInterceptor val = default(IInterceptor);
		object obj;
		while (true)
		{
			object obj2;
			switch (num2)
			{
			case 1:
			{
				IInterceptorProvider service = Locator.GetService<IInterceptorProvider>();
				if (service == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0)
					{
						num2 = 0;
					}
					continue;
				}
				obj2 = wnQyP8WH4IRokmMILuG7(service, sessionFactory);
				goto IL_0092;
			}
			case 2:
				if (val != null)
				{
					num2 = 4;
					continue;
				}
				goto case 3;
			case 3:
				obj = QUQciDWH67KGk1ti9b5L(sessionFactory);
				break;
			default:
				obj2 = null;
				goto IL_0092;
			case 4:
				{
					obj = xBasFFWHAb8eLViHubBh(((ISessionBuilder<ISessionBuilder>)lWjYZ7WHHP34HM23PoJo(sessionFactory)).Interceptor(val));
					break;
				}
				IL_0092:
				val = (IInterceptor)obj2;
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
				{
					num2 = 0;
				}
				continue;
			}
			break;
		}
		MGJ7A7WH7mp3OCbSfxit(obj, (FlushMode)5);
		((ISession)obj).set_CacheMode((CacheMode)3);
		return (ISession)obj;
	}

	protected static void CloseSession(ISession session)
	{
		//Discarded unreachable code: IL_0036, IL_0045, IL_0085, IL_00b8, IL_0125, IL_0176, IL_0185
		//IL_009e: Expected O, but got Unknown
		int num = 4;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					return;
				case 3:
					return;
				case 4:
					if (session != null)
					{
						break;
					}
					goto end_IL_0012;
				case 2:
					try
					{
						PhqmMHWH0m4cD6f2Yl8l(session);
						int num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 != 0)
						{
							num3 = 0;
						}
						switch (num3)
						{
						case 0:
							break;
						}
						return;
					}
					catch (HibernateException val)
					{
						HibernateException val2 = val;
						int num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0)
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
							fNLZv8WHmYFPPKVSRAVn(Logger, cLVOLBWHDVYBbC0xM0CB(0x3B36AB09 ^ 0x3B348D05), val2);
							num4 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
							{
								num4 = 1;
							}
						}
					}
					catch (Exception ex)
					{
						int num5 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
						{
							num5 = 1;
						}
						while (true)
						{
							switch (num5)
							{
							default:
								return;
							case 0:
								return;
							case 1:
								fNLZv8WHmYFPPKVSRAVn(Logger, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2099751081 ^ -2099613435), ex);
								num5 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa != 0)
								{
									num5 = 0;
								}
								break;
							}
						}
					}
				}
				if (!ctlAbmWHxiVyKrP7CiLE(session))
				{
					return;
				}
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
				{
					num2 = 0;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 3;
		}
	}

	private void OnBeginRequest(object sender, EventArgs e)
	{
		WebELMAContext.OnBeginRequest();
		CuKhS2WHybcUN9m4r8AX();
	}

	private void OnEndRequest(object sender, EventArgs e)
	{
		//Discarded unreachable code: IL_0044, IL_009d, IL_00b0, IL_00bf
		switch (1)
		{
		case 1:
			try
			{
				AiAqd3WHMA4cEO98DWYt();
				int num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
				{
					num = 1;
				}
				while (true)
				{
					switch (num)
					{
					default:
						return;
					case 1:
						UwQCK3WHJ6DAgbEnqSGX();
						num = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
						{
							num = 0;
						}
						break;
					case 0:
						return;
					}
				}
			}
			finally
			{
				WebELMAContext.OnEndRequest();
				int num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
				{
					num2 = 0;
				}
				switch (num2)
				{
				case 0:
					break;
				}
			}
		case 0:
			break;
		}
	}

	private static void ReleaseSettings()
	{
		//Discarded unreachable code: IL_0073, IL_0082
		int num = 3;
		int num2 = num;
		PoolBasedSettingsService service = default(PoolBasedSettingsService);
		while (true)
		{
			switch (num2)
			{
			case 3:
				if (Locator.Initialized)
				{
					num2 = 2;
					break;
				}
				return;
			case 1:
				return;
			case 5:
				return;
			case 6:
				return;
			default:
				if (service == null)
				{
					num2 = 5;
					break;
				}
				goto case 4;
			case 4:
				VX9fwSWHlYk12b1B5u9a(service);
				num2 = 6;
				break;
			case 2:
				if (Ow1KSOWHdul4Ko0mKX4f(BrCJ68WH9dVlsLiv5SXO()) == StartStatus.Started)
				{
					service = Locator.GetService<PoolBasedSettingsService>();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f != 0)
					{
						num2 = 0;
					}
				}
				else
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 != 0)
					{
						num2 = 1;
					}
				}
				break;
			}
		}
	}

	public WebSessionModule()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		lmUx6GWHrn4ywNbP7usK();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static WebSessionModule()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				SingletonReader.JJCZtPuTvSt();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				Logger = (ILogger)Uy5BPSWH5sI1TVDYi4il(LKmKyHWHg8x4QWL2ipQF(typeof(WebSessionModule).TypeHandle));
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				return;
			}
		}
	}

	internal static void xsAseSWH1ng56wisaIX9(object P_0, object P_1)
	{
		((WebSessionModule)P_0).Init((HttpApplication)P_1);
	}

	internal static bool pvAXy7WHejEHiRr7Gfs0()
	{
		return XfNKqsWH22OgVoePrqwV == null;
	}

	internal static WebSessionModule spp3SgWHPBcqDvL0uwYh()
	{
		return XfNKqsWH22OgVoePrqwV;
	}

	internal static void Idw7O6WHNXbSTo00SRWQ(object P_0, object P_1)
	{
		((HttpApplication)P_0).EndRequest += (EventHandler)P_1;
	}

	internal static object dUqxBoWH3tHJk9ynMKuG()
	{
		return SessionProvider;
	}

	internal static void JIE5NnWHpb13EWbpNlSk(object P_0, object P_1)
	{
		((ISessionProvider)P_0).CloseSession((string)P_1);
	}

	internal static void cPTcWtWHa1sPXirhJ4OQ()
	{
		RemoveSessionTable();
	}

	internal static object cLVOLBWHDVYBbC0xM0CB(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void D2iEY6WHtStNPGILMO4a(object P_0, object P_1, object P_2)
	{
		((ILogger)P_0).Verbose(P_1, (Exception)P_2);
	}

	internal static void lehm34WHw5CdZMtcJIYQ()
	{
		WebSessionProvider.RemoveSessionTable();
	}

	internal static object wnQyP8WH4IRokmMILuG7(object P_0, object P_1)
	{
		return ((IInterceptorProvider)P_0).GetInterceptor((ISessionFactory)P_1);
	}

	internal static object QUQciDWH67KGk1ti9b5L(object P_0)
	{
		return ((ISessionFactory)P_0).OpenSession();
	}

	internal static object lWjYZ7WHHP34HM23PoJo(object P_0)
	{
		return ((ISessionFactory)P_0).WithOptions();
	}

	internal static object xBasFFWHAb8eLViHubBh(object P_0)
	{
		return ((ISessionBuilder<ISessionBuilder>)P_0).OpenSession();
	}

	internal static void MGJ7A7WH7mp3OCbSfxit(object P_0, FlushMode P_1)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((ISession)P_0).set_FlushMode(P_1);
	}

	internal static bool ctlAbmWHxiVyKrP7CiLE(object P_0)
	{
		return ((ISession)P_0).get_IsOpen();
	}

	internal static void PhqmMHWH0m4cD6f2Yl8l(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static void fNLZv8WHmYFPPKVSRAVn(object P_0, object P_1, object P_2)
	{
		((ILogger)P_0).Error(P_1, (Exception)P_2);
	}

	internal static void CuKhS2WHybcUN9m4r8AX()
	{
		InitSessions();
	}

	internal static void AiAqd3WHMA4cEO98DWYt()
	{
		ReleaseSessions();
	}

	internal static void UwQCK3WHJ6DAgbEnqSGX()
	{
		ReleaseSettings();
	}

	internal static object BrCJ68WH9dVlsLiv5SXO()
	{
		return StartInformation.Root;
	}

	internal static StartStatus Ow1KSOWHdul4Ko0mKX4f(object P_0)
	{
		return ((StartInformation)P_0).Status;
	}

	internal static void VX9fwSWHlYk12b1B5u9a(object P_0)
	{
		((PoolBasedSettingsService)P_0).Release();
	}

	internal static void lmUx6GWHrn4ywNbP7usK()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static Type LKmKyHWHg8x4QWL2ipQF(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object Uy5BPSWH5sI1TVDYi4il(Type componentType)
	{
		return EleWise.ELMA.Logging.Logger.GetLogger(componentType);
	}
}
