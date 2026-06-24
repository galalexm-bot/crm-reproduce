using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using EleWise.ELMA.ActorModel.Abstractions;
using EleWise.ELMA.Deploy.Import;
using EleWise.ELMA.Runtime.Managers;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Deploy.Actors;

internal sealed class ImportStartActor : Actor, IImportStartActor, IActorWithGuidKey, IActor
{
	internal static readonly Guid ActorId;

	private static readonly string CurrentImportIdKey;

	private readonly IActorModelRuntime actorModelRuntime;

	private readonly IBLOBStore blobStore;

	private Guid currentImportId;

	private bool idIsSaved;

	internal static ImportStartActor ykDXcKEz9rUdfKbxRwKZ;

	public ImportStartActor(IActorModelRuntime actorModelRuntime, IBLOBStore blobStore)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		Iu1bKFEzrMsYyTYru75T();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				this.actorModelRuntime = actorModelRuntime;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
				{
					num = 0;
				}
				break;
			default:
				this.blobStore = blobStore;
				num = 2;
				break;
			case 2:
				return;
			}
		}
	}

	[AsyncStateMachine(typeof(_003COnActivateAsync_003Ed__7))]
	public override Task OnActivateAsync()
	{
		int num = 2;
		int num2 = num;
		_003COnActivateAsync_003Ed__7 stateMachine = default(_003COnActivateAsync_003Ed__7);
		AsyncTaskMethodBuilder _003C_003Et__builder = default(AsyncTaskMethodBuilder);
		while (true)
		{
			switch (num2)
			{
			case 4:
				return stateMachine._003C_003Et__builder.Task;
			default:
				_003C_003Et__builder = stateMachine._003C_003Et__builder;
				num2 = 5;
				break;
			case 2:
				stateMachine._003C_003E4__this = this;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0)
				{
					num2 = 0;
				}
				break;
			case 5:
				_003C_003Et__builder.Start(ref stateMachine);
				num2 = 4;
				break;
			case 1:
				stateMachine._003C_003Et__builder = LcvEbiEzg9J8mdciJDBE();
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
				{
					num2 = 2;
				}
				break;
			case 3:
				stateMachine._003C_003E1__state = -1;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public override Task OnDeactivateAsync()
	{
		//Discarded unreachable code: IL_00d2, IL_00e1
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return Task.CompletedTask;
			case 5:
				pXalejEzYWqDYSJidDh3(blobStore, CurrentImportIdKey);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				if (idIsSaved)
				{
					num2 = 5;
					break;
				}
				goto default;
			case 3:
				if (peq2cNEz5flJfs4YTI0g(currentImportId, Guid.Empty))
				{
					num2 = 2;
					break;
				}
				goto case 1;
			case 2:
				KO5F0LEzj7dacLHPsu6f(blobStore, CurrentImportIdKey, currentImportId.ToByteArray());
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	[AsyncStateMachine(typeof(_003CImport_003Ed__9))]
	public Task<Guid> Import(IImportSettings settings)
	{
		_003CImport_003Ed__9 stateMachine = default(_003CImport_003Ed__9);
		stateMachine._003C_003E4__this = this;
		stateMachine.settings = settings;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<Guid>.Create();
		stateMachine._003C_003E1__state = -1;
		AsyncTaskMethodBuilder<Guid> _003C_003Et__builder = stateMachine._003C_003Et__builder;
		_003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[AsyncStateMachine(typeof(_003CGetCurrentImportId_003Ed__10))]
	public Task<Guid> GetCurrentImportId()
	{
		_003CGetCurrentImportId_003Ed__10 stateMachine = default(_003CGetCurrentImportId_003Ed__10);
		stateMachine._003C_003E4__this = this;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<Guid>.Create();
		stateMachine._003C_003E1__state = -1;
		AsyncTaskMethodBuilder<Guid> _003C_003Et__builder = stateMachine._003C_003Et__builder;
		_003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[AsyncStateMachine(typeof(_003CContinuedImport_003Ed__11))]
	public Task<Guid> ContinuedImport(IEnumerable<IConfigImportSettings> settings)
	{
		_003CContinuedImport_003Ed__11 stateMachine = default(_003CContinuedImport_003Ed__11);
		stateMachine._003C_003E4__this = this;
		stateMachine.settings = settings;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<Guid>.Create();
		stateMachine._003C_003E1__state = -1;
		AsyncTaskMethodBuilder<Guid> _003C_003Et__builder = stateMachine._003C_003Et__builder;
		_003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	public Task ContinueImport()
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (Ni9qBfEzLq62IMu7j7GO(currentImportId, Guid.Empty))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			default:
				return (Task)NgbmIGEzs4DtA0edWW6f(actorModelRuntime.GetActor<IImportExecutorActor>(currentImportId));
			case 1:
				currentImportId = pRLoZ9EzUQiwMIgop8GL();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	[AsyncStateMachine(typeof(_003CCheckHasOngoingImport_003Ed__13))]
	private Task CheckHasOngoingImport()
	{
		int num = 4;
		int num2 = num;
		_003CCheckHasOngoingImport_003Ed__13 stateMachine = default(_003CCheckHasOngoingImport_003Ed__13);
		AsyncTaskMethodBuilder _003C_003Et__builder = default(AsyncTaskMethodBuilder);
		while (true)
		{
			switch (num2)
			{
			case 4:
				stateMachine._003C_003E4__this = this;
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
				{
					num2 = 3;
				}
				break;
			default:
				return stateMachine._003C_003Et__builder.Task;
			case 2:
				_003C_003Et__builder = stateMachine._003C_003Et__builder;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				_003C_003Et__builder.Start(ref stateMachine);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 != 0)
				{
					num2 = 0;
				}
				break;
			case 5:
				stateMachine._003C_003E1__state = -1;
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 != 0)
				{
					num2 = 2;
				}
				break;
			case 3:
				stateMachine._003C_003Et__builder = LcvEbiEzg9J8mdciJDBE();
				num2 = 5;
				break;
			}
		}
	}

	static ImportStartActor()
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
			case 1:
				ActorId = Guid.Empty;
				num2 = 3;
				break;
			case 3:
				CurrentImportIdKey = (string)yyJaJCEzcfYPLZIW1aY6(0xA592A41 ^ 0xA5C2467);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				Iu1bKFEzrMsYyTYru75T();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	internal static void Iu1bKFEzrMsYyTYru75T()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool anjq5rEzdjDfJBTum1RJ()
	{
		return ykDXcKEz9rUdfKbxRwKZ == null;
	}

	internal static ImportStartActor HmCqyCEzlmXNSqCwb9sZ()
	{
		return ykDXcKEz9rUdfKbxRwKZ;
	}

	internal static AsyncTaskMethodBuilder LcvEbiEzg9J8mdciJDBE()
	{
		return AsyncTaskMethodBuilder.Create();
	}

	internal static bool peq2cNEz5flJfs4YTI0g(Guid P_0, Guid P_1)
	{
		return P_0 != P_1;
	}

	internal static void KO5F0LEzj7dacLHPsu6f(object P_0, object P_1, object P_2)
	{
		((IBLOBStore)P_0).Save((string)P_1, (byte[])P_2);
	}

	internal static void pXalejEzYWqDYSJidDh3(object P_0, object P_1)
	{
		((IBLOBStore)P_0).Remove((string)P_1);
	}

	internal static bool Ni9qBfEzLq62IMu7j7GO(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}

	internal static Guid pRLoZ9EzUQiwMIgop8GL()
	{
		return Guid.NewGuid();
	}

	internal static object NgbmIGEzs4DtA0edWW6f(object P_0)
	{
		return ((IImportExecutorActor)P_0).ContinueImport();
	}

	internal static object yyJaJCEzcfYPLZIW1aY6(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}
}
