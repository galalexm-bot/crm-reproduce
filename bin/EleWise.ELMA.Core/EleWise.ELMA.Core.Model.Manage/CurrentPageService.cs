using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using EleWise.ELMA.Core.Abstractions.Metadata.Models;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Dependencies;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Metadata;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Scripts;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Signatures;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.UI;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.UI.Metadata;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.UI.Models;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.Core.Services;
using EleWise.ELMA.DataClasses;
using EleWise.ELMA.DTO;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Ioc.Abstract;
using EleWise.ELMA.Model;
using EleWise.ELMA.Model.Helpers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Metadata.DTO.Managers;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Scripts;
using EleWise.ELMA.Scripts.Models;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
using EleWise.ELMA.UI.Managers;

namespace EleWise.ELMA.Core.Model.Managers;

[Service]
internal sealed class CurrentPageService : ICurrentPageService, IClientCurrentPageService
{
	[StructLayout(3)]
	private struct _003CLoadClientComponentMetadataItem_003Ed__18 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<DataClass> _003C_003Et__builder;

		public CurrentPageService _003C_003E4__this;

		public Guid parentItemUid;

		public ComponentViewItem componentViewItem;

		public InterfaceBuilderViewMode viewMode;

		public bool clearCache;

		private object _003C_003Eu__1;

		private void MoveNext()
		{
			//IL_0013: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			CurrentPageService currentPageService = _003C_003E4__this;
			DataClass result;
			try
			{
				TaskAwaiter<UIViewModel> val;
				if (num != 0)
				{
					val = currentPageService.LoadComponentMetadataItem(parentItemUid, componentViewItem, viewMode, clearCache).GetAwaiter();
					if (!val.get_IsCompleted())
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = val;
						_003C_003Et__builder.AwaitOnCompleted<TaskAwaiter<UIViewModel>, _003CLoadClientComponentMetadataItem_003Ed__18>(ref val, ref this);
						return;
					}
				}
				else
				{
					val = (TaskAwaiter<UIViewModel>)_003C_003Eu__1;
					_003C_003Eu__1 = null;
					num = (_003C_003E1__state = -1);
				}
				result = ObjectExtensions.As<DataClass>((object)val.GetResult());
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
		public Guid itemUid;

		internal bool _003CLoadComponentMetadataItemInternal_003Eb__4(KeyValuePair<Guid, ClientComponentModel> a)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			if (a.get_Key() == itemUid)
			{
				return true;
			}
			ClientComponentModel value = a.get_Value();
			if (!value.get_Async())
			{
				return value.get_Owners().Contains(itemUid);
			}
			return false;
		}

		internal bool _003CLoadComponentMetadataItemInternal_003Eb__6(KeyValuePair<Guid, ClientComponentModel> a)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			if (a.get_Key() == itemUid)
			{
				return true;
			}
			ClientComponentModel value = a.get_Value();
			if (!value.get_Async())
			{
				return value.get_Owners().Contains(itemUid);
			}
			return false;
		}
	}

	private sealed class _003C_003Ec__DisplayClass20_1
	{
		public EntityDependency entityDependency;

		internal bool _003CLoadComponentMetadataItemInternal_003Eb__10(EntityDependency a)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			return ((Dependency)a).get_HeaderUid() == ((Dependency)entityDependency).get_HeaderUid();
		}
	}

	private sealed class _003C_003Ec__DisplayClass20_2
	{
		public PropertySignature property;

		internal bool _003CLoadComponentMetadataItemInternal_003Eb__12(PropertySignature a)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			return a.get_Uid() == property.get_Uid();
		}
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();

		public static Func<ClientDataClassModel, Guid> _003C_003E9__20_0;

		public static Func<EntityDependency, Guid> _003C_003E9__20_1;

		public static Func<KeyValuePair<Guid, ClientComponentModel>, ClientComponentModel> _003C_003E9__20_5;

		public static Func<ClientDataClassModel, Guid> _003C_003E9__20_2;

		public static Func<EntityDependency, Guid> _003C_003E9__20_3;

		public static Func<KeyValuePair<Guid, ClientComponentModel>, ClientComponentModel> _003C_003E9__20_7;

		public static Func<PropertySignature, bool> _003C_003E9__20_13;

		public static Func<PropertySignature, bool> _003C_003E9__20_11;

		public static Func<ClientDataClassModel, Guid> _003C_003E9__20_8;

		public static Func<EntityDependency, Guid> _003C_003E9__20_9;

		internal Guid _003CLoadComponentMetadataItemInternal_003Eb__20_0(ClientDataClassModel a)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return a.get_HeaderUid();
		}

		internal Guid _003CLoadComponentMetadataItemInternal_003Eb__20_1(EntityDependency a)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return ((Dependency)a).get_HeaderUid();
		}

		internal ClientComponentModel _003CLoadComponentMetadataItemInternal_003Eb__20_5(KeyValuePair<Guid, ClientComponentModel> a)
		{
			return a.get_Value();
		}

		internal Guid _003CLoadComponentMetadataItemInternal_003Eb__20_2(ClientDataClassModel a)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return a.get_HeaderUid();
		}

		internal Guid _003CLoadComponentMetadataItemInternal_003Eb__20_3(EntityDependency a)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return ((Dependency)a).get_HeaderUid();
		}

		internal ClientComponentModel _003CLoadComponentMetadataItemInternal_003Eb__20_7(KeyValuePair<Guid, ClientComponentModel> a)
		{
			return a.get_Value();
		}

		internal bool _003CLoadComponentMetadataItemInternal_003Eb__20_13(PropertySignature a)
		{
			return a.get_Name() == "Uid";
		}

		internal bool _003CLoadComponentMetadataItemInternal_003Eb__20_11(PropertySignature a)
		{
			return a.get_Name() == "Uid";
		}

		internal Guid _003CLoadComponentMetadataItemInternal_003Eb__20_8(ClientDataClassModel a)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return a.get_HeaderUid();
		}

		internal Guid _003CLoadComponentMetadataItemInternal_003Eb__20_9(EntityDependency a)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return ((Dependency)a).get_HeaderUid();
		}
	}

	[StructLayout(3)]
	private struct _003CLoadComponentMetadataItemInternal_003Ed__20 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<UIViewModel> _003C_003Et__builder;

		public CurrentPageService _003C_003E4__this;

		public Guid parentItemUid;

		public ComponentViewItem componentViewItem;

		public InterfaceBuilderViewMode viewMode;

		public bool clearCache;

		private _003C_003Ec__DisplayClass20_0 _003C_003E8__1;

		private string _003CrenderUid_003E5__2;

		private object _003C_003Eu__1;

		private void MoveNext()
		{
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_0031: Unknown result type (might be due to invalid IL or missing references)
			//IL_007d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0088: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
			//IL_015f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0164: Unknown result type (might be due to invalid IL or missing references)
			//IL_0166: Unknown result type (might be due to invalid IL or missing references)
			//IL_0168: Unknown result type (might be due to invalid IL or missing references)
			//IL_0179: Unknown result type (might be due to invalid IL or missing references)
			//IL_017e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0191: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
			//IL_024a: Unknown result type (might be due to invalid IL or missing references)
			//IL_025c: Unknown result type (might be due to invalid IL or missing references)
			//IL_026b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0278: Unknown result type (might be due to invalid IL or missing references)
			//IL_02bb: Unknown result type (might be due to invalid IL or missing references)
			//IL_02d4: Unknown result type (might be due to invalid IL or missing references)
			//IL_02d9: Unknown result type (might be due to invalid IL or missing references)
			//IL_02e4: Unknown result type (might be due to invalid IL or missing references)
			//IL_02e9: Unknown result type (might be due to invalid IL or missing references)
			//IL_0300: Unknown result type (might be due to invalid IL or missing references)
			//IL_0305: Unknown result type (might be due to invalid IL or missing references)
			//IL_0316: Unknown result type (might be due to invalid IL or missing references)
			//IL_03f0: Unknown result type (might be due to invalid IL or missing references)
			//IL_048a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0564: Unknown result type (might be due to invalid IL or missing references)
			//IL_0574: Unknown result type (might be due to invalid IL or missing references)
			//IL_0590: Unknown result type (might be due to invalid IL or missing references)
			//IL_05a8: Unknown result type (might be due to invalid IL or missing references)
			//IL_05c4: Unknown result type (might be due to invalid IL or missing references)
			//IL_0639: Unknown result type (might be due to invalid IL or missing references)
			//IL_063e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0640: Unknown result type (might be due to invalid IL or missing references)
			//IL_0642: Unknown result type (might be due to invalid IL or missing references)
			//IL_0650: Unknown result type (might be due to invalid IL or missing references)
			//IL_0655: Unknown result type (might be due to invalid IL or missing references)
			//IL_0668: Unknown result type (might be due to invalid IL or missing references)
			//IL_067a: Unknown result type (might be due to invalid IL or missing references)
			//IL_06a0: Unknown result type (might be due to invalid IL or missing references)
			//IL_06bc: Unknown result type (might be due to invalid IL or missing references)
			//IL_06ce: Unknown result type (might be due to invalid IL or missing references)
			//IL_06dd: Unknown result type (might be due to invalid IL or missing references)
			//IL_06ea: Unknown result type (might be due to invalid IL or missing references)
			//IL_087d: Unknown result type (might be due to invalid IL or missing references)
			//IL_08ad: Unknown result type (might be due to invalid IL or missing references)
			//IL_08f5: Unknown result type (might be due to invalid IL or missing references)
			//IL_08fa: Unknown result type (might be due to invalid IL or missing references)
			//IL_0910: Unknown result type (might be due to invalid IL or missing references)
			//IL_0947: Unknown result type (might be due to invalid IL or missing references)
			//IL_094c: Unknown result type (might be due to invalid IL or missing references)
			//IL_095b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0974: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			CurrentPageService currentPageService = _003C_003E4__this;
			UIViewModel result;
			try
			{
				TaskAwaiter<LoadComponentScriptsResult> val2;
				TaskAwaiter<RenderComponentModel> val;
				LoadComponentScriptsResult result2;
				RenderComponentModel result3;
				UIViewModel obj2;
				bool flag;
				Guid val3 = default(Guid);
				LoadComponentScriptsResult result4;
				switch (num)
				{
				default:
					if (currentPageService.CheckRecursiveError(parentItemUid, componentViewItem.Uid, viewMode))
					{
						result = null;
					}
					else
					{
						if (!(componentViewItem.Name == ExtensionPointViewItem.SystemGenericComponentKey))
						{
							goto IL_007b;
						}
						UIViewModel implementationModel = currentPageService.GetImplementationModel(componentViewItem);
						if (implementationModel == null)
						{
							goto IL_007b;
						}
						result = implementationModel;
					}
					goto end_IL_000e;
				case 0:
					val = (TaskAwaiter<RenderComponentModel>)_003C_003Eu__1;
					_003C_003Eu__1 = null;
					num = (_003C_003E1__state = -1);
					goto IL_011e;
				case 1:
					val2 = (TaskAwaiter<LoadComponentScriptsResult>)_003C_003Eu__1;
					_003C_003Eu__1 = null;
					num = (_003C_003E1__state = -1);
					goto IL_03ca;
				case 2:
					val2 = (TaskAwaiter<LoadComponentScriptsResult>)_003C_003Eu__1;
					_003C_003Eu__1 = null;
					num = (_003C_003E1__state = -1);
					goto IL_053e;
				case 3:
					{
						val = (TaskAwaiter<RenderComponentModel>)_003C_003Eu__1;
						_003C_003Eu__1 = null;
						num = (_003C_003E1__state = -1);
						break;
					}
					IL_03ca:
					result2 = val2.GetResult();
					if (result2 != null)
					{
						currentPageService.UpdateEntityDependencies(result2.EntityDependencies);
					}
					goto IL_03e4;
					IL_011e:
					result3 = val.GetResult();
					flag = true;
					currentPageService.model.Fill(result3, !flag);
					if (currentPageService.model.IsEmpty)
					{
						result = null;
					}
					else
					{
						ClientComponentModel header = currentPageService.model.Header;
						Guid moduleItemUid = header.get_ModuleItemUid();
						if (moduleItemUid == Guid.Empty)
						{
							moduleItemUid = header.get_ItemUid();
							currentPageService.model.RenderComponentCache.set_Item(_003CrenderUid_003E5__2, moduleItemUid);
							currentPageService.model.ComponentCache.set_Item(moduleItemUid, header);
							UIViewModel obj = CreateUiModel(currentPageService.componentMetadataItemManager.Load(moduleItemUid));
							obj.get_Dependencies().AddRange((System.Collections.Generic.IEnumerable<Guid>)Enumerable.Select<ClientDataClassModel, Guid>((System.Collections.Generic.IEnumerable<ClientDataClassModel>)result3.Header.get_DataClasses(), (Func<ClientDataClassModel, Guid>)((ClientDataClassModel a) => a.get_HeaderUid())));
							obj.get_Dependencies().AddRange((System.Collections.Generic.IEnumerable<Guid>)Enumerable.Select<EntityDependency, Guid>((System.Collections.Generic.IEnumerable<EntityDependency>)currentPageService.model.EntityDependencies, (Func<EntityDependency, Guid>)((EntityDependency a) => ((Dependency)a).get_HeaderUid())));
							result = obj;
						}
						else
						{
							currentPageService.model.RenderComponentCache.set_Item(_003CrenderUid_003E5__2, moduleItemUid);
							currentPageService.model.ComponentCache.set_Item(moduleItemUid, header);
							result = CreateUiModel(currentPageService.moduleMetadataItemManager.Load(moduleItemUid), componentViewItem.HeaderUid);
						}
					}
					goto end_IL_000e;
					IL_0558:
					result = CreateUiModel(currentPageService.moduleMetadataItemManager.Load(_003C_003E8__1.itemUid), componentViewItem.HeaderUid);
					goto end_IL_000e;
					IL_03e4:
					obj2 = CreateUiModel(currentPageService.componentMetadataItemManager.Load(_003C_003E8__1.itemUid));
					obj2.get_Dependencies().AddRange((System.Collections.Generic.IEnumerable<Guid>)Enumerable.Select<ClientDataClassModel, Guid>((System.Collections.Generic.IEnumerable<ClientDataClassModel>)currentPageService.model.Header.get_DataClasses(), (Func<ClientDataClassModel, Guid>)((ClientDataClassModel a) => a.get_HeaderUid())));
					obj2.get_Dependencies().AddRange((System.Collections.Generic.IEnumerable<Guid>)Enumerable.Select<EntityDependency, Guid>((System.Collections.Generic.IEnumerable<EntityDependency>)currentPageService.model.EntityDependencies, (Func<EntityDependency, Guid>)((EntityDependency a) => ((Dependency)a).get_HeaderUid())));
					result = obj2;
					goto end_IL_000e;
					IL_007b:
					_003CrenderUid_003E5__2 = GenerateRenderUid(parentItemUid, componentViewItem.Uid);
					if (currentPageService.model.IsEmpty | clearCache)
					{
						flag = false;
						val = currentPageService.findComponentService.FindComponent(componentViewItem.HeaderUid, viewMode).GetAwaiter();
						if (!val.get_IsCompleted())
						{
							num = (_003C_003E1__state = 0);
							_003C_003Eu__1 = val;
							_003C_003Et__builder.AwaitOnCompleted<TaskAwaiter<RenderComponentModel>, _003CLoadComponentMetadataItemInternal_003Ed__20>(ref val, ref this);
							return;
						}
						goto IL_011e;
					}
					if (currentPageService.model.RenderComponentCache.TryGetValue(_003CrenderUid_003E5__2, ref val3))
					{
						_003C_003E8__1 = new _003C_003Ec__DisplayClass20_0();
						ClientComponentModel val4 = default(ClientComponentModel);
						if (currentPageService.model.ComponentCache.TryGetValue(val3, ref val4))
						{
							_003C_003E8__1.itemUid = val4.get_ModuleItemUid();
							if (_003C_003E8__1.itemUid == Guid.Empty)
							{
								_003C_003E8__1.itemUid = val4.get_ItemUid();
								if (!currentPageService.componentMetadataItemManager.CheckItem(_003C_003E8__1.itemUid))
								{
									EnumerableInstance<ClientComponentModel> componentModels = Enumerable.Where<KeyValuePair<Guid, ClientComponentModel>>((System.Collections.Generic.IEnumerable<KeyValuePair<Guid, ClientComponentModel>>)currentPageService.model.ComponentCache, (Func<KeyValuePair<Guid, ClientComponentModel>, bool>)delegate(KeyValuePair<Guid, ClientComponentModel> a)
									{
										//IL_0002: Unknown result type (might be due to invalid IL or missing references)
										//IL_0008: Unknown result type (might be due to invalid IL or missing references)
										//IL_002d: Unknown result type (might be due to invalid IL or missing references)
										if (a.get_Key() == _003C_003E8__1.itemUid)
										{
											return true;
										}
										ClientComponentModel value2 = a.get_Value();
										return !value2.get_Async() && value2.get_Owners().Contains(_003C_003E8__1.itemUid);
									}).Select<ClientComponentModel>((Func<KeyValuePair<Guid, ClientComponentModel>, ClientComponentModel>)((KeyValuePair<Guid, ClientComponentModel> a) => a.get_Value()));
									val2 = currentPageService.findComponentService.LoadRuntimeMetadata((System.Collections.Generic.IEnumerable<ClientComponentModel>)componentModels).GetAwaiter();
									if (!val2.get_IsCompleted())
									{
										num = (_003C_003E1__state = 1);
										_003C_003Eu__1 = val2;
										_003C_003Et__builder.AwaitOnCompleted<TaskAwaiter<LoadComponentScriptsResult>, _003CLoadComponentMetadataItemInternal_003Ed__20>(ref val2, ref this);
										return;
									}
									goto IL_03ca;
								}
								goto IL_03e4;
							}
							if (!currentPageService.moduleMetadataItemManager.CheckItem(_003C_003E8__1.itemUid))
							{
								EnumerableInstance<ClientComponentModel> componentModels2 = Enumerable.Where<KeyValuePair<Guid, ClientComponentModel>>((System.Collections.Generic.IEnumerable<KeyValuePair<Guid, ClientComponentModel>>)currentPageService.model.ComponentCache, (Func<KeyValuePair<Guid, ClientComponentModel>, bool>)delegate(KeyValuePair<Guid, ClientComponentModel> a)
								{
									//IL_0002: Unknown result type (might be due to invalid IL or missing references)
									//IL_0008: Unknown result type (might be due to invalid IL or missing references)
									//IL_002d: Unknown result type (might be due to invalid IL or missing references)
									if (a.get_Key() == _003C_003E8__1.itemUid)
									{
										return true;
									}
									ClientComponentModel value = a.get_Value();
									return !value.get_Async() && value.get_Owners().Contains(_003C_003E8__1.itemUid);
								}).Select<ClientComponentModel>((Func<KeyValuePair<Guid, ClientComponentModel>, ClientComponentModel>)((KeyValuePair<Guid, ClientComponentModel> a) => a.get_Value()));
								val2 = currentPageService.findComponentService.LoadRuntimeMetadata((System.Collections.Generic.IEnumerable<ClientComponentModel>)componentModels2).GetAwaiter();
								if (!val2.get_IsCompleted())
								{
									num = (_003C_003E1__state = 2);
									_003C_003Eu__1 = val2;
									_003C_003Et__builder.AwaitOnCompleted<TaskAwaiter<LoadComponentScriptsResult>, _003CLoadComponentMetadataItemInternal_003Ed__20>(ref val2, ref this);
									return;
								}
								goto IL_053e;
							}
							goto IL_0558;
						}
						result = null;
					}
					else
					{
						ModuleMetadataItem val5 = currentPageService.findComponentService.TryFindModuleByComponentHeaderUid(componentViewItem.HeaderUid);
						if (val5 == null)
						{
							val = currentPageService.findComponentService.FindComponent(componentViewItem.HeaderUid, viewMode).GetAwaiter();
							if (!val.get_IsCompleted())
							{
								num = (_003C_003E1__state = 3);
								_003C_003Eu__1 = val;
								_003C_003Et__builder.AwaitOnCompleted<TaskAwaiter<RenderComponentModel>, _003CLoadComponentMetadataItemInternal_003Ed__20>(ref val, ref this);
								return;
							}
							break;
						}
						result = CreateUiModel(val5, componentViewItem.HeaderUid);
					}
					goto end_IL_000e;
					IL_053e:
					result4 = val2.GetResult();
					if (result4 != null)
					{
						currentPageService.UpdateEntityDependencies(result4.EntityDependencies);
					}
					goto IL_0558;
				}
				RenderComponentModel result5 = val.GetResult();
				ClientComponentModel header2 = result5.Header;
				Guid moduleItemUid2 = header2.get_ModuleItemUid();
				if (moduleItemUid2 == Guid.Empty)
				{
					moduleItemUid2 = header2.get_ItemUid();
					currentPageService.model.RenderComponentCache.set_Item(_003CrenderUid_003E5__2, moduleItemUid2);
					currentPageService.model.ComponentCache.set_Item(moduleItemUid2, header2);
					currentPageService.model.ExtensionPoints.AddRange((System.Collections.Generic.IEnumerable<ClientExtensionPointModel>)result5.ExtensionPoints);
					ComponentMetadataItem component = currentPageService.componentMetadataItemManager.Load(moduleItemUid2);
					if (viewMode != InterfaceBuilderViewMode.Design)
					{
						System.Collections.Generic.IEnumerator<EntityDependency> enumerator = ((System.Collections.Generic.IEnumerable<EntityDependency>)result5.EntityDependencies).GetEnumerator();
						try
						{
							while (((System.Collections.IEnumerator)enumerator).MoveNext())
							{
								_003C_003Ec__DisplayClass20_1 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass20_1();
								CS_0024_003C_003E8__locals0.entityDependency = enumerator.get_Current();
								EntityDependency val6 = Enumerable.FirstOrDefault<EntityDependency>((System.Collections.Generic.IEnumerable<EntityDependency>)currentPageService.model.EntityDependencies, (Func<EntityDependency, bool>)((EntityDependency a) => ((Dependency)a).get_HeaderUid() == ((Dependency)CS_0024_003C_003E8__locals0.entityDependency).get_HeaderUid()));
								if (val6 == null)
								{
									val6 = CS_0024_003C_003E8__locals0.entityDependency;
									currentPageService.model.EntityDependencies.Add(CS_0024_003C_003E8__locals0.entityDependency);
								}
								else
								{
									System.Collections.Generic.IEnumerator<PropertySignature> enumerator2 = ((System.Collections.Generic.IEnumerable<PropertySignature>)((ClassDependency)CS_0024_003C_003E8__locals0.entityDependency).get_Properties()).GetEnumerator();
									try
									{
										while (((System.Collections.IEnumerator)enumerator2).MoveNext())
										{
											_003C_003Ec__DisplayClass20_2 CS_0024_003C_003E8__locals1 = new _003C_003Ec__DisplayClass20_2();
											CS_0024_003C_003E8__locals1.property = enumerator2.get_Current();
											if (Enumerable.FirstOrDefault<PropertySignature>((System.Collections.Generic.IEnumerable<PropertySignature>)((ClassDependency)val6).get_Properties(), (Func<PropertySignature, bool>)((PropertySignature a) => a.get_Uid() == CS_0024_003C_003E8__locals1.property.get_Uid())) != null)
											{
												continue;
											}
											if (CS_0024_003C_003E8__locals1.property.get_Name() == "Uid")
											{
												PropertySignature val7 = Enumerable.FirstOrDefault<PropertySignature>((System.Collections.Generic.IEnumerable<PropertySignature>)((ClassDependency)val6).get_Properties(), (Func<PropertySignature, bool>)((PropertySignature a) => a.get_Name() == "Uid"));
												if (val7 != null)
												{
													((ClassDependency)val6).get_Properties().Remove(val7);
												}
											}
											((ClassDependency)val6).get_Properties().Add(CS_0024_003C_003E8__locals1.property);
										}
									}
									finally
									{
										if (num < 0)
										{
											((System.IDisposable)enumerator2)?.Dispose();
										}
									}
								}
								if (Enumerable.FirstOrDefault<PropertySignature>((System.Collections.Generic.IEnumerable<PropertySignature>)((ClassDependency)val6).get_Properties(), (Func<PropertySignature, bool>)((PropertySignature a) => a.get_Name() == "Uid")) == null)
								{
									TypeSignature val8 = InterfaceCreator.Create<TypeSignature>();
									val8.set_TypeUid(GuidDescriptor.UID);
									val8.set_Nullable(false);
									PropertySignature val9 = InterfaceCreator.Create<PropertySignature>();
									val9.set_Name("Uid");
									val9.set_Type(val8);
									val9.set_Uid(Guid.NewGuid());
									((ClassDependency)val6).get_Properties().Add(val9);
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
					}
					System.Collections.Generic.IEnumerator<KeyValuePair<string, Guid>> enumerator3 = ((System.Collections.Generic.IEnumerable<KeyValuePair<string, Guid>>)result5.RenderComponentCache).GetEnumerator();
					try
					{
						while (((System.Collections.IEnumerator)enumerator3).MoveNext())
						{
							KeyValuePair<string, Guid> current = enumerator3.get_Current();
							currentPageService.model.RenderComponentCache.set_Item(current.get_Key(), current.get_Value());
						}
					}
					finally
					{
						if (num < 0)
						{
							((System.IDisposable)enumerator3)?.Dispose();
						}
					}
					System.Collections.Generic.IEnumerator<KeyValuePair<Guid, ClientComponentModel>> enumerator4 = ((System.Collections.Generic.IEnumerable<KeyValuePair<Guid, ClientComponentModel>>)result5.ComponentCache).GetEnumerator();
					try
					{
						while (((System.Collections.IEnumerator)enumerator4).MoveNext())
						{
							KeyValuePair<Guid, ClientComponentModel> current2 = enumerator4.get_Current();
							if (!currentPageService.model.ComponentCache.ContainsKey(current2.get_Key()))
							{
								currentPageService.model.ComponentCache.Add(current2.get_Key(), current2.get_Value());
							}
						}
					}
					finally
					{
						if (num < 0)
						{
							((System.IDisposable)enumerator4)?.Dispose();
						}
					}
					UIViewModel obj3 = CreateUiModel(component);
					obj3.get_Dependencies().AddRange((System.Collections.Generic.IEnumerable<Guid>)Enumerable.Select<ClientDataClassModel, Guid>((System.Collections.Generic.IEnumerable<ClientDataClassModel>)currentPageService.model.Header.get_DataClasses(), (Func<ClientDataClassModel, Guid>)((ClientDataClassModel a) => a.get_HeaderUid())));
					obj3.get_Dependencies().AddRange((System.Collections.Generic.IEnumerable<Guid>)Enumerable.Select<EntityDependency, Guid>((System.Collections.Generic.IEnumerable<EntityDependency>)currentPageService.model.EntityDependencies, (Func<EntityDependency, Guid>)((EntityDependency a) => ((Dependency)a).get_HeaderUid())));
					result = obj3;
				}
				else
				{
					currentPageService.model.RenderComponentCache.set_Item(_003CrenderUid_003E5__2, moduleItemUid2);
					currentPageService.model.ComponentCache.set_Item(moduleItemUid2, header2);
					result = CreateUiModel(currentPageService.moduleMetadataItemManager.Load(moduleItemUid2), componentViewItem.HeaderUid);
				}
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

	private sealed class _003C_003Ec__DisplayClass25_0
	{
		public Guid moduleUid;

		internal System.Threading.Tasks.Task _003CSetCurrentPageUidAsync_003Eb__0(IModuleInit el)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			return el.Init(moduleUid);
		}
	}

	[StructLayout(3)]
	private struct _003CSetCurrentPageUidAsync_003Ed__25 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public Guid moduleUid;

		public CurrentPageService _003C_003E4__this;

		public Guid uid;

		public Guid typeUid;

		public InterfaceBuilderViewMode viewMode;

		private IMetadata _003Cmetadata_003E5__2;

		private object _003C_003Eu__1;

		private ComponentViewItem _003CcomponentViewItem_003E5__3;

		private void MoveNext()
		{
			//IL_001a: Unknown result type (might be due to invalid IL or missing references)
			//IL_001f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0058: Unknown result type (might be due to invalid IL or missing references)
			//IL_006a: Unknown result type (might be due to invalid IL or missing references)
			//IL_006f: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ea: Expected O, but got Unknown
			//IL_0101: Unknown result type (might be due to invalid IL or missing references)
			//IL_0106: Unknown result type (might be due to invalid IL or missing references)
			//IL_014f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0177: Unknown result type (might be due to invalid IL or missing references)
			//IL_0190: Unknown result type (might be due to invalid IL or missing references)
			//IL_0198: Unknown result type (might be due to invalid IL or missing references)
			//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
			//IL_02d3: Unknown result type (might be due to invalid IL or missing references)
			//IL_02d8: Unknown result type (might be due to invalid IL or missing references)
			//IL_02f5: Unknown result type (might be due to invalid IL or missing references)
			//IL_03af: Unknown result type (might be due to invalid IL or missing references)
			//IL_03b4: Unknown result type (might be due to invalid IL or missing references)
			//IL_03d1: Unknown result type (might be due to invalid IL or missing references)
			//IL_0498: Unknown result type (might be due to invalid IL or missing references)
			//IL_049e: Unknown result type (might be due to invalid IL or missing references)
			//IL_04ab: Unknown result type (might be due to invalid IL or missing references)
			//IL_04bc: Unknown result type (might be due to invalid IL or missing references)
			//IL_04cd: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			CurrentPageService currentPageService = _003C_003E4__this;
			try
			{
				_003C_003Ec__DisplayClass25_0 _003C_003Ec__DisplayClass25_ = default(_003C_003Ec__DisplayClass25_0);
				if ((uint)num > 3u)
				{
					_003C_003Ec__DisplayClass25_ = new _003C_003Ec__DisplayClass25_0();
					_003C_003Ec__DisplayClass25_.moduleUid = moduleUid;
					currentPageService.loaderService.Show("LoadContentKey", SR.T("Загрузка данных для отображения"), permanent: true);
				}
				try
				{
					TaskAwaiter val4;
					TaskAwaiter<UIViewModel> val3;
					TaskAwaiter<DataClassMetadataItem> val2;
					TaskAwaiter<FunctionMetadataItem> val;
					FunctionMetadataItem result;
					UIViewModel result2;
					DataClassMetadataItem result3;
					switch (num)
					{
					default:
						currentPageService.SetModuleUid(_003C_003Ec__DisplayClass25_.moduleUid);
						_003Cmetadata_003E5__2 = null;
						if (uid == Guid.Empty)
						{
							currentPageService.CurrentPageViewModel.ViewMode = InterfaceBuilderViewMode.Runtime;
							break;
						}
						val4 = System.Threading.Tasks.Task.WhenAll(Enumerable.Select<IModuleInit, System.Threading.Tasks.Task>(currentPageService.moduleInits, (Func<IModuleInit, System.Threading.Tasks.Task>)_003C_003Ec__DisplayClass25_._003CSetCurrentPageUidAsync_003Eb__0).ToArray()).GetAwaiter();
						if (!val4.get_IsCompleted())
						{
							num = (_003C_003E1__state = 0);
							_003C_003Eu__1 = val4;
							((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitOnCompleted<TaskAwaiter, _003CSetCurrentPageUidAsync_003Ed__25>(ref val4, ref this);
							return;
						}
						goto IL_00fa;
					case 0:
						val4 = (TaskAwaiter)_003C_003Eu__1;
						_003C_003Eu__1 = null;
						num = (_003C_003E1__state = -1);
						goto IL_00fa;
					case 1:
						val3 = (TaskAwaiter<UIViewModel>)_003C_003Eu__1;
						_003C_003Eu__1 = null;
						num = (_003C_003E1__state = -1);
						goto IL_0234;
					case 2:
						val2 = (TaskAwaiter<DataClassMetadataItem>)_003C_003Eu__1;
						_003C_003Eu__1 = null;
						num = (_003C_003E1__state = -1);
						goto IL_0350;
					case 3:
						{
							val = (TaskAwaiter<FunctionMetadataItem>)_003C_003Eu__1;
							_003C_003Eu__1 = null;
							num = (_003C_003E1__state = -1);
							goto IL_042c;
						}
						IL_042c:
						result = val.GetResult();
						_003Cmetadata_003E5__2 = (IMetadata)(object)((result != null) ? result.get_Metadata() : null);
						currentPageService.CurrentPageViewModel.ViewItem = null;
						currentPageService.CurrentPageViewModel.ServerScriptModule = ((result != null) ? result.get_ScriptModule() : null);
						currentPageService.CurrentPageViewModel.ClientScriptModule = null;
						currentPageService.CurrentPageViewModel.ViewScriptModule = null;
						currentPageService.CurrentPageViewModel.TestScriptModule = null;
						break;
						IL_0234:
						result2 = val3.GetResult();
						_003Cmetadata_003E5__2 = ((result2 != null) ? result2.get_Metadata() : null);
						currentPageService.CurrentPageViewModel.ViewItem = _003CcomponentViewItem_003E5__3;
						currentPageService.CurrentPageViewModel.ServerScriptModule = ((result2 != null) ? result2.get_ServerScriptModule() : null);
						currentPageService.CurrentPageViewModel.ClientScriptModule = ((result2 != null) ? result2.get_ClientScriptModule() : null);
						currentPageService.CurrentPageViewModel.ViewScriptModule = ((result2 != null) ? result2.get_ViewScriptModule() : null);
						currentPageService.CurrentPageViewModel.TestScriptModule = ((result2 != null) ? result2.get_TestScriptModule() : null);
						_003CcomponentViewItem_003E5__3 = null;
						break;
						IL_0350:
						result3 = val2.GetResult();
						_003Cmetadata_003E5__2 = (IMetadata)(object)((result3 != null) ? result3.get_Metadata() : null);
						currentPageService.CurrentPageViewModel.ViewItem = null;
						currentPageService.CurrentPageViewModel.ServerScriptModule = null;
						currentPageService.CurrentPageViewModel.ClientScriptModule = null;
						currentPageService.CurrentPageViewModel.ViewScriptModule = null;
						currentPageService.CurrentPageViewModel.TestScriptModule = null;
						break;
						IL_00fa:
						val4.GetResult();
						if (typeUid == MetadataConstants.ComponentMetadataTypeUid)
						{
							if (currentPageService.CurrentPageViewModel.ViewMode == InterfaceBuilderViewMode.Emulation || currentPageService.CurrentPageViewModel.ViewMode == InterfaceBuilderViewMode.Runtime)
							{
								if (currentPageService.CurrentPageViewModel.Metadata != null)
								{
									currentPageService.componentMetadataItemManager.RemoveFromCache(InterfaceBuilderViewMode.Emulation, currentPageService.CurrentPageViewModel.Metadata.get_Uid());
								}
								currentPageService.ClearComponentCacheItems();
							}
							_003CcomponentViewItem_003E5__3 = currentPageService.reactiveModelFactory.CreateModel<ComponentViewItem>();
							_003CcomponentViewItem_003E5__3.HeaderUid = uid;
							_003CcomponentViewItem_003E5__3.Uid = ((viewMode == InterfaceBuilderViewMode.Design) ? uid : Guid.NewGuid());
							_003CcomponentViewItem_003E5__3.ViewMode = viewMode;
							_003CcomponentViewItem_003E5__3.Theme = ViewItemTheme.Light;
							_003CcomponentViewItem_003E5__3.FocusableType = FocusableType.Default;
							val3 = currentPageService.LoadComponentMetadataItem(Guid.Empty, _003CcomponentViewItem_003E5__3, viewMode, clearCache: true).GetAwaiter();
							if (!val3.get_IsCompleted())
							{
								num = (_003C_003E1__state = 1);
								_003C_003Eu__1 = val3;
								((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitOnCompleted<TaskAwaiter<UIViewModel>, _003CSetCurrentPageUidAsync_003Ed__25>(ref val3, ref this);
								return;
							}
							goto IL_0234;
						}
						if (typeUid == MetadataConstants.DataClassMetadataTypeUid)
						{
							viewMode = InterfaceBuilderViewMode.Design;
							val2 = currentPageService.dataClassMetadataItemManager.LoadOrNull(uid).GetAwaiter();
							if (!val2.get_IsCompleted())
							{
								num = (_003C_003E1__state = 2);
								_003C_003Eu__1 = val2;
								((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitOnCompleted<TaskAwaiter<DataClassMetadataItem>, _003CSetCurrentPageUidAsync_003Ed__25>(ref val2, ref this);
								return;
							}
							goto IL_0350;
						}
						if (!(typeUid == MetadataConstants.FunctionMetadataTypeUid))
						{
							break;
						}
						viewMode = InterfaceBuilderViewMode.Design;
						val = currentPageService.functionMetadataItemManager.LoadOrNull(uid).GetAwaiter();
						if (!val.get_IsCompleted())
						{
							num = (_003C_003E1__state = 3);
							_003C_003Eu__1 = val;
							((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitOnCompleted<TaskAwaiter<FunctionMetadataItem>, _003CSetCurrentPageUidAsync_003Ed__25>(ref val, ref this);
							return;
						}
						goto IL_042c;
					}
					if (currentPageService.CurrentPageViewModel.Uid != uid)
					{
						currentPageService.SetCurrentPartialViewItemUid(Guid.Empty);
					}
					currentPageService.CurrentPageViewModel.Uid = uid;
					currentPageService.CurrentPageViewModel.TypeUid = typeUid;
					currentPageService.CurrentPageViewModel.ViewMode = viewMode;
					currentPageService.SetCurrentMetadata(_003Cmetadata_003E5__2);
					_003Cmetadata_003E5__2 = null;
				}
				finally
				{
					if (num < 0)
					{
						currentPageService.loaderService.Hide("LoadContentKey");
					}
				}
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
	private struct _003CSetScriptVisible_003Ed__29 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public bool value;

		public CurrentPageService _003C_003E4__this;

		public CodeType codeType;

		private object _003C_003Eu__1;

		private void MoveNext()
		{
			//IL_0110: Unknown result type (might be due to invalid IL or missing references)
			//IL_0117: Expected O, but got Unknown
			int num = _003C_003E1__state;
			CurrentPageService currentPageService = _003C_003E4__this;
			try
			{
				TaskAwaiter val;
				if (num == 0)
				{
					val = (TaskAwaiter)_003C_003Eu__1;
					_003C_003Eu__1 = null;
					num = (_003C_003E1__state = -1);
					goto IL_0127;
				}
				if (value)
				{
					ScriptMethodInfo scriptMethodInfo = ScriptMethodInfoHelper.Deserialize(currentPageService.CurrentPageViewModel.MethodName);
					if (currentPageService.CurrentPageViewModel.OverrideInitWorkspace)
					{
						InitWorkspaceParams val2 = InterfaceCreator.Create<InitWorkspaceParams>();
						val2.set_CodeType((int)codeType);
						val2.set_MethodName(scriptMethodInfo.Name);
						currentPageService.CurrentPageViewModel.InitParams = val2;
						currentPageService.CurrentPageViewModel.ScriptEditorReady = false;
						goto IL_012e;
					}
					IOmniSharpManager omniSharpManager = currentPageService.omniSharpManager;
					IMetadata metadata = currentPageService.CurrentPageViewModel.Metadata;
					val = omniSharpManager.InitWorkspace((NamedMetadata)(object)((metadata is NamedMetadata) ? metadata : null), currentPageService.CurrentPageViewModel.ClientScriptModule, currentPageService.CurrentPageViewModel.ViewScriptModule, currentPageService.CurrentPageViewModel.ServerScriptModule, currentPageService.CurrentPageViewModel.TestScriptModule, codeType, scriptMethodInfo.Name).GetAwaiter();
					if (!val.get_IsCompleted())
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = val;
						((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitOnCompleted<TaskAwaiter, _003CSetScriptVisible_003Ed__29>(ref val, ref this);
						return;
					}
					goto IL_0127;
				}
				currentPageService.CurrentPageViewModel.InitParams = null;
				goto end_IL_000e;
				IL_012e:
				currentPageService.CurrentPageViewModel.MethodName = null;
				goto end_IL_000e;
				IL_0127:
				val.GetResult();
				goto IL_012e;
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

	private sealed class _003C_003Ec__DisplayClass32_0
	{
		public Guid functionHeaderUid;

		internal bool _003CGetFunctionItemUid_003Eb__0(ClientFunctionModel q)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			return q.get_HeaderUid() == functionHeaderUid;
		}
	}

	private sealed class _003C_003Ec__DisplayClass37_0
	{
		public string pointId;

		public Guid typeUid;

		public CurrentPageService _003C_003E4__this;

		internal bool _003CGetExtensionPointImplementations_003Eb__0(ClientExtensionPointModel e)
		{
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0023: Unknown result type (might be due to invalid IL or missing references)
			if ((e.get_PointId() ?? "") == pointId)
			{
				return e.get_TypeUid() == typeUid;
			}
			return false;
		}

		internal RenderExtensionPointModel _003CGetExtensionPointImplementations_003Eb__1(ClientImplementationModel i)
		{
			//IL_000e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_003e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0043: Unknown result type (might be due to invalid IL or missing references)
			//IL_0081: Unknown result type (might be due to invalid IL or missing references)
			ComponentMetadata componentMetadata = null;
			ComponentMetadataItem val = _003C_003E4__this.componentMetadataItemManager.LoadOrNull(i.get_ItemUid());
			if (val == null)
			{
				ModuleMetadataItem val2 = _003C_003E4__this.moduleMetadataItemManager.LoadOrNull(i.get_ModuleItemUid());
				if (val2 != null)
				{
					_003C_003Ec__DisplayClass37_1 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass37_1();
					CS_0024_003C_003E8__locals0.headerId = i.get_HeaderUid();
					componentMetadata = Enumerable.FirstOrDefault<ComponentMetadata>((System.Collections.Generic.IEnumerable<ComponentMetadata>)val2.get_Metadata().get_Components(), (Func<ComponentMetadata, bool>)((ComponentMetadata c) => ((IMetadata)c).get_Uid() == CS_0024_003C_003E8__locals0.headerId));
				}
			}
			else
			{
				componentMetadata = val.get_Metadata();
			}
			return new RenderExtensionPointModel
			{
				PointId = pointId,
				TypeUid = typeUid,
				Implementation = i,
				ComponentMetadata = componentMetadata
			};
		}
	}

	private sealed class _003C_003Ec__DisplayClass37_1
	{
		public Guid headerId;

		internal bool _003CGetExtensionPointImplementations_003Eb__2(ComponentMetadata c)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			return ((IMetadata)c).get_Uid() == headerId;
		}
	}

	private sealed class _003C_003Ec__DisplayClass40_0
	{
		public IMetadata metadata;

		internal bool _003CSaveAndUpdate_003Eb__0(IUpdateMetadataHandler a)
		{
			return a.Check(metadata);
		}
	}

	[StructLayout(3)]
	private struct _003CSaveAndUpdate_003Ed__40 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public CurrentPageService _003C_003E4__this;

		private _003C_003Ec__DisplayClass40_0 _003C_003E8__1;

		private object _003C_003Eu__1;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			CurrentPageService currentPageService = _003C_003E4__this;
			try
			{
				TaskAwaiter<IUpdateModel> val;
				if (num == 0)
				{
					val = (TaskAwaiter<IUpdateModel>)_003C_003Eu__1;
					_003C_003Eu__1 = null;
					num = (_003C_003E1__state = -1);
					goto IL_0116;
				}
				_003C_003E8__1 = new _003C_003Ec__DisplayClass40_0();
				_003C_003E8__1.metadata = currentPageService.CurrentPageViewModel.Metadata;
				if (_003C_003E8__1.metadata != null)
				{
					IUpdateMetadataHandler updateMetadataHandler = Enumerable.FirstOrDefault<IUpdateMetadataHandler>(currentPageService.updateMetadataHandlers, (Func<IUpdateMetadataHandler, bool>)((IUpdateMetadataHandler a) => a.Check(_003C_003E8__1.metadata)));
					if (updateMetadataHandler != null)
					{
						UpdateModel updateModel = new UpdateModel(_003C_003E8__1.metadata)
						{
							ServerScriptModule = currentPageService.CurrentPageViewModel.ServerScriptModule,
							ClientScriptModule = currentPageService.CurrentPageViewModel.ClientScriptModule,
							ViewScriptModule = currentPageService.CurrentPageViewModel.ViewScriptModule,
							TestScriptModule = currentPageService.CurrentPageViewModel.TestScriptModule
						};
						val = updateMetadataHandler.SaveAndUpdate(updateModel).GetAwaiter();
						if (!val.get_IsCompleted())
						{
							num = (_003C_003E1__state = 0);
							_003C_003Eu__1 = val;
							((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitOnCompleted<TaskAwaiter<IUpdateModel>, _003CSaveAndUpdate_003Ed__40>(ref val, ref this);
							return;
						}
						goto IL_0116;
					}
				}
				goto end_IL_000e;
				IL_0116:
				IUpdateModel result = val.GetResult();
				currentPageService.UpdateScriptModules(result);
				MetadataTrackChangesHelper.FillOldMetadata(_003C_003E8__1.metadata);
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

	private sealed class _003C_003Ec__DisplayClass41_0
	{
		public IMetadata metadata;

		internal bool _003CSaveAndPublish_003Eb__0(IUpdateMetadataHandler a)
		{
			return a.Check(metadata);
		}
	}

	[StructLayout(3)]
	private struct _003CSaveAndPublish_003Ed__41 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public CurrentPageService _003C_003E4__this;

		public InterfaceBuilderViewMode viewMode;

		private _003C_003Ec__DisplayClass41_0 _003C_003E8__1;

		private object _003C_003Eu__1;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			CurrentPageService currentPageService = _003C_003E4__this;
			try
			{
				TaskAwaiter<IUpdateModel> val;
				if (num == 0)
				{
					val = (TaskAwaiter<IUpdateModel>)_003C_003Eu__1;
					_003C_003Eu__1 = null;
					num = (_003C_003E1__state = -1);
					goto IL_0122;
				}
				_003C_003E8__1 = new _003C_003Ec__DisplayClass41_0();
				_003C_003E8__1.metadata = currentPageService.CurrentPageViewModel.Metadata;
				if (_003C_003E8__1.metadata != null)
				{
					IUpdateMetadataHandler updateMetadataHandler = Enumerable.FirstOrDefault<IUpdateMetadataHandler>(currentPageService.updateMetadataHandlers, (Func<IUpdateMetadataHandler, bool>)((IUpdateMetadataHandler a) => a.Check(_003C_003E8__1.metadata)));
					if (updateMetadataHandler != null)
					{
						UpdateModel updateModel = new UpdateModel(_003C_003E8__1.metadata)
						{
							ServerScriptModule = currentPageService.CurrentPageViewModel.ServerScriptModule,
							ClientScriptModule = currentPageService.CurrentPageViewModel.ClientScriptModule,
							TestScriptModule = currentPageService.CurrentPageViewModel.TestScriptModule,
							ViewScriptModule = currentPageService.CurrentPageViewModel.ViewScriptModule,
							ViewMode = viewMode
						};
						val = updateMetadataHandler.SaveAndPublish(updateModel).GetAwaiter();
						if (!val.get_IsCompleted())
						{
							num = (_003C_003E1__state = 0);
							_003C_003Eu__1 = val;
							((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitOnCompleted<TaskAwaiter<IUpdateModel>, _003CSaveAndPublish_003Ed__41>(ref val, ref this);
							return;
						}
						goto IL_0122;
					}
				}
				goto end_IL_000e;
				IL_0122:
				IUpdateModel result = val.GetResult();
				currentPageService.UpdateScriptModules(result);
				MetadataTrackChangesHelper.FillOldMetadata(_003C_003E8__1.metadata);
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

	private sealed class _003C_003Ec__DisplayClass46_0
	{
		public Guid headerUid;

		internal bool _003CCreateUiModel_003Eb__0(ComponentMetadata a)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			return ((IMetadata)a).get_Uid() == headerUid;
		}
	}

	private const string LoadContentKey = "LoadContentKey";

	private readonly System.Collections.Generic.IEnumerable<IUpdateMetadataHandler> updateMetadataHandlers;

	private readonly ComponentMetadataItemManager componentMetadataItemManager;

	private readonly DataClassMetadataItemManager dataClassMetadataItemManager;

	private readonly FunctionMetadataItemManager functionMetadataItemManager;

	private readonly FindComponentService findComponentService;

	private readonly IOmniSharpManager omniSharpManager;

	private readonly IReactiveModelFactory reactiveModelFactory;

	private readonly ModuleMetadataItemManager moduleMetadataItemManager;

	private readonly ILoaderService loaderService;

	private readonly System.Collections.Generic.IEnumerable<IModuleInit> moduleInits;

	private readonly INotValidElementStorage notValidElementStorage;

	private readonly RenderComponentModel model = new RenderComponentModel();

	private readonly IDictionary<string, int> recursiveCheck = (IDictionary<string, int>)(object)new Dictionary<string, int>();

	private readonly CurrentPageModel _003CCurrentPageViewModel_003Ek__BackingField;

	public CurrentPageModel CurrentPageViewModel => _003CCurrentPageViewModel_003Ek__BackingField;

	public CurrentPageService(System.Collections.Generic.IEnumerable<IUpdateMetadataHandler> updateMetadataHandlers, ComponentMetadataItemManager componentMetadataItemManager, DataClassMetadataItemManager dataClassMetadataItemManager, FunctionMetadataItemManager functionMetadataItemManager, FindComponentService findComponentService, IOmniSharpManager omniSharpManager, IReactiveModelFactory reactiveModelFactory, ModuleMetadataItemManager moduleMetadataItemManager, IApplicationData applicationData, ILoaderService loaderService, System.Collections.Generic.IEnumerable<IModuleInit> moduleInits, ILifetimeScope lifetimeScope)
	{
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		this.updateMetadataHandlers = updateMetadataHandlers;
		this.componentMetadataItemManager = componentMetadataItemManager;
		this.dataClassMetadataItemManager = dataClassMetadataItemManager;
		this.functionMetadataItemManager = functionMetadataItemManager;
		this.findComponentService = findComponentService;
		this.omniSharpManager = omniSharpManager;
		this.reactiveModelFactory = reactiveModelFactory;
		this.moduleMetadataItemManager = moduleMetadataItemManager;
		this.loaderService = loaderService;
		this.moduleInits = moduleInits;
		notValidElementStorage = ((IScopeContext)((ISharingLifetimeScope)lifetimeScope).get_RootLifetimeScope()).Resolve<INotValidElementStorage>();
		CurrentPageModel currentPageModel = reactiveModelFactory.CreateModel<CurrentPageModel>();
		if (applicationData.InterfaceBuilderMode == InterfaceBuilderMode.DevServer)
		{
			currentPageModel.ViewMode = InterfaceBuilderViewMode.Design;
		}
		currentPageModel.RuntimeVersion = RuntimeVersion.Version2;
		_003CCurrentPageViewModel_003Ek__BackingField = currentPageModel;
	}

	public System.Threading.Tasks.Task<DataClass> LoadClientComponentMetadataItem(Guid parentItemUid, ComponentViewItem componentViewItem, InterfaceBuilderViewMode viewMode, bool clearCache = false)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		_003CLoadClientComponentMetadataItem_003Ed__18 _003CLoadClientComponentMetadataItem_003Ed__ = default(_003CLoadClientComponentMetadataItem_003Ed__18);
		_003CLoadClientComponentMetadataItem_003Ed__._003C_003E4__this = this;
		_003CLoadClientComponentMetadataItem_003Ed__.parentItemUid = parentItemUid;
		_003CLoadClientComponentMetadataItem_003Ed__.componentViewItem = componentViewItem;
		_003CLoadClientComponentMetadataItem_003Ed__.viewMode = viewMode;
		_003CLoadClientComponentMetadataItem_003Ed__.clearCache = clearCache;
		_003CLoadClientComponentMetadataItem_003Ed__._003C_003Et__builder = AsyncTaskMethodBuilder<DataClass>.Create();
		_003CLoadClientComponentMetadataItem_003Ed__._003C_003E1__state = -1;
		AsyncTaskMethodBuilder<DataClass> _003C_003Et__builder = _003CLoadClientComponentMetadataItem_003Ed__._003C_003Et__builder;
		_003C_003Et__builder.Start<_003CLoadClientComponentMetadataItem_003Ed__18>(ref _003CLoadClientComponentMetadataItem_003Ed__);
		return _003CLoadClientComponentMetadataItem_003Ed__._003C_003Et__builder.get_Task();
	}

	public System.Threading.Tasks.Task<UIViewModel> LoadComponentMetadataItem(Guid parentItemUid, ComponentViewItem componentViewItem, InterfaceBuilderViewMode viewMode, bool clearCache = false)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		return LoadComponentMetadataItemInternal(parentItemUid, componentViewItem, viewMode, clearCache);
	}

	private System.Threading.Tasks.Task<UIViewModel> LoadComponentMetadataItemInternal(Guid parentItemUid, ComponentViewItem componentViewItem, InterfaceBuilderViewMode viewMode, bool clearCache = false)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		_003CLoadComponentMetadataItemInternal_003Ed__20 _003CLoadComponentMetadataItemInternal_003Ed__ = default(_003CLoadComponentMetadataItemInternal_003Ed__20);
		_003CLoadComponentMetadataItemInternal_003Ed__._003C_003E4__this = this;
		_003CLoadComponentMetadataItemInternal_003Ed__.parentItemUid = parentItemUid;
		_003CLoadComponentMetadataItemInternal_003Ed__.componentViewItem = componentViewItem;
		_003CLoadComponentMetadataItemInternal_003Ed__.viewMode = viewMode;
		_003CLoadComponentMetadataItemInternal_003Ed__.clearCache = clearCache;
		_003CLoadComponentMetadataItemInternal_003Ed__._003C_003Et__builder = AsyncTaskMethodBuilder<UIViewModel>.Create();
		_003CLoadComponentMetadataItemInternal_003Ed__._003C_003E1__state = -1;
		AsyncTaskMethodBuilder<UIViewModel> _003C_003Et__builder = _003CLoadComponentMetadataItemInternal_003Ed__._003C_003Et__builder;
		_003C_003Et__builder.Start<_003CLoadComponentMetadataItemInternal_003Ed__20>(ref _003CLoadComponentMetadataItemInternal_003Ed__);
		return _003CLoadComponentMetadataItemInternal_003Ed__._003C_003Et__builder.get_Task();
	}

	public UIViewModel GetComponentMetadata(Guid parentUid, ViewItem viewItem)
	{
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		if (model.IsEmpty)
		{
			return null;
		}
		if (!(viewItem is ComponentViewItem componentViewItem))
		{
			return null;
		}
		if (componentViewItem.Name == ExtensionPointViewItem.SystemGenericComponentKey)
		{
			UIViewModel implementationModel = GetImplementationModel(componentViewItem);
			if (implementationModel != null)
			{
				return implementationModel;
			}
		}
		Guid val = default(Guid);
		if (model.RenderComponentCache.TryGetValue(GenerateRenderUid(parentUid, viewItem.Uid), ref val))
		{
			ClientComponentModel val2 = model.ComponentCache.get_Item(val);
			if (val2.get_ModuleItemUid() == Guid.Empty)
			{
				return CreateUiModel(componentMetadataItemManager.LoadOrNull(val2.get_ItemUid()));
			}
			ModuleMetadataItem val3 = moduleMetadataItemManager.LoadOrNull(val2.get_ModuleItemUid());
			if (val3 == null)
			{
				return null;
			}
			return CreateUiModel(val3, componentViewItem.HeaderUid);
		}
		ModuleMetadataItem val4 = findComponentService.TryFindModuleByComponentHeaderUid(componentViewItem.HeaderUid);
		if (val4 != null)
		{
			return CreateUiModel(val4, componentViewItem.HeaderUid);
		}
		return null;
	}

	public System.Threading.Tasks.Task ChangeViewMode(InterfaceBuilderViewMode viewMode)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		return SetCurrentPageUidAsync(CurrentPageViewModel.ModuleUid, CurrentPageViewModel.Uid, CurrentPageViewModel.TypeUid, viewMode);
	}

	public void SetCurrentPartialViewItemUid(Guid uid)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		CurrentPageViewModel.CurrentPartialViewItemUid = uid;
	}

	public UIViewModel GetCurrentItemMetadata()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		Guid itemUidByMetadataUid = componentMetadataItemManager.GetItemUidByMetadataUid(CurrentPageViewModel.Metadata.get_Uid());
		IMetadata metadata = CurrentPageViewModel.Metadata;
		UIViewModel obj = InterfaceCreator.Create<UIViewModel>();
		obj.set_Uid(itemUidByMetadataUid);
		obj.set_TypeUid((metadata is PageComponentMetadata) ? MetadataConstants.PageComponentMetadataTypeUid : MetadataConstants.ComponentMetadataTypeUid);
		obj.set_Metadata(metadata);
		obj.set_ServerScriptModule(CurrentPageViewModel.ServerScriptModule);
		obj.set_ClientScriptModule(CurrentPageViewModel.ClientScriptModule);
		obj.set_ViewScriptModule(CurrentPageViewModel.ViewScriptModule);
		obj.set_TestScriptModule(CurrentPageViewModel.TestScriptModule);
		return obj;
	}

	public System.Threading.Tasks.Task SetCurrentPageUidAsync(Guid moduleUid, Guid uid, Guid typeUid, InterfaceBuilderViewMode viewMode = InterfaceBuilderViewMode.Runtime)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		_003CSetCurrentPageUidAsync_003Ed__25 _003CSetCurrentPageUidAsync_003Ed__ = default(_003CSetCurrentPageUidAsync_003Ed__25);
		_003CSetCurrentPageUidAsync_003Ed__._003C_003E4__this = this;
		_003CSetCurrentPageUidAsync_003Ed__.moduleUid = moduleUid;
		_003CSetCurrentPageUidAsync_003Ed__.uid = uid;
		_003CSetCurrentPageUidAsync_003Ed__.typeUid = typeUid;
		_003CSetCurrentPageUidAsync_003Ed__.viewMode = viewMode;
		_003CSetCurrentPageUidAsync_003Ed__._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		_003CSetCurrentPageUidAsync_003Ed__._003C_003E1__state = -1;
		AsyncTaskMethodBuilder _003C_003Et__builder = _003CSetCurrentPageUidAsync_003Ed__._003C_003Et__builder;
		((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).Start<_003CSetCurrentPageUidAsync_003Ed__25>(ref _003CSetCurrentPageUidAsync_003Ed__);
		return ((AsyncTaskMethodBuilder)(ref _003CSetCurrentPageUidAsync_003Ed__._003C_003Et__builder)).get_Task();
	}

	public void SetModuleUid(Guid moduleUid)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		if (CurrentPageViewModel != null)
		{
			CurrentPageViewModel.ModuleUid = moduleUid;
		}
	}

	private void SetCurrentMetadata(IMetadata metadata)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		if (metadata == null)
		{
			model.Clear();
			notValidElementStorage.Clear(CurrentPageViewModel.Metadata.get_Uid());
			CurrentPageViewModel.Metadata = null;
			CurrentPageViewModel.ServerScriptModule = null;
			CurrentPageViewModel.ClientScriptModule = null;
			CurrentPageViewModel.ViewScriptModule = null;
			CurrentPageViewModel.TestScriptModule = null;
			MetadataTrackChangesHelper.ScriptChanged = false;
			return;
		}
		CurrentPageModel currentPageViewModel = CurrentPageViewModel;
		IMetadata metadata2;
		if (CurrentPageViewModel.ViewMode != InterfaceBuilderViewMode.Design)
		{
			metadata2 = metadata;
		}
		else
		{
			IMetadata val = (IMetadata)(object)ObjectExtensions.As<AbstractMetadata>((object)metadata).Clone<AbstractMetadata>();
			metadata2 = val;
		}
		currentPageViewModel.Metadata = metadata2;
		notValidElementStorage.Init(metadata.get_Uid());
		MetadataTrackChangesHelper.FillOldMetadata(CurrentPageViewModel.Metadata);
		CurrentPageViewModel.MethodsService = new MethodsService(this, functionMetadataItemManager);
	}

	public IMetadata GetCurrentMetadata()
	{
		return CurrentPageViewModel.Metadata;
	}

	public System.Threading.Tasks.Task SetScriptVisible(bool value, CodeType codeType = CodeType.Client)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		_003CSetScriptVisible_003Ed__29 _003CSetScriptVisible_003Ed__ = default(_003CSetScriptVisible_003Ed__29);
		_003CSetScriptVisible_003Ed__._003C_003E4__this = this;
		_003CSetScriptVisible_003Ed__.value = value;
		_003CSetScriptVisible_003Ed__.codeType = codeType;
		_003CSetScriptVisible_003Ed__._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		_003CSetScriptVisible_003Ed__._003C_003E1__state = -1;
		AsyncTaskMethodBuilder _003C_003Et__builder = _003CSetScriptVisible_003Ed__._003C_003Et__builder;
		((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).Start<_003CSetScriptVisible_003Ed__29>(ref _003CSetScriptVisible_003Ed__);
		return ((AsyncTaskMethodBuilder)(ref _003CSetScriptVisible_003Ed__._003C_003Et__builder)).get_Task();
	}

	public System.Threading.Tasks.Task Save(Action<System.Threading.Tasks.Task> continuation)
	{
		return SaveAndUpdate().ContinueWith(continuation);
	}

	public System.Threading.Tasks.Task Publish(Action<System.Threading.Tasks.Task> continuation, InterfaceBuilderViewMode viewMode)
	{
		return SaveAndPublish(viewMode).ContinueWith(continuation);
	}

	public Guid GetFunctionItemUid(Guid componentUid, Guid functionHeaderUid)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		_003C_003Ec__DisplayClass32_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass32_0();
		CS_0024_003C_003E8__locals0.functionHeaderUid = functionHeaderUid;
		ClientComponentModel val = default(ClientComponentModel);
		if (!model.ComponentCache.TryGetValue(componentUid, ref val))
		{
			return CS_0024_003C_003E8__locals0.functionHeaderUid;
		}
		ClientFunctionModel val2 = Enumerable.FirstOrDefault<ClientFunctionModel>((System.Collections.Generic.IEnumerable<ClientFunctionModel>)val.get_Functions(), (Func<ClientFunctionModel, bool>)((ClientFunctionModel q) => q.get_HeaderUid() == CS_0024_003C_003E8__locals0.functionHeaderUid));
		if (val2 != null)
		{
			return val2.get_ItemUid();
		}
		System.Collections.Generic.IEnumerator<Guid> enumerator = ((System.Collections.Generic.IEnumerable<Guid>)val.get_Owners()).GetEnumerator();
		try
		{
			if (((System.Collections.IEnumerator)enumerator).MoveNext())
			{
				Guid current = enumerator.get_Current();
				return GetFunctionItemUid(current, CS_0024_003C_003E8__locals0.functionHeaderUid);
			}
		}
		finally
		{
			((System.IDisposable)enumerator)?.Dispose();
		}
		return CS_0024_003C_003E8__locals0.functionHeaderUid;
	}

	public System.Collections.Generic.IEnumerable<EntityDependency> GetEntityDependencies()
	{
		return (System.Collections.Generic.IEnumerable<EntityDependency>)model.EntityDependencies;
	}

	public void ClearRenderComponentCache(Guid parentUid, Guid renderUid)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		model.RenderComponentCache.Remove(GenerateRenderUid(parentUid, renderUid));
	}

	public void UpdateComponentModel(RenderComponentModel componentModel)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		model.ComponentCache.set_Item(componentModel.Header.get_ItemUid(), componentModel.Header);
		UpdateEntityDependencies((System.Collections.Generic.IEnumerable<EntityDependency>)componentModel.EntityDependencies);
		System.Collections.Generic.IEnumerator<KeyValuePair<string, Guid>> enumerator = ((System.Collections.Generic.IEnumerable<KeyValuePair<string, Guid>>)componentModel.RenderComponentCache).GetEnumerator();
		try
		{
			while (((System.Collections.IEnumerator)enumerator).MoveNext())
			{
				KeyValuePair<string, Guid> current = enumerator.get_Current();
				model.RenderComponentCache.set_Item(current.get_Key(), current.get_Value());
			}
		}
		finally
		{
			((System.IDisposable)enumerator)?.Dispose();
		}
		System.Collections.Generic.IEnumerator<KeyValuePair<Guid, ClientComponentModel>> enumerator2 = ((System.Collections.Generic.IEnumerable<KeyValuePair<Guid, ClientComponentModel>>)componentModel.ComponentCache).GetEnumerator();
		try
		{
			while (((System.Collections.IEnumerator)enumerator2).MoveNext())
			{
				KeyValuePair<Guid, ClientComponentModel> current2 = enumerator2.get_Current();
				if (!model.ComponentCache.ContainsKey(current2.get_Key()))
				{
					model.ComponentCache.Add(current2.get_Key(), current2.get_Value());
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator2)?.Dispose();
		}
	}

	public void UpdateEntityDependencies(System.Collections.Generic.IEnumerable<EntityDependency> entityDependencies)
	{
		DependencyHelper.UpdateDependencies(model.EntityDependencies, entityDependencies);
	}

	public System.Collections.Generic.IEnumerable<RenderExtensionPointModel> GetExtensionPointImplementations(string pointId, Guid typeUid)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		_003C_003Ec__DisplayClass37_1 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass37_0();
		CS_0024_003C_003E8__locals0.pointId = pointId;
		CS_0024_003C_003E8__locals0.typeUid = typeUid;
		CS_0024_003C_003E8__locals0._003C_003E4__this = this;
		ClientExtensionPointModel val = Enumerable.FirstOrDefault<ClientExtensionPointModel>((System.Collections.Generic.IEnumerable<ClientExtensionPointModel>)model.ExtensionPoints, (Func<ClientExtensionPointModel, bool>)((ClientExtensionPointModel e) => (e.get_PointId() ?? "") == CS_0024_003C_003E8__locals0.pointId && e.get_TypeUid() == CS_0024_003C_003E8__locals0.typeUid));
		if (val == null)
		{
			return (System.Collections.Generic.IEnumerable<RenderExtensionPointModel>)Enumerable.Empty<RenderExtensionPointModel>();
		}
		return (System.Collections.Generic.IEnumerable<RenderExtensionPointModel>)Enumerable.Select<ClientImplementationModel, RenderExtensionPointModel>((System.Collections.Generic.IEnumerable<ClientImplementationModel>)val.get_Implementations(), (Func<ClientImplementationModel, RenderExtensionPointModel>)delegate(ClientImplementationModel i)
		{
			//IL_000e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_003e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0043: Unknown result type (might be due to invalid IL or missing references)
			//IL_0081: Unknown result type (might be due to invalid IL or missing references)
			ComponentMetadata componentMetadata = null;
			ComponentMetadataItem val2 = CS_0024_003C_003E8__locals0._003C_003E4__this.componentMetadataItemManager.LoadOrNull(i.get_ItemUid());
			if (val2 == null)
			{
				ModuleMetadataItem val3 = CS_0024_003C_003E8__locals0._003C_003E4__this.moduleMetadataItemManager.LoadOrNull(i.get_ModuleItemUid());
				if (val3 != null)
				{
					CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass37_1();
					CS_0024_003C_003E8__locals0.headerId = i.get_HeaderUid();
					componentMetadata = Enumerable.FirstOrDefault<ComponentMetadata>((System.Collections.Generic.IEnumerable<ComponentMetadata>)val3.get_Metadata().get_Components(), (Func<ComponentMetadata, bool>)((ComponentMetadata c) => ((IMetadata)c).get_Uid() == CS_0024_003C_003E8__locals0.headerId));
				}
			}
			else
			{
				componentMetadata = val2.get_Metadata();
			}
			return new RenderExtensionPointModel
			{
				PointId = CS_0024_003C_003E8__locals0.pointId,
				TypeUid = CS_0024_003C_003E8__locals0.typeUid,
				Implementation = i,
				ComponentMetadata = componentMetadata
			};
		});
	}

	private void ClearComponentCacheItems()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		System.Collections.Generic.IEnumerator<KeyValuePair<Guid, ClientComponentModel>> enumerator = ((System.Collections.Generic.IEnumerable<KeyValuePair<Guid, ClientComponentModel>>)model.ComponentCache).GetEnumerator();
		try
		{
			while (((System.Collections.IEnumerator)enumerator).MoveNext())
			{
				KeyValuePair<Guid, ClientComponentModel> current = enumerator.get_Current();
				ComponentMetadataItem val = componentMetadataItemManager.LoadOrNull(current.get_Value().get_ItemUid());
				if (val != null)
				{
					componentMetadataItemManager.RemoveFromCache(InterfaceBuilderViewMode.Runtime, val.get_Header_Uid());
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator)?.Dispose();
		}
	}

	private UIViewModel GetImplementationModel(ComponentViewItem componentViewItem)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		ComponentMetadataItem val = componentMetadataItemManager.LoadOrNull(componentViewItem.Uid);
		if (val == null)
		{
			ModuleMetadataItem val2 = moduleMetadataItemManager.LoadOrNull(componentViewItem.Uid);
			if (val2 != null)
			{
				return CreateUiModel(val2, componentViewItem.HeaderUid);
			}
			return null;
		}
		return CreateUiModel(val);
	}

	private System.Threading.Tasks.Task SaveAndUpdate()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		_003CSaveAndUpdate_003Ed__40 _003CSaveAndUpdate_003Ed__ = default(_003CSaveAndUpdate_003Ed__40);
		_003CSaveAndUpdate_003Ed__._003C_003E4__this = this;
		_003CSaveAndUpdate_003Ed__._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		_003CSaveAndUpdate_003Ed__._003C_003E1__state = -1;
		AsyncTaskMethodBuilder _003C_003Et__builder = _003CSaveAndUpdate_003Ed__._003C_003Et__builder;
		((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).Start<_003CSaveAndUpdate_003Ed__40>(ref _003CSaveAndUpdate_003Ed__);
		return ((AsyncTaskMethodBuilder)(ref _003CSaveAndUpdate_003Ed__._003C_003Et__builder)).get_Task();
	}

	private System.Threading.Tasks.Task SaveAndPublish(InterfaceBuilderViewMode viewMode)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		_003CSaveAndPublish_003Ed__41 _003CSaveAndPublish_003Ed__ = default(_003CSaveAndPublish_003Ed__41);
		_003CSaveAndPublish_003Ed__._003C_003E4__this = this;
		_003CSaveAndPublish_003Ed__.viewMode = viewMode;
		_003CSaveAndPublish_003Ed__._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		_003CSaveAndPublish_003Ed__._003C_003E1__state = -1;
		AsyncTaskMethodBuilder _003C_003Et__builder = _003CSaveAndPublish_003Ed__._003C_003Et__builder;
		((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).Start<_003CSaveAndPublish_003Ed__41>(ref _003CSaveAndPublish_003Ed__);
		return ((AsyncTaskMethodBuilder)(ref _003CSaveAndPublish_003Ed__._003C_003Et__builder)).get_Task();
	}

	private void UpdateScriptModules(IUpdateModel updateModel)
	{
		if (updateModel != null)
		{
			UpdateScriptModule(CurrentPageViewModel.ServerScriptModule, updateModel.ServerScriptModule, CodeType.Server);
			UpdateScriptModule(CurrentPageViewModel.ClientScriptModule, updateModel.ClientScriptModule, CodeType.Client);
			UpdateScriptModule(CurrentPageViewModel.ViewScriptModule, updateModel.ViewScriptModule, CodeType.View);
			UpdateScriptModule(CurrentPageViewModel.TestScriptModule, updateModel.TestScriptModule, CodeType.Test);
		}
	}

	private bool CheckRecursiveError(Guid parentItemUid, Guid viewItemUid, InterfaceBuilderViewMode viewMode)
	{
		string text = string.Concat((object)((object)(Guid)(ref parentItemUid)).ToString(), (object)((object)(Guid)(ref viewItemUid)).ToString(), (object)viewMode);
		int num = 0;
		if (recursiveCheck.TryGetValue(text, ref num) && num > 10)
		{
			return true;
		}
		recursiveCheck.set_Item(text, ++num);
		return false;
	}

	private void UpdateScriptModule(ScriptModule currentScriptModule, ScriptModule updatedScriptModule, CodeType codeType)
	{
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		if (updatedScriptModule == null)
		{
			return;
		}
		if (currentScriptModule == null)
		{
			switch (codeType)
			{
			case CodeType.Client:
				CurrentPageViewModel.ClientScriptModule = updatedScriptModule;
				break;
			case CodeType.Server:
				CurrentPageViewModel.ServerScriptModule = updatedScriptModule;
				break;
			case CodeType.Test:
				CurrentPageViewModel.TestScriptModule = updatedScriptModule;
				break;
			case CodeType.View:
				CurrentPageViewModel.ViewScriptModule = updatedScriptModule;
				break;
			case CodeType.GlobalFunction:
				break;
			}
		}
		else
		{
			updatedScriptModule.set_Uid(currentScriptModule.get_Uid());
			ConvertHelper.Reconcile<ScriptModule>(currentScriptModule, updatedScriptModule);
		}
	}

	private static UIViewModel CreateUiModel(ComponentMetadataItem component)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		if (component == null)
		{
			return null;
		}
		UIViewModel obj = InterfaceCreator.Create<UIViewModel>();
		obj.set_Uid(component.get_Uid());
		obj.set_TypeUid((component.get_Metadata() is PageComponentMetadata) ? MetadataConstants.PageComponentMetadataTypeUid : ((component.get_Metadata() is PortletComponentMetadata) ? MetadataConstants.PortletComponentMetadataTypeUid : MetadataConstants.ComponentMetadataTypeUid));
		obj.set_Metadata((IMetadata)(object)component.get_Metadata());
		obj.set_ServerScriptModule(component.get_ScriptModule());
		obj.set_ClientScriptModule(component.get_ClientScriptModule());
		obj.set_ViewScriptModule(component.get_ViewScriptModule());
		obj.set_TestScriptModule(component.get_TestScriptModule());
		return obj;
	}

	private static UIViewModel CreateUiModel(ModuleMetadataItem moduleItem, Guid headerUid)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		_003C_003Ec__DisplayClass46_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass46_0();
		CS_0024_003C_003E8__locals0.headerUid = headerUid;
		if (moduleItem == null)
		{
			return null;
		}
		ComponentMetadata val = Enumerable.FirstOrDefault<ComponentMetadata>((System.Collections.Generic.IEnumerable<ComponentMetadata>)moduleItem.get_Metadata().get_Components(), (Func<ComponentMetadata, bool>)((ComponentMetadata a) => ((IMetadata)a).get_Uid() == CS_0024_003C_003E8__locals0.headerUid));
		if (val == null)
		{
			return null;
		}
		UIViewModel obj = InterfaceCreator.Create<UIViewModel>();
		obj.set_Uid(((IMetadata)val).get_Uid());
		obj.set_TypeUid((val is PageComponentMetadata) ? MetadataConstants.PageComponentMetadataTypeUid : ((val is PortletComponentMetadata) ? MetadataConstants.PortletComponentMetadataTypeUid : MetadataConstants.ComponentMetadataTypeUid));
		obj.set_Metadata((IMetadata)(object)val);
		ScriptModule val2 = InterfaceCreator.Create<ScriptModule>();
		val2.set_AssemblyName(moduleItem.get_AssemblyName());
		obj.set_ClientScriptModule(val2);
		return obj;
	}

	private static string GenerateRenderUid(Guid itemUid, Guid viewItemUid)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		return $"{itemUid}_{viewItemUid}";
	}
}
