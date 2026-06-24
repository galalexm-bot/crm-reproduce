using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using EleWise.ELMA.Api.Models;
using EleWise.ELMA.Api.Services;
using EleWise.ELMA.Core.Abstractions.Metadata.Models;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Dependencies;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Metadata;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Types;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.Core.Diagnostics;
using EleWise.ELMA.Core.Engine.Metadata.Services.Abstractions;
using EleWise.ELMA.Core.Logging;
using EleWise.ELMA.DTO;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Types.Storage;

namespace EleWise.ELMA.Core.Services;

[Service]
internal sealed class MetadataService : IMetadataService
{
	[StructLayout(3)]
	private struct _003CGetMetadataAsync_003Ed__18 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<IMetadata> _003C_003Et__builder;

		public Guid metadataUid;

		public Guid moduleUid;

		public MetadataService _003C_003E4__this;

		private object _003C_003Eu__1;

		private void MoveNext()
		{
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Unknown result type (might be due to invalid IL or missing references)
			//IL_011b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0182: Unknown result type (might be due to invalid IL or missing references)
			//IL_018a: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			MetadataService metadataService = _003C_003E4__this;
			IMetadata result;
			try
			{
				TaskAwaiter<IMetadata> val;
				if (num == 0)
				{
					val = (TaskAwaiter<IMetadata>)_003C_003Eu__1;
					_003C_003Eu__1 = null;
					num = (_003C_003E1__state = -1);
					goto IL_0173;
				}
				IMetadata val5;
				if (metadataUid == Guid.Empty)
				{
					result = null;
				}
				else
				{
					string text = ((object)(Guid)(ref moduleUid)).ToString();
					string text2 = ((object)(Guid)(ref metadataUid)).ToString();
					TypedMap<string, IMetadata> val2 = metadataService.implementationsByUid.Get(text);
					if (val2 == null)
					{
						val2 = new TypedMap<string, IMetadata>();
						for (int i = 0; i < metadataService.systemMetadata.get_Keys().Length; i++)
						{
							string text3 = metadataService.systemMetadata.get_Keys()[i];
							IMetadata val3 = metadataService.systemMetadata.Get(text3);
							val2.Set(text3, val3);
						}
						metadataService.implementationsByUid.Set(text, val2);
					}
					TypedMap<string, IMetadata> val4 = metadataService.metadataByUid.Get(text);
					if (val4 == null)
					{
						val4 = new TypedMap<string, IMetadata>();
						metadataService.metadataByUid.Set(text, val4);
					}
					val5 = val2.Get(text2);
					if (val5 != null)
					{
						result = val5;
					}
					else
					{
						val5 = val4.Get(text2);
						if (val5 == null)
						{
							val = metadataService.metadataEditorService.LoadDraftMetadataByTypeUid(metadataUid).GetAwaiter();
							if (!val.get_IsCompleted())
							{
								num = (_003C_003E1__state = 0);
								_003C_003Eu__1 = val;
								_003C_003Et__builder.AwaitOnCompleted<TaskAwaiter<IMetadata>, _003CGetMetadataAsync_003Ed__18>(ref val, ref this);
								return;
							}
							goto IL_0173;
						}
						result = val5;
					}
				}
				goto end_IL_000e;
				IL_0173:
				val5 = val.GetResult();
				if (val5 != null)
				{
					metadataService.InternalProcessMetadata(moduleUid, val5, metadataUid);
				}
				result = val5;
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
		public Guid propertyUid;

		internal bool _003CGetProperty_003Eb__0(PropertyMetadata a)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			return ((IMetadata)a).get_Uid() == propertyUid;
		}

		internal bool _003CGetProperty_003Eb__1(PropertyMetadata prop)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			return ((IMetadata)prop).get_Uid() == propertyUid;
		}
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();

		public static Func<PropertyMetadata, bool> _003C_003E9__25_2;

		public static Func<PropertyMetadata, bool> _003C_003E9__26_2;

		internal bool _003CGetProperty_003Eb__25_2(PropertyMetadata a)
		{
			return a.get_IsSystem();
		}

		internal bool _003CGetPropertyWithOwner_003Eb__26_2(PropertyMetadata a)
		{
			return a.get_IsSystem();
		}
	}

	private sealed class _003C_003Ec__DisplayClass26_0
	{
		public Guid propertyUid;

		internal bool _003CGetPropertyWithOwner_003Eb__0(PropertyMetadata a)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			return ((IMetadata)a).get_Uid() == propertyUid;
		}

		internal bool _003CGetPropertyWithOwner_003Eb__1(PropertyMetadata prop)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			return ((IMetadata)prop).get_Uid() == propertyUid;
		}
	}

	private sealed class _003C_003Ec__DisplayClass27_0
	{
		public IPropertyMetadata prop;

		internal bool _003CGetProperties_003Eb__1(IPropertyMetadata a)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			return ((IMetadata)a).get_Uid() == ((IMetadata)prop).get_Uid();
		}
	}

	private sealed class _003C_003Ec__DisplayClass29_0
	{
		public Guid propertyUid;

		internal bool _003CFindProperty_003Eb__0(PropertyMetadata a)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			return ((IMetadata)a).get_Uid() == propertyUid;
		}
	}

	[StructLayout(3)]
	private struct _003CCheckChanges_003Ed__31 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<bool> _003C_003Et__builder;

		public MetadataService _003C_003E4__this;

		public Guid moduleUid;

		private object _003C_003Eu__1;

		private void MoveNext()
		{
			//IL_007e: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c6: Expected O, but got Unknown
			int num = _003C_003E1__state;
			MetadataService metadataService = _003C_003E4__this;
			bool result2;
			try
			{
				TaskAwaiter val;
				TaskAwaiter<LoadMetadataHeadersRequest[]> val2;
				if (num != 0)
				{
					if (num == 1)
					{
						val = (TaskAwaiter)_003C_003Eu__1;
						_003C_003Eu__1 = null;
						num = (_003C_003E1__state = -1);
						goto IL_00d6;
					}
					val2 = metadataService.GetChanges().GetAwaiter();
					if (!val2.get_IsCompleted())
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = val2;
						_003C_003Et__builder.AwaitOnCompleted<TaskAwaiter<LoadMetadataHeadersRequest[]>, _003CCheckChanges_003Ed__31>(ref val2, ref this);
						return;
					}
				}
				else
				{
					val2 = (TaskAwaiter<LoadMetadataHeadersRequest[]>)_003C_003Eu__1;
					_003C_003Eu__1 = null;
					num = (_003C_003E1__state = -1);
				}
				LoadMetadataHeadersRequest[] result = val2.GetResult();
				if (result.Length != 0)
				{
					val = metadataService.UpdateHeaders(result, moduleUid).GetAwaiter();
					if (!val.get_IsCompleted())
					{
						num = (_003C_003E1__state = 1);
						_003C_003Eu__1 = val;
						_003C_003Et__builder.AwaitOnCompleted<TaskAwaiter, _003CCheckChanges_003Ed__31>(ref val, ref this);
						return;
					}
					goto IL_00d6;
				}
				result2 = false;
				goto end_IL_000e;
				IL_00d6:
				val.GetResult();
				result2 = true;
				end_IL_000e:;
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

	private sealed class _003C_003Ec__DisplayClass32_0
	{
		public Guid metadataUid;

		internal bool _003CGetMetadataHeader_003Eb__0(MetadataHeader a)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			return a.get_Uid() == metadataUid;
		}

		internal bool _003CGetMetadataHeader_003Eb__1(MetadataHeader a)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			return a.get_Uid() == metadataUid;
		}
	}

	[StructLayout(3)]
	private struct _003CGetMetadataHeader_003Ed__32 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<MetadataHeader> _003C_003Et__builder;

		public Guid metadataUid;

		public Guid moduleUid;

		public MetadataService _003C_003E4__this;

		private MetadataHeader[] _003Cresult_003E5__2;

		private object _003C_003Eu__1;

		private void MoveNext()
		{
			//IL_001c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			MetadataService metadataService = _003C_003E4__this;
			MetadataHeader result;
			try
			{
				TaskAwaiter<MetadataHeader> val;
				if (num == 0)
				{
					val = (TaskAwaiter<MetadataHeader>)_003C_003Eu__1;
					_003C_003Eu__1 = null;
					num = (_003C_003E1__state = -1);
					goto IL_0156;
				}
				_003C_003Ec__DisplayClass32_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass32_0();
				CS_0024_003C_003E8__locals0.metadataUid = metadataUid;
				string text = ((object)(Guid)(ref moduleUid)).ToString();
				_003Cresult_003E5__2 = metadataService.metadataHeaders.Get(text);
				if (_003Cresult_003E5__2 == null)
				{
					_003Cresult_003E5__2 = (MetadataHeader[])(object)new MetadataHeader[0];
					metadataService.metadataHeaders.Set(text, _003Cresult_003E5__2);
				}
				MetadataHeader val2 = _003Cresult_003E5__2.Find((Func<MetadataHeader, bool>)((MetadataHeader a) => a.get_Uid() == CS_0024_003C_003E8__locals0.metadataUid));
				if (val2 != null)
				{
					result = val2;
				}
				else
				{
					_003Cresult_003E5__2 = metadataService.draftMetadataHeaders.Get(text);
					if (_003Cresult_003E5__2 == null)
					{
						_003Cresult_003E5__2 = (MetadataHeader[])(object)new MetadataHeader[0];
						metadataService.draftMetadataHeaders.Set(text, _003Cresult_003E5__2);
					}
					val2 = _003Cresult_003E5__2.Find((Func<MetadataHeader, bool>)((MetadataHeader a) => a.get_Uid() == CS_0024_003C_003E8__locals0.metadataUid));
					if (val2 == null)
					{
						val = metadataService.metadataEditorService.LoadDraftMetadataHeaderByTypeUid(CS_0024_003C_003E8__locals0.metadataUid).GetAwaiter();
						if (!val.get_IsCompleted())
						{
							num = (_003C_003E1__state = 0);
							_003C_003Eu__1 = val;
							_003C_003Et__builder.AwaitOnCompleted<TaskAwaiter<MetadataHeader>, _003CGetMetadataHeader_003Ed__32>(ref val, ref this);
							return;
						}
						goto IL_0156;
					}
					result = val2;
				}
				goto end_IL_000e;
				IL_0156:
				val2 = val.GetResult();
				if (val2 != null)
				{
					ArrayExtensions.Push<MetadataHeader>(_003Cresult_003E5__2, (MetadataHeader[])(object)new MetadataHeader[1] { val2 });
				}
				result = val2;
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

	private sealed class _003C_003Ec__DisplayClass33_0
	{
		public bool withDrafts;

		internal bool _003CGetMetadataHeaders_003Eb__0(MetadataHeader a)
		{
			if (!withDrafts && a.get_Status() != 2)
			{
				return a.get_Status() == 1;
			}
			return true;
		}
	}

	private sealed class _003C_003Ec__DisplayClass39_0
	{
		public EntityMetadata targetMetadata;

		public Func<EntityMetadata, bool> _003C_003E9__0;

		internal bool _003CGetViewModelMetadataAsync_003Eb__0(EntityMetadata m)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			if (((ClassMetadata)m).get_BaseClassUid() == ((IMetadata)targetMetadata).get_Uid())
			{
				return m.get_Type() == 2;
			}
			return false;
		}
	}

	[StructLayout(3)]
	private struct _003CGetViewModelMetadataAsync_003Ed__39 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<DataClassMetadata> _003C_003Et__builder;

		public EntityMetadata entityMetadata;

		public Guid moduleUid;

		private _003C_003Ec__DisplayClass39_0 _003C_003E8__1;

		public MetadataService _003C_003E4__this;

		private string _003CstringModuleUid_003E5__2;

		private DataClassMetadata _003CviewModelMetadata_003E5__3;

		private string _003CmetadataConfigExtName_003E5__4;

		private System.Collections.Generic.IEnumerator<Guid> _003C_003E7__wrap4;

		private object _003C_003Eu__1;

		private void MoveNext()
		{
			//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
			//IL_022a: Unknown result type (might be due to invalid IL or missing references)
			//IL_022f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0288: Unknown result type (might be due to invalid IL or missing references)
			//IL_028d: Unknown result type (might be due to invalid IL or missing references)
			//IL_029e: Unknown result type (might be due to invalid IL or missing references)
			//IL_02ae: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			MetadataService metadataService = _003C_003E4__this;
			DataClassMetadata result;
			try
			{
				if (num == 0)
				{
					goto IL_00e2;
				}
				TaskAwaiter<IMetadata> val;
				if (num == 1)
				{
					val = (TaskAwaiter<IMetadata>)_003C_003Eu__1;
					_003C_003Eu__1 = null;
					num = (_003C_003E1__state = -1);
					goto IL_0309;
				}
				_003C_003E8__1 = new _003C_003Ec__DisplayClass39_0();
				if (entityMetadata != null)
				{
					_003CstringModuleUid_003E5__2 = ((object)(Guid)(ref moduleUid)).ToString();
					_003C_003E8__1.targetMetadata = entityMetadata;
					_003CviewModelMetadata_003E5__3 = _003C_003E8__1.targetMetadata.get_ViewModelMetadata();
					goto IL_034e;
				}
				result = null;
				goto end_IL_000e;
				IL_00e2:
				try
				{
					if (num != 0)
					{
						goto IL_017c;
					}
					val = (TaskAwaiter<IMetadata>)_003C_003Eu__1;
					_003C_003Eu__1 = null;
					num = (_003C_003E1__state = -1);
					goto IL_0155;
					IL_017c:
					if (((System.Collections.IEnumerator)_003C_003E7__wrap4).MoveNext())
					{
						Guid current = _003C_003E7__wrap4.get_Current();
						val = metadataService.GetMetadataAsync(moduleUid, current).GetAwaiter();
						if (!val.get_IsCompleted())
						{
							num = (_003C_003E1__state = 0);
							_003C_003Eu__1 = val;
							_003C_003Et__builder.AwaitOnCompleted<TaskAwaiter<IMetadata>, _003CGetViewModelMetadataAsync_003Ed__39>(ref val, ref this);
							return;
						}
						goto IL_0155;
					}
					goto end_IL_00e3;
					IL_0155:
					IMetadata result2 = val.GetResult();
					DataClassMetadata viewModelMetadataFromEntityConfigExtension = GetViewModelMetadataFromEntityConfigExtension((EntityMetadata)(object)((result2 is EntityMetadata) ? result2 : null), _003CmetadataConfigExtName_003E5__4);
					if (viewModelMetadataFromEntityConfigExtension == null)
					{
						goto IL_017c;
					}
					_003CviewModelMetadata_003E5__3 = viewModelMetadataFromEntityConfigExtension;
					end_IL_00e3:;
				}
				finally
				{
					if (num < 0 && _003C_003E7__wrap4 != null)
					{
						((System.IDisposable)_003C_003E7__wrap4).Dispose();
					}
				}
				_003C_003E7__wrap4 = null;
				goto IL_01ad;
				IL_0309:
				IMetadata result3 = val.GetResult();
				_003C_003E8__1.targetMetadata = (EntityMetadata)(object)((result3 is EntityMetadata) ? result3 : null);
				if (_003C_003E8__1.targetMetadata != null)
				{
					_003CviewModelMetadata_003E5__3 = _003C_003E8__1.targetMetadata.get_ViewModelMetadata();
					_003CmetadataConfigExtName_003E5__4 = null;
					goto IL_034e;
				}
				goto IL_0359;
				IL_0359:
				result = _003CviewModelMetadata_003E5__3;
				goto end_IL_000e;
				IL_034e:
				if (_003CviewModelMetadata_003E5__3 == null)
				{
					_003CmetadataConfigExtName_003E5__4 = ((INamedMetadata)_003C_003E8__1.targetMetadata).get_Name() + "ConfigExt";
					if (_003C_003E8__1.targetMetadata.get_ImplementedExtensionUids() != null && _003C_003E8__1.targetMetadata.get_ImplementedExtensionUids().get_Count() != 0)
					{
						_003C_003E7__wrap4 = ((System.Collections.Generic.IEnumerable<Guid>)_003C_003E8__1.targetMetadata.get_ImplementedExtensionUids()).GetEnumerator();
						goto IL_00e2;
					}
					goto IL_01ad;
				}
				goto IL_0359;
				IL_01ad:
				if (_003CviewModelMetadata_003E5__3 == null)
				{
					TypedMap<string, IMetadata> val2 = metadataService.metadataByUid.Get(_003CstringModuleUid_003E5__2);
					if (val2 != null)
					{
						List<EntityMetadata> val3 = Enumerable.OfType<EntityMetadata>((System.Collections.IEnumerable)(object)val2.get_Values()).Where((Func<EntityMetadata, bool>)((EntityMetadata m) => ((ClassMetadata)m).get_BaseClassUid() == ((IMetadata)_003C_003E8__1.targetMetadata).get_Uid() && m.get_Type() == 2)).ToList();
						if (val3 != null && val3.get_Count() > 0)
						{
							Enumerator<EntityMetadata> enumerator = val3.GetEnumerator();
							try
							{
								while (enumerator.MoveNext())
								{
									DataClassMetadata viewModelMetadataFromEntityConfigExtension2 = GetViewModelMetadataFromEntityConfigExtension(enumerator.get_Current(), _003CmetadataConfigExtName_003E5__4);
									if (viewModelMetadataFromEntityConfigExtension2 != null)
									{
										_003CviewModelMetadata_003E5__3 = viewModelMetadataFromEntityConfigExtension2;
										break;
									}
								}
							}
							finally
							{
								if (num < 0)
								{
									((System.IDisposable)enumerator).Dispose();
								}
							}
						}
					}
				}
				if (_003CviewModelMetadata_003E5__3 == null && !(((ClassMetadata)_003C_003E8__1.targetMetadata).get_BaseClassUid() == Guid.Empty))
				{
					val = metadataService.GetMetadataAsync(moduleUid, ((ClassMetadata)_003C_003E8__1.targetMetadata).get_BaseClassUid()).GetAwaiter();
					if (!val.get_IsCompleted())
					{
						num = (_003C_003E1__state = 1);
						_003C_003Eu__1 = val;
						_003C_003Et__builder.AwaitOnCompleted<TaskAwaiter<IMetadata>, _003CGetViewModelMetadataAsync_003Ed__39>(ref val, ref this);
						return;
					}
					goto IL_0309;
				}
				goto IL_0359;
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

	private sealed class _003C_003Ec__DisplayClass40_0
	{
		public Guid parentPropertyUid;

		internal bool _003CGetMetadataListWithParents_003Eb__0(PropertyMetadata a)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			return ((IMetadata)a).get_Uid() == parentPropertyUid;
		}
	}

	[StructLayout(3)]
	private struct _003CGetMetadataListWithParents_003Ed__40 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<List<ExtendMetadataModel>> _003C_003Et__builder;

		public EntityMetadata metadata;

		public MetadataService _003C_003E4__this;

		public Guid moduleUid;

		private List<ExtendMetadataModel> _003Cresult_003E5__2;

		private object _003C_003Eu__1;

		private List<ExtendMetadataModel> _003C_003E7__wrap2;

		private EntityMetadata _003CtargetMetadata_003E5__4;

		private ExtendMetadataModel _003Cmodel_003E5__5;

		private string _003CmetadataConfigExtName_003E5__6;

		private System.Collections.Generic.IEnumerator<Guid> _003C_003E7__wrap6;

		private void MoveNext()
		{
			//IL_0066: Unknown result type (might be due to invalid IL or missing references)
			//IL_006b: Unknown result type (might be due to invalid IL or missing references)
			//IL_008c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0093: Unknown result type (might be due to invalid IL or missing references)
			//IL_0110: Unknown result type (might be due to invalid IL or missing references)
			//IL_0218: Unknown result type (might be due to invalid IL or missing references)
			//IL_021d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0221: Unknown result type (might be due to invalid IL or missing references)
			//IL_0226: Unknown result type (might be due to invalid IL or missing references)
			//IL_0305: Unknown result type (might be due to invalid IL or missing references)
			//IL_030a: Unknown result type (might be due to invalid IL or missing references)
			//IL_031b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0326: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			MetadataService metadataService = _003C_003E4__this;
			List<ExtendMetadataModel> result5;
			try
			{
				TaskAwaiter<List<ExtendMetadataModel>> val2;
				TaskAwaiter<IMetadata> val;
				IMetadata result;
				IMetadata result2;
				EntityMetadata val5;
				List<ExtendMetadataModel> result4;
				switch (num)
				{
				default:
				{
					_003Cresult_003E5__2 = new List<ExtendMetadataModel>();
					EntityMetadata obj = metadata;
					TablePartMetadata val3;
					if ((val3 = (TablePartMetadata)(object)((obj is TablePartMetadata) ? obj : null)) != null)
					{
						_003C_003Ec__DisplayClass40_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass40_0();
						ExtendMetadataModel extendMetadataModel = new ExtendMetadataModel
						{
							Metadata = (EntityMetadata)(object)val3
						};
						_003Cresult_003E5__2.Add(extendMetadataModel);
						CS_0024_003C_003E8__locals0.parentPropertyUid = ((EntityMetadata)val3).get_ParentPropertyUid();
						PropertyMetadata val4 = Enumerable.First<PropertyMetadata>((System.Collections.Generic.IEnumerable<PropertyMetadata>)((ClassMetadata)val3).get_Properties(), (Func<PropertyMetadata, bool>)((PropertyMetadata a) => ((IMetadata)a).get_Uid() == CS_0024_003C_003E8__locals0.parentPropertyUid));
						val = metadataService.GetMetadataAsync(moduleUid, ((IPropertyMetadata)val4).get_SubTypeUid()).GetAwaiter();
						if (!val.get_IsCompleted())
						{
							num = (_003C_003E1__state = 0);
							_003C_003Eu__1 = val;
							_003C_003Et__builder.AwaitOnCompleted<TaskAwaiter<IMetadata>, _003CGetMetadataListWithParents_003Ed__40>(ref val, ref this);
							return;
						}
						goto IL_00ee;
					}
					_003CtargetMetadata_003E5__4 = metadata;
					goto IL_019b;
				}
				case 0:
					val = (TaskAwaiter<IMetadata>)_003C_003Eu__1;
					_003C_003Eu__1 = null;
					num = (_003C_003E1__state = -1);
					goto IL_00ee;
				case 1:
					val2 = (TaskAwaiter<List<ExtendMetadataModel>>)_003C_003Eu__1;
					_003C_003Eu__1 = null;
					num = (_003C_003E1__state = -1);
					goto IL_016d;
				case 2:
					try
					{
						if (num != 2)
						{
							goto IL_02b6;
						}
						val = (TaskAwaiter<IMetadata>)_003C_003Eu__1;
						_003C_003Eu__1 = null;
						num = (_003C_003E1__state = -1);
						goto IL_027e;
						IL_02b6:
						if (((System.Collections.IEnumerator)_003C_003E7__wrap6).MoveNext())
						{
							Guid current = _003C_003E7__wrap6.get_Current();
							val = metadataService.GetMetadataAsync(moduleUid, current).GetAwaiter();
							if (!val.get_IsCompleted())
							{
								num = (_003C_003E1__state = 2);
								_003C_003Eu__1 = val;
								_003C_003Et__builder.AwaitOnCompleted<TaskAwaiter<IMetadata>, _003CGetMetadataListWithParents_003Ed__40>(ref val, ref this);
								return;
							}
							goto IL_027e;
						}
						goto end_IL_0209;
						IL_027e:
						IMetadata result3 = val.GetResult();
						EntityMetadata val6 = (EntityMetadata)(object)((result3 is EntityMetadata) ? result3 : null);
						if (!(((val6 != null) ? ((INamedMetadata)val6).get_Name() : null) == _003CmetadataConfigExtName_003E5__6))
						{
							goto IL_02b6;
						}
						_003Cmodel_003E5__5.ConfigExtMetadata = val6;
						end_IL_0209:;
					}
					finally
					{
						if (num < 0 && _003C_003E7__wrap6 != null)
						{
							((System.IDisposable)_003C_003E7__wrap6).Dispose();
						}
					}
					_003C_003E7__wrap6 = null;
					_003CmetadataConfigExtName_003E5__6 = null;
					goto IL_02ee;
				case 3:
					{
						val = (TaskAwaiter<IMetadata>)_003C_003Eu__1;
						_003C_003Eu__1 = null;
						num = (_003C_003E1__state = -1);
						goto IL_0381;
					}
					IL_019b:
					_003Cmodel_003E5__5 = new ExtendMetadataModel
					{
						Metadata = _003CtargetMetadata_003E5__4
					};
					if (_003CtargetMetadata_003E5__4.get_ImplementedExtensionUids() != null && _003CtargetMetadata_003E5__4.get_ImplementedExtensionUids().get_Count() != 0)
					{
						_003CmetadataConfigExtName_003E5__6 = ((INamedMetadata)_003CtargetMetadata_003E5__4).get_Name() + "ConfigExt";
						_003C_003E7__wrap6 = ((System.Collections.Generic.IEnumerable<Guid>)_003CtargetMetadata_003E5__4.get_ImplementedExtensionUids()).GetEnumerator();
						goto case 2;
					}
					goto IL_02ee;
					IL_0381:
					result = val.GetResult();
					_003CtargetMetadata_003E5__4 = (EntityMetadata)(object)((result is EntityMetadata) ? result : null);
					if (_003CtargetMetadata_003E5__4 != null)
					{
						_003Cmodel_003E5__5 = null;
						goto IL_019b;
					}
					goto IL_03ab;
					IL_00ee:
					result2 = val.GetResult();
					if ((val5 = (EntityMetadata)(object)((result2 is EntityMetadata) ? result2 : null)) == null)
					{
						break;
					}
					_003C_003E7__wrap2 = _003Cresult_003E5__2;
					val2 = metadataService.GetMetadataListWithParents(moduleUid, val5).GetAwaiter();
					if (!val2.get_IsCompleted())
					{
						num = (_003C_003E1__state = 1);
						_003C_003Eu__1 = val2;
						_003C_003Et__builder.AwaitOnCompleted<TaskAwaiter<List<ExtendMetadataModel>>, _003CGetMetadataListWithParents_003Ed__40>(ref val2, ref this);
						return;
					}
					goto IL_016d;
					IL_03ab:
					_003CtargetMetadata_003E5__4 = null;
					break;
					IL_016d:
					result4 = val2.GetResult();
					_003C_003E7__wrap2.AddRange((System.Collections.Generic.IEnumerable<ExtendMetadataModel>)result4);
					_003C_003E7__wrap2 = null;
					break;
					IL_02ee:
					_003Cresult_003E5__2.Add(_003Cmodel_003E5__5);
					if (!(((ClassMetadata)_003CtargetMetadata_003E5__4).get_BaseClassUid() == Guid.Empty))
					{
						val = metadataService.GetMetadataAsync(moduleUid, ((ClassMetadata)_003CtargetMetadata_003E5__4).get_BaseClassUid()).GetAwaiter();
						if (!val.get_IsCompleted())
						{
							num = (_003C_003E1__state = 3);
							_003C_003Eu__1 = val;
							_003C_003Et__builder.AwaitOnCompleted<TaskAwaiter<IMetadata>, _003CGetMetadataListWithParents_003Ed__40>(ref val, ref this);
							return;
						}
						goto IL_0381;
					}
					goto IL_03ab;
				}
				result5 = _003Cresult_003E5__2;
			}
			catch (System.Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003C_003Et__builder.SetResult(result5);
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			_003C_003Et__builder.SetStateMachine(stateMachine);
		}
	}

	private sealed class _003C_003Ec__DisplayClass41_0
	{
		public Guid parentPropertyUid;

		internal bool _003CGetTablePartRoot_003Eb__0(PropertyMetadata a)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			return ((IMetadata)a).get_Uid() == parentPropertyUid;
		}
	}

	private sealed class _003C_003Ec__DisplayClass43_0
	{
		public Guid metadataUid;

		internal bool _003CInternalProcessMetadata_003Eb__0(MetadataHeader a)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			return a.get_Uid() == metadataUid;
		}

		internal bool _003CInternalProcessMetadata_003Eb__1(MetadataHeader a)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			return a.get_Uid() == metadataUid;
		}
	}

	[StructLayout(3)]
	private struct _003CLoadHeaders_003Ed__46 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public MetadataService _003C_003E4__this;

		public Guid moduleUid;

		private object _003C_003Eu__1;

		private void MoveNext()
		{
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_0063: Unknown result type (might be due to invalid IL or missing references)
			//IL_0069: Expected O, but got Unknown
			//IL_0081: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c8: Expected O, but got Unknown
			//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
			//IL_011e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0124: Expected O, but got Unknown
			int num = _003C_003E1__state;
			MetadataService metadataService = _003C_003E4__this;
			try
			{
				TaskAwaiter val;
				switch (num)
				{
				default:
					val = metadataService.LoadMetadataHeaders(moduleUid).GetAwaiter();
					if (!val.get_IsCompleted())
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = val;
						((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitOnCompleted<TaskAwaiter, _003CLoadHeaders_003Ed__46>(ref val, ref this);
						return;
					}
					goto IL_0079;
				case 0:
					val = (TaskAwaiter)_003C_003Eu__1;
					_003C_003Eu__1 = null;
					num = (_003C_003E1__state = -1);
					goto IL_0079;
				case 1:
					val = (TaskAwaiter)_003C_003Eu__1;
					_003C_003Eu__1 = null;
					num = (_003C_003E1__state = -1);
					goto IL_00d8;
				case 2:
					{
						val = (TaskAwaiter)_003C_003Eu__1;
						_003C_003Eu__1 = null;
						num = (_003C_003E1__state = -1);
						break;
					}
					IL_00d8:
					val.GetResult();
					val = metadataService.LoadNamespaceMetadata(moduleUid).GetAwaiter();
					if (!val.get_IsCompleted())
					{
						num = (_003C_003E1__state = 2);
						_003C_003Eu__1 = val;
						((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitOnCompleted<TaskAwaiter, _003CLoadHeaders_003Ed__46>(ref val, ref this);
						return;
					}
					break;
					IL_0079:
					val.GetResult();
					val = metadataService.LoadNamespaceInfo(moduleUid).GetAwaiter();
					if (!val.get_IsCompleted())
					{
						num = (_003C_003E1__state = 1);
						_003C_003Eu__1 = val;
						((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitOnCompleted<TaskAwaiter, _003CLoadHeaders_003Ed__46>(ref val, ref this);
						return;
					}
					goto IL_00d8;
				}
				val.GetResult();
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
	private struct _003CLoadMetadataHeaders_003Ed__47 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public Guid moduleUid;

		public MetadataService _003C_003E4__this;

		private string _003CstringModuleUid_003E5__2;

		private object _003C_003Eu__1;

		private void MoveNext()
		{
			//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
			//IL_0119: Unknown result type (might be due to invalid IL or missing references)
			//IL_0120: Expected O, but got Unknown
			int num = _003C_003E1__state;
			MetadataService metadataService = _003C_003E4__this;
			try
			{
				TaskAwaiter<LoadMetadataHeadersRequest[]> val3;
				TaskAwaiter<System.Collections.Generic.ICollection<MetadataHeader>> val;
				TaskAwaiter val2;
				LoadMetadataHeadersRequest[] result;
				switch (num)
				{
				default:
				{
					_003CstringModuleUid_003E5__2 = ((object)(Guid)(ref moduleUid)).ToString();
					MetadataHeader[] array = metadataService.metadataHeaders.Get(_003CstringModuleUid_003E5__2);
					if (array == null)
					{
						array = (MetadataHeader[])(object)new MetadataHeader[0];
						metadataService.metadataHeaders.Set(_003CstringModuleUid_003E5__2, array);
					}
					if (array.Length != 0)
					{
						val3 = metadataService.GetChanges().GetAwaiter();
						if (!val3.get_IsCompleted())
						{
							num = (_003C_003E1__state = 0);
							_003C_003Eu__1 = val3;
							((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitOnCompleted<TaskAwaiter<LoadMetadataHeadersRequest[]>, _003CLoadMetadataHeaders_003Ed__47>(ref val3, ref this);
							return;
						}
						goto IL_00c3;
					}
					val = metadataService.metadataEditorService.GetMetadataHeaders(withDrafts: true).GetAwaiter();
					if (!val.get_IsCompleted())
					{
						num = (_003C_003E1__state = 2);
						_003C_003Eu__1 = val;
						((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitOnCompleted<TaskAwaiter<System.Collections.Generic.ICollection<MetadataHeader>>, _003CLoadMetadataHeaders_003Ed__47>(ref val, ref this);
						return;
					}
					break;
				}
				case 0:
					val3 = (TaskAwaiter<LoadMetadataHeadersRequest[]>)_003C_003Eu__1;
					_003C_003Eu__1 = null;
					num = (_003C_003E1__state = -1);
					goto IL_00c3;
				case 1:
					val2 = (TaskAwaiter)_003C_003Eu__1;
					_003C_003Eu__1 = null;
					num = (_003C_003E1__state = -1);
					goto IL_0130;
				case 2:
					{
						val = (TaskAwaiter<System.Collections.Generic.ICollection<MetadataHeader>>)_003C_003Eu__1;
						_003C_003Eu__1 = null;
						num = (_003C_003E1__state = -1);
						break;
					}
					IL_0130:
					val2.GetResult();
					goto end_IL_000e;
					IL_00c3:
					result = val3.GetResult();
					if (result.Length != 0)
					{
						val2 = metadataService.UpdateHeaders(result, moduleUid).GetAwaiter();
						if (!val2.get_IsCompleted())
						{
							num = (_003C_003E1__state = 1);
							_003C_003Eu__1 = val2;
							((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitOnCompleted<TaskAwaiter, _003CLoadMetadataHeaders_003Ed__47>(ref val2, ref this);
							return;
						}
						goto IL_0130;
					}
					goto end_IL_000e;
				}
				MetadataHeader[] array2 = Enumerable.ToArray<MetadataHeader>((System.Collections.Generic.IEnumerable<MetadataHeader>)val.GetResult());
				metadataService.metadataHeaders.Set(_003CstringModuleUid_003E5__2, array2);
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
	private struct _003CLoadNamespaceMetadata_003Ed__48 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public Guid moduleUid;

		public MetadataService _003C_003E4__this;

		private string _003CstringModuleUid_003E5__2;

		private object _003C_003Eu__1;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			MetadataService metadataService = _003C_003E4__this;
			try
			{
				TaskAwaiter<System.Collections.Generic.ICollection<NamespaceMetadata>> val;
				if (num == 0)
				{
					val = (TaskAwaiter<System.Collections.Generic.ICollection<NamespaceMetadata>>)_003C_003Eu__1;
					_003C_003Eu__1 = null;
					num = (_003C_003E1__state = -1);
					goto IL_0095;
				}
				_003CstringModuleUid_003E5__2 = ((object)(Guid)(ref moduleUid)).ToString();
				if (!metadataService.namespaceMetadata.Has(_003CstringModuleUid_003E5__2))
				{
					val = metadataService.metadataEditorService.GetNamespaceMetadata().GetAwaiter();
					if (!val.get_IsCompleted())
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = val;
						((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitOnCompleted<TaskAwaiter<System.Collections.Generic.ICollection<NamespaceMetadata>>, _003CLoadNamespaceMetadata_003Ed__48>(ref val, ref this);
						return;
					}
					goto IL_0095;
				}
				goto end_IL_000e;
				IL_0095:
				NamespaceMetadata[] array = Enumerable.ToArray<NamespaceMetadata>((System.Collections.Generic.IEnumerable<NamespaceMetadata>)val.GetResult());
				metadataService.namespaceMetadata.Set(_003CstringModuleUid_003E5__2, array);
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
	private struct _003CLoadNamespaceInfo_003Ed__49 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public Guid moduleUid;

		public MetadataService _003C_003E4__this;

		private string _003CstringModuleUid_003E5__2;

		private object _003C_003Eu__1;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			MetadataService metadataService = _003C_003E4__this;
			try
			{
				TaskAwaiter<System.Collections.Generic.ICollection<NamespaceInfo>> val;
				if (num == 0)
				{
					val = (TaskAwaiter<System.Collections.Generic.ICollection<NamespaceInfo>>)_003C_003Eu__1;
					_003C_003Eu__1 = null;
					num = (_003C_003E1__state = -1);
					goto IL_0095;
				}
				_003CstringModuleUid_003E5__2 = ((object)(Guid)(ref moduleUid)).ToString();
				if (!metadataService.namespaceInfos.Has(_003CstringModuleUid_003E5__2))
				{
					val = metadataService.metadataEditorService.GetNamespaceInfo().GetAwaiter();
					if (!val.get_IsCompleted())
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = val;
						((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitOnCompleted<TaskAwaiter<System.Collections.Generic.ICollection<NamespaceInfo>>, _003CLoadNamespaceInfo_003Ed__49>(ref val, ref this);
						return;
					}
					goto IL_0095;
				}
				goto end_IL_000e;
				IL_0095:
				NamespaceInfo[] array = Enumerable.ToArray<NamespaceInfo>((System.Collections.Generic.IEnumerable<NamespaceInfo>)val.GetResult());
				metadataService.namespaceInfos.Set(_003CstringModuleUid_003E5__2, array);
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
	private struct _003CGetChanges_003Ed__50 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<LoadMetadataHeadersRequest[]> _003C_003Et__builder;

		public MetadataService _003C_003E4__this;

		private string _003CserializedServerTime_003E5__2;

		private EntityChangesResponse _003CentityChanges_003E5__3;

		private object _003C_003Eu__1;

		private void MoveNext()
		{
			//IL_0055: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
			//IL_0188: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c5: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			MetadataService metadataService = _003C_003E4__this;
			LoadMetadataHeadersRequest[] result2;
			try
			{
				TaskAwaiter<EntityChangesResponse> val;
				if (num != 0)
				{
					if (num == 1)
					{
						val = (TaskAwaiter<EntityChangesResponse>)_003C_003Eu__1;
						_003C_003Eu__1 = null;
						num = (_003C_003E1__state = -1);
						goto IL_0138;
					}
					_003CserializedServerTime_003E5__2 = (metadataService.lastHeaderUpdate ?? metadataService.initServerTime).ToString((string)null, (IFormatProvider)(object)CultureInfo.get_InvariantCulture());
					val = metadataService.entityChangesService.Changes(MetadataConstants.MetadataItemHeaderType, _003CserializedServerTime_003E5__2, "Id > 0").GetAwaiter();
					if (!val.get_IsCompleted())
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = val;
						_003C_003Et__builder.AwaitOnCompleted<TaskAwaiter<EntityChangesResponse>, _003CGetChanges_003Ed__50>(ref val, ref this);
						return;
					}
				}
				else
				{
					val = (TaskAwaiter<EntityChangesResponse>)_003C_003Eu__1;
					_003C_003Eu__1 = null;
					num = (_003C_003E1__state = -1);
				}
				EntityChangesResponse entityChangesResponse = (_003CentityChanges_003E5__3 = val.GetResult());
				val = metadataService.entityChangesService.Changes(MetadataConstants.DataClassMetadataItemHeaderType, _003CserializedServerTime_003E5__2, "Id > 0").GetAwaiter();
				if (!val.get_IsCompleted())
				{
					num = (_003C_003E1__state = 1);
					_003C_003Eu__1 = val;
					_003C_003Et__builder.AwaitOnCompleted<TaskAwaiter<EntityChangesResponse>, _003CGetChanges_003Ed__50>(ref val, ref this);
					return;
				}
				goto IL_0138;
				IL_0138:
				EntityChangesResponse result = val.GetResult();
				metadataService.lastHeaderUpdate = _003CentityChanges_003E5__3.Now;
				LoadMetadataHeadersRequest[] array = (LoadMetadataHeadersRequest[])(object)new LoadMetadataHeadersRequest[0];
				if (_003CentityChanges_003E5__3.Updated.Length != 0)
				{
					LoadMetadataHeadersRequest val2 = InterfaceCreator.Create<LoadMetadataHeadersRequest>();
					val2.set_Ids(_003CentityChanges_003E5__3.Updated);
					val2.set_TypeUid(MetadataConstants.MetadataItemHeaderType);
					ArrayExtensions.Push<LoadMetadataHeadersRequest>(array, (LoadMetadataHeadersRequest[])(object)new LoadMetadataHeadersRequest[1] { val2 });
				}
				if (result.Updated.Length != 0)
				{
					LoadMetadataHeadersRequest val3 = InterfaceCreator.Create<LoadMetadataHeadersRequest>();
					val3.set_Ids(result.Updated);
					val3.set_TypeUid(MetadataConstants.DataClassMetadataItemHeaderType);
					ArrayExtensions.Push<LoadMetadataHeadersRequest>(array, (LoadMetadataHeadersRequest[])(object)new LoadMetadataHeadersRequest[1] { val3 });
				}
				result2 = array;
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

	private sealed class _003C_003Ec__DisplayClass51_0
	{
		public MetadataHeader updatedHeader;
	}

	private sealed class _003C_003Ec__DisplayClass51_1
	{
		public int idx;

		public _003C_003Ec__DisplayClass51_0 CS_0024_003C_003E8__locals1;

		internal bool _003CUpdateHeaders_003Eb__0(MetadataHeader a, int index)
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			idx = index;
			return a.get_Uid() == CS_0024_003C_003E8__locals1.updatedHeader.get_Uid();
		}
	}

	[StructLayout(3)]
	private struct _003CUpdateHeaders_003Ed__51 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public Guid moduleUid;

		public MetadataService _003C_003E4__this;

		public LoadMetadataHeadersRequest[] updated;

		private MetadataHeader[] _003Cresult_003E5__2;

		private object _003C_003Eu__1;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			MetadataService metadataService = _003C_003E4__this;
			try
			{
				TaskAwaiter<System.Collections.Generic.ICollection<MetadataHeader>> val;
				if (num != 0)
				{
					string text = ((object)(Guid)(ref moduleUid)).ToString();
					_003Cresult_003E5__2 = metadataService.metadataHeaders.Get(text);
					if (_003Cresult_003E5__2 == null)
					{
						_003Cresult_003E5__2 = (MetadataHeader[])(object)new MetadataHeader[0];
						metadataService.metadataHeaders.Set(text, _003Cresult_003E5__2);
					}
					val = metadataService.metadataEditorService.LoadMetadataHeaders(updated).GetAwaiter();
					if (!val.get_IsCompleted())
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = val;
						((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitOnCompleted<TaskAwaiter<System.Collections.Generic.ICollection<MetadataHeader>>, _003CUpdateHeaders_003Ed__51>(ref val, ref this);
						return;
					}
				}
				else
				{
					val = (TaskAwaiter<System.Collections.Generic.ICollection<MetadataHeader>>)_003C_003Eu__1;
					_003C_003Eu__1 = null;
					num = (_003C_003E1__state = -1);
				}
				MetadataHeader[] array = Enumerable.ToArray<MetadataHeader>((System.Collections.Generic.IEnumerable<MetadataHeader>)val.GetResult());
				for (int i = 0; i < array.Length; i++)
				{
					_003C_003Ec__DisplayClass51_0 _003C_003Ec__DisplayClass51_ = new _003C_003Ec__DisplayClass51_0();
					_003C_003Ec__DisplayClass51_.updatedHeader = array[i];
					_003C_003Ec__DisplayClass51_1 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass51_1();
					CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1 = _003C_003Ec__DisplayClass51_;
					CS_0024_003C_003E8__locals0.idx = -1;
					if (_003Cresult_003E5__2.Find((Func<MetadataHeader, int, bool>)delegate(MetadataHeader a, int index)
					{
						//IL_0008: Unknown result type (might be due to invalid IL or missing references)
						//IL_0018: Unknown result type (might be due to invalid IL or missing references)
						CS_0024_003C_003E8__locals0.idx = index;
						return a.get_Uid() == CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.updatedHeader.get_Uid();
					}) != null)
					{
						((System.Array)_003Cresult_003E5__2).Splice(CS_0024_003C_003E8__locals0.idx, 1, new object[0]);
					}
					ArrayExtensions.Push<MetadataHeader>(_003Cresult_003E5__2, (MetadataHeader[])(object)new MetadataHeader[1] { CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.updatedHeader });
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

	private sealed class _003C_003Ec__DisplayClass52_0
	{
		public Guid propertyUid;

		public Func<PropertyMetadata, bool> _003C_003E9__0;

		internal bool _003CGetExtensionProperties_003Eb__0(PropertyMetadata prop)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			return ((IMetadata)prop).get_Uid() == propertyUid;
		}
	}

	private readonly TypedMap<string, NamespaceInfo[]> namespaceInfos = new TypedMap<string, NamespaceInfo[]>();

	private readonly TypedMap<string, NamespaceMetadata[]> namespaceMetadata = new TypedMap<string, NamespaceMetadata[]>();

	private readonly TypedMap<string, MetadataHeader[]> metadataHeaders = new TypedMap<string, MetadataHeader[]>();

	private readonly TypedMap<string, MetadataHeader[]> draftMetadataHeaders = new TypedMap<string, MetadataHeader[]>();

	private readonly TypedMap<string, TypedMap<string, IMetadata>> implementationsByUid = new TypedMap<string, TypedMap<string, IMetadata>>();

	private readonly TypedMap<string, TypedMap<string, IMetadata>> metadataByUid = new TypedMap<string, TypedMap<string, IMetadata>>();

	private TypedMap<string, IMetadata> systemMetadata = new TypedMap<string, IMetadata>();

	private readonly IApplicationData applicationData;

	private readonly IMetadataEditorService metadataEditorService;

	private readonly IMetadataReferenceStorage metadataReferenceStorage;

	private readonly IEntityChangesService entityChangesService;

	private readonly IProxyCacheService proxyCacheService;

	private readonly ILogger logger;

	private readonly System.DateTime initServerTime;

	private System.DateTime? lastHeaderUpdate;

	private TypedMap<string, TypedMap<string, ValueTuple<PropertyMetadata, DataClassMetadata>>> findPropertyCache = new TypedMap<string, TypedMap<string, ValueTuple<PropertyMetadata, DataClassMetadata>>>();

	public MetadataService(IApplicationData applicationData, IMetadataEditorService metadataEditorService, IMetadataReferenceStorage metadataReferenceStorage, IEntityChangesService entityChangesService, IProxyCacheService proxyCacheService, ILogger logger)
	{
		this.applicationData = applicationData;
		this.metadataEditorService = metadataEditorService;
		this.metadataReferenceStorage = metadataReferenceStorage;
		this.entityChangesService = entityChangesService;
		this.proxyCacheService = proxyCacheService;
		this.logger = logger;
		initServerTime = TZ.GetServerTime();
	}

	public IMetadata GetMetadata(Guid moduleUid, Guid metadataUid)
	{
		string text = ((object)(Guid)(ref moduleUid)).ToString();
		TypedMap<string, IMetadata> val = implementationsByUid.Get(text);
		if (val == null)
		{
			val = new TypedMap<string, IMetadata>();
			for (int i = 0; i < systemMetadata.get_Keys().Length; i++)
			{
				string text2 = systemMetadata.get_Keys()[i];
				IMetadata val2 = systemMetadata.Get(text2);
				val.Set(text2, val2);
			}
			implementationsByUid.Set(text, val);
		}
		string text3 = ((object)(Guid)(ref metadataUid)).ToString();
		IMetadata val3 = val.Get(text3);
		if (val3 != null)
		{
			return val3;
		}
		TypedMap<string, IMetadata> val4 = metadataByUid.Get(text);
		if (val4 == null)
		{
			val4 = new TypedMap<string, IMetadata>();
			metadataByUid.Set(text, val4);
		}
		return val4.Get(text3);
	}

	public System.Collections.Generic.IEnumerable<ClassMetadata> GetBaseClasses(Guid moduleUid, Guid metadataUid)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		IMetadata metadata = GetMetadata(moduleUid, metadataUid);
		ClassMetadata val = (ClassMetadata)(object)((metadata is ClassMetadata) ? metadata : null);
		if (val == null)
		{
			return (System.Collections.Generic.IEnumerable<ClassMetadata>)Enumerable.Empty<ClassMetadata>();
		}
		List<ClassMetadata> val2 = new List<ClassMetadata>();
		Guid baseClassUid = val.get_BaseClassUid();
		while (baseClassUid != Guid.Empty)
		{
			IMetadata metadata2 = GetMetadata(moduleUid, baseClassUid);
			val = (ClassMetadata)(object)((metadata2 is ClassMetadata) ? metadata2 : null);
			if (val == null)
			{
				break;
			}
			val2.Add(val);
			baseClassUid = val.get_BaseClassUid();
		}
		return (System.Collections.Generic.IEnumerable<ClassMetadata>)val2;
	}

	public System.Threading.Tasks.Task<IMetadata> GetMetadataAsync(Guid moduleUid, Guid metadataUid)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		_003CGetMetadataAsync_003Ed__18 _003CGetMetadataAsync_003Ed__ = default(_003CGetMetadataAsync_003Ed__18);
		_003CGetMetadataAsync_003Ed__._003C_003E4__this = this;
		_003CGetMetadataAsync_003Ed__.moduleUid = moduleUid;
		_003CGetMetadataAsync_003Ed__.metadataUid = metadataUid;
		_003CGetMetadataAsync_003Ed__._003C_003Et__builder = AsyncTaskMethodBuilder<IMetadata>.Create();
		_003CGetMetadataAsync_003Ed__._003C_003E1__state = -1;
		AsyncTaskMethodBuilder<IMetadata> _003C_003Et__builder = _003CGetMetadataAsync_003Ed__._003C_003Et__builder;
		_003C_003Et__builder.Start<_003CGetMetadataAsync_003Ed__18>(ref _003CGetMetadataAsync_003Ed__);
		return _003CGetMetadataAsync_003Ed__._003C_003Et__builder.get_Task();
	}

	public IMetadata GetMetadataByHash(Guid moduleUid, string hash)
	{
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		string text = ((object)(Guid)(ref moduleUid)).ToString();
		TypedMap<string, IMetadata> val = implementationsByUid.Get(text);
		if (val == null)
		{
			val = new TypedMap<string, IMetadata>();
			for (int i = 0; i < systemMetadata.get_Keys().Length; i++)
			{
				string text2 = systemMetadata.get_Keys()[i];
				IMetadata obj = systemMetadata.Get(text2);
				DataClassMetadata val2;
				if ((val2 = (DataClassMetadata)(object)((obj is DataClassMetadata) ? obj : null)) != null)
				{
					TypedMap<string, IMetadata> obj2 = val;
					Guid uid = ((IMetadata)val2).get_Uid();
					obj2.Set(((object)(Guid)(ref uid)).ToString(), (IMetadata)(object)val2);
				}
			}
			implementationsByUid.Set(text, val);
		}
		string metadataUid = ((ISystemMetadataTypeReferenceStorage)metadataReferenceStorage).GetMetadataUid(hash);
		return val.Get(metadataUid);
	}

	public System.Collections.Generic.IEnumerable<IMetadata> GetMetadataList(Guid moduleUid)
	{
		string text = ((object)(Guid)(ref moduleUid)).ToString();
		TypedMap<string, IMetadata> val = implementationsByUid.Get(text);
		if (val == null)
		{
			return (System.Collections.Generic.IEnumerable<IMetadata>)Enumerable.Empty<IMetadata>();
		}
		return val.get_Values();
	}

	public IMetadata LoadMetadata(Guid moduleUid, System.Type type)
	{
		string text = ((object)(Guid)(ref moduleUid)).ToString();
		TypedMap<string, IMetadata> val = implementationsByUid.Get(text);
		if (val == null)
		{
			return null;
		}
		string name = type.get_Name();
		IMetadata result = null;
		IMetadata[] values = val.get_Values();
		foreach (IMetadata obj in values)
		{
			INamedMetadata val2;
			if ((val2 = (INamedMetadata)(object)((obj is INamedMetadata) ? obj : null)) != null && !(val2.get_Name() + "DTO" != name))
			{
				result = (IMetadata)(object)val2;
				break;
			}
		}
		return result;
	}

	public void DeleteMetadata(Guid moduleUid, Guid uid)
	{
		string text = ((object)(Guid)(ref moduleUid)).ToString();
		if (implementationsByUid.Get(text) != null)
		{
			string text2 = ((object)(Guid)(ref uid)).ToString();
			implementationsByUid.Get(text).Delete(text2);
			metadataByUid.Get(text).Delete(text2);
			proxyCacheService.Update(text2);
		}
	}

	public System.Collections.Generic.IEnumerable<NamespaceMetadata> GetNamespaceMetadataList(Guid moduleUid)
	{
		string text = ((object)(Guid)(ref moduleUid)).ToString();
		NamespaceMetadata[] array = namespaceMetadata.Get(text);
		if (array != null)
		{
			return array;
		}
		return (System.Collections.Generic.IEnumerable<NamespaceMetadata>)Enumerable.Empty<NamespaceMetadata>();
	}

	public System.Collections.Generic.IEnumerable<NamespaceInfo> GetNamespaceInfoList(Guid moduleUid)
	{
		string text = ((object)(Guid)(ref moduleUid)).ToString();
		NamespaceInfo[] array = namespaceInfos.Get(text);
		if (array != null)
		{
			return array;
		}
		return (System.Collections.Generic.IEnumerable<NamespaceInfo>)Enumerable.Empty<NamespaceInfo>();
	}

	public IPropertyMetadata GetProperty(Guid moduleUid, ClassMetadata metadataDto, Guid propertyUid)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_010f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_0168: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Unknown result type (might be due to invalid IL or missing references)
		//IL_0179: Unknown result type (might be due to invalid IL or missing references)
		//IL_018f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		_003C_003Ec__DisplayClass25_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass25_0();
		CS_0024_003C_003E8__locals0.propertyUid = propertyUid;
		if (metadataDto == null)
		{
			return null;
		}
		PropertyMetadata val = Enumerable.FirstOrDefault<PropertyMetadata>((System.Collections.Generic.IEnumerable<PropertyMetadata>)metadataDto.get_Properties(), (Func<PropertyMetadata, bool>)((PropertyMetadata a) => ((IMetadata)a).get_Uid() == CS_0024_003C_003E8__locals0.propertyUid));
		if (val != null)
		{
			return (IPropertyMetadata)(object)val;
		}
		EntityMetadata val2;
		if ((val2 = (EntityMetadata)(object)((metadataDto is EntityMetadata) ? metadataDto : null)) != null)
		{
			PropertyMetadata val3 = Enumerable.FirstOrDefault<PropertyMetadata>(GetExtensionProperties(moduleUid, ((IMetadata)metadataDto).get_Uid(), CS_0024_003C_003E8__locals0.propertyUid));
			if (val3 != null)
			{
				return (IPropertyMetadata)(object)val3;
			}
			IPropertyMetadata item = MetadataHelper.FindTablePartOrProperty(val2, CS_0024_003C_003E8__locals0.propertyUid).Item2;
			if (item != null)
			{
				return item;
			}
			DataClassMetadata viewModelMetadata = val2.get_ViewModelMetadata();
			PropertyMetadata val4 = ((viewModelMetadata != null) ? Enumerable.FirstOrDefault<PropertyMetadata>((System.Collections.Generic.IEnumerable<PropertyMetadata>)((ClassMetadata)viewModelMetadata).get_Properties(), (Func<PropertyMetadata, bool>)((PropertyMetadata prop) => ((IMetadata)prop).get_Uid() == CS_0024_003C_003E8__locals0.propertyUid)) : null);
			if (val4 != null)
			{
				return (IPropertyMetadata)(object)val4;
			}
		}
		DataClassMetadata val5;
		if ((val5 = (DataClassMetadata)(object)((metadataDto is DataClassMetadata) ? metadataDto : null)) != null)
		{
			ValueTuple<PropertyMetadata, DataClassMetadata> val6 = FindProperty(moduleUid, val5, CS_0024_003C_003E8__locals0.propertyUid);
			if (val6.Item1 != null)
			{
				return (IPropertyMetadata)(object)val6.Item1;
			}
			System.Collections.Generic.IEnumerator<PropertyMetadata> enumerator = Enumerable.Where<PropertyMetadata>((System.Collections.Generic.IEnumerable<PropertyMetadata>)((ClassMetadata)val5).get_Properties(), (Func<PropertyMetadata, bool>)((PropertyMetadata a) => a.get_IsSystem())).GetEnumerator();
			try
			{
				while (((System.Collections.IEnumerator)enumerator).MoveNext())
				{
					Guid subTypeUid = ((IPropertyMetadata)enumerator.get_Current()).get_SubTypeUid();
					ClassMetadata metadataDto2;
					if (!(subTypeUid == Guid.Empty) && (metadataDto2 = (ClassMetadata)/*isinst with value type is only supported in some contexts*/) != null)
					{
						IPropertyMetadata property = GetProperty(moduleUid, metadataDto2, CS_0024_003C_003E8__locals0.propertyUid);
						if (property != null)
						{
							return property;
						}
					}
				}
			}
			finally
			{
				((System.IDisposable)enumerator)?.Dispose();
			}
		}
		if (metadataDto.get_BaseClassUid() == Guid.Empty)
		{
			return null;
		}
		IMetadata metadata = GetMetadata(moduleUid, metadataDto.get_BaseClassUid());
		ClassMetadata val7 = (ClassMetadata)(object)((metadata is ClassMetadata) ? metadata : null);
		if (val7 != null)
		{
			return GetProperty(moduleUid, val7, CS_0024_003C_003E8__locals0.propertyUid);
		}
		return null;
	}

	internal ValueTuple<ClassMetadata, IPropertyMetadata> GetPropertyWithOwner(Guid moduleUid, ClassMetadata metadataDto, Guid propertyUid, List<Guid> used = null)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Unknown result type (might be due to invalid IL or missing references)
		//IL_010c: Unknown result type (might be due to invalid IL or missing references)
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_018e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Unknown result type (might be due to invalid IL or missing references)
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01da: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0207: Unknown result type (might be due to invalid IL or missing references)
		//IL_020b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0212: Unknown result type (might be due to invalid IL or missing references)
		//IL_021a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0220: Unknown result type (might be due to invalid IL or missing references)
		_003C_003Ec__DisplayClass26_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass26_0();
		CS_0024_003C_003E8__locals0.propertyUid = propertyUid;
		if (metadataDto == null)
		{
			return new ValueTuple<ClassMetadata, IPropertyMetadata>((ClassMetadata)null, (IPropertyMetadata)null);
		}
		if (used == null)
		{
			List<Guid> obj = new List<Guid>();
			obj.Add(((IMetadata)metadataDto).get_Uid());
			used = obj;
		}
		PropertyMetadata val = Enumerable.FirstOrDefault<PropertyMetadata>((System.Collections.Generic.IEnumerable<PropertyMetadata>)metadataDto.get_Properties(), (Func<PropertyMetadata, bool>)((PropertyMetadata a) => ((IMetadata)a).get_Uid() == CS_0024_003C_003E8__locals0.propertyUid));
		if (val != null)
		{
			return new ValueTuple<ClassMetadata, IPropertyMetadata>(metadataDto, (IPropertyMetadata)(object)val);
		}
		EntityMetadata val2;
		if ((val2 = (EntityMetadata)(object)((metadataDto is EntityMetadata) ? metadataDto : null)) != null)
		{
			ValueTuple<ClassMetadata, IPropertyMetadata> extensionPropertyWithOwner = GetExtensionPropertyWithOwner(moduleUid, ((IMetadata)metadataDto).get_Uid(), CS_0024_003C_003E8__locals0.propertyUid, used);
			ClassMetadata item = extensionPropertyWithOwner.Item1;
			IPropertyMetadata item2 = extensionPropertyWithOwner.Item2;
			if (item2 != null)
			{
				return new ValueTuple<ClassMetadata, IPropertyMetadata>(item, item2);
			}
			ValueTuple<EntityMetadata, IPropertyMetadata> val3 = MetadataHelper.FindTablePartOrProperty(val2, CS_0024_003C_003E8__locals0.propertyUid);
			EntityMetadata item3 = val3.Item1;
			IPropertyMetadata item4 = val3.Item2;
			if (item4 != null)
			{
				return new ValueTuple<ClassMetadata, IPropertyMetadata>((ClassMetadata)(object)item3, item4);
			}
			DataClassMetadata viewModelMetadata = val2.get_ViewModelMetadata();
			PropertyMetadata val4 = ((viewModelMetadata != null) ? Enumerable.FirstOrDefault<PropertyMetadata>((System.Collections.Generic.IEnumerable<PropertyMetadata>)((ClassMetadata)viewModelMetadata).get_Properties(), (Func<PropertyMetadata, bool>)((PropertyMetadata prop) => ((IMetadata)prop).get_Uid() == CS_0024_003C_003E8__locals0.propertyUid)) : null);
			if (val4 != null)
			{
				return new ValueTuple<ClassMetadata, IPropertyMetadata>((ClassMetadata)(object)viewModelMetadata, (IPropertyMetadata)(object)val4);
			}
		}
		DataClassMetadata val5;
		if ((val5 = (DataClassMetadata)(object)((metadataDto is DataClassMetadata) ? metadataDto : null)) != null)
		{
			ValueTuple<PropertyMetadata, DataClassMetadata> val6 = FindProperty(moduleUid, val5, CS_0024_003C_003E8__locals0.propertyUid);
			if (val6.Item1 != null)
			{
				return new ValueTuple<ClassMetadata, IPropertyMetadata>((ClassMetadata)(object)val6.Item2, (IPropertyMetadata)(object)val6.Item1);
			}
			System.Collections.Generic.IEnumerator<PropertyMetadata> enumerator = Enumerable.Where<PropertyMetadata>((System.Collections.Generic.IEnumerable<PropertyMetadata>)((ClassMetadata)val5).get_Properties(), (Func<PropertyMetadata, bool>)((PropertyMetadata a) => a.get_IsSystem())).GetEnumerator();
			try
			{
				while (((System.Collections.IEnumerator)enumerator).MoveNext())
				{
					Guid subTypeUid = ((IPropertyMetadata)enumerator.get_Current()).get_SubTypeUid();
					ClassMetadata metadataDto2;
					if (!(subTypeUid == Guid.Empty) && (metadataDto2 = (ClassMetadata)/*isinst with value type is only supported in some contexts*/) != null)
					{
						ValueTuple<ClassMetadata, IPropertyMetadata> propertyWithOwner = GetPropertyWithOwner(moduleUid, metadataDto2, CS_0024_003C_003E8__locals0.propertyUid);
						ClassMetadata item5 = propertyWithOwner.Item1;
						IPropertyMetadata item6 = propertyWithOwner.Item2;
						if (item6 != null)
						{
							return new ValueTuple<ClassMetadata, IPropertyMetadata>(item5, item6);
						}
					}
				}
			}
			finally
			{
				((System.IDisposable)enumerator)?.Dispose();
			}
		}
		if (metadataDto.get_BaseClassUid() == Guid.Empty)
		{
			return new ValueTuple<ClassMetadata, IPropertyMetadata>((ClassMetadata)null, (IPropertyMetadata)null);
		}
		IMetadata metadata = GetMetadata(moduleUid, metadataDto.get_BaseClassUid());
		ClassMetadata val7 = (ClassMetadata)(object)((metadata is ClassMetadata) ? metadata : null);
		if (val7 != null)
		{
			return GetPropertyWithOwner(moduleUid, val7, CS_0024_003C_003E8__locals0.propertyUid, used);
		}
		return new ValueTuple<ClassMetadata, IPropertyMetadata>((ClassMetadata)null, (IPropertyMetadata)null);
	}

	public System.Collections.Generic.IEnumerable<IPropertyMetadata> GetProperties(Guid moduleUid, ClassMetadata metadataDto, bool includeBase)
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		if (metadataDto == null)
		{
			return (System.Collections.Generic.IEnumerable<IPropertyMetadata>)Enumerable.Empty<IPropertyMetadata>();
		}
		IPropertyMetadata[] array = ObjectExtensions.As<IPropertyMetadata[]>((object)Enumerable.ToArray<PropertyMetadata>((System.Collections.Generic.IEnumerable<PropertyMetadata>)metadataDto.get_Properties()));
		EntityMetadata val = (EntityMetadata)(object)((metadataDto is EntityMetadata) ? metadataDto : null);
		if (val != null)
		{
			System.Collections.Generic.IEnumerable<PropertyMetadata> extensionProperties = GetExtensionProperties(moduleUid, ((IMetadata)metadataDto).get_Uid(), Guid.Empty);
			_003CGetProperties_003Eg__AddIfNotExistProperties_007C27_0(array, (System.Collections.Generic.IEnumerable<IPropertyMetadata>)extensionProperties);
		}
		if (!includeBase || metadataDto.get_BaseClassUid() == Guid.Empty)
		{
			if (val != null)
			{
				_003CGetProperties_003Eg__AddIfNotExistProperties_007C27_0(array, (System.Collections.Generic.IEnumerable<IPropertyMetadata>)val.get_TableParts());
			}
			return array;
		}
		IMetadata metadata = GetMetadata(moduleUid, metadataDto.get_BaseClassUid());
		ClassMetadata metadataDto2 = (ClassMetadata)(object)((metadata is ClassMetadata) ? metadata : null);
		System.Collections.Generic.IEnumerable<IPropertyMetadata> properties = GetProperties(moduleUid, metadataDto2, includeBase: true);
		_003CGetProperties_003Eg__AddIfNotExistProperties_007C27_0(array, properties);
		if (val != null)
		{
			_003CGetProperties_003Eg__AddIfNotExistProperties_007C27_0(array, (System.Collections.Generic.IEnumerable<IPropertyMetadata>)val.get_TableParts());
		}
		return array;
	}

	internal ValueTuple<PropertyMetadata, DataClassMetadata> FindProperty(Guid moduleUid, DataClassMetadata dataClassMetadata, Guid propertyUid)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		_003C_003Ec__DisplayClass29_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass29_0();
		CS_0024_003C_003E8__locals0.propertyUid = propertyUid;
		string text = ((object)(Guid)(ref moduleUid)).ToString();
		TypedMap<string, ValueTuple<PropertyMetadata, DataClassMetadata>> val;
		if (!findPropertyCache.Has(text))
		{
			val = new TypedMap<string, ValueTuple<PropertyMetadata, DataClassMetadata>>();
			findPropertyCache.Set(text, val);
		}
		else
		{
			val = findPropertyCache.Get(text);
		}
		Guid uid = ((IMetadata)dataClassMetadata).get_Uid();
		string text2 = ((object)(Guid)(ref uid)).ToString() + "_" + ((object)(Guid)(ref CS_0024_003C_003E8__locals0.propertyUid)).ToString();
		if (val.Has(text2))
		{
			return val.Get(text2);
		}
		PropertyMetadata val2 = Enumerable.FirstOrDefault<PropertyMetadata>((System.Collections.Generic.IEnumerable<PropertyMetadata>)((ClassMetadata)dataClassMetadata).get_Properties(), (Func<PropertyMetadata, bool>)((PropertyMetadata a) => ((IMetadata)a).get_Uid() == CS_0024_003C_003E8__locals0.propertyUid));
		if (val2 != null)
		{
			ValueTuple<PropertyMetadata, DataClassMetadata> val3 = default(ValueTuple<PropertyMetadata, DataClassMetadata>);
			val3._002Ector(val2, dataClassMetadata);
			val.Set(text2, val3);
			return val3;
		}
		System.Collections.Generic.IEnumerator<DataClassDependency> enumerator = ((System.Collections.Generic.IEnumerable<DataClassDependency>)dataClassMetadata.get_IncludeList()).GetEnumerator();
		try
		{
			while (((System.Collections.IEnumerator)enumerator).MoveNext())
			{
				DataClassDependency current = enumerator.get_Current();
				IMetadata metadata = GetMetadata(moduleUid, ((Dependency)current).get_HeaderUid());
				DataClassMetadata val4 = (DataClassMetadata)(object)((metadata is DataClassMetadata) ? metadata : null);
				if (val4 != null)
				{
					ValueTuple<PropertyMetadata, DataClassMetadata> val5 = FindProperty(moduleUid, val4, CS_0024_003C_003E8__locals0.propertyUid);
					if (val5.Item1 != null)
					{
						val.Set(text2, val5);
						return val5;
					}
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator)?.Dispose();
		}
		val.Set(text2, new ValueTuple<PropertyMetadata, DataClassMetadata>((PropertyMetadata)null, (DataClassMetadata)null));
		return new ValueTuple<PropertyMetadata, DataClassMetadata>((PropertyMetadata)null, (DataClassMetadata)null);
	}

	internal System.Threading.Tasks.Task InitHeaders(Guid moduleUid)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			return LoadHeaders(moduleUid);
		}
		catch (System.Exception exception)
		{
			logger.Error(SR.T("Ошибка при первоначальной загрузке заголовков метаданных"), exception);
			throw;
		}
	}

	internal System.Threading.Tasks.Task<bool> CheckChanges(Guid moduleUid)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		_003CCheckChanges_003Ed__31 _003CCheckChanges_003Ed__ = default(_003CCheckChanges_003Ed__31);
		_003CCheckChanges_003Ed__._003C_003E4__this = this;
		_003CCheckChanges_003Ed__.moduleUid = moduleUid;
		_003CCheckChanges_003Ed__._003C_003Et__builder = AsyncTaskMethodBuilder<bool>.Create();
		_003CCheckChanges_003Ed__._003C_003E1__state = -1;
		AsyncTaskMethodBuilder<bool> _003C_003Et__builder = _003CCheckChanges_003Ed__._003C_003Et__builder;
		_003C_003Et__builder.Start<_003CCheckChanges_003Ed__31>(ref _003CCheckChanges_003Ed__);
		return _003CCheckChanges_003Ed__._003C_003Et__builder.get_Task();
	}

	internal System.Threading.Tasks.Task<MetadataHeader> GetMetadataHeader(Guid moduleUid, Guid metadataUid)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		_003CGetMetadataHeader_003Ed__32 _003CGetMetadataHeader_003Ed__ = default(_003CGetMetadataHeader_003Ed__32);
		_003CGetMetadataHeader_003Ed__._003C_003E4__this = this;
		_003CGetMetadataHeader_003Ed__.moduleUid = moduleUid;
		_003CGetMetadataHeader_003Ed__.metadataUid = metadataUid;
		_003CGetMetadataHeader_003Ed__._003C_003Et__builder = AsyncTaskMethodBuilder<MetadataHeader>.Create();
		_003CGetMetadataHeader_003Ed__._003C_003E1__state = -1;
		AsyncTaskMethodBuilder<MetadataHeader> _003C_003Et__builder = _003CGetMetadataHeader_003Ed__._003C_003Et__builder;
		_003C_003Et__builder.Start<_003CGetMetadataHeader_003Ed__32>(ref _003CGetMetadataHeader_003Ed__);
		return _003CGetMetadataHeader_003Ed__._003C_003Et__builder.get_Task();
	}

	internal System.Collections.Generic.IEnumerable<MetadataHeader> GetMetadataHeaders(Guid moduleUid, bool withDrafts)
	{
		_003C_003Ec__DisplayClass33_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass33_0();
		CS_0024_003C_003E8__locals0.withDrafts = withDrafts;
		string text = ((object)(Guid)(ref moduleUid)).ToString();
		MetadataHeader[] array = metadataHeaders.Get(text);
		if (array == null)
		{
			array = (MetadataHeader[])(object)new MetadataHeader[0];
			metadataHeaders.Set(text, array);
		}
		return ArrayExtensions.Filter<MetadataHeader>(array, (Func<MetadataHeader, bool>)((MetadataHeader a) => CS_0024_003C_003E8__locals0.withDrafts || a.get_Status() == 2 || a.get_Status() == 1));
	}

	internal void ProcessMetadata(Guid moduleUid, IMetadata metadata)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		Contract.ArgumentNotNull(metadata, "metadata");
		InternalProcessMetadata(moduleUid, metadata);
	}

	internal void ProcessMetadata(Guid moduleUid, System.Collections.Generic.IEnumerable<IMetadata> metadataList)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		if (metadataList == null)
		{
			return;
		}
		System.Collections.Generic.IEnumerator<IMetadata> enumerator = metadataList.GetEnumerator();
		try
		{
			while (((System.Collections.IEnumerator)enumerator).MoveNext())
			{
				IMetadata current = enumerator.get_Current();
				ProcessMetadata(moduleUid, current);
			}
		}
		finally
		{
			((System.IDisposable)enumerator)?.Dispose();
		}
	}

	internal void RegisterSystemMetadata(Guid moduleUid, System.Collections.Generic.IEnumerable<IMetadata> systemMetadataList)
	{
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		string text = ((object)(Guid)(ref moduleUid)).ToString();
		TypedMap<string, IMetadata> val = implementationsByUid.Get(text);
		if (val == null)
		{
			val = new TypedMap<string, IMetadata>();
			implementationsByUid.Set(text, val);
		}
		System.Collections.Generic.IEnumerator<IMetadata> enumerator = systemMetadataList.GetEnumerator();
		try
		{
			while (((System.Collections.IEnumerator)enumerator).MoveNext())
			{
				IMetadata current = enumerator.get_Current();
				Guid uid = current.get_Uid();
				val.Set(((object)(Guid)(ref uid)).ToString(), current);
				ModuleInfoMetadata metadata;
				if ((metadata = (ModuleInfoMetadata)(object)((current is ModuleInfoMetadata) ? current : null)) != null)
				{
					RegisterSystemMetadata(moduleUid, MetadataHelper.GetMetadataToRegister((IMetadata)(object)metadata));
				}
				DataClassMetadata metadata2;
				if ((metadata2 = (DataClassMetadata)(object)((current is DataClassMetadata) ? current : null)) != null)
				{
					ProcessMetadataByName(moduleUid, metadata2);
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator)?.Dispose();
		}
		implementationsByUid.Set(text, val);
		for (int i = 0; i < val.get_Keys().Length; i++)
		{
			string text2 = val.get_Keys()[i];
			IMetadata val2 = val.Get(text2);
			systemMetadata.Set(text2, val2);
		}
	}

	internal void Refresh(Guid moduleUid)
	{
		string text = ((object)(Guid)(ref moduleUid)).ToString();
		metadataHeaders.Delete(text);
		draftMetadataHeaders.Delete(text);
		implementationsByUid.Delete(text);
		metadataByUid.Delete(text);
		findPropertyCache.Delete(text);
	}

	internal DataClassMetadata GetViewModelMetadata(Guid moduleUid, EntityMetadata entityMetadata)
	{
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		if (entityMetadata == null)
		{
			return null;
		}
		EntityMetadata val = entityMetadata;
		DataClassMetadata val2;
		for (val2 = val.get_ViewModelMetadata(); val2 == null; val2 = val.get_ViewModelMetadata())
		{
			if (val.get_ImplementedExtensionUids() != null && val.get_ImplementedExtensionUids().get_Count() != 0)
			{
				string metadataConfigExtName = ((INamedMetadata)val).get_Name() + "ConfigExt";
				System.Collections.Generic.IEnumerator<Guid> enumerator = ((System.Collections.Generic.IEnumerable<Guid>)val.get_ImplementedExtensionUids()).GetEnumerator();
				try
				{
					while (((System.Collections.IEnumerator)enumerator).MoveNext())
					{
						Guid current = enumerator.get_Current();
						IMetadata metadata = GetMetadata(moduleUid, current);
						DataClassMetadata viewModelMetadataFromEntityConfigExtension = GetViewModelMetadataFromEntityConfigExtension((EntityMetadata)(object)((metadata is EntityMetadata) ? metadata : null), metadataConfigExtName);
						if (viewModelMetadataFromEntityConfigExtension != null)
						{
							val2 = viewModelMetadataFromEntityConfigExtension;
							break;
						}
					}
				}
				finally
				{
					((System.IDisposable)enumerator)?.Dispose();
				}
			}
			if (val2 != null || ((ClassMetadata)val).get_BaseClassUid() == Guid.Empty)
			{
				break;
			}
			IMetadata metadata2 = GetMetadata(moduleUid, ((ClassMetadata)val).get_BaseClassUid());
			val = (EntityMetadata)(object)((metadata2 is EntityMetadata) ? metadata2 : null);
			if (val == null)
			{
				break;
			}
		}
		return val2;
	}

	internal System.Threading.Tasks.Task<DataClassMetadata> GetViewModelMetadataAsync(Guid moduleUid, EntityMetadata entityMetadata)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		_003CGetViewModelMetadataAsync_003Ed__39 _003CGetViewModelMetadataAsync_003Ed__ = default(_003CGetViewModelMetadataAsync_003Ed__39);
		_003CGetViewModelMetadataAsync_003Ed__._003C_003E4__this = this;
		_003CGetViewModelMetadataAsync_003Ed__.moduleUid = moduleUid;
		_003CGetViewModelMetadataAsync_003Ed__.entityMetadata = entityMetadata;
		_003CGetViewModelMetadataAsync_003Ed__._003C_003Et__builder = AsyncTaskMethodBuilder<DataClassMetadata>.Create();
		_003CGetViewModelMetadataAsync_003Ed__._003C_003E1__state = -1;
		AsyncTaskMethodBuilder<DataClassMetadata> _003C_003Et__builder = _003CGetViewModelMetadataAsync_003Ed__._003C_003Et__builder;
		_003C_003Et__builder.Start<_003CGetViewModelMetadataAsync_003Ed__39>(ref _003CGetViewModelMetadataAsync_003Ed__);
		return _003CGetViewModelMetadataAsync_003Ed__._003C_003Et__builder.get_Task();
	}

	internal System.Threading.Tasks.Task<List<ExtendMetadataModel>> GetMetadataListWithParents(Guid moduleUid, EntityMetadata metadata)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		_003CGetMetadataListWithParents_003Ed__40 _003CGetMetadataListWithParents_003Ed__ = default(_003CGetMetadataListWithParents_003Ed__40);
		_003CGetMetadataListWithParents_003Ed__._003C_003E4__this = this;
		_003CGetMetadataListWithParents_003Ed__.moduleUid = moduleUid;
		_003CGetMetadataListWithParents_003Ed__.metadata = metadata;
		_003CGetMetadataListWithParents_003Ed__._003C_003Et__builder = AsyncTaskMethodBuilder<List<ExtendMetadataModel>>.Create();
		_003CGetMetadataListWithParents_003Ed__._003C_003E1__state = -1;
		AsyncTaskMethodBuilder<List<ExtendMetadataModel>> _003C_003Et__builder = _003CGetMetadataListWithParents_003Ed__._003C_003Et__builder;
		_003C_003Et__builder.Start<_003CGetMetadataListWithParents_003Ed__40>(ref _003CGetMetadataListWithParents_003Ed__);
		return _003CGetMetadataListWithParents_003Ed__._003C_003Et__builder.get_Task();
	}

	internal EntityMetadata GetTablePartRoot(Guid moduleUid, TablePartMetadata tablePartMetadata)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Expected O, but got Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		_003C_003Ec__DisplayClass41_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass41_0();
		CS_0024_003C_003E8__locals0.parentPropertyUid = ((EntityMetadata)tablePartMetadata).get_ParentPropertyUid();
		PropertyMetadata val = Enumerable.First<PropertyMetadata>((System.Collections.Generic.IEnumerable<PropertyMetadata>)((ClassMetadata)tablePartMetadata).get_Properties(), (Func<PropertyMetadata, bool>)((PropertyMetadata a) => ((IMetadata)a).get_Uid() == CS_0024_003C_003E8__locals0.parentPropertyUid));
		IMetadata metadata = GetMetadata(moduleUid, ((IPropertyMetadata)val).get_SubTypeUid());
		TablePartMetadata tablePartMetadata2;
		if ((tablePartMetadata2 = (TablePartMetadata)(object)((metadata is TablePartMetadata) ? metadata : null)) == null)
		{
			return (EntityMetadata)metadata;
		}
		return GetTablePartRoot(moduleUid, tablePartMetadata2);
	}

	private static DataClassMetadata GetViewModelMetadataFromEntityConfigExtension(EntityMetadata extensionMetadata, string metadataConfigExtName)
	{
		if (extensionMetadata == null)
		{
			return null;
		}
		if (((INamedMetadata)extensionMetadata).get_Name() != metadataConfigExtName)
		{
			return null;
		}
		return extensionMetadata.get_ViewModelMetadata();
	}

	private void InternalProcessMetadata(Guid moduleUid, IMetadata metadata, Guid? saveAsMetadataUid = null)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Unknown result type (might be due to invalid IL or missing references)
		//IL_018e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_026c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0281: Unknown result type (might be due to invalid IL or missing references)
		//IL_0293: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0349: Unknown result type (might be due to invalid IL or missing references)
		//IL_036a: Unknown result type (might be due to invalid IL or missing references)
		//IL_037c: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_0427: Unknown result type (might be due to invalid IL or missing references)
		//IL_042c: Unknown result type (might be due to invalid IL or missing references)
		_003C_003Ec__DisplayClass43_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass43_0();
		TablePartMetadata val;
		if ((val = (TablePartMetadata)(object)((metadata is TablePartMetadata) ? metadata : null)) != null)
		{
			((IPropertyMetadata)val).set_TypeUid(MetadataConstants.TablePartMetadataTypeUid);
			((IPropertyMetadata)val).set_Settings((TypeSettings)(object)InterfaceCreator.Create<TablePartSettings>());
		}
		EntityMetadata val2;
		if ((val2 = (EntityMetadata)(object)((metadata is EntityMetadata) ? metadata : null)) != null)
		{
			ProcessMetadata(moduleUid, (System.Collections.Generic.IEnumerable<IMetadata>)val2.get_TableParts());
		}
		DataClassMetadata metadata2;
		if ((metadata2 = (DataClassMetadata)(object)((metadata is DataClassMetadata) ? metadata : null)) != null)
		{
			ProcessMetadataByName(moduleUid, metadata2);
		}
		string text = ((object)(Guid)(ref moduleUid)).ToString();
		TypedMap<string, IMetadata> val3 = implementationsByUid.Get(text);
		if (val3 == null)
		{
			val3 = new TypedMap<string, IMetadata>();
		}
		CS_0024_003C_003E8__locals0.metadataUid = metadata.get_Uid();
		EntityMetadata val4;
		Guid val6;
		if ((val4 = (EntityMetadata)(object)((metadata is EntityMetadata) ? metadata : null)) != null)
		{
			TypedMap<string, IMetadata> val5 = metadataByUid.Get(text);
			if (val5 == null)
			{
				val5 = new TypedMap<string, IMetadata>();
			}
			Guid implementationUid = val4.get_ImplementationUid();
			if (val4.get_Type() == 0 || val4.get_Type() == 3)
			{
				val3.Set(((object)(Guid)(ref CS_0024_003C_003E8__locals0.metadataUid)).ToString(), metadata);
				val5.Set(((object)(Guid)(ref implementationUid)).ToString(), metadata);
				if (saveAsMetadataUid.get_HasValue())
				{
					val6 = CS_0024_003C_003E8__locals0.metadataUid;
					Guid? val7 = saveAsMetadataUid;
					if ((!val7.get_HasValue() || val6 != val7.GetValueOrDefault()) && CS_0024_003C_003E8__locals0.metadataUid != implementationUid)
					{
						val5.Set(((object)saveAsMetadataUid).ToString(), metadata);
					}
				}
			}
			else
			{
				val5.Set(((object)(Guid)(ref CS_0024_003C_003E8__locals0.metadataUid)).ToString(), metadata);
				if (saveAsMetadataUid.get_HasValue())
				{
					val6 = CS_0024_003C_003E8__locals0.metadataUid;
					Guid? val7 = saveAsMetadataUid;
					if (!val7.get_HasValue() || val6 != val7.GetValueOrDefault())
					{
						val5.Set(((object)saveAsMetadataUid).ToString(), metadata);
					}
				}
				CS_0024_003C_003E8__locals0.metadataUid = implementationUid;
			}
			metadataByUid.Set(text, val5);
		}
		else
		{
			val3.Set(((object)(Guid)(ref CS_0024_003C_003E8__locals0.metadataUid)).ToString(), metadata);
		}
		implementationsByUid.Set(text, val3);
		ICodeItemMetadata val8;
		if (applicationData.InterfaceBuilderMode == InterfaceBuilderMode.DevServer && (val8 = (ICodeItemMetadata)(object)((metadata is ICodeItemMetadata) ? metadata : null)) != null)
		{
			MetadataHeader[] array = metadataHeaders.Get(text);
			if (array == null)
			{
				array = (MetadataHeader[])(object)new MetadataHeader[0];
				metadataHeaders.Set(text, array);
			}
			MetadataHeader val9 = array.Find((Func<MetadataHeader, bool>)((MetadataHeader a) => a.get_Uid() == CS_0024_003C_003E8__locals0.metadataUid));
			if (val9 == null)
			{
				if (array.Length != 0)
				{
					ArrayExtensions.Push<MetadataHeader>(array, (MetadataHeader[])(object)new MetadataHeader[1] { CreateHeader(val8, CS_0024_003C_003E8__locals0.metadataUid) });
				}
			}
			else
			{
				val9.set_Name(((INamedMetadata)metadata).get_Name());
				val9.set_DisplayName(((INamedMetadata)metadata).get_DisplayName());
				val9.set_Namespace(val8.get_Namespace());
				val9.set_NamespaceForDisplay(val8.get_NamespaceForDisplay());
				val9.set_ModuleUid(((IMetadata)val8).get_ModuleUid());
				val9.set_Internal(((IMetadata)val8).get_Internal());
				IGroupedMetadata val10;
				val9.set_GroupId(((val10 = (IGroupedMetadata)(object)((val8 is IGroupedMetadata) ? val8 : null)) != null) ? val10.get_GroupId() : 0);
			}
			MetadataHeader[] array2 = draftMetadataHeaders.Get(text);
			if (array2 == null)
			{
				array2 = (MetadataHeader[])(object)new MetadataHeader[0];
				draftMetadataHeaders.Set(text, array2);
			}
			MetadataHeader val11 = array2.Find((Func<MetadataHeader, bool>)((MetadataHeader a) => a.get_Uid() == CS_0024_003C_003E8__locals0.metadataUid));
			if (val11 == null)
			{
				ArrayExtensions.Push<MetadataHeader>(array2, (MetadataHeader[])(object)new MetadataHeader[1] { CreateHeader(val8, CS_0024_003C_003E8__locals0.metadataUid) });
			}
			else
			{
				EntityMetadata val12 = (EntityMetadata)(object)((val8 is EntityMetadata) ? val8 : null);
				val11.set_Name(((INamedMetadata)metadata).get_Name());
				val11.set_DisplayName(((INamedMetadata)metadata).get_DisplayName());
				val11.set_Namespace(val8.get_Namespace());
				val11.set_NamespaceForDisplay(val8.get_NamespaceForDisplay());
				val11.set_ModuleUid(((IMetadata)val8).get_ModuleUid());
				val11.set_Internal(((IMetadata)val8).get_Internal());
				IGroupedMetadata val13;
				val11.set_GroupId(((val13 = (IGroupedMetadata)(object)((val8 is IGroupedMetadata) ? val8 : null)) != null) ? val13.get_GroupId() : 0);
				EnumMetadata val14;
				val11.set_ShowInTypeTree((val12 != null) ? ((ClassMetadata)val12).get_ShowInTypeTree() : ((val14 = (EnumMetadata)(object)((val8 is EnumMetadata) ? val8 : null)) == null || val14.get_ShowInTypeTree()));
				val11.set_ShowInCatalogList(val12 != null && val12.get_ShowInCatalogList());
			}
		}
		IProxyCacheService obj = proxyCacheService;
		val6 = metadata.get_Uid();
		obj.Update(((object)(Guid)(ref val6)).ToString());
	}

	private MetadataHeader CreateHeader(ICodeItemMetadata codeItemMetadataDto, Guid metadataUid)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		EntityMetadata val = (EntityMetadata)(object)((codeItemMetadataDto is EntityMetadata) ? codeItemMetadataDto : null);
		MetadataHeader obj = InterfaceCreator.Create<MetadataHeader>();
		obj.set_MetadataType(MetadataHelper.GetMetadataType(codeItemMetadataDto));
		obj.set_Uid(metadataUid);
		obj.set_Internal(((IMetadata)codeItemMetadataDto).get_Internal());
		obj.set_ModuleUid(((IMetadata)codeItemMetadataDto).get_ModuleUid());
		obj.set_Name(((INamedMetadata)codeItemMetadataDto).get_Name());
		obj.set_DisplayName(((INamedMetadata)codeItemMetadataDto).get_DisplayName());
		obj.set_Namespace(codeItemMetadataDto.get_Namespace());
		obj.set_NamespaceForDisplay(codeItemMetadataDto.get_NamespaceForDisplay());
		IGroupedMetadata val2;
		obj.set_GroupId(((val2 = (IGroupedMetadata)(object)((codeItemMetadataDto is IGroupedMetadata) ? codeItemMetadataDto : null)) != null) ? val2.get_GroupId() : 0);
		obj.set_Status(1);
		EnumMetadata val3;
		obj.set_ShowInTypeTree((val != null) ? ((ClassMetadata)val).get_ShowInTypeTree() : ((val3 = (EnumMetadata)(object)((codeItemMetadataDto is EnumMetadata) ? codeItemMetadataDto : null)) == null || val3.get_ShowInTypeTree()));
		obj.set_ShowInCatalogList(val != null && val.get_ShowInCatalogList());
		return obj;
	}

	private void ProcessMetadataByName(Guid moduleUid, DataClassMetadata metadata)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		if (metadata != null)
		{
			string typeRef = metadata.get_TypeRef();
			Guid uid = ((IMetadata)metadata).get_Uid();
			string text = ((object)(Guid)(ref uid)).ToString();
			if (string.IsNullOrWhiteSpace(typeRef))
			{
				typeRef = ((ISystemMetadataTypeReferenceStorage)metadataReferenceStorage).GetTypeReference(text);
				metadata.set_TypeRef(typeRef);
			}
			else
			{
				((ISystemMetadataTypeReferenceStorage)metadataReferenceStorage).SetReference(typeRef, text);
			}
		}
	}

	private System.Threading.Tasks.Task LoadHeaders(Guid moduleUid)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		_003CLoadHeaders_003Ed__46 _003CLoadHeaders_003Ed__ = default(_003CLoadHeaders_003Ed__46);
		_003CLoadHeaders_003Ed__._003C_003E4__this = this;
		_003CLoadHeaders_003Ed__.moduleUid = moduleUid;
		_003CLoadHeaders_003Ed__._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		_003CLoadHeaders_003Ed__._003C_003E1__state = -1;
		AsyncTaskMethodBuilder _003C_003Et__builder = _003CLoadHeaders_003Ed__._003C_003Et__builder;
		((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).Start<_003CLoadHeaders_003Ed__46>(ref _003CLoadHeaders_003Ed__);
		return ((AsyncTaskMethodBuilder)(ref _003CLoadHeaders_003Ed__._003C_003Et__builder)).get_Task();
	}

	private System.Threading.Tasks.Task LoadMetadataHeaders(Guid moduleUid)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		_003CLoadMetadataHeaders_003Ed__47 _003CLoadMetadataHeaders_003Ed__ = default(_003CLoadMetadataHeaders_003Ed__47);
		_003CLoadMetadataHeaders_003Ed__._003C_003E4__this = this;
		_003CLoadMetadataHeaders_003Ed__.moduleUid = moduleUid;
		_003CLoadMetadataHeaders_003Ed__._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		_003CLoadMetadataHeaders_003Ed__._003C_003E1__state = -1;
		AsyncTaskMethodBuilder _003C_003Et__builder = _003CLoadMetadataHeaders_003Ed__._003C_003Et__builder;
		((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).Start<_003CLoadMetadataHeaders_003Ed__47>(ref _003CLoadMetadataHeaders_003Ed__);
		return ((AsyncTaskMethodBuilder)(ref _003CLoadMetadataHeaders_003Ed__._003C_003Et__builder)).get_Task();
	}

	private System.Threading.Tasks.Task LoadNamespaceMetadata(Guid moduleUid)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		_003CLoadNamespaceMetadata_003Ed__48 _003CLoadNamespaceMetadata_003Ed__ = default(_003CLoadNamespaceMetadata_003Ed__48);
		_003CLoadNamespaceMetadata_003Ed__._003C_003E4__this = this;
		_003CLoadNamespaceMetadata_003Ed__.moduleUid = moduleUid;
		_003CLoadNamespaceMetadata_003Ed__._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		_003CLoadNamespaceMetadata_003Ed__._003C_003E1__state = -1;
		AsyncTaskMethodBuilder _003C_003Et__builder = _003CLoadNamespaceMetadata_003Ed__._003C_003Et__builder;
		((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).Start<_003CLoadNamespaceMetadata_003Ed__48>(ref _003CLoadNamespaceMetadata_003Ed__);
		return ((AsyncTaskMethodBuilder)(ref _003CLoadNamespaceMetadata_003Ed__._003C_003Et__builder)).get_Task();
	}

	private System.Threading.Tasks.Task LoadNamespaceInfo(Guid moduleUid)
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		_003CLoadNamespaceInfo_003Ed__49 _003CLoadNamespaceInfo_003Ed__ = default(_003CLoadNamespaceInfo_003Ed__49);
		_003CLoadNamespaceInfo_003Ed__._003C_003E4__this = this;
		_003CLoadNamespaceInfo_003Ed__.moduleUid = moduleUid;
		_003CLoadNamespaceInfo_003Ed__._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		_003CLoadNamespaceInfo_003Ed__._003C_003E1__state = -1;
		AsyncTaskMethodBuilder _003C_003Et__builder = _003CLoadNamespaceInfo_003Ed__._003C_003Et__builder;
		((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).Start<_003CLoadNamespaceInfo_003Ed__49>(ref _003CLoadNamespaceInfo_003Ed__);
		return ((AsyncTaskMethodBuilder)(ref _003CLoadNamespaceInfo_003Ed__._003C_003Et__builder)).get_Task();
	}

	private System.Threading.Tasks.Task<LoadMetadataHeadersRequest[]> GetChanges()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		_003CGetChanges_003Ed__50 _003CGetChanges_003Ed__ = default(_003CGetChanges_003Ed__50);
		_003CGetChanges_003Ed__._003C_003E4__this = this;
		_003CGetChanges_003Ed__._003C_003Et__builder = AsyncTaskMethodBuilder<LoadMetadataHeadersRequest[]>.Create();
		_003CGetChanges_003Ed__._003C_003E1__state = -1;
		AsyncTaskMethodBuilder<LoadMetadataHeadersRequest[]> _003C_003Et__builder = _003CGetChanges_003Ed__._003C_003Et__builder;
		_003C_003Et__builder.Start<_003CGetChanges_003Ed__50>(ref _003CGetChanges_003Ed__);
		return _003CGetChanges_003Ed__._003C_003Et__builder.get_Task();
	}

	private System.Threading.Tasks.Task UpdateHeaders(LoadMetadataHeadersRequest[] updated, Guid moduleUid)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		_003CUpdateHeaders_003Ed__51 _003CUpdateHeaders_003Ed__ = default(_003CUpdateHeaders_003Ed__51);
		_003CUpdateHeaders_003Ed__._003C_003E4__this = this;
		_003CUpdateHeaders_003Ed__.updated = updated;
		_003CUpdateHeaders_003Ed__.moduleUid = moduleUid;
		_003CUpdateHeaders_003Ed__._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		_003CUpdateHeaders_003Ed__._003C_003E1__state = -1;
		AsyncTaskMethodBuilder _003C_003Et__builder = _003CUpdateHeaders_003Ed__._003C_003Et__builder;
		((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).Start<_003CUpdateHeaders_003Ed__51>(ref _003CUpdateHeaders_003Ed__);
		return ((AsyncTaskMethodBuilder)(ref _003CUpdateHeaders_003Ed__._003C_003Et__builder)).get_Task();
	}

	private System.Collections.Generic.IEnumerable<PropertyMetadata> GetExtensionProperties(Guid moduleUid, Guid metadataUid, Guid propertyUid)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		_003C_003Ec__DisplayClass52_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass52_0();
		CS_0024_003C_003E8__locals0.propertyUid = propertyUid;
		string text = ((object)(Guid)(ref moduleUid)).ToString();
		TypedMap<string, IMetadata> val = metadataByUid.Get(text);
		if (val != null)
		{
			PropertyMetadata[] array = (PropertyMetadata[])(object)new PropertyMetadata[0];
			for (int i = 0; i < val.get_Values().Length; i++)
			{
				IMetadata obj = val.get_Values()[i];
				EntityMetadata val2 = (EntityMetadata)(object)((obj is EntityMetadata) ? obj : null);
				if (val2 == null || ((ClassMetadata)val2).get_BaseClassUid() != metadataUid || val2.get_Type() != 2)
				{
					continue;
				}
				if (CS_0024_003C_003E8__locals0.propertyUid == Guid.Empty)
				{
					System.Collections.Generic.IEnumerator<PropertyMetadata> enumerator = ((System.Collections.Generic.IEnumerable<PropertyMetadata>)((ClassMetadata)val2).get_Properties()).GetEnumerator();
					try
					{
						while (((System.Collections.IEnumerator)enumerator).MoveNext())
						{
							PropertyMetadata current = enumerator.get_Current();
							ArrayExtensions.Push<PropertyMetadata>(array, (PropertyMetadata[])(object)new PropertyMetadata[1] { current });
						}
					}
					finally
					{
						((System.IDisposable)enumerator)?.Dispose();
					}
				}
				else
				{
					PropertyMetadata val3 = Enumerable.FirstOrDefault<PropertyMetadata>((System.Collections.Generic.IEnumerable<PropertyMetadata>)((ClassMetadata)val2).get_Properties(), (Func<PropertyMetadata, bool>)((PropertyMetadata prop) => ((IMetadata)prop).get_Uid() == CS_0024_003C_003E8__locals0.propertyUid));
					if (val3 != null)
					{
						ArrayExtensions.Push<PropertyMetadata>(array, (PropertyMetadata[])(object)new PropertyMetadata[1] { val3 });
						break;
					}
				}
			}
			return array;
		}
		return (System.Collections.Generic.IEnumerable<PropertyMetadata>)Enumerable.Empty<PropertyMetadata>();
	}

	private ValueTuple<ClassMetadata, IPropertyMetadata> GetExtensionPropertyWithOwner(Guid moduleUid, Guid metadataUid, Guid propertyUid, List<Guid> used)
	{
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		TypedMap<string, IMetadata> val = metadataByUid.Get(((object)(Guid)(ref moduleUid)).ToString());
		if (val != null)
		{
			IMetadata[] values = val.get_Values();
			foreach (IMetadata val2 in values)
			{
				if (used.Contains(val2.get_Uid()))
				{
					continue;
				}
				EntityMetadata val3 = (EntityMetadata)(object)((val2 is EntityMetadata) ? val2 : null);
				if (val3 == null || ((ClassMetadata)val3).get_BaseClassUid() != metadataUid || val3.get_Type() != 2)
				{
					continue;
				}
				used.Add(((IMetadata)val3).get_Uid());
				if (!(propertyUid == Guid.Empty))
				{
					ValueTuple<ClassMetadata, IPropertyMetadata> propertyWithOwner = GetPropertyWithOwner(moduleUid, (ClassMetadata)(object)val3, propertyUid, used);
					ClassMetadata item = propertyWithOwner.Item1;
					IPropertyMetadata item2 = propertyWithOwner.Item2;
					if (item2 != null)
					{
						return new ValueTuple<ClassMetadata, IPropertyMetadata>(item, item2);
					}
				}
			}
		}
		return new ValueTuple<ClassMetadata, IPropertyMetadata>((ClassMetadata)null, (IPropertyMetadata)null);
	}

	internal static void _003CGetProperties_003Eg__AddIfNotExistProperties_007C27_0(IPropertyMetadata[] array, System.Collections.Generic.IEnumerable<IPropertyMetadata> properties)
	{
		System.Collections.Generic.IEnumerator<IPropertyMetadata> enumerator = properties.GetEnumerator();
		try
		{
			while (((System.Collections.IEnumerator)enumerator).MoveNext())
			{
				_003C_003Ec__DisplayClass27_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass27_0();
				CS_0024_003C_003E8__locals0.prop = enumerator.get_Current();
				if (Enumerable.FirstOrDefault<IPropertyMetadata>((System.Collections.Generic.IEnumerable<IPropertyMetadata>)array, (Func<IPropertyMetadata, bool>)((IPropertyMetadata a) => ((IMetadata)a).get_Uid() == ((IMetadata)CS_0024_003C_003E8__locals0.prop).get_Uid())) == null)
				{
					ArrayExtensions.Push<IPropertyMetadata>(array, (IPropertyMetadata[])(object)new IPropertyMetadata[1] { CS_0024_003C_003E8__locals0.prop });
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator)?.Dispose();
		}
	}
}
