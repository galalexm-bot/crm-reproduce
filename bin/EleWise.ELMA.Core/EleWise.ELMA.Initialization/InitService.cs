using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using EleWise.ELMA.Api.Models;
using EleWise.ELMA.Api.Services.Internal;
using EleWise.ELMA.Cache;
using EleWise.ELMA.Core.Abstractions.Metadata.Models;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Metadata;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.UI;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.Core.Engine.Init.Services.Abstractions;
using EleWise.ELMA.Core.Engine.Init.Services.Implementations;
using EleWise.ELMA.Core.Engine.Metadata.Services.Abstractions;
using EleWise.ELMA.Core.Engine.Models;
using EleWise.ELMA.Core.Engine.Proxy;
using EleWise.ELMA.Core.Engine.Storage.Abstractions;
using EleWise.ELMA.Core.Services;
using EleWise.ELMA.DTO;
using EleWise.ELMA.Model;
using EleWise.ELMA.Model.Metadata.DTO.Managers;
using EleWise.ELMA.Scripts;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Initialization;

[Service]
internal sealed class InitService : IInitService
{
	private sealed class _003C_003Ec__DisplayClass11_0
	{
		public SystemMetadata generatedItem;

		internal bool _003CInit_003Eb__2(ItemRuntimeModelDto i)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0011: Unknown result type (might be due to invalid IL or missing references)
			return i.HeaderUid == ((IMetadata)generatedItem.get_ModuleMetadata()).get_Uid();
		}
	}

	private sealed class _003C_003Ec__DisplayClass11_1
	{
		public Guid headerUid;

		public ModuleMetadataItem systemItem;

		public InitService _003C_003E4__this;

		internal bool _003CInit_003Eb__3(SystemMetadata a)
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			return ((IMetadata)a.get_ModuleMetadata()).get_ModuleUid() == headerUid;
		}

		internal void _003CInit_003Eb__4()
		{
			_003C_003E4__this.moduleMetadataItemManager.RegisterItem(systemItem, isLoadedScript: true);
		}
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();

		public static Func<ItemRuntimeModelDto, Guid> _003C_003E9__11_0;

		public static Func<SystemMetadata, ModuleInfoMetadata> _003C_003E9__11_1;

		internal Guid _003CInit_003Eb__11_0(ItemRuntimeModelDto i)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return i.ItemUid;
		}

		internal ModuleInfoMetadata _003CInit_003Eb__11_1(SystemMetadata a)
		{
			return a.get_ModuleMetadata();
		}
	}

	[StructLayout(3)]
	private struct _003CInit_003Ed__11 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public InitService _003C_003E4__this;

		private SystemInitData _003CsystemInitData_003E5__2;

		private List<Guid> _003CitemGuids_003E5__3;

		private System.Threading.Tasks.Task<SystemMetadata[]> _003CcacheTask_003E5__4;

		private SystemMetadata[] _003Cgenerated_003E5__5;

		private object _003C_003Eu__1;

		private void MoveNext()
		{
			//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
			//IL_01bd: Unknown result type (might be due to invalid IL or missing references)
			//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
			//IL_02f7: Unknown result type (might be due to invalid IL or missing references)
			//IL_02fc: Unknown result type (might be due to invalid IL or missing references)
			//IL_030b: Unknown result type (might be due to invalid IL or missing references)
			//IL_039b: Unknown result type (might be due to invalid IL or missing references)
			//IL_03fc: Unknown result type (might be due to invalid IL or missing references)
			//IL_0401: Unknown result type (might be due to invalid IL or missing references)
			//IL_045a: Unknown result type (might be due to invalid IL or missing references)
			//IL_046d: Unknown result type (might be due to invalid IL or missing references)
			//IL_04c7: Unknown result type (might be due to invalid IL or missing references)
			//IL_04d1: Expected O, but got Unknown
			int num = _003C_003E1__state;
			InitService initService = _003C_003E4__this;
			try
			{
				TaskAwaiter<SystemInitData> val4;
				TaskAwaiter<System.Collections.Generic.IEnumerable<Guid>> val3;
				TaskAwaiter<object[]> val2;
				TaskAwaiter<SystemMetadata[]> val;
				SystemMetadata[] result;
				SystemInitData systemInitData;
				System.Collections.Generic.IEnumerable<Guid> result2;
				Guid[] array;
				System.Collections.Generic.IEnumerator<Guid> enumerator;
				object[] result3;
				SystemMetadata[] array2;
				switch (num)
				{
				default:
					if (!initService.inited)
					{
						InitDataModel initDataModel = new InitDataModel
						{
							Modules = SystemModules
						};
						val4 = initService.systemMetadataService.GetSystemInitData(initDataModel).GetAwaiter();
						if (!val4.get_IsCompleted())
						{
							num = (_003C_003E1__state = 0);
							_003C_003Eu__1 = val4;
							((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitOnCompleted<TaskAwaiter<SystemInitData>, _003CInit_003Ed__11>(ref val4, ref this);
							return;
						}
						goto IL_009f;
					}
					goto end_IL_000e;
				case 0:
					val4 = (TaskAwaiter<SystemInitData>)_003C_003Eu__1;
					_003C_003Eu__1 = null;
					num = (_003C_003E1__state = -1);
					goto IL_009f;
				case 1:
					val3 = (TaskAwaiter<System.Collections.Generic.IEnumerable<Guid>>)_003C_003Eu__1;
					_003C_003Eu__1 = null;
					num = (_003C_003E1__state = -1);
					goto IL_0183;
				case 2:
					val2 = (TaskAwaiter<object[]>)_003C_003Eu__1;
					_003C_003Eu__1 = null;
					num = (_003C_003E1__state = -1);
					goto IL_0293;
				case 3:
					{
						val = (TaskAwaiter<SystemMetadata[]>)_003C_003Eu__1;
						_003C_003Eu__1 = null;
						num = (_003C_003E1__state = -1);
						goto IL_037f;
					}
					IL_020f:
					_003Cgenerated_003E5__5 = (SystemMetadata[])(object)new SystemMetadata[0];
					if (_003CitemGuids_003E5__3.get_Count() > 0)
					{
						val2 = initService.systemMetadataService.GetSystemMetadata(_003CitemGuids_003E5__3.ToArray()).GetAwaiter();
						if (!val2.get_IsCompleted())
						{
							num = (_003C_003E1__state = 2);
							_003C_003Eu__1 = val2;
							((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitOnCompleted<TaskAwaiter<object[]>, _003CInit_003Ed__11>(ref val2, ref this);
							return;
						}
						goto IL_0293;
					}
					goto IL_0320;
					IL_037f:
					result = val.GetResult();
					ArrayExtensions.Push<SystemMetadata>(_003Cgenerated_003E5__5, result);
					break;
					IL_009f:
					systemInitData = (_003CsystemInitData_003E5__2 = val4.GetResult());
					if (_003CsystemInitData_003E5__2 != null)
					{
						initService.findComponentService.RegisterSystemModule(_003CsystemInitData_003E5__2.ItemRuntimeModels);
						_003CitemGuids_003E5__3 = Enumerable.Select<ItemRuntimeModelDto, Guid>((System.Collections.Generic.IEnumerable<ItemRuntimeModelDto>)_003CsystemInitData_003E5__2.ItemRuntimeModels, (Func<ItemRuntimeModelDto, Guid>)((ItemRuntimeModelDto i) => i.ItemUid)).ToList();
						bool num2 = initService.applicationData.InterfaceBuilderMode == InterfaceBuilderMode.DevServer;
						_003CcacheTask_003E5__4 = null;
						if (!num2)
						{
							val3 = initService.systemModuleMetadataCacheService.GetCachedModuleUids().GetAwaiter();
							if (!val3.get_IsCompleted())
							{
								num = (_003C_003E1__state = 1);
								_003C_003Eu__1 = val3;
								((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitOnCompleted<TaskAwaiter<System.Collections.Generic.IEnumerable<Guid>>, _003CInit_003Ed__11>(ref val3, ref this);
								return;
							}
							goto IL_0183;
						}
						goto IL_020f;
					}
					goto end_IL_000e;
					IL_0183:
					result2 = val3.GetResult();
					array = (Guid[])(object)new Guid[0];
					enumerator = result2.GetEnumerator();
					try
					{
						while (((System.Collections.IEnumerator)enumerator).MoveNext())
						{
							Guid current = enumerator.get_Current();
							if (_003CitemGuids_003E5__3.Contains(current))
							{
								_003CitemGuids_003E5__3.Remove(current);
								ArrayExtensions.Push<Guid>(array, (Guid[])(object)new Guid[1] { current });
							}
						}
					}
					finally
					{
						if (num < 0)
						{
							((System.IDisposable)enumerator)?.Dispose();
						}
					}
					if (array.Length != 0)
					{
						_003CcacheTask_003E5__4 = initService.LoadRuntimeCachedModules(array, _003CsystemInitData_003E5__2);
					}
					goto IL_020f;
					IL_0293:
					result3 = val2.GetResult();
					_003Cgenerated_003E5__5 = initService.engineInitService.Init((System.Collections.Generic.IEnumerable<MetadataReference>)_003CsystemInitData_003E5__2.MetadataReferences, result3);
					array2 = _003Cgenerated_003E5__5;
					for (int j = 0; j < array2.Length; j++)
					{
						_003C_003Ec__DisplayClass11_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass11_0();
						CS_0024_003C_003E8__locals0.generatedItem = array2[j];
						Guid itemUid = Enumerable.First<ItemRuntimeModelDto>((System.Collections.Generic.IEnumerable<ItemRuntimeModelDto>)_003CsystemInitData_003E5__2.ItemRuntimeModels, (Func<ItemRuntimeModelDto, bool>)((ItemRuntimeModelDto i) => i.HeaderUid == ((IMetadata)CS_0024_003C_003E8__locals0.generatedItem.get_ModuleMetadata()).get_Uid())).ItemUid;
						initService.systemModuleMetadataCacheService.Cache(CS_0024_003C_003E8__locals0.generatedItem, itemUid);
					}
					goto IL_0320;
					IL_0320:
					if (_003CcacheTask_003E5__4 == null)
					{
						break;
					}
					val = _003CcacheTask_003E5__4.GetAwaiter();
					if (!val.get_IsCompleted())
					{
						num = (_003C_003E1__state = 3);
						_003C_003Eu__1 = val;
						((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitOnCompleted<TaskAwaiter<SystemMetadata[]>, _003CInit_003Ed__11>(ref val, ref this);
						return;
					}
					goto IL_037f;
				}
				initService.metadataService.RegisterSystemMetadata(Guid.Empty, (System.Collections.Generic.IEnumerable<IMetadata>)Enumerable.Select<SystemMetadata, ModuleInfoMetadata>((System.Collections.Generic.IEnumerable<SystemMetadata>)_003Cgenerated_003E5__5, (Func<SystemMetadata, ModuleInfoMetadata>)((SystemMetadata a) => a.get_ModuleMetadata())));
				ItemRuntimeModelDto[] itemRuntimeModels = _003CsystemInitData_003E5__2.ItemRuntimeModels;
				for (int k = 0; k < itemRuntimeModels.Length; k++)
				{
					_003C_003Ec__DisplayClass11_1 CS_0024_003C_003E8__locals1 = new _003C_003Ec__DisplayClass11_1();
					CS_0024_003C_003E8__locals1._003C_003E4__this = initService;
					ItemRuntimeModelDto itemRuntimeModelDto = itemRuntimeModels[k];
					CS_0024_003C_003E8__locals1.headerUid = itemRuntimeModelDto.HeaderUid;
					SystemMetadata val5 = Enumerable.FirstOrDefault<SystemMetadata>((System.Collections.Generic.IEnumerable<SystemMetadata>)_003Cgenerated_003E5__5, (Func<SystemMetadata, bool>)((SystemMetadata a) => ((IMetadata)a.get_ModuleMetadata()).get_ModuleUid() == CS_0024_003C_003E8__locals1.headerUid));
					if (val5 == null)
					{
						continue;
					}
					ModuleInfoMetadata moduleMetadata = val5.get_ModuleMetadata();
					if (moduleMetadata == null)
					{
						continue;
					}
					CS_0024_003C_003E8__locals1.systemItem = InterfaceCreator.Create<ModuleMetadataItem>();
					CS_0024_003C_003E8__locals1.systemItem.set_Metadata(moduleMetadata);
					CS_0024_003C_003E8__locals1.systemItem.set_Uid(itemRuntimeModelDto.ItemUid);
					CS_0024_003C_003E8__locals1.systemItem.set_Header_Uid(itemRuntimeModelDto.HeaderUid);
					ClientScriptModel script = val5.get_Script();
					if (script == null)
					{
						initService.moduleMetadataItemManager.RegisterItem(CS_0024_003C_003E8__locals1.systemItem, isLoadedScript: true);
						continue;
					}
					string assemblyName = script.get_AssemblyName();
					CS_0024_003C_003E8__locals1.systemItem.set_AssemblyName(assemblyName);
					initService.scriptLoaderService.ApplyScript(assemblyName, script.get_SourceCode(), (Action)delegate
					{
						CS_0024_003C_003E8__locals1._003C_003E4__this.moduleMetadataItemManager.RegisterItem(CS_0024_003C_003E8__locals1.systemItem, isLoadedScript: true);
					});
				}
				initService.inited = true;
				end_IL_000e:;
			}
			catch (System.Exception exception)
			{
				_003C_003E1__state = -2;
				((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).SetResult();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).SetStateMachine(stateMachine);
		}
	}

	[StructLayout(3)]
	private struct _003CLoadRuntimeCachedModules_003Ed__12 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<SystemMetadata[]> _003C_003Et__builder;

		public InitService _003C_003E4__this;

		public System.Collections.Generic.IEnumerable<Guid> guidsToLoad;

		public SystemInitData systemInitData;

		private object _003C_003Eu__1;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			InitService initService = _003C_003E4__this;
			SystemMetadata[] result2;
			try
			{
				TaskAwaiter<object[]> val;
				if (num != 0)
				{
					val = initService.systemModuleMetadataCacheService.GetSerializedModules(guidsToLoad).GetAwaiter();
					if (!val.get_IsCompleted())
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = val;
						_003C_003Et__builder.AwaitOnCompleted<TaskAwaiter<object[]>, _003CLoadRuntimeCachedModules_003Ed__12>(ref val, ref this);
						return;
					}
				}
				else
				{
					val = (TaskAwaiter<object[]>)_003C_003Eu__1;
					_003C_003Eu__1 = null;
					num = (_003C_003E1__state = -1);
				}
				object[] result = val.GetResult();
				result2 = initService.engineInitService.Init((System.Collections.Generic.IEnumerable<MetadataReference>)systemInitData.MetadataReferences, result);
			}
			catch (System.Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003C_003Et__builder.SetResult(result2);
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			_003C_003Et__builder.SetStateMachine(stateMachine);
		}
	}

	private static readonly Guid[] SystemModules = (Guid[])(object)new Guid[11]
	{
		new Guid("4472D551-AE16-4316-9250-33E7FA1B090C"),
		new Guid("8A5E484F-D148-43CD-837F-AD4FA789F6B4"),
		new Guid("E7B4EF46-E891-423D-AC54-9653F0849892"),
		new Guid("ca89e936-cd0b-4dd2-b7bc-1b697365c60d"),
		new Guid("dc5c9a36-66cd-4922-95ce-49a19403b61c"),
		new Guid("f17e2f78-09d0-4f31-8a02-5c6818ad2645"),
		new Guid("93f667ab-d65c-4557-8b82-58ba1e76ce6c"),
		new Guid("a92ff97b-b73e-4a9b-8ddb-eb824b88140d"),
		new Guid("1e908624-375a-4c19-9a17-08d9efb3beb1"),
		new Guid("28abc7f0-1974-4835-a0d1-bc794080e874"),
		new Guid("06396cfa-59f3-4b4c-bad3-3d64346f52ec")
	};

	private bool inited;

	private readonly ISystemMetadataService systemMetadataService;

	private readonly ModuleMetadataItemManager moduleMetadataItemManager;

	private readonly IFindComponentService findComponentService;

	private readonly MetadataService metadataService;

	private readonly IScriptLoaderService scriptLoaderService;

	private readonly IApplicationData applicationData;

	private readonly ISystemModuleMetadataCacheService systemModuleMetadataCacheService;

	private readonly IInitService engineInitService;

	public InitService(ISystemMetadataService systemMetadataService, ISystemProxyGeneratorService systemProxyGeneratorService, ISystemProxyMetadataReferencesStorage systemProxyMetadataReferencesStorage, IMetadataReferenceStorage systemMetadataTypeReferenceStorage, ModuleMetadataItemManager moduleMetadataItemManager, IFindComponentService findComponentService, MetadataService metadataService, ProxyGeneratorService proxyGeneratorService, IScriptLoaderService scriptLoaderService, IApplicationData applicationData, ISystemModuleMetadataCacheService systemModuleMetadataCacheService)
	{
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		this.systemMetadataService = systemMetadataService;
		this.moduleMetadataItemManager = moduleMetadataItemManager;
		this.findComponentService = findComponentService;
		this.metadataService = metadataService;
		this.scriptLoaderService = scriptLoaderService;
		this.applicationData = applicationData;
		this.systemModuleMetadataCacheService = systemModuleMetadataCacheService;
		InterfaceCreator.SetServices(systemProxyMetadataReferencesStorage, proxyGeneratorService);
		engineInitService = (IInitService)new InitService((ISystemMetadataProxyGenerator)systemProxyGeneratorService, (ISystemMetadataReferencesStorage)systemProxyMetadataReferencesStorage, (ISystemMetadataTypeReferenceStorage)systemMetadataTypeReferenceStorage);
	}

	public System.Threading.Tasks.Task Init()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		_003CInit_003Ed__11 _003CInit_003Ed__ = default(_003CInit_003Ed__11);
		_003CInit_003Ed__._003C_003E4__this = this;
		_003CInit_003Ed__._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		_003CInit_003Ed__._003C_003E1__state = -1;
		AsyncTaskMethodBuilder _003C_003Et__builder = _003CInit_003Ed__._003C_003Et__builder;
		((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).Start<_003CInit_003Ed__11>(ref _003CInit_003Ed__);
		return ((AsyncTaskMethodBuilder)(ref _003CInit_003Ed__._003C_003Et__builder)).get_Task();
	}

	private System.Threading.Tasks.Task<SystemMetadata[]> LoadRuntimeCachedModules(System.Collections.Generic.IEnumerable<Guid> guidsToLoad, SystemInitData systemInitData)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		_003CLoadRuntimeCachedModules_003Ed__12 _003CLoadRuntimeCachedModules_003Ed__ = default(_003CLoadRuntimeCachedModules_003Ed__12);
		_003CLoadRuntimeCachedModules_003Ed__._003C_003E4__this = this;
		_003CLoadRuntimeCachedModules_003Ed__.guidsToLoad = guidsToLoad;
		_003CLoadRuntimeCachedModules_003Ed__.systemInitData = systemInitData;
		_003CLoadRuntimeCachedModules_003Ed__._003C_003Et__builder = AsyncTaskMethodBuilder<SystemMetadata[]>.Create();
		_003CLoadRuntimeCachedModules_003Ed__._003C_003E1__state = -1;
		AsyncTaskMethodBuilder<SystemMetadata[]> _003C_003Et__builder = _003CLoadRuntimeCachedModules_003Ed__._003C_003Et__builder;
		_003C_003Et__builder.Start<_003CLoadRuntimeCachedModules_003Ed__12>(ref _003CLoadRuntimeCachedModules_003Ed__);
		return _003CLoadRuntimeCachedModules_003Ed__._003C_003Et__builder.get_Task();
	}
}
