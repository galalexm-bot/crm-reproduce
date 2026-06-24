using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using EleWise.ELMA.Cache.Models;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.Metadata;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.DTO;
using EleWise.ELMA.Ioc;
using EleWise.ELMA.Model;
using EleWise.ELMA.Serialization;

namespace EleWise.ELMA.Cache;

[Service]
internal sealed class MetadataCacheService : CacheService, IMetadataCacheService
{
	[StructLayout(3)]
	private struct _003CGetMetadataUids_003Ed__5 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<IMetadataUidDifference> _003C_003Et__builder;

		public MetadataCacheService _003C_003E4__this;

		private Guid[] _003CexistUids_003E5__2;

		private object _003C_003Eu__1;

		private string[] _003C_003E7__wrap2;

		private int _003C_003E7__wrap3;

		private Guid _003Cuid_003E5__5;

		private void MoveNext()
		{
			//IL_0101: Unknown result type (might be due to invalid IL or missing references)
			//IL_0106: Unknown result type (might be due to invalid IL or missing references)
			//IL_018b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0190: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			MetadataCacheService metadataCacheService = _003C_003E4__this;
			IMetadataUidDifference result;
			try
			{
				TaskAwaiter<string[]> val;
				if (num == 0)
				{
					val = (TaskAwaiter<string[]>)_003C_003Eu__1;
					_003C_003Eu__1 = null;
					num = (_003C_003E1__state = -1);
					goto IL_009a;
				}
				TaskAwaiter<object> val2;
				if (num == 1)
				{
					val2 = (TaskAwaiter<object>)_003C_003Eu__1;
					_003C_003Eu__1 = null;
					num = (_003C_003E1__state = -1);
					goto IL_0173;
				}
				_003CexistUids_003E5__2 = (Guid[])(object)new Guid[0];
				if (!metadataCacheService.IsDevServer)
				{
					val = metadataCacheService.GetAllKeys().GetAwaiter();
					if (!val.get_IsCompleted())
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = val;
						_003C_003Et__builder.AwaitOnCompleted<TaskAwaiter<string[]>, _003CGetMetadataUids_003Ed__5>(ref val, ref this);
						return;
					}
					goto IL_009a;
				}
				result = new MetadataUidDifference((Guid[])(object)new Guid[0], (Guid[])(object)new Guid[0]);
				goto end_IL_000e;
				IL_01a6:
				_003C_003E7__wrap3++;
				goto IL_01b4;
				IL_009a:
				string[] array = (_003C_003E7__wrap2 = val.GetResult());
				_003C_003E7__wrap3 = 0;
				goto IL_01b4;
				IL_01b4:
				if (_003C_003E7__wrap3 < _003C_003E7__wrap2.Length)
				{
					string text = _003C_003E7__wrap2[_003C_003E7__wrap3];
					if (text.StartsWith(metadataCacheService.Hash + "_"))
					{
						string text2 = text.Replace(metadataCacheService.Hash + "_", "");
						_003Cuid_003E5__5 = new Guid(text2);
						val2 = metadataCacheService.Get(((object)(Guid)(ref _003Cuid_003E5__5)).ToString()).GetAwaiter();
						if (!val2.get_IsCompleted())
						{
							num = (_003C_003E1__state = 1);
							_003C_003Eu__1 = val2;
							_003C_003Et__builder.AwaitOnCompleted<TaskAwaiter<object>, _003CGetMetadataUids_003Ed__5>(ref val2, ref this);
							return;
						}
						goto IL_0173;
					}
					goto IL_01a6;
				}
				_003C_003E7__wrap2 = null;
				result = new MetadataUidDifference(_003CexistUids_003E5__2, (Guid[])(object)new Guid[0]);
				goto end_IL_000e;
				IL_0173:
				if (val2.GetResult() != null)
				{
					ArrayExtensions.Push<Guid>(_003CexistUids_003E5__2, (Guid[])(object)new Guid[1] { _003Cuid_003E5__5 });
					_003Cuid_003E5__5 = default(Guid);
				}
				goto IL_01a6;
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

	[StructLayout(3)]
	private struct _003CGetDifferenceMetadataUids_003Ed__6 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<IMetadataUidDifference> _003C_003Et__builder;

		public System.Collections.Generic.IEnumerable<Guid> metadataUidList;

		public MetadataCacheService _003C_003E4__this;

		private object _003C_003Eu__1;

		private void MoveNext()
		{
			//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00da: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			MetadataCacheService metadataCacheService = _003C_003E4__this;
			IMetadataUidDifference result;
			try
			{
				TaskAwaiter<IMetadataUidDifference> val;
				if (num == 0)
				{
					val = (TaskAwaiter<IMetadataUidDifference>)_003C_003Eu__1;
					_003C_003Eu__1 = null;
					num = (_003C_003E1__state = -1);
					goto IL_008f;
				}
				if (metadataUidList != null && !metadataCacheService.IsDevServer)
				{
					val = metadataCacheService.GetMetadataUids().GetAwaiter();
					if (!val.get_IsCompleted())
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = val;
						_003C_003Et__builder.AwaitOnCompleted<TaskAwaiter<IMetadataUidDifference>, _003CGetDifferenceMetadataUids_003Ed__6>(ref val, ref this);
						return;
					}
					goto IL_008f;
				}
				result = new MetadataUidDifference((Guid[])(object)new Guid[0], (Guid[])(object)new Guid[0]);
				goto end_IL_000e;
				IL_008f:
				Guid[] existUids = val.GetResult().ExistUids;
				Guid[] array = (Guid[])(object)new Guid[0];
				Guid[] array2 = (Guid[])(object)new Guid[0];
				System.Collections.Generic.IEnumerator<Guid> enumerator = metadataUidList.GetEnumerator();
				try
				{
					while (((System.Collections.IEnumerator)enumerator).MoveNext())
					{
						Guid current = enumerator.get_Current();
						if (ArrayExtensions.Contains<Guid>(existUids, current))
						{
							ArrayExtensions.Push<Guid>(array, (Guid[])(object)new Guid[1] { current });
						}
						else
						{
							ArrayExtensions.Push<Guid>(array2, (Guid[])(object)new Guid[1] { current });
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
				result = new MetadataUidDifference(array, array2);
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

	[StructLayout(3)]
	private struct _003CGetFromCache_003Ed__7 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<System.Collections.Generic.IEnumerable<IMetadata>> _003C_003Et__builder;

		public MetadataCacheService _003C_003E4__this;

		public System.Collections.Generic.IEnumerable<Guid> metadataUidList;

		private IMetadata[] _003CmetadataList_003E5__2;

		private object _003C_003Eu__1;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			MetadataCacheService metadataCacheService = _003C_003E4__this;
			System.Collections.Generic.IEnumerable<IMetadata> result;
			try
			{
				TaskAwaiter<object[]> val;
				if (num == 0)
				{
					val = (TaskAwaiter<object[]>)_003C_003Eu__1;
					_003C_003Eu__1 = null;
					num = (_003C_003E1__state = -1);
					goto IL_00a0;
				}
				_003CmetadataList_003E5__2 = (IMetadata[])(object)new IMetadata[0];
				if (!metadataCacheService.IsDevServer)
				{
					val = metadataCacheService.GetValues(Enumerable.Select<Guid, string>(metadataUidList, (Func<Guid, string>)metadataCacheService.GetKey).ToArray()).GetAwaiter();
					if (!val.get_IsCompleted())
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = val;
						_003C_003Et__builder.AwaitOnCompleted<TaskAwaiter<object[]>, _003CGetFromCache_003Ed__7>(ref val, ref this);
						return;
					}
					goto IL_00a0;
				}
				result = _003CmetadataList_003E5__2;
				goto end_IL_000e;
				IL_00a0:
				object[] result2 = val.GetResult();
				foreach (object value in result2)
				{
					IMetadata val2 = ObjectExtensions.As<IMetadata>(ConvertHelper.DeserializeWithType(typeof(IMetadata), value, metadataCacheService.ConvertContext));
					if (val2 != null)
					{
						ArrayExtensions.Push<IMetadata>(_003CmetadataList_003E5__2, (IMetadata[])(object)new IMetadata[1] { val2 });
					}
				}
				result = _003CmetadataList_003E5__2;
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

	private const string StorageName = "Metadata";

	protected override string StoreName => "Metadata";

	private bool IsDevServer => base.ApplicationData.InterfaceBuilderMode == InterfaceBuilderMode.DevServer;

	private string Hash => base.ApplicationData.RuntimeModelHash;

	public MetadataCacheService(IApplicationData applicationData, ILazy<IExtendEntityService> extendEntityServiceLazy, ILazy<IProxyGeneratorService> proxyGeneratorServiceLazy)
		: base(applicationData, extendEntityServiceLazy, proxyGeneratorServiceLazy)
	{
	}

	public void Cache(System.Collections.Generic.IEnumerable<IMetadata> metadataList)
	{
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		if (metadataList == null || IsDevServer)
		{
			return;
		}
		Guid[] array = (Guid[])(object)new Guid[0];
		System.Collections.Generic.IEnumerator<IMetadata> enumerator = metadataList.GetEnumerator();
		try
		{
			while (((System.Collections.IEnumerator)enumerator).MoveNext())
			{
				IMetadata current = enumerator.get_Current();
				EntityMetadata val;
				if (!(current is TablePartMetadata) && ((val = (EntityMetadata)(object)((current is EntityMetadata) ? current : null)) == null || !((ICodeItemMetadata)val).get_FullTypeName().StartsWith("EleWise.ELMA.Model.Entities.ProcessContext.")))
				{
					object value = ((object)current).get_Item("$jsonObj");
					Set(GetKey(current.get_Uid()), value);
					ArrayExtensions.Push<Guid>(array, (Guid[])(object)new Guid[1] { current.get_Uid() });
				}
			}
		}
		finally
		{
			((System.IDisposable)enumerator)?.Dispose();
		}
	}

	public System.Threading.Tasks.Task<IMetadataUidDifference> GetMetadataUids()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		_003CGetMetadataUids_003Ed__5 _003CGetMetadataUids_003Ed__ = default(_003CGetMetadataUids_003Ed__5);
		_003CGetMetadataUids_003Ed__._003C_003E4__this = this;
		_003CGetMetadataUids_003Ed__._003C_003Et__builder = AsyncTaskMethodBuilder<IMetadataUidDifference>.Create();
		_003CGetMetadataUids_003Ed__._003C_003E1__state = -1;
		AsyncTaskMethodBuilder<IMetadataUidDifference> _003C_003Et__builder = _003CGetMetadataUids_003Ed__._003C_003Et__builder;
		_003C_003Et__builder.Start<_003CGetMetadataUids_003Ed__5>(ref _003CGetMetadataUids_003Ed__);
		return _003CGetMetadataUids_003Ed__._003C_003Et__builder.get_Task();
	}

	public System.Threading.Tasks.Task<IMetadataUidDifference> GetDifferenceMetadataUids(System.Collections.Generic.IEnumerable<Guid> metadataUidList)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		_003CGetDifferenceMetadataUids_003Ed__6 _003CGetDifferenceMetadataUids_003Ed__ = default(_003CGetDifferenceMetadataUids_003Ed__6);
		_003CGetDifferenceMetadataUids_003Ed__._003C_003E4__this = this;
		_003CGetDifferenceMetadataUids_003Ed__.metadataUidList = metadataUidList;
		_003CGetDifferenceMetadataUids_003Ed__._003C_003Et__builder = AsyncTaskMethodBuilder<IMetadataUidDifference>.Create();
		_003CGetDifferenceMetadataUids_003Ed__._003C_003E1__state = -1;
		AsyncTaskMethodBuilder<IMetadataUidDifference> _003C_003Et__builder = _003CGetDifferenceMetadataUids_003Ed__._003C_003Et__builder;
		_003C_003Et__builder.Start<_003CGetDifferenceMetadataUids_003Ed__6>(ref _003CGetDifferenceMetadataUids_003Ed__);
		return _003CGetDifferenceMetadataUids_003Ed__._003C_003Et__builder.get_Task();
	}

	public System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<IMetadata>> GetFromCache(System.Collections.Generic.IEnumerable<Guid> metadataUidList)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		_003CGetFromCache_003Ed__7 _003CGetFromCache_003Ed__ = default(_003CGetFromCache_003Ed__7);
		_003CGetFromCache_003Ed__._003C_003E4__this = this;
		_003CGetFromCache_003Ed__.metadataUidList = metadataUidList;
		_003CGetFromCache_003Ed__._003C_003Et__builder = AsyncTaskMethodBuilder<System.Collections.Generic.IEnumerable<IMetadata>>.Create();
		_003CGetFromCache_003Ed__._003C_003E1__state = -1;
		AsyncTaskMethodBuilder<System.Collections.Generic.IEnumerable<IMetadata>> _003C_003Et__builder = _003CGetFromCache_003Ed__._003C_003Et__builder;
		_003C_003Et__builder.Start<_003CGetFromCache_003Ed__7>(ref _003CGetFromCache_003Ed__);
		return _003CGetFromCache_003Ed__._003C_003Et__builder.get_Task();
	}

	private string GetKey(Guid metadataUid)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		return $"{Hash}_{metadataUid}";
	}
}
