using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Threading;
using EleWise.ELMA.Diagnostics.Metrics;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Threading;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Diagnostics;

[Serializable]
public sealed class CallContextInfo : IWorkTreeElement, IDisposable, ISerializable
{
	private readonly Stopwatch stopwatch;

	private long callIdCounter;

	private static long _callContextId;

	private readonly List<IWorkTreeElement> workTree;

	private AbstractCallInfo currentCall;

	[ThreadStatic]
	private static TimeSpan _oldRealTotalProcessTime;

	private TimeSpan totalProcessorTime;

	[ThreadStatic]
	private static TimeSpan _oldRealUserProcessorTime;

	private TimeSpan userProcessorTime;

	[ThreadStatic]
	private static TimeSpan _oldRealPrivilegedProcessorTime;

	private TimeSpan privilegedProcessorTime;

	internal static CallContextInfo UXIBw5Eov7VenVuOXbhf;

	public long Id
	{
		[CompilerGenerated]
		get
		{
			return _003CId_003Ek__BackingField;
		}
		[CompilerGenerated]
		private set
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
					_003CId_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public Guid Uid
	{
		[CompilerGenerated]
		get
		{
			return _003CUid_003Ek__BackingField;
		}
		[CompilerGenerated]
		private set
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
					_003CUid_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
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

	public long ManagedThreadId
	{
		[CompilerGenerated]
		get
		{
			return _003CManagedThreadId_003Ek__BackingField;
		}
		[CompilerGenerated]
		private set
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
					_003CManagedThreadId_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public Guid CreatedParentContextInfoUid
	{
		[CompilerGenerated]
		get
		{
			return _003CCreatedParentContextInfoUid_003Ek__BackingField;
		}
		[CompilerGenerated]
		internal set
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
					_003CCreatedParentContextInfoUid_003Ek__BackingField = value;
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

	public string Name
	{
		[CompilerGenerated]
		get
		{
			return _003CName_003Ek__BackingField;
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
					_003CName_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public IDictionary<string, string> Tags { get; set; }

	public string Description
	{
		[CompilerGenerated]
		get
		{
			return _003CDescription_003Ek__BackingField;
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
					_003CDescription_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
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

	public string UserHostAddress
	{
		[CompilerGenerated]
		get
		{
			return _003CUserHostAddress_003Ek__BackingField;
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
					_003CUserHostAddress_003Ek__BackingField = value;
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

	public string ServerHostName
	{
		[CompilerGenerated]
		get
		{
			return _003CServerHostName_003Ek__BackingField;
		}
		[CompilerGenerated]
		private set
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
					_003CServerHostName_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
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

	public string HttpMethod
	{
		[CompilerGenerated]
		get
		{
			return _003CHttpMethod_003Ek__BackingField;
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
					_003CHttpMethod_003Ek__BackingField = value;
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
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad != 0)
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

	public string UserName
	{
		[CompilerGenerated]
		get
		{
			return _003CUserName_003Ek__BackingField;
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
					_003CUserName_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public CallContextType? Type { get; private set; }

	public DateTime StartTime
	{
		[CompilerGenerated]
		get
		{
			return _003CStartTime_003Ek__BackingField;
		}
		[CompilerGenerated]
		private set
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
					_003CStartTime_003Ek__BackingField = value;
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

	public DateTime EndTime
	{
		[CompilerGenerated]
		get
		{
			return _003CEndTime_003Ek__BackingField;
		}
		[CompilerGenerated]
		internal set
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
					_003CEndTime_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa != 0)
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

	public TimeSpan TotalTime => Yq5NqwEoug0ddEoVZBU3(stopwatch);

	public TimeSpan TotalProcessorTime => totalProcessorTime;

	public TimeSpan UserProcessorTime => userProcessorTime;

	public TimeSpan PrivilegedProcessorTime => privilegedProcessorTime;

	public CallContextInfo ParentContextInfo
	{
		[CompilerGenerated]
		get
		{
			return _003CParentContextInfo_003Ek__BackingField;
		}
		[CompilerGenerated]
		internal set
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
					_003CParentContextInfo_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public CallContextInfo ChildContextInfo
	{
		[CompilerGenerated]
		get
		{
			return _003CChildContextInfo_003Ek__BackingField;
		}
		[CompilerGenerated]
		internal set
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
					_003CChildContextInfo_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public AbstractCallInfo CurrentCall
	{
		get
		{
			return currentCall;
		}
		internal set
		{
			int num = 3;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					LnhhJEEoIhhy1pvpQsgn(ParentContextInfo, value);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				case 3:
					currentCall = value;
					num2 = 2;
					break;
				case 2:
					if (ParentContextInfo == null)
					{
						return;
					}
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0)
					{
						num2 = 1;
					}
					break;
				}
			}
		}
	}

	public IEnumerable<IWorkTreeElement> WorkTree => workTree.ToArray();

	public MetricsContainer Metrics
	{
		[CompilerGenerated]
		get
		{
			return _003CMetrics_003Ek__BackingField;
		}
		[CompilerGenerated]
		private set
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
					_003CMetrics_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e != 0)
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

	public Exception Exception
	{
		[CompilerGenerated]
		get
		{
			return _003CException_003Ek__BackingField;
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
					_003CException_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
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

	internal CallContextInfo(CallContextType? type)
	{
		SingletonReader.JJCZtPuTvSt();
		workTree = new List<IWorkTreeElement>();
		base._002Ector();
		Id = Interlocked.Increment(ref _callContextId);
		Uid = Guid.NewGuid();
		ManagedThreadId = Thread.CurrentThread.ManagedThreadId;
		StartTime = DateTime.UtcNow;
		Type = type;
		ServerHostName = Environment.MachineName;
		stopwatch = Stopwatch.StartNew();
		Metrics = new MetricsContainer();
		Tags = new Dictionary<string, string>();
	}

	public IEnumerable<AbstractCallInfo> GetCallStack()
	{
		if (CurrentCall != null)
		{
			List<AbstractCallInfo> list = new List<AbstractCallInfo>();
			for (AbstractCallInfo parentCall = CurrentCall; parentCall != null; parentCall = parentCall.ParentCall)
			{
				list.Add(parentCall);
			}
			return list.ToArray();
		}
		return Enumerable.Empty<AbstractCallInfo>();
	}

	public void Dispose()
	{
		//Discarded unreachable code: IL_0031, IL_0040
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				return;
			case 3:
				((DiagnosticsManager)nv9XlOEoS80fd4O44W7G()).CloseCurrentSession((Exception)null);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				if (!KVWJ1rEoVNmJpF57rN9V())
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 3;
			case 0:
				return;
			}
		}
	}

	void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
	{
		//Discarded unreachable code: IL_0114, IL_0237, IL_0246, IL_0441, IL_0450, IL_045f, IL_057e, IL_0646, IL_0655, IL_06ba, IL_071d
		int num = 11;
		CallContextType? type = default(CallContextType?);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 43:
				{
					object obj = mMLcA9Eoi9ttE3yEhZq0(-521266112 ^ -521263962);
					type = Type;
					AgLEEMEoqFsAvFSY2F6I(info, obj, e4tbCBEokcEgHASlkmTl(type.Value));
					num2 = 9;
					continue;
				}
				case 30:
					return;
				case 35:
					AgLEEMEoqFsAvFSY2F6I(info, mMLcA9Eoi9ttE3yEhZq0(-957824448 ^ -957550756), privilegedProcessorTime);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
					{
						num2 = 1;
					}
					continue;
				case 41:
					AgLEEMEoqFsAvFSY2F6I(info, mMLcA9Eoi9ttE3yEhZq0(-477139494 ^ -477412216), WorkTree);
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0)
					{
						num2 = 2;
					}
					continue;
				case 24:
					AgLEEMEoqFsAvFSY2F6I(info, mMLcA9Eoi9ttE3yEhZq0(0x2A7797B7 ^ 0x2A73BB9B), ParentContextInfo.Uid);
					num = 38;
					break;
				case 13:
					AgLEEMEoqFsAvFSY2F6I(info, mMLcA9Eoi9ttE3yEhZq0(0x66F566B6 ^ 0x66F14A08), UserId.ToString());
					num = 21;
					break;
				case 18:
					if (!WorkTree.Any())
					{
						num2 = 7;
						continue;
					}
					goto case 41;
				case 38:
					if (!luCtGxEoX14PSfgnlEtk(Name))
					{
						num2 = 39;
						continue;
					}
					goto case 5;
				case 21:
					if (!luCtGxEoX14PSfgnlEtk(UserName))
					{
						num2 = 37;
						continue;
					}
					goto case 31;
				case 19:
					return;
				case 26:
				case 32:
					if (luCtGxEoX14PSfgnlEtk(HttpMethod))
					{
						num2 = 29;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
						{
							num2 = 21;
						}
						continue;
					}
					goto default;
				case 17:
					AgLEEMEoqFsAvFSY2F6I(info, mMLcA9Eoi9ttE3yEhZq0(0x5F3078B6 ^ 0x5F3454EE), Tags);
					num2 = 3;
					continue;
				case 40:
					info.AddValue((string)mMLcA9Eoi9ttE3yEhZq0(-643786247 ^ -643517939), CreatedParentContextInfoUid);
					num2 = 14;
					continue;
				case 9:
				case 16:
					UVnvsuEonIWvc17dLKvg(info, mMLcA9Eoi9ttE3yEhZq0(0x10E41EDB ^ 0x10E03625), StartTime);
					num2 = 8;
					continue;
				case 1:
					if (WorkTree == null)
					{
						num2 = 12;
						continue;
					}
					goto case 18;
				case 39:
					AgLEEMEoqFsAvFSY2F6I(info, mMLcA9Eoi9ttE3yEhZq0(0x5F3078B6 ^ 0x5F300B76), Name);
					num2 = 5;
					continue;
				case 20:
					AgLEEMEoqFsAvFSY2F6I(info, z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1867379187 ^ 0x6F49DD97), UserHostAddress);
					num2 = 13;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
					{
						num2 = 36;
					}
					continue;
				case 10:
					AgLEEMEoqFsAvFSY2F6I(info, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-951514650 ^ -951490956), Uid);
					num2 = 25;
					continue;
				case 33:
					AgLEEMEoqFsAvFSY2F6I(info, mMLcA9Eoi9ttE3yEhZq0(-1886646897 ^ -1886903943), userProcessorTime);
					num2 = 29;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0)
					{
						num2 = 35;
					}
					continue;
				case 8:
					UVnvsuEonIWvc17dLKvg(info, mMLcA9Eoi9ttE3yEhZq0(-488881205 ^ -489133345), EndTime);
					num2 = 15;
					continue;
				case 4:
				case 36:
					if (luCtGxEoX14PSfgnlEtk(ServerHostName))
					{
						num2 = 11;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0)
						{
							num2 = 32;
						}
						continue;
					}
					goto case 34;
				case 14:
					if (ParentContextInfo != null)
					{
						num2 = 24;
						continue;
					}
					goto case 38;
				default:
					AgLEEMEoqFsAvFSY2F6I(info, mMLcA9Eoi9ttE3yEhZq0(-1767720453 ^ -1767467683), HttpMethod);
					num2 = 28;
					continue;
				case 42:
					AgLEEMEoqFsAvFSY2F6I(info, mMLcA9Eoi9ttE3yEhZq0(-1767720453 ^ -1767467723), totalProcessorTime);
					num = 33;
					break;
				case 31:
					type = Type;
					num2 = 27;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
					{
						num2 = 24;
					}
					continue;
				case 3:
					if (UserHostAddress.IsNullOrEmpty())
					{
						num2 = 4;
						continue;
					}
					goto case 20;
				case 6:
				case 23:
					if (xYxJtmEoTDUkRn5IoZZr(Tags) > 0)
					{
						num2 = 9;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
						{
							num2 = 17;
						}
						continue;
					}
					goto case 3;
				case 22:
					info.AddValue((string)mMLcA9Eoi9ttE3yEhZq0(0x63ABA4E8 ^ 0x63AF8D8E), Exception);
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca != 0)
					{
						num2 = 19;
					}
					continue;
				case 34:
					AgLEEMEoqFsAvFSY2F6I(info, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-195614443 ^ -195885677), ServerHostName);
					num2 = 26;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
					{
						num2 = 14;
					}
					continue;
				case 11:
					w5FmwbEoRYis1tXZCUBL(info, mMLcA9Eoi9ttE3yEhZq0(0x7C1EE318 ^ 0x7C1E6246), Id);
					num2 = 10;
					continue;
				case 28:
				case 29:
					if (UserId != null)
					{
						num2 = 13;
						continue;
					}
					goto case 21;
				case 37:
					info.AddValue((string)mMLcA9Eoi9ttE3yEhZq0(0x76DD48E ^ 0x76D8102), UserName);
					num2 = 15;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
					{
						num2 = 31;
					}
					continue;
				case 5:
					if (luCtGxEoX14PSfgnlEtk(Description))
					{
						num2 = 23;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
						{
							num2 = 22;
						}
						continue;
					}
					goto case 44;
				case 15:
					AgLEEMEoqFsAvFSY2F6I(info, mMLcA9Eoi9ttE3yEhZq0(-1824388195 ^ -1824120133), TotalTime);
					num2 = 42;
					continue;
				case 25:
					if (k3IviCEoK5IiVKj3iB1y(CreatedParentContextInfoUid, Guid.Empty))
					{
						num2 = 32;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
						{
							num2 = 40;
						}
						continue;
					}
					goto case 14;
				case 2:
				case 7:
				case 12:
					if (Exception == null)
					{
						num2 = 10;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
						{
							num2 = 30;
						}
						continue;
					}
					goto case 22;
				case 44:
					AgLEEMEoqFsAvFSY2F6I(info, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x17ADCCD8 ^ 0x17ACFD02), Description);
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
					{
						num2 = 6;
					}
					continue;
				case 27:
					if (!type.HasValue)
					{
						num2 = 16;
						continue;
					}
					goto case 43;
				}
				break;
			}
		}
	}

	internal long GetNewCallId()
	{
		//Discarded unreachable code: IL_006a, IL_0079
		int num = 3;
		int num2 = num;
		long result = default(long);
		while (true)
		{
			switch (num2)
			{
			case 1:
				return oe9OixEoO88DnejBC70f(ParentContextInfo);
			case 2:
				result = ++callIdCounter;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				if (ParentContextInfo == null)
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
					{
						num2 = 2;
					}
					break;
				}
				goto case 1;
			default:
				return result;
			}
		}
	}

	internal void AddWorkTreeElement(IWorkTreeElement call)
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
				workTree.Add(call);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	internal void CloseCallContext(Exception ex)
	{
		int num = 4;
		TimeSpan timeSpan2 = default(TimeSpan);
		TimeSpan timeSpan = default(TimeSpan);
		TimeSpan timeSpan3 = default(TimeSpan);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 4:
					EndTime = bcMKfFEo2URCjk63F47j();
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
					{
						num2 = 1;
					}
					continue;
				case 9:
					_oldRealUserProcessorTime = timeSpan2;
					num = 2;
					break;
				case 11:
					timeSpan2 = J8bij6EoPUM5qvuNkK9J();
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
					{
						num2 = 7;
					}
					continue;
				case 5:
					timeSpan = ProcessThreadInfo.TotalProcessorTime;
					num2 = 11;
					continue;
				case 12:
					_oldRealPrivilegedProcessorTime = timeSpan3;
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
					{
						num2 = 6;
					}
					continue;
				case 3:
					Exception = ex;
					num2 = 10;
					continue;
				case 10:
					TYvWJCEoequ6N8oQd3qJ(stopwatch);
					num = 5;
					break;
				case 2:
					privilegedProcessorTime = mfbIbZEoNtT3lSailUvH(timeSpan3, _oldRealPrivilegedProcessorTime);
					num2 = 12;
					continue;
				case 7:
					timeSpan3 = q57oeREo16p7dgMJtMmM();
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
					{
						num2 = 1;
					}
					continue;
				default:
					_oldRealTotalProcessTime = timeSpan;
					num2 = 8;
					continue;
				case 8:
					userProcessorTime = mfbIbZEoNtT3lSailUvH(timeSpan2, _oldRealUserProcessorTime);
					num2 = 9;
					continue;
				case 1:
					totalProcessorTime = mfbIbZEoNtT3lSailUvH(timeSpan, _oldRealTotalProcessTime);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
					{
						num2 = 0;
					}
					continue;
				case 6:
					return;
				}
				break;
			}
		}
	}

	internal static bool WfMgxCEo8uhmuxfqJTDs()
	{
		return UXIBw5Eov7VenVuOXbhf == null;
	}

	internal static CallContextInfo h6wnFsEoZYIDFNkc6WNk()
	{
		return UXIBw5Eov7VenVuOXbhf;
	}

	internal static TimeSpan Yq5NqwEoug0ddEoVZBU3(object P_0)
	{
		return ((Stopwatch)P_0).Elapsed;
	}

	internal static void LnhhJEEoIhhy1pvpQsgn(object P_0, object P_1)
	{
		((CallContextInfo)P_0).CurrentCall = (AbstractCallInfo)P_1;
	}

	internal static bool KVWJ1rEoVNmJpF57rN9V()
	{
		return DiagnosticsManager.Initialized;
	}

	internal static object nv9XlOEoS80fd4O44W7G()
	{
		return DiagnosticsManager.Instance;
	}

	internal static object mMLcA9Eoi9ttE3yEhZq0(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void w5FmwbEoRYis1tXZCUBL(object P_0, object P_1, long P_2)
	{
		((SerializationInfo)P_0).AddValue((string)P_1, P_2);
	}

	internal static void AgLEEMEoqFsAvFSY2F6I(object P_0, object P_1, object P_2)
	{
		((SerializationInfo)P_0).AddValue((string)P_1, P_2);
	}

	internal static bool k3IviCEoK5IiVKj3iB1y(Guid P_0, Guid P_1)
	{
		return P_0 != P_1;
	}

	internal static bool luCtGxEoX14PSfgnlEtk(object P_0)
	{
		return ((string)P_0).IsNullOrEmpty();
	}

	internal static int xYxJtmEoTDUkRn5IoZZr(object P_0)
	{
		return ((ICollection<KeyValuePair<string, string>>)P_0).Count;
	}

	internal static object e4tbCBEokcEgHASlkmTl(Enum enumValue)
	{
		return enumValue.GetDisplayName();
	}

	internal static void UVnvsuEonIWvc17dLKvg(object P_0, object P_1, DateTime P_2)
	{
		((SerializationInfo)P_0).AddValue((string)P_1, P_2);
	}

	internal static long oe9OixEoO88DnejBC70f(object P_0)
	{
		return ((CallContextInfo)P_0).GetNewCallId();
	}

	internal static DateTime bcMKfFEo2URCjk63F47j()
	{
		return DateTime.UtcNow;
	}

	internal static void TYvWJCEoequ6N8oQd3qJ(object P_0)
	{
		((Stopwatch)P_0).Stop();
	}

	internal static TimeSpan J8bij6EoPUM5qvuNkK9J()
	{
		return ProcessThreadInfo.UserProcessorTime;
	}

	internal static TimeSpan q57oeREo16p7dgMJtMmM()
	{
		return ProcessThreadInfo.PrivilegedProcessorTime;
	}

	internal static TimeSpan mfbIbZEoNtT3lSailUvH(TimeSpan P_0, TimeSpan P_1)
	{
		return P_0 - P_1;
	}
}
