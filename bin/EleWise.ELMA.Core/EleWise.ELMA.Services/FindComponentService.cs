using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using EleWise.ELMA.Api.Models;
using EleWise.ELMA.Api.Services;
using EleWise.ELMA.Cache;
using EleWise.ELMA.Cache.Models;
using EleWise.ELMA.Core;
using EleWise.ELMA.Core.Abstractions.Metadata.Models;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Dependencies;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Metadata;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Signatures;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.UI;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.UI.Metadata;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.UI.Models;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.Core.Logging;
using EleWise.ELMA.Core.Services;
using EleWise.ELMA.DTO;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Metadata.DTO.Managers;
using EleWise.ELMA.Scripts;
using EleWise.ELMA.UI.Managers;

namespace EleWise.ELMA.Services;

[Service]
internal sealed class FindComponentService : IFindComponentService
{
	private class RequestComponentModel
	{
		private readonly System.Collections.Generic.ICollection<Guid> _003CLoadingModules_003Ek__BackingField;

		private readonly System.Collections.Generic.ICollection<Guid> _003CLoadingComponents_003Ek__BackingField;

		private readonly System.Collections.Generic.ICollection<Guid> _003CLoadingDataClasses_003Ek__BackingField;

		internal System.Collections.Generic.ICollection<Guid> LoadingModules => _003CLoadingModules_003Ek__BackingField;

		internal System.Collections.Generic.ICollection<Guid> LoadingComponents => _003CLoadingComponents_003Ek__BackingField;

		internal System.Collections.Generic.ICollection<Guid> LoadingDataClasses => _003CLoadingDataClasses_003Ek__BackingField;

		public RequestComponentModel()
		{
			_003CLoadingModules_003Ek__BackingField = (System.Collections.Generic.ICollection<Guid>)new Collection<Guid>();
			_003CLoadingComponents_003Ek__BackingField = (System.Collections.Generic.ICollection<Guid>)new Collection<Guid>();
			_003CLoadingDataClasses_003Ek__BackingField = (System.Collections.Generic.ICollection<Guid>)new Collection<Guid>();
		}
	}

	[StructLayout(3)]
	private struct _003CFindComponent_003Ed__18 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<RenderComponentModel> _003C_003Et__builder;

		public FindComponentService _003C_003E4__this;

		public Guid headerUid;

		public InterfaceBuilderViewMode viewMode;

		private RecursiveComponentModelDto _003CrecursiveModelDto_003E5__2;

		private RecursiveComponentModel _003CrecursiveModel_003E5__3;

		private object _003C_003Eu__1;

		private void MoveNext()
		{
			//IL_0027: Unknown result type (might be due to invalid IL or missing references)
			//IL_0155: Unknown result type (might be due to invalid IL or missing references)
			//IL_015a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0173: Unknown result type (might be due to invalid IL or missing references)
			//IL_0233: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			FindComponentService findComponentService = _003C_003E4__this;
			RenderComponentModel result;
			try
			{
				TaskAwaiter<RecursiveComponentModelDto> val3;
				TaskAwaiter<ComponentMetadataItem> val2;
				TaskAwaiter<LoadComponentScriptsResult> val;
				EnumerableInstance<Guid> metadataUids;
				RecursiveComponentModelDto recursiveComponentModelDto;
				ComponentMetadataItem result2;
				ClientComponentModelDto header;
				switch (num)
				{
				default:
					val3 = findComponentService.componentMetadataService.FindComponent(headerUid, viewMode).GetAwaiter();
					if (!val3.get_IsCompleted())
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = val3;
						_003C_003Et__builder.AwaitOnCompleted<TaskAwaiter<RecursiveComponentModelDto>, _003CFindComponent_003Ed__18>(ref val3, ref this);
						return;
					}
					goto IL_0088;
				case 0:
					val3 = (TaskAwaiter<RecursiveComponentModelDto>)_003C_003Eu__1;
					_003C_003Eu__1 = null;
					num = (_003C_003E1__state = -1);
					goto IL_0088;
				case 1:
					val2 = (TaskAwaiter<ComponentMetadataItem>)_003C_003Eu__1;
					_003C_003Eu__1 = null;
					num = (_003C_003E1__state = -1);
					goto IL_01ce;
				case 2:
					{
						val = (TaskAwaiter<LoadComponentScriptsResult>)_003C_003Eu__1;
						_003C_003Eu__1 = null;
						num = (_003C_003E1__state = -1);
						break;
					}
					IL_0276:
					_003CrecursiveModel_003E5__3 = MapRecursiveComponentModelFromDto(_003CrecursiveModelDto_003E5__2);
					metadataUids = Enumerable.Concat<Guid>((System.Collections.Generic.IEnumerable<Guid>)_003CrecursiveModelDto_003E5__2.EntityMetadataUids, (System.Collections.Generic.IEnumerable<Guid>)_003CrecursiveModelDto_003E5__2.EnumMetadataUids);
					val = findComponentService.LoadComponent(_003CrecursiveModel_003E5__3, (System.Collections.Generic.IEnumerable<Guid>)metadataUids).GetAwaiter();
					if (!val.get_IsCompleted())
					{
						num = (_003C_003E1__state = 2);
						_003C_003Eu__1 = val;
						_003C_003Et__builder.AwaitOnCompleted<TaskAwaiter<LoadComponentScriptsResult>, _003CFindComponent_003Ed__18>(ref val, ref this);
						return;
					}
					break;
					IL_0088:
					recursiveComponentModelDto = (_003CrecursiveModelDto_003E5__2 = val3.GetResult());
					if (_003CrecursiveModelDto_003E5__2 != null)
					{
						string[] errors = _003CrecursiveModelDto_003E5__2.Errors;
						if (errors != null && errors.Length != 0)
						{
							string text = "";
							string[] array = errors;
							foreach (string text2 in array)
							{
								text += Environment.get_NewLine();
								text += text2;
								text += Environment.get_NewLine();
								findComponentService.logger.Error(text2);
							}
							findComponentService.notificationService.Error(SR.T("Ошибка при поиске версии компонента"), text, autoClosed: false);
							throw new System.Exception(SR.T("Не найден компонент подходящей версии"));
						}
						if (viewMode == InterfaceBuilderViewMode.Design && _003CrecursiveModelDto_003E5__2.Header.ModuleItemUid != Guid.Empty)
						{
							val2 = findComponentService.componentMetadataItemManager.LoadDraftByHeaderUid(headerUid).GetAwaiter();
							if (!val2.get_IsCompleted())
							{
								num = (_003C_003E1__state = 1);
								_003C_003Eu__1 = val2;
								_003C_003Et__builder.AwaitOnCompleted<TaskAwaiter<ComponentMetadataItem>, _003CFindComponent_003Ed__18>(ref val2, ref this);
								return;
							}
							goto IL_01ce;
						}
						goto IL_0276;
					}
					result = null;
					goto end_IL_000e;
					IL_01ce:
					result2 = val2.GetResult();
					findComponentService.ComponentRegister(result2);
					header = _003CrecursiveModelDto_003E5__2.Header;
					if (_003CrecursiveModelDto_003E5__2.ComponentCache == null)
					{
						_003CrecursiveModelDto_003E5__2.ComponentCache = new ClientComponentModelDto[0];
					}
					ArrayExtensions.Push<ClientComponentModelDto>(_003CrecursiveModelDto_003E5__2.ComponentCache, new ClientComponentModelDto[1] { header });
					_003CrecursiveModelDto_003E5__2.Header = new ClientComponentModelDto
					{
						ItemUid = result2.get_Uid(),
						Owners = header.Owners,
						RenderUidList = header.RenderUidList,
						Functions = header.Functions,
						DataClasses = header.DataClasses
					};
					goto IL_0276;
				}
				LoadComponentScriptsResult result3 = val.GetResult();
				RenderComponentModel renderComponentModel = new RenderComponentModel(_003CrecursiveModel_003E5__3);
				DependencyHelper.UpdateDependencies(renderComponentModel.EntityDependencies, (System.Collections.Generic.IEnumerable<EntityDependency>)Enumerable.Select<EntityDependencyDto, EntityDependency>((System.Collections.Generic.IEnumerable<EntityDependencyDto>)_003CrecursiveModelDto_003E5__2.EntityDependencies, (Func<EntityDependencyDto, EntityDependency>)MapEntityDependencyFromDto));
				if (result3 != null)
				{
					DependencyHelper.UpdateDependencies(renderComponentModel.EntityDependencies, result3.EntityDependencies);
				}
				result = renderComponentModel;
				end_IL_000e:;
			}
			catch (System.Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003C_003Et__builder.SetResult(result);
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			_003C_003Et__builder.SetStateMachine(stateMachine);
		}
	}

	private sealed class _003C_003Ec__DisplayClass20_0
	{
		public ItemRuntimeModelDto i;

		internal bool _003CGetCurrentRuntimeModel_003Eb__2(ItemRuntimeModelDto s)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			return s.HeaderUid != i.HeaderUid;
		}
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();

		public static Func<ModuleMetadataItem, ItemRuntimeModelDto> _003C_003E9__20_0;

		public static Func<ClientImplementationModelDto, ClientImplementationModel> _003C_003E9__35_2;

		public static Func<ClientExtensionPointModelDto, ClientExtensionPointModel> _003C_003E9__35_0;

		public static Func<CustomTypeModelDto, CustomTypeModel> _003C_003E9__35_1;

		public static Func<ClientFunctionModelDto, ClientFunctionModel> _003C_003E9__36_0;

		public static Func<ClientDataClassModelDto, ClientDataClassModel> _003C_003E9__36_1;

		internal ItemRuntimeModelDto _003CGetCurrentRuntimeModel_003Eb__20_0(ModuleMetadataItem a)
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Unknown result type (might be due to invalid IL or missing references)
			return new ItemRuntimeModelDto
			{
				ItemUid = a.get_Uid(),
				HeaderUid = a.get_Header_Uid()
			};
		}

		internal ClientExtensionPointModel _003CMapRecursiveComponentModelFromDto_003Eb__35_0(ClientExtensionPointModelDto e)
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			ClientExtensionPointModel val = InterfaceCreator.Create<ClientExtensionPointModel>();
			val.set_PointId(e.PointId);
			val.set_TypeUid(e.TypeUid);
			if (e.Implementations != null)
			{
				val.get_Implementations().AddRange((System.Collections.Generic.IEnumerable<ClientImplementationModel>)Enumerable.Select<ClientImplementationModelDto, ClientImplementationModel>((System.Collections.Generic.IEnumerable<ClientImplementationModelDto>)e.Implementations, (Func<ClientImplementationModelDto, ClientImplementationModel>)delegate(ClientImplementationModelDto i)
				{
					//IL_0007: Unknown result type (might be due to invalid IL or missing references)
					//IL_0013: Unknown result type (might be due to invalid IL or missing references)
					//IL_001f: Unknown result type (might be due to invalid IL or missing references)
					ClientImplementationModel obj = InterfaceCreator.Create<ClientImplementationModel>();
					obj.set_HeaderUid(i.HeaderUid);
					obj.set_ItemUid(i.ItemUid);
					obj.set_ModuleItemUid(i.ModuleItemUid);
					return obj;
				}));
			}
			return val;
		}

		internal ClientImplementationModel _003CMapRecursiveComponentModelFromDto_003Eb__35_2(ClientImplementationModelDto i)
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Unknown result type (might be due to invalid IL or missing references)
			//IL_001f: Unknown result type (might be due to invalid IL or missing references)
			ClientImplementationModel obj = InterfaceCreator.Create<ClientImplementationModel>();
			obj.set_HeaderUid(i.HeaderUid);
			obj.set_ItemUid(i.ItemUid);
			obj.set_ModuleItemUid(i.ModuleItemUid);
			return obj;
		}

		internal CustomTypeModel _003CMapRecursiveComponentModelFromDto_003Eb__35_1(CustomTypeModelDto e)
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0037: Unknown result type (might be due to invalid IL or missing references)
			//IL_0043: Unknown result type (might be due to invalid IL or missing references)
			CustomTypeModel obj = InterfaceCreator.Create<CustomTypeModel>();
			obj.set_TypeUid(e.TypeUid);
			obj.set_SubTypeUid(e.SubTypeUid);
			obj.set_IsCollection(e.IsCollection);
			obj.set_HeaderUid(e.HeaderUid);
			obj.set_ItemUid(e.ItemUid);
			obj.set_ModuleItemUid(e.ModuleItemUid);
			return obj;
		}

		internal ClientFunctionModel _003CMapClientComponentModelFromDto_003Eb__36_0(ClientFunctionModelDto f)
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Unknown result type (might be due to invalid IL or missing references)
			//IL_001f: Unknown result type (might be due to invalid IL or missing references)
			ClientFunctionModel obj = InterfaceCreator.Create<ClientFunctionModel>();
			obj.set_HeaderUid(f.HeaderUid);
			obj.set_ItemUid(f.ItemUid);
			obj.set_ModuleItemUid(f.ModuleItemUid);
			return obj;
		}

		internal ClientDataClassModel _003CMapClientComponentModelFromDto_003Eb__36_1(ClientDataClassModelDto f)
		{
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Unknown result type (might be due to invalid IL or missing references)
			//IL_001f: Unknown result type (might be due to invalid IL or missing references)
			ClientDataClassModel obj = InterfaceCreator.Create<ClientDataClassModel>();
			obj.set_HeaderUid(f.HeaderUid);
			obj.set_ItemUid(f.ItemUid);
			obj.set_ModuleItemUid(f.ModuleItemUid);
			return obj;
		}
	}

	private sealed class _003C_003Ec__DisplayClass21_0
	{
		public ClientComponentModel modelHeader;

		internal bool _003CLoadComponent_003Eb__0(ClientComponentModel clientComponent)
		{
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_0029: Unknown result type (might be due to invalid IL or missing references)
			//IL_003b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0048: Unknown result type (might be due to invalid IL or missing references)
			//IL_004d: Unknown result type (might be due to invalid IL or missing references)
			//IL_004e: Unknown result type (might be due to invalid IL or missing references)
			//IL_004f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0061: Unknown result type (might be due to invalid IL or missing references)
			if (clientComponent.get_Async())
			{
				return false;
			}
			if (clientComponent.get_ModuleItemUid() != Guid.Empty)
			{
				return true;
			}
			Guid val = ((modelHeader.get_ItemUid() != Guid.Empty) ? modelHeader.get_ItemUid() : modelHeader.get_ModuleItemUid());
			if (val != Guid.Empty)
			{
				return clientComponent.get_Owners().Contains(val);
			}
			return false;
		}
	}

	[StructLayout(3)]
	private struct _003CLoadRuntimeMetadataInternal_003Ed__29 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<LoadComponentScriptsResult> _003C_003Et__builder;

		public RequestComponentModel requestComponentModel;

		public bool debug;

		public FindComponentService _003C_003E4__this;

		public System.Collections.Generic.IEnumerable<Guid> metadataUids;

		private RuntimeModel _003Crequest_003E5__2;

		private object _003C_003Eu__1;

		private IMetadataUidDifference _003CdifferenceModuleMetadataUids_003E5__3;

		private IMetadataUidDifference _003CdifferenceComponentMetadataUids_003E5__4;

		private IMetadataUidDifference _003CdifferenceDataClassMetadataUids_003E5__5;

		private RuntimeResponse _003Cresponse_003E5__6;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			FindComponentService findComponentService = _003C_003E4__this;
			LoadComponentScriptsResult result3;
			try
			{
				TaskAwaiter<IMetadataUidDifference> val;
				if (num != 0)
				{
					if ((uint)(num - 1) <= 7u)
					{
						goto IL_017d;
					}
					_003Crequest_003E5__2 = InterfaceCreator.Create<RuntimeModel>();
					_003Crequest_003E5__2.set_Modules((System.Collections.Generic.ICollection<Guid>)Enumerable.Distinct<Guid>((System.Collections.Generic.IEnumerable<Guid>)requestComponentModel.LoadingModules).ToList());
					_003Crequest_003E5__2.set_Components((System.Collections.Generic.ICollection<Guid>)Enumerable.Distinct<Guid>((System.Collections.Generic.IEnumerable<Guid>)requestComponentModel.LoadingComponents).ToList());
					_003Crequest_003E5__2.set_DataClasses((System.Collections.Generic.ICollection<Guid>)Enumerable.Distinct<Guid>((System.Collections.Generic.IEnumerable<Guid>)requestComponentModel.LoadingDataClasses).ToList());
					_003Crequest_003E5__2.set_Debug(debug);
					if (findComponentService.applicationData.InterfaceBuilderMode == InterfaceBuilderMode.DevServer)
					{
						goto IL_0140;
					}
					val = findComponentService.metadataCacheService.GetDifferenceMetadataUids(metadataUids).GetAwaiter();
					if (!val.get_IsCompleted())
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = val;
						_003C_003Et__builder.AwaitOnCompleted<TaskAwaiter<IMetadataUidDifference>, _003CLoadRuntimeMetadataInternal_003Ed__29>(ref val, ref this);
						return;
					}
				}
				else
				{
					val = (TaskAwaiter<IMetadataUidDifference>)_003C_003Eu__1;
					_003C_003Eu__1 = null;
					num = (_003C_003E1__state = -1);
				}
				IMetadataUidDifference result = val.GetResult();
				_003Crequest_003E5__2.get_ExistedMetadataUids().AddRange(result.ExistUids);
				_003Crequest_003E5__2.get_MissedMetadataUids().AddRange(result.MissedGuids);
				goto IL_0140;
				IL_017d:
				try
				{
					TaskAwaiter<RuntimeResponse> val6;
					TaskAwaiter<System.Collections.Generic.IEnumerable<RuntimeModuleModel>> val5;
					TaskAwaiter<System.Collections.Generic.IEnumerable<RuntimeDataClassModel>> val4;
					TaskAwaiter<System.Collections.Generic.IEnumerable<RuntimeComponentModel>> val3;
					TaskAwaiter<System.Collections.Generic.IEnumerable<IMetadata>> val2;
					System.Collections.Generic.ICollection<RuntimeComponentModel> components;
					Guid[] missedGuids;
					System.Collections.Generic.ICollection<RuntimeModuleModel> modules;
					System.Collections.Generic.IEnumerable<RuntimeModuleModel> result2;
					System.Collections.Generic.ICollection<RuntimeDataClassModel> dataClasses;
					Guid[] missedGuids2;
					RuntimeResponse val7;
					System.Collections.Generic.IEnumerator<IMetadata> enumerator;
					IMetadataUidDifference metadataUidDifference;
					Guid[] missedGuids3;
					System.Collections.Generic.IEnumerable<RuntimeDataClassModel> result4;
					System.Collections.Generic.IEnumerable<RuntimeComponentModel> result5;
					switch (num)
					{
					default:
						val = findComponentService.moduleMetadataCacheService.GetDifferenceMetadataUids((System.Collections.Generic.IEnumerable<Guid>)_003Crequest_003E5__2.get_Modules()).GetAwaiter();
						if (!val.get_IsCompleted())
						{
							num = (_003C_003E1__state = 1);
							_003C_003Eu__1 = val;
							_003C_003Et__builder.AwaitOnCompleted<TaskAwaiter<IMetadataUidDifference>, _003CLoadRuntimeMetadataInternal_003Ed__29>(ref val, ref this);
							return;
						}
						goto IL_020d;
					case 1:
						val = (TaskAwaiter<IMetadataUidDifference>)_003C_003Eu__1;
						_003C_003Eu__1 = null;
						num = (_003C_003E1__state = -1);
						goto IL_020d;
					case 2:
						val = (TaskAwaiter<IMetadataUidDifference>)_003C_003Eu__1;
						_003C_003Eu__1 = null;
						num = (_003C_003E1__state = -1);
						goto IL_02c2;
					case 3:
						val = (TaskAwaiter<IMetadataUidDifference>)_003C_003Eu__1;
						_003C_003Eu__1 = null;
						num = (_003C_003E1__state = -1);
						goto IL_0377;
					case 4:
						val6 = (TaskAwaiter<RuntimeResponse>)_003C_003Eu__1;
						_003C_003Eu__1 = null;
						num = (_003C_003E1__state = -1);
						goto IL_0464;
					case 5:
						val5 = (TaskAwaiter<System.Collections.Generic.IEnumerable<RuntimeModuleModel>>)_003C_003Eu__1;
						_003C_003Eu__1 = null;
						num = (_003C_003E1__state = -1);
						goto IL_0506;
					case 6:
						val4 = (TaskAwaiter<System.Collections.Generic.IEnumerable<RuntimeDataClassModel>>)_003C_003Eu__1;
						_003C_003Eu__1 = null;
						num = (_003C_003E1__state = -1);
						goto IL_05b7;
					case 7:
						val3 = (TaskAwaiter<System.Collections.Generic.IEnumerable<RuntimeComponentModel>>)_003C_003Eu__1;
						_003C_003Eu__1 = null;
						num = (_003C_003E1__state = -1);
						goto IL_065f;
					case 8:
						{
							val2 = (TaskAwaiter<System.Collections.Generic.IEnumerable<IMetadata>>)_003C_003Eu__1;
							_003C_003Eu__1 = null;
							num = (_003C_003E1__state = -1);
							goto IL_0705;
						}
						IL_0670:
						components = _003Cresponse_003E5__6.get_Components();
						findComponentService.LoadRuntimeCachedComponents((System.Collections.Generic.IEnumerable<RuntimeComponentModel>)components);
						findComponentService.componentMetadataCacheService.Cache(components);
						if (findComponentService.applicationData.InterfaceBuilderMode == InterfaceBuilderMode.DevServer)
						{
							break;
						}
						val2 = findComponentService.metadataCacheService.GetFromCache(metadataUids).GetAwaiter();
						if (!val2.get_IsCompleted())
						{
							num = (_003C_003E1__state = 8);
							_003C_003Eu__1 = val2;
							_003C_003Et__builder.AwaitOnCompleted<TaskAwaiter<System.Collections.Generic.IEnumerable<IMetadata>>, _003CLoadRuntimeMetadataInternal_003Ed__29>(ref val2, ref this);
							return;
						}
						goto IL_0705;
						IL_020d:
						metadataUidDifference = (_003CdifferenceModuleMetadataUids_003E5__3 = val.GetResult());
						missedGuids = _003CdifferenceModuleMetadataUids_003E5__3.MissedGuids;
						if (findComponentService.applicationData.InterfaceBuilderMode != InterfaceBuilderMode.DevServer)
						{
							_003Crequest_003E5__2.get_Modules().Clear();
							_003Crequest_003E5__2.get_Modules().AddRange(missedGuids);
						}
						val = findComponentService.componentMetadataCacheService.GetDifferenceMetadataUids((System.Collections.Generic.IEnumerable<Guid>)_003Crequest_003E5__2.get_Components()).GetAwaiter();
						if (!val.get_IsCompleted())
						{
							num = (_003C_003E1__state = 2);
							_003C_003Eu__1 = val;
							_003C_003Et__builder.AwaitOnCompleted<TaskAwaiter<IMetadataUidDifference>, _003CLoadRuntimeMetadataInternal_003Ed__29>(ref val, ref this);
							return;
						}
						goto IL_02c2;
						IL_0517:
						modules = _003Cresponse_003E5__6.get_Modules();
						findComponentService.LoadRuntimeModules((System.Collections.Generic.IEnumerable<RuntimeModuleModel>)_003Cresponse_003E5__6.get_Modules());
						findComponentService.moduleMetadataCacheService.Cache(modules);
						if (findComponentService.applicationData.InterfaceBuilderMode != InterfaceBuilderMode.DevServer)
						{
							val4 = findComponentService.dataClassMetadataCacheService.GetFromCache(_003CdifferenceDataClassMetadataUids_003E5__5.ExistUids).GetAwaiter();
							if (!val4.get_IsCompleted())
							{
								num = (_003C_003E1__state = 6);
								_003C_003Eu__1 = val4;
								_003C_003Et__builder.AwaitOnCompleted<TaskAwaiter<System.Collections.Generic.IEnumerable<RuntimeDataClassModel>>, _003CLoadRuntimeMetadataInternal_003Ed__29>(ref val4, ref this);
								return;
							}
							goto IL_05b7;
						}
						goto IL_05c8;
						IL_0506:
						result2 = val5.GetResult();
						findComponentService.LoadRuntimeModules(result2);
						goto IL_0517;
						IL_05c8:
						dataClasses = _003Cresponse_003E5__6.get_DataClasses();
						findComponentService.LoadRuntimeDataClasses((System.Collections.Generic.IEnumerable<RuntimeDataClassModel>)dataClasses);
						findComponentService.dataClassMetadataCacheService.Cache(dataClasses);
						if (findComponentService.applicationData.InterfaceBuilderMode != InterfaceBuilderMode.DevServer)
						{
							val3 = findComponentService.componentMetadataCacheService.GetFromCache(_003CdifferenceComponentMetadataUids_003E5__4.ExistUids).GetAwaiter();
							if (!val3.get_IsCompleted())
							{
								num = (_003C_003E1__state = 7);
								_003C_003Eu__1 = val3;
								_003C_003Et__builder.AwaitOnCompleted<TaskAwaiter<System.Collections.Generic.IEnumerable<RuntimeComponentModel>>, _003CLoadRuntimeMetadataInternal_003Ed__29>(ref val3, ref this);
								return;
							}
							goto IL_065f;
						}
						goto IL_0670;
						IL_02c2:
						metadataUidDifference = (_003CdifferenceComponentMetadataUids_003E5__4 = val.GetResult());
						missedGuids2 = _003CdifferenceComponentMetadataUids_003E5__4.MissedGuids;
						if (findComponentService.applicationData.InterfaceBuilderMode != InterfaceBuilderMode.DevServer)
						{
							_003Crequest_003E5__2.get_Components().Clear();
							_003Crequest_003E5__2.get_Components().AddRange(missedGuids2);
						}
						val = findComponentService.dataClassMetadataCacheService.GetDifferenceMetadataUids((System.Collections.Generic.IEnumerable<Guid>)_003Crequest_003E5__2.get_DataClasses()).GetAwaiter();
						if (!val.get_IsCompleted())
						{
							num = (_003C_003E1__state = 3);
							_003C_003Eu__1 = val;
							_003C_003Et__builder.AwaitOnCompleted<TaskAwaiter<IMetadataUidDifference>, _003CLoadRuntimeMetadataInternal_003Ed__29>(ref val, ref this);
							return;
						}
						goto IL_0377;
						IL_0464:
						val7 = (_003Cresponse_003E5__6 = val6.GetResult());
						goto IL_0482;
						IL_0705:
						enumerator = val2.GetResult().GetEnumerator();
						try
						{
							while (((System.Collections.IEnumerator)enumerator).MoveNext())
							{
								IMetadata current = enumerator.get_Current();
								findComponentService.metadataRegistrationService.Register(current);
							}
						}
						finally
						{
							if (num < 0)
							{
								((System.IDisposable)enumerator)?.Dispose();
							}
						}
						break;
						IL_0482:
						if (_003Cresponse_003E5__6 != null)
						{
							if (findComponentService.applicationData.InterfaceBuilderMode != InterfaceBuilderMode.DevServer)
							{
								val5 = findComponentService.moduleMetadataCacheService.GetFromCache(_003CdifferenceModuleMetadataUids_003E5__3.ExistUids).GetAwaiter();
								if (!val5.get_IsCompleted())
								{
									num = (_003C_003E1__state = 5);
									_003C_003Eu__1 = val5;
									_003C_003Et__builder.AwaitOnCompleted<TaskAwaiter<System.Collections.Generic.IEnumerable<RuntimeModuleModel>>, _003CLoadRuntimeMetadataInternal_003Ed__29>(ref val5, ref this);
									return;
								}
								goto IL_0506;
							}
							goto IL_0517;
						}
						result3 = null;
						goto end_IL_017e;
						IL_0377:
						metadataUidDifference = (_003CdifferenceDataClassMetadataUids_003E5__5 = val.GetResult());
						missedGuids3 = _003CdifferenceDataClassMetadataUids_003E5__5.MissedGuids;
						if (findComponentService.applicationData.InterfaceBuilderMode != InterfaceBuilderMode.DevServer)
						{
							_003Crequest_003E5__2.get_DataClasses().Clear();
							_003Crequest_003E5__2.get_DataClasses().AddRange(missedGuids3);
						}
						_003Cresponse_003E5__6 = null;
						if (_003Crequest_003E5__2.get_Components().get_Count() != 0 || _003Crequest_003E5__2.get_Modules().get_Count() != 0 || _003Crequest_003E5__2.get_DataClasses().get_Count() != 0)
						{
							val6 = findComponentService.componentMetadataService.LoadRuntimeMetadata(_003Crequest_003E5__2).GetAwaiter();
							if (!val6.get_IsCompleted())
							{
								num = (_003C_003E1__state = 4);
								_003C_003Eu__1 = val6;
								_003C_003Et__builder.AwaitOnCompleted<TaskAwaiter<RuntimeResponse>, _003CLoadRuntimeMetadataInternal_003Ed__29>(ref val6, ref this);
								return;
							}
							goto IL_0464;
						}
						_003Cresponse_003E5__6 = InterfaceCreator.Create<RuntimeResponse>();
						goto IL_0482;
						IL_05b7:
						result4 = val4.GetResult();
						findComponentService.LoadRuntimeDataClasses(result4);
						goto IL_05c8;
						IL_065f:
						result5 = val3.GetResult();
						findComponentService.LoadRuntimeCachedComponents(result5);
						goto IL_0670;
					}
					System.Collections.Generic.IEnumerator<EnumMetadata> enumerator2 = ((System.Collections.Generic.IEnumerable<EnumMetadata>)_003Cresponse_003E5__6.get_EnumMetadataList()).GetEnumerator();
					try
					{
						while (((System.Collections.IEnumerator)enumerator2).MoveNext())
						{
							EnumMetadata current2 = enumerator2.get_Current();
							findComponentService.metadataRegistrationService.Register((IMetadata)(object)current2);
						}
					}
					finally
					{
						if (num < 0)
						{
							((System.IDisposable)enumerator2)?.Dispose();
						}
					}
					findComponentService.metadataCacheService.Cache((System.Collections.Generic.IEnumerable<IMetadata>)_003Cresponse_003E5__6.get_EnumMetadataList());
					System.Collections.Generic.IEnumerator<EntityMetadata> enumerator3 = ((System.Collections.Generic.IEnumerable<EntityMetadata>)_003Cresponse_003E5__6.get_EntityMetadataList()).GetEnumerator();
					try
					{
						while (((System.Collections.IEnumerator)enumerator3).MoveNext())
						{
							EntityMetadata current3 = enumerator3.get_Current();
							findComponentService.metadataRegistrationService.Register((IMetadata)(object)current3);
						}
					}
					finally
					{
						if (num < 0)
						{
							((System.IDisposable)enumerator3)?.Dispose();
						}
					}
					findComponentService.metadataCacheService.Cache((System.Collections.Generic.IEnumerable<IMetadata>)_003Cresponse_003E5__6.get_EntityMetadataList());
					result3 = new LoadComponentScriptsResult
					{
						EntityDependencies = (System.Collections.Generic.IEnumerable<EntityDependency>)_003Cresponse_003E5__6.get_EntityDependencies()
					};
					end_IL_017e:;
				}
				catch
				{
					findComponentService.logger.Error(SR.T("Не удалось загрузить клиентские скрипты для Runtime"));
					result3 = null;
				}
				goto end_IL_000e;
				IL_0140:
				if (_003Crequest_003E5__2.get_Components().get_Count() != 0 || _003Crequest_003E5__2.get_Modules().get_Count() != 0 || _003Crequest_003E5__2.get_DataClasses().get_Count() != 0)
				{
					goto IL_017d;
				}
				result3 = null;
				end_IL_000e:;
			}
			catch (System.Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003C_003Et__builder.SetResult(result3);
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			_003C_003Et__builder.SetStateMachine(stateMachine);
		}
	}

	private sealed class _003C_003Ec__DisplayClass30_0
	{
		public ModuleMetadataItem moduleItem;

		public FindComponentService _003C_003E4__this;

		internal void _003CLoadRuntimeModules_003Eb__0()
		{
			_003C_003E4__this.ModuleRegister(moduleItem, loadedScript: true);
		}
	}

	private sealed class _003C_003Ec__DisplayClass32_0
	{
		public RuntimeComponentModel component;

		public FindComponentService _003C_003E4__this;

		internal void _003CLoadRuntimeCachedComponents_003Eb__0()
		{
			_003C_003E4__this.ComponentRegister(component.get_MetadataItem());
		}
	}

	private ItemRuntimeModelDto[] systemItemRuntimeModels;

	private readonly IComponentMetadataService componentMetadataService;

	private readonly IScriptLoaderService scriptLoaderService;

	private readonly ModuleMetadataItemManager moduleMetadataItemManager;

	private readonly IMetadataRegistrationService metadataRegistrationService;

	private readonly ComponentMetadataItemManager componentMetadataItemManager;

	private readonly DataClassMetadataItemManager dataClassMetadataItemManager;

	private readonly IApplicationData applicationData;

	private readonly ILogger logger;

	private readonly INotificationService notificationService;

	private readonly IMetadataCacheService metadataCacheService;

	private readonly IModuleMetadataCacheService moduleMetadataCacheService;

	private readonly IComponentMetadataCacheService componentMetadataCacheService;

	private readonly IDataClassMetadataCacheService dataClassMetadataCacheService;

	private static readonly ItemRuntimeModelDto.Comparer DefaultItemRuntimeModelDtoComparer = new ItemRuntimeModelDto.Comparer();

	public FindComponentService(IComponentMetadataService componentMetadataService, IScriptLoaderService scriptLoaderService, ModuleMetadataItemManager moduleMetadataItemManager, IMetadataRegistrationService metadataRegistrationService, ComponentMetadataItemManager componentMetadataItemManager, DataClassMetadataItemManager dataClassMetadataItemManager, IApplicationData applicationData, ILogger logger, INotificationService notificationService, IMetadataCacheService metadataCacheService, IModuleMetadataCacheService moduleMetadataCacheService, IComponentMetadataCacheService componentMetadataCacheService, IDataClassMetadataCacheService dataClassMetadataCacheService)
	{
		this.componentMetadataService = componentMetadataService;
		this.scriptLoaderService = scriptLoaderService;
		this.moduleMetadataItemManager = moduleMetadataItemManager;
		this.metadataRegistrationService = metadataRegistrationService;
		this.componentMetadataItemManager = componentMetadataItemManager;
		this.dataClassMetadataItemManager = dataClassMetadataItemManager;
		this.applicationData = applicationData;
		this.logger = logger;
		this.notificationService = notificationService;
		this.metadataCacheService = metadataCacheService;
		this.moduleMetadataCacheService = moduleMetadataCacheService;
		this.componentMetadataCacheService = componentMetadataCacheService;
		this.dataClassMetadataCacheService = dataClassMetadataCacheService;
	}

	public void RegisterSystemModule(ItemRuntimeModelDto[] itemRuntimeModels)
	{
		if (systemItemRuntimeModels == null)
		{
			systemItemRuntimeModels = itemRuntimeModels;
		}
	}

	internal ModuleMetadataItem TryFindModuleByComponentHeaderUid(Guid componentHeaderUid)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		return moduleMetadataItemManager.TryLoadComponentByHeaderId(componentHeaderUid);
	}

	internal System.Threading.Tasks.Task<RenderComponentModel> FindComponent(Guid headerUid, InterfaceBuilderViewMode viewMode)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		_003CFindComponent_003Ed__18 _003CFindComponent_003Ed__ = default(_003CFindComponent_003Ed__18);
		_003CFindComponent_003Ed__._003C_003E4__this = this;
		_003CFindComponent_003Ed__.headerUid = headerUid;
		_003CFindComponent_003Ed__.viewMode = viewMode;
		_003CFindComponent_003Ed__._003C_003Et__builder = AsyncTaskMethodBuilder<RenderComponentModel>.Create();
		_003CFindComponent_003Ed__._003C_003E1__state = -1;
		AsyncTaskMethodBuilder<RenderComponentModel> _003C_003Et__builder = _003CFindComponent_003Ed__._003C_003Et__builder;
		_003C_003Et__builder.Start<_003CFindComponent_003Ed__18>(ref _003CFindComponent_003Ed__);
		return _003CFindComponent_003Ed__._003C_003Et__builder.get_Task();
	}

	internal System.Threading.Tasks.Task<LoadComponentScriptsResult> LoadRuntimeMetadata(System.Collections.Generic.IEnumerable<ClientComponentModel> componentModels)
	{
		RequestComponentModel requestComponentModel = new RequestComponentModel();
		GetRequestComponentModel(requestComponentModel, componentModels);
		return LoadRuntimeMetadataInternal(requestComponentModel, (System.Collections.Generic.IEnumerable<Guid>)Enumerable.Empty<Guid>(), applicationData.Debug);
	}

	internal UIRuntimeModelDto GetCurrentRuntimeModel()
	{
		List<ItemRuntimeModelDto> val = Enumerable.Select<ModuleMetadataItem, ItemRuntimeModelDto>(moduleMetadataItemManager.GetPublished(), (Func<ModuleMetadataItem, ItemRuntimeModelDto>)((ModuleMetadataItem a) => new ItemRuntimeModelDto
		{
			ItemUid = a.get_Uid(),
			HeaderUid = a.get_Header_Uid()
		})).Where((Func<ItemRuntimeModelDto, bool>)delegate(ItemRuntimeModelDto i)
		{
			_003C_003Ec__DisplayClass20_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass20_0();
			CS_0024_003C_003E8__locals0.i = i;
			return Enumerable.All<ItemRuntimeModelDto>((System.Collections.Generic.IEnumerable<ItemRuntimeModelDto>)systemItemRuntimeModels, (Func<ItemRuntimeModelDto, bool>)((ItemRuntimeModelDto s) => s.HeaderUid != CS_0024_003C_003E8__locals0.i.HeaderUid));
		}).ToList();
		return new UIRuntimeModelDto
		{
			RuntimeModules = Enumerable.Concat<ItemRuntimeModelDto>((System.Collections.Generic.IEnumerable<ItemRuntimeModelDto>)systemItemRuntimeModels, (System.Collections.Generic.IEnumerable<ItemRuntimeModelDto>)val).Distinct((IEqualityComparer<ItemRuntimeModelDto>)DefaultItemRuntimeModelDtoComparer).ToArray()
		};
	}

	internal System.Threading.Tasks.Task<LoadComponentScriptsResult> LoadComponent(RecursiveComponentModel model, System.Collections.Generic.IEnumerable<Guid> metadataUids = null)
	{
		_003C_003Ec__DisplayClass21_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass21_0();
		RequestComponentModel requestComponentModel = new RequestComponentModel();
		CS_0024_003C_003E8__locals0.modelHeader = model.get_Header();
		GetRequestComponentModel(requestComponentModel, CS_0024_003C_003E8__locals0.modelHeader);
		GetRequestComponentModel(requestComponentModel, (System.Collections.Generic.IEnumerable<ClientComponentModel>)model.get_ComponentCache(), delegate(ClientComponentModel clientComponent)
		{
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_0029: Unknown result type (might be due to invalid IL or missing references)
			//IL_003b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0048: Unknown result type (might be due to invalid IL or missing references)
			//IL_004d: Unknown result type (might be due to invalid IL or missing references)
			//IL_004e: Unknown result type (might be due to invalid IL or missing references)
			//IL_004f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0061: Unknown result type (might be due to invalid IL or missing references)
			if (clientComponent.get_Async())
			{
				return false;
			}
			if (clientComponent.get_ModuleItemUid() != Guid.Empty)
			{
				return true;
			}
			Guid val = ((CS_0024_003C_003E8__locals0.modelHeader.get_ItemUid() != Guid.Empty) ? CS_0024_003C_003E8__locals0.modelHeader.get_ItemUid() : CS_0024_003C_003E8__locals0.modelHeader.get_ModuleItemUid());
			return val != Guid.Empty && clientComponent.get_Owners().Contains(val);
		});
		GetRequestExtensionPointsModel(requestComponentModel, model.get_ExtensionPoints());
		GetRequestCustomTypesModel(requestComponentModel, model.get_CustomTypes());
		if (metadataUids == null)
		{
			metadataUids = (System.Collections.Generic.IEnumerable<Guid>)Enumerable.Empty<Guid>();
		}
		return LoadRuntimeMetadataInternal(requestComponentModel, metadataUids, applicationData.Debug);
	}

	private void GetRequestComponentModel(RequestComponentModel requestModel, System.Collections.Generic.IEnumerable<ClientComponentModel> componentModels, Func<ClientComponentModel, bool> loadComponent = null)
	{
		System.Collections.Generic.IEnumerator<ClientComponentModel> enumerator = componentModels.GetEnumerator();
		try
		{
			while (((System.Collections.IEnumerator)enumerator).MoveNext())
			{
				ClientComponentModel current = enumerator.get_Current();
				GetRequestComponentModel(requestModel, current, loadComponent);
			}
		}
		finally
		{
			((System.IDisposable)enumerator)?.Dispose();
		}
	}

	private void GetRequestComponentModel(RequestComponentModel requestModel, ClientComponentModel componentModel, Func<ClientComponentModel, bool> loadComponent = null)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		if (loadComponent == null || loadComponent.Invoke(componentModel))
		{
			if (componentModel.get_ModuleItemUid() != Guid.Empty && !moduleMetadataItemManager.CheckItem(componentModel.get_ModuleItemUid()) && !requestModel.LoadingModules.Contains(componentModel.get_ModuleItemUid()))
			{
				requestModel.LoadingModules.Add(componentModel.get_ModuleItemUid());
				PrepareDataClasses(requestModel, (System.Collections.Generic.IEnumerable<ClientDataClassModel>)componentModel.get_DataClasses());
				PrepareFunctions(requestModel, (System.Collections.Generic.IEnumerable<ClientFunctionModel>)componentModel.get_Functions());
			}
			if (componentModel.get_ItemUid() != Guid.Empty && !componentMetadataItemManager.CheckItem(componentModel.get_ItemUid()) && !requestModel.LoadingComponents.Contains(componentModel.get_ItemUid()))
			{
				requestModel.LoadingComponents.Add(componentModel.get_ItemUid());
				PrepareDataClasses(requestModel, (System.Collections.Generic.IEnumerable<ClientDataClassModel>)componentModel.get_DataClasses());
				PrepareFunctions(requestModel, (System.Collections.Generic.IEnumerable<ClientFunctionModel>)componentModel.get_Functions());
			}
		}
	}

	private void GetRequestExtensionPointsModel(RequestComponentModel requestModel, System.Collections.Generic.ICollection<ClientExtensionPointModel> extensionPoints)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		System.Collections.Generic.IEnumerator<ClientExtensionPointModel> enumerator = ((System.Collections.Generic.IEnumerable<ClientExtensionPointModel>)extensionPoints).GetEnumerator();
		try
		{
			while (((System.Collections.IEnumerator)enumerator).MoveNext())
			{
				System.Collections.Generic.IEnumerator<ClientImplementationModel> enumerator2 = ((System.Collections.Generic.IEnumerable<ClientImplementationModel>)enumerator.get_Current().get_Implementations()).GetEnumerator();
				try
				{
					while (((System.Collections.IEnumerator)enumerator2).MoveNext())
					{
						ClientImplementationModel current = enumerator2.get_Current();
						if (current.get_ModuleItemUid() != Guid.Empty && !moduleMetadataItemManager.CheckItem(current.get_ModuleItemUid()) && !requestModel.LoadingModules.Contains(current.get_ModuleItemUid()))
						{
							requestModel.LoadingModules.Add(current.get_ModuleItemUid());
						}
						else if (current.get_ItemUid() != Guid.Empty && !componentMetadataItemManager.CheckItem(current.get_ItemUid()) && !requestModel.LoadingComponents.Contains(current.get_ItemUid()))
						{
							requestModel.LoadingComponents.Add(current.get_ItemUid());
						}
					}
				}
				finally
				{
					((System.IDisposable)enumerator2)?.Dispose();
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator)?.Dispose();
		}
	}

	private void GetRequestCustomTypesModel(RequestComponentModel requestModel, System.Collections.Generic.ICollection<CustomTypeModel> customTypes)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		System.Collections.Generic.IEnumerator<CustomTypeModel> enumerator = ((System.Collections.Generic.IEnumerable<CustomTypeModel>)customTypes).GetEnumerator();
		try
		{
			while (((System.Collections.IEnumerator)enumerator).MoveNext())
			{
				CustomTypeModel current = enumerator.get_Current();
				if (current.get_ModuleItemUid() != Guid.Empty && !moduleMetadataItemManager.CheckItem(current.get_ModuleItemUid()) && !requestModel.LoadingModules.Contains(current.get_ModuleItemUid()))
				{
					requestModel.LoadingModules.Add(current.get_ModuleItemUid());
				}
				else if (current.get_ItemUid() != Guid.Empty && !componentMetadataItemManager.CheckItem(current.get_ItemUid()) && !requestModel.LoadingComponents.Contains(current.get_ItemUid()))
				{
					requestModel.LoadingComponents.Add(current.get_ItemUid());
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator)?.Dispose();
		}
	}

	private void PrepareDataClasses(RequestComponentModel requestModel, System.Collections.Generic.IEnumerable<ClientDataClassModel> clientDataClassModels)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		if (requestModel == null)
		{
			return;
		}
		System.Collections.Generic.IEnumerator<ClientDataClassModel> enumerator = clientDataClassModels.GetEnumerator();
		try
		{
			while (((System.Collections.IEnumerator)enumerator).MoveNext())
			{
				ClientDataClassModel current = enumerator.get_Current();
				if (current.get_ModuleItemUid() != Guid.Empty && !moduleMetadataItemManager.CheckItem(current.get_ModuleItemUid()) && !requestModel.LoadingModules.Contains(current.get_ModuleItemUid()))
				{
					requestModel.LoadingModules.Add(current.get_ModuleItemUid());
				}
				if (current.get_ItemUid() != Guid.Empty && !dataClassMetadataItemManager.CheckItem(current.get_ItemUid()) && !requestModel.LoadingDataClasses.Contains(current.get_ItemUid()))
				{
					requestModel.LoadingDataClasses.Add(current.get_ItemUid());
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator)?.Dispose();
		}
	}

	private void PrepareFunctions(RequestComponentModel requestModel, System.Collections.Generic.IEnumerable<ClientFunctionModel> clientFunctionModels)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		if (requestModel == null)
		{
			return;
		}
		System.Collections.Generic.IEnumerator<ClientFunctionModel> enumerator = clientFunctionModels.GetEnumerator();
		try
		{
			while (((System.Collections.IEnumerator)enumerator).MoveNext())
			{
				ClientFunctionModel current = enumerator.get_Current();
				if (current.get_ModuleItemUid() != Guid.Empty && !moduleMetadataItemManager.CheckItem(current.get_ModuleItemUid()) && !requestModel.LoadingModules.Contains(current.get_ModuleItemUid()))
				{
					requestModel.LoadingModules.Add(current.get_ModuleItemUid());
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator)?.Dispose();
		}
	}

	private void ModuleRegister(ModuleMetadataItem item, bool loadedScript)
	{
		moduleMetadataItemManager.RegisterItem(item, loadedScript);
		ModuleInfoMetadata metadata = item.get_Metadata();
		metadataRegistrationService.Register((IMetadata)(object)metadata);
		metadataRegistrationService.Register(MetadataHelper.GetMetadataToRegister((IMetadata)(object)metadata));
	}

	private System.Threading.Tasks.Task<LoadComponentScriptsResult> LoadRuntimeMetadataInternal(RequestComponentModel requestComponentModel, System.Collections.Generic.IEnumerable<Guid> metadataUids, bool debug = false)
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		_003CLoadRuntimeMetadataInternal_003Ed__29 _003CLoadRuntimeMetadataInternal_003Ed__ = default(_003CLoadRuntimeMetadataInternal_003Ed__29);
		_003CLoadRuntimeMetadataInternal_003Ed__._003C_003E4__this = this;
		_003CLoadRuntimeMetadataInternal_003Ed__.requestComponentModel = requestComponentModel;
		_003CLoadRuntimeMetadataInternal_003Ed__.metadataUids = metadataUids;
		_003CLoadRuntimeMetadataInternal_003Ed__.debug = debug;
		_003CLoadRuntimeMetadataInternal_003Ed__._003C_003Et__builder = AsyncTaskMethodBuilder<LoadComponentScriptsResult>.Create();
		_003CLoadRuntimeMetadataInternal_003Ed__._003C_003E1__state = -1;
		AsyncTaskMethodBuilder<LoadComponentScriptsResult> _003C_003Et__builder = _003CLoadRuntimeMetadataInternal_003Ed__._003C_003Et__builder;
		_003C_003Et__builder.Start<_003CLoadRuntimeMetadataInternal_003Ed__29>(ref _003CLoadRuntimeMetadataInternal_003Ed__);
		return _003CLoadRuntimeMetadataInternal_003Ed__._003C_003Et__builder.get_Task();
	}

	private void LoadRuntimeModules(System.Collections.Generic.IEnumerable<RuntimeModuleModel> modules)
	{
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected O, but got Unknown
		System.Collections.Generic.IEnumerator<RuntimeModuleModel> enumerator = modules.GetEnumerator();
		try
		{
			while (((System.Collections.IEnumerator)enumerator).MoveNext())
			{
				RuntimeModuleModel current = enumerator.get_Current();
				_003C_003Ec__DisplayClass30_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass30_0();
				CS_0024_003C_003E8__locals0._003C_003E4__this = this;
				CS_0024_003C_003E8__locals0.moduleItem = current.get_MetadataItem();
				ClientScriptModel script = current.get_Script();
				if (script == null || string.IsNullOrWhiteSpace(script.get_SourceCode()))
				{
					logger.Info(SR.T("Не удалось загрузить клиентский скрипт модуля {0}: пустой исходный код", ((INamedMetadata)CS_0024_003C_003E8__locals0.moduleItem.get_Metadata()).get_DisplayName()));
					ModuleRegister(CS_0024_003C_003E8__locals0.moduleItem, loadedScript: false);
					continue;
				}
				string assemblyName = script.get_AssemblyName();
				CS_0024_003C_003E8__locals0.moduleItem.set_AssemblyName(assemblyName);
				scriptLoaderService.ApplyScript(assemblyName, script.get_SourceCode(), (Action)delegate
				{
					CS_0024_003C_003E8__locals0._003C_003E4__this.ModuleRegister(CS_0024_003C_003E8__locals0.moduleItem, loadedScript: true);
				});
			}
		}
		finally
		{
			((System.IDisposable)enumerator)?.Dispose();
		}
	}

	private void LoadRuntimeDataClasses(System.Collections.Generic.IEnumerable<RuntimeDataClassModel> dataClassModels)
	{
		System.Collections.Generic.IEnumerator<RuntimeDataClassModel> enumerator = dataClassModels.GetEnumerator();
		try
		{
			while (((System.Collections.IEnumerator)enumerator).MoveNext())
			{
				DataClassMetadataItem metadataItem = enumerator.get_Current().get_MetadataItem();
				if (metadataItem.get_IsPublished())
				{
					dataClassMetadataItemManager.RegisterItem(metadataItem);
					metadataRegistrationService.Register((IMetadata)(object)metadataItem.get_Metadata());
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator)?.Dispose();
		}
	}

	private void LoadRuntimeCachedComponents(System.Collections.Generic.IEnumerable<RuntimeComponentModel> componentModels)
	{
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Expected O, but got Unknown
		System.Collections.Generic.IEnumerator<RuntimeComponentModel> enumerator = componentModels.GetEnumerator();
		try
		{
			while (((System.Collections.IEnumerator)enumerator).MoveNext())
			{
				_003C_003Ec__DisplayClass32_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass32_0();
				CS_0024_003C_003E8__locals0._003C_003E4__this = this;
				CS_0024_003C_003E8__locals0.component = enumerator.get_Current();
				ComponentMetadataItem metadataItem = CS_0024_003C_003E8__locals0.component.get_MetadataItem();
				ClientScriptModel script = CS_0024_003C_003E8__locals0.component.get_Script();
				if (script == null)
				{
					logger.Info(SR.T("Не удалось загрузить клиентский скрипт компонента {0}: пустой скрипт-модуль", ((INamedMetadata)metadataItem.get_Metadata()).get_DisplayName()));
					ComponentRegister(metadataItem);
					continue;
				}
				string sourceCode = script.get_SourceCode();
				if (string.IsNullOrWhiteSpace(sourceCode))
				{
					logger.Info(SR.T("Не удалось загрузить клиентский скрипт компонента {0}: пустой исходный код", ((INamedMetadata)metadataItem.get_Metadata()).get_DisplayName()));
					ComponentRegister(metadataItem);
				}
				else
				{
					scriptLoaderService.ApplyScript(script.get_AssemblyName(), sourceCode, (Action)delegate
					{
						CS_0024_003C_003E8__locals0._003C_003E4__this.ComponentRegister(CS_0024_003C_003E8__locals0.component.get_MetadataItem());
					});
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator)?.Dispose();
		}
	}

	private void ComponentRegister(ComponentMetadataItem item)
	{
		componentMetadataItemManager.RegisterItem(item);
		ComponentMetadata metadata = item.get_Metadata();
		metadataRegistrationService.Register((IMetadata)(object)metadata);
		metadataRegistrationService.Register(MetadataHelper.GetMetadataToRegister((IMetadata)(object)metadata));
	}

	private static EntityDependency MapEntityDependencyFromDto(EntityDependencyDto entityDependencyDto)
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		if (entityDependencyDto == null)
		{
			return null;
		}
		EntityDependency val = InterfaceCreator.Create<EntityDependency>();
		((Dependency)val).set_Name(entityDependencyDto.Name);
		((Dependency)val).set_DisplayName(entityDependencyDto.DisplayName);
		((Dependency)val).set_HeaderUid(entityDependencyDto.HeaderUid);
		((Dependency)val).set_ModuleUid(entityDependencyDto.ModuleUid);
		if (entityDependencyDto.Properties != null)
		{
			for (int i = 0; i < entityDependencyDto.Properties.Length; i++)
			{
				PropertySignatureDto propertySignatureDto = entityDependencyDto.Properties[i];
				PropertySignature val2 = InterfaceCreator.Create<PropertySignature>();
				val2.set_Name(propertySignatureDto.Name);
				val2.set_Uid(propertySignatureDto.Uid);
				TypeSignature val3 = InterfaceCreator.Create<TypeSignature>();
				val3.set_Nullable(propertySignatureDto.Type.Nullable);
				val3.set_RelationType(propertySignatureDto.Type.RelationType);
				val3.set_TypeUid(propertySignatureDto.Type.TypeUid);
				val3.set_SubTypeUid(propertySignatureDto.Type.SubTypeUid);
				val2.set_Type(val3);
				((ClassDependency)val).get_Properties().Add(val2);
			}
		}
		return val;
	}

	internal static RecursiveComponentModel MapRecursiveComponentModelFromDto(RecursiveComponentModelDto recursiveModelDto)
	{
		RecursiveComponentModel val = InterfaceCreator.Create<RecursiveComponentModel>();
		if (recursiveModelDto.Errors != null)
		{
			val.get_Errors().AddRange(recursiveModelDto.Errors);
		}
		val.set_Header(MapClientComponentModelFromDto(recursiveModelDto.Header));
		if (recursiveModelDto.ComponentCache != null)
		{
			val.get_ComponentCache().AddRange((System.Collections.Generic.IEnumerable<ClientComponentModel>)Enumerable.Select<ClientComponentModelDto, ClientComponentModel>((System.Collections.Generic.IEnumerable<ClientComponentModelDto>)recursiveModelDto.ComponentCache, (Func<ClientComponentModelDto, ClientComponentModel>)MapClientComponentModelFromDto));
		}
		if (recursiveModelDto.ExtensionPoints != null)
		{
			val.get_ExtensionPoints().AddRange((System.Collections.Generic.IEnumerable<ClientExtensionPointModel>)Enumerable.Select<ClientExtensionPointModelDto, ClientExtensionPointModel>((System.Collections.Generic.IEnumerable<ClientExtensionPointModelDto>)recursiveModelDto.ExtensionPoints, (Func<ClientExtensionPointModelDto, ClientExtensionPointModel>)delegate(ClientExtensionPointModelDto e)
			{
				//IL_0014: Unknown result type (might be due to invalid IL or missing references)
				ClientExtensionPointModel val2 = InterfaceCreator.Create<ClientExtensionPointModel>();
				val2.set_PointId(e.PointId);
				val2.set_TypeUid(e.TypeUid);
				if (e.Implementations != null)
				{
					val2.get_Implementations().AddRange((System.Collections.Generic.IEnumerable<ClientImplementationModel>)Enumerable.Select<ClientImplementationModelDto, ClientImplementationModel>((System.Collections.Generic.IEnumerable<ClientImplementationModelDto>)e.Implementations, (Func<ClientImplementationModelDto, ClientImplementationModel>)delegate(ClientImplementationModelDto i)
					{
						//IL_0007: Unknown result type (might be due to invalid IL or missing references)
						//IL_0013: Unknown result type (might be due to invalid IL or missing references)
						//IL_001f: Unknown result type (might be due to invalid IL or missing references)
						ClientImplementationModel obj2 = InterfaceCreator.Create<ClientImplementationModel>();
						obj2.set_HeaderUid(i.HeaderUid);
						obj2.set_ItemUid(i.ItemUid);
						obj2.set_ModuleItemUid(i.ModuleItemUid);
						return obj2;
					}));
				}
				return val2;
			}));
		}
		if (recursiveModelDto.CustomTypes != null)
		{
			val.get_CustomTypes().AddRange((System.Collections.Generic.IEnumerable<CustomTypeModel>)Enumerable.Select<CustomTypeModelDto, CustomTypeModel>((System.Collections.Generic.IEnumerable<CustomTypeModelDto>)recursiveModelDto.CustomTypes, (Func<CustomTypeModelDto, CustomTypeModel>)delegate(CustomTypeModelDto e)
			{
				//IL_0007: Unknown result type (might be due to invalid IL or missing references)
				//IL_0013: Unknown result type (might be due to invalid IL or missing references)
				//IL_002b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0037: Unknown result type (might be due to invalid IL or missing references)
				//IL_0043: Unknown result type (might be due to invalid IL or missing references)
				CustomTypeModel obj = InterfaceCreator.Create<CustomTypeModel>();
				obj.set_TypeUid(e.TypeUid);
				obj.set_SubTypeUid(e.SubTypeUid);
				obj.set_IsCollection(e.IsCollection);
				obj.set_HeaderUid(e.HeaderUid);
				obj.set_ItemUid(e.ItemUid);
				obj.set_ModuleItemUid(e.ModuleItemUid);
				return obj;
			}));
		}
		if (recursiveModelDto.EntityMetadataUids != null)
		{
			val.get_EntityMetadataUids().AddRange(recursiveModelDto.EntityMetadataUids);
		}
		if (recursiveModelDto.EnumMetadataUids != null)
		{
			val.get_EnumMetadataUids().AddRange(recursiveModelDto.EnumMetadataUids);
		}
		return val;
	}

	internal static ClientComponentModel MapClientComponentModelFromDto(ClientComponentModelDto clientComponentModelDto)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		ClientComponentModel val = InterfaceCreator.Create<ClientComponentModel>();
		val.set_Async(clientComponentModelDto.Async);
		val.set_ItemUid(clientComponentModelDto.ItemUid);
		val.set_ModuleItemUid(clientComponentModelDto.ModuleItemUid);
		if (clientComponentModelDto.RenderUidList != null)
		{
			val.get_RenderUidList().AddRange(clientComponentModelDto.RenderUidList);
		}
		if (clientComponentModelDto.Owners != null)
		{
			val.get_Owners().AddRange(clientComponentModelDto.Owners);
		}
		if (clientComponentModelDto.Functions != null)
		{
			val.get_Functions().AddRange((System.Collections.Generic.IEnumerable<ClientFunctionModel>)Enumerable.Select<ClientFunctionModelDto, ClientFunctionModel>((System.Collections.Generic.IEnumerable<ClientFunctionModelDto>)clientComponentModelDto.Functions, (Func<ClientFunctionModelDto, ClientFunctionModel>)delegate(ClientFunctionModelDto f)
			{
				//IL_0007: Unknown result type (might be due to invalid IL or missing references)
				//IL_0013: Unknown result type (might be due to invalid IL or missing references)
				//IL_001f: Unknown result type (might be due to invalid IL or missing references)
				ClientFunctionModel obj2 = InterfaceCreator.Create<ClientFunctionModel>();
				obj2.set_HeaderUid(f.HeaderUid);
				obj2.set_ItemUid(f.ItemUid);
				obj2.set_ModuleItemUid(f.ModuleItemUid);
				return obj2;
			}));
		}
		if (clientComponentModelDto.DataClasses != null)
		{
			val.get_DataClasses().AddRange((System.Collections.Generic.IEnumerable<ClientDataClassModel>)Enumerable.Select<ClientDataClassModelDto, ClientDataClassModel>((System.Collections.Generic.IEnumerable<ClientDataClassModelDto>)clientComponentModelDto.DataClasses, (Func<ClientDataClassModelDto, ClientDataClassModel>)delegate(ClientDataClassModelDto f)
			{
				//IL_0007: Unknown result type (might be due to invalid IL or missing references)
				//IL_0013: Unknown result type (might be due to invalid IL or missing references)
				//IL_001f: Unknown result type (might be due to invalid IL or missing references)
				ClientDataClassModel obj = InterfaceCreator.Create<ClientDataClassModel>();
				obj.set_HeaderUid(f.HeaderUid);
				obj.set_ItemUid(f.ItemUid);
				obj.set_ModuleItemUid(f.ModuleItemUid);
				return obj;
			}));
		}
		return val;
	}

	private bool _003CGetCurrentRuntimeModel_003Eb__20_1(ItemRuntimeModelDto i)
	{
		_003C_003Ec__DisplayClass20_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass20_0();
		CS_0024_003C_003E8__locals0.i = i;
		return Enumerable.All<ItemRuntimeModelDto>((System.Collections.Generic.IEnumerable<ItemRuntimeModelDto>)systemItemRuntimeModels, (Func<ItemRuntimeModelDto, bool>)((ItemRuntimeModelDto s) => s.HeaderUid != CS_0024_003C_003E8__locals0.i.HeaderUid));
	}
}
