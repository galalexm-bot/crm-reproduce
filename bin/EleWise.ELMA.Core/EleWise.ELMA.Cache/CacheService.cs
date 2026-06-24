using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.Core.Helpers;
using EleWise.ELMA.DTO;
using EleWise.ELMA.Ioc;
using EleWise.ELMA.Model;
using EleWise.ELMA.Serialization;

namespace EleWise.ELMA.Cache;

[Component]
public abstract class CacheService : ICacheService
{
	[StructLayout(3)]
	private struct _003CCount_003Ed__11 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<int> _003C_003Et__builder;

		public CacheService _003C_003E4__this;

		private System.Threading.Tasks.Task<object[]> _003Ctask_003E5__2;

		private object _003C_003Eu__1;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			CacheService cacheService = _003C_003E4__this;
			int result;
			try
			{
				if (num == 0)
				{
					goto IL_0027;
				}
				IPromise val = IndexedDBHelper.Count(cacheService.DataBaseName);
				if (val != null)
				{
					goto IL_0027;
				}
				result = -1;
				goto end_IL_000e;
				IL_0027:
				try
				{
					TaskAwaiter<object[]> val2;
					if (num != 0)
					{
						_003Ctask_003E5__2 = System.Threading.Tasks.Task.FromPromise(val);
						val2 = _003Ctask_003E5__2.GetAwaiter();
						if (!val2.get_IsCompleted())
						{
							num = (_003C_003E1__state = 0);
							_003C_003Eu__1 = val2;
							_003C_003Et__builder.AwaitOnCompleted<TaskAwaiter<object[]>, _003CCount_003Ed__11>(ref val2, ref this);
							return;
						}
					}
					else
					{
						val2 = (TaskAwaiter<object[]>)_003C_003Eu__1;
						_003C_003Eu__1 = null;
						num = (_003C_003E1__state = -1);
					}
					val2.GetResult();
					result = (int)_003Ctask_003E5__2.get_Result()[0];
				}
				catch (System.Exception)
				{
					result = -1;
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

	[StructLayout(3)]
	private struct _003CGet_003Ed__12 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<object> _003C_003Et__builder;

		public CacheService _003C_003E4__this;

		public string key;

		private System.Threading.Tasks.Task<object[]> _003Ctask_003E5__2;

		private object _003C_003Eu__1;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			CacheService cacheService = _003C_003E4__this;
			object result;
			try
			{
				if (num == 0)
				{
					goto IL_002d;
				}
				IPromise val = IndexedDBHelper.Get(cacheService.DataBaseName, key);
				if (val != null)
				{
					goto IL_002d;
				}
				result = null;
				goto end_IL_000e;
				IL_002d:
				try
				{
					TaskAwaiter<object[]> val2;
					if (num != 0)
					{
						_003Ctask_003E5__2 = System.Threading.Tasks.Task.FromPromise(val);
						val2 = _003Ctask_003E5__2.GetAwaiter();
						if (!val2.get_IsCompleted())
						{
							num = (_003C_003E1__state = 0);
							_003C_003Eu__1 = val2;
							_003C_003Et__builder.AwaitOnCompleted<TaskAwaiter<object[]>, _003CGet_003Ed__12>(ref val2, ref this);
							return;
						}
					}
					else
					{
						val2 = (TaskAwaiter<object[]>)_003C_003Eu__1;
						_003C_003Eu__1 = null;
						num = (_003C_003E1__state = -1);
					}
					val2.GetResult();
					result = _003Ctask_003E5__2.get_Result()[0];
				}
				catch (System.Exception)
				{
					result = null;
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

	[StructLayout(3)]
	private struct _003CGetAllKeys_003Ed__13 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<string[]> _003C_003Et__builder;

		public CacheService _003C_003E4__this;

		private System.Threading.Tasks.Task<object[]> _003Ctask_003E5__2;

		private object _003C_003Eu__1;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			CacheService cacheService = _003C_003E4__this;
			string[] result;
			try
			{
				if (num == 0)
				{
					goto IL_002c;
				}
				IPromise allKeys = IndexedDBHelper.GetAllKeys(cacheService.DataBaseName);
				if (allKeys != null)
				{
					goto IL_002c;
				}
				result = new string[0];
				goto end_IL_000e;
				IL_002c:
				try
				{
					TaskAwaiter<object[]> val;
					if (num != 0)
					{
						_003Ctask_003E5__2 = System.Threading.Tasks.Task.FromPromise(allKeys);
						val = _003Ctask_003E5__2.GetAwaiter();
						if (!val.get_IsCompleted())
						{
							num = (_003C_003E1__state = 0);
							_003C_003Eu__1 = val;
							_003C_003Et__builder.AwaitOnCompleted<TaskAwaiter<object[]>, _003CGetAllKeys_003Ed__13>(ref val, ref this);
							return;
						}
					}
					else
					{
						val = (TaskAwaiter<object[]>)_003C_003Eu__1;
						_003C_003Eu__1 = null;
						num = (_003C_003E1__state = -1);
					}
					val.GetResult();
					result = (string[])_003Ctask_003E5__2.get_Result()[0];
				}
				catch (System.Exception)
				{
					result = new string[0];
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

	[StructLayout(3)]
	private struct _003CGetValues_003Ed__14 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<object[]> _003C_003Et__builder;

		public CacheService _003C_003E4__this;

		private System.Threading.Tasks.Task<object[]> _003Ctask_003E5__2;

		private object _003C_003Eu__1;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			CacheService cacheService = _003C_003E4__this;
			object[] result;
			try
			{
				if (num == 0)
				{
					goto IL_002c;
				}
				IPromise values = IndexedDBHelper.GetValues(cacheService.DataBaseName);
				if (values != null)
				{
					goto IL_002c;
				}
				result = new object[0];
				goto end_IL_000e;
				IL_002c:
				try
				{
					TaskAwaiter<object[]> val;
					if (num != 0)
					{
						_003Ctask_003E5__2 = System.Threading.Tasks.Task.FromPromise(values);
						val = _003Ctask_003E5__2.GetAwaiter();
						if (!val.get_IsCompleted())
						{
							num = (_003C_003E1__state = 0);
							_003C_003Eu__1 = val;
							_003C_003Et__builder.AwaitOnCompleted<TaskAwaiter<object[]>, _003CGetValues_003Ed__14>(ref val, ref this);
							return;
						}
					}
					else
					{
						val = (TaskAwaiter<object[]>)_003C_003Eu__1;
						_003C_003Eu__1 = null;
						num = (_003C_003E1__state = -1);
					}
					val.GetResult();
					result = (object[])_003Ctask_003E5__2.get_Result()[0];
				}
				catch (System.Exception)
				{
					result = new object[0];
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

	[StructLayout(3)]
	private struct _003CGetValues_003Ed__15 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<object[]> _003C_003Et__builder;

		public string[] keys;

		public CacheService _003C_003E4__this;

		private System.Threading.Tasks.Task<object[]> _003Ctask_003E5__2;

		private object _003C_003Eu__1;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			CacheService cacheService = _003C_003E4__this;
			object[] result;
			try
			{
				if (num == 0)
				{
					goto IL_0047;
				}
				IPromise values = default(IPromise);
				if (keys.Length == 0)
				{
					result = new object[0];
				}
				else
				{
					values = IndexedDBHelper.GetValues(cacheService.DataBaseName, keys);
					if (values != null)
					{
						goto IL_0047;
					}
					result = new object[0];
				}
				goto end_IL_000e;
				IL_0047:
				try
				{
					TaskAwaiter<object[]> val;
					if (num != 0)
					{
						_003Ctask_003E5__2 = System.Threading.Tasks.Task.FromPromise(values);
						val = _003Ctask_003E5__2.GetAwaiter();
						if (!val.get_IsCompleted())
						{
							num = (_003C_003E1__state = 0);
							_003C_003Eu__1 = val;
							_003C_003Et__builder.AwaitOnCompleted<TaskAwaiter<object[]>, _003CGetValues_003Ed__15>(ref val, ref this);
							return;
						}
					}
					else
					{
						val = (TaskAwaiter<object[]>)_003C_003Eu__1;
						_003C_003Eu__1 = null;
						num = (_003C_003E1__state = -1);
					}
					val.GetResult();
					result = (object[])_003Ctask_003E5__2.get_Result()[0];
				}
				catch (System.Exception)
				{
					result = new object[0];
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

	private readonly ILazy<IExtendEntityService> extendEntityServiceLazy;

	private readonly ILazy<IProxyGeneratorService> proxyGeneratorServiceLazy;

	private ConvertContext context;

	private readonly IApplicationData _003CApplicationData_003Ek__BackingField;

	protected IApplicationData ApplicationData => _003CApplicationData_003Ek__BackingField;

	protected abstract string StoreName { get; }

	protected ConvertContext ConvertContext
	{
		get
		{
			ConvertContext convertContext = context;
			if (convertContext == null)
			{
				ConvertContext obj = new ConvertContext
				{
					ExtendEntityService = extendEntityServiceLazy.Value(),
					ProxyGeneratorService = proxyGeneratorServiceLazy.Value()
				};
				ConvertContext convertContext2 = obj;
				context = obj;
				convertContext = convertContext2;
			}
			return convertContext;
		}
	}

	private string DataBaseName => "ELMA_" + StoreName;

	public CacheService(IApplicationData applicationData, ILazy<IExtendEntityService> extendEntityServiceLazy, ILazy<IProxyGeneratorService> proxyGeneratorServiceLazy)
	{
		_003CApplicationData_003Ek__BackingField = applicationData;
		this.extendEntityServiceLazy = extendEntityServiceLazy;
		this.proxyGeneratorServiceLazy = proxyGeneratorServiceLazy;
	}

	public void Clear()
	{
		IndexedDBHelper.Clear(DataBaseName);
	}

	public void Remove(string key)
	{
		IndexedDBHelper.Remove(DataBaseName, key);
	}

	public System.Threading.Tasks.Task<int> Count()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		_003CCount_003Ed__11 _003CCount_003Ed__ = default(_003CCount_003Ed__11);
		_003CCount_003Ed__._003C_003E4__this = this;
		_003CCount_003Ed__._003C_003Et__builder = AsyncTaskMethodBuilder<int>.Create();
		_003CCount_003Ed__._003C_003E1__state = -1;
		AsyncTaskMethodBuilder<int> _003C_003Et__builder = _003CCount_003Ed__._003C_003Et__builder;
		_003C_003Et__builder.Start<_003CCount_003Ed__11>(ref _003CCount_003Ed__);
		return _003CCount_003Ed__._003C_003Et__builder.get_Task();
	}

	public System.Threading.Tasks.Task<object> Get(string key)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		_003CGet_003Ed__12 _003CGet_003Ed__ = default(_003CGet_003Ed__12);
		_003CGet_003Ed__._003C_003E4__this = this;
		_003CGet_003Ed__.key = key;
		_003CGet_003Ed__._003C_003Et__builder = AsyncTaskMethodBuilder<object>.Create();
		_003CGet_003Ed__._003C_003E1__state = -1;
		AsyncTaskMethodBuilder<object> _003C_003Et__builder = _003CGet_003Ed__._003C_003Et__builder;
		_003C_003Et__builder.Start<_003CGet_003Ed__12>(ref _003CGet_003Ed__);
		return _003CGet_003Ed__._003C_003Et__builder.get_Task();
	}

	public System.Threading.Tasks.Task<string[]> GetAllKeys()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		_003CGetAllKeys_003Ed__13 _003CGetAllKeys_003Ed__ = default(_003CGetAllKeys_003Ed__13);
		_003CGetAllKeys_003Ed__._003C_003E4__this = this;
		_003CGetAllKeys_003Ed__._003C_003Et__builder = AsyncTaskMethodBuilder<string[]>.Create();
		_003CGetAllKeys_003Ed__._003C_003E1__state = -1;
		AsyncTaskMethodBuilder<string[]> _003C_003Et__builder = _003CGetAllKeys_003Ed__._003C_003Et__builder;
		_003C_003Et__builder.Start<_003CGetAllKeys_003Ed__13>(ref _003CGetAllKeys_003Ed__);
		return _003CGetAllKeys_003Ed__._003C_003Et__builder.get_Task();
	}

	public System.Threading.Tasks.Task<object[]> GetValues()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		_003CGetValues_003Ed__14 _003CGetValues_003Ed__ = default(_003CGetValues_003Ed__14);
		_003CGetValues_003Ed__._003C_003E4__this = this;
		_003CGetValues_003Ed__._003C_003Et__builder = AsyncTaskMethodBuilder<object[]>.Create();
		_003CGetValues_003Ed__._003C_003E1__state = -1;
		AsyncTaskMethodBuilder<object[]> _003C_003Et__builder = _003CGetValues_003Ed__._003C_003Et__builder;
		_003C_003Et__builder.Start<_003CGetValues_003Ed__14>(ref _003CGetValues_003Ed__);
		return _003CGetValues_003Ed__._003C_003Et__builder.get_Task();
	}

	public System.Threading.Tasks.Task<object[]> GetValues(string[] keys)
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		_003CGetValues_003Ed__15 _003CGetValues_003Ed__ = default(_003CGetValues_003Ed__15);
		_003CGetValues_003Ed__._003C_003E4__this = this;
		_003CGetValues_003Ed__.keys = keys;
		_003CGetValues_003Ed__._003C_003Et__builder = AsyncTaskMethodBuilder<object[]>.Create();
		_003CGetValues_003Ed__._003C_003E1__state = -1;
		AsyncTaskMethodBuilder<object[]> _003C_003Et__builder = _003CGetValues_003Ed__._003C_003Et__builder;
		_003C_003Et__builder.Start<_003CGetValues_003Ed__15>(ref _003CGetValues_003Ed__);
		return _003CGetValues_003Ed__._003C_003Et__builder.get_Task();
	}

	public void Set(string key, object value)
	{
		IndexedDBHelper.Put(DataBaseName, key, value);
	}
}
