using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using EleWise.ELMA.ActorModel.Abstractions;
using EleWise.ELMA.Events;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Events.Publication;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata.Actors;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Model.Scripts.Manager;
using EleWise.ELMA.Model.Signatures;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
using EleWise.ELMA.UI.Managers;
using EleWise.ELMA.UI.Models;
using j3AmrhgkCleVTGdEwA;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;
using NHibernate.Criterion;
using NHibernate.SqlCommand;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Metadata.Managers;

internal class FunctionMetadataItemManager : EntityManager<FunctionMetadataItem, long>, IFunctionMetadataItemManager, IEntityManager<FunctionMetadataItem, long>, IEntityManager<FunctionMetadataItem>, IEntityManager
{
	private sealed class FunctionMetadataPublishingEventHandler : IFunctionMetadataPublishingEventHandler, IEventHandler
	{
		private readonly object actor;

		private readonly Guid headerUid;

		private readonly TaskCompletionSource<UIMetadataPublishResult> taskCompletionSource;

		internal static object Wm5CcaCMx2y2QgiybsE5;

		public Task<UIMetadataPublishResult> Wait => taskCompletionSource.Task;

		public FunctionMetadataPublishingEventHandler(IFunctionMetadataPublishingActor actor, Guid headerUid)
		{
			//Discarded unreachable code: IL_003c, IL_0041
			Ba73XgCMyOhPUp5H78wy();
			taskCompletionSource = new TaskCompletionSource<UIMetadataPublishResult>(TaskCreationOptions.RunContinuationsAsynchronously);
			base._002Ector();
			int num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
			{
				num = 2;
			}
			while (true)
			{
				switch (num)
				{
				default:
					this.headerUid = headerUid;
					num = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0)
					{
						num = 0;
					}
					break;
				case 2:
					this.actor = actor;
					num = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 != 0)
					{
						num = 0;
					}
					break;
				case 1:
					return;
				}
			}
		}

		public Task Complete(Guid functionMetadataUid, UIMetadataPublishResult result)
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					if (ibq4bmCMM9HTVhZLtRea(headerUid, functionMetadataUid))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 != 0)
						{
							num2 = 0;
						}
						break;
					}
					taskCompletionSource.TrySetResult(result);
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0)
					{
						num2 = 1;
					}
					break;
				default:
					return (Task)ibag4PCMJXeSkrKZ4wB5();
				case 2:
					return (Task)Os6HM7CM9NYkvJSeo7kS(actor);
				}
			}
		}

		public Task Error(Guid functionMetadataUid, Exception exception)
		{
			//Discarded unreachable code: IL_0085, IL_0094
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					if (!ibq4bmCMM9HTVhZLtRea(headerUid, functionMetadataUid))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 2;
				case 2:
					return (Task)ibag4PCMJXeSkrKZ4wB5();
				default:
					iNQmORCMdAo9NhRPpukO(taskCompletionSource, exception);
					num2 = 3;
					break;
				case 3:
					return (Task)Os6HM7CM9NYkvJSeo7kS(actor);
				}
			}
		}

		internal static void Ba73XgCMyOhPUp5H78wy()
		{
			SingletonReader.JJCZtPuTvSt();
		}

		internal static bool kBok6kCM0AQTGhGYByr8()
		{
			return Wm5CcaCMx2y2QgiybsE5 == null;
		}

		internal static FunctionMetadataPublishingEventHandler xXBAsjCMmXqvygcjpcRC()
		{
			return (FunctionMetadataPublishingEventHandler)Wm5CcaCMx2y2QgiybsE5;
		}

		internal static bool ibq4bmCMM9HTVhZLtRea(Guid P_0, Guid P_1)
		{
			return P_0 != P_1;
		}

		internal static object ibag4PCMJXeSkrKZ4wB5()
		{
			return Task.CompletedTask;
		}

		internal static object Os6HM7CM9NYkvJSeo7kS(object P_0)
		{
			return ((IFunctionMetadataPublishingActor)P_0).PublishComplete();
		}

		internal static bool iNQmORCMdAo9NhRPpukO(object P_0, object P_1)
		{
			return ((TaskCompletionSource<UIMetadataPublishResult>)P_0).TrySetException((Exception)P_1);
		}
	}

	private static readonly SyntaxTrivia[] ArgWrapIndent;

	private readonly FetchOptions fetchOptions;

	private readonly IFunctionMetadataItemHeaderManager headerManager;

	private readonly ScriptModuleManager scriptModuleManager;

	private readonly IActorModelRuntime actorModelRuntime;

	private readonly IEventHandlerSubscribeService eventHandlerSubscribeService;

	internal static FunctionMetadataItemManager lQKG4GbcfF1fO1GFIUIZ;

	public new static FunctionMetadataItemManager Instance => Locator.GetServiceNotNull<FunctionMetadataItemManager>();

	public FunctionMetadataItemManager(IFunctionMetadataItemHeaderManager headerManager, ScriptModuleManager scriptModuleManager, IActorModelRuntime actorModelRuntime, IEventHandlerSubscribeService eventHandlerSubscribeService)
	{
		//Discarded unreachable code: IL_004d, IL_0052
		CejwKybcvWdLSGXffTxq();
		fetchOptions = new FetchOptions(0, 0, ListSortDirection.Descending, (string)Tp0tH9bc8XtUgQlOpZEU(0x3C5338FF ^ 0x3C53CA03));
		base._002Ector();
		int num = 2;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 4:
				this.scriptModuleManager = scriptModuleManager;
				num = 3;
				break;
			case 2:
				this.headerManager = headerManager;
				num = 4;
				break;
			case 3:
				this.actorModelRuntime = actorModelRuntime;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
				{
					num = 0;
				}
				break;
			case 1:
				return;
			default:
				this.eventHandlerSubscribeService = eventHandlerSubscribeService;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a != 0)
				{
					num = 1;
				}
				break;
			}
		}
	}

	[Transaction]
	public virtual FunctionMetadataItem Create(Guid moduleUid, Guid group, string displayName)
	{
		int num = 6;
		int num2 = num;
		FunctionMetadata functionMetadata = default(FunctionMetadata);
		while (true)
		{
			switch (num2)
			{
			case 5:
				functionMetadata.InitNew();
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
				{
					num2 = 4;
				}
				break;
			case 7:
				MdVl44bcZmefXd4rF9cN(functionMetadata, displayName.ToTranslitIdent());
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				functionMetadata.NamespaceForDisplay = (string)DKXOCnbcum5V1r0RpOfA(Tp0tH9bc8XtUgQlOpZEU(0x7247028A ^ 0x72440A42));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
				{
					num2 = 1;
				}
				break;
			case 3:
				return Create(functionMetadata, null, string.Empty, group);
			default:
				vvlugabcIqLjPwYtV0x1(functionMetadata, new TypeSignature());
				num2 = 3;
				break;
			case 1:
				functionMetadata.ReturnType = new TypeSignature();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
				{
					num2 = 0;
				}
				break;
			case 6:
				functionMetadata = new FunctionMetadata(moduleUid);
				num2 = 5;
				break;
			case 4:
				functionMetadata.DisplayName = displayName;
				num2 = 7;
				break;
			}
		}
	}

	[Transaction]
	public virtual FunctionMetadataItem Copy(Guid headerUid)
	{
		int num = 1;
		int num2 = num;
		int num3 = default(int);
		FunctionMetadata functionMetadata = default(FunctionMetadata);
		FunctionMetadataItem functionMetadataItem = default(FunctionMetadataItem);
		string sourceCode = default(string);
		MetadataItemGroupUI metadataItemGroupUI = default(MetadataItemGroupUI);
		while (true)
		{
			switch (num2)
			{
			case 1:
				num3 = new Random().Next(0, 10000);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				return Create(functionMetadata, (FunctionMetadata)QWWp30bcSZfjSIpir9v5(functionMetadataItem), sourceCode, metadataItemGroupUI?.Uid ?? Guid.Empty);
			}
			FunctionMetadataItemHeader functionMetadataItemHeader = headerManager.Load(headerUid);
			functionMetadataItem = (FunctionMetadataItem)jhdePhbcVdYZ0Cp5c3of(functionMetadataItemHeader);
			FunctionMetadata functionMetadata2 = (FunctionMetadata)QWWp30bcSZfjSIpir9v5(functionMetadataItem);
			functionMetadata = ClassSerializationHelper.CloneObjectByXml(functionMetadata2);
			H5cf2IbciySBDxJVg7Fn(functionMetadata);
			p4p39EbcRZNusj3Fst0a(functionMetadata, functionMetadata2.Namespace);
			MdVl44bcZmefXd4rF9cN(functionMetadata, Kie57wbcKt8gbqDDfZtf(Tp0tH9bc8XtUgQlOpZEU(0x103FE975 ^ 0x103F1A6F), EUyQ65bcqQUDL5FhoOXg(functionMetadata), num3));
			fuiefHbcT4ECQLWTmk1D(functionMetadata, Kie57wbcKt8gbqDDfZtf(Tp0tH9bc8XtUgQlOpZEU(0x637E299B ^ 0x637EDA81), eDeZWMbcXIkFYspEYFv1(functionMetadata), num3));
			sourceCode = (string)GB6hT7bcna9lTHBDgWXU(DLohYjbckbKws7IevwbH(functionMetadataItem));
			metadataItemGroupUI = (MetadataItemGroupUI)enef7abcOkH1f07NWCKw(functionMetadataItemHeader);
			num2 = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e != 0)
			{
				num2 = 2;
			}
		}
	}

	public override void Save(FunctionMetadataItem obj)
	{
		//Discarded unreachable code: IL_019b, IL_021a, IL_0229
		int num = 10;
		int num2 = num;
		string errorMessage = default(string);
		FunctionMetadata functionMetadata = default(FunctionMetadata);
		IUser currentUser = default(IUser);
		while (true)
		{
			switch (num2)
			{
			case 3:
				throw new Exception(SR.T((string)Tp0tH9bc8XtUgQlOpZEU(-345420348 ^ -345391530), Tp0tH9bc8XtUgQlOpZEU(-1638402543 ^ -1638596917)));
			case 7:
				throw new InvalidOperationException(errorMessage);
			case 8:
				Cv9jnfbcNhbebRXBxpYr(obj, ApL5nxbc1WjBb5pDVv9U());
				num2 = 6;
				break;
			case 2:
				throw new Exception(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1852837372 ^ -1852898824), functionMetadata.DisplayName, EUyQ65bcqQUDL5FhoOXg(functionMetadata)));
			default:
				if (headerManager.ValidateName(((Entity<long>)BHfEtEbc22NERYbH4lsB(obj)).Id, (string)EUyQ65bcqQUDL5FhoOXg(functionMetadata), out errorMessage))
				{
					if (headerManager.ValidateDisplayName(((Entity<long>)BHfEtEbc22NERYbH4lsB(obj)).Id, functionMetadata.DisplayName, out errorMessage))
					{
						num2 = 11;
						break;
					}
					goto case 4;
				}
				num2 = 7;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				throw new InvalidOperationException(errorMessage);
			case 11:
				currentUser = ((IAuthenticationService)nNElcRbceRNI7uXurI0p(this)).GetCurrentUser();
				num2 = 12;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0)
				{
					num2 = 5;
				}
				break;
			case 1:
				if (functionMetadata != null)
				{
					if (BHfEtEbc22NERYbH4lsB(obj) != null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 2;
				}
				num2 = 3;
				break;
			case 6:
				base.Save(obj);
				num2 = 5;
				break;
			case 5:
				return;
			case 10:
				Contract.ArgumentNotNull(obj, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1123633026 ^ -1123673098));
				num2 = 9;
				break;
			case 9:
				functionMetadata = obj.Metadata as FunctionMetadata;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
				{
					num2 = 1;
				}
				break;
			case 12:
				obj.CreationAuthorId = (long?)((currentUser != null) ? T5uq4UbcP0wftqV6vasG(currentUser) : null);
				num2 = 8;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
				{
					num2 = 3;
				}
				break;
			}
		}
	}

	public virtual UIMetadataPublishResult Publish(Guid headerUid, string comment)
	{
		int num = 1;
		int num2 = num;
		TaskAwaiter<UIMetadataPublishResult> awaiter = default(TaskAwaiter<UIMetadataPublishResult>);
		while (true)
		{
			switch (num2)
			{
			case 1:
				awaiter = PublishAsync(headerUid, comment).GetAwaiter();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				return awaiter.GetResult();
			}
		}
	}

	string IFunctionMetadataItemManager.UpdateScriptCode(FunctionMetadata newMetadata, FunctionMetadata oldMetadata, string newSource)
	{
		return UpdateScriptCode(newMetadata, oldMetadata, newSource);
	}

	GenerateFunctionCodeResponse IFunctionMetadataItemManager.GenerateCode(GenerateFunctionCodeRequest request)
	{
		return (GenerateFunctionCodeResponse)e07IPWbc3NCviUyTaurv(request);
	}

	public IEnumerable<FunctionMetadataItem> GetCandidates(Guid headerUid)
	{
		return CreateCriteria(fetchOptions, base.ImplementationType).CreateAlias(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x20261A4F ^ 0x2026ACFD), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1765851862 ^ -1765830210), (JoinType)1).Add((ICriterion)(object)Restrictions.Eq(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5A4C7B29 ^ 0x5A4C8E15), (object)headerUid)).Add((ICriterion)(object)Restrictions.IsNotNull(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-70007027 ^ -70044175)))
			.List<FunctionMetadataItem>();
	}

	public static string UpdateScriptCode(FunctionMetadata newMetadata, FunctionMetadata oldMetadata, string newSource)
	{
		//Discarded unreachable code: IL_0075, IL_0091, IL_0160
		int num = 1;
		int num2 = num;
		GenerateFunctionCodeRequest generateFunctionCodeRequest = default(GenerateFunctionCodeRequest);
		while (true)
		{
			switch (num2)
			{
			case 4:
				if (oldMetadata != null)
				{
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
					{
						num2 = 2;
					}
					continue;
				}
				goto case 3;
			case 2:
			case 9:
				return ((GenerateFunctionCodeResponse)e07IPWbc3NCviUyTaurv(generateFunctionCodeRequest)).SourceCode;
			case 3:
			case 7:
				generateFunctionCodeRequest.GenerateFullSourceCode = true;
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
				{
					num2 = 1;
				}
				continue;
			case 12:
				Jx6CHwbcwfnKcTpyFxdF(generateFunctionCodeRequest, true);
				num2 = 11;
				continue;
			case 11:
				generateFunctionCodeRequest.GenerateReturnType = true;
				num2 = 10;
				continue;
			case 8:
				if (urZIACbcDAEwUdujsr2u(newSource))
				{
					num2 = 3;
					continue;
				}
				goto case 4;
			case 1:
				GA2ZWWbcpHt2W0Yc1wSQ(newMetadata, Tp0tH9bc8XtUgQlOpZEU(-3333094 ^ -3265308));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff != 0)
				{
					num2 = 0;
				}
				continue;
			case 10:
				generateFunctionCodeRequest.GenerateParameterType = true;
				num2 = 9;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
				{
					num2 = 3;
				}
				continue;
			case 5:
			case 6:
				RIOMdvbctvdG6wEEfJWF(generateFunctionCodeRequest, EUyQ65bcqQUDL5FhoOXg(oldMetadata));
				num2 = 12;
				continue;
			}
			GenerateFunctionCodeRequest generateFunctionCodeRequest2 = new GenerateFunctionCodeRequest();
			P36oLKbcajyN2bdPlerI(generateFunctionCodeRequest2, newMetadata);
			generateFunctionCodeRequest2.SourceCode = newSource;
			generateFunctionCodeRequest = generateFunctionCodeRequest2;
			num2 = 8;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
			{
				num2 = 5;
			}
		}
	}

	public static GenerateFunctionCodeResponse GenerateCode(GenerateFunctionCodeRequest request)
	{
		//Discarded unreachable code: IL_033b, IL_034a, IL_037f, IL_04c0, IL_04cf, IL_04de, IL_04ed, IL_0572, IL_060f, IL_061e, IL_0712, IL_0721, IL_0731
		//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01be: Unknown result type (might be due to invalid IL or missing references)
		//IL_0425: Unknown result type (might be due to invalid IL or missing references)
		//IL_042a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0495: Unknown result type (might be due to invalid IL or missing references)
		//IL_0595: Unknown result type (might be due to invalid IL or missing references)
		//IL_059a: Unknown result type (might be due to invalid IL or missing references)
		//IL_059f: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0630: Unknown result type (might be due to invalid IL or missing references)
		//IL_0635: Unknown result type (might be due to invalid IL or missing references)
		int num = 8;
		ParameterSyntax val8 = default(ParameterSyntax);
		ParameterListSyntax val7 = default(ParameterListSyntax);
		MethodDeclarationSyntax val = default(MethodDeclarationSyntax);
		GenerateFunctionCodeResponse generateFunctionCodeResponse = default(GenerateFunctionCodeResponse);
		TypeSyntax val9 = default(TypeSyntax);
		string typeName2 = default(string);
		TypeSyntax val2 = default(TypeSyntax);
		CompilationUnitSyntax val3 = default(CompilationUnitSyntax);
		ClassDeclarationSyntax val4 = default(ClassDeclarationSyntax);
		SyntaxToken val6 = default(SyntaxToken);
		_003C_003Ec__DisplayClass19_0 _003C_003Ec__DisplayClass19_ = default(_003C_003Ec__DisplayClass19_0);
		ClassDeclarationSyntax[] source = default(ClassDeclarationSyntax[]);
		FunctionMetadata functionMetadata = default(FunctionMetadata);
		MethodDeclarationSyntax val5 = default(MethodDeclarationSyntax);
		string typeName = default(string);
		_003C_003Ec__DisplayClass19_1 _003C_003Ec__DisplayClass19_2 = default(_003C_003Ec__DisplayClass19_1);
		SeparatedSyntaxList<ParameterSyntax> parameters = default(SeparatedSyntaxList<ParameterSyntax>);
		SyntaxTrivia[] array2 = default(SyntaxTrivia[]);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				SyntaxTrivia[] array;
				switch (num2)
				{
				case 29:
					if (val8 != null)
					{
						num = 16;
						break;
					}
					goto case 24;
				case 20:
					val7 = SyntaxNodeExtensions.WithTriviaFrom<ParameterListSyntax>((ParameterListSyntax)RQgNFLbcg5Jkq3mlRoZr(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x92F12D5 ^ 0x92C1BCD), 0, null, true), (SyntaxNode)j458a8bc5WSuNEMEPGCG(val));
					num2 = 4;
					continue;
				case 48:
					return generateFunctionCodeResponse;
				case 16:
					val9 = SyntaxNodeExtensions.WithTriviaFrom<TypeSyntax>(SyntaxFactory.ParseTypeName(typeName2, 0, true), (SyntaxNode)(object)val8.get_Type());
					num2 = 34;
					continue;
				case 22:
					if (xiW9brbcYcbosb0ab4Y5(((SyntaxNode)WKXCHZbcdUlrXuAgpa3Y(val)).GetText((Encoding)null, (SourceHashAlgorithm)1)) + ((SourceText)bdSqR6bcLJAqH2T5fSce(val2, null, (SourceHashAlgorithm)1)).get_Length() > 91)
					{
						num2 = 32;
						continue;
					}
					goto case 43;
				case 45:
					return generateFunctionCodeResponse;
				case 36:
				case 49:
				{
					CompilationUnitSyntax obj2 = val3;
					SyntaxToken val10 = I6Ug48bcykCNgOtwGKrD(val4);
					val6 = SyntaxFactory.Identifier(_003C_003Ec__DisplayClass19_.newName);
					val3 = SyntaxNodeExtensions.ReplaceToken<CompilationUnitSyntax>(obj2, val10, ((SyntaxToken)(ref val6)).WithTriviaFrom(I6Ug48bcykCNgOtwGKrD(val4)));
					num2 = 46;
					continue;
				}
				case 13:
					val4 = source.FirstOrDefault(_003C_003Ec__DisplayClass19_._003CGenerateCode_003Eb__1);
					num2 = 26;
					continue;
				case 25:
					if (val4 != null)
					{
						num2 = 49;
						continue;
					}
					goto case 30;
				case 23:
					typeName2 = FunctionScriptModuleType.GetTypeName((TypeSignature)cSwmx6bclvl0ZNIVssFm(functionMetadata));
					num2 = 11;
					continue;
				case 4:
				case 5:
				case 17:
					val = SyntaxNodeExtensions.ReplaceNode<MethodDeclarationSyntax>(val, (SyntaxNode)j458a8bc5WSuNEMEPGCG(val), (SyntaxNode)(object)SyntaxNodeExtensions.WithTriviaFrom<ParameterListSyntax>(val7, (SyntaxNode)j458a8bc5WSuNEMEPGCG(val5)));
					num = 38;
					break;
				case 7:
				{
					GenerateFunctionCodeResponse generateFunctionCodeResponse2 = new GenerateFunctionCodeResponse();
					ij2hpXbcHwf5SrTUIOcj(generateFunctionCodeResponse2, V6qHrObc6w4hZY5Rj0Is(request));
					generateFunctionCodeResponse = generateFunctionCodeResponse2;
					num2 = 21;
					continue;
				}
				case 40:
					typeName = FunctionScriptModuleType.GetTypeName((TypeSignature)tfaYOMbcJ22Uh9QrEOPB(functionMetadata));
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
					{
						num2 = 14;
					}
					continue;
				case 9:
					return generateFunctionCodeResponse;
				case 27:
					val4 = source.FirstOrDefault(_003C_003Ec__DisplayClass19_2._003CGenerateCode_003Eb__2);
					num2 = 25;
					continue;
				case 3:
					if (cvgCPrbcMH6i1ayCmdIk(request))
					{
						num2 = 40;
						continue;
					}
					goto case 12;
				case 35:
					_003C_003Ec__DisplayClass19_2 = new _003C_003Ec__DisplayClass19_1();
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
					{
						num2 = 6;
					}
					continue;
				case 12:
					if (!request.GenerateParameterType)
					{
						num2 = 33;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 23;
				case 6:
					_003C_003Ec__DisplayClass19_2.oldName = (string)jNBxPEbcmhlYBHPhLKai(request.OldName, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1751176224 ^ -1751265732));
					num2 = 10;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
					{
						num2 = 27;
					}
					continue;
				case 2:
					val8 = parameters.FirstOrDefault();
					num2 = 25;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0)
					{
						num2 = 29;
					}
					continue;
				case 15:
					_003C_003Ec__DisplayClass19_ = new _003C_003Ec__DisplayClass19_0();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
					{
						num2 = 0;
					}
					continue;
				case 28:
					val6 = tQOqKAbcUnWGHD9ETs7T(Tp0tH9bc8XtUgQlOpZEU(0x3630F361 ^ 0x363256ED));
					num2 = 27;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
					{
						num2 = 31;
					}
					continue;
				case 39:
					return generateFunctionCodeResponse;
				case 44:
					val5 = val;
					num2 = 3;
					continue;
				case 33:
				case 38:
					val3 = SyntaxNodeExtensions.ReplaceNode<CompilationUnitSyntax>(val3, (SyntaxNode)(object)val5, (SyntaxNode)(object)SyntaxNodeExtensions.WithTriviaFrom<MethodDeclarationSyntax>(val, (SyntaxNode)(object)val5));
					num2 = 25;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
					{
						num2 = 41;
					}
					continue;
				case 34:
					val7 = ((ParameterListSyntax)j458a8bc5WSuNEMEPGCG(val5)).WithParameters(SyntaxFactory.SingletonSeparatedList<ParameterSyntax>((ParameterSyntax)J9YXRObcjJT2bai2YaLt(val8, val9)));
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
					{
						num2 = 5;
					}
					continue;
				case 8:
					functionMetadata = (FunctionMetadata)ONJ1L0bc4QpwLDOhaZTg(request);
					num2 = 7;
					continue;
				case 41:
					ij2hpXbcHwf5SrTUIOcj(generateFunctionCodeResponse, ((object)val3).ToString());
					num2 = 18;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
					{
						num2 = 5;
					}
					continue;
				case 24:
					val2 = (TypeSyntax)Lg5E7nbc9mlw3nvJQx5F(typeName2, 0, true);
					num2 = 16;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
					{
						num2 = 22;
					}
					continue;
				case 10:
					if (val4 != null)
					{
						num2 = 36;
						continue;
					}
					goto case 45;
				case 43:
					array = Array.Empty<SyntaxTrivia>();
					goto IL_07cb;
				case 18:
					return generateFunctionCodeResponse;
				case 26:
					if (val4 == null)
					{
						num2 = 35;
						continue;
					}
					goto case 19;
				case 31:
					val7 = SyntaxFactory.ParameterList(SyntaxFactory.SingletonSeparatedList<ParameterSyntax>((ParameterSyntax)J9YXRObcjJT2bai2YaLt(SyntaxFactory.Parameter(((SyntaxToken)(ref val6)).WithLeadingTrivia((SyntaxTrivia[])(object)new SyntaxTrivia[1] { SyntaxFactory.get_Space() })), SyntaxNodeExtensions.WithLeadingTrivia<TypeSyntax>(val2, array2))));
					num2 = 17;
					continue;
				case 11:
					if (bUnCYbbcr6o8gsRvIUHZ(typeName2, Tp0tH9bc8XtUgQlOpZEU(0x1A33FE36 ^ 0x1A31420A)))
					{
						num2 = 20;
						continue;
					}
					goto case 42;
				case 1:
					if (val != null)
					{
						num2 = 44;
						continue;
					}
					goto case 39;
				case 42:
					parameters = ((BaseParameterListSyntax)j458a8bc5WSuNEMEPGCG(val5)).get_Parameters();
					num2 = 2;
					continue;
				case 21:
				{
					if (grfnEtbcAQabW4ni1MK5(request))
					{
						num = 47;
						break;
					}
					object obj = DRpHXdbc0wYmU4c7WLkO(CSharpSyntaxTree.ParseText((string)V6qHrObc6w4hZY5Rj0Is(request), ((CSharpParseOptions)DQncOsbcxvyAtgUJM0qF()).WithLanguageVersion((LanguageVersion)7), "", (Encoding)null, (ImmutableDictionary<string, ReportDiagnostic>)null, default(CancellationToken)), default(CancellationToken));
					if ((val3 = (CompilationUnitSyntax)((obj is CompilationUnitSyntax) ? obj : null)) != null)
					{
						if (!request.GenerateName)
						{
							num2 = 19;
							continue;
						}
						goto case 15;
					}
					num2 = 48;
					continue;
				}
				case 37:
					source = ((SyntaxNode)val3).DescendantNodes((Func<SyntaxNode, bool>)null, false).OfType<ClassDeclarationSyntax>().ToArray();
					num2 = 9;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
					{
						num2 = 13;
					}
					continue;
				case 14:
					val = SyntaxNodeExtensions.ReplaceNode<MethodDeclarationSyntax>(val, (SyntaxNode)(object)val.get_ReturnType(), (SyntaxNode)(object)SyntaxNodeExtensions.WithTriviaFrom<TypeSyntax>((TypeSyntax)Lg5E7nbc9mlw3nvJQx5F(typeName, 0, true), (SyntaxNode)WKXCHZbcdUlrXuAgpa3Y(val)));
					num2 = 12;
					continue;
				default:
					_003C_003Ec__DisplayClass19_.newName = (string)jNBxPEbcmhlYBHPhLKai(functionMetadata.Name, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1317790512 ^ -1317603060));
					num2 = 37;
					continue;
				case 47:
					ij2hpXbcHwf5SrTUIOcj(generateFunctionCodeResponse, GxORaXbc7xgsJYIDgOX3(functionMetadata));
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
					{
						num2 = 9;
					}
					continue;
				case 30:
					val4 = source.FirstOrDefault(delegate(ClassDeclarationSyntax q)
					{
						//IL_0025: Unknown result type (might be due to invalid IL or missing references)
						//IL_002a: Unknown result type (might be due to invalid IL or missing references)
						int num3 = 1;
						int num4 = num3;
						SyntaxToken val11 = default(SyntaxToken);
						while (true)
						{
							switch (num4)
							{
							case 1:
								val11 = _003C_003Ec.dDCHR1CJorRwT2mfZXnB(q);
								num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0)
								{
									num4 = 0;
								}
								break;
							default:
								return _003C_003Ec.gpWphQCJhrrc5B4pXaMd(((object)(SyntaxToken)(ref val11)).ToString(), _003C_003Ec.pqg2yBCJbcix5gP6ovVv(0x1C9495B4 ^ 0x1C967068));
							}
						}
					});
					num2 = 10;
					continue;
				case 19:
				case 46:
					val = ((SyntaxNode)val3).DescendantNodes((Func<SyntaxNode, bool>)null, false).OfType<MethodDeclarationSyntax>().FirstOrDefault(delegate(MethodDeclarationSyntax q)
					{
						//IL_0048: Unknown result type (might be due to invalid IL or missing references)
						//IL_004d: Unknown result type (might be due to invalid IL or missing references)
						int num5 = 1;
						int num6 = num5;
						SyntaxToken val12 = default(SyntaxToken);
						while (true)
						{
							switch (num6)
							{
							default:
								return _003C_003Ec.Tuw0HnCJERJyBIHJ9abL(((object)(SyntaxToken)(ref val12)).ToString(), _003C_003Ec.pqg2yBCJbcix5gP6ovVv(-420743386 ^ -420917930));
							case 1:
								val12 = _003C_003Ec.hBEOsKCJGGunAgDIU98F(q);
								num6 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
								{
									num6 = 0;
								}
								break;
							}
						}
					});
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
					{
						num2 = 1;
					}
					continue;
				case 32:
					{
						array = ArgWrapIndent;
						goto IL_07cb;
					}
					IL_07cb:
					array2 = array;
					num2 = 28;
					continue;
				}
				break;
			}
		}
	}

	private FunctionMetadataItem Create(FunctionMetadata metadata, FunctionMetadata oldMetadata, string sourceCode, Guid group)
	{
		int num = 25;
		ScriptModule scriptModule = default(ScriptModule);
		FunctionMetadataItemHeader functionMetadataItemHeader = default(FunctionMetadataItemHeader);
		IUser user = default(IUser);
		FunctionMetadataItem functionMetadataItem = default(FunctionMetadataItem);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					yqf0bgbzW13inkYJt43n(scriptModule, WbEgr1bzBQE6bL9VUs1j(metadata));
					num2 = 18;
					continue;
				case 23:
					scriptModule.ModuleName = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-195614443 ^ -195813323);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
					{
						num2 = 0;
					}
					continue;
				case 9:
					yuNZxIbzvLLaLPQ5fIg4(functionMetadataItemHeader, voitfwbzCyv01BNYytRE(metadata));
					num2 = 3;
					continue;
				case 17:
					user = (IUser)JPDxwLbcs8ndEeB54h9B(nNElcRbceRNI7uXurI0p(this));
					num2 = 19;
					continue;
				case 7:
					Coh7NxbzGY1FA3FVxruP(functionMetadataItem, scriptModule);
					num2 = 4;
					continue;
				case 2:
					return functionMetadataItem;
				case 6:
					g5OuvobzF7FmjWiHa9qD(scriptModule, kR7iKcbczBYIFFp2ph3P(metadata));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
					{
						num2 = 1;
					}
					continue;
				case 24:
					functionMetadataItem.Metadata = metadata;
					num2 = 17;
					continue;
				case 21:
					base.Save(functionMetadataItem);
					num2 = 2;
					continue;
				case 10:
					AL1rYTbzZIFVQpt0UymB(functionMetadataItemHeader, functionMetadataItem);
					num2 = 12;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
					{
						num2 = 13;
					}
					continue;
				case 25:
					functionMetadataItem = Create();
					num2 = 24;
					continue;
				case 12:
					break;
				default:
					scriptModule.SourceCode = (string)RZyM27bzhlxV8KYWAnqV(metadata, oldMetadata, sourceCode);
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
					{
						num2 = 5;
					}
					continue;
				case 18:
					aHMQJxbzbDxZ70Bnt5ce(scriptModule, oFJ8vobzoAwH26uvQoeN(metadata));
					num2 = 10;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0)
					{
						num2 = 23;
					}
					continue;
				case 26:
					dI02Zcbz8mXZraZ5eMFu(functionMetadataItemHeader, functionMetadataItem.CreationDate);
					num2 = 9;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 != 0)
					{
						num2 = 10;
					}
					continue;
				case 5:
					BxMeUMbzETN5lxT5wOsW(functionMetadataItemHeader, metadata.Uid);
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
					{
						num2 = 20;
					}
					continue;
				case 14:
					scriptModule.ModuleTypeUid = FunctionScriptModuleType.UID;
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
					{
						num2 = 5;
					}
					continue;
				case 16:
					GxUkxrbzfZHyTJcs36xy(functionMetadataItemHeader, eDeZWMbcXIkFYspEYFv1(metadata));
					num2 = 8;
					continue;
				case 13:
					functionMetadataItemHeader.Group = ((AbstractNHEntityManager<MetadataItemGroupUI, long>)f1Erxfbzufh49gR057AP()).LoadOrNull(group);
					num2 = 11;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0)
					{
						num2 = 4;
					}
					continue;
				case 20:
					functionMetadataItemHeader.Name = metadata.Name;
					num2 = 16;
					continue;
				case 4:
					functionMetadataItemHeader = headerManager.Create();
					num2 = 5;
					continue;
				case 22:
					Cv9jnfbcNhbebRXBxpYr(functionMetadataItem, DateTime.Now);
					num2 = 12;
					continue;
				case 3:
					functionMetadataItemHeader.CreationAuthorId = functionMetadataItem.CreationAuthorId;
					num2 = 26;
					continue;
				case 15:
					metadata.ScriptUid = uXMByjbcc3icJHo44J8e(scriptModule);
					num2 = 9;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
					{
						num2 = 14;
					}
					continue;
				case 8:
					functionMetadataItemHeader.Description = (string)Gh2oiJbzQPTMhyvJdsHY(metadata);
					num2 = 9;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0)
					{
						num2 = 3;
					}
					continue;
				case 11:
					MVNjxfbzIgWqvGa4rqe6(functionMetadataItem, functionMetadataItemHeader);
					num2 = 21;
					continue;
				case 19:
					functionMetadataItem.CreationAuthorId = (long?)((user != null) ? T5uq4UbcP0wftqV6vasG(user) : null);
					num2 = 22;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
					{
						num2 = 19;
					}
					continue;
				}
				break;
			}
			scriptModule = scriptModuleManager.Create();
			num = 15;
		}
	}

	[AsyncStateMachine(typeof(_003CPublishAsync_003Ed__21))]
	private Task<UIMetadataPublishResult> PublishAsync(Guid headerUid, string comment)
	{
		_003CPublishAsync_003Ed__21 stateMachine = default(_003CPublishAsync_003Ed__21);
		stateMachine._003C_003E4__this = this;
		stateMachine.headerUid = headerUid;
		stateMachine.comment = comment;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<UIMetadataPublishResult>.Create();
		stateMachine._003C_003E1__state = -1;
		AsyncTaskMethodBuilder<UIMetadataPublishResult> _003C_003Et__builder = stateMachine._003C_003Et__builder;
		_003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	static FunctionMetadataItemManager()
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				CejwKybcvWdLSGXffTxq();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				return;
			}
			ArgWrapIndent = (SyntaxTrivia[])(object)new SyntaxTrivia[2]
			{
				UrlFM6bzVFL703PVOoTv(),
				aNDgUnbzSefgvk3NIi7c(Tp0tH9bc8XtUgQlOpZEU(-1858887263 ^ -1859052055))
			};
			num2 = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0)
			{
				num2 = 2;
			}
		}
	}

	internal static void CejwKybcvWdLSGXffTxq()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object Tp0tH9bc8XtUgQlOpZEU(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool rJrMewbcQUktLJ2NFgEC()
	{
		return lQKG4GbcfF1fO1GFIUIZ == null;
	}

	internal static FunctionMetadataItemManager RIMwxobcCIeLj29BV0mw()
	{
		return lQKG4GbcfF1fO1GFIUIZ;
	}

	internal static void MdVl44bcZmefXd4rF9cN(object P_0, object P_1)
	{
		((NamedMetadata)P_0).Name = (string)P_1;
	}

	internal static object DKXOCnbcum5V1r0RpOfA(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static void vvlugabcIqLjPwYtV0x1(object P_0, object P_1)
	{
		((FunctionMetadata)P_0).ParameterType = (TypeSignature)P_1;
	}

	internal static object jhdePhbcVdYZ0Cp5c3of(object P_0)
	{
		return ((FunctionMetadataItemHeader)P_0).Draft;
	}

	internal static object QWWp30bcSZfjSIpir9v5(object P_0)
	{
		return ((FunctionMetadataItem)P_0).Metadata;
	}

	internal static void H5cf2IbciySBDxJVg7Fn(object P_0)
	{
		((AbstractMetadata)P_0).InitNew();
	}

	internal static void p4p39EbcRZNusj3Fst0a(object P_0, object P_1)
	{
		((FunctionMetadata)P_0).Namespace = (string)P_1;
	}

	internal static object EUyQ65bcqQUDL5FhoOXg(object P_0)
	{
		return ((NamedMetadata)P_0).Name;
	}

	internal static object Kie57wbcKt8gbqDDfZtf(object P_0, object P_1, object P_2)
	{
		return string.Format((string)P_0, P_1, P_2);
	}

	internal static object eDeZWMbcXIkFYspEYFv1(object P_0)
	{
		return ((NamedMetadata)P_0).DisplayName;
	}

	internal static void fuiefHbcT4ECQLWTmk1D(object P_0, object P_1)
	{
		((NamedMetadata)P_0).DisplayName = (string)P_1;
	}

	internal static object DLohYjbckbKws7IevwbH(object P_0)
	{
		return ((FunctionMetadataItem)P_0).ScriptModule;
	}

	internal static object GB6hT7bcna9lTHBDgWXU(object P_0)
	{
		return ((ScriptModule)P_0).SourceCode;
	}

	internal static object enef7abcOkH1f07NWCKw(object P_0)
	{
		return ((FunctionMetadataItemHeader)P_0).Group;
	}

	internal static object BHfEtEbc22NERYbH4lsB(object P_0)
	{
		return ((FunctionMetadataItem)P_0).Header;
	}

	internal static object nNElcRbceRNI7uXurI0p(object P_0)
	{
		return ((EntityManager<FunctionMetadataItem, long>)P_0).AuthenticationService;
	}

	internal static object T5uq4UbcP0wftqV6vasG(object P_0)
	{
		return ((IIdentified)P_0).GetId();
	}

	internal static DateTime ApL5nxbc1WjBb5pDVv9U()
	{
		return DateTime.Now;
	}

	internal static void Cv9jnfbcNhbebRXBxpYr(object P_0, DateTime value)
	{
		((FunctionMetadataItem)P_0).CreationDate = value;
	}

	internal static object e07IPWbc3NCviUyTaurv(object P_0)
	{
		return GenerateCode((GenerateFunctionCodeRequest)P_0);
	}

	internal static void GA2ZWWbcpHt2W0Yc1wSQ(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static void P36oLKbcajyN2bdPlerI(object P_0, object P_1)
	{
		((GenerateFunctionCodeRequest)P_0).Function = (FunctionMetadata)P_1;
	}

	internal static bool urZIACbcDAEwUdujsr2u(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static void RIOMdvbctvdG6wEEfJWF(object P_0, object P_1)
	{
		((GenerateFunctionCodeRequest)P_0).OldName = (string)P_1;
	}

	internal static void Jx6CHwbcwfnKcTpyFxdF(object P_0, bool value)
	{
		((GenerateFunctionCodeRequest)P_0).GenerateName = value;
	}

	internal static object ONJ1L0bc4QpwLDOhaZTg(object P_0)
	{
		return ((GenerateFunctionCodeRequest)P_0).Function;
	}

	internal static object V6qHrObc6w4hZY5Rj0Is(object P_0)
	{
		return ((GenerateFunctionCodeRequest)P_0).SourceCode;
	}

	internal static void ij2hpXbcHwf5SrTUIOcj(object P_0, object P_1)
	{
		((GenerateFunctionCodeResponse)P_0).SourceCode = (string)P_1;
	}

	internal static bool grfnEtbcAQabW4ni1MK5(object P_0)
	{
		return ((GenerateFunctionCodeRequest)P_0).GenerateFullSourceCode;
	}

	internal static object GxORaXbc7xgsJYIDgOX3(object P_0)
	{
		return FunctionScriptModuleType.GenerateSourceCode((FunctionMetadata)P_0);
	}

	internal static object DQncOsbcxvyAtgUJM0qF()
	{
		return CSharpParseOptions.get_Default();
	}

	internal static object DRpHXdbc0wYmU4c7WLkO(object P_0, CancellationToken P_1)
	{
		return ((SyntaxTree)P_0).GetRoot(P_1);
	}

	internal static object jNBxPEbcmhlYBHPhLKai(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static SyntaxToken I6Ug48bcykCNgOtwGKrD(object P_0)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((BaseTypeDeclarationSyntax)P_0).get_Identifier();
	}

	internal static bool cvgCPrbcMH6i1ayCmdIk(object P_0)
	{
		return ((GenerateFunctionCodeRequest)P_0).GenerateReturnType;
	}

	internal static object tfaYOMbcJ22Uh9QrEOPB(object P_0)
	{
		return ((FunctionMetadata)P_0).ReturnType;
	}

	internal static object Lg5E7nbc9mlw3nvJQx5F(object P_0, int P_1, bool P_2)
	{
		return SyntaxFactory.ParseTypeName((string)P_0, P_1, P_2);
	}

	internal static object WKXCHZbcdUlrXuAgpa3Y(object P_0)
	{
		return ((MethodDeclarationSyntax)P_0).get_ReturnType();
	}

	internal static object cSwmx6bclvl0ZNIVssFm(object P_0)
	{
		return ((FunctionMetadata)P_0).ParameterType;
	}

	internal static bool bUnCYbbcr6o8gsRvIUHZ(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static object RQgNFLbcg5Jkq3mlRoZr(object P_0, int P_1, object P_2, bool P_3)
	{
		return SyntaxFactory.ParseParameterList((string)P_0, P_1, (ParseOptions)P_2, P_3);
	}

	internal static object j458a8bc5WSuNEMEPGCG(object P_0)
	{
		return ((BaseMethodDeclarationSyntax)P_0).get_ParameterList();
	}

	internal static object J9YXRObcjJT2bai2YaLt(object P_0, object P_1)
	{
		return ((ParameterSyntax)P_0).WithType((TypeSyntax)P_1);
	}

	internal static int xiW9brbcYcbosb0ab4Y5(object P_0)
	{
		return ((SourceText)P_0).get_Length();
	}

	internal static object bdSqR6bcLJAqH2T5fSce(object P_0, object P_1, SourceHashAlgorithm P_2)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return ((SyntaxNode)P_0).GetText((Encoding)P_1, P_2);
	}

	internal static SyntaxToken tQOqKAbcUnWGHD9ETs7T(object P_0)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		return SyntaxFactory.Identifier((string)P_0);
	}

	internal static object JPDxwLbcs8ndEeB54h9B(object P_0)
	{
		return ((IAuthenticationService)P_0).GetCurrentUser();
	}

	internal static Guid uXMByjbcc3icJHo44J8e(object P_0)
	{
		return ((ScriptModule)P_0).Uid;
	}

	internal static object kR7iKcbczBYIFFp2ph3P(object P_0)
	{
		return FunctionMetadataHelper.ExecutorName((FunctionMetadata)P_0);
	}

	internal static void g5OuvobzF7FmjWiHa9qD(object P_0, object P_1)
	{
		((ScriptModule)P_0).ClassName = (string)P_1;
	}

	internal static object WbEgr1bzBQE6bL9VUs1j(object P_0)
	{
		return FunctionMetadataHelper.ServerAssemblyName((FunctionMetadata)P_0);
	}

	internal static void yqf0bgbzW13inkYJt43n(object P_0, object P_1)
	{
		((ScriptModule)P_0).AssemblyName = (string)P_1;
	}

	internal static object oFJ8vobzoAwH26uvQoeN(object P_0)
	{
		return ((FunctionMetadata)P_0).Namespace;
	}

	internal static void aHMQJxbzbDxZ70Bnt5ce(object P_0, object P_1)
	{
		((ScriptModule)P_0).Namespace = (string)P_1;
	}

	internal static object RZyM27bzhlxV8KYWAnqV(object P_0, object P_1, object P_2)
	{
		return UpdateScriptCode((FunctionMetadata)P_0, (FunctionMetadata)P_1, (string)P_2);
	}

	internal static void Coh7NxbzGY1FA3FVxruP(object P_0, object P_1)
	{
		((FunctionMetadataItem)P_0).ScriptModule = (ScriptModule)P_1;
	}

	internal static void BxMeUMbzETN5lxT5wOsW(object P_0, Guid value)
	{
		((FunctionMetadataItemHeader)P_0).Uid = value;
	}

	internal static void GxUkxrbzfZHyTJcs36xy(object P_0, object P_1)
	{
		((FunctionMetadataItemHeader)P_0).DisplayName = (string)P_1;
	}

	internal static object Gh2oiJbzQPTMhyvJdsHY(object P_0)
	{
		return ((NamedMetadata)P_0).Description;
	}

	internal static Guid voitfwbzCyv01BNYytRE(object P_0)
	{
		return ((AbstractMetadata)P_0).ModuleUid;
	}

	internal static void yuNZxIbzvLLaLPQ5fIg4(object P_0, Guid value)
	{
		((FunctionMetadataItemHeader)P_0).ModuleUid = value;
	}

	internal static void dI02Zcbz8mXZraZ5eMFu(object P_0, DateTime value)
	{
		((FunctionMetadataItemHeader)P_0).CreationDate = value;
	}

	internal static void AL1rYTbzZIFVQpt0UymB(object P_0, object P_1)
	{
		((FunctionMetadataItemHeader)P_0).Draft = (FunctionMetadataItem)P_1;
	}

	internal static object f1Erxfbzufh49gR057AP()
	{
		return MetadataItemGroupUIManager.Instance;
	}

	internal static void MVNjxfbzIgWqvGa4rqe6(object P_0, object P_1)
	{
		((FunctionMetadataItem)P_0).Header = (FunctionMetadataItemHeader)P_1;
	}

	internal static SyntaxTrivia UrlFM6bzVFL703PVOoTv()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return SyntaxFactory.get_LineFeed();
	}

	internal static SyntaxTrivia aNDgUnbzSefgvk3NIi7c(object P_0)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		return SyntaxFactory.Whitespace((string)P_0);
	}
}
