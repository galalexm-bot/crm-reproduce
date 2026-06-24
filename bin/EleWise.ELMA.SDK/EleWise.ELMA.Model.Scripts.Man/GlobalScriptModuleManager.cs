using System;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using AutoMapper;
using EleWise.ELMA.ActorModel.Abstractions;
using EleWise.ELMA.ActorModel.Publication;
using EleWise.ELMA.Deploy.ExportHelper;
using EleWise.ELMA.Events;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Memory;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Scripts.DTO.Models;
using EleWise.ELMA.Model.Scripts.Exceptions;
using EleWise.ELMA.Model.Scripts.Types;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Scripts.Manager;

public class GlobalScriptModuleManager : EntityManager<IGlobalScriptModule, long>, IGlobalScriptModuleManager, IEntityManager<IGlobalScriptModule, long>, IEntityManager<IGlobalScriptModule>, IEntityManager
{
	private sealed class GlobalScriptModulePublicationEventHandler : IGlobalScriptModulePublicationEventHandler, IEventHandler
	{
		private readonly object actor;

		private readonly long scriptModuleId;

		private readonly TaskCompletionSource<bool> taskCompletionSource;

		private static object uTWTT5C3JY7sDgsV3o5I;

		public Task Wait => taskCompletionSource.Task;

		public GlobalScriptModulePublicationEventHandler(IGlobalScriptModulePublicationActor actor, long scriptModuleId)
		{
			//Discarded unreachable code: IL_003c, IL_0041
			SingletonReader.JJCZtPuTvSt();
			taskCompletionSource = new TaskCompletionSource<bool>(TaskCreationOptions.RunContinuationsAsynchronously);
			base._002Ector();
			int num = 2;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 != 0)
			{
				num = 2;
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
					this.scriptModuleId = scriptModuleId;
					num = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
					{
						num = 0;
					}
					break;
				case 2:
					this.actor = actor;
					num = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0)
					{
						num = 0;
					}
					break;
				}
			}
		}

		public Task Complete(long globalScriptModuleId)
		{
			int num = 2;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					if (scriptModuleId != globalScriptModuleId)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
						{
							num2 = 1;
						}
						break;
					}
					taskCompletionSource.TrySetResult(result: true);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
					{
						num2 = 0;
					}
					break;
				default:
					return (Task)zCn6PPC3rfyHU3iAuHOl(actor);
				case 1:
					return (Task)SxLPOHC3lb2Vw1CnJRRf();
				}
			}
		}

		public Task Error(long globalScriptModuleId, Exception exception)
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					return (Task)zCn6PPC3rfyHU3iAuHOl(actor);
				default:
					return Task.CompletedTask;
				case 1:
					if (scriptModuleId == globalScriptModuleId)
					{
						taskCompletionSource.TrySetException(exception);
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0)
						{
							num2 = 2;
						}
					}
					else
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
						{
							num2 = 0;
						}
					}
					break;
				}
			}
		}

		internal static bool RaevohC39oVKbdDQWEnu()
		{
			return uTWTT5C3JY7sDgsV3o5I == null;
		}

		internal static GlobalScriptModulePublicationEventHandler X0pUUPC3d5ckhYpGVMQd()
		{
			return (GlobalScriptModulePublicationEventHandler)uTWTT5C3JY7sDgsV3o5I;
		}

		internal static object SxLPOHC3lb2Vw1CnJRRf()
		{
			return Task.CompletedTask;
		}

		internal static object zCn6PPC3rfyHU3iAuHOl(object P_0)
		{
			return ((IGlobalScriptModulePublicationActor)P_0).PublicationComplete();
		}
	}

	private static GlobalScriptModuleManager fibMPhbOEqTqvlCA9RKh;

	public new static GlobalScriptModuleManager Instance => Locator.GetServiceNotNull<GlobalScriptModuleManager>();

	public IActorModelRuntime ActorModelRuntime
	{
		[CompilerGenerated]
		get
		{
			return _003CActorModelRuntime_003Ek__BackingField;
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
					_003CActorModelRuntime_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public IEventHandlerSubscribeService EventHandlerSubscribeService
	{
		[CompilerGenerated]
		get
		{
			return _003CEventHandlerSubscribeService_003Ek__BackingField;
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
					_003CEventHandlerSubscribeService_003Ek__BackingField = value;
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

	[Transaction]
	public virtual ScriptModule LoadScriptModuleForEdit(long gsmId)
	{
		//Discarded unreachable code: IL_00ba
		int num = 2;
		int num2 = num;
		IGlobalScriptModule globalScriptModule = default(IGlobalScriptModule);
		ScriptModuleDTO scriptModuleDTO = default(ScriptModuleDTO);
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (vHChTGbOChBqYsdFnrL1(globalScriptModule) != null)
				{
					num2 = 5;
					break;
				}
				goto case 7;
			case 7:
				throw new InvalidOperationException((string)EFfoiXbO85OWPEnDGX2A(AAJhvQbOvuFr4gAm2KCw(-629844702 ^ -629694966), gsmId));
			case 5:
				if (fwohjDbOZFQYjqiTby8k(vHChTGbOChBqYsdFnrL1(globalScriptModule)) == null)
				{
					num2 = 4;
					break;
				}
				goto default;
			case 4:
				scriptModuleDTO = Mapper.Map<ScriptModule, ScriptModuleDTO>((ScriptModule)vHChTGbOChBqYsdFnrL1(globalScriptModule), new ScriptModuleDTO());
				num2 = 3;
				break;
			case 6:
				NJQ8mtbOIyFrcTPaHRTy(globalScriptModule.ScriptModule.Draft);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				globalScriptModule = Load(gsmId);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0)
				{
					num2 = 1;
				}
				break;
			case 3:
				scriptModuleDTO.Id = 0L;
				num2 = 8;
				break;
			default:
				return ((ScriptModule)vHChTGbOChBqYsdFnrL1(globalScriptModule)).Draft;
			case 8:
				usCacubOufJnMWgsD5iZ(globalScriptModule.ScriptModule, Mapper.Map<ScriptModuleDTO, ScriptModule>(scriptModuleDTO, new ScriptModule()));
				num2 = 6;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0)
				{
					num2 = 6;
				}
				break;
			}
		}
	}

	public virtual void Publish(IGlobalScriptModule gsm)
	{
		int num = 3;
		int num2 = num;
		TaskAwaiter awaiter = default(TaskAwaiter);
		while (true)
		{
			switch (num2)
			{
			default:
				KDDiM2bOVVcCkBrRYEa6(gsm);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 != 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				return;
			case 2:
				awaiter.GetResult();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				awaiter = PublishAsync(gsm).GetAwaiter();
				num2 = 2;
				break;
			}
		}
	}

	public virtual void Validate(IGlobalScriptModule gsm)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				viLn1gbOSj5v78ey7jWV(gsm, AAJhvQbOvuFr4gAm2KCw(0x66F566B6 ^ 0x66F7A4F2));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return;
			default:
				GenerateAssembly(gsm);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	public virtual void DeleteDirectory(string directoryPath)
	{
		//Discarded unreachable code: IL_0065, IL_0074, IL_00cc, IL_00db, IL_01fc, IL_0253, IL_026a, IL_0279
		int num = 16;
		string[] array = default(string[]);
		string[] directories = default(string[]);
		int num5 = default(int);
		string text2 = default(string);
		string text = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 5:
					array = directories;
					num = 10;
					break;
				case 2:
				case 3:
					if (num5 >= array.Length)
					{
						num2 = 5;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
						{
							num2 = 4;
						}
						continue;
					}
					goto case 14;
				case 7:
					num5 = 0;
					num = 3;
					break;
				case 1:
					return;
				case 6:
					cPbEHDbOqv8seK9EILZu(this, text2);
					num = 11;
					break;
				case 10:
					num5 = 0;
					num2 = 12;
					continue;
				case 8:
					text2 = array[num5];
					num2 = 6;
					continue;
				case 16:
					GsElgubOiCf6JuHWJU4q(directoryPath, FileAttributes.Normal);
					num = 15;
					break;
				case 14:
					text = array[num5];
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 != 0)
					{
						num2 = 0;
					}
					continue;
				case 9:
					num5++;
					num2 = 2;
					continue;
				case 13:
					Directory.Delete(directoryPath, recursive: false);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
					{
						num2 = 1;
					}
					continue;
				case 15:
				{
					object obj2 = GHLOqybORjZEWVFbUbVF(directoryPath);
					directories = Directory.GetDirectories(directoryPath);
					array = (string[])obj2;
					num2 = 7;
					continue;
				}
				case 4:
				case 12:
					if (num5 >= array.Length)
					{
						num2 = 6;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
						{
							num2 = 13;
						}
						continue;
					}
					goto case 8;
				case 11:
					num5++;
					num2 = 4;
					continue;
				default:
					try
					{
						GsElgubOiCf6JuHWJU4q(text, FileAttributes.Normal);
						int num3 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 != 0)
						{
							num3 = 0;
						}
						while (true)
						{
							switch (num3)
							{
							case 1:
								File.Delete(text);
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
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
					catch
					{
						int num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
						{
							num4 = 0;
						}
						switch (num4)
						{
						case 0:
							break;
						}
					}
					goto case 9;
				}
				break;
			}
		}
	}

	public virtual void GenerateGlobalScriptModuleAssembly(IGlobalScriptModule globalScriptModule)
	{
		//Discarded unreachable code: IL_027e, IL_028d, IL_0318
		int num = 15;
		ScriptModule scriptModule = default(ScriptModule);
		_003C_003Ec__DisplayClass14_0 _003C_003Ec__DisplayClass14_ = default(_003C_003Ec__DisplayClass14_0);
		AssemblyModelsMetadata assemblyModelsMetadata2 = default(AssemblyModelsMetadata);
		MemoryStream memoryStream2 = default(MemoryStream);
		MemoryStream memoryStream = default(MemoryStream);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				AssemblyModelsMetadata assemblyModelsMetadata;
				switch (num2)
				{
				case 3:
				case 4:
					if (OGS10BbOHuW2Gs7Foam4(scriptModule) == null)
					{
						num2 = 12;
						continue;
					}
					goto case 2;
				case 11:
				{
					IQueryOver<AssemblyModelsMetadata, AssemblyModelsMetadata> obj = base.Session.QueryOver<AssemblyModelsMetadata>();
					ParameterExpression parameterExpression = (ParameterExpression)igBAPXbOKccqlLK9pp70(typeof(AssemblyModelsMetadata), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1886646897 ^ -1886468603));
					assemblyModelsMetadata = ((IQueryOver<AssemblyModelsMetadata>)(object)obj.Where(Expression.Lambda<Func<AssemblyModelsMetadata, bool>>((Expression)XsTRpEbO12eZ5O9WJCUm(Expression.Equal((Expression)dTg1C2bOTk4u9I5YU1xy(parameterExpression, (MethodInfo)wKSwB0bOX4mfdLPRMltR((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (Expression)dTg1C2bOTk4u9I5YU1xy(dTg1C2bOTk4u9I5YU1xy(m3BlxjbOOJYkuI20SkI5(Expression.Constant(_003C_003Ec__DisplayClass14_, UHapWmbOk8vdYOKVIdl5(typeof(_003C_003Ec__DisplayClass14_0).TypeHandle)), eE7ADYbOnZu5cVri3fYh((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/)), (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (MethodInfo)wKSwB0bOX4mfdLPRMltR((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/))), c38j6YbOPgVOQA5epev0(FpCxnibO2bLlMhLGDBZV(dTg1C2bOTk4u9I5YU1xy(parameterExpression, (MethodInfo)wKSwB0bOX4mfdLPRMltR((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), UHapWmbOk8vdYOKVIdl5(typeof(int).TypeHandle)), Mk7TMGbOeAYKjMxqvBnB(4, UHapWmbOk8vdYOKVIdl5(typeof(int).TypeHandle)))), new ParameterExpression[1] { parameterExpression }))).List().FirstOrDefault();
					if (assemblyModelsMetadata == null)
					{
						num2 = 18;
						continue;
					}
					goto IL_03a2;
				}
				case 13:
					IcexdGbO6TuNSWV7eSPv(assemblyModelsMetadata2, memoryStream2);
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
					{
						num2 = 4;
					}
					continue;
				default:
					kFHQKlbOwC06XPFVXIqF(memoryStream, OGS10BbOHuW2Gs7Foam4(scriptModule), 0, scriptModule.DebugRaw.Length);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
					{
						num2 = 0;
					}
					continue;
				case 9:
					if (scriptModule != null)
					{
						num = 11;
						break;
					}
					return;
				case 17:
					rJZcxKbO4Vdd3kn502GV(memoryStream2, 0L, SeekOrigin.Begin);
					num2 = 12;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
					{
						num2 = 13;
					}
					continue;
				case 2:
					memoryStream = (MemoryStream)U3CPtlbOtnUKBFWXZEdg(scriptModule.DebugRaw.Length);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
					{
						num2 = 0;
					}
					continue;
				case 10:
					memoryStream2 = (MemoryStream)U3CPtlbOtnUKBFWXZEdg(((Array)X81WVHbODDR44NBVUGmn(scriptModule)).Length);
					num2 = 8;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
					{
						num2 = 19;
					}
					continue;
				case 15:
					_003C_003Ec__DisplayClass14_ = new _003C_003Ec__DisplayClass14_0();
					num2 = 14;
					continue;
				case 7:
					scriptModule = GenerateAssembly(_003C_003Ec__DisplayClass14_.globalScriptModule);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
					{
						num2 = 9;
					}
					continue;
				case 16:
					Thb36ybOA9Ldoe9grl6X(assemblyModelsMetadata2, memoryStream);
					num = 8;
					break;
				case 14:
					_003C_003Ec__DisplayClass14_.globalScriptModule = globalScriptModule;
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0)
					{
						num2 = 3;
					}
					continue;
				case 8:
				case 12:
					z9CC9dbO7TD9RqiDAEfn(base.Session, assemblyModelsMetadata2);
					num2 = 6;
					continue;
				case 6:
					return;
				case 5:
					if (X81WVHbODDR44NBVUGmn(scriptModule) == null)
					{
						num2 = 3;
						continue;
					}
					goto case 10;
				case 19:
					kFHQKlbOwC06XPFVXIqF(memoryStream2, X81WVHbODDR44NBVUGmn(scriptModule), 0, scriptModule.AssemblyRaw.Length);
					num2 = 17;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
					{
						num2 = 5;
					}
					continue;
				case 1:
					memoryStream.Seek(0L, SeekOrigin.Begin);
					num2 = 16;
					continue;
				case 18:
					{
						assemblyModelsMetadata = new AssemblyModelsMetadata();
						HOXUE6bOpT45YxlGk0NY(assemblyModelsMetadata, ujbNVabO3sBelSgYlS07(UIM6dfbON4WLPxAKLObO(_003C_003Ec__DisplayClass14_.globalScriptModule)));
						wUP5hrbOa8dihCK1Jn5d(assemblyModelsMetadata, AssemblyModelsMetadataStatus.GlobalModule);
						goto IL_03a2;
					}
					IL_03a2:
					assemblyModelsMetadata2 = assemblyModelsMetadata;
					num = 5;
					break;
				}
				break;
			}
		}
	}

	public override ExportRuleList ExportRules()
	{
		int num = 5;
		int num2 = num;
		ExportRuleList exportRuleList = default(ExportRuleList);
		Type type = default(Type);
		while (true)
		{
			switch (num2)
			{
			default:
				return exportRuleList;
			case 1:
			{
				ExportRuleList exportRuleList5 = exportRuleList;
				ExportRule exportRule = new ExportRule
				{
					ParentType = type
				};
				ExportRule exportRule5 = exportRule;
				ParameterExpression parameterExpression = (ParameterExpression)igBAPXbOKccqlLK9pp70(UHapWmbOk8vdYOKVIdl5(typeof(IGlobalScriptModule).TypeHandle), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-576149596 ^ -576189680));
				exportRule5.PropertyName = LinqUtils.NameOf(Expression.Lambda<Func<IGlobalScriptModule, object>>((Expression)FpCxnibO2bLlMhLGDBZV(dTg1C2bOTk4u9I5YU1xy(parameterExpression, (MethodInfo)wKSwB0bOX4mfdLPRMltR((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), UHapWmbOk8vdYOKVIdl5(typeof(object).TypeHandle)), new ParameterExpression[1] { parameterExpression }));
				exportRule.ExportRuleType = ExportRuleType.Export;
				exportRuleList5.Add(exportRule);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
				{
					num2 = 0;
				}
				break;
			}
			case 3:
			{
				ExportRuleList exportRuleList4 = exportRuleList;
				ExportRule exportRule = new ExportRule();
				ogBO1vbO09gkndOG3Db1(exportRule, type);
				ExportRule exportRule4 = exportRule;
				ParameterExpression parameterExpression = (ParameterExpression)igBAPXbOKccqlLK9pp70(UHapWmbOk8vdYOKVIdl5(typeof(IGlobalScriptModule).TypeHandle), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x92F12D5 ^ 0x92FBE61));
				PM9ZRObOm6vp1fDxekqE(exportRule4, LinqUtils.NameOf(Expression.Lambda<Func<IGlobalScriptModule, object>>(Expression.Property(parameterExpression, (MethodInfo)wKSwB0bOX4mfdLPRMltR((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression })));
				wfZ3BLbOyS1rTRYAQSiS(exportRule, ExportRuleType.Export);
				exportRuleList4.Add(exportRule);
				num2 = 2;
				break;
			}
			case 4:
				exportRuleList = new ExportRuleList();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
				{
					num2 = 3;
				}
				break;
			case 2:
			{
				ExportRuleList exportRuleList6 = exportRuleList;
				ExportRule exportRule = new ExportRule();
				ogBO1vbO09gkndOG3Db1(exportRule, type);
				ExportRule exportRule6 = exportRule;
				ParameterExpression parameterExpression = (ParameterExpression)igBAPXbOKccqlLK9pp70(UHapWmbOk8vdYOKVIdl5(typeof(IGlobalScriptModule).TypeHandle), AAJhvQbOvuFr4gAm2KCw(0x7459E02 ^ 0x74532B6));
				exportRule6.PropertyName = LinqUtils.NameOf(Expression.Lambda<Func<IGlobalScriptModule, object>>((Expression)dTg1C2bOTk4u9I5YU1xy(parameterExpression, (MethodInfo)wKSwB0bOX4mfdLPRMltR((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }));
				wfZ3BLbOyS1rTRYAQSiS(exportRule, ExportRuleType.Export);
				exportRuleList6.Add(exportRule);
				num2 = 6;
				break;
			}
			case 5:
				type = fWqTisbOxD6gVaM63tSL(this);
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
				{
					num2 = 1;
				}
				break;
			case 7:
			{
				ExportRuleList exportRuleList3 = exportRuleList;
				ExportRule exportRule = new ExportRule();
				ogBO1vbO09gkndOG3Db1(exportRule, type);
				ExportRule exportRule3 = exportRule;
				ParameterExpression parameterExpression = (ParameterExpression)igBAPXbOKccqlLK9pp70(UHapWmbOk8vdYOKVIdl5(typeof(IGlobalScriptModule).TypeHandle), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1822890472 ^ -1822930260));
				PM9ZRObOm6vp1fDxekqE(exportRule3, LinqUtils.NameOf(Expression.Lambda<Func<IGlobalScriptModule, object>>((Expression)dTg1C2bOTk4u9I5YU1xy(parameterExpression, (MethodInfo)wKSwB0bOX4mfdLPRMltR((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression })));
				wfZ3BLbOyS1rTRYAQSiS(exportRule, ExportRuleType.Export);
				exportRuleList3.Add(exportRule);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
				{
					num2 = 1;
				}
				break;
			}
			case 6:
			{
				ExportRuleList exportRuleList2 = exportRuleList;
				ExportRule exportRule = new ExportRule
				{
					ParentType = type
				};
				ExportRule exportRule2 = exportRule;
				ParameterExpression parameterExpression = (ParameterExpression)igBAPXbOKccqlLK9pp70(UHapWmbOk8vdYOKVIdl5(typeof(IGlobalScriptModule).TypeHandle), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1426094279 ^ -1426117747));
				PM9ZRObOm6vp1fDxekqE(exportRule2, LinqUtils.NameOf(Expression.Lambda<Func<IGlobalScriptModule, object>>(Expression.Property(parameterExpression, (MethodInfo)wKSwB0bOX4mfdLPRMltR((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression })));
				wfZ3BLbOyS1rTRYAQSiS(exportRule, ExportRuleType.Export);
				exportRuleList2.Add(exportRule);
				num2 = 7;
				break;
			}
			}
		}
	}

	protected ScriptModule GenerateAssembly(IGlobalScriptModule gsm)
	{
		//Discarded unreachable code: IL_0051, IL_00f1
		int num = 5;
		ScriptModule scriptModule = default(ScriptModule);
		GlobalScriptModuleCompiler globalScriptModuleCompiler = default(GlobalScriptModuleCompiler);
		ScriptCompileResult scriptCompileResult = default(ScriptCompileResult);
		byte[] array = default(byte[]);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 7:
					DvadwlbOg5k3fJKIiULJ(scriptModule, WKRlOebOrBwnDriMoSAT(globalScriptModuleCompiler));
					num2 = 6;
					continue;
				case 6:
					return scriptModule;
				case 2:
					return null;
				case 1:
					scriptCompileResult = (ScriptCompileResult)xjod79bOJ9NqRthVDoPY(globalScriptModuleCompiler);
					num2 = 9;
					continue;
				case 8:
					return null;
				case 5:
					scriptModule = (ScriptModule)vHChTGbOChBqYsdFnrL1(gsm);
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
					{
						num2 = 4;
					}
					continue;
				default:
					SXjVBXbOlKhLnMEU2Nm9(scriptModule, array);
					num2 = 7;
					continue;
				case 9:
					if (y0ghrobO9EQ68EIMh3Rt(scriptCompileResult))
					{
						num2 = 10;
						continue;
					}
					goto case 3;
				case 3:
					throw new GlobalScriptModulePublishingException(gsm.Id, scriptCompileResult);
				case 10:
					array = (byte[])kbGeKZbOdyjsgoo6IuQy(globalScriptModuleCompiler);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
					{
						num2 = 0;
					}
					continue;
				case 11:
					break;
				case 4:
					if (scriptModule == null)
					{
						goto end_IL_0012;
					}
					if (!(K1QNWvbOMLVEemVZQkQb(gsm) is ProjectInfo))
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0)
						{
							num2 = 2;
						}
						continue;
					}
					break;
				}
				globalScriptModuleCompiler = new GlobalScriptModuleCompiler(scriptModule, gsm);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
				{
					num2 = 1;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 8;
		}
	}

	[AsyncStateMachine(typeof(_003CPublishAsync_003Ed__17))]
	private Task PublishAsync(IGlobalScriptModule globalScriptModule)
	{
		int num = 1;
		_003CPublishAsync_003Ed__17 stateMachine = default(_003CPublishAsync_003Ed__17);
		AsyncTaskMethodBuilder _003C_003Et__builder = default(AsyncTaskMethodBuilder);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					stateMachine._003C_003Et__builder = KkHgM6bO5lQlWwKFiXrm();
					num2 = 4;
					continue;
				case 4:
					break;
				case 3:
					return stateMachine._003C_003Et__builder.Task;
				case 1:
					stateMachine._003C_003E4__this = this;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
					{
						num2 = 0;
					}
					continue;
				default:
					stateMachine.globalScriptModule = globalScriptModule;
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0)
					{
						num2 = 0;
					}
					continue;
				case 5:
					_003C_003Et__builder = stateMachine._003C_003Et__builder;
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
					{
						num2 = 1;
					}
					continue;
				case 6:
					_003C_003Et__builder.Start(ref stateMachine);
					num2 = 3;
					continue;
				}
				break;
			}
			stateMachine._003C_003E1__state = -1;
			num = 5;
		}
	}

	public GlobalScriptModuleManager()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		wCk8P5bOjcJpu5JDE6Lh();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool mGWV6cbOfm7C7xAtD4q0()
	{
		return fibMPhbOEqTqvlCA9RKh == null;
	}

	internal static GlobalScriptModuleManager YkMpHPbOQaxXRUun8NBm()
	{
		return fibMPhbOEqTqvlCA9RKh;
	}

	internal static object vHChTGbOChBqYsdFnrL1(object P_0)
	{
		return ((IGlobalScriptModule)P_0).ScriptModule;
	}

	internal static object AAJhvQbOvuFr4gAm2KCw(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object EFfoiXbO85OWPEnDGX2A(object P_0, object P_1)
	{
		return string.Concat(P_0, P_1);
	}

	internal static object fwohjDbOZFQYjqiTby8k(object P_0)
	{
		return ((ScriptModule)P_0).Draft;
	}

	internal static void usCacubOufJnMWgsD5iZ(object P_0, object P_1)
	{
		((ScriptModule)P_0).Draft = (ScriptModule)P_1;
	}

	internal static void NJQ8mtbOIyFrcTPaHRTy(object P_0)
	{
		((Entity<long>)P_0).Save();
	}

	internal static void KDDiM2bOVVcCkBrRYEa6(object P_0)
	{
		((IEntity)P_0).Refresh();
	}

	internal static void viLn1gbOSj5v78ey7jWV(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static void GsElgubOiCf6JuHWJU4q(object P_0, FileAttributes P_1)
	{
		File.SetAttributes((string)P_0, P_1);
	}

	internal static object GHLOqybORjZEWVFbUbVF(object P_0)
	{
		return Directory.GetFiles((string)P_0);
	}

	internal static void cPbEHDbOqv8seK9EILZu(object P_0, object P_1)
	{
		((GlobalScriptModuleManager)P_0).DeleteDirectory((string)P_1);
	}

	internal static object igBAPXbOKccqlLK9pp70(Type P_0, object P_1)
	{
		return Expression.Parameter(P_0, (string)P_1);
	}

	internal static object wKSwB0bOX4mfdLPRMltR(RuntimeMethodHandle P_0)
	{
		return MethodBase.GetMethodFromHandle(P_0);
	}

	internal static object dTg1C2bOTk4u9I5YU1xy(object P_0, object P_1)
	{
		return Expression.Property((Expression)P_0, (MethodInfo)P_1);
	}

	internal static Type UHapWmbOk8vdYOKVIdl5(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object eE7ADYbOnZu5cVri3fYh(RuntimeFieldHandle P_0)
	{
		return FieldInfo.GetFieldFromHandle(P_0);
	}

	internal static object m3BlxjbOOJYkuI20SkI5(object P_0, object P_1)
	{
		return Expression.Field((Expression)P_0, (FieldInfo)P_1);
	}

	internal static object FpCxnibO2bLlMhLGDBZV(object P_0, Type P_1)
	{
		return Expression.Convert((Expression)P_0, P_1);
	}

	internal static object Mk7TMGbOeAYKjMxqvBnB(object P_0, Type P_1)
	{
		return Expression.Constant(P_0, P_1);
	}

	internal static object c38j6YbOPgVOQA5epev0(object P_0, object P_1)
	{
		return Expression.Equal((Expression)P_0, (Expression)P_1);
	}

	internal static object XsTRpEbO12eZ5O9WJCUm(object P_0, object P_1)
	{
		return Expression.AndAlso((Expression)P_0, (Expression)P_1);
	}

	internal static object UIM6dfbON4WLPxAKLObO(object P_0)
	{
		return ((IGlobalScriptModule)P_0).Header;
	}

	internal static object ujbNVabO3sBelSgYlS07(object P_0)
	{
		return ((IGlobalScriptModuleHeader)P_0).Namespace;
	}

	internal static void HOXUE6bOpT45YxlGk0NY(object P_0, object P_1)
	{
		((AssemblyModelsMetadata)P_0).Name = (string)P_1;
	}

	internal static void wUP5hrbOa8dihCK1Jn5d(object P_0, AssemblyModelsMetadataStatus value)
	{
		((AssemblyModelsMetadata)P_0).Status = value;
	}

	internal static object X81WVHbODDR44NBVUGmn(object P_0)
	{
		return ((ScriptModule)P_0).AssemblyRaw;
	}

	internal static object U3CPtlbOtnUKBFWXZEdg(int requiredSize)
	{
		return MemoryHelper.GetMemoryStream(requiredSize);
	}

	internal static void kFHQKlbOwC06XPFVXIqF(object P_0, object P_1, int P_2, int P_3)
	{
		((Stream)P_0).Write((byte[])P_1, P_2, P_3);
	}

	internal static long rJZcxKbO4Vdd3kn502GV(object P_0, long P_1, SeekOrigin P_2)
	{
		return ((Stream)P_0).Seek(P_1, P_2);
	}

	internal static void IcexdGbO6TuNSWV7eSPv(object P_0, object P_1)
	{
		((AssemblyModelsMetadata)P_0).AssemblyRawStream = (MemoryStream)P_1;
	}

	internal static object OGS10BbOHuW2Gs7Foam4(object P_0)
	{
		return ((ScriptModule)P_0).DebugRaw;
	}

	internal static void Thb36ybOA9Ldoe9grl6X(object P_0, object P_1)
	{
		((AssemblyModelsMetadata)P_0).DebugRawStream = (MemoryStream)P_1;
	}

	internal static object z9CC9dbO7TD9RqiDAEfn(object P_0, object P_1)
	{
		return ((ISession)P_0).Save(P_1);
	}

	internal static Type fWqTisbOxD6gVaM63tSL(object P_0)
	{
		return ((EntityManager<IGlobalScriptModule, long>)P_0).ImplementationType;
	}

	internal static void ogBO1vbO09gkndOG3Db1(object P_0, Type value)
	{
		((ExportRule)P_0).ParentType = value;
	}

	internal static void PM9ZRObOm6vp1fDxekqE(object P_0, object P_1)
	{
		((ExportRule)P_0).PropertyName = (string)P_1;
	}

	internal static void wfZ3BLbOyS1rTRYAQSiS(object P_0, ExportRuleType value)
	{
		((ExportRule)P_0).ExportRuleType = value;
	}

	internal static object K1QNWvbOMLVEemVZQkQb(object P_0)
	{
		return ((IGlobalScriptModule)P_0).Items;
	}

	internal static object xjod79bOJ9NqRthVDoPY(object P_0)
	{
		return ((ScriptCompiler)P_0).Compile();
	}

	internal static bool y0ghrobO9EQ68EIMh3Rt(object P_0)
	{
		return ((ScriptCompileResult)P_0).Success;
	}

	internal static object kbGeKZbOdyjsgoo6IuQy(object P_0)
	{
		return ((AssemblyBuilder)P_0).AssemblyRaw;
	}

	internal static void SXjVBXbOlKhLnMEU2Nm9(object P_0, object P_1)
	{
		((ScriptModule)P_0).AssemblyRaw = (byte[])P_1;
	}

	internal static object WKRlOebOrBwnDriMoSAT(object P_0)
	{
		return ((AssemblyBuilder)P_0).DebugRaw;
	}

	internal static void DvadwlbOg5k3fJKIiULJ(object P_0, object P_1)
	{
		((ScriptModule)P_0).DebugRaw = (byte[])P_1;
	}

	internal static AsyncTaskMethodBuilder KkHgM6bO5lQlWwKFiXrm()
	{
		return AsyncTaskMethodBuilder.Create();
	}

	internal static void wCk8P5bOjcJpu5JDE6Lh()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
