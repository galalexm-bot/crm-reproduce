using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using EleWise.ELMA.Actions;
using EleWise.ELMA.ActorModel.Abstractions;
using EleWise.ELMA.Events;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Model.Scripts.Manager;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Scripts;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
using EleWise.ELMA.UI.Actors;
using EleWise.ELMA.UI.Events;
using EleWise.ELMA.UI.Metadata;
using EleWise.ELMA.UI.Models;
using EleWise.ELMA.UI.Scripts;
using j3AmrhgkCleVTGdEwA;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using NHibernate.Criterion;
using NHibernate.SqlCommand;
using NHibernate.Transform;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.UI.Managers;

internal class ComponentMetadataItemManager : EntityManager<ComponentMetadataItem, long>, IComponentMetadataItemManager, IEntityManager<ComponentMetadataItem, long>, IEntityManager<ComponentMetadataItem>, IEntityManager
{
	private sealed class ComponentMetadataPublishingEventHandler : IComponentMetadataPublishingEventHandler, IEventHandler
	{
		private readonly object componentMetadataPublishingActor;

		private readonly Guid componentHeaderUid;

		private readonly TaskCompletionSource<UIMetadataPublishResult> taskCompletionSource;

		private static object yCvYUmQbUimS9MVLbjdM;

		public Task<UIMetadataPublishResult> Wait => taskCompletionSource.Task;

		public ComponentMetadataPublishingEventHandler(IComponentMetadataPublishingActor componentMetadataPublishingActor, Guid componentHeaderUid)
		{
			//Discarded unreachable code: IL_003c, IL_0041
			SingletonReader.JJCZtPuTvSt();
			taskCompletionSource = new TaskCompletionSource<UIMetadataPublishResult>(TaskCreationOptions.RunContinuationsAsynchronously);
			base._002Ector();
			int num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
			{
				num = 1;
			}
			while (true)
			{
				switch (num)
				{
				default:
					return;
				case 2:
					this.componentHeaderUid = componentHeaderUid;
					num = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
					{
						num = 0;
					}
					break;
				case 0:
					return;
				case 1:
					this.componentMetadataPublishingActor = componentMetadataPublishingActor;
					num = 2;
					break;
				}
			}
		}

		public Task PublicationSuccess(Guid componentMetadataUid, UIMetadataPublishResult result)
		{
			//Discarded unreachable code: IL_0031, IL_0040
			int num = 2;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return (Task)mvgdd1QhFBUU4TV0xHi4();
				case 1:
					taskCompletionSource.TrySetResult(result);
					num2 = 3;
					break;
				case 3:
					return ((IComponentMetadataPublishingActor)componentMetadataPublishingActor).PublishComplete();
				case 2:
					if (!fByy4fQbzKVqYxtOjGSA(componentMetadataUid, componentHeaderUid))
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto default;
				}
			}
		}

		public Task PublicationError(Guid componentMetadataUid, Exception exception)
		{
			//Discarded unreachable code: IL_0068, IL_0077
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					return (Task)In1wUtQhWbvVZnalkcAS(componentMetadataPublishingActor);
				case 1:
					if (!fByy4fQbzKVqYxtOjGSA(componentMetadataUid, componentHeaderUid))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 2;
				case 2:
					return (Task)mvgdd1QhFBUU4TV0xHi4();
				default:
					fs4K8fQhBc1ZpcsNDnLf(taskCompletionSource, exception);
					num2 = 3;
					break;
				}
			}
		}

		internal static bool DFp3tsQbseKcA0NkVS3d()
		{
			return yCvYUmQbUimS9MVLbjdM == null;
		}

		internal static ComponentMetadataPublishingEventHandler l91hvhQbc5OjhVZjxWxe()
		{
			return (ComponentMetadataPublishingEventHandler)yCvYUmQbUimS9MVLbjdM;
		}

		internal static bool fByy4fQbzKVqYxtOjGSA(Guid P_0, Guid P_1)
		{
			return P_0 != P_1;
		}

		internal static object mvgdd1QhFBUU4TV0xHi4()
		{
			return Task.CompletedTask;
		}

		internal static bool fs4K8fQhBc1ZpcsNDnLf(object P_0, object P_1)
		{
			return ((TaskCompletionSource<UIMetadataPublishResult>)P_0).TrySetException((Exception)P_1);
		}

		internal static object In1wUtQhWbvVZnalkcAS(object P_0)
		{
			return ((IComponentMetadataPublishingActor)P_0).PublishComplete();
		}
	}

	private readonly ScriptModuleManager scriptModuleManager;

	private readonly IComponentMetadataItemHeaderManager headerManager;

	private readonly IDependencyService dependencyService;

	private readonly ISearchMetadataService searchMetadataService;

	private readonly IScriptService scriptService;

	private readonly IActorModelRuntime actorModelRuntime;

	private readonly IEventHandlerSubscribeService eventHandlerSubscribeService;

	private readonly FetchOptions fetchOptions;

	private static readonly Dictionary<Guid, ComponentMetadataItem> SystemComponents;

	private readonly ConcurrentDictionary<string, ComponentMetadataItem> componentCache;

	private IEnumerable<IEntityFilterProvider> entityFilterProviders;

	internal static ComponentMetadataItemManager bVmjL4BQP30Gi5fmJCL2;

	private IEnumerable<IEntityFilterProvider> EntityFilterProviders => entityFilterProviders ?? (entityFilterProviders = Locator.GetServiceNotNull<IEnumerable<IEntityFilterProvider>>());

	public new static ComponentMetadataItemManager Instance => Locator.GetServiceNotNull<ComponentMetadataItemManager>();

	public ComponentMetadataItemManager(ScriptModuleManager scriptModuleManager, IComponentMetadataItemHeaderManager headerManager, IDependencyService dependencyService, ISearchMetadataService searchMetadataService, IScriptService scriptService, IActorModelRuntime actorModelRuntime, IEventHandlerSubscribeService eventHandlerSubscribeService)
	{
		//Discarded unreachable code: IL_0053, IL_0058
		RZpyeGBQ3SIGWyTcgeQj();
		fetchOptions = new FetchOptions(0, 0, ListSortDirection.Descending, (string)p1eQFWBQp3nubCPsNAyi(-195614443 ^ -195568663));
		componentCache = new ConcurrentDictionary<string, ComponentMetadataItem>();
		base._002Ector();
		int num = 4;
		while (true)
		{
			switch (num)
			{
			default:
				this.dependencyService = dependencyService;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
				{
					num = 1;
				}
				break;
			case 6:
				return;
			case 7:
				this.headerManager = headerManager;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
				{
					num = 0;
				}
				break;
			case 4:
				this.scriptModuleManager = scriptModuleManager;
				num = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0)
				{
					num = 7;
				}
				break;
			case 3:
				this.actorModelRuntime = actorModelRuntime;
				num = 2;
				break;
			case 5:
				this.scriptService = scriptService;
				num = 3;
				break;
			case 2:
				this.eventHandlerSubscribeService = eventHandlerSubscribeService;
				num = 6;
				break;
			case 1:
				this.searchMetadataService = searchMetadataService;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
				{
					num = 5;
				}
				break;
			}
		}
	}

	public override ComponentMetadataItem Load(Guid uid)
	{
		//Discarded unreachable code: IL_0059, IL_0068
		int num = 1;
		int num2 = num;
		ComponentMetadataItem value = default(ComponentMetadataItem);
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (SystemComponents.TryGetValue(uid, out value))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			case 2:
				return base.Load(uid);
			default:
				return value;
			}
		}
	}

	public override ComponentMetadataItem LoadOrNull(Guid uid)
	{
		//Discarded unreachable code: IL_002d, IL_003c
		int num = 2;
		int num2 = num;
		ComponentMetadataItem value = default(ComponentMetadataItem);
		while (true)
		{
			switch (num2)
			{
			default:
				return base.LoadOrNull(uid);
			case 1:
				return value;
			case 2:
				if (SystemComponents.TryGetValue(uid, out value))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			}
		}
	}

	public ComponentMetadataItem Create(Guid typeUid, Guid moduleUid, Guid groupUid, string displayName)
	{
		//Discarded unreachable code: IL_0039, IL_0048, IL_0058, IL_0067
		int num = 4;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 4:
				if (!Eqx94eBQapfobBrKCMjv(typeUid, PageComponentMetadata.TypeUid))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
					{
						num2 = 3;
					}
					break;
				}
				goto case 1;
			default:
				return CreateComponent(moduleUid, groupUid, displayName);
			case 5:
				return null;
			case 2:
				return CreatePortlet(moduleUid, groupUid, displayName);
			case 1:
				return CreatePage(moduleUid, groupUid, displayName);
			case 3:
				if (!Eqx94eBQapfobBrKCMjv(typeUid, PortletComponentMetadata.TypeUid))
				{
					if (!Eqx94eBQapfobBrKCMjv(typeUid, ComponentMetadata.TypeUid))
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
						{
							num2 = 5;
						}
						break;
					}
					goto default;
				}
				num2 = 2;
				break;
			}
		}
	}

	[Transaction]
	public virtual ComponentMetadataItem Create(ComponentMetadata metadata, Guid groupUid, string displayName)
	{
		int num = 12;
		int num2 = num;
		ComponentMetadataItem componentMetadataItem = default(ComponentMetadataItem);
		string assemblyName = default(string);
		while (true)
		{
			switch (num2)
			{
			default:
				return componentMetadataItem;
			case 9:
				g5BEDNBQwvBastcmvaDk(metadata, displayName);
				num2 = 6;
				break;
			case 8:
				metadata.ClientScriptUid = uNbcViBQmqexv2WGRfgK(componentMetadataItem.ClientScriptModule);
				num2 = 2;
				break;
			case 7:
				kItsR1BQ7o9fkG1ifvJT(componentMetadataItem, CreateScriptModule(ComponentScriptModuleType.TypeUid, metadata, (string)M0pBpEBQAGHcjWUoQWGj(metadata)));
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
				{
					num2 = 3;
				}
				break;
			case 11:
				wnrpEfBQtTn6tQKYAxjO(metadata);
				num2 = 9;
				break;
			case 4:
				metadata.ScriptUid = uNbcViBQmqexv2WGRfgK(IbYRvaBQ0U45VEjSmBLN(componentMetadataItem));
				num2 = 8;
				break;
			case 1:
				pBMHXqBQxm85fXuC1Jfc(componentMetadataItem, CreateScriptModule(ComponentClientScriptModuleType.TypeUid, metadata, assemblyName));
				num2 = 4;
				break;
			case 2:
				Save(componentMetadataItem);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0)
				{
					num2 = 0;
				}
				break;
			case 6:
				metadata.Name = displayName.ToTranslitIdent();
				num2 = 10;
				break;
			case 3:
				assemblyName = ComponentMetadataHelper.ClientAssemblyName(metadata);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
				{
					num2 = 1;
				}
				break;
			case 5:
				XvnshbBQHTG3BKhkjfyw(VtBN2rBQ4iiKJQ8RlloM(componentMetadataItem), ((AbstractNHEntityManager<MetadataItemGroupUI, long>)IMgWBgBQ6pRFeS1jNYRd()).LoadOrNull(groupUid));
				num2 = 7;
				break;
			case 10:
				componentMetadataItem = CreateItem(metadata);
				num2 = 5;
				break;
			case 12:
				IOJhWpBQDOSIS5lUTHSU(metadata, p1eQFWBQp3nubCPsNAyi(-957824448 ^ -957838466));
				num2 = 11;
				break;
			}
		}
	}

	[Transaction]
	public virtual ComponentMetadataItem Copy(Guid headerUid)
	{
		int num = 19;
		int num2 = num;
		ComponentMetadata componentMetadata = default(ComponentMetadata);
		ComponentMetadata componentMetadata3 = default(ComponentMetadata);
		ComponentMetadataItem draft = default(ComponentMetadataItem);
		ComponentMetadataItem componentMetadataItem = default(ComponentMetadataItem);
		string assemblyName = default(string);
		int num3 = default(int);
		string name = default(string);
		string assemblyName2 = default(string);
		ComponentMetadataItemHeader componentMetadataItemHeader = default(ComponentMetadataItemHeader);
		while (true)
		{
			switch (num2)
			{
			case 8:
				componentMetadata = ClassSerializationHelper.CloneObjectByXml(componentMetadata3);
				num2 = 12;
				break;
			case 5:
				componentMetadata3 = (ComponentMetadata)XMuSrwBQy5wfVHbOLc7y(draft);
				num2 = 8;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
				{
					num2 = 3;
				}
				break;
			case 15:
				sZd8aVBQYegI5tqZ2924(componentMetadataItem, CreateScriptModule(ComponentViewScriptModuleType.TypeUid, (string)YStk1QBQgZg6TIPsc448(componentMetadata), assemblyName, (ScriptModule)DVvZu8BQjP53pVIoyZtR(draft)));
				num2 = 20;
				break;
			default:
				TvOIPWBQMX8pBNuR23RS(componentMetadata);
				num2 = 9;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0)
				{
					num2 = 23;
				}
				break;
			case 21:
				return componentMetadataItem;
			case 19:
				num3 = new Random().Next(0, 10000);
				num2 = 18;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
				{
					num2 = 3;
				}
				break;
			case 24:
				componentMetadataItem.TestScriptModule = CreateScriptModule(TestScriptModuleType.TypeUid, componentMetadata.Name, assemblyName, draft.TestScriptModule);
				num2 = 13;
				break;
			case 14:
				Rename(componentMetadataItem, name);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				assemblyName2 = (string)M0pBpEBQAGHcjWUoQWGj(componentMetadata);
				num2 = 7;
				break;
			case 6:
				draft = componentMetadataItemHeader.Draft;
				num2 = 5;
				break;
			case 7:
				kItsR1BQ7o9fkG1ifvJT(componentMetadataItem, CreateScriptModule(ComponentScriptModuleType.TypeUid, (string)YStk1QBQgZg6TIPsc448(componentMetadata), assemblyName2, (ScriptModule)IbYRvaBQ0U45VEjSmBLN(draft)));
				num2 = 17;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0)
				{
					num2 = 1;
				}
				break;
			case 18:
				componentMetadataItemHeader = headerManager.Load(headerUid);
				num2 = 6;
				break;
			case 1:
				base.Save(componentMetadataItem);
				num2 = 21;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0)
				{
					num2 = 14;
				}
				break;
			case 3:
				assemblyName = ComponentMetadataHelper.ClientAssemblyName(componentMetadata);
				num2 = 11;
				break;
			case 16:
				J1UK0ABQdJust4Z7Vecy(componentMetadata, string.Format((string)p1eQFWBQp3nubCPsNAyi(-1751176224 ^ -1751131910), componentMetadata.Name, num3));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
				{
					num2 = 9;
				}
				break;
			case 12:
				name = componentMetadata.Name;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0)
				{
					num2 = 0;
				}
				break;
			case 9:
				g5BEDNBQwvBastcmvaDk(componentMetadata, lKmpFJBQlV1EHesxGkNV(p1eQFWBQp3nubCPsNAyi(0x1637C429 ^ 0x16373733), componentMetadata.DisplayName, num3));
				num2 = 10;
				break;
			case 10:
				componentMetadataItem = CreateItem(componentMetadata);
				num2 = 4;
				break;
			case 11:
				pBMHXqBQxm85fXuC1Jfc(componentMetadataItem, CreateScriptModule(ComponentClientScriptModuleType.TypeUid, (string)YStk1QBQgZg6TIPsc448(componentMetadata), assemblyName, draft.ClientScriptModule));
				num2 = 22;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
				{
					num2 = 22;
				}
				break;
			case 23:
				WwqFsyBQ9QQJtuov6jos(componentMetadata, fFbiVjBQJnd1tBnhXuHX(componentMetadata3));
				num2 = 16;
				break;
			case 4:
				XvnshbBQHTG3BKhkjfyw(componentMetadataItem.Header, iDnnkuBQrEFk0lyx9loB(componentMetadataItemHeader));
				num2 = 2;
				break;
			case 17:
			{
				ComponentMetadata componentMetadata6 = componentMetadata;
				object obj4 = IbYRvaBQ0U45VEjSmBLN(componentMetadataItem);
				componentMetadata6.ScriptUid = ((obj4 != null) ? new Guid?(uNbcViBQmqexv2WGRfgK(obj4)) : null);
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
				{
					num2 = 3;
				}
				break;
			}
			case 22:
			{
				ComponentMetadata componentMetadata5 = componentMetadata;
				object obj3 = v5UAQ0BQ5OMsrpaiukp4(componentMetadataItem);
				componentMetadata5.ClientScriptUid = ((obj3 != null) ? new Guid?(uNbcViBQmqexv2WGRfgK(obj3)) : null);
				num2 = 15;
				break;
			}
			case 20:
			{
				ComponentMetadata componentMetadata4 = componentMetadata;
				object obj2 = DVvZu8BQjP53pVIoyZtR(componentMetadataItem);
				componentMetadata4.ViewScriptUid = ((obj2 != null) ? new Guid?(uNbcViBQmqexv2WGRfgK(obj2)) : null);
				num2 = 24;
				break;
			}
			case 13:
			{
				ComponentMetadata componentMetadata2 = componentMetadata;
				object obj = mMduoxBQLtliXUYCW7u0(componentMetadataItem);
				componentMetadata2.TestScriptUid = ((obj != null) ? new Guid?(uNbcViBQmqexv2WGRfgK(obj)) : null);
				num2 = 14;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
				{
					num2 = 3;
				}
				break;
			}
			}
		}
	}

	[ActionCheck("ab615fac-fc87-4672-b68e-173bf0b24c60")]
	public virtual ActionCheckResult CanMarkAsNotWorking(ComponentMetadataItem obj)
	{
		//Discarded unreachable code: IL_0087, IL_0096
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (obj == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e != 0)
					{
						num2 = 0;
					}
					break;
				}
				if (obj.IsWork)
				{
					num2 = 3;
					break;
				}
				goto case 2;
			default:
				return ActionCheckResult.False((string)r2oKIBBQUNcalQ6uItoW(p1eQFWBQp3nubCPsNAyi(0x6DC147B0 ^ 0x6DC1B484)));
			case 2:
				return yM4EiBBQskcALLCMg2l1(SR.T((string)p1eQFWBQp3nubCPsNAyi(0x61EC0CB8 ^ 0x61ECFFEA)));
			case 3:
				return APUdbwBQcnKvr2ekVmtV();
			}
		}
	}

	[ActionMethod("ab615fac-fc87-4672-b68e-173bf0b24c60")]
	[Transaction]
	public virtual void MarkAsNotWorking(ComponentMetadataItem obj)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				obj.IsWork = false;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return;
			default:
				base.Save(obj);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	public void Rename(ComponentMetadataItem current, string oldName)
	{
		int num = 6;
		ComponentMetadata componentMetadata = default(ComponentMetadata);
		string name = default(string);
		string assemblyName = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					return;
				case 5:
					if ((componentMetadata = XMuSrwBQy5wfVHbOLc7y(current) as ComponentMetadata) == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
						{
							num2 = 1;
						}
						continue;
					}
					name = componentMetadata.Name;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
					{
						num2 = 2;
					}
					continue;
				default:
					UpdateScriptModule(current.ViewScriptModule, oldName, name, assemblyName);
					num2 = 3;
					continue;
				case 4:
					UpdateScriptModule(current.ClientScriptModule, oldName, name, assemblyName);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
					{
						num2 = 0;
					}
					continue;
				case 8:
					UpdateScriptModule((ScriptModule)mMduoxBQLtliXUYCW7u0(current), oldName, name, assemblyName);
					num2 = 4;
					continue;
				case 2:
					UpdateScriptModule((ScriptModule)IbYRvaBQ0U45VEjSmBLN(current), oldName, name, (string)M0pBpEBQAGHcjWUoQWGj(componentMetadata));
					num2 = 7;
					continue;
				case 6:
					break;
				case 7:
					assemblyName = ComponentMetadataHelper.ClientAssemblyName(componentMetadata);
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 != 0)
					{
						num2 = 8;
					}
					continue;
				case 1:
					return;
				}
				break;
			}
			IOJhWpBQDOSIS5lUTHSU(current, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x18A6761F ^ 0x18A6859F));
			num = 5;
		}
	}

	public override void Save(ComponentMetadataItem obj)
	{
		//Discarded unreachable code: IL_0306, IL_0315, IL_03e2, IL_041a, IL_0452, IL_0461, IL_04d0
		int num = 2;
		Guid? guid = default(Guid?);
		ComponentMetadata componentMetadata = default(ComponentMetadata);
		List<IMetadata> list = default(List<IMetadata>);
		MetadataServiceContext metadataServiceContext = default(MetadataServiceContext);
		IUser user = default(IUser);
		string errorMessage = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					guid = componentMetadata.TestScriptUid;
					num2 = 10;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
					{
						num2 = 13;
					}
					continue;
				case 20:
					euIuCxBCCWHsdCYppDDE(obj, CreateScriptModule(TestScriptModuleType.TypeUid, componentMetadata, (string)mpRFprBCQQt3kJrY4VgV(obj.ClientScriptModule)));
					num2 = 8;
					continue;
				case 10:
				{
					List<DataClassMetadata> first = searchMetadataService.GetDraftDataClasses().ToList();
					list = componentMetadata.GetMetadataToRegister().ToList();
					metadataServiceContext = MetadataServiceContext.Extend(first.Concat(list).Concat(searchMetadataService.GetDraftFunctions()).Concat(searchMetadataService.GetDraftComponents()));
					num2 = 27;
					continue;
				}
				case 19:
					user = (IUser)IS0GuvBCbsK2sFxBrWXl(zXF2lRBCoIZyU1oFEb9w(this));
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
					{
						num2 = 3;
					}
					continue;
				case 18:
					return;
				case 21:
				case 23:
					if (obj.ViewScriptModule == null)
					{
						num2 = 3;
						continue;
					}
					goto case 7;
				case 4:
					componentMetadata.ViewScriptUid = ((ScriptModule)DVvZu8BQjP53pVIoyZtR(obj)).Uid;
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
					{
						num2 = 7;
					}
					continue;
				case 26:
					break;
				case 17:
					if (guid.HasValue)
					{
						num2 = 11;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
						{
							num2 = 11;
						}
						continue;
					}
					goto case 7;
				case 6:
					if (mMduoxBQLtliXUYCW7u0(obj) == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 21;
				case 12:
					throw new InvalidOperationException(errorMessage);
				case 22:
					((ScriptModule)IbYRvaBQ0U45VEjSmBLN(obj)).ScriptMethods = ParseMethods((string)fadx3GBCfXp7vAFTdGCN(IbYRvaBQ0U45VEjSmBLN(obj)), (string)YStk1QBQgZg6TIPsc448(componentMetadata));
					num2 = 15;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
					{
						num2 = 15;
					}
					continue;
				case 2:
					Contract.ArgumentNotNull(obj, (string)p1eQFWBQp3nubCPsNAyi(-1939377524 ^ -1939353340));
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
					{
						num2 = 1;
					}
					continue;
				case 3:
					guid = componentMetadata.ViewScriptUid;
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 != 0)
					{
						num2 = 17;
					}
					continue;
				case 29:
					if (IbYRvaBQ0U45VEjSmBLN(obj) != null)
					{
						num2 = 22;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
						{
							num2 = 13;
						}
						continue;
					}
					goto case 15;
				case 11:
					sZd8aVBQYegI5tqZ2924(obj, CreateScriptModule(ComponentViewScriptModuleType.TypeUid, componentMetadata, (string)mpRFprBCQQt3kJrY4VgV(v5UAQ0BQ5OMsrpaiukp4(obj))));
					num2 = 4;
					continue;
				case 8:
					componentMetadata.TestScriptUid = uNbcViBQmqexv2WGRfgK(mMduoxBQLtliXUYCW7u0(obj));
					num2 = 23;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0)
					{
						num2 = 15;
					}
					continue;
				case 1:
					componentMetadata = obj.Metadata as ComponentMetadata;
					num2 = 16;
					continue;
				case 27:
					try
					{
						dependencyService.FillDependencies(componentMetadata, list.Select((IMetadata m) => _003C_003Ec.wLB0PtQhESw2OsR4YBvp(m)));
						int num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
						{
							num3 = 0;
						}
						switch (num3)
						{
						case 0:
							break;
						}
					}
					finally
					{
						if (metadataServiceContext != null)
						{
							int num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
							{
								num4 = 1;
							}
							while (true)
							{
								switch (num4)
								{
								case 1:
									FlghJNBCWrDK8ykLCkPx(metadataServiceContext);
									num4 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
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
					goto case 19;
				case 24:
					throw new Exception(SR.T((string)p1eQFWBQp3nubCPsNAyi(0x4EDCBA32 ^ 0x4EDC49A0), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-787452571 ^ -787439949)));
				case 16:
					if (componentMetadata != null)
					{
						if (VtBN2rBQ4iiKJQ8RlloM(obj) == null)
						{
							num2 = 28;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 != 0)
							{
								num2 = 25;
							}
							continue;
						}
						if (headerManager.ValidateName(((ComponentMetadataItemHeader)VtBN2rBQ4iiKJQ8RlloM(obj)).Uid, (string)YStk1QBQgZg6TIPsc448(componentMetadata), out errorMessage))
						{
							if (headerManager.ValidateDisplayName(d8AHZHBCFPl7Eg1y1LXP(VtBN2rBQ4iiKJQ8RlloM(obj)), (string)suAVK0BQz9Xm24vYTLc7(componentMetadata), out errorMessage))
							{
								num2 = 25;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
								{
									num2 = 8;
								}
								continue;
							}
							goto case 14;
						}
						num2 = 12;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
						{
							num2 = 7;
						}
						continue;
					}
					num2 = 24;
					continue;
				case 13:
					if (!guid.HasValue)
					{
						num2 = 21;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b != 0)
						{
							num2 = 3;
						}
						continue;
					}
					goto case 20;
				case 15:
					if (v5UAQ0BQ5OMsrpaiukp4(obj) != null)
					{
						num2 = 9;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
						{
							num2 = 5;
						}
						continue;
					}
					goto case 6;
				case 14:
					throw new InvalidOperationException(errorMessage);
				case 25:
					if (H3gqofBCBVWjFGYKJ5nv(obj.Header) == obj)
					{
						num2 = 10;
						continue;
					}
					goto case 19;
				case 28:
					throw new Exception(SR.T((string)p1eQFWBQp3nubCPsNAyi(-475857671 ^ -475918587), suAVK0BQz9Xm24vYTLc7(componentMetadata), componentMetadata.Name));
				case 9:
					obj.ClientScriptModule.ScriptMethods = ParseMethods((string)fadx3GBCfXp7vAFTdGCN(v5UAQ0BQ5OMsrpaiukp4(obj)), componentMetadata.Name);
					num2 = 6;
					continue;
				case 7:
					base.Save(obj);
					num2 = 18;
					continue;
				case 5:
					obj.CreationAuthorId = (long?)((user != null) ? AOxJvMBChdGS62gOpntK(user) : null);
					num2 = 26;
					continue;
				}
				break;
			}
			JBIBWFBCEsDpUIT68mYb(obj, nh1jBKBCGHLqUF4n7RmJ());
			num = 29;
		}
	}

	public UIMetadataPublishResult Publish(Guid headerId, string comment, bool forEmulation)
	{
		int num = 1;
		int num2 = num;
		TaskAwaiter<UIMetadataPublishResult> awaiter = default(TaskAwaiter<UIMetadataPublishResult>);
		while (true)
		{
			switch (num2)
			{
			default:
				return awaiter.GetResult();
			case 1:
				awaiter = PublishAsync(headerId, comment, forEmulation).GetAwaiter();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public IEnumerable<ComponentMetadataItemWrapper> GetCandidates(Guid headerUid)
	{
		return CreateCriteria(fetchOptions, base.ImplementationType).CreateAlias(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-234299632 ^ -234329694), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x63ABA4E8 ^ 0x63AB087C), (JoinType)1).Add((ICriterion)(object)Restrictions.Eq(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1633514411 ^ -1633519255), (object)headerUid)).Add((ICriterion)(object)Restrictions.Eq(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-606654180 ^ -606616504), (object)true))
			.Add((ICriterion)(object)Restrictions.IsNotNull(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1459557599 ^ -1459611171)))
			.Add((ICriterion)(object)Restrictions.IsNotNull(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1637C429 ^ 0x1637314D)))
			.SetProjection((IProjection[])(object)new IProjection[1] { (IProjection)Projections.ProjectionList().Add((IProjection)(object)Projections.Property(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1886646897 ^ -1886586701)), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138958856 ^ -2138904958)).Add((IProjection)(object)Projections.Property(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1334993905 ^ -1334971491)), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-978351861 ^ -978327911))
				.Add((IProjection)(object)Projections.Property(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1633514411 ^ -1633519311)), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x2ACE37D ^ 0x2AC1619)) })
			.SetResultTransformer((IResultTransformer)(object)new AliasToBeanResultTransformer(typeof(ComponentMetadataItemWrapper)))
			.List<ComponentMetadataItemWrapper>();
	}

	public IEnumerable<ComponentMetadataItemWrapper> GetLastPublished()
	{
		return CreateCriteria(fetchOptions, base.ImplementationType, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x66F566B6 ^ 0x66F59326)).CreateAlias(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x53FA00CE ^ 0x53FAB67C), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-740338220 ^ -740296352), (JoinType)0, (ICriterion)(object)Restrictions.EqProperty(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1751176224 ^ -1751130506), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x12A5FAC7 ^ 0x12A50F65))).Add((ICriterion)(object)Restrictions.Eq(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x53FA00CE ^ 0x53FAF59A), (object)true)).Add((ICriterion)(object)Restrictions.IsNotNull(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-541731959 ^ -541777547)))
			.Add((ICriterion)(object)Restrictions.IsNotNull(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1637C429 ^ 0x1637314D)))
			.SetProjection((IProjection[])(object)new IProjection[1] { (IProjection)Projections.ProjectionList().Add((IProjection)(object)Projections.Property(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2106517564 ^ -2106465672)), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x2A7797B7 ^ 0x2A7762CD)).Add((IProjection)(object)Projections.Property(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3A5D5EF ^ 0x3A5BA7D)), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1487388570 ^ -1487392780))
				.Add((IProjection)(object)Projections.Property(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x35C0467B ^ 0x35C0B31F)), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7459E02 ^ 0x7456B66)) })
			.SetResultTransformer((IResultTransformer)(object)new AliasToBeanResultTransformer(typeof(ComponentMetadataItemWrapper)))
			.List<ComponentMetadataItemWrapper>();
	}

	public static List<ScriptMethodDeclaration> ParseMethods(string sourceCode, string metadataName)
	{
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e6: Unknown result type (might be due to invalid IL or missing references)
		List<ScriptMethodDeclaration> list = new List<ScriptMethodDeclaration>();
		if (string.IsNullOrWhiteSpace(sourceCode))
		{
			return list;
		}
		SyntaxTree val = SyntaxFactory.ParseSyntaxTree(sourceCode, (ParseOptions)null, "", Encoding.UTF8, (ImmutableDictionary<string, ReportDiagnostic>)null, default(CancellationToken));
		ClassDeclarationSyntax val2 = ((val != null) ? val.GetRoot(default(CancellationToken)).DescendantNodes((Func<SyntaxNode, bool>)null, false).OfType<ClassDeclarationSyntax>()
			.FirstOrDefault(delegate(ClassDeclarationSyntax q)
			{
				//IL_0025: Unknown result type (might be due to invalid IL or missing references)
				//IL_002a: Unknown result type (might be due to invalid IL or missing references)
				int num3 = 1;
				int num4 = num3;
				SyntaxToken val5 = default(SyntaxToken);
				while (true)
				{
					switch (num4)
					{
					case 1:
						val5 = _003C_003Ec.r9BXkOQhfkgMx0ajW2bB(q);
						num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b != 0)
						{
							num4 = 0;
						}
						break;
					default:
						return _003C_003Ec.pFTUdWQhCBxRMscSqrDL(((object)(SyntaxToken)(ref val5)).ToString(), _003C_003Ec.zjMNuKQhQClj55IiiCAe(0x35C0467B ^ 0x35C15799));
					}
				}
			}) : null);
		if (val2 == null)
		{
			return list;
		}
		Enumerator<MemberDeclarationSyntax> enumerator = ((TypeDeclarationSyntax)val2).get_Members().GetEnumerator();
		while (enumerator.MoveNext())
		{
			MemberDeclarationSyntax current = enumerator.get_Current();
			_003C_003Ec__DisplayClass30_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass30_0();
			MethodDeclarationSyntax val3 = (MethodDeclarationSyntax)(object)((current is MethodDeclarationSyntax) ? current : null);
			if (val3 == null || !CSharpExtensions.Any(((MemberDeclarationSyntax)val3).get_Modifiers(), (SyntaxKind)8343))
			{
				continue;
			}
			SyntaxToken identifier = val3.get_Identifier();
			string text = ((SyntaxToken)(ref identifier)).get_Text();
			List<string> list2 = new List<string>();
			SyntaxTriviaList leadingTrivia = ((CSharpSyntaxNode)val3).GetLeadingTrivia();
			Enumerator enumerator2 = ((SyntaxTriviaList)(ref leadingTrivia)).GetEnumerator();
			while (((Enumerator)(ref enumerator2)).MoveNext())
			{
				SyntaxTrivia current2 = ((Enumerator)(ref enumerator2)).get_Current();
				string text2 = ((SyntaxTrivia)(ref current2)).ToFullString();
				if (!(text2 == z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x34A6D230 ^ 0x34A6B10E)) && !string.IsNullOrWhiteSpace(text2))
				{
					list2.Add(text2);
				}
			}
			string text3 = string.Join("", list2).Replace(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-629844702 ^ -629825304), "");
			CS_0024_003C_003E8__locals0.methodDeclaration = new ScriptMethodDeclaration
			{
				Name = text,
				ReturnType = ((object)val3.get_ReturnType()).ToString(),
				Description = string.Join("", text3)
			};
			string text4 = string.Join(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xA592A41 ^ 0xA592643), ((IEnumerable<ParameterSyntax>)(object)((BaseParameterListSyntax)((BaseMethodDeclarationSyntax)val3).get_ParameterList()).get_Parameters()).Select(delegate(ParameterSyntax param)
			{
				//IL_006d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0072: Unknown result type (might be due to invalid IL or missing references)
				int num = 2;
				int num2 = num;
				string text6 = default(string);
				string text5 = default(string);
				SyntaxToken val4 = default(SyntaxToken);
				while (true)
				{
					switch (num2)
					{
					default:
						text6 = _003C_003Ec__DisplayClass30_0.qi9eJ2QhSttbLEnv3krP(param).ToString();
						num2 = 3;
						break;
					case 4:
						return (string)_003C_003Ec__DisplayClass30_0.HvU22uQhiLvuQAmvRRQ3(text6) + (string)_003C_003Ec__DisplayClass30_0.wp3bEcQhRNEM57avFxGK(0x1C9495B4 ^ 0x1C94DC96) + text5;
					case 2:
						val4 = _003C_003Ec__DisplayClass30_0.vB4PguQhVgNsHhPWZcl0(param);
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
						{
							num2 = 1;
						}
						break;
					case 3:
						CS_0024_003C_003E8__locals0.methodDeclaration.Parameters.Add(new ScriptMethodParameter(text5, text6));
						num2 = 4;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
						{
							num2 = 3;
						}
						break;
					case 1:
						text5 = ((SyntaxToken)(ref val4)).get_Text();
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}));
			string nameSpace = ((object)val.GetRoot(default(CancellationToken)).DescendantNodes((Func<SyntaxNode, bool>)null, false).OfType<NamespaceDeclarationSyntax>()
				.First()
				.get_Name()).ToString();
			List<string> list3 = new List<string>();
			foreach (ScriptMethodParameter parameter in CS_0024_003C_003E8__locals0.methodDeclaration.Parameters)
			{
				list3.Add(ConvertType(parameter.Type, nameSpace, metadataName));
			}
			CS_0024_003C_003E8__locals0.methodDeclaration.Signature = text + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1108654032 ^ -1108650106) + string.Join(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-629844702 ^ -629843680), list3) + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-398663332 ^ -398655776);
			CS_0024_003C_003E8__locals0.methodDeclaration.DisplayInfo = text + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-70007027 ^ -70002501) + text4 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-542721635 ^ -542726623);
			list.Add(CS_0024_003C_003E8__locals0.methodDeclaration);
		}
		return list;
	}

	internal void AddSystemComponent(ComponentMetadataItem item)
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
				SystemComponents.Add(item.Uid, item);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public List<RuntimeComponentModel> LoadRuntimeMetadata(IEnumerable<Guid> itemUids, bool debug)
	{
		_003C_003Ec__DisplayClass32_0 _003C_003Ec__DisplayClass32_ = new _003C_003Ec__DisplayClass32_0();
		_003C_003Ec__DisplayClass32_._003C_003E4__this = this;
		List<RuntimeComponentModel> list = new List<RuntimeComponentModel>();
		Guid[] array = itemUids.ToArray();
		if (array.Length == 0)
		{
			return list;
		}
		IList<ComponentMetadataItem> list2 = new List<ComponentMetadataItem>();
		_003C_003Ec__DisplayClass32_.notLoadedItemUids = new List<Guid>();
		foreach (Guid itemUid in itemUids)
		{
			_003C_003Ec__DisplayClass32_.notLoadedItemUids.Add(itemUid);
		}
		if (_003C_003Ec__DisplayClass32_.notLoadedItemUids.Count > 0)
		{
			_003C_003Ec__DisplayClass32_1 CS_0024_003C_003E8__locals1 = new _003C_003Ec__DisplayClass32_1();
			CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1 = _003C_003Ec__DisplayClass32_;
			CS_0024_003C_003E8__locals1.loadedComponents = null;
			SR.LocalizableString.RunWithSRLocalizer(delegate
			{
				int num3 = 1;
				int num4 = num3;
				while (true)
				{
					switch (num4)
					{
					default:
						return;
					case 1:
						CS_0024_003C_003E8__locals1.loadedComponents = CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1._003C_003E4__this.CreateCriteriaForArraySearch(CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals1.notLoadedItemUids, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1979251663 ^ -1979225181), null, null).List<ComponentMetadataItem>();
						num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
						{
							num4 = 0;
						}
						break;
					case 0:
						return;
					}
				}
			});
			list2.AddRange(CS_0024_003C_003E8__locals1.loadedComponents);
		}
		if (list2.Count == 0)
		{
			Guid[] array2 = array;
			for (int i = 0; i < array2.Length; i++)
			{
				_003C_003Ec__DisplayClass32_2 _003C_003Ec__DisplayClass32_2 = new _003C_003Ec__DisplayClass32_2();
				_003C_003Ec__DisplayClass32_2.CS_0024_003C_003E8__locals2 = _003C_003Ec__DisplayClass32_;
				_003C_003Ec__DisplayClass32_2.itemUid = array2[i];
				_003C_003Ec__DisplayClass32_3 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass32_3();
				CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals3 = _003C_003Ec__DisplayClass32_2;
				CS_0024_003C_003E8__locals0.systemComponent = null;
				SR.LocalizableString.RunWithSRLocalizer(delegate
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
							CS_0024_003C_003E8__locals0.systemComponent = CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals3.CS_0024_003C_003E8__locals2._003C_003E4__this.LoadOrNull(CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals3.itemUid);
							num2 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
							{
								num2 = 0;
							}
							break;
						}
					}
				});
				if (CS_0024_003C_003E8__locals0.systemComponent != null)
				{
					ScriptModule clientScriptModule = CS_0024_003C_003E8__locals0.systemComponent.ClientScriptModule;
					string sourceCode = SR.TranslateStringResource(Encoding.UTF8.GetString(clientScriptModule.AssemblyRaw ?? Array.Empty<byte>()));
					list.Add(new RuntimeComponentModel
					{
						MetadataItem = CS_0024_003C_003E8__locals0.systemComponent,
						Script = new ClientScriptModel
						{
							AssemblyName = clientScriptModule.AssemblyName,
							SourceCode = sourceCode
						}
					});
				}
			}
			return list;
		}
		foreach (ComponentMetadataItem item in list2)
		{
			ComponentMetadataItem componentMetadataItem = item;
			ComponentMetadata componentMetadata = (ComponentMetadata)componentMetadataItem.Metadata;
			if (componentMetadataItem.Header.Published?.Id == componentMetadataItem.Id || componentMetadataItem.Header.Emulation?.Id == componentMetadataItem.Id)
			{
				foreach (PropertyViewItem allProperty in componentMetadata.Content.View.GetAllProperties())
				{
					FillFilterProvider(allProperty, null, componentMetadataItem, componentMetadata.Content.Context);
				}
			}
			ScriptModule clientScriptModule2 = item.ClientScriptModule;
			byte[] array3 = (debug ? clientScriptModule2.DebugRaw : clientScriptModule2.AssemblyRaw);
			string text = Encoding.UTF8.GetString(array3 ?? Array.Empty<byte>());
			if (SR.GetCurrentCulture().Name != SR.KeyCultureInfo.Name)
			{
				text = SR.TranslateStringResource(text);
				componentMetadataItem = CloneHelperBuilder.Create(item).Restrictions(delegate(RestrictionsBuilder<ComponentMetadataItem> a)
				{
					RestrictionBuilderSelectType<ComponentMetadataItem> restrictionBuilderSelectType3 = a.Rule();
					ParameterExpression parameterExpression3 = Expression.Parameter(typeof(ComponentMetadataItem), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x637E299B ^ 0x637EDC0B));
					restrictionBuilderSelectType3.ForPropertyName(Expression.Lambda<Func<ComponentMetadataItem, object>>(Expression.Property(parameterExpression3, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression3 })).ByRef();
				}).Restrictions(delegate(RestrictionsBuilder<ComponentMetadataItem> a)
				{
					RestrictionBuilderSelectType<ComponentMetadataItem> restrictionBuilderSelectType2 = a.Rule();
					ParameterExpression parameterExpression2 = Expression.Parameter(typeof(ComponentMetadataItem), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1411196499 ^ -1411240899));
					restrictionBuilderSelectType2.ForPropertyName(Expression.Lambda<Func<ComponentMetadataItem, object>>(Expression.Property(parameterExpression2, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression2 })).ByRef();
				})
					.Restrictions(delegate(RestrictionsBuilder<ComponentMetadataItem> a)
					{
						RestrictionBuilderSelectType<ComponentMetadataItem> restrictionBuilderSelectType = a.Rule();
						ParameterExpression parameterExpression = Expression.Parameter(typeof(ComponentMetadataItem), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7459E02 ^ 0x7456B92));
						restrictionBuilderSelectType.ForPropertyName(Expression.Lambda<Func<ComponentMetadataItem, object>>(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression })).ByRef();
					})
					.Clone();
				componentMetadataItem.Uid = item.Uid;
				componentMetadata = (ComponentMetadata)componentMetadataItem.Metadata;
				componentMetadata.Content.View.ApplyLocalization();
			}
			list.Add(new RuntimeComponentModel
			{
				MetadataItem = componentMetadataItem,
				Script = new ClientScriptModel
				{
					AssemblyName = clientScriptModule2.AssemblyName,
					SourceCode = text
				}
			});
		}
		return list;
	}

	internal IEnumerable<ItemWithScriptModuleWrapper> GetItemsWithClientScriptModules()
	{
		return CreateCriteria().CreateAlias(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-289714582 ^ -289670952), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7459E02 ^ 0x7453296), (JoinType)1).CreateAlias(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1418440330 ^ 0x548B5B5C), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7C1EE318 ^ 0x7C1E16E6), (JoinType)1).Add((ICriterion)(object)Restrictions.NotEqProperty(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2106517564 ^ -2106465846), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4DC2B14D ^ 0x4DC23013)))
			.Add((ICriterion)(object)Restrictions.Eq(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-345420348 ^ -345392146), (object)false))
			.Add((ICriterion)(object)Restrictions.Eq(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2099751081 ^ -2099732199), (object)false))
			.Add((ICriterion)(object)Restrictions.IsNotNull(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1217523399 ^ -1217469201)))
			.Add((ICriterion)(object)Restrictions.IsNotNull(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1858887263 ^ -1858906167)))
			.SetProjection((IProjection[])(object)new IProjection[1] { (IProjection)Projections.ProjectionList().Add((IProjection)(object)Projections.Property(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xD3DEF7E ^ 0xD3D80EC)), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-978351861 ^ -978327911)).Add((IProjection)(object)Projections.Property(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x53FA00CE ^ 0x53FAF518)), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1A33FE36 ^ 0x1A3308A6)) })
			.SetResultTransformer((IResultTransformer)(object)new AliasToBeanResultTransformer(typeof(ItemWithScriptModuleWrapper)))
			.List<ItemWithScriptModuleWrapper>();
	}

	private ComponentMetadataItem CreateComponent(Guid moduleUid, Guid groupUid, string displayName)
	{
		int num = 1;
		int num2 = num;
		ComponentMetadata componentMetadata = default(ComponentMetadata);
		while (true)
		{
			switch (num2)
			{
			default:
				return (ComponentMetadataItem)aGRif2BCv8j9Fr4innI3(this, componentMetadata, groupUid, displayName);
			case 1:
				componentMetadata = new ComponentMetadata(moduleUid);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private ComponentMetadataItem CreatePage(Guid moduleUid, Guid groupUid, string displayName)
	{
		int num = 1;
		int num2 = num;
		PageComponentMetadata pageComponentMetadata = default(PageComponentMetadata);
		while (true)
		{
			switch (num2)
			{
			case 1:
				pageComponentMetadata = new PageComponentMetadata(moduleUid);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				return (ComponentMetadataItem)aGRif2BCv8j9Fr4innI3(this, pageComponentMetadata, groupUid, displayName);
			}
		}
	}

	private ComponentMetadataItem CreatePortlet(Guid moduleUid, Guid groupUid, string displayName)
	{
		int num = 1;
		int num2 = num;
		PortletComponentMetadata metadata = default(PortletComponentMetadata);
		while (true)
		{
			switch (num2)
			{
			case 1:
				metadata = new PortletComponentMetadata(moduleUid);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				return Create(metadata, groupUid, displayName);
			}
		}
	}

	private ComponentMetadataItem CreateItem(ComponentMetadata metadata)
	{
		int num = 4;
		ComponentMetadataItemHeader componentMetadataItemHeader = default(ComponentMetadataItemHeader);
		ComponentMetadataItem componentMetadataItem = default(ComponentMetadataItem);
		IUser user = default(IUser);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 5:
					Hk3Pb7BCVAV3STNYVfFv(componentMetadataItemHeader, suAVK0BQz9Xm24vYTLc7(metadata));
					num2 = 9;
					continue;
				case 6:
					componentMetadataItemHeader.CreationDate = op8kR1BCRdbI28SB8IvU(componentMetadataItem);
					num2 = 13;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
					{
						num2 = 1;
					}
					continue;
				case 7:
					return componentMetadataItem;
				case 15:
					raEnifBCib5sjoK3bsmb(componentMetadataItemHeader, metadata.ModuleUid);
					num2 = 2;
					continue;
				case 8:
					componentMetadataItem.CreationDate = nh1jBKBCGHLqUF4n7RmJ();
					num = 10;
					break;
				case 4:
					componentMetadataItem = Create();
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
					{
						num2 = 0;
					}
					continue;
				case 11:
					GURoKoBCuk6wyY4cGjlf(componentMetadataItemHeader, Qta7asBCZCEDJSBxonwD(metadata));
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
					{
						num2 = 1;
					}
					continue;
				case 13:
					Kvi5xgBCqofeORBuXPAY(componentMetadataItemHeader, componentMetadataItem);
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
					{
						num2 = 12;
					}
					continue;
				case 3:
					APhxmnBC80ordJpdwHCl(componentMetadataItem, metadata);
					num2 = 16;
					continue;
				case 12:
					TgS3knBCXFR94Ook0xAS(componentMetadataItemHeader, NkR9WMBCKNMZktyO5WWf(metadata));
					num2 = 14;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
					{
						num2 = 3;
					}
					continue;
				case 16:
					user = (IUser)IS0GuvBCbsK2sFxBrWXl(zXF2lRBCoIZyU1oFEb9w(this));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
					{
						num2 = 0;
					}
					continue;
				case 10:
					componentMetadataItemHeader = headerManager.Create();
					num2 = 11;
					continue;
				case 1:
					jbsx2QBCIiDUSYeDyL5v(componentMetadataItemHeader, YStk1QBQgZg6TIPsc448(metadata));
					num = 5;
					break;
				case 9:
					componentMetadataItemHeader.Description = (string)VLQMBOBCSy2I0wga3ICU(metadata);
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
					{
						num2 = 15;
					}
					continue;
				case 14:
					o2eSCZBCTDXHE60HueUc(componentMetadataItem, componentMetadataItemHeader);
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
					{
						num2 = 6;
					}
					continue;
				case 2:
					componentMetadataItemHeader.CreationAuthorId = componentMetadataItem.CreationAuthorId;
					num = 6;
					break;
				default:
					componentMetadataItem.CreationAuthorId = (long?)user?.GetId();
					num = 8;
					break;
				}
				break;
			}
		}
	}

	private ScriptModule CreateScriptModule(Guid moduleTypeUid, ComponentMetadata metadata, string assemblyName)
	{
		int num = 3;
		int num2 = num;
		string sourceCode = default(string);
		while (true)
		{
			object obj;
			switch (num2)
			{
			case 1:
				return CreateScriptModule(moduleTypeUid, (string)YStk1QBQgZg6TIPsc448(metadata), assemblyName, sourceCode);
			case 3:
			{
				IScriptModuleType scriptModuleType = scriptModuleManager.GetScriptModuleType(moduleTypeUid);
				if (scriptModuleType == null)
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
					{
						num2 = 1;
					}
					continue;
				}
				obj = scriptModuleType.GenerateSourceCode(metadata);
				goto IL_0076;
			}
			case 2:
				obj = null;
				goto IL_0076;
			default:
				{
					obj = string.Empty;
					break;
				}
				IL_0076:
				if (obj != null)
				{
					break;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
				{
					num2 = 0;
				}
				continue;
			}
			sourceCode = (string)obj;
			num2 = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
			{
				num2 = 1;
			}
		}
	}

	private ScriptModule CreateScriptModule(Guid moduleTypeUid, string name, string assemblyName, ScriptModule oldScriptModule)
	{
		int num = 2;
		ScriptModule scriptModule = default(ScriptModule);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 4:
					scriptModule.ScriptMethods.AddRange(oldScriptModule.ScriptMethods);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
					{
						num2 = 0;
					}
					break;
				case 1:
					return null;
				default:
					return scriptModule;
				case 3:
					if (oldScriptModule.ScriptMethods.Count > 0)
					{
						goto end_IL_0012;
					}
					goto default;
				case 2:
					if (oldScriptModule != null)
					{
						scriptModule = CreateScriptModule(moduleTypeUid, name, assemblyName, (string)fadx3GBCfXp7vAFTdGCN(oldScriptModule));
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
						{
							num2 = 3;
						}
					}
					else
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
						{
							num2 = 1;
						}
					}
					break;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 4;
		}
	}

	private ScriptModule CreateScriptModule(Guid moduleTypeUid, string name, string assemblyName, string sourceCode)
	{
		ScriptModule scriptModule = scriptModuleManager.Create();
		e24Pk9BCk4TJKOgGUhet(scriptModule, name);
		YxGhC9BCnWpcpgM2T0b3(scriptModule, name);
		znONuNBCO7isWkYOKQAb(scriptModule, assemblyName);
		wrZcTkBC2SlMpCkukmhi(scriptModule, moduleTypeUid);
		GMoFx4BCeD0GDyCEtvMh(scriptModule, sourceCode);
		TnKhA0BCPLxjGtCXqrVE(scriptModule, string.Empty);
		QNIMFGBC1K0Tp3sMNInH(scriptModule, (moduleTypeUid == ComponentScriptModuleType.TypeUid) ? p1eQFWBQp3nubCPsNAyi(-541731959 ^ -541769833) : z2jc63fLkugS1X8Q9N.tE1kD1vbB(-542721635 ^ -542748879));
		return scriptModule;
	}

	private static string ConvertParameter(object paramType)
	{
		//Discarded unreachable code: IL_008f, IL_009e, IL_0152, IL_0161
		int num = 8;
		int num2 = num;
		string result = default(string);
		string text2 = default(string);
		string text = default(string);
		List<string> values = default(List<string>);
		while (true)
		{
			switch (num2)
			{
			case 6:
				result = (string)ASlj9iBCa2nLDsN2pdoN(text2, p1eQFWBQp3nubCPsNAyi(-210725949 ^ -210707451), text, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-542721635 ^ -542706083));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
				{
					num2 = 4;
				}
				break;
			default:
				result = text2.Split('.').Last();
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
				{
					num2 = 3;
				}
				break;
			case 3:
			case 4:
				return result;
			case 9:
				text = string.Join((string)p1eQFWBQp3nubCPsNAyi(-1939377524 ^ -1939374450), values);
				num2 = 6;
				break;
			case 7:
				if (!(text2 != text))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 1;
			case 1:
				text2 = text2.Split('.').Last();
				num2 = 2;
				break;
			case 8:
			{
				object source = T889fsBCNqPXytji7JU3(paramType, new char[1] { '<' });
				text2 = ((IEnumerable<string>)source).First();
				text = ((IEnumerable<string>)source).Last();
				num2 = 7;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0)
				{
					num2 = 6;
				}
				break;
			}
			case 2:
				values = ((IEnumerable<string>)ksD7jWBCp8r5fuBqNysR(CcMvRcBC3KHcOHF26eN9(text, p1eQFWBQp3nubCPsNAyi(-29254301 ^ -29240669), ""), new string[1] { (string)p1eQFWBQp3nubCPsNAyi(0x49E27B8A ^ 0x49E27788) }, StringSplitOptions.None)).Select((string param) => ((IEnumerable<string>)_003C_003Ec.vR2FjjQhvekrdAOTflq5(param, new char[1] { '.' })).Last()).ToList();
				num2 = 9;
				break;
			}
		}
	}

	private static string ConvertType(object type, object nameSpace, object metadataName)
	{
		//Discarded unreachable code: IL_00f5, IL_0148, IL_0157, IL_0162, IL_0283, IL_0292, IL_02dc, IL_02ef
		int num = 6;
		string text = default(string);
		List<string>.Enumerator enumerator = default(List<string>.Enumerator);
		List<string> list = default(List<string>);
		string text2 = default(string);
		string current = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 8:
					text = (string)CcMvRcBC3KHcOHF26eN9(CcMvRcBC3KHcOHF26eN9(text, p1eQFWBQp3nubCPsNAyi(-1426094279 ^ -1426077441), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x12441CA4 ^ 0x1244EBF4)), p1eQFWBQp3nubCPsNAyi(0x5A4C7B29 ^ 0x5A4C34E9), p1eQFWBQp3nubCPsNAyi(0x3630F361 ^ 0x3630043D));
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
					{
						num2 = 3;
					}
					continue;
				case 4:
					if (!text.Contains((string)p1eQFWBQp3nubCPsNAyi(-1633514411 ^ -1633500269)))
					{
						num2 = 11;
						continue;
					}
					goto case 8;
				case 3:
				case 11:
					return text;
				case 5:
					if (A4481xBCDXthGmCfuxLd(text, p1eQFWBQp3nubCPsNAyi(0x63ABA4E8 ^ 0x63ABEB2E)))
					{
						num2 = 9;
						continue;
					}
					goto case 3;
				case 7:
					enumerator = list.GetEnumerator();
					num = 2;
					break;
				case 2:
					try
					{
						while (true)
						{
							int num3;
							if (!enumerator.MoveNext())
							{
								num3 = 4;
								goto IL_0166;
							}
							goto IL_029d;
							IL_0166:
							while (true)
							{
								switch (num3)
								{
								case 6:
									text2 = current;
									num3 = 5;
									continue;
								case 5:
									if (!EFxr7MBC4er12ltS5Z8R(current, p1eQFWBQp3nubCPsNAyi(-488881205 ^ -488896561)))
									{
										num3 = 3;
										continue;
									}
									goto default;
								default:
									text2 = (string)dYAHpyBC6FYecChjI66W(metadataName, p1eQFWBQp3nubCPsNAyi(0x4A1640F ^ 0x4A12BD1), current);
									num3 = 2;
									continue;
								case 7:
									break;
								case 2:
								case 3:
									text = (string)CcMvRcBC3KHcOHF26eN9(text, current, Wiw0o3BCHR7kbspqWTJa(new string[5]
									{
										(string)p1eQFWBQp3nubCPsNAyi(0x8317432 ^ 0x83182D0),
										(string)nameSpace,
										z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1921202237 ^ -1921196793),
										text2,
										(string)p1eQFWBQp3nubCPsNAyi(-2138160520 ^ -2138131312)
									}));
									num3 = 7;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f != 0)
									{
										num3 = 7;
									}
									continue;
								case 1:
									goto IL_029d;
								case 4:
									goto end_IL_01ef;
								}
								break;
							}
							continue;
							IL_029d:
							current = enumerator.Current;
							num3 = 6;
							goto IL_0166;
							continue;
							end_IL_01ef:
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator).Dispose();
						int num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
						{
							num4 = 0;
						}
						switch (num4)
						{
						case 0:
							break;
						}
					}
					goto case 10;
				default:
					text = (string)ncKfqQBCx2WMM7NcAgBh(p1eQFWBQp3nubCPsNAyi(-345420348 ^ -345392422), text);
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
					{
						num2 = 4;
					}
					continue;
				case 10:
					text = (string)CcMvRcBC3KHcOHF26eN9(CcMvRcBC3KHcOHF26eN9(text, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4D1C1EE4 ^ 0x4D1C5122), QcvD7KBC74OTqSu61cGl(p1eQFWBQp3nubCPsNAyi(0x26FFCB59 ^ 0x26FF3DB7), c6DObPBCAuWF9rQH0YXh(list))), p1eQFWBQp3nubCPsNAyi(0x57A5235E ^ 0x57A56C9E), p1eQFWBQp3nubCPsNAyi(0x3C5338FF ^ 0x3C53CE17));
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
					{
						num2 = 1;
					}
					continue;
				case 1:
					if (A4481xBCDXthGmCfuxLd(nameSpace, p1eQFWBQp3nubCPsNAyi(-1633514411 ^ -1633518935)))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 4;
				case 9:
					list = ((IEnumerable<string>)ksD7jWBCp8r5fuBqNysR(CcMvRcBC3KHcOHF26eN9(Fu9mkQBCww0hm02gkFqu(text, GX6YqvBCtnEGuR8h0GtD(text, '<') + 1), p1eQFWBQp3nubCPsNAyi(-105199646 ^ -105215966), ""), new string[1] { (string)p1eQFWBQp3nubCPsNAyi(0x3CE17B75 ^ 0x3CE17777) }, StringSplitOptions.None)).ToList();
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
					{
						num2 = 1;
					}
					continue;
				case 6:
					text = (string)type;
					num = 5;
					break;
				}
				break;
			}
		}
	}

	private void UpdateScriptModule(ScriptModule scriptModule, string oldName, string newName, string assemblyName)
	{
		//Discarded unreachable code: IL_003d
		int num = 1;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 4:
					return;
				case 3:
					return;
				case 1:
					if (scriptModule == null)
					{
						return;
					}
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0)
					{
						num2 = 0;
					}
					continue;
				case 5:
					YxGhC9BCnWpcpgM2T0b3(scriptModule, newName);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
					{
						num2 = 2;
					}
					continue;
				case 6:
					e24Pk9BCk4TJKOgGUhet(scriptModule, newName);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
					{
						num2 = 5;
					}
					continue;
				case 2:
					znONuNBCO7isWkYOKQAb(scriptModule, assemblyName);
					num2 = 3;
					continue;
				}
				break;
			}
			GMoFx4BCeD0GDyCEtvMh(scriptModule, KIQXKOBC0AhPW0H3UL8C(scriptService, fadx3GBCfXp7vAFTdGCN(scriptModule), oldName, newName));
			num = 6;
		}
	}

	[AsyncStateMachine(typeof(_003CPublishAsync_003Ed__44))]
	private Task<UIMetadataPublishResult> PublishAsync(Guid headerId, string comment, bool forEmulation)
	{
		_003CPublishAsync_003Ed__44 stateMachine = default(_003CPublishAsync_003Ed__44);
		stateMachine._003C_003E4__this = this;
		stateMachine.headerId = headerId;
		stateMachine.comment = comment;
		stateMachine.forEmulation = forEmulation;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<UIMetadataPublishResult>.Create();
		stateMachine._003C_003E1__state = -1;
		AsyncTaskMethodBuilder<UIMetadataPublishResult> _003C_003Et__builder = stateMachine._003C_003Et__builder;
		_003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	private void FillFilterProvider(PropertyViewItem propertyViewItem, Type containerType, IEntity entity, ClassMetadata contextMetadata)
	{
		//Discarded unreachable code: IL_0046, IL_0050, IL_009a, IL_00a9, IL_00ec, IL_0176, IL_0195, IL_01a4, IL_01d1, IL_01e0, IL_0274, IL_027e, IL_0331, IL_0369, IL_0378
		int num = 4;
		IEnumerator<IEntityFilterProvider> enumerator2 = default(IEnumerator<IEntityFilterProvider>);
		IEntityFilterProvider current2 = default(IEntityFilterProvider);
		Type item2 = default(Type);
		PropertyMetadata item = default(PropertyMetadata);
		ViewAttributes viewAttributes = default(ViewAttributes);
		string text = default(string);
		IEnumerator<PropertyViewItem> enumerator = default(IEnumerator<PropertyViewItem>);
		PropertyViewItem current = default(PropertyViewItem);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					try
					{
						while (true)
						{
							IL_00b4:
							int num5;
							if (!cNGsrMBCgu2jSn3TeFOm(enumerator2))
							{
								num5 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
								{
									num5 = 1;
								}
								goto IL_0054;
							}
							goto IL_0082;
							IL_0082:
							current2 = enumerator2.Current;
							num5 = 6;
							goto IL_0054;
							IL_0054:
							while (true)
							{
								object obj;
								switch (num5)
								{
								case 8:
									break;
								case 5:
									goto end_IL_00b4;
								default:
									goto IL_00b4;
								case 2:
									obj = jL2fH6BCJpxfwYNMgcOl(current2, item2, item, viewAttributes);
									goto IL_0154;
								case 7:
									GkOCpuBCl0TiZdHsTt5N(viewAttributes, f04e0yBCdY41miBwZbhO(current2));
									num5 = 4;
									continue;
								case 3:
									if (text != null)
									{
										num5 = 7;
										continue;
									}
									goto IL_00b4;
								case 6:
									if (!(current2 is IEntityInstanceFilterProvider entityInstanceFilterProvider))
									{
										num5 = 2;
										continue;
									}
									obj = nvZPlcBC9QZwYN5Taakx(entityInstanceFilterProvider, entity, item2, item, viewAttributes);
									goto IL_0154;
								case 4:
									C3O8HTBCrnnamx5JcMGO(viewAttributes, text);
									num5 = 5;
									continue;
								case 1:
									goto end_IL_00b4;
									IL_0154:
									text = (string)obj;
									num5 = 3;
									continue;
								}
								break;
							}
							goto IL_0082;
							continue;
							end_IL_00b4:
							break;
						}
					}
					finally
					{
						int num6;
						if (enumerator2 == null)
						{
							num6 = 2;
							goto IL_017a;
						}
						goto IL_01af;
						IL_017a:
						switch (num6)
						{
						case 2:
							goto end_IL_0165;
						case 1:
							goto end_IL_0165;
						}
						goto IL_01af;
						IL_01af:
						FlghJNBCWrDK8ykLCkPx(enumerator2);
						num6 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 != 0)
						{
							num6 = 0;
						}
						goto IL_017a;
						end_IL_0165:;
					}
					goto case 1;
				case 8:
					viewAttributes = (ViewAttributes)DbW3sgBCMqWLYotJtJKl(propertyViewItem);
					num2 = 6;
					continue;
				case 5:
					return;
				case 4:
					break;
				case 6:
					enumerator2 = entityFilterProviders.GetEnumerator();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					if (LkSZQtBCyq3H7sE9g6R9(item2, null))
					{
						num2 = 8;
						continue;
					}
					goto case 1;
				case 7:
					try
					{
						while (true)
						{
							int num3;
							if (!cNGsrMBCgu2jSn3TeFOm(enumerator))
							{
								num3 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
								{
									num3 = 0;
								}
								goto IL_0282;
							}
							goto IL_02c2;
							IL_02c2:
							current = enumerator.Current;
							num3 = 2;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 != 0)
							{
								num3 = 2;
							}
							goto IL_0282;
							IL_0282:
							while (true)
							{
								switch (num3)
								{
								case 1:
									return;
								case 3:
									goto IL_02c2;
								case 2:
									FillFilterProvider(current, containerType, entity, contextMetadata);
									num3 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0)
									{
										num3 = 0;
									}
									continue;
								}
								break;
							}
						}
					}
					finally
					{
						if (enumerator != null)
						{
							int num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0)
							{
								num4 = 0;
							}
							while (true)
							{
								switch (num4)
								{
								default:
									FlghJNBCWrDK8ykLCkPx(enumerator);
									num4 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
									{
										num4 = 1;
									}
									continue;
								case 1:
									break;
								}
								break;
							}
						}
					}
				case 1:
					enumerator = propertyViewItem.Items.OfType<PropertyViewItem>().GetEnumerator();
					num2 = 7;
					continue;
				case 3:
					if (item != null)
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 1;
				}
				break;
			}
			(PropertyMetadata, Type) tuple = FindProperty(containerType, contextMetadata, h5HobCBCm0JMY1TD3hgo(propertyViewItem), propertyViewItem.PropertyParents);
			item = tuple.Item1;
			item2 = tuple.Item2;
			num = 3;
		}
	}

	private (PropertyMetadata, Type) FindProperty(Type containerType, ClassMetadata entityMetadata, Guid propertyUid, IEnumerable<Guid> propertyParents)
	{
		_003C_003Ec__DisplayClass46_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass46_0();
		CS_0024_003C_003E8__locals0.propertyUid = propertyUid;
		PropertyMetadata propertyMetadata = entityMetadata.Properties.FirstOrDefault((PropertyMetadata p) => _003C_003Ec__DisplayClass46_0.TbaYc3QhmKWE9YJxx5GW(p) == CS_0024_003C_003E8__locals0.propertyUid);
		if (propertyMetadata != null)
		{
			return (propertyMetadata, containerType);
		}
		return (null, null);
	}

	static ComponentMetadataItemManager()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				RZpyeGBQ3SIGWyTcgeQj();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				SystemComponents = new Dictionary<Guid, ComponentMetadataItem>();
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				return;
			}
		}
	}

	internal static void RZpyeGBQ3SIGWyTcgeQj()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object p1eQFWBQp3nubCPsNAyi(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool XtrT19BQ1UR5NusDuwjZ()
	{
		return bVmjL4BQP30Gi5fmJCL2 == null;
	}

	internal static ComponentMetadataItemManager Tse3mABQN7o6BcwiMqea()
	{
		return bVmjL4BQP30Gi5fmJCL2;
	}

	internal static bool Eqx94eBQapfobBrKCMjv(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}

	internal static void IOJhWpBQDOSIS5lUTHSU(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static void wnrpEfBQtTn6tQKYAxjO(object P_0)
	{
		((AbstractMetadata)P_0).InitNew();
	}

	internal static void g5BEDNBQwvBastcmvaDk(object P_0, object P_1)
	{
		((NamedMetadata)P_0).DisplayName = (string)P_1;
	}

	internal static object VtBN2rBQ4iiKJQ8RlloM(object P_0)
	{
		return ((ComponentMetadataItem)P_0).Header;
	}

	internal static object IMgWBgBQ6pRFeS1jNYRd()
	{
		return MetadataItemGroupUIManager.Instance;
	}

	internal static void XvnshbBQHTG3BKhkjfyw(object P_0, object P_1)
	{
		((ComponentMetadataItemHeader)P_0).Group = (MetadataItemGroupUI)P_1;
	}

	internal static object M0pBpEBQAGHcjWUoQWGj(object P_0)
	{
		return ComponentMetadataHelper.ServerAssemblyName((ComponentMetadata)P_0);
	}

	internal static void kItsR1BQ7o9fkG1ifvJT(object P_0, object P_1)
	{
		((ComponentMetadataItem)P_0).ScriptModule = (ScriptModule)P_1;
	}

	internal static void pBMHXqBQxm85fXuC1Jfc(object P_0, object P_1)
	{
		((ComponentMetadataItem)P_0).ClientScriptModule = (ScriptModule)P_1;
	}

	internal static object IbYRvaBQ0U45VEjSmBLN(object P_0)
	{
		return ((ComponentMetadataItem)P_0).ScriptModule;
	}

	internal static Guid uNbcViBQmqexv2WGRfgK(object P_0)
	{
		return ((ScriptModule)P_0).Uid;
	}

	internal static object XMuSrwBQy5wfVHbOLc7y(object P_0)
	{
		return ((ComponentMetadataItem)P_0).Metadata;
	}

	internal static void TvOIPWBQMX8pBNuR23RS(object P_0)
	{
		((ComponentMetadata)P_0).GenerateNewUids();
	}

	internal static object fFbiVjBQJnd1tBnhXuHX(object P_0)
	{
		return ((ComponentMetadata)P_0).Namespace;
	}

	internal static void WwqFsyBQ9QQJtuov6jos(object P_0, object P_1)
	{
		((ComponentMetadata)P_0).Namespace = (string)P_1;
	}

	internal static void J1UK0ABQdJust4Z7Vecy(object P_0, object P_1)
	{
		((NamedMetadata)P_0).Name = (string)P_1;
	}

	internal static object lKmpFJBQlV1EHesxGkNV(object P_0, object P_1, object P_2)
	{
		return string.Format((string)P_0, P_1, P_2);
	}

	internal static object iDnnkuBQrEFk0lyx9loB(object P_0)
	{
		return ((ComponentMetadataItemHeader)P_0).Group;
	}

	internal static object YStk1QBQgZg6TIPsc448(object P_0)
	{
		return ((NamedMetadata)P_0).Name;
	}

	internal static object v5UAQ0BQ5OMsrpaiukp4(object P_0)
	{
		return ((ComponentMetadataItem)P_0).ClientScriptModule;
	}

	internal static object DVvZu8BQjP53pVIoyZtR(object P_0)
	{
		return ((ComponentMetadataItem)P_0).ViewScriptModule;
	}

	internal static void sZd8aVBQYegI5tqZ2924(object P_0, object P_1)
	{
		((ComponentMetadataItem)P_0).ViewScriptModule = (ScriptModule)P_1;
	}

	internal static object mMduoxBQLtliXUYCW7u0(object P_0)
	{
		return ((ComponentMetadataItem)P_0).TestScriptModule;
	}

	internal static object r2oKIBBQUNcalQ6uItoW(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static ActionCheckResult yM4EiBBQskcALLCMg2l1(object P_0)
	{
		return ActionCheckResult.False((string)P_0);
	}

	internal static ActionCheckResult APUdbwBQcnKvr2ekVmtV()
	{
		return ActionCheckResult.True;
	}

	internal static object suAVK0BQz9Xm24vYTLc7(object P_0)
	{
		return ((NamedMetadata)P_0).DisplayName;
	}

	internal static Guid d8AHZHBCFPl7Eg1y1LXP(object P_0)
	{
		return ((ComponentMetadataItemHeader)P_0).Uid;
	}

	internal static object H3gqofBCBVWjFGYKJ5nv(object P_0)
	{
		return ((ComponentMetadataItemHeader)P_0).Draft;
	}

	internal static void FlghJNBCWrDK8ykLCkPx(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static object zXF2lRBCoIZyU1oFEb9w(object P_0)
	{
		return ((EntityManager<ComponentMetadataItem, long>)P_0).AuthenticationService;
	}

	internal static object IS0GuvBCbsK2sFxBrWXl(object P_0)
	{
		return ((IAuthenticationService)P_0).GetCurrentUser();
	}

	internal static object AOxJvMBChdGS62gOpntK(object P_0)
	{
		return ((IIdentified)P_0).GetId();
	}

	internal static DateTime nh1jBKBCGHLqUF4n7RmJ()
	{
		return DateTime.Now;
	}

	internal static void JBIBWFBCEsDpUIT68mYb(object P_0, DateTime value)
	{
		((ComponentMetadataItem)P_0).CreationDate = value;
	}

	internal static object fadx3GBCfXp7vAFTdGCN(object P_0)
	{
		return ((ScriptModule)P_0).SourceCode;
	}

	internal static object mpRFprBCQQt3kJrY4VgV(object P_0)
	{
		return ((ScriptModule)P_0).AssemblyName;
	}

	internal static void euIuCxBCCWHsdCYppDDE(object P_0, object P_1)
	{
		((ComponentMetadataItem)P_0).TestScriptModule = (ScriptModule)P_1;
	}

	internal static object aGRif2BCv8j9Fr4innI3(object P_0, object P_1, Guid groupUid, object P_3)
	{
		return ((ComponentMetadataItemManager)P_0).Create((ComponentMetadata)P_1, groupUid, (string)P_3);
	}

	internal static void APhxmnBC80ordJpdwHCl(object P_0, object P_1)
	{
		((ComponentMetadataItem)P_0).Metadata = P_1;
	}

	internal static Guid Qta7asBCZCEDJSBxonwD(object P_0)
	{
		return ((AbstractMetadata)P_0).Uid;
	}

	internal static void GURoKoBCuk6wyY4cGjlf(object P_0, Guid value)
	{
		((ComponentMetadataItemHeader)P_0).Uid = value;
	}

	internal static void jbsx2QBCIiDUSYeDyL5v(object P_0, object P_1)
	{
		((ComponentMetadataItemHeader)P_0).Name = (string)P_1;
	}

	internal static void Hk3Pb7BCVAV3STNYVfFv(object P_0, object P_1)
	{
		((ComponentMetadataItemHeader)P_0).DisplayName = (string)P_1;
	}

	internal static object VLQMBOBCSy2I0wga3ICU(object P_0)
	{
		return ((NamedMetadata)P_0).Description;
	}

	internal static void raEnifBCib5sjoK3bsmb(object P_0, Guid value)
	{
		((ComponentMetadataItemHeader)P_0).ModuleUid = value;
	}

	internal static DateTime op8kR1BCRdbI28SB8IvU(object P_0)
	{
		return ((ComponentMetadataItem)P_0).CreationDate;
	}

	internal static void Kvi5xgBCqofeORBuXPAY(object P_0, object P_1)
	{
		((ComponentMetadataItemHeader)P_0).Draft = (ComponentMetadataItem)P_1;
	}

	internal static Guid NkR9WMBCKNMZktyO5WWf(object P_0)
	{
		return ((ComponentMetadata)P_0).GetMetadataTypeUid();
	}

	internal static void TgS3knBCXFR94Ook0xAS(object P_0, Guid value)
	{
		((ComponentMetadataItemHeader)P_0).MetadataTypeUid = value;
	}

	internal static void o2eSCZBCTDXHE60HueUc(object P_0, object P_1)
	{
		((ComponentMetadataItem)P_0).Header = (ComponentMetadataItemHeader)P_1;
	}

	internal static void e24Pk9BCk4TJKOgGUhet(object P_0, object P_1)
	{
		((ScriptModule)P_0).ClassName = (string)P_1;
	}

	internal static void YxGhC9BCnWpcpgM2T0b3(object P_0, object P_1)
	{
		((ScriptModule)P_0).ModuleName = (string)P_1;
	}

	internal static void znONuNBCO7isWkYOKQAb(object P_0, object P_1)
	{
		((ScriptModule)P_0).AssemblyName = (string)P_1;
	}

	internal static void wrZcTkBC2SlMpCkukmhi(object P_0, Guid value)
	{
		((ScriptModule)P_0).ModuleTypeUid = value;
	}

	internal static void GMoFx4BCeD0GDyCEtvMh(object P_0, object P_1)
	{
		((ScriptModule)P_0).SourceCode = (string)P_1;
	}

	internal static void TnKhA0BCPLxjGtCXqrVE(object P_0, object P_1)
	{
		((ScriptModule)P_0).References = (string)P_1;
	}

	internal static void QNIMFGBC1K0Tp3sMNInH(object P_0, object P_1)
	{
		((ScriptModule)P_0).Namespace = (string)P_1;
	}

	internal static object T889fsBCNqPXytji7JU3(object P_0, object P_1)
	{
		return ((string)P_0).Split((char[])P_1);
	}

	internal static object CcMvRcBC3KHcOHF26eN9(object P_0, object P_1, object P_2)
	{
		return ((string)P_0).Replace((string)P_1, (string)P_2);
	}

	internal static object ksD7jWBCp8r5fuBqNysR(object P_0, object P_1, StringSplitOptions P_2)
	{
		return ((string)P_0).Split((string[])P_1, P_2);
	}

	internal static object ASlj9iBCa2nLDsN2pdoN(object P_0, object P_1, object P_2, object P_3)
	{
		return (string)P_0 + (string)P_1 + (string)P_2 + (string)P_3;
	}

	internal static bool A4481xBCDXthGmCfuxLd(object P_0, object P_1)
	{
		return ((string)P_0).Contains((string)P_1);
	}

	internal static int GX6YqvBCtnEGuR8h0GtD(object P_0, char P_1)
	{
		return ((string)P_0).IndexOf(P_1);
	}

	internal static object Fu9mkQBCww0hm02gkFqu(object P_0, int P_1)
	{
		return ((string)P_0).Substring(P_1);
	}

	internal static bool EFxr7MBC4er12ltS5Z8R(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static object dYAHpyBC6FYecChjI66W(object P_0, object P_1, object P_2)
	{
		return (string)P_0 + (string)P_1 + (string)P_2;
	}

	internal static object Wiw0o3BCHR7kbspqWTJa(object P_0)
	{
		return string.Concat((string[])P_0);
	}

	internal static int c6DObPBCAuWF9rQH0YXh(object P_0)
	{
		return ((List<string>)P_0).Count;
	}

	internal static object QcvD7KBC74OTqSu61cGl(object P_0, object P_1)
	{
		return string.Format((string)P_0, P_1);
	}

	internal static object ncKfqQBCx2WMM7NcAgBh(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static object KIQXKOBC0AhPW0H3UL8C(object P_0, object P_1, object P_2, object P_3)
	{
		return ((IScriptService)P_0).ChangeSourceClassName((string)P_1, (string)P_2, (string)P_3);
	}

	internal static Guid h5HobCBCm0JMY1TD3hgo(object P_0)
	{
		return ((PropertyViewItem)P_0).PropertyUid;
	}

	internal static bool LkSZQtBCyq3H7sE9g6R9(Type P_0, Type P_1)
	{
		return P_0 != P_1;
	}

	internal static object DbW3sgBCMqWLYotJtJKl(object P_0)
	{
		return ((PropertyViewItem)P_0).Attributes;
	}

	internal static object jL2fH6BCJpxfwYNMgcOl(object P_0, Type entityType, object P_2, object P_3)
	{
		return ((IEntityFilterProvider)P_0).GetFilterProviderData(entityType, (PropertyMetadata)P_2, (ViewAttributes)P_3);
	}

	internal static object nvZPlcBC9QZwYN5Taakx(object P_0, object P_1, Type entityType, object P_3, object P_4)
	{
		return ((IEntityInstanceFilterProvider)P_0).GetFilterProviderData((IEntity)P_1, entityType, (PropertyMetadata)P_3, (ViewAttributes)P_4);
	}

	internal static Guid f04e0yBCdY41miBwZbhO(object P_0)
	{
		return ((IEntityFilterProvider)P_0).ProviderUid;
	}

	internal static void GkOCpuBCl0TiZdHsTt5N(object P_0, Guid value)
	{
		((ViewAttributes)P_0).EntityFilterProvider = value;
	}

	internal static void C3O8HTBCrnnamx5JcMGO(object P_0, object P_1)
	{
		((ViewAttributes)P_0).EntityFilterData = (string)P_1;
	}

	internal static bool cNGsrMBCgu2jSn3TeFOm(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}
}
