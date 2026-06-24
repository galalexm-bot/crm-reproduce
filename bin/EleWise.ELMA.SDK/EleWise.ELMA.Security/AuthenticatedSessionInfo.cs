using System;
using System.Collections.Specialized;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Web;
using EleWise.ELMA.Extensions;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Security;

public class AuthenticatedSessionInfo
{
	public static class Db
	{
		public static class Fields
		{
			public static readonly string TicketUid;

			public static readonly string Status;

			public static readonly string Expiration;

			public static readonly string SessionId;

			public static readonly string SessionData;

			public static readonly string UserId;

			public static readonly string RemoteAddress;

			public static readonly string CreationDate;

			public static readonly string LastActionDate;

			public static readonly string LastPingDate;

			public static readonly string LastActionInfo;

			private static Fields i5Kt8LZvATZSW7FwpwpQ;

			static Fields()
			{
				int num = 3;
				int num2 = num;
				ParameterExpression parameterExpression = default(ParameterExpression);
				while (true)
				{
					switch (num2)
					{
					case 4:
						parameterExpression = Expression.Parameter(HILfXQZvmxMbZL6KkVj6(typeof(AuthenticatedSessionInfo).TypeHandle), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1886646897 ^ -1886468603));
						num2 = 8;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
						{
							num2 = 9;
						}
						break;
					case 15:
						parameterExpression = Expression.Parameter(HILfXQZvmxMbZL6KkVj6(typeof(AuthenticatedSessionInfo).TypeHandle), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1751176224 ^ -1751261078));
						num2 = 20;
						break;
					case 3:
						YVWunGZv0ILmj8NLGnmK();
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0)
						{
							num2 = 2;
						}
						break;
					case 1:
						parameterExpression = Expression.Parameter(HILfXQZvmxMbZL6KkVj6(typeof(AuthenticatedSessionInfo).TypeHandle), (string)HBdw7eZvyfeygvuTm6x1(0x5A4C7B29 ^ 0x5A4EB0A3));
						num2 = 13;
						break;
					case 10:
						parameterExpression = (ParameterExpression)NcZDnrZvM4xT3VfnEAoW(HILfXQZvmxMbZL6KkVj6(typeof(AuthenticatedSessionInfo).TypeHandle), HBdw7eZvyfeygvuTm6x1(0x638095EB ^ 0x63825E61));
						num2 = 12;
						break;
					case 6:
						parameterExpression = Expression.Parameter(HILfXQZvmxMbZL6KkVj6(typeof(AuthenticatedSessionInfo).TypeHandle), (string)HBdw7eZvyfeygvuTm6x1(-1858887263 ^ -1859032533));
						num2 = 22;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0)
						{
							num2 = 17;
						}
						break;
					case 14:
						SessionId = LinqUtils.NameOf(Expression.Lambda<Func<AuthenticatedSessionInfo, object>>((Expression)WdNJy3ZvdeVdAFPd5n42(parameterExpression, (MethodInfo)TCZqdJZv9DK4VcKkCPt9((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }));
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
						{
							num2 = 0;
						}
						break;
					case 16:
						TicketUid = LinqUtils.NameOf(Expression.Lambda<Func<AuthenticatedSessionInfo, object>>((Expression)PZxvqeZvJrnnWOYRVgrc(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), HILfXQZvmxMbZL6KkVj6(typeof(object).TypeHandle)), new ParameterExpression[1] { parameterExpression }));
						num2 = 17;
						break;
					case 11:
						Status = LinqUtils.NameOf(Expression.Lambda<Func<AuthenticatedSessionInfo, object>>(Expression.Convert((Expression)WdNJy3ZvdeVdAFPd5n42(parameterExpression, (MethodInfo)TCZqdJZv9DK4VcKkCPt9((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), HILfXQZvmxMbZL6KkVj6(typeof(object).TypeHandle)), new ParameterExpression[1] { parameterExpression }));
						num2 = 15;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
						{
							num2 = 7;
						}
						break;
					case 20:
						Expiration = LinqUtils.NameOf(Expression.Lambda<Func<AuthenticatedSessionInfo, object>>((Expression)PZxvqeZvJrnnWOYRVgrc(Expression.Property(parameterExpression, (MethodInfo)TCZqdJZv9DK4VcKkCPt9((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), HILfXQZvmxMbZL6KkVj6(typeof(object).TypeHandle)), new ParameterExpression[1] { parameterExpression }));
						num2 = 19;
						break;
					case 7:
						parameterExpression = Expression.Parameter(typeof(AuthenticatedSessionInfo), (string)HBdw7eZvyfeygvuTm6x1(-35995181 ^ -36173223));
						num2 = 18;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
						{
							num2 = 11;
						}
						break;
					case 18:
						RemoteAddress = LinqUtils.NameOf(Expression.Lambda<Func<AuthenticatedSessionInfo, object>>(Expression.Property(parameterExpression, (MethodInfo)TCZqdJZv9DK4VcKkCPt9((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }));
						num2 = 10;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
						{
							num2 = 10;
						}
						break;
					case 22:
						UserId = LinqUtils.NameOf(Expression.Lambda<Func<AuthenticatedSessionInfo, object>>((Expression)WdNJy3ZvdeVdAFPd5n42(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }));
						num2 = 7;
						break;
					case 13:
						LastActionInfo = LinqUtils.NameOf(Expression.Lambda<Func<AuthenticatedSessionInfo, object>>(Expression.Property(parameterExpression, (MethodInfo)TCZqdJZv9DK4VcKkCPt9((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }));
						num2 = 21;
						break;
					case 17:
						parameterExpression = (ParameterExpression)NcZDnrZvM4xT3VfnEAoW(HILfXQZvmxMbZL6KkVj6(typeof(AuthenticatedSessionInfo).TypeHandle), HBdw7eZvyfeygvuTm6x1(0x1C9495B4 ^ 0x1C965E3E));
						num2 = 11;
						break;
					case 21:
						return;
					case 9:
						LastPingDate = LinqUtils.NameOf(Expression.Lambda<Func<AuthenticatedSessionInfo, object>>((Expression)PZxvqeZvJrnnWOYRVgrc(WdNJy3ZvdeVdAFPd5n42(parameterExpression, (MethodInfo)TCZqdJZv9DK4VcKkCPt9((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), typeof(object)), new ParameterExpression[1] { parameterExpression }));
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
						{
							num2 = 1;
						}
						break;
					case 19:
						parameterExpression = Expression.Parameter(HILfXQZvmxMbZL6KkVj6(typeof(AuthenticatedSessionInfo).TypeHandle), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1459557599 ^ -1459478357));
						num2 = 14;
						break;
					case 2:
						parameterExpression = (ParameterExpression)NcZDnrZvM4xT3VfnEAoW(HILfXQZvmxMbZL6KkVj6(typeof(AuthenticatedSessionInfo).TypeHandle), HBdw7eZvyfeygvuTm6x1(0x5F3078B6 ^ 0x5F32B33C));
						num2 = 5;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
						{
							num2 = 16;
						}
						break;
					default:
						SessionData = (string)HBdw7eZvyfeygvuTm6x1(-477139494 ^ -477542024);
						num2 = 6;
						break;
					case 8:
						parameterExpression = (ParameterExpression)NcZDnrZvM4xT3VfnEAoW(HILfXQZvmxMbZL6KkVj6(typeof(AuthenticatedSessionInfo).TypeHandle), HBdw7eZvyfeygvuTm6x1(--1360331293 ^ 0x5117C997));
						num2 = 5;
						break;
					case 12:
						CreationDate = LinqUtils.NameOf(Expression.Lambda<Func<AuthenticatedSessionInfo, object>>(Expression.Convert((Expression)WdNJy3ZvdeVdAFPd5n42(parameterExpression, (MethodInfo)TCZqdJZv9DK4VcKkCPt9((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), HILfXQZvmxMbZL6KkVj6(typeof(object).TypeHandle)), new ParameterExpression[1] { parameterExpression }));
						num2 = 8;
						break;
					case 5:
						LastActionDate = LinqUtils.NameOf(Expression.Lambda<Func<AuthenticatedSessionInfo, object>>((Expression)PZxvqeZvJrnnWOYRVgrc(WdNJy3ZvdeVdAFPd5n42(parameterExpression, (MethodInfo)TCZqdJZv9DK4VcKkCPt9((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), typeof(object)), new ParameterExpression[1] { parameterExpression }));
						num2 = 4;
						break;
					}
				}
			}

			internal static void YVWunGZv0ILmj8NLGnmK()
			{
				SingletonReader.JJCZtPuTvSt();
			}

			internal static Type HILfXQZvmxMbZL6KkVj6(RuntimeTypeHandle P_0)
			{
				return Type.GetTypeFromHandle(P_0);
			}

			internal static object HBdw7eZvyfeygvuTm6x1(int _0020)
			{
				return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
			}

			internal static object NcZDnrZvM4xT3VfnEAoW(Type P_0, object P_1)
			{
				return Expression.Parameter(P_0, (string)P_1);
			}

			internal static object PZxvqeZvJrnnWOYRVgrc(object P_0, Type P_1)
			{
				return Expression.Convert((Expression)P_0, P_1);
			}

			internal static object TCZqdJZv9DK4VcKkCPt9(RuntimeMethodHandle P_0)
			{
				return MethodBase.GetMethodFromHandle(P_0);
			}

			internal static object WdNJy3ZvdeVdAFPd5n42(object P_0, object P_1)
			{
				return Expression.Property((Expression)P_0, (MethodInfo)P_1);
			}

			internal static bool HdHm8hZv7FL8Tb7a3QMd()
			{
				return i5Kt8LZvATZSW7FwpwpQ == null;
			}

			internal static Fields bekk6AZvx2yXmumDQuQY()
			{
				return i5Kt8LZvATZSW7FwpwpQ;
			}
		}

		public const string TableName = "ActiveUserSession";
	}

	private static readonly string HeaderKeyRemoteAddress;

	private static AuthenticatedSessionInfo dR8IbEBjb8mACXFuVL2S;

	public Guid TicketUid
	{
		[CompilerGenerated]
		get
		{
			return _003CTicketUid_003Ek__BackingField;
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
					_003CTicketUid_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public AuthenticatedSessionStatus Status
	{
		[CompilerGenerated]
		get
		{
			return _003CStatus_003Ek__BackingField;
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
					_003CStatus_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
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

	public DateTime? Expiration { get; set; }

	public string SessionId
	{
		[CompilerGenerated]
		get
		{
			return _003CSessionId_003Ek__BackingField;
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
					_003CSessionId_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0)
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

	public object UserId
	{
		[CompilerGenerated]
		get
		{
			return _003CUserId_003Ek__BackingField;
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
					_003CUserId_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
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

	public string RemoteAddress
	{
		[CompilerGenerated]
		get
		{
			return _003CRemoteAddress_003Ek__BackingField;
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
					_003CRemoteAddress_003Ek__BackingField = value;
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

	public DateTime CreationDate
	{
		[CompilerGenerated]
		get
		{
			return _003CCreationDate_003Ek__BackingField;
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
					_003CCreationDate_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public DateTime LastActionDate
	{
		[CompilerGenerated]
		get
		{
			return _003CLastActionDate_003Ek__BackingField;
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
					_003CLastActionDate_003Ek__BackingField = value;
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

	public DateTime LastPingDate
	{
		[CompilerGenerated]
		get
		{
			return _003CLastPingDate_003Ek__BackingField;
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
					_003CLastPingDate_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public string LastActionInfo
	{
		[CompilerGenerated]
		get
		{
			return _003CLastActionInfo_003Ek__BackingField;
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
					_003CLastActionInfo_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public bool LastActionIsCurrent
	{
		[CompilerGenerated]
		get
		{
			return _003CLastActionIsCurrent_003Ek__BackingField;
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
					_003CLastActionIsCurrent_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public bool LastPingIsCurrent
	{
		[CompilerGenerated]
		get
		{
			return _003CLastPingIsCurrent_003Ek__BackingField;
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
					_003CLastPingIsCurrent_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
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

	public bool CreationIsCurrent
	{
		[CompilerGenerated]
		get
		{
			return _003CCreationIsCurrent_003Ek__BackingField;
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
					_003CCreationIsCurrent_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public AuthenticatedSessionInfo()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 3;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
		{
			num = 3;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				LastPingDate = CreationDate;
				num = 4;
				break;
			default:
				CreationDate = YXyl2gBjfYwHwZgEeWc0();
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
				{
					num = 0;
				}
				break;
			case 3:
				TicketUid = SE8ESeBjEQkiJcrSUMXI();
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
				{
					num = 0;
				}
				break;
			case 2:
				return;
			case 4:
				LastActionDate = CreationDate;
				num = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
				{
					num = 2;
				}
				break;
			}
		}
	}

	public AuthenticatedSessionInfo(Guid ticketUid, object userId, HttpContextBase httpContext)
	{
		//Discarded unreachable code: IL_001a, IL_001f
		rUPMU3BjQEqlak603mlS();
		base._002Ector();
		int num = 5;
		while (true)
		{
			switch (num)
			{
			case 6:
				LastActionDate = CreationDate;
				num = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
				{
					num = 2;
				}
				break;
			case 4:
				CreationDate = YXyl2gBjfYwHwZgEeWc0();
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
				{
					num = 0;
				}
				break;
			case 5:
				TicketUid = ticketUid;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0)
				{
					num = 1;
				}
				break;
			case 3:
				UpdateFromHttpContext(httpContext);
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
				{
					num = 4;
				}
				break;
			default:
				LastPingDate = CreationDate;
				num = 6;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
				{
					num = 5;
				}
				break;
			case 1:
				UserId = userId;
				num = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
				{
					num = 2;
				}
				break;
			case 2:
				return;
			}
		}
	}

	public void UpdateFromHttpContext(HttpContextBase httpContext)
	{
		//Discarded unreachable code: IL_00d4, IL_013b, IL_014a, IL_016b, IL_017a, IL_018b, IL_01bf
		int num = 9;
		string text = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				object obj;
				switch (num2)
				{
				case 1:
				case 2:
					if (text == null)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
						{
							num2 = 11;
						}
						continue;
					}
					goto default;
				case 12:
					LastActionInfo = text;
					num2 = 6;
					continue;
				case 7:
					text = text.Substring(1);
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0)
					{
						num2 = 1;
					}
					continue;
				default:
					if (uhs207BjiFe5U9ZlPT9p(text, p3vJu5BjVUPwLG24iCh2(-1217523399 ^ -1217435287), StringComparison.CurrentCultureIgnoreCase))
					{
						return;
					}
					goto case 11;
				case 10:
					if (!npZNssBjSbLAc3LCG5f4(text, p3vJu5BjVUPwLG24iCh2(0x7459E02 ^ 0x745FA52)))
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 != 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 7;
				case 14:
					LastPingIsCurrent = true;
					num2 = 16;
					continue;
				case 16:
					if (httpContext == null)
					{
						num = 15;
						break;
					}
					goto case 13;
				case 6:
					return;
				case 5:
					if (text != null)
					{
						num2 = 10;
						continue;
					}
					goto case 1;
				case 3:
				case 15:
					obj = null;
					goto IL_025d;
				case 13:
					if (gpd2LpBjCdWbdvYgmlXP(httpContext) == null)
					{
						num = 3;
						break;
					}
					obj = XKaFhOBjImIV0Gx9OIZL(gpd2LpBjCdWbdvYgmlXP(httpContext));
					goto IL_025d;
				case 4:
					LastActionIsCurrent = true;
					num2 = 12;
					continue;
				case 9:
					RemoteAddress = (string)((httpContext != null) ? (oI2wYhBjv7yWXFGOiVHx(((HttpRequestBase)gpd2LpBjCdWbdvYgmlXP(httpContext)).Headers, HeaderKeyRemoteAddress) ?? EwbMYuBj8J381HYodylq(gpd2LpBjCdWbdvYgmlXP(httpContext))) : null);
					num2 = 8;
					continue;
				case 8:
					SessionId = (string)((httpContext != null && QKTqSiBjZbAQQ0cROMlY(httpContext) != null) ? D6PwKYBju8mdUxEnHKtY(QKTqSiBjZbAQQ0cROMlY(httpContext)) : null);
					num2 = 14;
					continue;
				case 11:
					{
						num2 = 4;
						continue;
					}
					IL_025d:
					text = (string)obj;
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
					{
						num2 = 2;
					}
					continue;
				}
				break;
			}
		}
	}

	static AuthenticatedSessionInfo()
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
				rUPMU3BjQEqlak603mlS();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				HeaderKeyRemoteAddress = (string)p3vJu5BjVUPwLG24iCh2(0x12A5FAC7 ^ 0x12A482BB);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static Guid SE8ESeBjEQkiJcrSUMXI()
	{
		return Guid.NewGuid();
	}

	internal static DateTime YXyl2gBjfYwHwZgEeWc0()
	{
		return DateTime.Now;
	}

	internal static bool QPn5hABjhhwgVgsRqlsj()
	{
		return dR8IbEBjb8mACXFuVL2S == null;
	}

	internal static AuthenticatedSessionInfo WvlrhlBjGjlHV2Dxl8Ml()
	{
		return dR8IbEBjb8mACXFuVL2S;
	}

	internal static void rUPMU3BjQEqlak603mlS()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object gpd2LpBjCdWbdvYgmlXP(object P_0)
	{
		return ((HttpContextBase)P_0).Request;
	}

	internal static object oI2wYhBjv7yWXFGOiVHx(object P_0, object P_1)
	{
		return ((NameValueCollection)P_0).Get((string)P_1);
	}

	internal static object EwbMYuBj8J381HYodylq(object P_0)
	{
		return ((HttpRequestBase)P_0).UserHostAddress;
	}

	internal static object QKTqSiBjZbAQQ0cROMlY(object P_0)
	{
		return ((HttpContextBase)P_0).Session;
	}

	internal static object D6PwKYBju8mdUxEnHKtY(object P_0)
	{
		return ((HttpSessionStateBase)P_0).SessionID;
	}

	internal static object XKaFhOBjImIV0Gx9OIZL(object P_0)
	{
		return ((HttpRequestBase)P_0).RawUrl;
	}

	internal static object p3vJu5BjVUPwLG24iCh2(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool npZNssBjSbLAc3LCG5f4(object P_0, object P_1)
	{
		return ((string)P_0).StartsWith((string)P_1);
	}

	internal static bool uhs207BjiFe5U9ZlPT9p(object P_0, object P_1, StringComparison P_2)
	{
		return ((string)P_0).StartsWith((string)P_1, P_2);
	}
}
