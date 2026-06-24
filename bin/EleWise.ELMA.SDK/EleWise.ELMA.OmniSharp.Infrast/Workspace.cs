using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Scripts.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.OmniSharp.Infrastructure;

internal class Workspace : IDisposable
{
	private static readonly string[] ValidChangeReferenceCommands;

	private static readonly WebExceptionStatus[] TransientFailures;

	private readonly TimeSpan defaultInterval;

	private readonly HashSet<string> addedAssembliesSync;

	private readonly HashSet<string> addedWebReferencesSync;

	private readonly ConcurrentQueue<ReferenceOperation> referenceQueue;

	private string key;

	private volatile bool isCreated;

	private volatile bool mustRestoreReferences;

	private readonly SimpleWebClient client;

	private readonly IConnectionMonitor monitor;

	private readonly ILogger logger;

	private readonly string project;

	private Timer tracker;

	internal static Workspace PJZWkFWrt9yxZJyj9Dy5;

	public string FileName { get; }

	public string Key => key;

	public string ProjectFolder { get; }

	public string ProjectPath { get; }

	protected virtual bool IsWorkspaceCreated => isCreated;

	protected bool IsOffline => oi9jylWrlitQZ77KgioG(monitor);

	private bool MustRestoreReferences => mustRestoreReferences;

	protected virtual bool HasUnsyncItems
	{
		get
		{
			//Discarded unreachable code: IL_004a, IL_0059, IL_0097, IL_00a6
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 4:
					if (MustRestoreReferences)
					{
						num2 = 3;
						break;
					}
					goto case 2;
				case 1:
					if (!IsWorkspaceCreated)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 4;
				case 2:
					return HasUnsyncReferences;
				default:
					return true;
				}
			}
		}
	}

	protected virtual bool HasUnsyncReferences => !R2yOCdWrr0jf1fV3Oja0(referenceQueue);

	private bool IsReferencesSyncingNow => referenceQueue.ToArray().Any((ReferenceOperation m) => m.IsSyncingNow);

	public Workspace(string fileName, string projectPath, Func<string, string> csprojPathProvider, SimpleWebClient client, IConnectionMonitor monitor, ILogger logger)
	{
		SingletonReader.JJCZtPuTvSt();
		defaultInterval = TimeSpan.FromSeconds(2.0);
		addedAssembliesSync = new HashSet<string>();
		addedWebReferencesSync = new HashSet<string>();
		referenceQueue = new ConcurrentQueue<ReferenceOperation>();
		base._002Ector();
		Contract.ArgumentNotNull(csprojPathProvider, z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1867379187 ^ 0x6F4FC7E5));
		FileName = fileName;
		ProjectFolder = projectPath;
		ProjectPath = csprojPathProvider(projectPath);
		this.client = client;
		this.logger = logger;
		this.monitor = monitor;
		project = new DirectoryInfo(projectPath).Name;
		tracker = new Timer(Synchronize);
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
				tracker = null;
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
			{
				Timer timer = tracker;
				if (timer == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
					{
						num2 = 0;
					}
				}
				else
				{
					IIISocWr6kl7SeUAo5X0(timer);
					num2 = 3;
				}
				break;
			}
			case 2:
				return;
			}
		}
	}

	[AsyncStateMachine(typeof(_003CCreate_003Ed__31))]
	public Task<bool> Create()
	{
		_003CCreate_003Ed__31 stateMachine = default(_003CCreate_003Ed__31);
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<bool>.Create();
		stateMachine._003C_003E1__state = -1;
		AsyncTaskMethodBuilder<bool> _003C_003Et__builder = stateMachine._003C_003Et__builder;
		_003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	public Task<string> Query(OmniSharpRequest request)
	{
		if (!IsWorkspaceCreated || IsOffline)
		{
			return Task.FromResult(string.Empty);
		}
		try
		{
			string data = ProduceCodeQueryPostData(request);
			return client.Post(request.Command, data);
		}
		catch (WebException)
		{
			return Task.FromResult(string.Empty);
		}
	}

	public Task<bool> AddReferences(IEnumerable<string> assembliesPath, IEnumerable<string> webReferencesPath)
	{
		return ChangeReferences(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x26FFCB59 ^ 0x26FDFD67), assembliesPath, webReferencesPath);
	}

	public Task<bool> RemoveReferences(IEnumerable<string> assembliesPath, IEnumerable<string> webReferencesPath)
	{
		return ChangeReferences(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-629844702 ^ -629710016), assembliesPath, webReferencesPath);
	}

	public void ForceRestore()
	{
		//Discarded unreachable code: IL_00f6, IL_0105, IL_013a, IL_0149
		int num = 9;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					PrintDebug((string)gc0w6NWrHZY3thQRLmHi(0xE1229CF ^ 0xE101F45), () => (string)gc0w6NWrHZY3thQRLmHi(0x638095EB ^ 0x6382AFE1) + FormatChangeReferencesCommand((string)gc0w6NWrHZY3thQRLmHi(-1487388570 ^ -1487248548), addedAssembliesSync, addedWebReferencesSync));
					num2 = 4;
					break;
				case 7:
					if (addedWebReferencesSync.Count <= 0)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b != 0)
						{
							num2 = 1;
						}
						break;
					}
					goto default;
				case 9:
					isCreated = false;
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
					{
						num2 = 8;
					}
					break;
				case 8:
					if (addedAssembliesSync.Count > 0)
					{
						goto end_IL_0012;
					}
					goto case 7;
				case 6:
					return;
				default:
					mustRestoreReferences = true;
					num2 = 5;
					break;
				case 1:
				case 5:
					key = string.Empty;
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
					{
						num2 = 3;
					}
					break;
				case 4:
					ScheduleNextSync();
					num2 = 6;
					break;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 2;
		}
	}

	[AsyncStateMachine(typeof(_003CChangeReferences_003Ed__36))]
	public Task<bool> ChangeReferences(string command, IEnumerable<string> assembliesPath, IEnumerable<string> webReferencesPath)
	{
		_003CChangeReferences_003Ed__36 stateMachine = default(_003CChangeReferences_003Ed__36);
		stateMachine._003C_003E4__this = this;
		stateMachine.command = command;
		stateMachine.assembliesPath = assembliesPath;
		stateMachine.webReferencesPath = webReferencesPath;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<bool>.Create();
		stateMachine._003C_003E1__state = -1;
		AsyncTaskMethodBuilder<bool> _003C_003Et__builder = stateMachine._003C_003Et__builder;
		_003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[AsyncStateMachine(typeof(_003CSendCreateWorkspaceCommand_003Ed__37))]
	private Task<Dictionary<string, string>> SendCreateWorkspaceCommand()
	{
		_003CSendCreateWorkspaceCommand_003Ed__37 stateMachine = default(_003CSendCreateWorkspaceCommand_003Ed__37);
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<Dictionary<string, string>>.Create();
		stateMachine._003C_003E1__state = -1;
		AsyncTaskMethodBuilder<Dictionary<string, string>> _003C_003Et__builder = stateMachine._003C_003Et__builder;
		_003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[AsyncStateMachine(typeof(_003CSendChangeReferencesCommand_003Ed__38))]
	private Task SendChangeReferencesCommand(string command, IEnumerable<string> assembliesPath, IEnumerable<string> webReferencesPath)
	{
		_003CSendChangeReferencesCommand_003Ed__38 stateMachine = default(_003CSendChangeReferencesCommand_003Ed__38);
		stateMachine._003C_003E4__this = this;
		stateMachine.command = command;
		stateMachine.assembliesPath = assembliesPath;
		stateMachine.webReferencesPath = webReferencesPath;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		stateMachine._003C_003E1__state = -1;
		AsyncTaskMethodBuilder _003C_003Et__builder = stateMachine._003C_003Et__builder;
		_003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	private Exception ConvertWebExceptionToWorkspaceError(string function, WebException ex)
	{
		//Discarded unreachable code: IL_0052, IL_0061
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (qouvGNWrABv47kunaiC4(ex))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			case 2:
				return new FatalWorkspaceError(FormatDebugMessage(function, (string)gc0w6NWrHZY3thQRLmHi(0x2ACE37D ^ 0x2AED5DB)), ex);
			default:
				return new TransientWorkspaceError(FormatDebugMessage(function, (string)G29aSnWrxRRO3Ia18qj6(gc0w6NWrHZY3thQRLmHi(0x12441CA4 ^ 0x12462A7E), mn9LykWr7JMjkaBkif6n(ex), gc0w6NWrHZY3thQRLmHi(0x31326106 ^ 0x31327EBA))), ex);
			}
		}
	}

	private void MergeReferences(string command, IEnumerable<string> assembliesPath, IEnumerable<string> webReferencesPath)
	{
		if (command == z2jc63fLkugS1X8Q9N.tE1kD1vbB(-675505729 ^ -675369087))
		{
			addedAssembliesSync.AddRange(assembliesPath);
			addedWebReferencesSync.AddRange(webReferencesPath);
		}
		else
		{
			if (!(command == z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1638402543 ^ -1638547341)))
			{
				throw new Exception(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1837662597 ^ -1837807263) + command);
			}
			assembliesPath.ForEach(delegate(string m)
			{
				int num3 = 1;
				int num4 = num3;
				while (true)
				{
					switch (num4)
					{
					default:
						return;
					case 0:
						return;
					case 1:
						addedAssembliesSync.Remove(m);
						num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0)
						{
							num4 = 0;
						}
						break;
					}
				}
			});
			webReferencesPath.ForEach(delegate(string m)
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
						addedWebReferencesSync.Remove(m);
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
						{
							num2 = 0;
						}
						break;
					case 0:
						return;
					}
				}
			});
		}
		PrintDebug(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x35C0467B ^ 0x35C27119), () => (string)UJr8ntWrc0IgLewfmoev(gc0w6NWrHZY3thQRLmHi(0xE1229CF ^ 0xE1013FB), FormatChangeReferencesCommand((string)gc0w6NWrHZY3thQRLmHi(0xD3DEF7E ^ 0xD3FCC44), addedAssembliesSync, addedWebReferencesSync)));
	}

	private string ProduceInitWorkspacePostData()
	{
		return (string)G29aSnWrxRRO3Ia18qj6(gc0w6NWrHZY3thQRLmHi(-345420348 ^ -345277888), DoubleSlashes(ProjectFolder), gc0w6NWrHZY3thQRLmHi(-1487388570 ^ -1487243268));
	}

	private string ProduceCodeQueryPostData(OmniSharpRequest request)
	{
		int num = 2;
		int num2 = num;
		string text = default(string);
		while (true)
		{
			switch (num2)
			{
			case 1:
				text = (string)v3YVr8WrMQ7iVyp3a7LX(new string[6]
				{
					text,
					(string)gc0w6NWrHZY3thQRLmHi(-1886646897 ^ -1886504403),
					Key,
					(string)gc0w6NWrHZY3thQRLmHi(-672123589 ^ -672005389),
					DoubleSlashes(FileName),
					(string)gc0w6NWrHZY3thQRLmHi(-1939377524 ^ -1939520234)
				});
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				return text;
			case 2:
				text = (string)w5ccpXWryj3SUDd5gqH1(k46qBVWr0c04wtpGJ9Bc(request), 0, dquWXDWrm4xMaRGoCk0l(k46qBVWr0c04wtpGJ9Bc(request)) - 1);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	private string ProduceReferencePostData(IEnumerable<string> assembliesPath, IEnumerable<string> webReferencesPath)
	{
		string text = string.Join(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1DE3DD89 ^ 0x1DE38F79), assembliesPath.Select((string p) => (string)yNIofvWrzwPQB6mH69hN(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138160520 ^ -2138277866), DoubleSlashes(p))));
		string text2 = string.Join(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-70007027 ^ -70019587), webReferencesPath.Select((string p) => (string)yNIofvWrzwPQB6mH69hN(gc0w6NWrHZY3thQRLmHi(-1459557599 ^ -1459433137), DoubleSlashes(p))));
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1710575414 ^ -1710717150) + Key + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-16752921 ^ -16619799) + DoubleSlashes(ProjectPath) + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-281842504 ^ -281979776) + text + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-606654180 ^ -606795404) + text2 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5DD55050 ^ 0x5DD768CE);
	}

	private string DoubleSlashes(string path)
	{
		return (string)JYUNUXWrJDLRYEo3Uxur(path, gc0w6NWrHZY3thQRLmHi(0x20261A4F ^ 0x20260539), gc0w6NWrHZY3thQRLmHi(-138018305 ^ -138010927));
	}

	[AsyncStateMachine(typeof(_003CSynchronize_003Ed__45))]
	private void Synchronize(object state)
	{
		int num = 4;
		int num2 = num;
		AsyncVoidMethodBuilder _003C_003Et__builder = default(AsyncVoidMethodBuilder);
		_003CSynchronize_003Ed__45 stateMachine = default(_003CSynchronize_003Ed__45);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 5:
				_003C_003Et__builder.Start(ref stateMachine);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			case 1:
				stateMachine._003C_003E1__state = -1;
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
				{
					num2 = 1;
				}
				break;
			case 4:
				stateMachine._003C_003E4__this = this;
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0)
				{
					num2 = 2;
				}
				break;
			case 3:
				stateMachine._003C_003Et__builder = bx00wIWr9UeXGHwMPZMt();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				_003C_003Et__builder = stateMachine._003C_003Et__builder;
				num2 = 5;
				break;
			}
		}
	}

	[AsyncStateMachine(typeof(_003CRestoreReferences_003Ed__46))]
	private Task RestoreReferences()
	{
		int num = 4;
		int num2 = num;
		_003CRestoreReferences_003Ed__46 stateMachine = default(_003CRestoreReferences_003Ed__46);
		AsyncTaskMethodBuilder _003C_003Et__builder = default(AsyncTaskMethodBuilder);
		while (true)
		{
			switch (num2)
			{
			case 1:
				return stateMachine._003C_003Et__builder.Task;
			case 4:
				stateMachine._003C_003E4__this = this;
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
				{
					num2 = 1;
				}
				break;
			default:
				_003C_003Et__builder.Start(ref stateMachine);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
				{
					num2 = 1;
				}
				break;
			case 2:
				stateMachine._003C_003E1__state = -1;
				num2 = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
				{
					num2 = 3;
				}
				break;
			case 3:
				stateMachine._003C_003Et__builder = Kmw4VxWrdkD7jRyNunxG();
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0)
				{
					num2 = 2;
				}
				break;
			case 5:
				_003C_003Et__builder = stateMachine._003C_003Et__builder;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	[AsyncStateMachine(typeof(_003CSendReferences_003Ed__47))]
	private Task SendReferences()
	{
		int num = 3;
		int num2 = num;
		_003CSendReferences_003Ed__47 stateMachine = default(_003CSendReferences_003Ed__47);
		AsyncTaskMethodBuilder _003C_003Et__builder = default(AsyncTaskMethodBuilder);
		while (true)
		{
			switch (num2)
			{
			case 1:
				stateMachine._003C_003E1__state = -1;
				num2 = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
				{
					num2 = 5;
				}
				break;
			case 5:
				_003C_003Et__builder = stateMachine._003C_003Et__builder;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				return stateMachine._003C_003Et__builder.Task;
			case 3:
				stateMachine._003C_003E4__this = this;
				num2 = 2;
				break;
			case 2:
				stateMachine._003C_003Et__builder = Kmw4VxWrdkD7jRyNunxG();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
				{
					num2 = 1;
				}
				break;
			default:
				_003C_003Et__builder.Start(ref stateMachine);
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	protected virtual void ScheduleNextSync()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			default:
				BdX57lWrgrdwJ22Ptnw8(tracker, defaultInterval, Timeout.InfiniteTimeSpan);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				PrintDebug((string)gc0w6NWrHZY3thQRLmHi(-583745292 ^ -583600036), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x53CB464B ^ 0x53C97E87));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	protected virtual void EnqueueReferenceChanges(string command, IEnumerable<string> assembliesPath, IEnumerable<string> webReferencesPath)
	{
		_003C_003Ec__DisplayClass61_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass61_0();
		CS_0024_003C_003E8__locals0._003C_003E4__this = this;
		CS_0024_003C_003E8__locals0.command = command;
		CS_0024_003C_003E8__locals0.assemblies = assembliesPath.ToArray();
		CS_0024_003C_003E8__locals0.webServices = webReferencesPath.ToArray();
		if (CS_0024_003C_003E8__locals0.assemblies.Length == 0 && CS_0024_003C_003E8__locals0.webServices.Length == 0)
		{
			PrintDebug(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1317790512 ^ -1317657560), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1767720453 ^ -1767866159));
			return;
		}
		referenceQueue.Enqueue(new ReferenceOperation(CS_0024_003C_003E8__locals0.command, CS_0024_003C_003E8__locals0.assemblies, CS_0024_003C_003E8__locals0.webServices));
		PrintDebug(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1824388195 ^ -1824509083), () => (string)_003C_003Ec__DisplayClass61_0.i2BxmgQz3iKqPtZNWcNN(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3C5338FF ^ 0x3C56AB99), CS_0024_003C_003E8__locals0._003C_003E4__this.FormatChangeReferencesCommand(CS_0024_003C_003E8__locals0.command, CS_0024_003C_003E8__locals0.assemblies, CS_0024_003C_003E8__locals0.webServices)));
	}

	private void CheckIfOffline(string function)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (IsOffline)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0)
					{
						num2 = 0;
					}
					break;
				}
				return;
			default:
				throw new TransientWorkspaceError(FormatDebugMessage(function, (string)gc0w6NWrHZY3thQRLmHi(0x26FFCB59 ^ 0x26FDF237)));
			}
		}
	}

	private void PrintInfo(string function, string message)
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
				faZBriWr5JQyUW3kHJnQ(logger, FormatDebugMessage(function, message));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private void PrintDebug(string function, Func<string> messageProvider)
	{
		if (logger.IsDebugEnabled())
		{
			logger.Debug(FormatDebugMessage(function, messageProvider()));
		}
	}

	private void PrintTransientWorkspaceError(TransientWorkspaceError ex)
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
				aInAj4WrjhfXjlECi9Bt(logger, mn9LykWr7JMjkaBkif6n(ex));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private void PrintFatalWorkspaceError(FatalWorkspaceError ex)
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
				YYtZY5WrYxrPtD8GQ1ZC(logger, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-889460160 ^ -889596966), ex);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	private void PrintDebug(string function, string message)
	{
		int num = 1;
		_003C_003Ec__DisplayClass67_0 _003C_003Ec__DisplayClass67_ = default(_003C_003Ec__DisplayClass67_0);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					_003C_003Ec__DisplayClass67_ = new _003C_003Ec__DisplayClass67_0();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
					{
						num2 = 0;
					}
					continue;
				case 3:
					PrintDebug(function, _003C_003Ec__DisplayClass67_._003CPrintDebug_003Eb__0);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca != 0)
					{
						num2 = 2;
					}
					continue;
				case 2:
					return;
				}
				break;
			}
			_003C_003Ec__DisplayClass67_.message = message;
			num = 3;
		}
	}

	private string FormatDebugMessage(string function, string message)
	{
		return (string)v3YVr8WrMQ7iVyp3a7LX(new string[6]
		{
			(string)gc0w6NWrHZY3thQRLmHi(0x63ABA4E8 ^ 0x63A99D20),
			project,
			z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x10E41EDB ^ 0x10E6270F),
			function,
			(string)gc0w6NWrHZY3thQRLmHi(-2112703338 ^ -2112693054),
			message
		});
	}

	private string FormatChangeReferencesCommand(string command, IEnumerable<string> assemblies, IEnumerable<string> webServices)
	{
		string text = string.Join(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-882126494 ^ -882146414), assemblies.Select(Path.GetFileName));
		string text2 = string.Join(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x53CB464B ^ 0x53CB14BB), webServices.Select(Path.GetFileName));
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3B36AB09 ^ 0x3B3492E9) + command + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6A81B9B4 ^ 0x6A83805A) + text + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x53CACA3 ^ 0x53E955F) + text2 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-398663332 ^ -398655776);
	}

	private static bool IsTransientConnectionFailure(object exception)
	{
		return TransientFailures.Contains(Ax0GxhWrLdYpwDtIb0Px(exception));
	}

	static Workspace()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
			{
				WebExceptionStatus[] array = new WebExceptionStatus[3];
				EFYcZAWrslFlrEMB7RAl(array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
				TransientFailures = array;
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
				{
					num2 = 3;
				}
				break;
			}
			case 1:
				upmYGMWrUS2RTp6A80xY();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				return;
			default:
				ValidChangeReferenceCommands = new string[2]
				{
					(string)gc0w6NWrHZY3thQRLmHi(0x12A5FAC7 ^ 0x12A7CCF9),
					(string)gc0w6NWrHZY3thQRLmHi(-1870892489 ^ -1870773163)
				};
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static void IIISocWr6kl7SeUAo5X0(object P_0)
	{
		((Timer)P_0).Dispose();
	}

	internal static bool hjr0rbWrwQVhdmGvt3oZ()
	{
		return PJZWkFWrt9yxZJyj9Dy5 == null;
	}

	internal static Workspace pJ8rK9Wr4bM1xXlL0RbP()
	{
		return PJZWkFWrt9yxZJyj9Dy5;
	}

	internal static object gc0w6NWrHZY3thQRLmHi(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool qouvGNWrABv47kunaiC4(object P_0)
	{
		return IsTransientConnectionFailure(P_0);
	}

	internal static object mn9LykWr7JMjkaBkif6n(object P_0)
	{
		return ((Exception)P_0).Message;
	}

	internal static object G29aSnWrxRRO3Ia18qj6(object P_0, object P_1, object P_2)
	{
		return (string)P_0 + (string)P_1 + (string)P_2;
	}

	internal static object k46qBVWr0c04wtpGJ9Bc(object P_0)
	{
		return ((OmniSharpRequest)P_0).PostData;
	}

	internal static int dquWXDWrm4xMaRGoCk0l(object P_0)
	{
		return ((string)P_0).Length;
	}

	internal static object w5ccpXWryj3SUDd5gqH1(object P_0, int P_1, int P_2)
	{
		return ((string)P_0).Substring(P_1, P_2);
	}

	internal static object v3YVr8WrMQ7iVyp3a7LX(object P_0)
	{
		return string.Concat((string[])P_0);
	}

	internal static object JYUNUXWrJDLRYEo3Uxur(object P_0, object P_1, object P_2)
	{
		return ((string)P_0).Replace((string)P_1, (string)P_2);
	}

	internal static AsyncVoidMethodBuilder bx00wIWr9UeXGHwMPZMt()
	{
		return AsyncVoidMethodBuilder.Create();
	}

	internal static AsyncTaskMethodBuilder Kmw4VxWrdkD7jRyNunxG()
	{
		return AsyncTaskMethodBuilder.Create();
	}

	internal static bool oi9jylWrlitQZ77KgioG(object P_0)
	{
		return ((IConnectionMonitor)P_0).IsOffline;
	}

	internal static bool R2yOCdWrr0jf1fV3Oja0(object P_0)
	{
		return ((ConcurrentQueue<ReferenceOperation>)P_0).IsEmpty;
	}

	internal static bool BdX57lWrgrdwJ22Ptnw8(object P_0, TimeSpan P_1, TimeSpan P_2)
	{
		return ((Timer)P_0).Change(P_1, P_2);
	}

	internal static void faZBriWr5JQyUW3kHJnQ(object P_0, object P_1)
	{
		((ILogger)P_0).Info(P_1);
	}

	internal static void aInAj4WrjhfXjlECi9Bt(object P_0, object P_1)
	{
		((ILogger)P_0).Debug(P_1);
	}

	internal static void YYtZY5WrYxrPtD8GQ1ZC(object P_0, object P_1, object P_2)
	{
		((ILogger)P_0).Error(P_1, (Exception)P_2);
	}

	internal static WebExceptionStatus Ax0GxhWrLdYpwDtIb0Px(object P_0)
	{
		return ((WebException)P_0).Status;
	}

	internal static void upmYGMWrUS2RTp6A80xY()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static void EFYcZAWrslFlrEMB7RAl(object P_0, RuntimeFieldHandle P_1)
	{
		RuntimeHelpers.InitializeArray((Array)P_0, P_1);
	}

	internal static object UJr8ntWrc0IgLewfmoev(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static object yNIofvWrzwPQB6mH69hN(object P_0, object P_1)
	{
		return string.Format((string)P_0, P_1);
	}
}
