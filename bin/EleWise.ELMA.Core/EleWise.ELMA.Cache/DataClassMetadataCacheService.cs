using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using EleWise.ELMA.Cache.Models;
using EleWise.ELMA.Core;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.UI;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.DTO;
using EleWise.ELMA.Ioc;
using EleWise.ELMA.Model;
using EleWise.ELMA.Serialization;

namespace EleWise.ELMA.Cache;

[Service]
internal sealed class DataClassMetadataCacheService : CacheService, IDataClassMetadataCacheService
{
	[StructLayout(3)]
	private struct _003CGetFromCache_003Ed__5 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<System.Collections.Generic.IEnumerable<RuntimeDataClassModel>> _003C_003Et__builder;

		public DataClassMetadataCacheService _003C_003E4__this;

		public System.Collections.Generic.IEnumerable<Guid> metadataUidList;

		private RuntimeDataClassModel[] _003CmetadataList_003E5__2;

		private object _003C_003Eu__1;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			DataClassMetadataCacheService dataClassMetadataCacheService = _003C_003E4__this;
			System.Collections.Generic.IEnumerable<RuntimeDataClassModel> result;
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
				_003CmetadataList_003E5__2 = (RuntimeDataClassModel[])(object)new RuntimeDataClassModel[0];
				if (!dataClassMetadataCacheService.IsDevServer)
				{
					val = dataClassMetadataCacheService.GetValues(Enumerable.Select<Guid, string>(metadataUidList, (Func<Guid, string>)GetKey).ToArray()).GetAwaiter();
					if (!val.get_IsCompleted())
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = val;
						_003C_003Et__builder.AwaitOnCompleted<TaskAwaiter<object[]>, _003CGetFromCache_003Ed__5>(ref val, ref this);
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
					ArrayExtensions.Push<RuntimeDataClassModel>(_003CmetadataList_003E5__2, (RuntimeDataClassModel[])(object)new RuntimeDataClassModel[1] { ObjectExtensions.As<RuntimeDataClassModel>(ConvertHelper.DeserializeWithType(typeof(RuntimeDataClassModel), value, dataClassMetadataCacheService.ConvertContext)) });
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

	[StructLayout(3)]
	private struct _003CGetDifferenceMetadataUids_003Ed__6 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<IMetadataUidDifference> _003C_003Et__builder;

		public System.Collections.Generic.IEnumerable<Guid> metadataUidList;

		public DataClassMetadataCacheService _003C_003E4__this;

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
			DataClassMetadataCacheService dataClassMetadataCacheService = _003C_003E4__this;
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
				if (metadataUidList != null && !dataClassMetadataCacheService.IsDevServer)
				{
					val = dataClassMetadataCacheService.GetMetadataUids().GetAwaiter();
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

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();

		public static Func<string, Guid> _003C_003E9__7_0;

		internal Guid _003CGetMetadataUids_003Eb__7_0(string a)
		{
			//IL_0013: Unknown result type (might be due to invalid IL or missing references)
			return new Guid(a.Substring(0, a.IndexOf("_", (StringComparison)4)));
		}
	}

	[StructLayout(3)]
	private struct _003CGetMetadataUids_003Ed__7 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<IMetadataUidDifference> _003C_003Et__builder;

		public DataClassMetadataCacheService _003C_003E4__this;

		private object _003C_003Eu__1;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			DataClassMetadataCacheService dataClassMetadataCacheService = _003C_003E4__this;
			IMetadataUidDifference result;
			try
			{
				TaskAwaiter<string[]> val;
				if (num != 0)
				{
					val = dataClassMetadataCacheService.GetAllKeys().GetAwaiter();
					if (!val.get_IsCompleted())
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = val;
						_003C_003Et__builder.AwaitOnCompleted<TaskAwaiter<string[]>, _003CGetMetadataUids_003Ed__7>(ref val, ref this);
						return;
					}
				}
				else
				{
					val = (TaskAwaiter<string[]>)_003C_003Eu__1;
					_003C_003Eu__1 = null;
					num = (_003C_003E1__state = -1);
				}
				result = new MetadataUidDifference(Enumerable.Select<string, Guid>((System.Collections.Generic.IEnumerable<string>)val.GetResult(), (Func<string, Guid>)((string a) => new Guid(a.Substring(0, a.IndexOf("_", (StringComparison)4))))).ToArray(), (Guid[])(object)new Guid[0]);
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

	private const string StorageName = "DataClassMetadataStore";

	protected override string StoreName => "DataClassMetadataStore";

	private bool IsDevServer => base.ApplicationData.InterfaceBuilderMode == InterfaceBuilderMode.DevServer;

	public DataClassMetadataCacheService(IApplicationData applicationData, ILazy<IExtendEntityService> extendEntityServiceLazy, ILazy<IProxyGeneratorService> proxyGeneratorServiceLazy)
		: base(applicationData, extendEntityServiceLazy, proxyGeneratorServiceLazy)
	{
	}

	public void Cache(System.Collections.Generic.ICollection<RuntimeDataClassModel> dataClassModels)
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		if (IsDevServer)
		{
			return;
		}
		System.Collections.Generic.IEnumerator<RuntimeDataClassModel> enumerator = ((System.Collections.Generic.IEnumerable<RuntimeDataClassModel>)dataClassModels).GetEnumerator();
		try
		{
			while (((System.Collections.IEnumerator)enumerator).MoveNext())
			{
				RuntimeDataClassModel current = enumerator.get_Current();
				object value = ((object)current).get_Item("$jsonObj");
				Set(GetKey(current.get_MetadataItem().get_Uid()), value);
			}
		}
		finally
		{
			((System.IDisposable)enumerator)?.Dispose();
		}
	}

	public System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<RuntimeDataClassModel>> GetFromCache(System.Collections.Generic.IEnumerable<Guid> metadataUidList)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		_003CGetFromCache_003Ed__5 _003CGetFromCache_003Ed__ = default(_003CGetFromCache_003Ed__5);
		_003CGetFromCache_003Ed__._003C_003E4__this = this;
		_003CGetFromCache_003Ed__.metadataUidList = metadataUidList;
		_003CGetFromCache_003Ed__._003C_003Et__builder = AsyncTaskMethodBuilder<System.Collections.Generic.IEnumerable<RuntimeDataClassModel>>.Create();
		_003CGetFromCache_003Ed__._003C_003E1__state = -1;
		AsyncTaskMethodBuilder<System.Collections.Generic.IEnumerable<RuntimeDataClassModel>> _003C_003Et__builder = _003CGetFromCache_003Ed__._003C_003Et__builder;
		_003C_003Et__builder.Start<_003CGetFromCache_003Ed__5>(ref _003CGetFromCache_003Ed__);
		return _003CGetFromCache_003Ed__._003C_003Et__builder.get_Task();
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

	private System.Threading.Tasks.Task<IMetadataUidDifference> GetMetadataUids()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		_003CGetMetadataUids_003Ed__7 _003CGetMetadataUids_003Ed__ = default(_003CGetMetadataUids_003Ed__7);
		_003CGetMetadataUids_003Ed__._003C_003E4__this = this;
		_003CGetMetadataUids_003Ed__._003C_003Et__builder = AsyncTaskMethodBuilder<IMetadataUidDifference>.Create();
		_003CGetMetadataUids_003Ed__._003C_003E1__state = -1;
		AsyncTaskMethodBuilder<IMetadataUidDifference> _003C_003Et__builder = _003CGetMetadataUids_003Ed__._003C_003Et__builder;
		_003C_003Et__builder.Start<_003CGetMetadataUids_003Ed__7>(ref _003CGetMetadataUids_003Ed__);
		return _003CGetMetadataUids_003Ed__._003C_003Et__builder.get_Task();
	}

	private static string GetKey(Guid metadataUid)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		return $"{metadataUid}_{SR.CurrentCulture.get_Name()}";
	}
}
