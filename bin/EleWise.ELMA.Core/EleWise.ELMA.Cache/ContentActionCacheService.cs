using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using EleWise.ELMA.Core.Abstractions.Metadata.Models;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.DTO;
using EleWise.ELMA.Ioc;
using EleWise.ELMA.Model;
using EleWise.ELMA.Serialization;

namespace EleWise.ELMA.Cache;

[Service]
internal sealed class ContentActionCacheService : CacheService, IContentActionCacheService
{
	[StructLayout(3)]
	private struct _003CGetFromCache_003Ed__6 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<System.Collections.Generic.IEnumerable<ContentAction>> _003C_003Et__builder;

		public ContentActionCacheService _003C_003E4__this;

		private ContentAction[] _003CcachedActions_003E5__2;

		private object _003C_003Eu__1;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			ContentActionCacheService contentActionCacheService = _003C_003E4__this;
			System.Collections.Generic.IEnumerable<ContentAction> result;
			try
			{
				TaskAwaiter<object[]> val;
				if (num == 0)
				{
					val = (TaskAwaiter<object[]>)_003C_003Eu__1;
					_003C_003Eu__1 = null;
					num = (_003C_003E1__state = -1);
					goto IL_0084;
				}
				_003CcachedActions_003E5__2 = (ContentAction[])(object)new ContentAction[0];
				if (!contentActionCacheService.IsDevServer)
				{
					val = contentActionCacheService.GetValues().GetAwaiter();
					if (!val.get_IsCompleted())
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = val;
						_003C_003Et__builder.AwaitOnCompleted<TaskAwaiter<object[]>, _003CGetFromCache_003Ed__6>(ref val, ref this);
						return;
					}
					goto IL_0084;
				}
				result = _003CcachedActions_003E5__2;
				goto end_IL_000e;
				IL_0084:
				object[] result2 = val.GetResult();
				foreach (object value in result2)
				{
					object obj = ConvertHelper.DeserializeWithType(typeof(ContentAction), value, contentActionCacheService.ConvertContext);
					ContentAction val2 = (ContentAction)((obj is ContentAction) ? obj : null);
					ArrayExtensions.Push<ContentAction>(_003CcachedActions_003E5__2, (ContentAction[])(object)new ContentAction[1] { val2 });
				}
				result = _003CcachedActions_003E5__2;
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

	private const string StorageName = "ContentActionStore";

	private readonly SerializationSettings settings = new SerializationSettings
	{
		Mode = SerializationMode.FullWithInit,
		WriteReferences = true
	};

	protected override string StoreName => "ContentActionStore";

	private bool IsDevServer => base.ApplicationData.InterfaceBuilderMode == InterfaceBuilderMode.DevServer;

	public ContentActionCacheService(IApplicationData applicationData, ILazy<IExtendEntityService> extendEntityServiceLazy, ILazy<IProxyGeneratorService> proxyGeneratorServiceLazy)
		: base(applicationData, extendEntityServiceLazy, proxyGeneratorServiceLazy)
	{
	}

	public void Cache(System.Collections.Generic.IEnumerable<ContentAction> contentActions)
	{
		if (IsDevServer)
		{
			return;
		}
		System.Collections.Generic.IEnumerator<ContentAction> enumerator = contentActions.GetEnumerator();
		try
		{
			while (((System.Collections.IEnumerator)enumerator).MoveNext())
			{
				ContentAction current = enumerator.get_Current();
				object value = ConvertHelper.Serialize(current, settings);
				Set(current.get_Id(), value);
			}
		}
		finally
		{
			((System.IDisposable)enumerator)?.Dispose();
		}
	}

	public System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<ContentAction>> GetFromCache()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		_003CGetFromCache_003Ed__6 _003CGetFromCache_003Ed__ = default(_003CGetFromCache_003Ed__6);
		_003CGetFromCache_003Ed__._003C_003E4__this = this;
		_003CGetFromCache_003Ed__._003C_003Et__builder = AsyncTaskMethodBuilder<System.Collections.Generic.IEnumerable<ContentAction>>.Create();
		_003CGetFromCache_003Ed__._003C_003E1__state = -1;
		AsyncTaskMethodBuilder<System.Collections.Generic.IEnumerable<ContentAction>> _003C_003Et__builder = _003CGetFromCache_003Ed__._003C_003Et__builder;
		_003C_003Et__builder.Start<_003CGetFromCache_003Ed__6>(ref _003CGetFromCache_003Ed__);
		return _003CGetFromCache_003Ed__._003C_003Et__builder.get_Task();
	}
}
