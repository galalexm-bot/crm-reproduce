using System;
using System.Collections.Generic;
using EleWise.ELMA.Logging;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Runtime.NH;

internal sealed class SessionProvider : ISessionProvider
{
	private class SessionDictionary : Dictionary<string, ISession>, ISessionsContainer
	{
		public static readonly Guid Uid;

		internal static object Ky4fSoQMYSTtfRNR7LwS;

		public void CloseAll()
		{
			//Discarded unreachable code: IL_0059, IL_0068, IL_0073, IL_013e, IL_0171, IL_01de, IL_0235, IL_0244, IL_0253, IL_028a, IL_029d
			//IL_0157: Expected O, but got Unknown
			int num = 1;
			int num2 = num;
			ValueCollection.Enumerator enumerator = default(ValueCollection.Enumerator);
			ISession current = default(ISession);
			while (true)
			{
				switch (num2)
				{
				case 1:
					enumerator = base.Values.GetEnumerator();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
					{
						num2 = 0;
					}
					continue;
				default:
					try
					{
						while (true)
						{
							int num3;
							if (!enumerator.MoveNext())
							{
								num3 = 2;
								goto IL_0077;
							}
							goto IL_0108;
							IL_0077:
							while (true)
							{
								switch (num3)
								{
								default:
									UQxPGqQMsh47FliM7MCf(Logger.Log, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1487388570 ^ -1487025144));
									num3 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
									{
										num3 = 1;
									}
									continue;
								case 5:
									if (current == null)
									{
										num3 = 4;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
										{
											num3 = 4;
										}
										continue;
									}
									goto default;
								case 4:
								case 6:
									break;
								case 3:
									goto IL_0108;
								case 1:
									try
									{
										M0h51wQMcRb3t27fYqh7(current);
										int num4 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0)
										{
											num4 = 0;
										}
										switch (num4)
										{
										case 0:
											break;
										}
									}
									catch (HibernateException val)
									{
										HibernateException val2 = val;
										int num5 = 1;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
										{
											num5 = 0;
										}
										while (true)
										{
											switch (num5)
											{
											case 1:
												eC7B46QJFD0uRdb1WrVu(Logger.Log, g5qdpAQMz5ThDsGX80BV(-345420348 ^ -345281592), val2);
												num5 = 0;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
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
									catch (Exception ex)
									{
										int num6 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
										{
											num6 = 0;
										}
										while (true)
										{
											switch (num6)
											{
											default:
												eC7B46QJFD0uRdb1WrVu(mLy84AQJBjkOXtKX3EyG(), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x49E27B8A ^ 0x49E05DD8), ex);
												num6 = 1;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 != 0)
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
									break;
								case 2:
									goto end_IL_00f2;
								}
								break;
							}
							continue;
							IL_0108:
							current = enumerator.Current;
							num3 = 5;
							goto IL_0077;
							continue;
							end_IL_00f2:
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator).Dispose();
						int num7 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
						{
							num7 = 0;
						}
						switch (num7)
						{
						case 0:
							break;
						}
					}
					break;
				case 3:
					break;
				case 2:
					return;
				}
				Clear();
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0)
				{
					num2 = 2;
				}
			}
		}

		public SessionDictionary()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			G4iuLWQJW8iYnFW4FoWv();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		static SessionDictionary()
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
					G4iuLWQJW8iYnFW4FoWv();
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0)
					{
						num2 = 1;
					}
					break;
				case 1:
					Uid = new Guid((string)g5qdpAQMz5ThDsGX80BV(0x103FE975 ^ 0x103DF123));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}

		internal static void UQxPGqQMsh47FliM7MCf(object P_0, object P_1)
		{
			((ILogger)P_0).Verbose(P_1);
		}

		internal static object M0h51wQMcRb3t27fYqh7(object P_0)
		{
			return ((ISession)P_0).Close();
		}

		internal static object g5qdpAQMz5ThDsGX80BV(int _0020)
		{
			return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}

		internal static void eC7B46QJFD0uRdb1WrVu(object P_0, object P_1, object P_2)
		{
			((ILogger)P_0).Error(P_1, (Exception)P_2);
		}

		internal static object mLy84AQJBjkOXtKX3EyG()
		{
			return Logger.Log;
		}

		internal static bool gmEMSuQMLeD7mvMV2ioU()
		{
			return Ky4fSoQMYSTtfRNR7LwS == null;
		}

		internal static SessionDictionary DJqO7hQMUrSp6u7IUIRH()
		{
			return (SessionDictionary)Ky4fSoQMYSTtfRNR7LwS;
		}

		internal static void G4iuLWQJW8iYnFW4FoWv()
		{
			SingletonReader.JJCZtPuTvSt();
		}
	}

	private static readonly Guid Uid;

	private readonly ISessionsContainerProvider sessionsContainerProvider;

	private readonly SessionFactoryHolder sessionFactory;

	private readonly IInterceptorProvider interceptorProvider;

	private static SessionProvider jQW7oiWpoSpVqY16MuKy;

	public SessionProvider(ISessionsContainerProvider sessionsContainerProvider, SessionFactoryHolder sessionFactory, IInterceptorProvider interceptorProvider)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		p3hk7QWpGElAPNWphHBN();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			case 2:
				return;
			default:
				this.interceptorProvider = interceptorProvider;
				num = 2;
				break;
			case 1:
				this.sessionsContainerProvider = sessionsContainerProvider;
				num = 3;
				break;
			case 3:
				this.sessionFactory = sessionFactory;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public ISession GetSession(string dbName)
	{
		int num = 1;
		ISession value = default(ISession);
		Dictionary<string, ISession> sessionTable = default(Dictionary<string, ISession>);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				string text;
				switch (num2)
				{
				case 4:
					return value;
				case 2:
					sessionTable = GetSessionTable();
					num2 = 5;
					continue;
				case 3:
					value = OpenSession((ISessionFactory)ubEthcWpE75BErgTYaeg(sessionFactory));
					num2 = 6;
					continue;
				case 6:
					goto end_IL_0012;
				case 5:
					if (!sessionTable.TryGetValue(dbName, out value))
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0)
						{
							num2 = 3;
						}
						continue;
					}
					goto case 4;
				case 1:
					text = dbName;
					if (text != null)
					{
						break;
					}
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
					{
						num2 = 0;
					}
					continue;
				default:
					text = string.Empty;
					break;
				}
				dbName = text;
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
				{
					num2 = 1;
				}
				continue;
				end_IL_0012:
				break;
			}
			sessionTable.Add(dbName, value);
			num = 4;
		}
	}

	public void CloseSession(string dbName)
	{
		//Discarded unreachable code: IL_0095, IL_00b4, IL_0100, IL_0141
		int num = 3;
		int num2 = num;
		Dictionary<string, ISession> sessionTable = default(Dictionary<string, ISession>);
		ISession value = default(ISession);
		while (true)
		{
			string text;
			switch (num2)
			{
			case 5:
				sessionTable = GetSessionTable();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0)
				{
					num2 = 1;
				}
				continue;
			case 4:
				sessionTable.Remove(dbName);
				num2 = 6;
				continue;
			case 6:
				return;
			default:
				try
				{
					int num3;
					if (!Ofr8jHWpfsBUNNptOr6B(value))
					{
						num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
						{
							num3 = 0;
						}
						goto IL_0099;
					}
					goto IL_00be;
					IL_00be:
					tNqCa5WpQkmgyN0lfWWg(value);
					num3 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f != 0)
					{
						num3 = 0;
					}
					goto IL_0099;
					IL_0099:
					switch (num3)
					{
					default:
						goto end_IL_006f;
					case 0:
						goto end_IL_006f;
					case 2:
						break;
					case 1:
						goto end_IL_006f;
					}
					goto IL_00be;
					end_IL_006f:;
				}
				catch (Exception ex)
				{
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
					{
						num4 = 0;
					}
					while (true)
					{
						switch (num4)
						{
						default:
							NuEEfFWpCoQnLhKbfW07(Logger.Log, ex);
							num4 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0)
							{
								num4 = 0;
							}
							continue;
						case 1:
							break;
						}
						break;
					}
				}
				goto case 4;
			case 1:
				if (!sessionTable.TryGetValue(dbName, out value))
				{
					return;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
				{
					num2 = 0;
				}
				continue;
			case 3:
				text = dbName;
				if (text != null)
				{
					break;
				}
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
				{
					num2 = 2;
				}
				continue;
			case 2:
				text = string.Empty;
				break;
			}
			dbName = text;
			num2 = 5;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
			{
				num2 = 2;
			}
		}
	}

	public void EndUnitOfWork(string dbName)
	{
	}

	public void SetCurrentSession(ISession session, string dbName)
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
				GetSessionTable()[dbName] = session;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	internal Dictionary<string, ISession> GetSessionTable()
	{
		IDictionary<Guid, ISessionsContainer> sessionsContainers = sessionsContainerProvider.GetSessionsContainers();
		if (!sessionsContainers.TryGetValue(Uid, out var value))
		{
			value = (sessionsContainers[Uid] = new SessionDictionary());
		}
		return (Dictionary<string, ISession>)value;
	}

	private ISession OpenSession(ISessionFactory sessionFactory)
	{
		//Discarded unreachable code: IL_0036, IL_0046, IL_008a, IL_0099
		int num = 1;
		IInterceptor val = default(IInterceptor);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				object obj2;
				object obj;
				switch (num2)
				{
				default:
					obj2 = null;
					goto IL_00b0;
				case 2:
					obj = sessionFactory.OpenSession();
					break;
				case 4:
					if (val != null)
					{
						goto end_IL_0012;
					}
					goto case 2;
				case 1:
					if (interceptorProvider == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					obj2 = Q3fLxhWpvf35QbZ9jHUj(interceptorProvider, sessionFactory);
					goto IL_00b0;
				case 3:
					{
						obj = bnKNlHWp8VZngYIr2YY8(sessionFactory, val);
						break;
					}
					IL_00b0:
					val = (IInterceptor)obj2;
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
					{
						num2 = 3;
					}
					continue;
				}
				x4oy9xWpZsPoYUmZMagx(obj, (FlushMode)5);
				((ISession)obj).set_CacheMode((CacheMode)3);
				return (ISession)obj;
				continue;
				end_IL_0012:
				break;
			}
			num = 3;
		}
	}

	static SessionProvider()
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
				Uid = new Guid((string)yI5JtsWpuu3RHr6k6I1W(-1979251663 ^ -1979376537));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			case 2:
				p3hk7QWpGElAPNWphHBN();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static void p3hk7QWpGElAPNWphHBN()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool OlLi4UWpbGum9dmqd3xl()
	{
		return jQW7oiWpoSpVqY16MuKy == null;
	}

	internal static SessionProvider yCicKWWphhip5hPvnHol()
	{
		return jQW7oiWpoSpVqY16MuKy;
	}

	internal static object ubEthcWpE75BErgTYaeg(object P_0)
	{
		return ((SessionFactoryHolder)P_0).SessionFactory;
	}

	internal static bool Ofr8jHWpfsBUNNptOr6B(object P_0)
	{
		return ((ISession)P_0).get_IsOpen();
	}

	internal static void tNqCa5WpQkmgyN0lfWWg(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static void NuEEfFWpCoQnLhKbfW07(object P_0, object P_1)
	{
		((ILogger)P_0).Error(P_1);
	}

	internal static object Q3fLxhWpvf35QbZ9jHUj(object P_0, object P_1)
	{
		return ((IInterceptorProvider)P_0).GetInterceptor((ISessionFactory)P_1);
	}

	internal static object bnKNlHWp8VZngYIr2YY8(object P_0, object P_1)
	{
		return ((ISessionFactory)P_0).OpenSession((IInterceptor)P_1);
	}

	internal static void x4oy9xWpZsPoYUmZMagx(object P_0, FlushMode P_1)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		((ISession)P_0).set_FlushMode(P_1);
	}

	internal static object yI5JtsWpuu3RHr6k6I1W(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}
}
