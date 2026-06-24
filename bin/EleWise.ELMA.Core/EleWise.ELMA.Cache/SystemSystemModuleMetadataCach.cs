using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using EleWise.ELMA.Core;
using EleWise.ELMA.Core.Abstractions.Metadata.Models.UI;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.DTO;
using EleWise.ELMA.Ioc;
using EleWise.ELMA.Model;

namespace EleWise.ELMA.Cache;

[Service]
internal sealed class SystemSystemModuleMetadataCacheService : CacheService, ISystemModuleMetadataCacheService
{
	[StructLayout(3)]
	private struct _003CGetCachedModuleUids_003Ed__4 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<System.Collections.Generic.IEnumerable<Guid>> _003C_003Et__builder;

		public SystemSystemModuleMetadataCacheService _003C_003E4__this;

		private Guid[] _003CcachedGuids_003E5__2;

		private object _003C_003Eu__1;

		private void MoveNext()
		{
			//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			SystemSystemModuleMetadataCacheService systemSystemModuleMetadataCacheService = _003C_003E4__this;
			System.Collections.Generic.IEnumerable<Guid> result;
			try
			{
				TaskAwaiter<string[]> val;
				if (num == 0)
				{
					val = (TaskAwaiter<string[]>)_003C_003Eu__1;
					_003C_003Eu__1 = null;
					num = (_003C_003E1__state = -1);
					goto IL_0084;
				}
				_003CcachedGuids_003E5__2 = (Guid[])(object)new Guid[0];
				if (!systemSystemModuleMetadataCacheService.IsDevServer)
				{
					val = systemSystemModuleMetadataCacheService.GetAllKeys().GetAwaiter();
					if (!val.get_IsCompleted())
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = val;
						_003C_003Et__builder.AwaitOnCompleted<TaskAwaiter<string[]>, _003CGetCachedModuleUids_003Ed__4>(ref val, ref this);
						return;
					}
					goto IL_0084;
				}
				result = _003CcachedGuids_003E5__2;
				goto end_IL_000e;
				IL_0084:
				string[] result2 = val.GetResult();
				foreach (string text in result2)
				{
					ArrayExtensions.Push<Guid>(_003CcachedGuids_003E5__2, (Guid[])(object)new Guid[1] { Guid.Parse(text.Split(new char[1] { '_' })[0]) });
				}
				result = _003CcachedGuids_003E5__2;
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

	private const string StorageName = "SystemModuleMetadataStore";

	protected override string StoreName => "SystemModuleMetadataStore";

	private bool IsDevServer => base.ApplicationData.InterfaceBuilderMode == InterfaceBuilderMode.DevServer;

	public SystemSystemModuleMetadataCacheService(IApplicationData applicationData, ILazy<IExtendEntityService> extendEntityServiceLazy, ILazy<IProxyGeneratorService> proxyGeneratorServiceLazy)
		: base(applicationData, extendEntityServiceLazy, proxyGeneratorServiceLazy)
	{
	}

	public System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<Guid>> GetCachedModuleUids()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		_003CGetCachedModuleUids_003Ed__4 _003CGetCachedModuleUids_003Ed__ = default(_003CGetCachedModuleUids_003Ed__4);
		_003CGetCachedModuleUids_003Ed__._003C_003E4__this = this;
		_003CGetCachedModuleUids_003Ed__._003C_003Et__builder = AsyncTaskMethodBuilder<System.Collections.Generic.IEnumerable<Guid>>.Create();
		_003CGetCachedModuleUids_003Ed__._003C_003E1__state = -1;
		AsyncTaskMethodBuilder<System.Collections.Generic.IEnumerable<Guid>> _003C_003Et__builder = _003CGetCachedModuleUids_003Ed__._003C_003Et__builder;
		_003C_003Et__builder.Start<_003CGetCachedModuleUids_003Ed__4>(ref _003CGetCachedModuleUids_003Ed__);
		return _003CGetCachedModuleUids_003Ed__._003C_003Et__builder.get_Task();
	}

	public System.Threading.Tasks.Task<object[]> GetSerializedModules(System.Collections.Generic.IEnumerable<Guid> guidsToLoad)
	{
		if (IsDevServer)
		{
			return System.Threading.Tasks.Task.FromResult<object[]>(new object[0]);
		}
		return GetValues(Enumerable.Select<Guid, string>(guidsToLoad, (Func<Guid, string>)((Guid g) => GetLocalizedKey(((object)(Guid)(ref g)).ToString()))).ToArray());
	}

	public void Cache(SystemMetadata systemMetadata, Guid uid)
	{
		if (!IsDevServer)
		{
			Set(GetLocalizedKey(((object)(Guid)(ref uid)).ToString()), ((object)systemMetadata).get_Item("$jsonObj"));
		}
	}

	private string GetLocalizedKey(string uid)
	{
		return uid + "_" + SR.CurrentCulture.get_Name();
	}

	private string _003CGetSerializedModules_003Eb__5_0(Guid g)
	{
		return GetLocalizedKey(((object)(Guid)(ref g)).ToString());
	}
}
