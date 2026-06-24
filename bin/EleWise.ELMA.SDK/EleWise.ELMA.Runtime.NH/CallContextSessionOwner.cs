using System;
using System.Collections;
using System.Collections.Generic;
using EleWise.ELMA.Runtime.Context;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Runtime.NH;

public sealed class CallContextSessionOwner : IDisposable
{
	private static readonly ContextVars.Local<CallContextSessionOwner> current;

	private static readonly CallContextSessionOwner EmptyDisposable;

	private readonly bool isEmpty;

	private bool disposed;

	private readonly IDisposable elmaContext;

	private IDictionary<Guid, ISessionsContainer> sessionTable;

	private bool isExternalSessionTable;

	private static CallContextSessionOwner NxUwApW6AX5LB5SLSkSW;

	public static CallContextSessionOwner Current => current.Value;

	public Dictionary<string, ISession> SessionTable => Locator.GetService<SessionProvider>().GetSessionTable();

	[Obsolete("Конструктор устарел и больше не используется. Используйте CallContextSessionOwner.Create()", true)]
	public CallContextSessionOwner()
	{
		//Discarded unreachable code: IL_002b, IL_0030
		SingletonReader.JJCZtPuTvSt();
		this._002Ector(emptyDisposable: false);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public static CallContextSessionOwner Create()
	{
		//Discarded unreachable code: IL_003a, IL_0049
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return EmptyDisposable;
			case 1:
				return new CallContextSessionOwner(emptyDisposable: false);
			case 2:
				if (current.Value == null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto default;
			}
		}
	}

	internal IDictionary<Guid, ISessionsContainer> GetSessionTable()
	{
		if (Current == null)
		{
			throw new Exception(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x571EA399 ^ 0x571C869D));
		}
		return Current.sessionTable;
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
				return;
			case 0:
				return;
			case 1:
				Dispose(disposing: true);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private CallContextSessionOwner(bool emptyDisposable)
	{
		//Discarded unreachable code: IL_001a, IL_001f, IL_005a, IL_0069, IL_00e9, IL_00f8
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 4;
		while (true)
		{
			switch (num)
			{
			case 5:
				return;
			case 6:
				return;
			case 4:
				isEmpty = emptyDisposable;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 != 0)
				{
					num = 1;
				}
				break;
			case 1:
				if (isEmpty)
				{
					return;
				}
				num = 9;
				break;
			case 7:
				sessionTable = new Dictionary<Guid, ISessionsContainer>();
				num = 6;
				break;
			case 9:
				if (ELMAContext.Initialized)
				{
					num = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
					{
						num = 3;
					}
					break;
				}
				goto default;
			case 2:
				current.Value = this;
				num = 7;
				break;
			default:
				elmaContext = ELMAContext.Create();
				num = 8;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
				{
					num = 7;
				}
				break;
			case 3:
			case 8:
				if (current.Value != null)
				{
					num = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
					{
						num = 5;
					}
					break;
				}
				goto case 2;
			}
		}
	}

	~CallContextSessionOwner()
	{
		//Discarded unreachable code: IL_0046, IL_007d, IL_0090, IL_009f
		switch (1)
		{
		case 1:
			try
			{
				Dispose(disposing: false);
				int num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
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
			finally
			{
				b0k9IOW60JUitqHD11N9(this);
				int num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
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

	private void Dispose(bool disposing)
	{
		//Discarded unreachable code: IL_0039, IL_0048, IL_0074, IL_00c0, IL_00e7, IL_00f6, IL_0148, IL_0157, IL_0162, IL_01ee, IL_0226, IL_025a, IL_026d, IL_027c, IL_0330, IL_038f
		int num = 4;
		int num2 = num;
		IEnumerator<ISessionsContainer> enumerator = default(IEnumerator<ISessionsContainer>);
		ELMAContext eLMAContext = default(ELMAContext);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				try
				{
					int num3;
					if (!disposing)
					{
						num3 = 5;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0)
						{
							num3 = 4;
						}
						goto IL_0078;
					}
					goto IL_02a4;
					IL_02a4:
					if (current.Value == this)
					{
						num3 = 4;
						goto IL_0078;
					}
					return;
					IL_0078:
					while (true)
					{
						switch (num3)
						{
						default:
							try
							{
								int num4;
								if (sessionTable == null)
								{
									num4 = 3;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0)
									{
										num4 = 3;
									}
									goto IL_00c4;
								}
								goto IL_0101;
								IL_0101:
								enumerator = sessionTable.Values.GetEnumerator();
								num4 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
								{
									num4 = 1;
								}
								goto IL_00c4;
								IL_00c4:
								while (true)
								{
									switch (num4)
									{
									case 3:
										return;
									case 4:
										goto IL_012d;
									case 1:
										try
										{
											while (true)
											{
												int num5;
												if (!F1QaDpW6MQ7UG15EvdC4(enumerator))
												{
													num5 = 2;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
													{
														num5 = 2;
													}
													goto IL_0166;
												}
												goto IL_01a2;
												IL_01a2:
												ITZ00SW6yBQ95C16QoOt(enumerator.Current);
												num5 = 0;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
												{
													num5 = 0;
												}
												goto IL_0166;
												IL_0166:
												switch (num5)
												{
												case 1:
													goto IL_01a2;
												case 2:
													goto end_IL_017c;
												}
												continue;
												end_IL_017c:
												break;
											}
										}
										finally
										{
											if (enumerator != null)
											{
												int num6 = 0;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
												{
													num6 = 0;
												}
												while (true)
												{
													switch (num6)
													{
													default:
														AAf3H0W6J8qssniK8Mg8(enumerator);
														num6 = 0;
														if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
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
										goto IL_012d;
									case 2:
										return;
									}
									break;
									IL_012d:
									KPFCHjW69EV4Ra28Tj48(sessionTable);
									num4 = 2;
								}
								goto IL_0101;
							}
							finally
							{
								current.Value = null;
								int num7 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0)
								{
									num7 = 0;
								}
								switch (num7)
								{
								case 0:
									break;
								}
							}
						case 5:
							if ((eLMAContext = elmaContext as ELMAContext) != null)
							{
								num3 = 2;
								continue;
							}
							break;
						case 1:
							break;
						case 2:
							BuVDBSW6mLNfPq5p3jrQ(eLMAContext);
							num3 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
							{
								num3 = 1;
							}
							continue;
						case 4:
							if (!isExternalSessionTable)
							{
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
								{
									num3 = 0;
								}
								continue;
							}
							return;
						case 3:
							return;
						}
						break;
					}
					goto IL_02a4;
				}
				finally
				{
					IDisposable disposable = elmaContext;
					int num8;
					if (disposable == null)
					{
						num8 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
						{
							num8 = 1;
						}
					}
					else
					{
						AAf3H0W6J8qssniK8Mg8(disposable);
						num8 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
						{
							num8 = 0;
						}
					}
					while (true)
					{
						switch (num8)
						{
						default:
							So4ZBUW6dNWqDWZGYnuQ(this);
							num8 = 2;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
							{
								num8 = 2;
							}
							continue;
						case 2:
							break;
						}
						break;
					}
				}
			case 4:
				if (!isEmpty)
				{
					num2 = 3;
					break;
				}
				return;
			case 0:
				return;
			case 5:
				disposed = true;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return;
			case 3:
				if (disposed)
				{
					return;
				}
				num2 = 5;
				break;
			}
		}
	}

	static CallContextSessionOwner()
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				current = new ContextVars.Local<CallContextSessionOwner>();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				DkOPjsW6loxgGstOSrPd();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				return;
			default:
				EmptyDisposable = new CallContextSessionOwner(emptyDisposable: true);
				num2 = 3;
				break;
			}
		}
	}

	internal static bool HRSt4ZW67qjypIunpKFC()
	{
		return NxUwApW6AX5LB5SLSkSW == null;
	}

	internal static CallContextSessionOwner owUxsjW6xjr4GbFo3t6X()
	{
		return NxUwApW6AX5LB5SLSkSW;
	}

	internal static void b0k9IOW60JUitqHD11N9(object P_0)
	{
		P_0.Finalize();
	}

	internal static void BuVDBSW6mLNfPq5p3jrQ(object P_0)
	{
		((ELMAContext)P_0).SetAsCurrent();
	}

	internal static void ITZ00SW6yBQ95C16QoOt(object P_0)
	{
		((ISessionsContainer)P_0).CloseAll();
	}

	internal static bool F1QaDpW6MQ7UG15EvdC4(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void AAf3H0W6J8qssniK8Mg8(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static void KPFCHjW69EV4Ra28Tj48(object P_0)
	{
		((ICollection<KeyValuePair<Guid, ISessionsContainer>>)P_0).Clear();
	}

	internal static void So4ZBUW6dNWqDWZGYnuQ(object P_0)
	{
		GC.SuppressFinalize(P_0);
	}

	internal static void DkOPjsW6loxgGstOSrPd()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
